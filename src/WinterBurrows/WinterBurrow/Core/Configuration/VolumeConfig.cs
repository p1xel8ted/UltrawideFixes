namespace WinterBurrow.Core.Configuration;

/// <summary>
/// Manages post-processing volume configuration settings.
/// </summary>
public static class VolumeConfig
{
    public static ConfigEntry<bool> Notifications { get; private set; }

    /// <summary>
    /// Initializes post-processing volume configuration with default values.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        Notifications = config.Bind("04. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription(
                "Enable or disable notifications for post-processing effects being registered for configuration.",
                null,
                new ConfigurationManagerAttributes { Order = 93 }));
    }
}