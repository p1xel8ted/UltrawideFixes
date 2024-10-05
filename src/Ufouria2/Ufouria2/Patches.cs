// ReSharper disable InconsistentNaming
namespace Ufouria2;

/// <summary>
/// Contains Harmony patches for modifying game behavior.
/// </summary>
[Harmony]
public static class Patches
{
    /// <summary>
    /// Stores a mapping between virtual cameras and their original field of view.
    /// </summary>
    private static readonly Dictionary<CinemachineVirtualCamera, float> Cameras = new();

    /// <summary>
    /// A list of <see cref="ContentSizeFitter"/> components to adjust UI elements.
    /// </summary>
    private static readonly List<ContentSizeFitter> ContentSizeFitters = [];

    /// <summary>
    /// A list of <see cref="RectMask2D"/> components for masking UI elements.
    /// </summary>
    private static readonly List<RectMask2D> RectMask2Ds = [];

    /// <summary>
    /// A list of bead <see cref="Image"/> components in the UI.
    /// </summary>
    private static readonly List<Image> BeadImages = [];

    /// <summary>
    /// Stores the initial position of the guide image.
    /// </summary>
    private static readonly WriteOnceFloat GuideInitialPosition = new();

    /// <summary>
    /// Gets or sets the instance of <see cref="GuideWipeViewController"/>.
    /// </summary>
    private static GuideWipeViewController GuideWipeViewControllerInstance { get; set; }

    /// <summary>
    /// Gets or sets the temporary position of the guide image.
    /// </summary>
    private static Vector2 TempGuidePosition { get; set; } = Vector2.zero;

    /// <summary>
    /// Gets or sets the transform of the guide image.
    /// </summary>
    private static Transform GuideImage { get; set; }

    /// <summary>
    /// Harmony Prefix patch for <see cref="ViewControllerBase.FadeIn"/> method.
    /// This forces the completion of the splash logos.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="ViewControllerBase"/>.</param>
    /// <returns>Returns <c>true</c> to continue execution, or <c>false</c> to skip the original method.</returns>
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

