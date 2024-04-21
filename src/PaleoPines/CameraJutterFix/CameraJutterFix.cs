using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(CameraJutterFix.CameraJutterFix), "Camera Jutter Fix", "0.1.0", "p1xel8ted")]

namespace CameraJutterFix;

public class CameraJutterFix : MelonMod
{
    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);
        LoggerInstance.Warning("Original Time.fixedDeltaTime: " + Time.fixedDeltaTime);
        Time.fixedDeltaTime = 1 / (float) Screen.currentResolution.refreshRate;
        LoggerInstance.Warning("New Time.fixedDeltaTime: " + Time.fixedDeltaTime);
    }
}