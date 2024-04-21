namespace ArtifactSeekerTweaks;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingPanelUI_Quality), nameof(SettingPanelUI_Quality.Start))]
    public static void SettingPanelUI_Quality_Start(ref SettingPanelUI_Quality __instance)
    {
        __instance.frameRateSlider.minValue = Plugin.MaxRefresh;
        __instance.frameRateSlider.value = Plugin.MaxRefresh;
        __instance.frameRateSlider.maxValue = Plugin.MaxRefresh;
    }
}