    /// <summary>
    /// Harmony Prefix patch for <see cref="SkipOpeningViewController.ManagedUpdate"/> method.
    /// This sets the Skip button to 100% straight away, instead of having to hold to skip.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="SkipOpeningViewController"/>.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SkipOpeningViewController), nameof(SkipOpeningViewController.ManagedUpdate))]
    public static void SkipOpeningViewController_ManagedUpdate(SkipOpeningViewController __instance)
    {
        __instance.SetProgress(200);
        __instance.SetMode(SkipOpeningViewController.eMode.Skip);
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Harmony Postfix patch for <see cref="TimeLineController.Initialize"/> method.
    /// Adjusts the white fade image size.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="TimeLineController"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TimeLineController), nameof(TimeLineController.Initialize))]
    public static void TimeLineController_Initialize(TimeLineController __instance)
    {
        UpdateImage(__instance.transform, "Canvas/WhiteFade", ImageAdjustment.SetRectScreenSize, false);
    }

    /// <summary>
    /// Harmony Postfix patch for <see cref="BossDefeatViewController.EndVictory"/> method.
    /// Updates the HUD after defeating a boss.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="BossDefeatViewController"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BossDefeatViewController), nameof(BossDefeatViewController.EndVictory))]
    public static void BossDefeatViewController_EndVictory(BossDefeatViewController __instance)
    {
        UpdateSpanHUD();
    }

    /// <summary>
    /// Harmony Postfix patch for <see cref="CanvasScaler.OnEnable"/> method.
    /// Adjusts the canvas scaling mode.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="CanvasScaler"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        if (__instance.name.Contains("universe")) return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    /// <summary>
    /// Adds a <see cref="ContentSizeFitter"/> and optionally a <see cref="RectMask2D"/> to the specified <see cref="GameObject"/>.
    /// </summary>
    /// <param name="go">The GameObject to modify.</param>
    /// <param name="addMask">Whether to add a RectMask2D component.</param>
    /// <returns>A tuple containing the added ContentSizeFitter and RectMask2D components.</returns>
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

    /// <summary>
    /// Updates the span of HUD elements based on plugin settings.
    /// </summary>
    internal static void UpdateSpanHUD()
    {
        foreach (var fitter in ContentSizeFitters)
        {
            fitter.horizontalFit = Plugin.SpanUI.Value ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize;
            fitter.verticalFit = Plugin.SpanUI.Value ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize;
        }

        UpdateMasks();

        if (!GuideWipeViewControllerInstance)
        {
            GuideWipeViewControllerInstance = Resources.FindObjectsOfTypeAll<GuideWipeViewController>().FirstOrDefault();
        }

        if (GuideWipeViewControllerInstance)
        {
            GuideWipeViewControllerInstance.UpdateAssistIconPosition(GuideWipeViewControllerInstance.m_isAssistActive);
            GuideWipeViewController_Setup(GuideWipeViewControllerInstance);
        }
    }

    /// <summary>
    /// Updates an image component based on the specified adjustments.
    /// </summary>
    /// <param name="tr">The parent transform.</param>
    /// <param name="find">The name of the child to find.</param>
    /// <param name="ia">The type of image adjustment to apply.</param>
    /// <param name="maskEnabled">Whether masking is enabled.</param>
    /// <returns>The updated <see cref="Image"/> component, or null if not found.</returns>
    private static Image UpdateImage(Transform tr, string find, ImageAdjustment ia, bool maskEnabled)
    {
        var bg = tr.FindChild(find);
        if (!bg) return null;

        var rect = bg.GetComponent<RectTransform>();
        switch (ia)
        {
            case ImageAdjustment.SetRectAspectRatio:
                if (rect)
                {
                    rect.sizeDelta = new Vector2(rect.sizeDelta.y * Plugin.MainAspectRatio, rect.sizeDelta.y);
                }
                break;
            case ImageAdjustment.PositiveScaleX:
                bg.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
                break;
            case ImageAdjustment.PositiveScaleXY:
                bg.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
                break;
            case ImageAdjustment.NegativeScaleX:
                bg.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
                break;
            case ImageAdjustment.NegativeScaleXY:
                bg.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1f);
                break;
            case ImageAdjustment.SetRectScreenSize:
                if (rect)
                {
                    rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
                }
                break;
            case ImageAdjustment.None:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(ia), ia, null);
        }

        var image = bg.GetComponent<Image>();
        if (!image)
        {
            UpdateSpanHUD();
            return null;
        }

        if (maskEnabled)
        {
            EnableMasking(image);
        }
        else
        {
            DisableMasking(image);
        }

