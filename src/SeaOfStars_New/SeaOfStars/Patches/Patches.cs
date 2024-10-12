using Iced.Intel;
using UnityEngine.Experimental.Rendering.Universal;

namespace SeaOfStars;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
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
    [HarmonyPatch(typeof(CanvasUpscaleViewport), nameof(CanvasUpscaleViewport.OnEnable))]
    public static void CanvasUpscaleViewport_OnEnable(ref CanvasUpscaleViewport __instance)
    {
        __instance.useCustomCanvasSize = true;
        __instance.customCanvasPos = new Vector2(180, 0);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(ref PixelPerfectCamera __instance)
    {
        __instance.cropFrameX = false;
        ExcludeUnityExplorerFromPixelPerfect(__instance);
    }


    private static void ExcludeUnityExplorerFromPixelPerfect(PixelPerfectCamera pixelPerfectCamera)
    {
        // Find UnityExplorer canvases or other objects
        var allCanvases = Utils.FindIl2CppType<Canvas>();
        int nonPixelPerfectLayer = LayerMask.NameToLayer("NonPixelPerfect");

        // If the layer does not exist, use a default one (e.g., Layer 8)
        if (nonPixelPerfectLayer == -1) nonPixelPerfectLayer = 30;

        // Move UnityExplorer objects to this layer
        foreach (var canvas in allCanvases)
        {
            if (canvas.name.Contains("UnityExplorer", StringComparison.OrdinalIgnoreCase) || canvas.name.Contains("sinai", StringComparison.OrdinalIgnoreCase) || canvas.name.Contains("universe", StringComparison.OrdinalIgnoreCase))
            {
                canvas.gameObject.layer = nonPixelPerfectLayer;
                Plugin.Logger.LogWarning($"Moved UnityExplorer Canvas: {canvas.name} to layer {nonPixelPerfectLayer}");
            }
        }

        // Exclude the "NonPixelPerfect" layer from the Pixel Perfect Camera's culling mask
        int nonPixelPerfectLayerMask = 1 << nonPixelPerfectLayer;
        pixelPerfectCamera.GetComponent<Camera>().cullingMask &= ~nonPixelPerfectLayerMask;
    }

    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    // public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    // {
    //     __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
    // }
}