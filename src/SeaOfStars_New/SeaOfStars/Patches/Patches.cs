namespace SeaOfStars;

[Harmony]
public static class Patches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.OnEnable))]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.Show))]
    public static void LocalInventoryPanel_OnEnable(ref LocalInventoryPanel __instance)
    {
        var go = __instance.transform.FindChild("GenericBackground");
        if (go)
        {
            go.gameObject.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.RefreshResolutionList))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.CheckToUpdateResolutionList))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.UpdateVideoSettings))]
    public static void OptionsScreen_Awake(ref OptionsScreen __instance)
    {
        //makes the main display resolution the only available
        __instance.pixelPerfectBtn.IsEnabled = false;
        __instance.pixelPerfectBtn.selectedIdx = 1;
        __instance.fullscreenBtn.selectedIdx = 1;
        __instance.fullscreenBtn.IsEnabled = false;
        __instance.resolutionBtn.IsEnabled = false;
        var ultrawide = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };

        var newResList = new Il2CppSystem.Collections.Generic.List<Resolution>();
        newResList.Add(ultrawide);

        __instance.resolutions = newResList;
        Plugin.SetResolution();
    }
}