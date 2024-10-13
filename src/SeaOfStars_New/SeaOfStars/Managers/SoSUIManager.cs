// SoSuiManager.cs

using SeaOfStars.Core;

namespace SeaOfStars.Managers;

public static class SoSuiManager
{
    private static GameObject LoadingScreenClone { get; set; }
    private static GameObject TransitionOneClone { get; set; }
    private static GameObject TransitionTwoClone { get; set; }
    private static GameObject DialogueCutsceneGameObject { get; set; }
    private static CanvasUpscaleViewport UiCanvasViewPort { get; set; }
    internal static GameObject FishingScreen { get; private set; }
    internal static int CanvasPosition => CalculateX(DisplayManager.MainWidth);
    internal static List<CanvasUpscaleViewport> CanvasUpscaleViewports => Utilities.Utilities.FindIl2CppType<CanvasUpscaleViewport>().ToList();
    private static List<PixelPerfectCamera> PixelPerfectCameras => Utilities.Utilities.FindIl2CppType<PixelPerfectCamera>().ToList();
    private static GameObject DialogueCutsceneBox => GameObject.Find($"{Constants.UiCanvasClone}/Modal/NewDialogBox(Clone)");

    public static void ProcessSceneElements(string sceneName)
    {
        ProcessImages();
        ProcessCanvas(sceneName);
        ProcessViewportScaler();
        ProcessPixelPerfectCameras(sceneName);
        AdjustOceanScale();
        FindUIElements();
        AdjustLoadTransitionScale();
        UpdateLoadTransitionCanvasUpscaleViewports();
        DisableWeirdUI();
    }

    private static int CalculateX(float targetWidth)
    {
        const float referenceWidth = 2560f;
        const float ratio = 110f / 880f;
        var targetDeltaWidth = targetWidth - referenceWidth;
        return Mathf.RoundToInt(ratio * targetDeltaWidth);
    }

    public static void HandleShiftViewportViaUI()
    {
        foreach (var v in CanvasUpscaleViewports.Where(v => v != null))
        {
            v.customCanvasPos = new Vector2(Configuration.Configuration.UiPosition.Value, 0f);
        }
    }

    public static void HandleConfigManager(bool isVisible)
    {
        foreach (var vp in CanvasUpscaleViewports.Where(vp => vp != null))
        {
            vp.enabled = !isVisible;
        }

        foreach (var pp in PixelPerfectCameras.Where(pp => pp != null))
        {
            pp.refResolutionX = isVisible ? DisplayManager.MainWidth : 640;
            pp.refResolutionY = isVisible ? DisplayManager.MainHeight : 360;
        }
    }

    internal static void FindUIElements()
    {
        LoadingScreenClone ??= GameObject.Find($"{Constants.UiCanvasClone}/Modal/{Constants.LoadingScreen}(Clone)");
        TransitionOneClone ??= GameObject.Find($"{Constants.UiCanvasClone}/Modal/ColorFadeTransitionScreen(Clone)0");
        TransitionTwoClone ??= GameObject.Find($"{Constants.UiCanvasClone}/Modal/ColorFadeTransitionScreen(Clone)1");
        DialogueCutsceneGameObject ??= GameObject.Find($"{Constants.UiCanvasClone}/Modal/NewDialogBox(Clone)");

        var uiCanvas = GameObject.Find(Constants.UiCanvasClone);
        if (uiCanvas)
        {
            UiCanvasViewPort = uiCanvas.GetComponent<CanvasUpscaleViewport>();
        }
    }

    private static void ProcessImages()
    {
        var images = Utilities.Utilities.FindIl2CppType<Image>();
        foreach (var i in images)
        {
            switch (i.name)
            {
                case Constants.Overlay:
                    i.enabled = false;
                    break;
                case Constants.ScreenConst:
                    if (i.transform.parent.name.Contains(Constants.LoadingScreen) || i.transform.parent.name.Contains(Constants.Transition))
                    {
                        i.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
                    }
                    else
                    {
                        i.enabled = false;
                    }

                    break;
            }
        }
    }

