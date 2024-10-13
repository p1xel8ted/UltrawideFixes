// Configuration.cs

using SeaOfStars.Managers;

namespace SeaOfStars.Configuration;

public static class Configuration
{
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static ConfigEntry<KeyCode> ShiftViewportLeftKeybind { get; private set; }
    internal static ConfigEntry<KeyCode> ShiftViewportRightKeybind { get; private set; }
    internal static ConfigEntry<KeyCode> ResetViewportKeybind { get; private set; }
    internal static ConfigEntry<KeyCode> ModifierKeybind { get; private set; }
    internal static ConfigEntry<int> UiPosition { get; private set; }
    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    internal static ConfigEntry<bool> MuteInBackground { get; private set; }
    internal static ConfigEntry<int> CustomRefreshRate { get; private set; }
    internal static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; private set; }
    internal static ConfigEntry<bool> CorrectFixedUpdateRate { get; private set; }
    internal static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }
    internal static ConfigEntry<int> TargetFramerate { get; private set; }

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

        ShiftViewportLeftKeybind = config.Bind(
            "03. UI",
            "Shift Viewport Left",
            KeyCode.LeftBracket,
            new ConfigDescription("Shift the UI viewport to the left.", null, new ConfigurationManagerAttributes { Order = 91 })
        );
        ShiftViewportRightKeybind = config.Bind(
            "03. UI",
            "Shift Viewport Right",
            KeyCode.RightBracket,
            new ConfigDescription("Shift the UI viewport to the right.", null, new ConfigurationManagerAttributes { Order = 90 })
        );
        ModifierKeybind = config.Bind(
            "03. UI",
            "Modifier Key",
            KeyCode.LeftShift,
            new ConfigDescription("The key that needs to be held to shift the viewport at a faster rate.", null, new ConfigurationManagerAttributes { Order = 89 })
        );
        ResetViewportKeybind = config.Bind(
            "03. UI",
            "Reset Viewport",
            KeyCode.Backslash,
            new ConfigDescription("Reset the UI viewport to the default position.", null, new ConfigurationManagerAttributes { Order = 88 })
        );

        UiPosition = config.Bind(
            "03. UI",
            "UI Position",
            SoSuiManager.CanvasPosition,
            new ConfigDescription(
                "Set the position of the UI on the x-axis.",
                new AcceptableValueRange<int>(-1000, 1000),
                new ConfigurationManagerAttributes { Order = 92 })
        );
        UiPosition.SettingChanged += (_, _) => { SoSuiManager.HandleShiftViewportViaUI(); };

        RunInBackground = config.Bind(
            "07. Misc",
            "Run In Background",
            true,
            new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 })
        );
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = config.Bind(
            "07. Misc",
            "Mute In Background",
            false,
            new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 })
        );
    }
}