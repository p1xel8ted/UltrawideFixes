namespace SeaOfStars;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency("com.p1xel8ted.BepInExConfigManager", "2.1.0")]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.seaofstars.ultrawide";
    private const string PluginName = "Sea of Stars Ultra-Wide";
    private const string PluginVersion = "0.3.0";

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
    private const string UiCanvasClone = "UICanvas(Clone)";
    private const string InventoryMarkerThing = "UICanvas(Clone)/Prompt/InGameHud(Clone)/LocalInventory/GenericBackground";

    private static readonly int[] CustomRefreshRates =
    [
        30, // Uncommon
        50, // Uncommon
        60, // Common
        72, // Uncommon
        75, // Common
        90, // Uncommon
        100, // Uncommon
        120, // Common
        144, // Common
        165, // Common
        180, // Common
        200, // Uncommon
        240, // Common
        300, // Uncommon
        360, // Uncommon
        480 // Uncommon
    ];

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static int NormalWidth => Mathf.RoundToInt(MainHeight * 16f / 9f); //2560
    private static float PositiveScaleFactor => MainWidth / (float)NormalWidth; //1.344
    private static ManualLogSource Logger { get; set; }

    private static ConfigEntry<KeyCode> ShiftViewportLeftKeybind { get; set; }
    private static ConfigEntry<KeyCode> ShiftViewportRightKeybind { get; set; }
    private static ConfigEntry<KeyCode> ResetViewportKeybind { get; set; }
    private static ConfigEntry<KeyCode> ModifierKeybind { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth; //3440
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight; //1440
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnceInt OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static ConfigEntry<int> UiPosition { get; set; }


    internal static void SetResolution(bool sixteenNine = false)
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(sixteenNine ? NormalWidth : MainWidth, MainHeight, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);
    }

    /// <summary>
    /// Indicates whether fishing is currently active.
    /// </summary>
    private static bool FishingActive { get; set; }

    /// <summary>
    /// List of viewports used for canvas upscaling.
    /// </summary>
    private static List<CanvasUpscaleViewport> CanvasUpscaleViewports => Utils.FindIl2CppType<CanvasUpscaleViewport>().ToList();

    /// <summary>
    /// Reference to the cloned loading screen game object.
    /// </summary>
    private static GameObject LoadingScreenClone { get; set; }

    /// <summary>
    /// Reference to the cloned dialogue cutscene game object.
    /// </summary>
    private static GameObject DialogueCutsceneGameObject { get; set; }

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
    private static bool FishingViewPortUpdated { get; set; }

    /// <summary>
    /// Calculates the canvas position based on the difference between ultra width and normal width.
    /// </summary>
    private static int CanvasPosition => CalculateX(MainWidth);

    /// <summary>
    /// Reference to the CanvasUpscaleViewport UI element in the scene.
    /// </summary>   
    private static CanvasUpscaleViewport UiCanvasViewPort { get; set; }


    /// <summary>
    /// Reference to the DialogueCutsceneBox UI element in the scene.
    /// </summary>
    private static GameObject DialogueCutsceneBox => GameObject.Find("UICanvas(Clone)/Modal/NewDialogBox(Clone)");

    /// <summary>
    ///     List of PixelPerfectCamera objects in the scene.
    /// </summary>
    private static List<PixelPerfectCamera> PixelPerfectCameras => Utils.FindIl2CppType<PixelPerfectCamera>().ToList();

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Utils.FindIl2CppType<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }


    public override void Load()
    {
        ConfigManager.ConfigManager.OnMenuVisibilityChanged += HandleConfigManager;
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();
        AddComponent<MonoMethods>();

        Logger = Log;

        var customRates = MergeUnityRefreshRates();

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        ShiftViewportLeftKeybind = Config.Bind("03. UI", "Shift Viewport Left", KeyCode.LeftBracket, new ConfigDescription("Shift the UI viewport to the left.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ShiftViewportRightKeybind = Config.Bind("03. UI", "Shift Viewport Right", KeyCode.RightBracket, new ConfigDescription("Shift the UI viewport to the right.", null, new ConfigurationManagerAttributes { Order = 90 }));
        ModifierKeybind = Config.Bind("03. UI", "Modifier Key", KeyCode.LeftShift, new ConfigDescription("The key that needs to be held to shift the viewport at a faster rate.", null, new ConfigurationManagerAttributes { Order = 89 }));
        ResetViewportKeybind = Config.Bind("03. UI", "Reset Viewport", KeyCode.Backslash, new ConfigDescription("Reset the UI viewport to the default position.", null, new ConfigurationManagerAttributes { Order = 89 }));

        UiPosition = Config.Bind("03. UI", "UI Position", CanvasPosition, new ConfigDescription("Set the position of the UI on the x-axis. It is recommended to use the keybinds as you wont see the results while this window is open.", new AcceptableValueRange<int>(-1000, 1000), new ConfigurationManagerAttributes { Order = 92 }));
        UiPosition.SettingChanged += (_, _) => { HandleShiftViewportViaUI(); };

        RunInBackground = Config.Bind("07. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("07. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        SceneManager.sceneUnloaded += (UnityAction<Scene>)OnSceneUnloaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        FishingViewPortUpdated = false;
        FishingActive = false;
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0)
        {
            Logger.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / targetRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }


    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;

        SetResolution();

        Application.targetFrameRate = TargetFramerate.Value;
    }

    private static void OnSceneUnloaded(Scene scene)
    {
        if (scene.name.Equals("InitialScene"))
        {
            Time.timeScale = 1f;
        }

        FishingActive = FishingScreen != null;
        FishingViewPortUpdated = !FishingActive && FishingViewPortUpdated;
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals("InitialScene"))
        {
            Time.timeScale = 10000f;
        }

        UpdateDisplay();
        UpdateFixedDeltaTime();

        // Process and modify properties of Image objects in the scene
        ProcessImages();

        // Process and modify properties of Canvas objects in the scene
        ProcessCanvas(scene.name);

        // Process and modify properties of CanvasUpscaleViewport objects in the scene
        ProcessViewportScaler();

        // Process and modify properties of PixelPerfectCamera objects in the scene
        ProcessPixelPerfectCameras(scene.name);

        // Adjust the scale of the ocean game object if present
        AdjustOceanScale();

        // Find and cache references to specific UI elements in the scene
        FindUIElements();

        // Adjust the scale of the loading screen and transition screens if they exist
        AdjustLoadTransitionScale();

        // Update the state of CanvasUpscaleViewports based on the activity of certain UI elements
      //  UpdateLoadTransitionCanvasUpscaleViewports();

        //DisableWierdUI()
        DisableWierdUI();

        // Update the FishingActive status based on the presence of the FishingScreen
        FishingActive = FishingScreen != null;
    }

    private static int CalculateX(float targetWidth)
    {
        // Hardcoded reference resolution
        const float referenceWidth1 = 2560f;

        // Hardcoded ratio based on the reference values
        const float ratio = 110f / 880f; // 0.125

        // Calculate the change in width for the target resolution
        var targetDeltaWidth = targetWidth - referenceWidth1;

        // Calculate and return the x value for the target resolution
        return Mathf.RoundToInt(ratio * targetDeltaWidth);
    }

    private static void HandleShiftViewportViaUI()
    {
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            v.customCanvasPos = new Vector2(UiPosition.Value, 0f);
        }
    }


    /// <summary>
    /// Shifts the viewport to the left by updating the custom canvas position of each viewport in CanvasUpscaleViewports.
    /// </summary>
    private static void ShiftViewportLeft()
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
        UiPosition.Value = (int)newOffset;
    }


    /// <summary>
    /// Shifts the viewport to the right by updating the custom canvas position of each viewport in CanvasUpscaleViewports.
    /// </summary>
    private static void ShiftViewportRight()
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
        UiPosition.Value = (int)newOffset;
    }


    /// <summary>
    /// Resets the custom canvas position of each viewport in CanvasUpscaleViewports to the default CanvasPosition.
    /// </summary>
    private static void ResetViewports()
    {
        // Iterate through each viewport in CanvasUpscaleViewports that is not null
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            // Reset the custom canvas position of the viewport to the default CanvasPosition
            v.customCanvasPos = new Vector2(CanvasPosition, 0f);
        }

        // Update the SeaOfStarsUiEntry value with the default CanvasPosition (casted to an integer)
        UiPosition.Value = CanvasPosition;
    }

    /// <summary>
    /// Handles the viewport shifts based on user input. If the shift key is pressed, it checks for continuous key presses.
    /// Otherwise, it checks for single key presses.
    /// </summary>
    private static void HandleViewportShifts()
    {
        // Check if either the left or right shift key is currently pressed
        var isShiftPressed = Input.GetKey(ModifierKeybind.Value);

        // If shift key is pressed, handle continuous key presses
        if (isShiftPressed)
        {
            // If the LeftBracket key is pressed, shift the viewport to the left
            if (Input.GetKey(ShiftViewportLeftKeybind.Value))
            {
                ShiftViewportLeft();
            }

            // If the RightBracket key is pressed, shift the viewport to the right
            if (Input.GetKey(ShiftViewportRightKeybind.Value))
            {
                ShiftViewportRight();
            }
        }
        // If shift key is not pressed, handle single key presses
        else
        {
            // If the LeftBracket key is pressed once, shift the viewport to the left
            if (Input.GetKeyDown(ShiftViewportLeftKeybind.Value))
            {
                ShiftViewportLeft();
            }

            // If the RightBracket key is pressed once, shift the viewport to the right
            if (Input.GetKeyDown(ShiftViewportRightKeybind.Value))
            {
                ShiftViewportRight();
            }
        }
    }


    /// <summary>
    /// Checks if the pipe key is pressed and, if so, resets the viewports.
    /// </summary>
    private static void ResetViewportOnMultiplyKey()
    {
        // If the pipe key is pressed, call the ResetViewports method
        if (Input.GetKeyDown(ResetViewportKeybind.Value))
        {
            ResetViewports();
        }
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

        // If DialogueCutsceneGameObject is null, find and assign the DialogueCutscene UI element in the scene
        DialogueCutsceneGameObject ??= GameObject.Find("UICanvas(Clone)/Modal/NewDialogBox(Clone)");

        // If UiCanvasViewPort is null, find and assign the CanvasUpscaleViewport UI element in the scene
        var uiCanvas = GameObject.Find(UiCanvasClone);
        if (uiCanvas)
        {
            UiCanvasViewPort = uiCanvas.GetComponent<CanvasUpscaleViewport>();
        }
    }


    /// <summary>
    /// Flag to indicate if the resolution has already been updated in <see cref="@UpdateLoadTransitionCanvasUpscaleViewports"/>
    /// </summary>
    private static bool IsResolutionUpdated { get; set; }


    /// <summary>
    /// Updates the state of CanvasUpscaleViewports based on the activity of certain UI elements.
    /// If any of the specified UI elements (LoadingScreen, TransitionOne, TransitionTwo) are active, 
    /// the viewports in CanvasUpscaleViewports are disabled.
    /// </summary>
    private static void UpdateLoadTransitionCanvasUpscaleViewports()
    {
        // Exit early if any of the UI elements are not found or the config menu is active
        if (ConfigManager.UI.UIManager.ShowMenu || LoadingScreenClone == null || TransitionOneClone == null || TransitionTwoClone == null) return;

        // // Check if any of the UI elements are currently active
        var anyActive = LoadingScreenClone.activeSelf || TransitionOneClone.activeSelf || TransitionTwoClone.activeSelf;

        // Disable the viewports in CanvasUpscaleViewports if any of the UI elements are active

        foreach (var viewport in CanvasUpscaleViewports)
        {
            viewport.enabled = !anyActive;
        }


        // Check if DialogueCutsceneBox is active and handle accordingly
        if (UiCanvasViewPort && DialogueCutsceneBox && DialogueCutsceneBox.activeSelf)
        {
            // Reset the flag, allowing changes the next time DialogueCutsceneBox is inactive
            IsResolutionUpdated = false;

            // Set properties for the dialogue cutscene
            UiCanvasViewPort.enabled = true;
            UiCanvasViewPort.useCustomCanvasSize = false;

            foreach (var pp in PixelPerfectCameras.Where(a => a != null))
            {
                if (pp.name.Equals("SplashCamera")) continue;
                pp.refResolutionX = MainWidth;
                pp.refResolutionY = MainHeight;
            }
        }
        else if (!IsResolutionUpdated) // Only update if the resolution has not been set yet
        {
            UiCanvasViewPort.useCustomCanvasSize = true;

            foreach (var pp in PixelPerfectCameras.Where(a => a != null))
            {
                if (pp.name.Equals("SplashCamera")) continue;
                pp.refResolutionX = 640;
                pp.refResolutionY = 360;
            }

            // Set the flag to prevent this block from running again
            IsResolutionUpdated = true;
        }
    }

    /// <summary>
    /// Updates the fishing viewports if fishing is currently active and the viewports haven't been updated yet.
    /// </summary>
    private static void UpdateFishingViewportsIfNeeded()
    {
        // If fishing is active and the viewports haven't been updated, update them
        if (FishingActive && !FishingViewPortUpdated)
        {
            UpdateFishingViewports();
        }
    }


    /// <summary>
    /// Updates the screen resolution and properties of viewports in CanvasUpscaleViewports based on the fishing activity.
    /// </summary>
    private static void UpdateFishingViewports()
    {
        // If fishing is active, update the properties of each valid viewport in CanvasUpscaleViewports
        if (FishingActive)
        {
            // Set the screen resolution based on predefined values
            SetResolution(true);

            foreach (var viewport in CanvasUpscaleViewports.Where(viewport => viewport))
            {
                viewport.useCustomCanvasSize = false;
                viewport.customCanvasPos = Vector2.zero; // Use Vector2.zero for (0,0) for clarity
            }
        }

        // Mark that the fishing viewports have been updated
        FishingViewPortUpdated = true;
    }


    /// <summary>
    /// Processes and adjusts properties of all Image objects in the scene based on their names and their parent's names.
    /// </summary>
    private static void ProcessImages()
    {
        // Retrieve all Image objects in the scene
        var images = Utils.FindIl2CppType<Image>();

        foreach (var i in images)
        {
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
                        i.transform.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
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
        var canvases = Utils.FindIl2CppType<Canvas>();

        foreach (var c in canvases)
        {
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
    private static void ProcessViewportScaler()
    {
        foreach (var v in CanvasUpscaleViewports.Where(a => a != null))
        {
            // if (UiCanvasViewPort != null && v.name.Equals(UiCanvasViewPort.name)) continue;
            // Adjust properties of the CanvasUpscaleViewport object
            // This component controls UI positioning and scaling.
            v.useCustomCanvasSize = true;
            v.customCanvasPos = new Vector2(UiPosition.Value, 0f);
        
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
        foreach (var p in PixelPerfectCameras.Where(a => a != null))
        {
            if (p.name.Equals("SplashCamera")) continue;
            // // Adjust properties based on the scene name or the camera's name
            // // Removes the black bars on the left and right sides of the screen (except for the initial scene and videos).
            if (sceneName.Equals(InitialScene) || p.name.Equals(VideoPlayerCamera))
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

            PixelPerfectCameras.Add(p);
        }
    }


    /// <summary>
    ///     Adjusts the scale of the loading screen and transition screens if they exist in the scene.
    /// </summary>
    private static void AdjustLoadTransitionScale()
    {
        if (LoadingScreenClone)
        {
            LoadingScreenClone.transform.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
        }

        if (TransitionOneClone)
        {
            TransitionOneClone.transform.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
        }

        if (TransitionTwoClone)
        {
            TransitionTwoClone.transform.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
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
        if (ocean)
        {
            ocean.transform.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
        }
    }


    private class MonoMethods : MonoBehaviour
    {
        private void Update()
        {
            HandleViewportShifts();

            // Reset the viewport if the multiply key is pressed
            ResetViewportOnMultiplyKey();

            // Find and cache references to specific UI elements in the scene
            FindUIElements();

            // Adjust the scale of the loading screen and transition screens if they exist
            AdjustLoadTransitionScale();

            // Update the state of CanvasUpscaleViewports based on the activity of certain UI elements
            UpdateLoadTransitionCanvasUpscaleViewports();

            // Update fishing viewports if certain conditions are met
            UpdateFishingViewportsIfNeeded();
        }
    }

    private static void DisableWierdUI()
    {
        var go = GameObject.Find(InventoryMarkerThing);
        if (go)
        {
            go.SetActiveRecursively(false);
        }
    }


    private static void HandleConfigManager(bool isVisible)
    {
        if (isVisible)
        {
            foreach (var vp in CanvasUpscaleViewports)
            {
                vp.enabled = false;
            }

            foreach (var pp in PixelPerfectCameras.Where(pp => pp))
            {
                pp.refResolutionX = MainWidth;
                pp.refResolutionY = MainHeight;
            }
        }
        else
        {
            foreach (var vp in CanvasUpscaleViewports)
            {
                vp.enabled = true;
            }

            foreach (var pp in PixelPerfectCameras.Where(pp => pp))
            {
                pp.refResolutionX = 640;
                pp.refResolutionY = 360;
            }
        }
    }
}