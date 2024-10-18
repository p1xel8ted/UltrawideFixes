// ReSharper disable Unity.IncorrectMonoBehaviourInstantiation

namespace AI_Limit.Patches;

[Harmony]
public static class Patches
{
    private static UIMovieBgController _movieBgController;
    private static Dictionary<string, WriteOnceFloat> OriginalSizes { get; } = new();
    private static WriteOnceFloat OriginalFoV { get; } = new();
    private static CinemachineBrain MainCamera { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
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
    [HarmonyPatch(typeof(TitleView), nameof(TitleView.OnShow))]
    [HarmonyPatch(typeof(TitleView), nameof(TitleView.OnGameSettingViewClose))]
    [HarmonyPatch(typeof(TitleView), nameof(TitleView.OnEnable))]
    public static void TitleView_OnEnable(TitleView __instance)
    {
        var aspectRatio = Plugin.MainAspect;

        // Process the main RectTransform
        var rectTransform = __instance.GetComponent<RectTransform>();
        if (rectTransform)
        {
            var path = rectTransform.GetPath();
            UpdateRectTransformSize(rectTransform, path, aspectRatio);
        }

        var gsv = __instance.transform.Find("GameSettingView");
        if (gsv)
        {
            var bg = gsv.Find("Bg");
            if (bg)
            {
                bg.transform.localScale = Plugin.ExpandUI.Value ? new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f) : Vector3.one;
            }

            var footer = gsv.Find("Footer");
            if (footer)
            {
                var footerBg = footer.Find("Bg");
                if (footerBg)
                {
                    var footerBgRectTransform = footerBg.GetComponent<RectTransform>();
                    if (footerBgRectTransform)
                    {
                        var path = footerBgRectTransform.GetPath();
                        UpdateFooterRectTransformSize(footerBgRectTransform, path);
                    }
                }
            }
        }
    }

    internal static void UpdateCamera()
    {
        if (!MainCamera)
        {
            MainCamera = Resources.FindObjectsOfTypeAll<CinemachineBrain>().FirstOrDefault(x => x.name == "Main Camera");
        }

        if (MainCamera)
        {
            if (OriginalFoV.HasValue)
            {
                var pct = Plugin.CameraFieldOfView.Value / 100f;

                MainCamera.OutputCamera.fieldOfView = OriginalFoV.Value + OriginalFoV.Value * pct;
            }

            MainCamera.OutputCamera.gateFit = Plugin.ViewScalingModeConfig.Value.ToGateFitMode();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.OnEnable))]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.OnSceneLoaded))]
    public static void CinemachineBrain_OnEnable(CinemachineBrain __instance)
    {
        if (__instance.name == "Main Camera")
        {
            MainCamera = __instance;
            OriginalFoV.Value = __instance.OutputCamera.fieldOfView;
            UpdateCamera();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FunctionView), nameof(FunctionView.OnShow))]
    [HarmonyPatch(typeof(FunctionView), nameof(FunctionView.ChangeTab))]
    [HarmonyPatch(typeof(FunctionView), nameof(FunctionView.OnNoticeViewStateChange))]
    public static void FunctionView_OnEnable(FunctionView __instance)
    {
        // Cache main aspect ratio once
        var aspectRatio = Plugin.MainAspect;

        // Process the main RectTransform
        var rectTransform = __instance.GetComponent<RectTransform>();
        if (rectTransform)
        {
            var path = rectTransform.GetPath();
            UpdateRectTransformSize(rectTransform, path, aspectRatio);
        }

        // Process the background RectTransform
        var bg = __instance.transform.Find("Bg");
        if (bg)
        {
            var bgRectTransform = bg.GetComponent<RectTransform>();
            if (bgRectTransform)
            {
                var path = bgRectTransform.GetPath();
                UpdateRectTransformSize(bgRectTransform, path, aspectRatio);
            }
        }

        // Process Footer children and parents
        var allRectTransforms = __instance.GetComponentsInChildren<RectTransform>()
            .Concat(__instance.GetComponentsInParent<RectTransform>());

        foreach (var footer in allRectTransforms)
        {
            if (footer.name == "Footer")
            {
                var footerBg = footer.Find("Bg");
                if (footerBg)
                {
                    var footerBgRectTransform = footerBg.GetComponent<RectTransform>();
                    if (footerBgRectTransform)
                    {
                        var path = footerBgRectTransform.GetPath();
                        UpdateFooterRectTransformSize(footerBgRectTransform, path);
                    }
                }
            }
        }
    }


    private static void UpdateRectTransformSize(RectTransform rectTransform, string path, float aspectRatio)
    {
        if (rectTransform == null || rectTransform.sizeDelta.y <= 0) return;

        var y = rectTransform.sizeDelta.y;
        var x = rectTransform.sizeDelta.x;

        // Check if this RectTransform has been adjusted before
        if (!OriginalSizes.TryGetValue(path, out var size))
        {
            OriginalSizes[path] = new WriteOnceFloat(x);
        }
        else
        {
            x = size;
        }

        // Adjust size based on aspect ratio
        rectTransform.sizeDelta = Plugin.ExpandUI.Value
            ? rectTransform.sizeDelta with { x = y * aspectRatio }
            : rectTransform.sizeDelta with { x = x };
    }

    private static void UpdateFooterRectTransformSize(RectTransform rectTransform, string path)
    {
        if (rectTransform == null) return;

        var x = rectTransform.sizeDelta.x;

        // Check if this RectTransform has been adjusted before
        if (!OriginalSizes.TryGetValue(path, out var size))
        {
            OriginalSizes[path] = new WriteOnceFloat(x);
        }
        else
        {
            x = size;
        }

        // For footers, simply adjust the `x` value without the aspect ratio multiplier
        rectTransform.sizeDelta = Plugin.ExpandUI.Value
            ? rectTransform.sizeDelta with { x = x * Plugin.PositiveScaleFactor } // Optional multiplier for footers
            : rectTransform.sizeDelta with { x = x };
    }

    internal static void UpdateMovieBgController()
    {
        if (!_movieBgController)
        {
            _movieBgController = Resources.FindObjectsOfTypeAll<UIMovieBgController>().FirstOrDefault();
        }

        if (_movieBgController)
        {
            _movieBgController.transform.localScale = Plugin.ScaleMenuBackground.Value ? new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f) : Vector3.one;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMovieBgController), nameof(UIMovieBgController.OnEnable))]
    public static void UIMovieBgController_OnEnable(UIMovieBgController __instance)
    {
        _movieBgController = __instance;

        UpdateMovieBgController();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.None;
        __instance.enabled = false;
        // Object.Destroy(__instance);
    }
}