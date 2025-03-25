namespace Nunholy.Patches;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UnlockChaCheck), nameof(UnlockChaCheck.Start))]
    public static void UnlockChaCheck_OnEnable(UnlockChaCheck __instance)
    {
        var bg = __instance.transform.Find("Background/Image");
        if (bg)
        {
            var image = bg.GetComponent<Image>();
            if (image)
            {
                image.maskable = false;
                image.m_Maskable = false;
                image.MarkDirty();
                Canvas.ForceUpdateCanvases();
                image.gameObject.SetActive(false);
                image.gameObject.SetActive(true);
            }

            var width = Screen.width * 2f;
            LayoutController.AddLayoutControllerRoot(bg, LayoutController.LayoutSize.Custom, width, false);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroCanvas), nameof(IntroCanvas.Start))]
    public static bool IntroCanvas_OnEnable(IntroCanvas __instance)
    {
        __instance.SkipToTitle();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.SetCamRect))]
    public static void CameraManager_SetCamRect(CameraManager __instance)
    {
        OverrideCameraRect();
#if DEBUG
        __instance.fullScreen = false;
#else
        __instance.fullScreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
#endif
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CommonCam), nameof(CommonCam.SetCamRect))]
    public static void CommonCam_SetCamRect(CommonCam __instance)
    {
        OverrideCameraRect();
#if DEBUG
        __instance.fullScreen = false;
#else
        __instance.fullScreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
#endif
    }

    private static void OverrideCameraRect()
    {
        if (Camera.main)
        {
            Camera.main.aspect = Resolutions.CurrentAspect;
            Camera.main.rect = new Rect(0, 0, 1, 1);
            Camera.main.clearFlags = CameraClearFlags.Color;
            Camera.main.backgroundColor = Color.black;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DamageCurtain), nameof(DamageCurtain.Awake))]
    public static void DamageCurtain_Awake(DamageCurtain __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, true);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleCanvas), nameof(TitleCanvas.OnEnable))]
    public static void TitleCanvas_OnEnable(TitleCanvas __instance)
    {
        var reportButton = __instance.transform.Find("Pannel/Box/ButtonPannel/2");
        if (reportButton)
        {
            reportButton.gameObject.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Curtain), nameof(Curtain.FadeOut))]
    public static void Curtain_FadeOut(Curtain __instance)
    {
        Plugin.UpdateFixedDeltaTime();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Curtain), nameof(Curtain.OnEnable))]
    public static void Curtain_OnEnable(Curtain __instance)
    {
        var posScale = Resolutions.CurrentAspect / Resolutions.NativeAspect;
        __instance.transform.localScale = new Vector3(posScale, posScale, 1f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Inventory), nameof(Inventory.Start))]
    public static void Inventory_Start(Inventory __instance)
    {
        var panel = __instance.transform.Find("_Panel");
        if (panel)
        {
            // Check if "BackgroundNew" already exists
            if (panel.Find("BackgroundNew")) return;

            // Find the first Image component in the panel and clone it
            var originalImage = panel.GetComponent<Image>();
            if (originalImage)
            {
                var image = Utils.CloneImage(originalImage, panel, "BackgroundNew", true);
                if (image)
                {
                    originalImage.enabled = false;
                    LayoutController.AddLayoutControllerRoot(image.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, true);
                }
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICanvas), nameof(UICanvas.OnEnable))]
    public static void AlertBox_OnEnable(UICanvas __instance)
    {
        if (__instance is AlertBox ab)
        {
            var rect = ab.transform.parent.GetComponent<RectTransform>();
            if (rect)
            {
                rect.sizeDelta = new Vector2(Resolutions.MainWidth, Resolutions.MainHeight);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConfigCanvas), nameof(ConfigCanvas.OnEnable))]
    [HarmonyPatch(typeof(SelectSlotCanvas), nameof(SelectSlotCanvas.OnEnable))]
    [HarmonyPatch(typeof(SelectCharacterCanvas), nameof(SelectCharacterCanvas.OnEnable))]
    [HarmonyPatch(typeof(PauseCanvas), nameof(PauseCanvas.OnEnable))]
    [HarmonyPatch(typeof(VampiricPowerManager), nameof(VampiricPowerManager.OnEnable))]
    public static void UICanvas_OnEnable(UICanvas __instance)
    {
        var panel = __instance.transform.Find("Pannel");
        if (panel)
        {

            var desPanel = panel.Find("SubDesParent");
            if (desPanel)
            {
                desPanel.transform.localPosition = desPanel.transform.localPosition with { x = Resolutions.WidthDifference };
            }
            
            // Apply the layout controller
            LayoutController.AddLayoutControllerRoot(panel, LayoutController.LayoutSize.ForceSixteenNine, 0f, true);

            // Check if "BackgroundNew" already exists
            if (panel.Find("BackgroundNew")) return;

            // Find the first Image component in the panel and clone it
            var originalImage = panel.GetComponent<Image>();
            if (originalImage)
            {
                var image = Utils.CloneImage(originalImage, panel, "BackgroundNew", true);
                if (image)
                {
                    originalImage.enabled = false;
                    LayoutController.AddLayoutControllerRoot(image.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, true);
                }
            }
        }
    }


    /// <summary>
    /// Overrides quality settings set by the game based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int))]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel()
    {
        QualSettings.UpdateSettings();
    }

    /// <summary>
    /// Forces game to apply expensive changes when quality settings are changed    
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel(ref bool applyExpensiveChanges)
    {
        applyExpensiveChanges = true;
    }

    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIControl), nameof(UIControl.OnEnable))]
    public static void UIControl_OnEnable(UIControl __instance)
    {
        var scaler = __instance.transform.Find("Scaler");
        if (scaler)
        {
            LayoutController.AddLayoutControllerRoot(scaler, LayoutController.LayoutSize.ConfigBased, 0f, true);
        }
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateVolumes();
    }


    /// <summary>
    /// Corrects scaling for certain UI components    
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;

        //the post-processing notifications canvas
        if (__instance.name == "MessageCanvas") return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}