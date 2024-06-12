namespace LifeIsStrangeBTSR;

[Harmony]
public static class Patches
{
    private readonly static Dictionary<string, float> _cameraFovs = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ButtonTweener), nameof(ButtonTweener.OnClick))]
    public static void ButtonTweener_OnClick(ButtonTweener __instance)
    {
        if (__instance.name.Contains("apply", StringComparison.OrdinalIgnoreCase))
        {
            Plugin.UpdateDisplay();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.ResetDefaults))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.RestorePriorToDefaultsValues))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.RevertResolutions))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.ApplyResolution))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.ApplyConfirmed))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.ApplyCanceled))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.ApplyPressed))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.BackCanceled))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.BackConfirmed))]
    [HarmonyPatch(typeof(AdvancedVideoUI.RenderSettings), nameof(AdvancedVideoUI.RenderSettings.SetScreenResolution))]
    public static void AdvancedVideoUI_RenderSettings_SetResolution()
    {
        Plugin.UpdateDisplay();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.SetVSyncOff))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.SetVSyncOn))]
    [HarmonyPatch(typeof(DawnSettingsManager.RenderSettingsManager), nameof(DawnSettingsManager.RenderSettingsManager.SetVSync))]
    [HarmonyPatch(typeof(DawnSettingsManager.RenderSettingsManager), nameof(DawnSettingsManager.RenderSettingsManager.SetVSyncNow))]
    public static void AdvancedVideoUI_SetVSync(AdvancedVideoUI __instance)
    {
        Plugin.UpdateDisplay();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.Setup))]
    [HarmonyPatch(typeof(AdvancedVideoUI), nameof(AdvancedVideoUI.LoadAdvancedSettings))]
    public static void AdvancedVideoUI_Show(AdvancedVideoUI __instance)
    {
        __instance.m_VSyncUI.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashScreenWindow), nameof(SplashScreenWindow.Awake))]
    [HarmonyPatch(typeof(SplashScreenWindow), nameof(SplashScreenWindow.GetSplashNext))]
    [HarmonyPatch(typeof(SplashScreenWindow), nameof(SplashScreenWindow.StartSplash))]
    public static void SplashScreenWindow_Patches(SplashScreenWindow __instance)
    {
        Plugin.UpdateDisplay();

        __instance.m_continue = true;
        __instance.m_fadeTime = 0;
        __instance.m_transitionTime = 0;
        __instance.m_splashScreenTime = 0;
        __instance.m_waitStepTime = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), "set_fieldOfView")]
    public static void PrefixSetFieldOfView(Camera __instance, ref float value)
    {
        if (__instance.name.Contains("MainMenu", StringComparison.OrdinalIgnoreCase)) return;
        _cameraFovs[__instance.name] = value;
        var pct = Plugin.FieldOfView.Value / 100f;
        var newFov = value + value * pct;
        value = newFov;
    }

    internal static void UpdateCamerasFoV()
    {
        var cameras = Utils.FindIl2CppType<Camera>();
        foreach (var camera in cameras.Where(camera => !camera.name.Contains("MainMenu", StringComparison.OrdinalIgnoreCase)))
        {
            if (_cameraFovs.TryGetValue(camera.name, out var fov))
            {
                //we don't actually need to include the pct calcs, as the prefix patch will do it
                camera.fieldOfView = fov;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AdvancedVideoUI.RenderSettings), nameof(AdvancedVideoUI.RenderSettings.GenerateResolutions))]
    public static void RenderSettings_GenerateResolutions(ref AdvancedVideoUI.RenderSettings __instance)
    {
        var myRes = new Resolution
        {
            width = Plugin.MainWidth,
            height = Plugin.MainHeight,
            refreshRate = Plugin.MaxRefresh
        };

        __instance.m_resolutions.Clear();
        __instance.m_resolutions.Add(myRes);
        __instance.m_resolutions.Add(myRes);
        __instance.m_resolutions.Add(myRes);

        __instance.m_resolutionsAsString.Clear();
        __instance.m_resolutionsAsString.Add($"{myRes.width}x{myRes.height}");
        __instance.m_resolutionsAsString.Add($"{myRes.width}x{myRes.height}");
        __instance.m_resolutionsAsString.Add($"{myRes.width}x{myRes.height}");

        __instance.m_currentResolution = myRes;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}