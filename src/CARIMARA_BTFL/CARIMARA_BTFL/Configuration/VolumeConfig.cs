namespace CARIMARA_BTFL.Configuration;

/// <summary>
/// Manages UI-related configuration settings including HUD aspect ratio preferences.
/// </summary>
public static class VolumeConfig
{
    public static ConfigEntry<bool> Notifications { get; private set; }

    /// <summary>
    /// Initializes UI configuration entries with default values and acceptable aspect ratios.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        Notifications = config.Bind("03. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 86 }));

        
    }
}