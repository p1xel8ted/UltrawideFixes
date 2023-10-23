using Il2Cpp;
using Il2CppInterop.Runtime;
using MelonLoader;
using SeaOfStars;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

[assembly: MelonInfo(typeof(SeaOfStarsUltrawide), "Sea of Stars Ultra-Wide", "0.2.0", "p1xel8ted")]

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
    private const string Wizard = "Wizard";
    private const string VideoPlayerCamera = "VideoPlayerCamera";

    /// <summary>
    /// Calculates the normal width based on the system height and a 16:9 aspect ratio.
    /// </summary>
    private static float NormalWidth => Display.main.systemHeight * 16f / 9f;

    /// <summary>
    /// Retrieves the system's ultra width.
    /// </summary>
    private static float UltraWidth => Display.main.systemWidth;

    /// <summary>
    /// Retrieves the system's height.
    /// </summary>
    private static float Height => Display.main.systemHeight;

    /// <summary>
    /// Retrieves the maximum refresh rate from the available screen resolutions.
    /// </summary>
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    /// <summary>
    /// Indicates whether fishing is currently active.
    /// </summary>
    private bool FishingActive { get; set; }

    /// <summary>
    /// List of viewports used for canvas upscaling.
    /// </summary>
    private static List<CanvasUpscaleViewport> CanvasUpscaleViewports { get; } = new();

    /// <summary>
    /// Reference to the cloned loading screen game object.
    /// </summary>
    private static GameObject LoadingScreenClone { get; set; }

    /// <summary>
    /// Reference to the first cloned transition screen game object.
    /// </summary>
    private static GameObject TransitionOneClone { get; set; }

    /// <summary>
    /// Reference to the second cloned transition screen game object.
    /// </summary>
    private static GameObject TransitionTwoClone { get; set; }

    /// <summary>
    /// Reference to the fishing screen game object.
    /// </summary>
    private static GameObject FishingScreen { get; set; }

    /// <summary>
    /// Indicates whether the fishing viewports have been updated.
    /// </summary>
    private bool FishingViewPortUpdated { get; set; }

    /// <summary>
    /// Category for the Melon preferences related to "Sea of Stars".
    /// </summary>
    private MelonPreferences_Category SeaOfStarsCategory { get; set; }

    /// <summary>
    /// Entry for the UI position in the Melon preferences.
    /// </summary>
    private MelonPreferences_Entry<float> SeaOfStarsUiEntry { get; set; }

    /// <summary>
    /// Calculates the canvas position based on the difference between ultra width and normal width.
    /// </summary>
    private static float CanvasPosition => CalculateX(UltraWidth);

    private static float CalculateX(float targetWidth)
    {
        // Hardcoded reference resolution
        const float referenceWidth1 = 2560f;

        // Hardcoded ratio based on the reference values
        const float ratio = 110f / 880f; // 0.125

        // Calculate the change in width for the target resolution
        var targetDeltaWidth = targetWidth - referenceWidth1;

        // Calculate and return the x value for the target resolution
        return ratio * targetDeltaWidth;
    }

    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();

        // Initialize properties
        FishingViewPortUpdated = false;
        FishingActive = false;

        // Create preferences
        SeaOfStarsCategory = MelonPreferences.CreateCategory("Sea of Stars Ultra-Wide");
        SeaOfStarsUiEntry = SeaOfStarsCategory.CreateEntry("UI Position", CanvasPosition);

        // Save preferences
        MelonPreferences.Save();
    }


    /// <summary>
    /// Shifts the viewport to the left by updating the custom canvas position of each viewport in CanvasUpscaleViewports.
    /// </summary>
    private void ShiftViewportLeft()
    {
        // Initialize the new offset value for the viewport shift
        var newOffset = 0f;

        // Iterate through each viewport in CanvasUpscaleViewports that is not null
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            // Calculate the new offset by subtracting 1 from the current x position of the viewport
            newOffset = v.customCanvasPos.x - 1f;

            // Update the custom canvas position of the viewport with the new offset
            v.customCanvasPos = new Vector2(newOffset, 0f);
        }

        // Update the SeaOfStarsUiEntry value with the last calculated offset (casted to an integer)
        SeaOfStarsUiEntry.Value = (int) newOffset;

        // Save the updated preferences
        MelonPreferences.Save();
    }


    /// <summary>
    /// Shifts the viewport to the right by updating the custom canvas position of each viewport in CanvasUpscaleViewports.
    /// </summary>
    private void ShiftViewportRight()
    {
        // Initialize the new offset value for the viewport shift
        var newOffset = 0f;

        // Iterate through each viewport in CanvasUpscaleViewports that is not null
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            // Calculate the new offset by adding 1 to the current x position of the viewport
            newOffset = v.customCanvasPos.x + 1f;

            // Update the custom canvas position of the viewport with the new offset
            v.customCanvasPos = new Vector2(newOffset, 0f);
        }

        // Update the SeaOfStarsUiEntry value with the last calculated offset (casted to an integer)
        SeaOfStarsUiEntry.Value = (int) newOffset;

        // Save the updated preferences
        MelonPreferences.Save();
    }


    /// <summary>
    /// Resets the custom canvas position of each viewport in CanvasUpscaleViewports to the default CanvasPosition.
    /// </summary>
    private void ResetViewports()
    {
        // Iterate through each viewport in CanvasUpscaleViewports that is not null
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            // Reset the custom canvas position of the viewport to the default CanvasPosition
            v.customCanvasPos = new Vector2(CanvasPosition, 0f);
        }

        // Update the SeaOfStarsUiEntry value with the default CanvasPosition (casted to an integer)
        SeaOfStarsUiEntry.Value = (int) CanvasPosition;

        // Save the updated preferences
        MelonPreferences.Save();
    }


    /// <summary>
    /// Overrides the base OnUpdate method to handle specific viewport and UI updates.
    /// </summary>
    public override void OnUpdate()
    {
        // Call the base OnUpdate method for any inherited behavior
        base.OnUpdate();

        // Handle viewport shifts based on user input (left or right shifts)
        HandleViewportShifts();

        // Reset the viewport if the multiply key is pressed
        ResetViewportOnMultiplyKey();

        // Find and cache references to specific UI elements in the scene
        FindUIElements();

        // Update the state of CanvasUpscaleViewports based on the activity of certain UI elements
        UpdateCanvasUpscaleViewports();

        // Update fishing viewports if certain conditions are met
        UpdateFishingViewportsIfNeeded();
    }


    /// <summary>
    /// Handles the viewport shifts based on user input. If the shift key is pressed, it checks for continuous key presses.
    /// Otherwise, it checks for single key presses.
    /// </summary>
    private void HandleViewportShifts()
    {
        // Check if either the left or right shift key is currently pressed
        var isShiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        // If shift key is pressed, handle continuous key presses
        if (isShiftPressed)
        {
            // If the minus key on the keypad is pressed, shift the viewport to the left
            if (Input.GetKey(KeyCode.KeypadMinus)) ShiftViewportLeft();

            // If the plus key on the keypad is pressed, shift the viewport to the right
            if (Input.GetKey(KeyCode.KeypadPlus)) ShiftViewportRight();
        }
        // If shift key is not pressed, handle single key presses
        else
        {
            // If the minus key on the keypad is pressed once, shift the viewport to the left
            if (Input.GetKeyDown(KeyCode.KeypadMinus)) ShiftViewportLeft();

            // If the plus key on the keypad is pressed once, shift the viewport to the right
            if (Input.GetKeyDown(KeyCode.KeypadPlus)) ShiftViewportRight();
        }
    }


    /// <summary>
    /// Checks if the multiply key on the keypad is pressed and, if so, resets the viewports.
    /// </summary>
    private void ResetViewportOnMultiplyKey()
    {
        // If the multiply key on the keypad is pressed, call the ResetViewports method
        if (Input.GetKeyDown(KeyCode.KeypadMultiply)) ResetViewports();
    }


    /// <summary>
    /// Finds and caches references to specific UI elements in the scene if they haven't been assigned yet.
    /// </summary>
    private static void FindUIElements()
    {
        // If LoadingScreenClone is null, find and assign the LoadingScreen UI element in the scene
        LoadingScreenClone ??= GameObject.Find("UICanvas(Clone)/Modal/LoadingScreen(Clone)");

        // If TransitionOneClone is null, find and assign the first ColorFadeTransitionScreen UI element in the scene
        TransitionOneClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)0");

        // If TransitionTwoClone is null, find and assign the second ColorFadeTransitionScreen UI element in the scene
        TransitionTwoClone ??= GameObject.Find("UICanvas(Clone)/Modal/ColorFadeTransitionScreen(Clone)1");
    }


    /// <summary>
    /// Updates the state of CanvasUpscaleViewports based on the activity of certain UI elements.
    /// If any of the specified UI elements (LoadingScreen, TransitionOne, TransitionTwo) are active, 
    /// the viewports in CanvasUpscaleViewports are disabled.
    /// </summary>
    private static void UpdateCanvasUpscaleViewports()
    {
        // Exit early if any of the UI elements are not found
        if (LoadingScreenClone == null || TransitionOneClone == null || TransitionTwoClone == null) return;

        // Check if any of the UI elements are currently active
        var anyActive = LoadingScreenClone.activeSelf || TransitionOneClone.activeSelf || TransitionTwoClone.activeSelf;

        // Iterate through each viewport in CanvasUpscaleViewports that is not null
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            // Disable the viewport if any of the UI elements are active
            v.enabled = !anyActive;
        }
    }


    /// <summary>
    /// Updates the fishing viewports if fishing is currently active and the viewports haven't been updated yet.
    /// </summary>
    private void UpdateFishingViewportsIfNeeded()
    {
        // If fishing is active and the viewports haven't been updated, update them
        if (FishingActive && !FishingViewPortUpdated)
        {
            UpdateFishingViewports();
        }
    }


    /// <summary>
    /// Overrides the base OnSceneWasLoaded method to handle specific actions based on the loaded scene.
    /// </summary>
    /// <param name="buildIndex">The build index of the loaded scene.</param>
    /// <param name="sceneName">The name of the loaded scene.</param>
    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        // Call the base OnSceneWasLoaded method for any inherited behavior
        base.OnSceneWasLoaded(buildIndex, sceneName);

        // If the loaded scene is the initial scene, set the time scale to a high value
        if (sceneName.Equals(InitialScene))
        {
            Time.timeScale = 10000f;
        }

        // Update the FishingActive status based on the presence of the FishingScreen
        FishingActive = FishingScreen != null;
    }


    /// <summary>
    /// Overrides the base OnSceneWasUnloaded method to handle specific actions based on the unloaded scene.
    /// </summary>
    /// <param name="buildIndex">The build index of the unloaded scene.</param>
    /// <param name="sceneName">The name of the unloaded scene.</param>
    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        // Call the base OnSceneWasUnloaded method for any inherited behavior
        base.OnSceneWasUnloaded(buildIndex, sceneName);

        // If the unloaded scene is the initial scene, reset the time scale to its default value
        if (sceneName.Equals(InitialScene))
        {
            Time.timeScale = 1f;
        }

        // Update the FishingActive and FishingViewPortUpdated statuses based on the presence of the FishingScreen
        FishingActive = FishingScreen != null;
        FishingViewPortUpdated = !FishingActive && FishingViewPortUpdated;
    }


    /// <summary>
    /// Updates the screen resolution and properties of viewports in CanvasUpscaleViewports based on the fishing activity.
    /// </summary>
    private void UpdateFishingViewports()
    {
        // Set the screen resolution based on predefined values
        Screen.SetResolution((int) NormalWidth, (int) Height, FullScreenMode.FullScreenWindow, MaxRefresh);

        // If fishing is active, update the properties of each valid viewport in CanvasUpscaleViewports
        if (FishingActive)
        {
            foreach (var viewport in CanvasUpscaleViewports.Where(viewport => viewport != null))
            {
                viewport.useCustomCanvasSize = false;
                viewport.customCanvasPos = Vector2.zero; // Use Vector2.zero for (0,0) for clarity
            }
        }

        // Mark that the fishing viewports have been updated
        FishingViewPortUpdated = true;
    }


    /// <summary>
    /// Overrides the base OnSceneWasInitialized method to handle specific actions based on the initialized scene.
    /// </summary>
    /// <param name="buildIndex">The build index of the initialized scene.</param>
    /// <param name="sceneName">The name of the initialized scene.</param>
    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        // Call the base OnSceneWasInitialized method for any inherited behavior
        base.OnSceneWasInitialized(buildIndex, sceneName);

        // Set the application's target frame rate to the maximum refresh rate
        Application.targetFrameRate = MaxRefresh;

        // Set the screen resolution based on predefined ultra width and height values
        Screen.SetResolution((int) UltraWidth, (int) Height, FullScreenMode.FullScreenWindow, MaxRefresh);

        // Process and modify properties of Image objects in the scene
       // ProcessImages();

        // Process and modify properties of Canvas objects in the scene
        ProcessCanvas(sceneName);

        // Process and modify properties of CanvasUpscaleViewport objects in the scene
        ProcessViewportScaler();

        // Process and modify properties of PixelPerfectCamera objects in the scene
        ProcessPixelPerfectCameras(sceneName);

        // Adjust the scale of the ocean game object if present
        AdjustOceanScale();

        // Update the FishingActive status based on the presence of the FishingScreen
        FishingActive = FishingScreen != null;
    }

    /// <summary>
    /// Processes and adjusts properties of all Image objects in the scene based on their names and their parent's names.
    /// </summary>
    private void ProcessImages()
    {
        // Retrieve all Image objects in the scene
        var images = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Image>());

        foreach (var image in images)
        {
            // Attempt to cast the object to Image type
            var i = image.TryCast<Image>();

            // If casting fails, skip to the next iteration
            if (i == null) continue;

            // Adjust properties based on the Image object's name
            switch (i.name)
            {
                case Overlay:
                    // Disable the image if its name matches "Overlay"
                    // Removes the semi-transparent 16:9 background overlay on some menus.
                    i.enabled = false;
                    break;
                case ScreenConst:
                    // Adjust the scale or disable the image based on its parent's name
                    // Stretches the black loading screens/transitions to the ultra width
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
    }


    /// <summary>
    /// Processes and adjusts properties of all Canvas objects in the scene based on their names and the provided scene name.
    /// </summary>
    /// <param name="sceneName">The name of the current scene.</param>
    private static void ProcessCanvas(string sceneName)
    {
        // Retrieve all Canvas objects in the scene
        var canvases = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Canvas>());

        foreach (var can in canvases)
        {
            // Attempt to cast the object to Canvas type
            var c = can.TryCast<Canvas>();

            // If casting fails, skip to the next iteration
            if (c == null) continue;

            // Adjust properties based on the Canvas object's name
            switch (c.name)
            {
                case CutsceneBarsClone:
                    // Disable the canvas if its name matches "CutsceneBarsClone"
                    // Removes the top and button black bars during cutscenes.
                    c.enabled = false;
                    break;
                case Fishing:
                    // Set the FishingScreen based on the scene name and the canvas's name
                    // Used to determine if fishing is active.
                    FishingScreen = sceneName.StartsWith(Wizard) ? null : c.gameObject;
                    break;
            }
        }
    }


    /// <summary>
    /// Processes and adjusts properties of all CanvasUpscaleViewport objects in the scene.
    /// Also, adds them to the CanvasUpscaleViewports list.
    /// </summary>
    private void ProcessViewportScaler()
    {
        // Retrieve all CanvasUpscaleViewport objects in the scene
        var viewportScalers = Resources.FindObjectsOfTypeAll(Il2CppType.Of<CanvasUpscaleViewport>());

        foreach (var vs in viewportScalers)
        {
            // Attempt to cast the object to CanvasUpscaleViewport type
            var v = vs.TryCast<CanvasUpscaleViewport>();

            // If casting fails, skip to the next iteration
            if (v == null) continue;

            // Adjust properties of the CanvasUpscaleViewport object
            // This component controls UI positioning and scaling.
            v.useCustomCanvasSize = true;
            v.customCanvasPos = new Vector2(SeaOfStarsUiEntry.Value, 0f);

            // Add the CanvasUpscaleViewport object to the CanvasUpscaleViewports list
            CanvasUpscaleViewports.Add(v);
        }
    }


    /// <summary>
    /// Processes and adjusts properties of all PixelPerfectCamera objects in the scene based on the provided scene name.
    /// </summary>
    /// <param name="sceneName">The name of the current scene.</param>
    private static void ProcessPixelPerfectCameras(string sceneName)
    {
        // Retrieve all PixelPerfectCamera objects in the scene
        var pixelPerfects = Resources.FindObjectsOfTypeAll(Il2CppType.Of<PixelPerfectCamera>());

        foreach (var pp in pixelPerfects)
        {
            // Attempt to cast the object to PixelPerfectCamera type
            var p = pp.TryCast<PixelPerfectCamera>();

            // If casting fails, skip to the next iteration
            if (p == null) continue;

            // // Adjust properties based on the scene name or the camera's name
            // // Removes the black bars on the left and right sides of the screen (except for the initial scene and videos).
            if (sceneName.Equals(InitialScene) || p.name.Equals(VideoPlayerCamera))
            {
                p.upscaleRT = false;
                p.cropFrameX = true;
                p.cropFrameY = true;
            }
            else
            {
                p.upscaleRT = true;
                p.cropFrameX = false;
                p.cropFrameY = false;
            }

            p.refResolutionX = 640;
            p.refResolutionY = 360;
        }
    }


    /// <summary>
    /// Adjusts the scale of the ocean game object, if it exists in the scene.
    /// </summary>
    private static void AdjustOceanScale()
    {
        // Find the ocean background game object in the scene
        var ocean = GameObject.Find(SosOcean);
    
        // If the ocean game object is found, adjust its scale
        if (ocean != null)
        {
            ocean.transform.localScale = new Vector3(10f, 1f, 1f);
        }
    }

}