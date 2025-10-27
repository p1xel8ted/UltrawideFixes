namespace ScarletMaiden.Core.Configuration;

/// <summary>
/// Manages camera-specific configuration settings including alternate camera mode and vertical positioning.
/// </summary>
public static class CameraConfig
{
    public static ConfigEntry<bool> AlternateCameraMode { get; private set; }
    public static ConfigEntry<int> CameraVerticality { get; private set; }

    /// <summary>
    /// Initializes camera configuration with default values and acceptable ranges.
    /// </summary>
    /// <param name="config">The BepInEx configuration file to bind settings to.</param>
    public static void Initialize(ConfigFile config)
    {
        AlternateCameraMode = config.Bind("03. Camera", "Enable Alternate Camera Mode", false, new ConfigDescription("Changes the behaviour of the follow camera. Camera will stick to you with this enabled.", null, new ConfigurationManagerAttributes { Order = 92 }));
        CameraVerticality = config.Bind("03. Camera", "Camera Vertical Position", 4, new ConfigDescription("Adjust the vertical position of the camera when using Alternate Mode.", new AcceptableValueRange<int>(-10, 10), new ConfigurationManagerAttributes { Order = 91 }));
    }

    public static void SubscribeToEvents(EventHandler updateAlternateCameraModeHandler)
    {
        AlternateCameraMode.SettingChanged += updateAlternateCameraModeHandler;
        CameraVerticality.SettingChanged += updateAlternateCameraModeHandler;
    }
}