// Configuration.cs

namespace SeaOfStars.Configuration;

public static class Configuration
{
    internal static ConfigEntry<float> GamePlayRunSpeedMultiplier { get; private set; }
    internal static ConfigEntry<float> WorldMapRunSpeedMultiplier { get; private set; }
    internal static ConfigEntry<bool> CorrectFixedUpdateRate { get; private set; }
    internal static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; private set; }
    internal static ConfigEntry<bool> EnableDebugLogging { get; private set; }

    public static void SetupConfig(ConfigFile config)
    {
        GamePlayRunSpeedMultiplier = config.Bind(
            "01. Gameplay",
            "Run Speed Multiplier",
            1f,
            new ConfigDescription("Adjust the run/walk speed during game-play (not the world map)", new AcceptableValueRange<float>(1f, 2f), new ConfigurationManagerAttributes { Order = 87 })
        );
        GamePlayRunSpeedMultiplier.SettingChanged += (_, _) =>
        {
            //0.25 increments
            GamePlayRunSpeedMultiplier.Value = Mathf.Round(GamePlayRunSpeedMultiplier.Value * 4) / 4;
        };

        WorldMapRunSpeedMultiplier = config.Bind(
            "01. Gameplay",
            "World Map Run Speed Multiplier",
            1f,
            new ConfigDescription("Adjust the run/walk speed on the world map.", new AcceptableValueRange<float>(1f, 3f), new ConfigurationManagerAttributes { Order = 87 })
        );
        WorldMapRunSpeedMultiplier.SettingChanged += (_, _) =>
        {
            //0.25 increments
            WorldMapRunSpeedMultiplier.Value = Mathf.Round(WorldMapRunSpeedMultiplier.Value * 4) / 4;
        };

        CorrectFixedUpdateRate = config.Bind(
            "02. Performance",
            "Correct Physics Rate",
            true,
            new ConfigDescription("Adjusts the physics update rate to reduce camera judder based on your refresh rate.", null, new ConfigurationManagerAttributes { Order = 92 })
        );
        CorrectFixedUpdateRate.SettingChanged += (_, _) => DisplayManager.UpdateFixedDeltaTime();

        UseRefreshRateForFixedUpdateRate = config.Bind(
            "02. Performance",
            "Use Monitor Refresh Rate",
            true,
            new ConfigDescription("Uses your monitor's refresh rate directly for the physics update rate. When disabled, a calculated optimal rate is used instead.", null, new ConfigurationManagerAttributes { Order = 91 })
        );
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => DisplayManager.UpdateFixedDeltaTime();

        EnableDebugLogging = config.Bind(
            "03. Advanced",
            "Enable Debug Logging",
            false,
            new ConfigDescription("Enable verbose plugin logging for troubleshooting.", null, new ConfigurationManagerAttributes { Order = 1 })
        );

    }
}
