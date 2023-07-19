using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(WonhonSpirit.WonhonSpirit), "Wonhon Spirit UltraWide Fixes", "0.0.2", "p1xel8ted")]
[assembly: MelonGame("busan_sanai_games", "Wonhon")]

namespace WonhonSpirit;

public class WonhonSpirit : MelonMod
{
    internal static int RefreshRate { get; set; } = 60;

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);
        var ar = Screen.width / (float) Screen.height;
        const float originalAr = 16f / 9f;
        if (ar > originalAr)
        {
            foreach (var camera in Camera.allCameras)
            {
                camera.aspect = Screen.width / (float) Screen.height;
            }
        }

        RefreshRate = Screen.resolutions.Max(x => x.refreshRate);
        Application.targetFrameRate = RefreshRate;
    }
}