// Configuration.cs

namespace SeaOfStars.Configuration;

public static class Configuration
{
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static ConfigEntry<KeyCode> UiPixelAlignmentLeftKeybind { get; private set; }
    internal static ConfigEntry<KeyCode> UiPixelAlignmentRightKeybind { get; private set; }
    internal static ConfigEntry<KeyCode> ResetPixelAlignmentKeybind { get; private set; }
    internal static ConfigEntry<KeyCode> ModifierKeybind { get; private set; }
    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    internal static ConfigEntry<bool> MuteInBackground { get; private set; }
    internal static ConfigEntry<int> CustomRefreshRate { get; private set; }
    internal static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; private set; }
    internal static ConfigEntry<bool> CorrectFixedUpdateRate { get; private set; }
    internal static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }
    internal static ConfigEntry<int> TargetFramerate { get; private set; }
    internal static ConfigEntry<float> GamePlayRunSpeedMultiplier { get; private set; }
    internal static ConfigEntry<float> WorldMapRunSpeedMultiplier { get; private set; }
    internal static ConfigEntry<bool> CinematicLetterboxing { get; private set; }
    internal static ConfigEntry<bool> AdjustUiPixelAlignment { get; private set; }
    internal static ConfigEntry<float> UiPixelAlignment { get; private set; }

    internal static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static ConfigEntry<string> Resolution { get; private set; }
    internal static ConfigEntry<string> VSyncSetting { get; private set; }

    internal static bool RequiresUpdate { get; set; }

    public static void SetupConfig(ConfigFile config, int[] customRates)
    {
        Resolution = config.Bind("01. Display", "Resolution", $"{DisplayManager.MainWidth}x{DisplayManager.MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(DisplayManager.GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

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
        FullScreenModeConfig.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

        TargetFramerate = config.Bind("01. Display", "Target Framerate", DisplayManager.MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

        VSyncSetting = config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

        UseCustomRefreshRate = config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

        CustomRefreshRate = config.Bind("01. Display", "Custom Refresh Rate", DisplayManager.RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

        TargetFramerate = config.Bind("01. Display", "Target Framerate", DisplayManager.MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);


        CorrectFixedUpdateRate = config.Bind(
            "02. Performance",
            "Modify Physics Rate",
            true,
            new ConfigDescription(
                "Adjusts the fixed update rate to reduce camera judder based on your refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 94 }
            )
        );
        CorrectFixedUpdateRate.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);
        UseRefreshRateForFixedUpdateRate = config.Bind(
            "02. Performance",
            "Use Refresh Rate For Physics Rate",
            true,
            new ConfigDescription(
                "Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay.",
                null,
                new ConfigurationManagerAttributes { Order = 93 }
            )
        );
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => DisplayManager.UpdateAll(true);

        AdjustUiPixelAlignment = config.Bind(
            "03. UI Pixel Alignment",
            "Use Custom UI Width",
            false,
            new ConfigDescription("Only use if the UI text pixels appear misaligned. This will cause the UI to shift left/right but correct pixel alignments. You should only need extremely minor adjustments.", null, new ConfigurationManagerAttributes { Order = 86 })
        );
        AdjustUiPixelAlignment.SettingChanged += (_, _) => { SoSuiManager.UpdateUiWidth(); };

        UiPixelAlignment = config.Bind(
            "03. UI Pixel Alignment",
            "UI Width",
            640f,
            new ConfigDescription("Resize UI at very small (0.05) increments smaller/larger horizontally until the text appears normal. You will have to close this menu to see the results. Recommended to use the keybinds.", new AcceptableValueRange<float>(500f, 1000f), new ConfigurationManagerAttributes { Order = 85 })
        );
        UiPixelAlignment.SettingChanged += (_, _) =>
        {
            //0.05 increments
            UiPixelAlignment.Value = Mathf.Round(UiPixelAlignment.Value * 20) / 20;
            SoSuiManager.UpdateUiWidth();
        };

        UiPixelAlignmentLeftKeybind = config.Bind(
            "03. UI Pixel Alignment",
            "Shrink Viewport",
            KeyCode.LeftBracket,
            new ConfigDescription("Shrink the UI viewport. Shrinking too far will squash the image.", null, new ConfigurationManagerAttributes { Order = 91 })
        );
        UiPixelAlignmentRightKeybind = config.Bind(
            "03. UI Pixel Alignment",
            "Expand Viewport",
            KeyCode.RightBracket,
            new ConfigDescription("Expand the UI viewport. Expanding too far will stretch the image.", null, new ConfigurationManagerAttributes { Order = 90 })
        );
        ModifierKeybind = config.Bind(
            "03. UI Pixel Alignment",
            "Modifier Key",
            KeyCode.LeftShift,
            new ConfigDescription("The key that needs to be held to update the UI at a faster rate.", null, new ConfigurationManagerAttributes { Order = 89 })
        );
        ResetPixelAlignmentKeybind = config.Bind(
            "03. UI Pixel Alignment",
            "Reset Viewport",
            KeyCode.Backslash,
            new ConfigDescription("Reset the UI viewport to the default values.", null, new ConfigurationManagerAttributes { Order = 88 })
        );

        CinematicLetterboxing = config.Bind(
            "04. Gameplay",
            "Cinematic Letterboxing",
            false,
            new ConfigDescription("Toggle cinematic letterboxing.", null, new ConfigurationManagerAttributes { Order = 87 })
        );

        GamePlayRunSpeedMultiplier = config.Bind(
            "04. Gameplay",
            "Run Speed Multiplier",
            1f,
            new ConfigDescription("Adjust the run/walk speed during game-play (not the world map)", new AcceptableValueRange<float>(1f, 2f), new ConfigurationManagerAttributes { Order = 87 })
        );
        GamePlayRunSpeedMultiplier.SettingChanged += (_, _) =>
        {
            //0.25 increments
            GamePlayRunSpeedMultiplier.Value = Mathf.Round(GamePlayRunSpeedMultiplier.Value * 4) / 4;
        };

        WorldMapRunSpeedMultiplier = config.Bind(
            "04. Gameplay",
            "World Map Run Speed Multiplier",
            1f,
            new ConfigDescription("Adjust the run/walk speed on the world map.", new AcceptableValueRange<float>(1f, 3f), new ConfigurationManagerAttributes { Order = 87 })
        );
        WorldMapRunSpeedMultiplier.SettingChanged += (_, _) =>
        {
            //0.25 increments
            WorldMapRunSpeedMultiplier.Value = Mathf.Round(WorldMapRunSpeedMultiplier.Value * 4) / 4;
        };

        RunInBackground = config.Bind(
            "05. Misc",
            "Run In Background",
            true,
            new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 })
        );
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = config.Bind(
            "05. Misc",
            "Mute In Background",
            false,
            new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 })
        );
    }
}