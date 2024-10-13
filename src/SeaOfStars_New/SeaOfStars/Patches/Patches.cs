// Patches.cs

using SeaOfStars.Managers;

namespace SeaOfStars;

[Harmony]
public static class Patches
{
    // Patching LocalInventoryPanel.OnEnable and LocalInventoryPanel.Show
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.OnEnable))]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.Show))]
    public static void LocalInventoryPanel_OnEnable(LocalInventoryPanel __instance)
    {
        var go = __instance.transform.Find("GenericBackground");
        if (go != null)
        {
            go.gameObject.SetActive(false);
        }
    }

    // Patching OptionsScreen.RefreshResolutionList, OptionsScreen.CheckToUpdateResolutionList, and OptionsScreen.UpdateVideoSettings
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.RefreshResolutionList))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.CheckToUpdateResolutionList))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.UpdateVideoSettings))]
    public static void OptionsScreen_Awake(OptionsScreen __instance)
    {
        // Makes the main display resolution the only available
        __instance.pixelPerfectBtn.IsEnabled = false;
        __instance.pixelPerfectBtn.selectedIdx = 1;
        __instance.fullscreenBtn.selectedIdx = 1;
        __instance.fullscreenBtn.IsEnabled = false;
        __instance.resolutionBtn.IsEnabled = false;

        var ultrawide = new Resolution
        {
            width = DisplayManager.MainWidth,
            height = DisplayManager.MainHeight,
            refreshRate = DisplayManager.MaxRefresh
        };

        var newResList = new Il2CppSystem.Collections.Generic.List<Resolution>();
        newResList.Add(ultrawide);
        
        __instance.resolutions = newResList;

        DisplayManager.SetResolution();
    }
}