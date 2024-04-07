using HyperGames.Helpers;

namespace Snufkin.AspectRatio;

public static class AspectRatioFixes
{
    internal static void RunScalerFixes()
    {
        var canvasScalers = Resources.FindObjectsOfTypeAll<CanvasScaler>();
        foreach (var canvasScaler in canvasScalers)
        {
            Plugin.LOG.LogWarning($"CanvasScaler: {canvasScaler.name}. Original ScreenMatchMode: {canvasScaler.screenMatchMode}");
            canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
    internal static void RunVideoPlayerFixes()
    {
        var videoPlayers = Resources.FindObjectsOfTypeAll<VideoPlayer>();
        foreach (var videoPlayer in videoPlayers)
        {
            videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
        }
    }
    
    internal static void CameraRatioRestrictorFixes()
    {
        var cameraRatioRestrictors = Resources.FindObjectsOfTypeAll<CameraRatioRestrictor>();
        foreach (var crr in cameraRatioRestrictors)
        {
            crr._camAspect = Plugin.MainAspectRatio;
            crr._screenHeight = Plugin.MainHeight;
            crr._screenWidth = Plugin.MainWidth;
            crr._maxRatioLandscape = Plugin.SimplifiedMainAspect;
            crr._showPillar = false;
            crr._camScreenHeight = Plugin.MainHeight;
            crr._camScreenWidth = Plugin.MainWidth;

        }
    }

    
    
    private readonly static string[] MeshRendersToProcess = ["Skies", "Seas"];
    internal static void RunMeshFixes()
    {
        var meshRenderers = Resources.FindObjectsOfTypeAll<MeshRenderer>();
        foreach (var mr in meshRenderers)
        {
            if (!MeshRendersToProcess.Contains(mr.name)) continue;
            
            var x = mr.transform.localScale.x * Plugin.PositiveScaleFactor;
            mr.transform.localScale = mr.transform.localScale with {x = x};
        }
    }
    
    internal static void RunCameraFixes()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            camera.aspect = Plugin.MainAspectRatio;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        }
    }

    internal static void RunDisplayFixes()
    {
        Display.displays[Plugin.DisplayToUse.Value].Activate(Plugin.MainWidth, Plugin.MainHeight, Plugin.MaxRefresh);
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, Plugin.FullScreenModeConfig.Value, Plugin.MaxRefresh);
        Application.targetFrameRate = Plugin.MaxRefresh;
        Time.fixedDeltaTime = 1f / Plugin.MaxRefresh;
    }
}