        UpdateSpanHUD();
        return image;
    }

    /// <summary>
    /// Harmony Prefix patches for various <see cref="GuideWipeViewController"/> methods.
    /// Adjusts the talking head position and visibility, depending on settings.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="GuideWipeViewController"/>.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.Initialize))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.Setup))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.SetAssistActive))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.UpdateAssistIconPosition))]
    [HarmonyPatch(typeof(GuideWipeViewController), nameof(GuideWipeViewController.ManagedUpdate))]
    public static void GuideWipeViewController_Setup(GuideWipeViewController __instance)
    {
        if (!__instance.isPlayingGuideWipe && !Mathf.Approximately(__instance.m_currentImagePosition.x, TempGuidePosition.x))
        {
            GuideImage ??= __instance.transform.FindChild("GuideWipeRoot/GuideImage");
            if (GuideImage)
            {
                __instance.m_currentImagePosition = TempGuidePosition;
                GuideImage.localPosition = TempGuidePosition;
            }
        }

        GuideWipeViewControllerInstance = __instance;

        GuideInitialPosition.Value = __instance.m_imageStartPosition.x;

        if (Plugin.SpanUI.Value)
        {
            __instance.m_imageStartPosition = __instance.m_imageStartPosition with { x = GuideInitialPosition.Value };
        }
        else
        {
            var x = GuideInitialPosition.Value * Plugin.MainAspectRatio;
            if (Plugin.SuperWide && Plugin.KeepHeadVisibleWhenInactive.Value)
            {
                x += 300f;
            }

            __instance.m_imageStartPosition = __instance.m_imageStartPosition with { x = x };
        }

        TempGuidePosition = __instance.m_imageStartPosition;
    }

    /// <summary>
    /// Harmony Postfix patch for <see cref="ViewControllerBase.Initialize"/> method.
    /// Updates various UI elements upon initialization. This ensures background images are correctly scaled, and masking is applied (or not) to relevant elements.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="ViewControllerBase"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ViewControllerBase), nameof(ViewControllerBase.Initialize))]
    public static void ViewControllerBase_Initialize(ViewControllerBase __instance)
    {
        UpdateImage(__instance.transform, "BG_black", ImageAdjustment.SetRectScreenSize, false);
        UpdateImage(__instance.transform, "BG", ImageAdjustment.SetRectScreenSize, false);
        UpdateImage(__instance.transform, "GuideWipeRoot/GuideImage", ImageAdjustment.None, false);
        UpdateImage(__instance.transform, "GrayBG", ImageAdjustment.SetRectAspectRatio, false);
        UpdateImage(__instance.transform, "Victory/ScreenStitch", ImageAdjustment.PositiveScaleX, false);
        UpdateImage(__instance.transform, "BG/ShopContentRoot/FlameBG", ImageAdjustment.SetRectScreenSize, false);
        UpdateImage(__instance.transform, "Image", ImageAdjustment.SetRectAspectRatio, false);

        var menuBeads = UpdateImage(__instance.transform, "Menu/MenuBeadsLine", ImageAdjustment.None, true);
        if (menuBeads)
        {
            BeadImages.Add(menuBeads);
        }

        var popoonBeads = UpdateImage(__instance.transform, "Popoon/PopoonBeadsLine", ImageAdjustment.None, true);
        if (popoonBeads)
        {
            BeadImages.Add(popoonBeads);
        }

        var hpBeads = UpdateImage(__instance.transform, "HP/HPBeadsLine", ImageAdjustment.None, true);
        if (hpBeads)
        {
            BeadImages.Add(hpBeads);
        }

        UpdateSpanHUD();
    }

    /// <summary>
    /// Updates the masks applied to UI elements.
    /// </summary>
    internal static void UpdateMasks()
    {
        GlobalMaskUpdate();

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
            mask.GetComponent<Image>()?.SetMaterialDirty();
            mask.GetComponent<Image>()?.SetVerticesDirty();

            mask.enabled = false;
            mask.enabled = true;

            mask.enabled = !Plugin.SpanUI.Value;

            var newMaskList = new Il2CppSystem.Collections.Generic.HashSet<MaskableGraphic>();
            foreach (var maskable in mask.m_MaskableTargets)
            {
                var img = maskable.TryCast<Image>();
                if (img)
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

    /// <summary>
    /// Performs a global update on all <see cref="RectMask2D"/> components.
    /// </summary>
    private static void GlobalMaskUpdate()
    {
        var tempMasks = new List<RectMask2D>(RectMask2Ds);
        var foundMasks = Object.FindObjectsOfType<RectMask2D>(true).ToList();
        var moreFoundMasks = Resources.FindObjectsOfTypeAll<RectMask2D>().ToList();
        tempMasks.AddRange(foundMasks);
        tempMasks.AddRange(moreFoundMasks);

        foreach (var mask in tempMasks)
        {
            if (mask.gameObject.name.Contains("sinai", StringComparison.OrdinalIgnoreCase) || mask.gameObject.GetPath().Contains("sinai", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var isEnabled = mask.enabled;
            var newMaskList = new Il2CppSystem.Collections.Generic.HashSet<MaskableGraphic>();
            foreach (var maskable in mask.m_MaskableTargets)
            {
                var img = maskable.TryCast<Image>();
                if (img)
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

            mask.enabled = false;
            mask.enabled = true;
            mask.enabled = isEnabled;
        }
    }

    /// <summary>
    /// Harmony Postfix patch for <see cref="GameMainViewManager.Awake"/> method.
    /// Adds content size fitter to the game main view. This is used to span or constrain the UI.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="GameMainViewManager"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameMainViewManager), nameof(GameMainViewManager.Awake))]
    public static void PauseViewController_Initialize(GameMainViewManager __instance)
    {
        // Restrict the vending machine to 16:9 aspect ratio
        var crf = AddContentSizeFitter(__instance.gameObject, true);
        ContentSizeFitters.Add(crf.Item1);
        RectMask2Ds.Add(crf.Item2);
    }

    /// <summary>
    /// Enables masking on the specified image.
    /// </summary>
    /// <param name="image">The image to enable masking on.</param>
    private static void EnableMasking(Image image)
    {
        image.maskable = true;
        image.m_IncludeForMasking = true;

        UpdateSpanHUD();
    }

    /// <summary>
    /// Disables masking on the specified image.
    /// </summary>
    /// <param name="image">The image to disable masking on.</param>
    private static void DisableMasking(Image image)
    {
        image.maskable = false;
        image.m_IncludeForMasking = false;

        UpdateSpanHUD();
    }

    /// <summary>
    /// Harmony Postfix patch for <see cref="ShopMenuViewController.Initialize"/> method.
    /// Restricts the shop menu UI elements to 16:9 as it breaks the shop otherwise.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="ShopMenuViewController"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ShopMenuViewController), nameof(ShopMenuViewController.Initialize))]
    public static void ShopMenuViewController_Initialize(ShopMenuViewController __instance)
    {
        var bg = __instance.transform.FindChild("BG");
        if (!bg) return;

        // Restrict the vending machine to 16:9 aspect ratio - exclude from spanning as it breaks the shop
        AddContentSizeFitter(bg.gameObject);

        UpdateImage(bg, "ShopContentRoot/FlameBG", ImageAdjustment.SetRectScreenSize, false);

        // Disable the gradients
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

    /// <summary>
    /// Harmony Postfix patches for <see cref="EventViewController"/> methods.
    /// Disables letterbox components in events.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="EventViewController"/>.</param>
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

    /// <summary>
    /// Harmony Postfix patch for <see cref="CinemachineVirtualCamera.OnEnable"/> method.
    /// Adjusts the field of view of specific virtual cameras.
    /// </summary>
    /// <param name="__instance">The instance of <see cref="CinemachineVirtualCamera"/>.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(CinemachineVirtualCamera __instance)
    {
        if (__instance.name.Contains("Area_VirtualCamera", StringComparison.OrdinalIgnoreCase) || __instance.name.Contains("PC_VirtualCamera", StringComparison.OrdinalIgnoreCase))
        {
            var fov = __instance.m_Lens.FieldOfView;
            Cameras.TryAdd(__instance, fov);
            UpdateCamera(__instance, fov);
        }
    }

    /// <summary>
    /// Updates the field of view of the specified camera based on plugin settings.
    /// </summary>
    /// <param name="cam">The camera to update.</param>
    /// <param name="originalFov">The original field of view.</param>
    private static void UpdateCamera(CinemachineVirtualCamera cam, float originalFov)
    {
        var fov = Plugin.FieldOfView.Value / 100f;
        var newFov = originalFov + originalFov * fov;
        if (cam)
        {
            cam.m_Lens = cam.m_Lens with { FieldOfView = newFov };
        }
    }

    /// <summary>
    /// Updates all stored cameras with the new field of view settings.
    /// </summary>
    internal static void UpdateCameras()
    {
        foreach (var (key, originalFov) in Cameras)
        {
            UpdateCamera(key, originalFov);
        }
    }

    /// <summary>
    /// Specifies the types of image adjustments that can be applied.
    /// </summary>
    private enum ImageAdjustment
    {
        /// <summary>
        /// Adjusts the RectTransform to maintain the aspect ratio.
        /// </summary>
        SetRectAspectRatio,
        /// <summary>
        /// Scales the image positively along the X-axis.
        /// </summary>
        PositiveScaleX,
        /// <summary>
        /// Scales the image positively along both X and Y axes.
        /// </summary>
        PositiveScaleXY,
        /// <summary>
        /// Scales the image negatively along the X-axis.
        /// </summary>
        NegativeScaleX,
        /// <summary>
        /// Scales the image negatively along both X and Y axes.
        /// </summary>
        NegativeScaleXY,
        /// <summary>
        /// Sets the RectTransform to match the screen size.
        /// </summary>
        SetRectScreenSize,
        /// <summary>
        /// No adjustment is applied.
        /// </summary>
        None
    }
}