using AK;
using AK.Wwise;
using Alkawa.Core;
using Gameplay.UI.Menu;
using Unity.Mathematics;
using UnityEngine.Video;
using Utils = BepInEx_IL2CPP.Utils;

namespace PrinceOfPersia;

[Harmony]
public static class Patches
{
    private const string CnvCharacter = "CNV_Character";
    private const string SargonSilhouette = "SargonSilhouette";
    private const string MainMenu = "MainMenu";
    private const string UpperLeft2Const = "HUDScaleRectParentUpperLeftCorner";
    private const string UpperLeft1Const = "HealthBar";
    private const string UpperRightConst = "HUDScaleRectParentUpperRight";
    private const string BottomLeftConst = "HUDScaleRectParentBottomLeft";
    private const string BottomRight1Const = "HUDScaleRectParentBottomRight";
    private const string BottomRight2Const = "FocusHUDWidget";

    private readonly static WriteOnce<Vector2> OriginalUpperLeft1 = new();
    private readonly static WriteOnce<Vector2> OriginalUpperLeft2 = new();
    private readonly static WriteOnce<Vector2> OriginalUpperRight = new();
    private readonly static WriteOnce<Vector2> OriginalBottomLeft = new();
    private readonly static WriteOnce<Vector2> OriginalBottomRight1 = new();
    private readonly static WriteOnce<Vector2> OriginalBottomRight2 = new();
    private static float BaseAspect => 16f / 9f;
    private static float CurrentAspect => (float) Screen.width / Screen.height;
    private static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    private static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    private static float NormalWidth => CurrentHeight * BaseAspect;
    private static float CurrentWidth => Screen.width;
    private static float CurrentHeight => Screen.height;
    private static float AspectGap => (CurrentWidth - NormalWidth) / 2f;
    private static int MaxRefreshRate => Screen.resolutions.Max(a => a.refreshRate);

    private static RectTransform UpperLeft1 { get; set; }
    private static RectTransform UpperLeft2 { get; set; }
    private static RectTransform UpperRight { get; set; }
    private static RectTransform BottomLeft { get; set; }
    private static RectTransform BottomRight1 { get; set; }
    private static RectTransform BottomRight2 { get; set; }


