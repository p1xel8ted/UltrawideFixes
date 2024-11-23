// Configuration.cs

namespace SeaOfStars.Configuration;

public static class Configuration
{
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
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
    internal static ConfigEntry<float> RunSpeedMultiplier { get; private set; }
    internal static ConfigEntry<bool> CinematicLetterboxing { get; private set; }
    internal static ConfigEntry<bool> AdjustUiPixelAlignment { get; private set; }
    internal static ConfigEntry<float> UiPixelAlignment { get; private set; }

    public static void SetupConfig(ConfigFile config, int[] customRates)
    {
        FullScreenModeConfig = config.Bind(
            "01. Display",
            "Full Screen Mode",
            FullScreenMode.FullScreenWindow,
            new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 })
        );
        FullScreenModeConfig.SettingChanged += (_, _) => DisplayManager.UpdateDisplay();

        DisplayToUse = config.Bind(
            "01. Display",
            "Display to Use",
            0,
            new ConfigDescription(
                "Select the display to use.",
                new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()),
                new ConfigurationManagerAttributes { Order = 98 }
            )
        );
        DisplayToUse.SettingChanged += (_, _) => DisplayManager.UpdateDisplay();

        UseCustomRefreshRate = config.Bind(
            "01. Display",
            "Use Custom Refresh Rate",
            false,
            new ConfigDescription("Use a custom refresh rate instead of the maximum available.", null, new ConfigurationManagerAttributes { Order = 97 })
        );
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            DisplayManager.UpdateDisplay();
            DisplayManager.UpdateFixedDeltaTime();
        };

        CustomRefreshRate = config.Bind(
            "01. Display",
            "Custom Refresh Rate",
            DisplayManager.MaxRefresh,
            new ConfigDescription(
                "Set a custom refresh rate to use instead of the maximum available.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 96 }
            )
        );
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            DisplayManager.UpdateDisplay();
            DisplayManager.UpdateFixedDeltaTime();
        };

        TargetFramerate = config.Bind(
            "01. Display",
            "Target Framerate",
            DisplayManager.MaxRefresh,
            new ConfigDescription(
                "Set the target framerate",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 95 }
            )
        );
        TargetFramerate.SettingChanged += (_, _) =>
        {
            DisplayManager.UpdateDisplay();
            DisplayManager.UpdateFixedDeltaTime();
        };

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
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            DisplayManager.UpdateDisplay();
            DisplayManager.UpdateFixedDeltaTime();
        };

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
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            DisplayManager.UpdateDisplay();
            DisplayManager.UpdateFixedDeltaTime();
        };
        
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

        RunSpeedMultiplier = config.Bind(
            "04. Gameplay",
            "Run Speed Multiplier",
            1f,
            new ConfigDescription("Adjust the speed of the game.", new AcceptableValueRange<float>(0.25f, 2f), new ConfigurationManagerAttributes { Order = 87 })
        );
        RunSpeedMultiplier.SettingChanged += (_, _) =>
        {
            //0.25 increments
            RunSpeedMultiplier.Value = Mathf.Round(RunSpeedMultiplier.Value * 4) / 4;
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