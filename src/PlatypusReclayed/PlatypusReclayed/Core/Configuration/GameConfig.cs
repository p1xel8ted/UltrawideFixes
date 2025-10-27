namespace PlatypusReclayed.Core.Configuration;

/// <summary>
/// Manages game-related configuration settings including playable area expansion.
/// </summary>
public static class GameConfig
{
    public static ConfigEntry<bool> ExpandPlayableArea { get; private set; }

    /// <summary>
    /// Initializes game configuration entries with default values.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        ExpandPlayableArea = config.Bind("03. Game", "Expand Playable Area", false,
            new ConfigDescription(
                "When enabled, this setting expands the playable area of the game to better utilize ultrawide. Makes the game very easy.",
                null,
                new ConfigurationManagerAttributes { Order = 92 }));
        
    }
}