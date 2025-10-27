namespace ScarletMaiden.Core.Configuration;

/// <summary>
/// Manages UI-related configuration settings including HUD aspect ratio preferences.
/// </summary>
public static class UIConfig
{
    public static ConfigEntry<string> HUDAspect { get; private set; }
    public static ConfigEntry<string> DialogAspect { get; private set; }

    /// <summary>
    /// Initializes UI configuration entries with default values and acceptable aspect ratios.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        HUDAspect = config.Bind("02. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(ResolutionManager.GetAvailableHUDAspects().ToArray()),
                new ConfigurationManagerAttributes { Order = 93 }));

        DialogAspect = config.Bind("02. UI", "Dialog Aspect", "16:9",
            new ConfigDescription(
                "Choose the aspect ratio for in-game dialog boxes. This setting is independent of the main HUD aspect ratio.",
                new AcceptableValueList<string>(ResolutionManager.GetAvailableHUDAspects().ToArray()),
                new ConfigurationManagerAttributes { Order = 92 }));
    }

    /// <summary>
    /// Subscribes to UI configuration change events to trigger fitter and scaler updates.
    /// </summary>
    /// <param name="updateFitterScalersHandler">Handler to update aspect ratio fitters and canvas scalers.</param>
    public static void SubscribeToEvents(EventHandler updateFitterScalersHandler)
    {
        HUDAspect.SettingChanged += updateFitterScalersHandler;
        DialogAspect.SettingChanged += updateFitterScalersHandler;
    }
}