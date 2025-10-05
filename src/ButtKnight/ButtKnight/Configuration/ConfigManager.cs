using ButtKnight.Patches;
using ClimbGames.Base;

namespace ButtKnight.Configuration;

internal static class ConfigManager
{
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static ConfigEntry<string> Resolution { get; private set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }
    internal static ConfigEntry<int> CustomRefreshRate { get; private set; }
    internal static ConfigEntry<int> TargetFramerate { get; private set; }
    internal static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }
    internal static ConfigEntry<string> HUDAspect { get; private set; }
    internal static ConfigEntry<bool> ScanLines { get; private set; }
    internal static ConfigEntry<bool> ForestSides { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> FasterSceneTransitions { get; private set; }
    
    internal static ConfigEntry<bool> AlternateWorldMapView { get; private set; }
    internal static ConfigEntry<Plugin.SkipChoice> SkipChoiceConfig { get; private set; }
    internal static ConfigEntry<Color> AlternateMapColor { get; private set; }

    internal static ConfigEntry<bool> RichPresence { get; private set; }
    internal static ConfigEntry<bool> HidePresenceDuringAdultContent { get; private set; }
    internal static ConfigEntry<bool> UseGenericPresenceText { get; private set; }
    

    internal static void Initialize(ConfigFile config, Action onDisplayUpdate, Action onHUDUpdate, Action onScanLinesUpdate, Action onVignetteUpdate, Action onForestSidesUpdate, Action onAlternateMapColorUpdate)
    {
        var customRates = Resolutions.MergeUnityRefreshRates();

        // Display Settings
        Resolution = config.Bind("01. Display", "Resolution", $"{Resolutions.MainWidth}x{Resolutions.MainHeight}",
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

        // Camera Settings
        ScanLines = config.Bind("02. Camera", "Scan Lines", true,
            new ConfigDescription("Enable or disable scan lines effect.", null, new ConfigurationManagerAttributes { Order = 10 }));
        ScanLines.SettingChanged += (_, _) => onScanLinesUpdate();

        Vignette = config.Bind("02. Camera", "Vignette", true,
            new ConfigDescription("Enable or disable vignette effect.", null, new ConfigurationManagerAttributes { Order = 12 }));
        Vignette.SettingChanged += (_, _) => onVignetteUpdate();

        ForestSides = config.Bind("02. Camera", "Forest Side Decorations", true,
            new ConfigDescription("Enable or disable the forest side decorations in the background.", null, new ConfigurationManagerAttributes { Order = 13 }));
        ForestSides.SettingChanged += (_, _) => onForestSidesUpdate();

        // Intro Settings
        SkipChoiceConfig = config.Bind("03. Intros", "Intro and Logo Animations", Plugin.SkipChoice.SkipNone,
            new ConfigDescription("Choose which intro elements to skip:\n" +
                                  "• SkipNone - Normal intro sequence (insert coin → intro animation → press any key → menu)\n" +
                                  "• SkipInsertAnyCoinOnly - Skip the 'insert coin' screen, go straight to intro animation\n" +
                                  "• SkipAll - Skip everything and go straight to main menu",
                null,
                new ConfigurationManagerAttributes { Order = 11 }));

        // UI Settings
        HUDAspect = config.Bind("04. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(Resolutions.HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 93 }));
        HUDAspect.SettingChanged += (_, _) => onHUDUpdate();
        
        FasterSceneTransitions = config.Bind("04. UI", "Faster Scene Transitions", true,
            new ConfigDescription("Enable or disable faster scene transition effects.", null, new ConfigurationManagerAttributes { Order = 91 }));
        
        AlternateWorldMapView = config.Bind("05. World Map", "Alternate World Map View", true,
            new ConfigDescription("Enable or disable the alternate world map view.", null, new ConfigurationManagerAttributes { Order = 90 }));
        
        AlternateMapColor = config.Bind("05. World Map", "Alternate Map Color", new Color(0.0896f, 0.0532f, 0.1032f, 1f),
            new ConfigDescription("Choose the background color for the alternate world map view.", null, new ConfigurationManagerAttributes { Order = 89 }));
        AlternateMapColor.SettingChanged += (_, _) => onAlternateMapColorUpdate();

        // Privacy Settings
        RichPresence = config.Bind("06. Privacy", "Rich Presence", true,
            new ConfigDescription("Completely disable Steam and Discord Rich Presence for privacy.",
                null, new ConfigurationManagerAttributes { Order = 20 }));
        RichPresence.SettingChanged += (_, _) =>
        {
            if (!Singleton<SteamworksManager>.Instance.IsInitialized)
            {
                Singleton<SteamworksManager>.Instance.Initialize();  
            }
            
            if (!RichPresence.Value)
            {
                ButtKnight.Patches.Patches.ClearRichPresence();
            }
        };

        HidePresenceDuringAdultContent = config.Bind("06. Privacy", "Hide Presence During Adult Content", false,
            new ConfigDescription("Hide Rich Presence during H-scenes and adult content.",
                null, new ConfigurationManagerAttributes { Order = 19 }));

        UseGenericPresenceText = config.Bind("06. Privacy", "Use Generic Presence Text", false,
            new ConfigDescription("Replace all presence text with generic 'Daydreaming' status.",
                null, new ConfigurationManagerAttributes { Order = 18 }));
        UseGenericPresenceText.SettingChanged += (_, _) =>
        {
            if (UseGenericPresenceText.Value)
            {
                ButtKnight.Patches.Patches.TrySetSteamPresence();
            }
        };
    }

    internal static int GetVSyncCount()
    {
        return VSyncOptions.GetValueOrDefault(VSyncSetting.Value, 1);
    }
}
