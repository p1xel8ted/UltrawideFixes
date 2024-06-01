namespace PrinceOfPersia;

[Harmony]
public static class Patches
{
    private const string CnvCharacter = "CNV_Character";
    private const string SargonSilhouette = "SargonSilhouette";
    private const float BaseAspect = 16f / 9f;

    private const string MainMenu = "MainMenu";
    private const string UpperLeft2Const = "HUDScaleRectParentUpperLeftCorner";
    private const string UpperLeft1Const = "HealthBar";
    private const string UpperRightConst = "HUDScaleRectParentUpperRight";
    private const string BottomLeftConst = "HUDScaleRectParentBottomLeft";
    private const string BottomRight1Const = "HUDScaleRectParentBottomRight";
    private const string BottomRight2Const = "FocusHUDWidget";
    private const string UbisoftSwirl = "UBISOFTSWIRL";
    private const string UpperLeft3Const = "Amulets";
    private static bool Switching;

    // private readonly static WriteOnce OriginalUpperLeft1 = new();
    // private readonly static WriteOnce OriginalUpperLeft2 = new();
    // private readonly static WriteOnce OriginalUpperLeft3 = new();
    // private readonly static WriteOnce OriginalUpperRight = new();
    // private readonly static WriteOnce OriginalBottomLeft = new();
    // private readonly static WriteOnce OriginalBottomRight1 = new();
    // private readonly static WriteOnce OriginalBottomRight2 = new();
    private static float CurrentAspect => (float) Display._mainDisplay.systemWidth / Display._mainDisplay.systemHeight;
    private static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    // private static float NegativeScaleFactor => 1f / PositiveScaleFactor;

    private static RectTransform UpperLeft1 { get; set; }
    private static RectTransform UpperLeft2 { get; set; }
    private static RectTransform UpperLeft3 { get; set; }
    private static RectTransform UpperRight { get; set; }
    private static RectTransform BottomLeft { get; set; }
    private static RectTransform BottomRight1 { get; set; }
    private static RectTransform BottomRight2 { get; set; }

    private static float NormalWidth => CurrentHeight * BaseAspect;
    private static float CurrentWidth => Screen.width;
    private static float CurrentHeight => Screen.height;
    private static float AspectGap => (CurrentWidth - NormalWidth) / 2f;


    //can't SceneManager.sceneLoaded += action; because it crashes interop
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneController_OnSceneLoaded(Scene scene)
    {
        SwitchToUltra();
        // if (UIManager.Instance == null) return;
        //
        // if (!(UIManager.Instance.m_canvasHUD != null & scene.name.Equals(MainMenu))) return;
        //
        // UpperLeft2 = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperLeft2Const).GetComponent<RectTransform>(); //top left - appears to be just the potions
        // UpperLeft1 = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperLeft1Const).GetComponent<RectTransform>(); //top left - health
        // UpperLeft3 = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperLeft3Const).GetComponent<RectTransform>(); //top left - amulets
        // OriginalUpperLeft1.Value = UpperLeft1.anchoredPosition;
        // OriginalUpperLeft2.Value = UpperLeft2.anchoredPosition;
        // OriginalUpperLeft3.Value = UpperLeft3.anchoredPosition;
        //
        // UpperRight = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperRightConst).GetComponent<RectTransform>(); //top right
        // OriginalUpperRight.Value = UpperRight.anchoredPosition;
        //
        //
        // BottomLeft = UIManager.Instance.m_canvasHUD.transform.FindChild(BottomLeftConst).GetComponent<RectTransform>(); //bottom left
        // OriginalBottomLeft.Value = BottomLeft.anchoredPosition;
        //
        // BottomRight1 = UIManager.Instance.m_canvasHUD.transform.FindChild(BottomRight1Const).GetComponent<RectTransform>(); //bottom right
        // BottomRight2 = UIManager.Instance.m_canvasHUD.transform.FindChild(BottomRight2Const).GetComponent<RectTransform>(); //bottom right
        // OriginalBottomRight1.Value = BottomRight1.anchoredPosition;
        // OriginalBottomRight2.Value = BottomRight2.anchoredPosition;
    }

