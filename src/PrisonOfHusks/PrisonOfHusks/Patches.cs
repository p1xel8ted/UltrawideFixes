namespace PrisonOfHusks;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_One(ref int width, ref int height)
    {
        Utils.ApplyMainResolution(ref width, ref height);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        Utils.ApplyMainResolutionAndFullscreen(ref width, ref height, ref fullscreenMode);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
    public static void Screen_SetFullScreenMode(ref FullScreenMode value)
    {
        value = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.fieldOfView), MethodType.Setter)]
    public static void Camera_fieldOfView_Set(Camera __instance, ref float value)
    {
        if (Plugin.AdditionalFov == null || Mathf.Approximately(Plugin.AdditionalFov.Value, 0f)) return;
        if (__instance != Camera.main) return;

        value += Plugin.AdditionalFov.Value;
    }
}
