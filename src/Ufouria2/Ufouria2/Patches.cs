namespace Ufouria2;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<CinemachineVirtualCamera, float> Cameras = new();
    private static readonly List<ContentSizeFitter> ContentSizeFitters = [];
    private static readonly List<RectMask2D> RectMask2Ds = [];
    private static readonly List<Image> BeadImages = [];
    private static readonly WriteOnceFloat GuideInitialPosition = new();
    private static GuideWipeViewController GuideWipeViewControllerInstance { get; set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ViewControllerBase), nameof(ViewControllerBase.FadeIn))]
    public static bool ViewControllerBase_FadeIn(ViewControllerBase __instance)
    {
        var tvc = __instance.TryCast<TitleViewController>();
        if (tvc)
        {
            Time.timeScale = 1f;
            return true;
        }

        var lvc = __instance.TryCast<LogoViewController>();
        if (lvc)
        {
            lvc.isIgnoreTimeScale = false;
            Time.timeScale = 10f;
            lvc.OnCompleteFade(false);
            lvc.OnCompleteFade(true);
            return false;
        }

        var lvcr = __instance.TryCast<LogoViewControllerRAG>();
        if (lvcr)
        {
            lvcr.isIgnoreTimeScale = false;
            Time.timeScale = 10f;
            lvcr.OnCompleteFade(false);
            lvcr.OnCompleteFade(true);
            return false;
        }

        return true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SkipOpeningViewController), nameof(SkipOpeningViewController.ManagedUpdate))]
    public static void SkipOpeningViewController_ManagedUpdate(SkipOpeningViewController __instance)
    {
        __instance.SetProgress(200);
        __instance.SetMode(SkipOpeningViewController.eMode.Skip);
        Time.timeScale = 1f;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TimeLineController), nameof(TimeLineController.Initialize))]
    public static void TimeLineController_Initialize(TimeLineController __instance)
    {
        var whiteFade = __instance.transform.FindChild("Canvas/WhiteFade");
        if (!whiteFade) return;

        var rect = whiteFade.GetComponent<RectTransform>();
        if (rect)
        {
            rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        }

        var image = whiteFade.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }

        UpdateSpanHUD();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TransitionViewController), nameof(TransitionViewController.Initialize))]
    public static void TransitionViewController_Initialize(TransitionViewController __instance)
    {
        var imageGo = __instance.transform.FindChild("Image");
        if (!imageGo) return;

        var rect = imageGo.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(rect.sizeDelta.y * Plugin.MainAspectRatio, rect.sizeDelta.y);

        var image = imageGo.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }

        UpdateSpanHUD();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BossDefeatViewController), nameof(BossDefeatViewController.EndVictory))]
    public static void BossDefeatViewController_EndVictory(BossDefeatViewController __instance)
    {
        Plugin.Logger.LogWarning("BossDefeatViewController_EndVictory");
        UpdateSpanHUD();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(BossDefeatViewController), nameof(BossDefeatViewController.Initialize))]
    public static void BossDefeatViewController_Initialize(BossDefeatViewController __instance)
    {
        var stitchImage = __instance.transform.FindChild("Victory/ScreenStitch");
        if (!stitchImage) return;

        stitchImage.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);

        var image = stitchImage.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }

        UpdateSpanHUD();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        if (__instance.name.Contains("universe")) return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    private static (ContentSizeFitter, RectMask2D) AddContentSizeFitter(GameObject go, bool addMask = false)
    {
        var le = go.GetComponentOrAdd<LayoutElement>();
        var csf = go.GetComponentOrAdd<ContentSizeFitter>();

        le.preferredWidth = 1920;
        le.preferredHeight = 1080;

        csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        le.enabled = true;
        csf.enabled = true;

        if (!addMask) return (csf, null);

        var mask = go.GetComponentOrAdd<RectMask2D>();
        mask.enabled = true;

        return (csf, mask);
    }

    internal static void UpdateSpanHUD()
    {
        foreach (var fitter in ContentSizeFitters)
        {
            if (Plugin.SpanUI.Value)
            {
                fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                fitter.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
            }
            else
            {
                fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
                fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            }
        }

        UpdateMasks();

        if (GuideWipeViewControllerInstance)
        {
            GuideWipeViewControllerInstance.UpdateAssistIconPosition(GuideWipeViewControllerInstance.m_isAssistActive);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FastTravelViewController), nameof(FastTravelViewController.Initialize))]
    public static void FastTravelViewController_Initialize(FastTravelViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG_black");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);

        var image = bg.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.Initialize))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.Setup))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.SetAssistActive))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.UpdateAssistIconPosition))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.ManagedUpdate))]
    public static void GuideWipeViewController_Setup(GuideWipeViewController __instance)
    {
        GuideWipeViewControllerInstance = __instance;
        
        GuideInitialPosition.Value = __instance.m_imageStartPosition.x;
        
        if (Plugin.SpanUI.Value)
        {
            __instance.m_imageStartPosition = __instance.m_imageStartPosition with { x = GuideInitialPosition.Value };
        }
        else
        {
            __instance.m_imageStartPosition = __instance.m_imageStartPosition with { x = GuideInitialPosition.Value * Plugin.MainAspectRatio };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.Initialize))]
    public static void GuideWipeViewController_Initialize(GuideWipeViewController __instance)
    {
        var image = __instance.transform.FindChild("GuideWipeRoot/GuideImage");
        if (!image) return;

        var img = image.GetComponent<Image>();
        if (img)
        {
            DisableMasking(img);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CollectionViewController), nameof(CollectionViewController.Initialize))]
    public static void CollectionViewController_Initialize(CollectionViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG_black");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);

        var image = bg.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapViewController), nameof(MapViewController.Initialize))]
    public static void MapViewController_Initialize(MapViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG_black");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);

        var image = bg.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HelpViewController), nameof(HelpViewController.Initialize))]
    public static void HelpViewController_Initialize(HelpViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);

        var image = bg.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseViewController), nameof(PauseViewController.Initialize))]
    public static void PauseViewController_Initialize(PauseViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);

        var image = bg.GetComponent<Image>();
        if (image)
        {
            DisableMasking(image);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CockpitViewController), nameof(CockpitViewController.Initialize))]
    public static void CockpitViewController_Initialize(CockpitViewController __instance)
    {
        var menuBeads = __instance.transform.FindChild("Menu/MenuBeadsLine");
        if (menuBeads)
        {
            var img = menuBeads.GetComponent<Image>();
            if (img)
            {
                BeadImages.Add(img);
                EnableMasking(img);
            }
        }

        var popoonBeads = __instance.transform.FindChild("Popoon/PopoonBeadsLine");
        if (popoonBeads)
        {
            var img = popoonBeads.GetComponent<Image>();
            if (img)
            {
                BeadImages.Add(img);
                EnableMasking(img);
            }
        }

        var healthBeads = __instance.transform.FindChild("HP/HPBeadsLine");
        if (!healthBeads) return;
        {
            var img = healthBeads.GetComponent<Image>();
            if (!img) return;

            BeadImages.Add(img);
            EnableMasking(img);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeadlineTextViewController), nameof(HeadlineTextViewController.Initialize))]
    public static void HeadlineTextViewController_Initialize(HeadlineTextViewController __instance)
    {
        var image = __instance.transform.FindChild("GrayBG");
        if (!image) return;

        var rect = image.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(rect.sizeDelta.y * Plugin.MainAspectRatio, rect.sizeDelta.y);

        var img = image.GetComponent<Image>();
        if (img)
        {
            DisableMasking(img);
        }
    }


    internal static void UpdateMasks()
    {
        foreach (var bead in BeadImages)
        {
            if (!Plugin.SpanUI.Value)
            {
                bead.maskable = Plugin.MaskUIBeads.Value;
                bead.m_IncludeForMasking = Plugin.MaskUIBeads.Value;
            }
            else
            {
                bead.maskable = false;
                bead.m_IncludeForMasking = false;
            }
        }

        foreach (var mask in RectMask2Ds)
        {
            mask.GetComponent<Graphic>()?.SetMaterialDirty();
            mask.GetComponent<Graphic>()?.SetVerticesDirty();

            mask.enabled = false;
            mask.enabled = true;

            mask.enabled = !Plugin.SpanUI.Value;

            var newMaskList = new Il2CppSystem.Collections.Generic.HashSet<MaskableGraphic>();
            foreach (var maskable in mask.m_MaskableTargets)
            {
                if (maskable is Image img)
                {
                    newMaskList.Add(img);
                }
                else
                {
                    maskable.maskable = false;
                    maskable.m_IncludeForMasking = false;
                }
            }

            mask.m_MaskableTargets = newMaskList;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameMainViewManager), nameof(GameMainViewManager.Awake))]
    public static void PauseViewController_Initialize(GameMainViewManager __instance)
    {
        //restrict the vending machine to 16:9 aspect ratio
        var crf = AddContentSizeFitter(__instance.gameObject, true);
        ContentSizeFitters.Add(crf.Item1);
        RectMask2Ds.Add(crf.Item2);
    }

    private static void EnableMasking(Image image)
    {
        image.maskable = true;
        image.m_IncludeForMasking = true;
     
        UpdateSpanHUD();
    }

    private static void DisableMasking(Image image)
    {
        image.maskable = false;
        image.m_IncludeForMasking = false;
 
        UpdateSpanHUD();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ShopMenuViewController), nameof(ShopMenuViewController.Initialize))]
    public static void ShopMenuViewController_Initialize(ShopMenuViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG");
        if (!bg) return;

        //restrict the vending machine to 16:9 aspect ratio - exclude from spanning as it breaks the shop
        AddContentSizeFitter(bg.gameObject);

        //resize background image to fit the screen
        var flameBg = bg.transform.FindChild("ShopContentRoot/FlameBG");
        if (flameBg)
        {
            var rect = flameBg.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(rect.sizeDelta.y * Plugin.MainAspectRatio, rect.sizeDelta.y);

            var image = flameBg.GetComponent<Image>();
            if (image)
            {
                DisableMasking(image);
            }
        }

        //disable the gradients
        var bottomGradient = bg.transform.FindChild("BlackMaskBottom");
        if (bottomGradient)
        {
            bottomGradient.gameObject.SetActive(false);
        }

        var topGradient = bg.transform.FindChild("BlackMaskUp");
        if (topGradient)
        {
            topGradient.gameObject.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FadeAnchordPosition), nameof(FadeAnchordPosition.OnUpdatePosition))]
    public static void FadeAnchordPosition_OnUpdatePosition(FadeAnchordPosition __instance)
    {
        if (__instance.name.Contains("LetterBox", StringComparison.OrdinalIgnoreCase))
        {
            __instance.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, 100f);
            __instance.rectTransform.anchoredPosition = new Vector2(-Plugin.BlackBarSize, 0f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EventViewController), nameof(EventViewController.Initialize))]
    [HarmonyPatch(typeof(EventViewController), nameof(EventViewController.Setup))]
    public static void EventViewController_OnEnable(EventViewController __instance)
    {
        foreach (var obj in __instance.m_letterBoxFadeComponents)
        {
            // Letterbox.Add(obj.gameObject);
            obj.gameObject.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(CinemachineVirtualCamera __instance)
    {
        var fov = __instance.m_Lens.FieldOfView;
        Cameras.TryAdd(__instance, fov);
    }

    private static void UpdateCamera(CinemachineVirtualCamera cam, float originalFov)
    {
        var fov = Plugin.FieldOfView.Value / 100f;
        var newFov = originalFov + originalFov * fov;
        if (cam)
        {
            cam.m_Lens = cam.m_Lens with { FieldOfView = newFov };
        }
    }

    internal static void UpdateCameras()
    {
        foreach (var (key, originalFov) in Cameras)
        {
            UpdateCamera(key, originalFov);
        }
    }
}