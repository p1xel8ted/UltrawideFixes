using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace SeaOfStars;

[Harmony]
public static class Patches
{
    //credits Rose
    internal static void CamFix(Camera cam)
    {
        if (cam.targetTexture == null) return;
        
        var targetTexture = cam.targetTexture;
        var descriptor = targetTexture.descriptor;
        if (descriptor.width == Display.main.systemWidth) return;
        descriptor.width = Display.main.systemWidth;
        descriptor.height = Display.main.systemHeight;
        var renderTexture = new RenderTexture(descriptor)
        {
            filterMode = targetTexture.filterMode,
            name = targetTexture.name
        };
        cam.targetTexture = renderTexture;
        if (cam.targetTexture == renderTexture)
        {
            targetTexture.Release();
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
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow,
            ultrawide.refreshRate);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.OnEnable))]
    [HarmonyPatch(typeof(LocalInventoryPanel), nameof(LocalInventoryPanel.InitIcons))]
    public static void LocalInventoryPanel_OnEnable(ref LocalInventoryPanel __instance)
    {
        //disables the random square on the top right of the UI
        __instance.gameObject.SetActive(false);
    }
}