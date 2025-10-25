namespace WinterBurrows.Core.Configuration;

/// <summary>
/// Manages camera field of view configuration settings.
/// </summary>
public static class FoVConfig
{
    public static ConfigEntry<float> FieldOfViewMultiplier { get; private set; }

    /// <summary>
    /// Initializes field of view configuration with default values and acceptable range.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        FieldOfViewMultiplier = config.Bind("03. Camera", "Field of View Multiplier", 1.0f,
            new ConfigDescription(
                "Adjusts the field of view (FoV). A value greater than 1.0 increases FoV, while a value less than 1.0 decreases it.",
                new AcceptableValueRange<float>(0.25f, 2.0f),
                new ConfigurationManagerAttributes { Order = 92 }));

        // Snap the value to 0.025 increments for smoother adjustment
        FieldOfViewMultiplier.SettingChanged += (_, _) =>
        {
            FieldOfViewMultiplier.Value = (float)Math.Round(FieldOfViewMultiplier.Value * 40f) / 40f;
        };
    }
}