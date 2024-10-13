namespace AnimaFlux.Patches;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        
        if (__instance.name.Equals("QuitDialogView"))
        {
            var bg = __instance.transform.Find("Image");
            if (bg)
            {
                bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //video is targeting a renderTexture so this does nothing...but..i..cant..stop..myself
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        var rawImage = __instance.GetComponent<RawImage>();
        if (rawImage)
        {
            rawImage.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LetterboxController), nameof(LetterboxController.TweenHeight))]
    public static void LetterboxController_Show(LetterboxController __instance, ref float height)
    {
        height = 0f;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        __instance.enabled = false;
        // Object.Destroy(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DialogueBubbleView), nameof(DialogueBubbleView.Start))]
    [HarmonyPatch(typeof(DialogueBubbleView), nameof(DialogueBubbleView.SetupText))]
    [HarmonyPatch(typeof(DialogueBubbleView), nameof(DialogueBubbleView.SetupNameText))]
    [HarmonyPatch(typeof(DialogueBubbleView), nameof(DialogueBubbleView.SetupPortrait))]
    public static void DialogueBubbleView_SetupPortrait(DialogueBubbleView __instance)
    {
        if (__instance._hasPortrait)
        {
            var x = __instance._portraitImage.transform.localPosition.x - 70f;
            __instance._portraitImage.transform.localPosition = __instance._portraitImage.transform.localPosition with { x = x };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UiViewChangerBehaviour), nameof(UiViewChangerBehaviour.Start))]
    [HarmonyPatch(typeof(UiViewChangerBehaviour), nameof(UiViewChangerBehaviour.SetDefaultView))]
    [HarmonyPatch(typeof(UiViewChangerBehaviour), nameof(UiViewChangerBehaviour.SetActiveView))]
    public static void AUiViewChangerBehaviour_SetActiveView(UiViewChangerBehaviour __instance)
    {
        var backPanel = __instance.transform.Find("BackPanel");
        if (backPanel)
        {
            backPanel.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
        }

    
    }
    
    
}