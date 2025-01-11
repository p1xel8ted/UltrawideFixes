namespace Snufkin;

[Harmony]
public static class Patches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnRectTransformDimensionsChange))]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnTransformParentChanged))]
    public static void AspectRatioFitter_Patches(AspectRatioFitter __instance)
    {
        __instance.aspectRatio = Plugin.MainAspectRatio;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Patches(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraRatioRestrictor), nameof(CameraRatioRestrictor.Start))]
    [HarmonyPatch(typeof(CameraRatioRestrictor), nameof(CameraRatioRestrictor.OnAspectChanged))]
    public static void CameraRatioRestrictor_Patches(CameraRatioRestrictor __instance)
    {
        __instance._camAspect = Plugin.MainAspectRatio;
        __instance._screenHeight = Plugin.MainHeight;
        __instance._screenWidth = Plugin.MainWidth;
        __instance._maxRatioLandscape = Plugin.SimplifiedMainAspect;
        __instance._showPillar = false;
        __instance._camScreenHeight = Plugin.MainHeight;
        __instance._camScreenWidth = Plugin.MainWidth;
    }
}