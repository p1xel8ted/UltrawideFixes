namespace CARIMARA_BTFL.Configuration;

public static class FixedDeltaTimeConfig
{
    public static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; private set; }
    public static ConfigEntry<bool> CorrectFixedUpdateRate { get; private set; }
    internal static WriteOnce<float> OriginalFixedDeltaTime { get; } = new();

    /// <summary>
    /// Initializes Fixed Delta Time configuration entry with a default value.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        config.Bind("02. Performance", "**WARNING**", false,
            new ConfigDescription("TURN ALL THESE OFF IF YOU GET STUCK IN CERTAIN AREAS OF THE GAME", null, new ConfigurationManagerAttributes { Order = 93 }));
        
        CorrectFixedUpdateRate = config.Bind("02. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix and may or may not do anything in this particular title.", null, new ConfigurationManagerAttributes { Order = 92 }));

        UseRefreshRateForFixedUpdateRate = config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.", null, new ConfigurationManagerAttributes { Order = 91 }));
    }
    
    /// <summary>
    /// Subscribes to UI configuration change events to trigger fitter and scaler updates.
    /// </summary>
    /// <param name="fixedTimeHandler">Handler to update aspect ratio fitters and canvas scalers.</param>
    public static void SubscribeToEvents(EventHandler fixedTimeHandler)
    {
        CorrectFixedUpdateRate.SettingChanged += fixedTimeHandler;
        UseRefreshRateForFixedUpdateRate.SettingChanged += fixedTimeHandler;
    }
}