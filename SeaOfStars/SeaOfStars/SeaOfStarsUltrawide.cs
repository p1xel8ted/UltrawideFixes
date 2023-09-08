using Il2Cpp;
using Il2CppInterop.Runtime;
using MelonLoader;
using SeaOfStars;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

[assembly: MelonInfo(typeof(SeaOfStarsUltrawide), "Sea of Stars Ultra-Wide", "0.1.8", "p1xel8ted")]

namespace SeaOfStars;

public class SeaOfStarsUltrawide : MelonMod
{
    private const string Overlay = "Overlay";
    private const string ScreenConst = "Screen";
    private const string CutsceneBarsClone = "CutsceneBars(Clone)";
    private const string LoadingScreen = "LoadingScreen";
    private const string Transition = "Transition";
    private const string SosOcean = "SoSOcean";
    private const string Fishing = "FishingPanelScreen(Clone)";
    private const string InitialScene = "InitialScene";

    private static float NormalWidth => Display.main.systemHeight * 16f / 9f;
    private static float UltraWidth => Display.main.systemWidth;
    //private static float Difference => UltraWidth - NormalWidth;
    //private static float SplitDifference => Difference / 2f;
    private static float Height => Display.main.systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private bool FishingActive { get; set; }
    private static List<CanvasUpscaleViewport> CanvasUpscaleViewports { get; } = new();
    private static GameObject LoadingScreenClone { get; set; }
    private static GameObject TransitionOneClone { get; set; }
    private static GameObject TransitionTwoClone { get; set; }
    private static GameObject FishingScreen { get; set; }
    private bool FishingViewPortUpdated { get; set; }
    
    private MelonPreferences_Category SeaOfStarsCategory { get; set; }
    private MelonPreferences_Entry<int> SeaOfStarsUiEntry { get; set; }

    private static float CanvasOffset => CalculateCenteredPosition(UltraWidth, Height);

    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();
        FishingViewPortUpdated = false;
        FishingActive = false;
        
