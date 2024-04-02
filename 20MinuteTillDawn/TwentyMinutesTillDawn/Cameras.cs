using UnityEngine;

namespace TwentyMinutesTillDawn;

public static class Cameras
{
    private static WriteOnce<float> OriginalOrthographicSize { get; } = new();
    
    public static void UpdateCameras()
    {
        foreach (var cam in Camera.allCameras)
        {
            if (cam.name.Equals(Patches.FogOfWarCamera))
            {
                OriginalOrthographicSize.Value = cam.orthographicSize;
                cam.orthographicSize =  OriginalOrthographicSize.Value * Plugin.PositiveScaleFactor;
                cam.aspect = 1;
            }
            else
            {
                cam.aspect = Plugin.MainAspectRatio;
            }
        }
    }
}