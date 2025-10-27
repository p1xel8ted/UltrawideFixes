using OnceUponKatamari.Resolutions;

namespace OnceUponKatamari.Core.Configuration;

/// <summary>
/// Manages UI-related configuration settings including HUD aspect ratio preferences.
/// </summary>
public static class UIConfig
{
    public static ConfigEntry<string> HUDAspect { get; private set; }

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
        
    }
}