    private static void ProcessCanvas(string sceneName)
    {
        var canvases = Utilities.Utilities.FindIl2CppType<Canvas>();
        foreach (var c in canvases)
        {
            switch (c.name)
            {
                case Constants.CutsceneBarsClone:
                    c.enabled = false;
                    break;
                case Constants.Fishing:
                    FishingScreen = sceneName.StartsWith(Constants.Wizard) ? null : c.gameObject;
                    break;
            }
        }
    }

    private static void ProcessViewportScaler()
    {
        foreach (var v in CanvasUpscaleViewports.Where(v => v != null))
        {
            v.useCustomCanvasSize = true;
            v.customCanvasPos = new Vector2(Configuration.Configuration.UiPosition.Value, 0f);
        }
    }

    private static void ProcessPixelPerfectCameras(string sceneName)
    {
        foreach (var p in PixelPerfectCameras.Where(p => p != null && !p.name.Equals("SplashCamera")))
        {
            if (sceneName.Equals(Constants.InitialScene) || p.name.Equals(Constants.VideoPlayerCamera))
            {
                p.cropFrameX = true;
                p.cropFrameY = true;
            }
            else
            {
                p.cropFrameX = false;
                p.cropFrameY = false;
            }

            p.upscaleRT = true;
            p.pixelSnapping = true;
        }
    }

    private static void AdjustOceanScale()
    {
        var ocean = GameObject.Find(Constants.SosOcean);
        if (ocean)
        {
            ocean.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }
    }

    internal static void AdjustLoadTransitionScale()
    {
        if (LoadingScreenClone)
        {
            LoadingScreenClone.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }


        if (TransitionOneClone)
        {
            TransitionOneClone.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }


        if (TransitionTwoClone)
        {
            TransitionTwoClone.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }
    }

    internal static void UpdateLoadTransitionCanvasUpscaleViewports()
    {
        if (ConfigManager.UI.UIManager.ShowMenu || LoadingScreenClone == null || TransitionOneClone == null || TransitionTwoClone == null) return;

        var anyActive = LoadingScreenClone.activeSelf || TransitionOneClone.activeSelf || TransitionTwoClone.activeSelf;
        foreach (var viewport in CanvasUpscaleViewports.Where(viewport => viewport != null))
        {
            viewport.enabled = !anyActive;
        }

        if (UiCanvasViewPort && DialogueCutsceneBox && DialogueCutsceneBox.activeSelf)
        {
            State.IsResolutionUpdated = false;
            UiCanvasViewPort.enabled = true;
            UiCanvasViewPort.useCustomCanvasSize = false;

            foreach (var pp in PixelPerfectCameras.Where(pp => pp != null && !pp.name.Equals("SplashCamera")))
            {
                pp.refResolutionX = DisplayManager.MainWidth;
                pp.refResolutionY = DisplayManager.MainHeight;
            }
        }
        else if (!State.IsResolutionUpdated)
        {
            UiCanvasViewPort.useCustomCanvasSize = true;

            foreach (var pp in PixelPerfectCameras.Where(pp => pp != null && !pp.name.Equals("SplashCamera")))
            {
                pp.refResolutionX = 640;
                pp.refResolutionY = 360;
            }

            State.IsResolutionUpdated = true;
        }
    }

    private static void DisableWeirdUI()
    {
        var go = GameObject.Find(Constants.InventoryMarkerThing);
        if (go)
        {
            go.SetActiveRecursively(false);
        }
    }

    internal static void UpdateFishingViewportsIfNeeded()
    {
        if (State.FishingActive && !State.FishingViewPortUpdated)
        {
            UpdateFishingViewports();
        }
    }

    private static void UpdateFishingViewports()
    {
        if (State.FishingActive)
        {
            DisplayManager.SetResolution(true);
            foreach (var viewport in CanvasUpscaleViewports.Where(viewport => viewport != null))
            {
                viewport.useCustomCanvasSize = false;
                viewport.customCanvasPos = Vector2.zero;
            }
        }

        State.FishingViewPortUpdated = true;
    }
}