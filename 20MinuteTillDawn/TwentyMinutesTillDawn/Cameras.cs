using UnityEngine;

namespace TwentyMinutesTillDawn;

public static class Cameras
{
    public static void UpdateCameras()
    {
        foreach (var cam in Camera.allCameras)
        {
            if (cam.name.Equals(Patches.FogOfWarCamera))
            {
                cam.aspect = 1;
            }
            else
            {
                cam.aspect = (float) Display.main.systemWidth / Display.main.systemHeight;
            }
        }
    }
}