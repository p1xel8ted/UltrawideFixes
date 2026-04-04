namespace LegacyOfKainAscendance;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    // --- Resolution enforcement ---

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_One(ref int width, ref int height)
    {
        Plugin.Log.LogInfo($"Screen.SetResolution intercepted: {width}x{height} -> {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}");
        Utils.ApplyMainResolution(ref width, ref height);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        Plugin.Log.LogInfo($"Screen.SetResolution intercepted: {width}x{height} {fullscreenMode} -> {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight} FullScreenWindow");
        Utils.ApplyMainResolutionAndFullscreen(ref width, ref height, ref fullscreenMode);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
    public static void Screen_SetFullScreenMode(ref FullScreenMode value)
    {
        if (value != FullScreenMode.FullScreenWindow)
        {
            Plugin.Log.LogInfo($"Screen.fullScreenMode intercepted: {value} -> FullScreenWindow");
        }
        value = FullScreenMode.FullScreenWindow;
    }

    // --- UI scaling ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
        {
            Plugin.Log.LogInfo($"CanvasScaler '{__instance.name}': screenMatchMode {__instance.screenMatchMode} -> Expand");
        }
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    // --- SidescrollingCamera: fix hardcoded 16:9 aspect in camera width calculation ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SidescrollingCamera), nameof(SidescrollingCamera.GetCamWidth))]
    public static void SidescrollingCamera_GetCamWidth(float screenHeight, ref float __result)
    {
        if (!DisplayMetrics.IsWiderThanNative) return;

        var original = __result;
        __result = screenHeight * DisplayMetrics.MainAspect;
        Plugin.Log.LogInfo($"SidescrollingCamera.GetCamWidth: {original:F2} -> {__result:F2} (screenHeight={screenHeight:F2}, aspect={DisplayMetrics.MainAspect:F4})");
    }

    // --- Run in background: prevent input blocking on focus loss ---
    // ApplicationFocusInputGate aggressively disables all input when unfocused.
    // We prevent it from ever entering the blocked state.

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ApplicationFocusInputGate), nameof(ApplicationFocusInputGate.RefreshBlockState))]
    public static bool ApplicationFocusInputGate_RefreshBlockState(ApplicationFocusInputGate __instance)
    {
        if (!Plugin.RunInBackground.Value) return true;

        if (__instance.isBlocked)
        {
            __instance.UnblockInput();
        }
        return false;
    }

    // --- Intro skip: bypass logos, videos, and warnings ---
    // LogoSequence.PlaySequence runs after save data + localization are loaded.
    // We skip the visual sequence and jump directly to FMOD preload + scene load.

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LogoSequence), nameof(LogoSequence.PlaySequence))]
    public static bool LogoSequence_PlaySequence(LogoSequence __instance)
    {
        if (!Plugin.SkipIntros.Value) return true;

        Plugin.Log.LogInfo("Skipping intro sequence, loading next scene...");
        __instance.StopAllCoroutines();
        __instance.StartCoroutine(__instance.PreloadFmodAndLoadNextScene());
        return false;
    }
}
