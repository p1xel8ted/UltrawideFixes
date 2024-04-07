using UnityEngine;

namespace DisplayTweaks.AspectRatio;

public static class AspectRatioFixes
{
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

    // internal static void RunDisplayFixes()
    // {
    //     Display.displays[Plugin.DisplayToUse.Value].Activate(Plugin.MainWidth, Plugin.MainHeight, Plugin.MaxRefresh);
    //     Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, Plugin.FullScreenModeConfig.Value, Plugin.MaxRefresh);
    //     Application.targetFrameRate = Plugin.MaxRefresh;
    //     Time.fixedDeltaTime = 1f / Plugin.MaxRefresh;
    // }
}