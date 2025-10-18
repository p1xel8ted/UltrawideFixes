namespace ImmortalLegacyTheJadeCipher.Configuration;

internal static class ConfigManager
{
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<PostProcessLayer.Antialiasing> Antialiasing { get; private set; }
    internal static ConfigEntry<float> TaaSharpness { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static ConfigEntry<string> Resolution { get; private set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }
    internal static ConfigEntry<int> CustomRefreshRate { get; private set; }
    internal static ConfigEntry<int> TargetFramerate { get; private set; }
    internal static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }

  //  internal static ConfigEntry<string> HUDAspect { get; private set; }
    internal static ConfigEntry<float> GameCameraFieldOfViewMultiplier { get; private set; }
internal static ConfigFile ConfigFileInstance { get; private set; }

    internal static void Initialize(ConfigFile config, Action onDisplayUpdate)//, Action onHUDUpdate)
    {
        ConfigFileInstance = config;
        var customRates = Resolutions.MergeUnityRefreshRates();

        // Display Settings
        Resolution = config.Bind("01. Display", "Resolution", $"{Display.main.systemWidth}x{Display.main.systemHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(Resolutions.GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => onDisplayUpdate();

        FullScreenModeConfig = config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) => onDisplayUpdate();

        TargetFramerate = config.Bind("01. Display", "Target Framerate", Resolutions.MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => onDisplayUpdate();

        VSyncSetting = config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game's frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => onDisplayUpdate();

        UseCustomRefreshRate = config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => onDisplayUpdate();

        CustomRefreshRate = config.Bind("01. Display", "Custom Refresh Rate", Resolutions.RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => onDisplayUpdate();

        GameCameraFieldOfViewMultiplier = config.Bind("02. Camera", "Field of View Multiplier", 1f,
            new ConfigDescription("The multiplier applied to the game's field of view. Default is 1.0.", new AcceptableValueRange<float>(0.25f, 2f), new ConfigurationManagerAttributes { Order = 86 }));
        GameCameraFieldOfViewMultiplier.SettingChanged += (_, _) =>
        {
           //0.025 steps
            GameCameraFieldOfViewMultiplier.Value = Mathf.Round(GameCameraFieldOfViewMultiplier.Value * 40) / 40f;
        };
        
        Antialiasing = config.Bind("03. Antialiasing", "Antialiasing Mode", PostProcessLayer.Antialiasing.TemporalAntialiasing,
            new ConfigDescription("Set the antialiasing mode for post-processing effects. Options include None, Fast Approximate Antialiasing (FXAA), Subpixel Morphological Antialiasing (SMAA), and Temporal Antialiasing (TAA).", null, new ConfigurationManagerAttributes { Order = 85 }));
        Antialiasing.SettingChanged += (_, _) => Volumes.UpdateAntialiasing();

        TaaSharpness = config.Bind("03. Antialiasing", "Temporal AA Sharpness", 0.25f,
            new ConfigDescription("Set the sharpness for Temporal Antialiasing (TAA). A value of 0 is the softest, while 1 is the sharpest.", new AcceptableValueRange<float>(-5f, 5f), new ConfigurationManagerAttributes { Order = 84 }));
        TaaSharpness.SettingChanged += (_, _) =>
        {
            //0.25 steps
            TaaSharpness.Value = Mathf.Round(TaaSharpness.Value * 4) / 4f;
            Volumes.UpdateAntialiasing();
        };

        // // UI Settings
        // HUDAspect = config.Bind("04. UI", "UI Aspect", "Auto",
        //     new ConfigDescription(
        //         "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
        //         new AcceptableValueList<string>(Resolutions.HUDAspects.ToArray()),
        //         new ConfigurationManagerAttributes { Order = 93 }));
        // HUDAspect.SettingChanged += (_, _) => onHUDUpdate();

        Notifications = config.Bind("05. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 86 }));

    }

   

    internal static int GetVSyncCount()
    {
        return VSyncOptions.TryGetValue(VSyncSetting.Value, out var count) ? count : 0;
    }
}
