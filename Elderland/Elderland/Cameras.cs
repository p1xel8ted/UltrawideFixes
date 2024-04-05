using UnityEngine;

namespace Elderland;

public static class Cameras
{
    public static void UpdateCameras()
    {
        foreach (var cam in Camera.allCameras)
        {
            cam.aspect = Plugin.MainAspectRatio;
            cam.rect = new Rect(0, 0, 1, 1);
            cam.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        }
    }
}