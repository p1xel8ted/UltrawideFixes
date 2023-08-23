using Il2Cpp;
using Il2CppInterop.Runtime;
using MelonLoader;
using SeaOfStars;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[assembly: MelonInfo(typeof(SeaOfStarsUltrawide), "Sea of Stars Ultra-wide", "0.1.0", "p1xel8ted")]
[assembly: MelonGame("Sabotage Studio", "Sea of Stars Demo")]
// [assembly: MelonGame("Sabotage Studio", "Sea of Stars")]

namespace SeaOfStars;

public class SeaOfStarsUltrawide : MelonMod
{
    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);
        var width = Display.main.systemWidth;
        var height = Display.main.systemHeight;
        var maxRefresh = Screen.resolutions.Max(a => a.refreshRate);
        Screen.SetResolution(width, height, FullScreenMode.FullScreenWindow,
            maxRefresh);
        LoggerInstance.Warning($"Set resolution to {width}x{height}@{maxRefresh}Hz");
        LoggerInstance.Warning($"Old FixedDeltaTime: {Time.fixedDeltaTime}");
        Time.fixedDeltaTime = 1f / maxRefresh;
        LoggerInstance.Warning($"New FixedDeltaTime: {Time.fixedDeltaTime}");

        var cameras = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Camera>());
        foreach (var cam in cameras)
        {
            var c = cam.TryCast<Camera>();
            if (c == null) continue;

            c.pixelRect = new Rect(0, 0, Display.main.systemWidth, Display.main.systemHeight);
            c.aspect = Display.main.systemWidth / (float) Display.main.systemHeight;

            LoggerInstance.Warning($"Set camera {c.name} to {Display.main.systemWidth}x{Display.main.systemHeight}");
        }

        var pixelPerfects = Resources.FindObjectsOfTypeAll(Il2CppType.Of<PixelPerfectCamera>());
        foreach (var pp in pixelPerfects)
        {
            var p = pp.TryCast<PixelPerfectCamera>();
            if (p == null) continue;
            LoggerInstance.Warning($"Disabling PixelPerfectCamera {p.name}");
            p.enabled = false;
        }

        var stretchCameras = Resources.FindObjectsOfTypeAll(Il2CppType.Of<StretchCamera>());
        foreach (var sc in stretchCameras)
        {
            var s = sc.TryCast<StretchCamera>();
            if (s == null) continue;
            LoggerInstance.Warning($"Disabling StretchCamera {s.name}");
            s.enabled = false;
        }

        var ocean = GameObject.Find("SoSOcean");
        if (ocean == null) return;
        LoggerInstance.Warning($"Scaling Ocean");
        ocean.transform.localScale = new Vector3(4f, 1.0f, 1.0f);
    }
}