    // private static void UpdatePositions()
    // {
    //     Plugin.ConfigInstance.Reload();
    //
    //     if (UpperLeft1 == null || UpperLeft2 == null || UpperRight == null || BottomLeft == null || BottomRight1 == null || BottomRight2 == null) return;
    //
    //     if (!Plugin.ExpandUI.Value)
    //     {
    //         UpperLeft1.anchoredPosition = OriginalUpperLeft1.Value += new Vector2(AspectGap, 0);
    //         UpperLeft2.anchoredPosition = OriginalUpperLeft2.Value += new Vector2(AspectGap, 0);
    //         UpperLeft3.anchoredPosition = OriginalUpperLeft3.Value += new Vector2(AspectGap, 0);
    //         BottomLeft.anchoredPosition = OriginalBottomLeft.Value += new Vector2(AspectGap, 0);
    //         UpperRight.anchoredPosition = OriginalUpperRight.Value -= new Vector2(AspectGap, 0);
    //         BottomRight1.anchoredPosition = OriginalBottomRight1.Value -= new Vector2(AspectGap, 0);
    //         BottomRight2.anchoredPosition = OriginalBottomRight2.Value -= new Vector2(AspectGap, 0);
    //     }
    //     else
    //     {
    //         UpperLeft1.anchoredPosition = OriginalUpperLeft1.Value;
    //         UpperLeft2.anchoredPosition = OriginalUpperLeft2.Value;
    //         UpperLeft3.anchoredPosition = OriginalUpperLeft3.Value;
    //         UpperRight.anchoredPosition = OriginalUpperRight.Value;
    //         BottomLeft.anchoredPosition = OriginalBottomLeft.Value;
    //         BottomRight1.anchoredPosition = OriginalBottomRight1.Value;
    //         BottomRight2.anchoredPosition = OriginalBottomRight2.Value;
    //     }
    // }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoController), nameof(VideoController.OnVideoPrepared))]
    public static void VideoPlayer_OnVideoPrepared()
    {
        //aspect ratio setting is ignored/overridden elsewhere hence this hacky method
        SwitchToSixteenByNine(FullScreenMode.FullScreenWindow);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Stop))]
    public static void VideoController_Stop()
    {
        //aspect ratio setting is ignored/overridden elsewhere hence this hacky method
        SwitchToUltra();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoController), nameof(VideoController.StopVideo))]
    public static void VideoController_StopVideo()
    {
        SwitchToUltra();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        var source = __instance.source == VideoSource.Url ? __instance.url : __instance.clip.name;
        if (!source.Contains(UbisoftSwirl)) return;
        __instance.targetCameraAlpha = 0f;
        __instance.playbackSpeed = 10000f;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        var refRes = __instance.referenceResolution;
        refRes.x = Mathf.RoundToInt(refRes.y * CurrentAspect);
        __instance.referenceResolution = refRes;
        
        if (!__instance.name.Equals(CnvCharacter)) return;

        //fixes sargon being squished on the menu screen in game
        var player = __instance.transform.FindChild(SargonSilhouette);
        if (player != null)
        {
            player.localScale = player.localScale with {x = PositiveScaleFactor};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OnPlayerChangingLevel))]
    public static void UIManager_OnPlayerChangingLevel()
    {
        Plugin.ConfigInstance.Reload();

        //UpdatePositions();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OpenWorldMap))]
    public static void UIManager_OpenWorldMap()
    {
        Plugin.ConfigInstance.Reload();

        UIManager.Instance.PlayerMap.m_showFog = !Plugin.RemoveAllMapFog.Value;

        SwitchToUltra();

       // UpdatePositions();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OnMenuClosedBackToGameplay))]
    public static void UIManager_OnMenuClosedBackToGameplay()
    {
        SwitchToUltra();
    }
    
    private static void SwitchToSixteenByNine(FullScreenMode fsMode)
    {
        var res = new Resolution
        {
            width = Mathf.RoundToInt(Display._mainDisplay.systemHeight * (16f / 9f)),
            height = Display._mainDisplay.systemHeight,
        };
        Switching = true;
        ScreenResolutionHandler.Instance.SetResolution(res, fsMode);
        Switching = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.SetResolution))]
    public static void ScreenResolutionHandler_SetResolution(ref Resolution r, ref FullScreenMode fsMode)
    {
        if (Switching) return;
        r.width = Display._mainDisplay.systemWidth;
        r.height = Display._mainDisplay.systemHeight;
        fsMode = FullScreenMode.FullScreenWindow;
    }


    private static void SwitchToUltra()
    {
        var res = new Resolution
        {
            width = Display._mainDisplay.systemWidth,
            height = Display._mainDisplay.systemHeight,
        };
        ScreenResolutionHandler.Instance.SetResolution(res, FullScreenMode.FullScreenWindow);
    }
}