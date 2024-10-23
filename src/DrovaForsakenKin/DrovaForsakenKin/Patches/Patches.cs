// ReSharper disable Unity.IncorrectMonoBehaviourInstantiation

namespace DrovaForsakenKin.Patches;

[Harmony]
public static class Patches
{
    internal static PixelPerfectCamera MainMenuCamera { get; private set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //if target is a camera
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        //if target is a render texture
        if (__instance.targetTexture)
        {
            var rawImage = __instance.GetComponent<RawImage>();
            if (rawImage)
            {
                rawImage.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelCamBhvr), nameof(PixelCamBhvr.OnEnable))]
    public static void PixelCamBhvr_OnEnable(PixelCamBhvr __instance)
    {
        var pp = __instance.GetComponent<PixelPerfectCamera>();
        UpdatePixelPerfectCamera(pp);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CamWideSupport), nameof(CamWideSupport.Start))]
    public static void CamWideSupport_OnEnable(CamWideSupport __instance)
    {
        var pp = __instance.GetComponent<PixelPerfectCamera>();
        UpdatePixelPerfectCamera(pp);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GUI_HUD), nameof(GUI_HUD.Start))]
    public static void GUI_HUD_Start(GUI_HUD __instance)
    {
        var scalers = __instance.GetComponentsInChildren<CanvasScaler>();
        foreach (var scaler in scalers)
        {
            scaler.scaleFactor = Plugin.UIScale.Value;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        UpdatePixelPerfectCamera(__instance);
    }

    private static void UpdatePixelPerfectCamera(PixelPerfectCamera pp)
    {
        pp.cropFrameX = false;
        pp.cropFrameY = false;
        pp.refResolutionX = Mathf.RoundToInt(pp.refResolutionY * Plugin.MainAspect);
        pp.cropFrame = PixelPerfectCamera.CropFrame.None;
        if (pp.name == "WorldCam_Extra")
        {
            MainMenuCamera = pp;
            if (Plugin.ConstrainMainMenu.Value)
            {
                pp.cropFrame = PixelPerfectCamera.CropFrame.Pillarbox;
            }
        }
      
    }
}