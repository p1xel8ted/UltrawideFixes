using Il2Cpp;
using Il2CppInterop.Runtime;
using MelonLoader;
using SeaOfStars;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: MelonInfo(typeof(SeaOfStarsUltrawide), "Sea of Stars Ultra-Wide", "0.1.6", "p1xel8ted")]

namespace SeaOfStars;

public class SeaOfStarsUltrawide : MelonMod
{
    private const string Overlay = "Overlay";
    private const string ScreenConst = "Screen";
    private const string CutsceneBarsClone = "CutsceneBars(Clone)";

    private const string LoadingScreen = "LoadingScreen";
    private const string Transition = "Transition";
    private const string SosOcean = "SoSOcean";

    private const string Fishing = "fishing";
    private const string InitialScene = "InitialScene";

    private static float NormalWidth => Display.main.systemHeight * 16f / 9f;
    private static float UltraWidth => Display.main.systemWidth;
    private static float Difference => UltraWidth - NormalWidth;
    private static float SplitDifference => Difference / 2f;

    private static float Height => Display.main.systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private bool FishingActive { get; set; }

    private static readonly List<CanvasUpscaleViewport> CanvasUpscaleViewports = new();

    private static GameObject LoadingScreenClone { get; set; }
    private static GameObject TransitionOneClone { get; set; }
    private static GameObject TransitionTwoClone { get; set; }

    public override void OnUpdate()
    {
        base.OnUpdate();

        LoadingScreenClone ??= GameObject.Find("UICanvas(Clone)/Modal/LoadingScreen(Clone)");
        TransitionOneClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)0");
        TransitionTwoClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)1");

        if (LoadingScreenClone == null || TransitionOneClone == null || TransitionTwoClone == null)
            return;

        var anyActive = LoadingScreenClone.activeSelf || TransitionOneClone.activeSelf || TransitionTwoClone.activeSelf;

        foreach (var v in CanvasUpscaleViewports)
        {
            v.enabled = !anyActive;
        }
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);
        if (sceneName.Equals(InitialScene))
        {
            Time.timeScale = 10000f;
        }
    }

    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasUnloaded(buildIndex, sceneName);
        if (sceneName.Equals(InitialScene))
        {
            Time.timeScale = 1f;
        }
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);

        FishingActive = SceneManager.GetActiveScene().name.ToLowerInvariant().Contains(Fishing);
        if (FishingActive)
        {
            Screen.SetResolution((int) NormalWidth, (int) Height, FullScreenMode.FullScreenWindow,
                MaxRefresh);
        }
        else
        {
            Screen.SetResolution((int) UltraWidth, (int) Height, FullScreenMode.FullScreenWindow,
                MaxRefresh);
        }

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
            if (c.name.Equals(CutsceneBarsClone))
            {
                c.enabled = false;
            }
        }


        var viewportScaler = Resources.FindObjectsOfTypeAll(Il2CppType.Of<CanvasUpscaleViewport>());
        foreach (var vs in viewportScaler)
        {
            var v = vs.TryCast<CanvasUpscaleViewport>();
            if (v == null) continue;
            if (FishingActive)
            {
                v.useCustomCanvasSize = false;
                v.customCanvasPos = new Vector2(0f, 0f);
            }
            else
            {
                v.useCustomCanvasSize = true;
                v.customCanvasPos = new Vector2(SplitDifference, 0f);
            }

            CanvasUpscaleViewports.Add(v);
        }

        var cameras = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Camera>());
        foreach (var cam in cameras)
        {
            var c = cam.TryCast<Camera>();
            if (c == null) continue;
            if (FishingActive)
            {
                c.aspect = NormalWidth / Height;
                c.pixelRect = new Rect(0, 0, NormalWidth, Height);
            }
            else
            {
                c.aspect = UltraWidth / Height;
                c.pixelRect = new Rect(0, 0, UltraWidth, Height);
            }
        }

        var pixelPerfects = Resources.FindObjectsOfTypeAll(Il2CppType.Of<PixelPerfectCamera>());
        foreach (var pp in pixelPerfects)
        {
            var p = pp.TryCast<PixelPerfectCamera>();
            if (p == null) continue;
            p.enabled = FishingActive;
        }

        var ocean = GameObject.Find(SosOcean);
        if (ocean != null)
        {
            ocean.transform.localScale = new Vector3(10f, 1f, 1f);
        }
    }
}