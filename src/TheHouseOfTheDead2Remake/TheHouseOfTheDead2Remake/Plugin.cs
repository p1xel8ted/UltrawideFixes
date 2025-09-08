namespace TheHouseOfTheDead2Remake;

/// <summary>
/// Main plugin class for "The House of the Dead Remake Ultra-Wide" modifications.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    // Plugin Metadata
    private const string PluginGuid = "p1xel8ted.houseofthedead2remake.uwfixes";
    private const string PluginName = "The House of the Dead 2 Remake Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }

    // Configuration Fields
    private static List<string> HUDAspects { get; } =
    [
        "16:10",
        "16:9",
        "21:9",
        "21.5:9",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    private static ConfigurationManager.ConfigurationManager ConfigurationManager =>
        global::ConfigurationManager.ConfigurationManager.Instance;

#if DEBUG
    internal static ConfigEntry<bool> SixteenTenTesting { get; set; }
    internal static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    internal static ConfigEntry<bool> FourtyEightNineTesting { get; set; }
#endif

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    public enum ModdedGameEnding
    {
        NormalEnding = GameEnding.Normal,
        GoodEnding = GameEnding.Good,
        BadEnding = GameEnding.Bad,
        Disabled
    }

    internal static ConfigEntry<int> MSAA { get; private set; }
    internal static ConfigFile ConfigFile { get; private set; }
    public static ConfigEntry<bool> MaximumQuality { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static ConfigEntry<string> HUDAspect { get; private set; }
    internal static ConfigEntry<int> CustomRefreshRate { get; private set; }
    internal static ConfigEntry<HDAdditionalCameraData.AntialiasingMode> PostProcessAntialiasingMode { get; private set; }
    internal static ConfigEntry<float> PostProcessTaaSharpeningStrength { get; private set; }
    internal static ConfigEntry<float> PlayerFieldOfView { get; private set; }
    internal static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }
    internal static ConfigEntry<string> Resolution { get; private set; }
   // internal static ConfigEntry<bool> ExpandBloodOverlay { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<ModdedGameEnding> EndingToShow { get; private set; }

    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }
    private static bool RequiresUpdate { get; set; }

    /// <summary>
    /// Initializes the plugin, setting up configuration entries, debug options, and event handlers.
    /// </summary>
    private void Awake()
    {
       
        
        ConfigFile = Config;
        Log = Logger;

#if DEBUG
        SetupDebugConfigurations();
#endif
        SetupDisplayConfigurations(); //01
        SetupUIConfigurations(); //02
        SetupCameraConfigurations(); //03
       SetupGameConfigurations(); //04
      // SetupGraphicsConfigurations(); //05
        SetupPostProcessConfigurations(); //06
        //reflection generated options //07
        ReflectionConfigGeneration.GenerateHdDataConfig();
        RequiresUpdate = true;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
            
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

#if DEBUG
    /// <summary>
    /// Sets up debug configurations for aspect ratio testing.
    /// </summary>
    private void SetupDebugConfigurations()
    {
        SixteenTenTesting = Config.Bind("00. Testing", "16:10 Testing", false,
            new ConfigDescription("Enable this option to test 16:10 aspect ratio."));
        SixteenTenTesting.SettingChanged += (_, _) =>
        {
            if (SixteenTenTesting.Value)
            {
                ThirtyTwoNineTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };

        ThirtyTwoNineTesting = Config.Bind("00. Testing", "32:9 Testing", false,
            new ConfigDescription("Enable this option to test 32:9 aspect ratio."));
        ThirtyTwoNineTesting.SettingChanged += (_, _) =>
        {
            if (ThirtyTwoNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };

        FourtyEightNineTesting = Config.Bind("00. Testing", "48:9 Testing", false,
            new ConfigDescription("Enable this option to test 48:9 aspect ratio."));
        FourtyEightNineTesting.SettingChanged += (_, _) =>
        {
            if (FourtyEightNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                ThirtyTwoNineTesting.Value = false;
            }

            UpdateAll(true);
        };
    }
#endif
    /// <summary>
    /// Sets up configurations related to game settings.
    /// </summary>
    private void SetupGameConfigurations()
    {
        EndingToShow = Config.Bind("04. Game", "Ending To Show", ModdedGameEnding.Disabled,
            new ConfigDescription("Choose the ending to show when the game is completed. Disabled will let the game decide.", null, new ConfigurationManagerAttributes { Order = 92 }));
    }

    /// <summary>
    /// Sets up configurations related to post-processing.
    /// </summary>
    private void SetupPostProcessConfigurations()
    {
        Notifications = Config.Bind("05. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 89 }));
    }

    /// <summary>
    /// Sets up configurations related to display settings.
    /// </summary>
    private void SetupDisplayConfigurations()
    {
        var customRates = Resolutions.MergeUnityRefreshRates();

        Resolution = Config.Bind("01. Display", "Resolution", $"{Resolutions.MainWidth}x{Resolutions.MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(Resolutions.GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => UpdateAll(true);

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", Resolutions.MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll(true);

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll(true);

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", Resolutions.RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", Resolutions.MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll(true);
    }

    // /// <summary>
    // /// Sets up configurations related to graphics settings.
    // /// </summary>
    // private void SetupGraphicsConfigurations()
    // {
    //     MaximumQuality = Config.Bind("05. Graphics", "Maximum Quality", false,
    //         new ConfigDescription(
    //             "Enable this to use the highest quality settings for the game. This may reduce performance. If you disable this, you will need to restart the game to undo the changes.",
    //             null,
    //             new ConfigurationManagerAttributes { Order = 98 }));
    //     MaximumQuality.SettingChanged += (_, _) => { UpdateAll(); };
    //     
    //     MSAA = Config.Bind("05. Graphics", "MSAA", 0,
    //         new ConfigDescription(
    //             "Set the level of Multi-Sample Anti-Aliasing (MSAA) to use. Higher values result in better quality but lower performance.",
    //             new AcceptableValueList<int>(0, 2, 4, 8),
    //             new ConfigurationManagerAttributes { Order = 97 }));
    //     MSAA.SettingChanged += (_, _) => UpdateAll();
    //     
    //     PostProcessAntialiasingMode = Config.Bind("05. Graphics", "Post-Process Antialiasing Mode", HDAdditionalCameraData.AntialiasingMode.TemporalAntialiasing,
    //         new ConfigDescription("Choose the antialiasing mode for post-processing effects.", null, new ConfigurationManagerAttributes { Order = 91 }));
    //     PostProcessAntialiasingMode.SettingChanged += (_, _) => Cameras.UpdatePostProcessingAA();
    //     
    //     PostProcessTaaSharpeningStrength = Config.Bind("05. Graphics", "Post-Process TAA Sharpening Strength", 1f,
    //         new ConfigDescription("Choose the sharpening strength for post-processing effects.", new AcceptableValueRange<float>(0f, 5f), new ConfigurationManagerAttributes { Order = 90 }));
    //     PostProcessTaaSharpeningStrength.SettingChanged += (_, _) =>
    //     {
    //         //0.25 increments
    //         PostProcessTaaSharpeningStrength.Value = Mathf.Round(PostProcessTaaSharpeningStrength.Value * 4) / 4;
    //     
    //         Cameras.UpdatePostProcessingAA();
    //     };
    // }

    /// <summary>
    /// Sets up configurations related to UI settings.
    /// </summary>
    private void SetupUIConfigurations()
    {
        HUDAspect = Config.Bind("02. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 93 }));
        HUDAspect.SettingChanged += (_, _) => LayoutController.UpdateAllLayouts();
    }

    /// <summary>
    /// Sets up configurations related to camera settings.
    /// </summary>
    private void SetupCameraConfigurations()
    {
        PlayerFieldOfView = Config.Bind("03. Camera", "Player Field of View", 0f,
            new ConfigDescription("Modify the games field of view.", new AcceptableValueRange<float>(0, 10f), new ConfigurationManagerAttributes { Order = 92 }));
        PlayerFieldOfView.SettingChanged += (_, _) =>
        {
            PlayerFieldOfView.Value = Mathf.Round(PlayerFieldOfView.Value * 4) / 4;
        };
    }



    /// <summary>
    /// Updates all systems based on configuration changes.
    /// </summary>
    private static void UpdateAll(bool force = false)
    {
       // QualSettings.UpdateSettings();
        UpdateDisplay(force);
   
        Patches.Patches.UpdateAllCameras();
        Volumes.UpdateVolumes();
    }

    private void LateUpdate()
    {
        if (Keyboard.current.f1Key.wasPressedThisFrame)
        {
            ConfigurationManager.ToggleWindow();
        }
      
    }


    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Log.LogWarning($"Scene loaded: {arg0.name} in mode {arg1}");
        var force = Screen.width != Resolutions.SelectedResolution.width || Screen.height != Resolutions.SelectedResolution.height || Screen.fullScreenMode != FullScreenModeConfig.Value;
        UpdateDisplay(force);
       // ReflectionConfigGeneration.GenerateHdDataConfig();
       
       Patches.Patches.UpdateAllCameras();
    }

    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Log.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;

      //  Videos.UpdateAllPlayers();

        Screen.SetResolution(Resolutions.SelectedResolution.width, Resolutions.SelectedResolution.height, FullScreenModeConfig.Value, Resolutions.MaxRefreshRate);
        Log.LogInfo($"Resolution updated: {Resolutions.SelectedResolution.width}x{Resolutions.SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={Resolutions.RefreshRate}Hz");


        // if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        // {
        //     ConfigurationManager.CloseWindow();
        //     ConfigurationManager.OpenWindow();
        // }

        RequiresUpdate = false;
    }
}