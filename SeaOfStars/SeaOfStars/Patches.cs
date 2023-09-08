using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace SeaOfStars;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.RefreshResolutionList))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.CheckToUpdateResolutionList))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.UpdateVideoSettings))]
    public static void OptionsScreen_Awake(ref OptionsScreen __instance)
    {
        __instance.pixelPerfectBtn.selectedIdx = 1;
        __instance.fullscreenBtn.selectedIdx = 1;
        __instance.pixelPerfectBtn.IsEnabled = false;
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
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow,
            ultrawide.refreshRate);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.OnEnable))]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.InitIcons))]
    public static void LocalInventoryPanel_OnEnable(ref LocalInventoryPanel __instance)
    {
        __instance.gameObject.SetActive(false);
    }
}