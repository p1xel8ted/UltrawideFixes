// ReSharper disable Unity.IncorrectMonoBehaviourInstantiation

using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;
using Object = UnityEngine.Object;

namespace AI_Limit.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, Transform> PositiveScaleMe = [];
    private static readonly Dictionary<int, Transform> NegativeScaleMe = [];
    private static WriteOnceFloat OriginalFoV { get; } = new();
    private static CinemachineBrain MainCamera { get; set; }

    private static GameObject MovieBgBackground { get; set; }

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    internal static void UpdateScalers()
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = Resolutions.CurrentAspect > Resolutions.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers();
    }

    // need this here, as well as adding the custom component to force it
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), "set_gateFit")]
    public static void Camera_set_gateFit(ref Camera.GateFitMode value)
    {
        value = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
    }

    // need this here, as well as adding the custom component to force it
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Camera), "get_gateFit")]
    public static void Camera_get_gateFit(ref Camera.GateFitMode __result)
    {
        __result = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
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
                rawImage.transform.localScale = new Vector3(Resolutions.NegativeScaleFactor, 1f, 1f);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PaperView), nameof(PaperView.OnShow))]
    public static void PaperView_OnShow(PaperView __instance)
    {
        var bg = __instance.transform.FindChild("HUD_TutorialView/Bg");
        if (bg)
        {
            PositiveScaleMe.TryAdd(bg.GetInstanceID(), bg);
        }

        for (var i = 0; i < __instance.transform.childCount; i++)
        {
            var child = __instance.transform.GetChild(i);
            if (child)
            {
                NegativeScaleMe.TryAdd(child.GetInstanceID(), child);
            }
        }

        UpdateTransforms();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Tutorial), nameof(Tutorial.OnEnable))]
    public static void Tutorial_OnEnable(Tutorial __instance)
    {
        var bg = __instance.transform.FindChild("Bg");
        if (bg)
        {
            PositiveScaleMe.TryAdd(bg.GetInstanceID(), bg);
        }

        UpdateTransforms();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_Dialog), nameof(UI_Dialog.OnEnable))]
    public static void UI_Dialog_OnEnable(UI_Dialog __instance)
    {
        var dlg = __instance.transform.FindChild("UIRppt/DialogGroup/Bg");
        {
            if (dlg)
            {
                PositiveScaleMe.TryAdd(dlg.GetInstanceID(), dlg);
            }
        }

        UpdateTransforms();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TransferView), nameof(TransferView.OnShow))]
    [HarmonyPatch(typeof(TransferView), nameof(TransferView.OnEnable))]
    [HarmonyPatch(typeof(TitleView), nameof(TitleView.OnShow))]
    // [HarmonyPatch(typeof(TitleView), nameof(TitleView.OnHide))]
    [HarmonyPatch(typeof(TitleView), nameof(TitleView.OnEnable))]
    [HarmonyPatch(typeof(ArchiveView), nameof(ArchiveView.OnEnable))]
    [HarmonyPatch(typeof(ArchiveView), nameof(ArchiveView.OnNoticeShow))]
    [HarmonyPatch(typeof(FunctionView), nameof(FunctionView.OnShow))]
    [HarmonyPatch(typeof(FunctionView), nameof(FunctionView.ChangeTab))]
    [HarmonyPatch(typeof(FunctionView), nameof(FunctionView.OnNoticeViewStateChange))]
    public static void UIBehaviour_OnEnable(UIBehaviour __instance)
    {
        var infoHeader = __instance.transform.FindChild("Tutorial/Footer/Bg");
        if (infoHeader)
        {
            PositiveScaleMe.TryAdd(infoHeader.GetInstanceID(), infoHeader);
        }

        var bg = __instance.transform.FindChild("GameSettingView/Bg");
        if (bg)
        {
            PositiveScaleMe.TryAdd(bg.GetInstanceID(), bg);
        }

        var bg2 = __instance.transform.FindChild("Bg");
        if (bg2)
        {
            PositiveScaleMe.TryAdd(bg2.GetInstanceID(), bg2);
        }

        var footer = __instance.transform.FindChild("Footer/Bg");
        if (footer)
        {
            PositiveScaleMe.TryAdd(footer.GetInstanceID(), footer);
        }

        var footer2 = __instance.transform.FindChild("GameSettingView/Footer/Bg");
        if (footer2)
        {
            PositiveScaleMe.TryAdd(footer2.GetInstanceID(), footer2);
        }

        var header = __instance.transform.FindChild("GameSettingView/HeaderSimple/Bg");
        if (header)
        {
            PositiveScaleMe.TryAdd(header.GetInstanceID(), header);
        }

        var header2 = __instance.transform.FindChild("HeaderSimple/Bg");
        if (header2)
        {
            PositiveScaleMe.TryAdd(header2.GetInstanceID(), header2);
        }

        var header3 = __instance.transform.FindChild("Header/Bg");
        if (header3)
        {
            PositiveScaleMe.TryAdd(header3.GetInstanceID(), header3);
        }

        if (__instance is FunctionView fv)
        {
            // List to hold the results
            var footerChildren = new List<Transform>();

            // Start the recursive search
            TransformExtensions.FindAllChildrenByName(fv.transform, "Footer", footerChildren);

            // Now `footerChildren` contains all transforms named "Footer"
            foreach (var bg3 in from foot in footerChildren where foot select foot.transform.FindChild("Bg") into bg3 where bg3 select bg3)
            {
                // Plugin.Logger.LogWarning(bg3.GetPath());
                PositiveScaleMe.TryAdd(bg3.GetInstanceID(), bg3);
            }
        }


        UpdateTransforms();
    }

    internal static void UpdateTransforms()
    {
        foreach (var t in PositiveScaleMe.Where(t => t.Value))
        {
            t.Value.transform.localScale = t.Value.transform.localScale with { x = Resolutions.PositiveScaleFactor };
        }

        foreach (var t in NegativeScaleMe.Where(t => t.Value))
        {
            t.Value.transform.localScale = t.Value.transform.localScale with { x = Resolutions.NegativeScaleFactor };
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
                var pct = Configuration.CameraFieldOfView.Value / 100f;

                MainCamera.OutputCamera.fieldOfView = OriginalFoV.Value + OriginalFoV.Value * pct;
            }
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

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIMovieBgController), nameof(UIMovieBgController.OnDisable))]
    public static void UIMovieBgController_OnDisable(UIMovieBgController __instance)
    {
        if (!MovieBgBackground) return;

        Object.Destroy(MovieBgBackground);
        MovieBgBackground = null;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameSettingElement), nameof(GameSettingElement.InitValue), typeof(Il2CppSystem.Action<int>), typeof(int), typeof(Il2CppStringArray), typeof(string))]
    public static void GameSettingElement_InitValue(GameSettingElement __instance, Il2CppSystem.Action<int> valueChangeAction,
        int valueIndex,
        ref Il2CppStringArray enumNameList,
        string settingName)
    {
        if (settingName != "Resolution") return;

        var newRes = $"{Resolutions.SelectedResolution.width} X {Resolutions.SelectedResolution.height}";

        var newList = enumNameList.ToList();
        newList.Add(newRes);
        newList.Add(newRes);
        newList.Add(newRes);
        newList.Add(newRes);
        
        enumNameList = newList.ToArray();
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ResolutionManager), nameof(ResolutionManager.SetResolutionLow_1280))]
    [HarmonyPatch(typeof(ResolutionManager), nameof(ResolutionManager.SetResolutionMid_1920))]
    [HarmonyPatch(typeof(ResolutionManager), nameof(ResolutionManager.SetResolutionMid_2560))]
    [HarmonyPatch(typeof(ResolutionManager), nameof(ResolutionManager.SetResolutionHight_4K))]
    public static void ResolutionManager_OnEnable(ResolutionManager __instance)
    {
        var newW = Resolutions.SelectedResolution.width;
        var newH = Resolutions.SelectedResolution.height;

        var w = __instance.widths.ToList();
        var h = __instance.heights.ToList();
        
        for (var i = 0; i < w.Count; i++)
        {
            w[i] = newW;
            h[i] = newH;
        }

        __instance.widths = w.ToArray();
        __instance.heights = h.ToArray();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMovieBgController), nameof(UIMovieBgController.OnEnable))]
    public static void UIMovieBgController_OnEnable(UIMovieBgController __instance)
    {
        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = Resolutions.NativeAspect;

        // Add a new GameObject as a fullscreen black background
        var go = new GameObject("BlackBG");
        go.transform.SetParent(__instance.transform.parent, false); // Maintain correct local positioning
        var img = go.AddComponent<Image>();
        img.color = Color.black;

        // Set the rect transform to cover the entire parent
        var rectTransform = img.rectTransform;
        rectTransform.anchorMin = Vector2.zero;
        rectTransform.anchorMax = Vector2.one;
        rectTransform.sizeDelta = Vector2.zero;

        // Move the background behind everything else
        go.transform.SetAsFirstSibling();
        MovieBgBackground = go;
    }
}