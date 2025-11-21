namespace CARIMARA_BTFL.Patches;

[Harmony]
public static class UIComponentPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.Awake))]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.Init))]
    public static void SettingsManager_OnEnable(SettingsManager __instance)
    {
        if (__instance.m_Cache)
        {
            var arf = __instance.m_Cache.TryAddComponent<AspectRatioFitter>();
            arf.aspectRatio = ResolutionManager.NativeAspect;
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceResolution), nameof(ForceResolution.Start))]
    public static void ForceResolution_Start(ForceResolution __instance)
    {
        __instance.desiredFPS = ResolutionManager.RefreshRateValue;
        __instance.width = ResolutionManager.SelectedResolution.width;
        __instance.height = ResolutionManager.SelectedResolution.height;
    }
}