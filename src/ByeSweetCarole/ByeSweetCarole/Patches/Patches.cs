using ByeSweetCarole.Misc;

namespace ByeSweetCarole.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];


    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Mod.MainAspect > Mod.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionMenuHandler), nameof(OptionMenuHandler.OnEnable))]
    public static void OptionMenuHandler_OnEnable(OptionMenuHandler __instance)
    {
        var bg = __instance.transform.FindChild("bkg");
        if (bg)
        {
            var arf = bg.gameObject.TryAddComponent<AspectRatioFitter>();
            arf.aspectRatio = Mod.NativeAspectRatio;
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        if (__instance.renderMode == VideoRenderMode.RenderTexture &&
            __instance.targetTexture &&
            __instance.targetTexture.width != Mod.NativeDisplayWidth)
        {
            var tex = __instance.targetTexture;
            tex.Release();
            tex.width = Mod.NativeDisplayWidth;
            tex.height = Mod.NativeDisplayHeight;
            tex.Create();
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioBlackBarHandler), nameof(AspectRatioBlackBarHandler.Start))]
    public static void AspectRatioBlackBarHandler_Start(AspectRatioBlackBarHandler __instance)
    {
        __instance.enabled = false;
        __instance._down.gameObject.SetActive(false);
        __instance._up.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }
}