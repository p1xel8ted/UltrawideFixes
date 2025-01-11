namespace xRESIST;

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
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //if target is a camera
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        //if target is a render texture
        if (__instance.targetTexture && Plugin.MainAspectRatio > Plugin.NativeAspect)
        {
            var rawImage = __instance.GetComponent<RawImage>();
            if (rawImage)
            {
                rawImage.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
            }
        }
    }
}