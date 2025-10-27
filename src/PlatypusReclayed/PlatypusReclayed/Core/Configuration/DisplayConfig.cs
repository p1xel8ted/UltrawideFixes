namespace PlatypusReclayed.Core.Configuration;

/// <summary>
/// Manages display-related configuration settings including resolution, fullscreen mode, VSync, and refresh rates.
/// </summary>
public static class DisplayConfig
{
    /// <summary>
    /// Maps user-friendly VSync option names to Unity's VSync count values.
    /// </summary>
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    public static ConfigEntry<FullScreenMode> FullScreenMode { get; private set; }
    public static ConfigEntry<string> Resolution { get; private set; }
    public static ConfigEntry<string> VSyncSetting { get; private set; }
    public static ConfigEntry<int> CustomRefreshRate { get; private set; }
    public static ConfigEntry<int> TargetFramerate { get; private set; }
    public static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }

    /// <summary>
    /// Initializes all display configuration entries with default values and acceptable ranges.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        Resolution = config.Bind("01. Display", "Resolution", $"{Display.main.systemWidth}x{Display.main.systemHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(ResolutionManager.GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));

        FullScreenMode = config.Bind("01. Display", "Full Screen Mode", UnityEngine.FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));

        TargetFramerate = config.Bind("01. Display", "Target Framerate", ResolutionManager.MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(ResolutionManager.MergeUnityRefreshRates()),
                new ConfigurationManagerAttributes { Order = 97 }));

        VSyncSetting = config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game's frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));

        UseCustomRefreshRate = config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));

        CustomRefreshRate = config.Bind("01. Display", "Custom Refresh Rate", ResolutionManager.RefreshRateValue,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(ResolutionManager.MergeUnityRefreshRates()),
                new ConfigurationManagerAttributes { Order = 94 }));
    }

    /// <summary>
    /// Subscribes to configuration change events to trigger appropriate update handlers.
    /// </summary>
    /// <param name="updateDisplayHandler">Handler for settings that only require display updates.</param>
    /// <param name="updateAllHandler">Handler for settings that require full system updates (resolution, fullscreen mode).</param>
    public static void SubscribeToEvents(EventHandler updateDisplayHandler, EventHandler updateAllHandler)
    {
        // Resolution and fullscreen mode changes require full system updates
        Resolution.SettingChanged += updateAllHandler;
        FullScreenMode.SettingChanged += updateAllHandler;

        // Other display settings only need display-specific updates
        TargetFramerate.SettingChanged += updateDisplayHandler;
        VSyncSetting.SettingChanged += updateDisplayHandler;
        UseCustomRefreshRate.SettingChanged += updateDisplayHandler;
        CustomRefreshRate.SettingChanged += updateDisplayHandler;
    }

    /// <summary>
    /// Converts the user-friendly VSync setting name to Unity's VSync count value.
    /// </summary>
    /// <returns>The VSync count value (0=disabled, 1=every refresh, 2=every 2nd refresh). Defaults to 1 if invalid.</returns>
    public static int GetVSyncValue()
    {
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var value))
        {
            return value;
        }

        // Invalid value found - log warning and reset to valid default
        var invalidValue = VSyncSetting.Value;
        const string defaultValue = "Enabled (Every Refresh)";

        Plugin.Log.LogWarning($"Invalid VSync setting '{invalidValue}'. Resetting to '{defaultValue}'.");
        VSyncSetting.Value = defaultValue;

        return 1; // Default to VSync enabled
    }
}