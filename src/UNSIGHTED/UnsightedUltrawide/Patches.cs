namespace UnsightedUltrawide;

[Harmony]
public static class Patches
{


    private static GameObject VerticalBar { get; set; }
    private static GameObject NewWindowParent { get; set; }

    private static GameObject MenuHolder { get; set; }

    private static GameObject SlotsHolder { get; set; }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashScreenScene), nameof(SplashScreenScene.CheckBestResolution))]
    public static void SplashScreenScene_CheckBestResolution(ref SplashScreenScene __instance)
    {
        SetMaxUltrawide();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GlobalGraphicsSettings), nameof(GlobalGraphicsSettings.SetGraphicsSettings))]
    public static void GlobalGraphicsSettings_SetGraphicsSettings(ref GlobalGraphicsSettings __instance)
    {
        SetMaxUltrawide();
    }

    private static void SetSixteenByNine(CanvasScaler scaler = null)
    {
        if (scaler != null)
        {
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        }
        Display.displays[Plugin.DisplayToUse.Value].Activate();
        Screen.SetResolution(Plugin.SixteenNineWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
    }

    internal static void ChangeResolution()
    {
        Application.runInBackground = Plugin.RunInBackground.Value;
        Display.displays[Plugin.DisplayToUse.Value].Activate();
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, Plugin.FullScreenModeConfig.Value, Plugin.MaxRefresh);
        Application.targetFrameRate = Plugin.MaxRefresh;
        Time.fixedDeltaTime = 1f / Plugin.MaxRefresh;
    }

    private static void SetMaxUltrawide(CanvasScaler scaler = null)
    {
        if (scaler)
        {
            UltraWideScaling(scaler);
        }
        ChangeResolution();
    }


    private static void UltraWideScaling(CanvasScaler scaler)
    {
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreenScene), nameof(SplashScreenScene.Start))]
    public static bool SplashScreenScene_Start(ref SplashScreenScene __instance)
    {
        if (!Plugin.SkipDevLogos.Value) return true;
        SceneManager.LoadSceneAsync("TitleScreen");
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        UltraWideScaling(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SpotlightController), nameof(SpotlightController.OnEnable))]
    public static void SpotlightController_OnEnable(SpotlightController __instance)
    {
        __instance.transform.localScale = __instance.transform.localScale with {x = Plugin.NegativeScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HexagonalTransitionObject), nameof(HexagonalTransitionObject.PlayHexagonalTween))]
    public static void HexagonalTransitionObject_PlayHexagonalTween(HexagonalTransitionObject __instance)
    {
        __instance.transform.localScale = __instance.transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsPopup), nameof(OptionsPopup.OnEnable))]
    public static void OptionsPopup_OnEnable(OptionsPopup __instance)
    {
        __instance.resolutionWindow.SetActive(false);
        __instance.dataProcessingButton.SetActive(false);

        if (!NewWindowParent)
        {
            var child = __instance.transform.Find("Window (1)");
            NewWindowParent = new GameObject("NewWindowParent");
            child.SetParent(NewWindowParent.transform);
            NewWindowParent.transform.SetParent(__instance.transform);
            NewWindowParent.transform.position = NewWindowParent.transform.position with {x = 4.8f};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ControllerPopupPlatforms), nameof(ControllerPopupPlatforms.OnEnable))]
    public static void ControllerPopupPlatforms_OnEnable(ref ControllerPopupPlatforms __instance)
    {
        if (!VerticalBar)
        {
            var verticalBar = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/PopupManager/ConfigurePlayersPopup(Clone)/PC/Detail (1)");
            VerticalBar = new GameObject("Bar");
            VerticalBar.transform.SetParent(verticalBar.transform.parent);
            verticalBar.transform.SetParent(VerticalBar.transform);

            var devicesWindow = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/PopupManager/ConfigurePlayersPopup(Clone)/PC/ConfigureControlsMenu/DevicesWindow");
            devicesWindow.transform.SetParent(VerticalBar.transform);
            VerticalBar.transform.position = VerticalBar.transform.position with {x = -4.8f};
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PausePopup), nameof(PausePopup.OnEnable))]
    public static void PausePopup_OnEnable()
    {
        SetSixteenByNine(Plugin.GlobalCanvasScaler);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PausePopup), nameof(PausePopup.OnDisable))]
    public static void PausePopup_OnDisable()
    {
        SetMaxUltrawide(Plugin.GlobalCanvasScaler);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PopupManager), nameof(PopupManager.Start))]
    public static void PopupManager_Start(ref PopupManager __instance)
    {
        __instance.popupLetterbox.transform.localScale = __instance.popupLetterbox.transform.localScale with {x = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BetaTitleScreen), nameof(BetaTitleScreen.OnEnable))]
    public static void BetaTitleScreen_OnEnable(BetaTitleScreen __instance)
    {
        if (!MenuHolder)
        {
            var parentParent = __instance.transform;
            var menu = __instance.menu.transform;
            MenuHolder = new GameObject("MenuHolder");
            MenuHolder.transform.SetParent(parentParent);
            menu.SetParent(MenuHolder.transform);
            MenuHolder.transform.position = MenuHolder.transform.position with {x = -4.8f};
        }

        __instance.demoText.gameObject.SetActive(false);
        __instance.pixelPunkText.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveSlotPopup), nameof(SaveSlotPopup.Start))]
    public static void SaveSlotPopup_Start(SaveSlotPopup __instance)
    {
        if (!SlotsHolder)
        {
            var parentParent = __instance.transform;
            var slotsParent = __instance.slotsParent;
            var descText = __instance.descriptionText.transform;
            SlotsHolder = new GameObject("SlotsHolder");
            SlotsHolder.transform.SetParent(parentParent);
            descText.SetParent(SlotsHolder.transform);
            slotsParent.SetParent(SlotsHolder.transform);
            SlotsHolder.transform.position = SlotsHolder.transform.position with {x = -4.8f};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldLightController), nameof(WorldLightController.OnEnable))]
    public static void WorldLightController_OnEnable(WorldLightController __instance)
    {
        var x = __instance.transform.localScale.x * Plugin.PositiveScaleFactor;
        __instance.transform.localScale = __instance.transform.localScale with {x = x};
    }
}