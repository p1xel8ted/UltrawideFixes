using UnityEngine.UI;
using UnityEngine.Video;

namespace Gift;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Handle(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.Start))]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_Start(AspectRatioFitter __instance)
    {
        __instance.aspectRatio = Plugin.MainAspectRatio;
        __instance.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_Handle(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        __instance.uiScaleMode = Plugin.ScaleMode.Value;
        __instance.screenMatchMode = Plugin.ScreenMatchMode.Value;
        if (__instance.uiScaleMode is CanvasScaler.ScaleMode.ScaleWithScreenSize) return;
        __instance.scaleFactor = Plugin.ScaleFactor.Value;
        __instance.SetScaleFactor(Plugin.ScaleFactor.Value);
    }
    

}