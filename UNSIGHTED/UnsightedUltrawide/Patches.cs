namespace UnsightedUltrawide;

[Harmony]
public static class Patches
{
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
        Display.displays[Plugin.DisplayToUse.Value].Activate();
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
        Application.targetFrameRate = Plugin.MaxRefresh;
    }

    private static void SetMaxUltrawide(CanvasScaler scaler = null)
    {
        if (scaler != null)
        {
            UltraWideScaling(scaler);
        }
        ChangeResolution();
    }


    private static void UltraWideScaling(CanvasScaler scaler)
    {
        if (scaler == null)
        {
            Plugin.LOG.LogError("Requested CanvasScaler is null!");
            return;
        }
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreenScene), nameof(SplashScreenScene.Start))]
    public static bool SplashScreenScene_Start(ref SplashScreenScene __instance)
    {
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
        PerformNegativeXScale(__instance.transform);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HexagonalTransitionObject), nameof(HexagonalTransitionObject.PlayHexagonalTween))]
    public static void HexagonalTransitionObject_PlayHexagonalTween(HexagonalTransitionObject __instance)
    {
        PerformPositiveXYScale(__instance.transform);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ControllerPopupPlatforms), nameof(ControllerPopupPlatforms.OnEnable))]
    public static void ControllerPopupPlatforms_OnEnable(ControllerPopupPlatforms __instance)
    {
        var verticalBar = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/PopupManager/ConfigurePlayersPopup(Clone)/PC/Detail (1)");
        if (verticalBar != null)
        {
            var localPosition = verticalBar.transform.localPosition;
            localPosition = localPosition with {x = localPosition.x - 66f};
            verticalBar.transform.localPosition = localPosition;
        }


        var devicesWindow = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/PopupManager/ConfigurePlayersPopup(Clone)/PC/ConfigureControlsMenu/DevicesWindow");
        if (devicesWindow == null) return;
        
        var position = devicesWindow.transform.localPosition;
        position = position with {x = position.x - 76f};
        devicesWindow.transform.localPosition = position;
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
    [HarmonyPatch(typeof(BetaTitleScreen), nameof(BetaTitleScreen.OnEnable))]
    public static void BetaTitleScreen_OnEnable(BetaTitleScreen __instance)
    {
        __instance.menu.transform.localPosition = __instance.menu.transform.localPosition with {x = -215f};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveSlotPopup), nameof(SaveSlotPopup.Start))]
    public static void SaveSlotPopup_Start(SaveSlotPopup __instance)
    {
        __instance.slotsParent.localPosition = __instance.slotsParent.localPosition with {x = -30f};
        var transform = __instance.descriptionText.transform;
        transform.localPosition = transform.localPosition with {x = -30f};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldLightController), nameof(WorldLightController.OnEnable))]
    public static void WorldLightController_OnEnable(WorldLightController __instance)
    {
        var transform = __instance.transform;
        transform.localPosition = new Vector3(0, 0, 1);
        var localScale = transform.localScale;
        localScale = localScale with {x = localScale.x * Plugin.PositiveScaleFactor};
        transform.localScale = localScale;
    }

    private static void PerformPositiveXYScale(Transform tf)
    {
        tf.localScale = tf.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
    }

    private static void PerformNegativeXScale(Transform tf)
    {
        tf.localScale = tf.localScale with {x = Plugin.NegativeScaleFactor};
    }

    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution(ref int width, ref int height)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
}