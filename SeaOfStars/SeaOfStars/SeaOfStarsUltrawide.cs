using Il2Cpp;
using Il2CppInterop.Runtime;
using MelonLoader;
using SeaOfStars;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

[assembly: MelonInfo(typeof(SeaOfStarsUltrawide), "Sea of Stars Ultra-Wide", "0.1.5", "p1xel8ted")]

namespace SeaOfStars;

public class SeaOfStarsUltrawide : MelonMod
{
    private const string Overlay = "Overlay";
    private const string ScreenConst = "Screen";
    private const string CutsceneBarsClone = "CutsceneBars(Clone)";
    private const string LoadingScreen = "LoadingScreen";
    private const string Transition = "Transition";

    private static float NormalWidth => Display.main.systemHeight * 16f / 9f;
    private static float UltraWidth => Display.main.systemWidth;
    private static float Difference => UltraWidth - NormalWidth;
    private static float SplitDifference => Difference / 2f;

    private static readonly List<CanvasUpscaleViewport> CanvasUpscaleViewports = new();

    //private static GameObject LoadingScreenClone { get; set; }
    private static GameObject TransitionOneClone { get; set; }
    private static GameObject TransitionTwoClone { get; set; }
    
    public override void OnUpdate()
    {
        base.OnUpdate();
        
        //LoadingScreenClone ??= GameObject.Find("UICanvas(Clone)/Modal/LoadingScreen(Clone)");
        TransitionOneClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)0");
        TransitionTwoClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)1");

        if (TransitionOneClone == null || TransitionTwoClone == null)
            return;

        var anyActive = TransitionOneClone.activeSelf || TransitionTwoClone.activeSelf;

        foreach (var v in CanvasUpscaleViewports)
        {
            v.enabled = !anyActive;
        }
    }


    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);
        var width = Display.main.systemWidth;
        var height = Display.main.systemHeight;
        var maxRefresh = Screen.resolutions.Max(a => a.refreshRate);
        Screen.SetResolution(width, height, FullScreenMode.FullScreenWindow,
            maxRefresh);
        Time.fixedDeltaTime = 1f / maxRefresh;

        var images = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Image>());
        foreach (var image in images)
        {
            var i = image.TryCast<Image>();
            if (i == null) continue;
            switch (i.name)
            {
                case Overlay:
                    i.enabled = false;
                    break;
                case ScreenConst:
                    if (i.transform.parent.name.Contains(LoadingScreen) ||
                        i.transform.parent.name.Contains(Transition))
                    {
                        i.transform.localScale = new Vector3(10f, 1f, 1f);
                        i.transform.position = new Vector3(i.transform.position.x - 440, i.transform.position.y,
                            i.transform.position.z);
                    }
                    else
                    {
                        i.enabled = false;
                    }

                    break;
            }
        }


        var canvas = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Canvas>());
        foreach (var can in canvas)
        {
            var c = can.TryCast<Canvas>();
            if (c == null) continue;
            if (!c.name.Equals(CutsceneBarsClone)) continue;
            c.enabled = false;
        }


        var viewportScaler = Resources.FindObjectsOfTypeAll(Il2CppType.Of<CanvasUpscaleViewport>());
        foreach (var vs in viewportScaler)
        {
            var v = vs.TryCast<CanvasUpscaleViewport>();
            if (v == null) continue;
            v.customCanvasPos = new Vector2(SplitDifference, 0);
            v.useCustomCanvasSize = true;
            CanvasUpscaleViewports.Add(v);
        }

        var cameras = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Camera>());
        foreach (var cam in cameras)
        {
            var c = cam.TryCast<Camera>();
            if (c == null) continue;
            c.aspect = (float) width / height;
            c.pixelRect = new Rect(0, 0, width, height);
        }

        var pixelPerfects = Resources.FindObjectsOfTypeAll(Il2CppType.Of<PixelPerfectCamera>());
        foreach (var pp in pixelPerfects)
        {
            var p = pp.TryCast<PixelPerfectCamera>();
            if (p == null) continue;
            p.refResolutionX = Display.main.systemWidth;
            p.refResolutionY = Display.main.systemHeight;
            p.enabled = true;
            p.cropFrameX = false;
            p.cropFrameY = false;
        }
    }
}