        SeaOfStarsCategory = MelonPreferences.CreateCategory("Sea of Stars Ultra-Wide");
        SeaOfStarsUiEntry = SeaOfStarsCategory.CreateEntry("UI Offset", (int) CanvasOffset);
        MelonPreferences.Save();
    }

    private static float CalculateCenteredPosition(float screenWidth, float screenHeight)
    {
        // Calculate the 16:9 width based on the screen height
        var heightBased16By9Width = screenHeight * 16 / 9;

        // Calculate the perfect centering offset
        var perfectCenterOffset = (screenWidth - heightBased16By9Width) / 2;

        // Visual centering discrepancy derived from the 3440x1440 resolution
        const float visualCenterDiscrepancy = 340;

        // Return the visually centered position
        return perfectCenterOffset - visualCenterDiscrepancy;
    }

    private void ShiftViewportLeft()
    {
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            var newOffset = v.customCanvasPos.x - 1f;
            v.customCanvasPos = new Vector2(newOffset, 0f);
            SeaOfStarsUiEntry.Value = (int) newOffset;
            MelonPreferences.Save();
        }  
    }
    
    private void ShiftViewportRight()
    {
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            var newOffset = v.customCanvasPos.x + 1f;
            v.customCanvasPos = new Vector2(newOffset, 0f);
            SeaOfStarsUiEntry.Value = (int) newOffset;
            MelonPreferences.Save();
        }  
    }

    private void ResetViewports()
    {
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            v.customCanvasPos = new Vector2(CanvasOffset, 0f);
            SeaOfStarsUiEntry.Value = (int) CanvasOffset;
            MelonPreferences.Save();
        }    
    }
    
    public override void OnUpdate()
    {
        base.OnUpdate();

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            // Hold behavior with Shift key pressed.
            if (Input.GetKey(KeyCode.KeypadMinus))
            {
                ShiftViewportLeft();
            }
            if (Input.GetKey(KeyCode.KeypadPlus))
            {
                ShiftViewportRight();
            }
        }
        else
        {
            // Single press behavior without Shift key pressed.
            if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                ShiftViewportLeft();
            }
            if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                ShiftViewportRight();
            }
        }

        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            ResetViewports();
        }
        
        LoadingScreenClone ??= GameObject.Find("UICanvas(Clone)/Modal/LoadingScreen(Clone)");
        TransitionOneClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)0");
        TransitionTwoClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)1");

        if (LoadingScreenClone == null || TransitionOneClone == null || TransitionTwoClone == null)
            return;

        var anyActive = LoadingScreenClone.activeSelf || TransitionOneClone.activeSelf || TransitionTwoClone.activeSelf;

        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            v.enabled = !anyActive;
        }

        if (FishingActive && !FishingViewPortUpdated)
        {
            UpdateFishingViewports();
        }
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);
        if (sceneName.Equals(InitialScene))
        {
            Time.timeScale = 10000f;
        }

        FishingActive = FishingScreen != null;
    }

    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasUnloaded(buildIndex, sceneName);
        if (sceneName.Equals(InitialScene))
        {
            Time.timeScale = 1f;
        }

        if (FishingScreen != null)
        {
            FishingViewPortUpdated = false;
            FishingActive = true;
        }
        else
        {
            FishingActive = false;
        }
    }

    private void UpdateFishingViewports()
    {
        Screen.SetResolution((int) NormalWidth, (int) Height, FullScreenMode.FullScreenWindow,
            MaxRefresh);

        foreach (var viewport in CanvasUpscaleViewports.Where(viewport => viewport != null && FishingActive))
        {
            viewport.useCustomCanvasSize = false;
            viewport.customCanvasPos = new Vector2(0f, 0f);
        }

        FishingViewPortUpdated = true;
    }

    // private static float CalculateCenteredPosition(float screenWidth, float screenHeight, float canvasHeight)
    // {
    //     // Calculate the 16:9 width for the given screen width
    //     var width16By9 = screenHeight * 16 / 9;
    //
    //     // Calculate the extra space in the horizontal dimension
    //     var extraWidth = screenWidth - width16By9;
    //     var horizontalOffset = extraWidth / 2;
    //
    //     // Calculate the extra space in the vertical dimension
    //     var extraHeight = screenHeight - canvasHeight;
    //     var verticalOffset = extraHeight / 2;
    //
    //     // Calculate the apparent center offset
    //     var apparentCenterOffset = verticalOffset - horizontalOffset;
    //
    //     return apparentCenterOffset;
    // }

    
    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        base.OnSceneWasInitialized(buildIndex, sceneName);

        Screen.SetResolution((int) UltraWidth, (int) Height, FullScreenMode.FullScreenWindow,
            MaxRefresh);

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
            switch (c.name)
            {
                case CutsceneBarsClone:
                    c.enabled = false;
                    break;
                case Fishing:
                    FishingScreen = c.gameObject;
                    break;
            }
        }

        var viewportScaler = Resources.FindObjectsOfTypeAll(Il2CppType.Of<CanvasUpscaleViewport>());
        foreach (var vs in viewportScaler)
        {
            var v = vs.TryCast<CanvasUpscaleViewport>();
            if (v == null) continue;
            v.useCustomCanvasSize = true;
            v.customCanvasPos = new Vector2(SeaOfStarsUiEntry.Value, 0f);
            CanvasUpscaleViewports.Add(v);
        }

        var pixelPerfects = Resources.FindObjectsOfTypeAll(Il2CppType.Of<PixelPerfectCamera>());
        foreach (var pp in pixelPerfects)
        {
            var p = pp.TryCast<PixelPerfectCamera>();
            if (p == null) continue;
            p.enabled = true;
            p.refResolutionX = 640;
            p.refResolutionY = 360;
            p.cropFrameX = false;
            p.cropFrameY = false;
        }

        var ocean = GameObject.Find(SosOcean);
        if (ocean != null)
        {
            ocean.transform.localScale = new Vector3(10f, 1f, 1f);
        }

        FishingActive = FishingScreen != null;
    }
}