    private static void UpdatePositions()
    {
        Plugin.Instance.Config.Reload();

        if (UpperLeft1 == null || UpperLeft2 == null || UpperRight == null || BottomLeft == null || BottomRight1 == null || BottomRight2 == null) return;

        if (!Plugin.ExpandUI.Value)
        {
            UpperLeft1.anchoredPosition = OriginalUpperLeft1.Value += new Vector2(AspectGap, 0);
            UpperLeft2.anchoredPosition = OriginalUpperLeft2.Value += new Vector2(AspectGap, 0);
            UpperRight.anchoredPosition = OriginalUpperRight.Value -= new Vector2(AspectGap, 0);
            BottomLeft.anchoredPosition = OriginalBottomLeft.Value += new Vector2(AspectGap, 0);
            BottomRight1.anchoredPosition = OriginalBottomRight1.Value -= new Vector2(AspectGap, 0);
            BottomRight2.anchoredPosition = OriginalBottomRight2.Value -= new Vector2(AspectGap, 0);
        }
        else
        {
            UpperLeft1.anchoredPosition = OriginalUpperLeft1.Value;
            UpperLeft2.anchoredPosition = OriginalUpperLeft2.Value;
            UpperRight.anchoredPosition = OriginalUpperRight.Value;
            BottomLeft.anchoredPosition = OriginalBottomLeft.Value;
            BottomRight1.anchoredPosition = OriginalBottomRight1.Value;
            BottomRight2.anchoredPosition = OriginalBottomRight2.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        UpdatePositions();

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        Application.targetFrameRate = Screen.currentResolution.refreshRate;

        if (!__instance.name.Equals(CnvCharacter)) return;

        var player = __instance.transform.FindChild(SargonSilhouette);
        if (player != null)
        {
            player.localScale = player.localScale with {x = PositiveScaleFactor};
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OpenWorldMap))]
    public static void UIManager_OpenWorldMap()
    {
        UIManager.Instance.m_playerMap.Config.m_autoDiscoverZone = true;
        UIManager.Instance.m_playerMap.Config.m_autoDiscoverZoneSize = float.MaxValue;
        UIManager.Instance.m_playerMap.m_activeRefresh = true;
        UIManager.Instance.m_playerMap.UpdateAutoDiscover(true);

        // Plugin.Logger.LogWarning("------------m_canvasWorldMap----------------");
        // foreach (var comp in UIManager.Instance.m_canvasWorldMap.GetComponentsInChildren<Component>())
        // {
        //     var mb = comp.TryCast<MonoBehaviour>();
        //     if (mb != null)
        //     {
        //         Plugin.Logger.LogWarning(mb.GetScriptClassName());
        //         
        //     }
        // }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OnMenuClosedBackToGameplay))]
    public static void UIManager_OnMenuClosedBackToGameplay()
    {
        SwitchToUltra();
    }

    private static void SwitchToSixteenByNine()
    {
        Screen.SetResolution((int) (Display.main.systemHeight * (16f / 9f)), Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);
    }

    private static void SwitchToUltra()
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        var source = __instance.source == VideoSource.Url ? __instance.url : __instance.clip.name;
        if (source.Contains("UBISOFTSWIRL"))
        {
            __instance.targetCameraAlpha = 0f;
            __instance.playbackSpeed = 10000f;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoController), nameof(VideoController.OnVideoPrepared))]
    public static void VideoPlayer_ResumeVideo()
    {
        SwitchToSixteenByNine();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Stop))]
    [HarmonyPatch(typeof(VideoController), nameof(VideoController.StopVideo))]
    public static void VideoController_StopVideo()
    {
        SwitchToUltra();
    }

    //can't SceneManager.sceneLoaded += action; because it crashes interop
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneController), nameof(SceneController.OnSceneLoaded))]
    public static void SceneController_OnSceneLoaded(Scene _scene)
    {
        if (UIManager.Instance == null) return;

        if (!(UIManager.Instance.m_canvasHUD != null & _scene.name.Equals(MainMenu))) return;

        UpperLeft2 = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperLeft2Const).GetComponent<RectTransform>(); //top left - appears to be just the potions
        UpperLeft1 = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperLeft1Const).GetComponent<RectTransform>(); //top left
        OriginalUpperLeft1.Value = UpperLeft1.anchoredPosition;
        OriginalUpperLeft2.Value = UpperLeft2.anchoredPosition;

        UpperRight = UIManager.Instance.m_canvasHUD.transform.FindChild(UpperRightConst).GetComponent<RectTransform>(); //top right
        OriginalUpperRight.Value = UpperRight.anchoredPosition;


        BottomLeft = UIManager.Instance.m_canvasHUD.transform.FindChild(BottomLeftConst).GetComponent<RectTransform>(); //bottom left
        OriginalBottomLeft.Value = BottomLeft.anchoredPosition;

        BottomRight1 = UIManager.Instance.m_canvasHUD.transform.FindChild(BottomRight1Const).GetComponent<RectTransform>(); //bottom right
        BottomRight2 = UIManager.Instance.m_canvasHUD.transform.FindChild(BottomRight2Const).GetComponent<RectTransform>(); //bottom right
        OriginalBottomRight1.Value = BottomRight1.anchoredPosition;
        OriginalBottomRight2.Value = BottomRight2.anchoredPosition;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.NearestResolution))]
    public static void ScreenResolutionHandler_NearestResolution(ref Resolution __result)
    {
        var myRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };

        __result = myRes;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsSupportedResolution))]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsValidAspectRatio))]
    public static void ScreenResolutionHandler_IsValid(ref bool __result)
    {
        __result = true;
    }
}