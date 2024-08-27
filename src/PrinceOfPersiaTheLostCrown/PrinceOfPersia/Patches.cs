using Gameplay.UI.Menu;

namespace PrinceOfPersia;

[Harmony]
public static class Patches
{
    // private const string CnvCharacter = "CNV_Character";
    // private const string SargonSilhouette = "SargonSilhouette";
    // private const float BaseAspect = 16f / 9f;
    private const string UbisoftSwirl = "UBISOFTSWIRL";
    //
    // private static bool Switching;
    //
    // private readonly static float CurrentAspect = (float) Display._mainDisplay.systemWidth / Display._mainDisplay.systemHeight;
    // private readonly static float PositiveScaleFactor = CurrentAspect / BaseAspect;

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneController_OnSceneLoaded(Scene scene)
    {
        var cameras = UnityEngine.Object.FindObjectsOfType<Camera>();
        foreach (var cam in cameras)
        {
            cam.aspect = 16f / 9f;
            cam.pixelRect = new Rect(440, 0, Display._mainDisplay.systemHeight * (16f / 9f), Display._mainDisplay.systemHeight);
            cam.rect = new Rect(0, 0, 1, 1);
            Plugin.Logger.LogWarning($"Camera: {cam.gameObject.GetPath()} - {cam.aspect} - {cam.pixelRect} - {cam.rect}");
        }
    }

    private static string GetPath(this GameObject obj)
    {
        string path = "/" + obj.name;
        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }
        return path;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoController), nameof(VideoController.OnVideoPrepared))]
    public static void VideoPlayer_OnVideoPrepared(VideoController __instance)
    {
        SwitchToSixteenByNine(FullScreenMode.FullScreenWindow);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoController), nameof(VideoController.StopVideo))]
    public static void VideoController_StopVideo(VideoController __instance)
    {
        SwitchToUltra();
    }


    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Stop))]
    // public static void VideoController_Stop(VideoController __instance)
    // {
    //     //aspect ratio setting is ignored/overridden elsewhere hence this hacky method
    //     SwitchToUltra();
    // }



    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
        var source = __instance.source == VideoSource.Url ? __instance.url : __instance.clip.name;
        if (!source.Contains(UbisoftSwirl)) return;
        __instance.targetCameraAlpha = 0f;
        __instance.playbackSpeed = 10000f;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        Plugin.Logger.LogWarning($"CanvasScaler: {__instance.gameObject.GetPath()}");
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OnPlayerChangingLevel))]
    public static void UIManager_OnPlayerChangingLevel()
    {
        Plugin.ConfigInstance.Reload();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.OpenWorldMap))]
    public static void UIManager_OpenWorldMap()
    {
        Plugin.ConfigInstance.Reload();

        if (UIManager.Instance)
        {
            UIManager.Instance.PlayerMap.m_showFog = true;
            UIManager.Instance.PlayerMap.m_autoUnfogCurrentLevel = false;
        }

        SwitchToSixteenByNine(FullScreenMode.FullScreenWindow);
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

        if (ScreenResolutionHandler.Instance)
        {
            ScreenResolutionHandler.Instance.SetResolution(res, fsMode);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsValidAspectRatio))]
    public static void ScreenResolutionHandler_IsValidAspectRatio(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsSupportedResolution))]
    public static void ScreenResolutionHandler_IsSupportedResolution(ref bool __result)
    {
        __result = true;
    }

    private static void SwitchToUltra()
    {
        var res = new Resolution
        {
            width = Display._mainDisplay.systemWidth,
            height = Display._mainDisplay.systemHeight,
        };
        if (ScreenResolutionHandler.Instance)
        {
            ScreenResolutionHandler.Instance.SetResolution(res, FullScreenMode.FullScreenWindow);
        }
    }
}