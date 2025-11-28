namespace Constance;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const string SinaiFilterName = "sinai";
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        if (__instance.renderMode == VideoRenderMode.RenderTexture &&
            __instance.targetTexture &&
            __instance.targetTexture.width != Plugin.CurrentWidth)
        {
            var tex = __instance.targetTexture;
            tex.Release();
            tex.width = Plugin.CurrentWidth;
            tex.height = Plugin.CurrentHeight;
            tex.Create();
        }
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CConStartMenu), nameof(CConStartMenu.Start))]
    public static void CConStartMenu_Start()
    {
        ConStaticFlags.ShowSplashScreen = false;
        Plugin.Log.LogInfo("Skipping splash screen");
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConUiPanel_Journal), nameof(CConUiPanel_Journal.Awake))]
    public static void CConUiPanel_Journal_Awake(CConUiPanel_Journal __instance)
    {
        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = Plugin.NativeAspect;

        var bgImage = __instance.transform.Find("Journal_Base");
        if (bgImage)
        {
            var arfBg = bgImage.gameObject.TryAddComponent<AspectRatioFitter>();
            arfBg.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arfBg.aspectRatio = Plugin.CurrentAspect;

            var newPos = 1080 * Plugin.CurrentAspect; //1080 * 2.38889 = 2580
            bgImage.localPosition = bgImage.localPosition with { x = -newPos };
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConEnforceAspectRatio), nameof(CConEnforceAspectRatio.Awake))]
    public static void CConEnforceAspectRatio_Awake(CConEnforceAspectRatio __instance)
    {
        __instance.enabled = false;
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CConSelectionLayer_Blocker), nameof(CConSelectionLayer_Blocker.TryGetNewSelection))]
    public static void CConSelectionLayer_Blocker_TryGetNewSelection(CConSelectionLayer_Blocker __instance)
    {
       var image = __instance.GetComponent<Image>();
       if (!image) return;
       if (image && image.name == "Overlay Black")
       {
           image.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
       }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains(SinaiFilterName)) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
    
}