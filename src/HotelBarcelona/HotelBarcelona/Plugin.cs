using System.IO;

namespace HotelBarcelona;

/// <summary>
/// BepInEx IL2CPP plugin that enables ultrawide support for Hotel Barcelona.
/// Patches resolution enforcement, UI scaling, camera viewports, letterboxing,
/// video playback, startup sequences, anti-aliasing, and post-processing volume management.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    /// <summary>Unique identifier for this BepInEx plugin.</summary>
    private const string PluginGuid = "p1xel8ted.hotelbarcelona.ultrawide";

    /// <summary>Display name shown in BepInEx plugin listings.</summary>
    private const string PluginName = "Hotel Barcelona Ultra-Wide";

    /// <summary>Current semantic version of the plugin.</summary>
    private const string PluginVersion = "0.1.0";

    /// <summary>BepInEx log source for writing to the log output.</summary>
    internal static ManualLogSource Logger { get; private set; }

    /// <summary>
    /// Flag set by the <see cref="FileSystemWatcher"/> when the config file changes on disk.
    /// Checked on the main thread to safely reload and apply config values.
    /// </summary>
    internal static volatile bool ConfigChanged;

    /// <summary>Prevents the config file watcher from being garbage collected.</summary>
    private static FileSystemWatcher _configWatcher;

    /// <summary>BepInEx config file instance, exposed for dynamic config creation by <see cref="Volumes"/>.</summary>
    internal static ConfigFile ConfigFile { get; private set; }

    /// <summary>
    /// Anti-aliasing mode to apply to all cameras. The game ships with no AA;
    /// this allows users to enable FXAA or SMAA via URP's <see cref="UniversalAdditionalCameraData"/>.
    /// </summary>
    internal static ConfigEntry<AntialiasingMode> AntiAliasing { get; private set; }

    /// <summary>
    /// Plugin entry point. Initializes display metrics, configures anti-aliasing,
    /// applies all Harmony patches, sets up config file watcher, and runs initial global fixups.
    /// </summary>
    public override void Load()
    {
        Logger = Log;
        ConfigFile = Config;

        DisplayMetrics.Initialize();

        AntiAliasing = Config.Bind("01. Quality", "Anti-Aliasing", AntialiasingMode.SubpixelMorphologicalAntiAliasing,
            new ConfigDescription("Set the anti-aliasing mode. The game ships with none. Options: None, FXAA (fast), SMAA (best quality)."));
        AntiAliasing.SettingChanged += (_, _) => Utils.UpdateAntiAliasing();

        SetupConfigWatcher();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}, IsWider: {DisplayMetrics.IsWiderThanNative}");

        Utils.ApplyGlobalFixups();
    }

    /// <summary>
    /// Creates a <see cref="FileSystemWatcher"/> on the config file. When the file is
    /// modified on disk, the config is automatically reloaded and all settings are re-applied.
    /// </summary>
    private void SetupConfigWatcher()
    {
        var configPath = Config.ConfigFilePath;
        var directory = Path.GetDirectoryName(configPath);
        var fileName = Path.GetFileName(configPath);

        if (directory == null)
        {
            Logger.LogError("Failed to set up config file watcher: could not determine config directory.");
            return;
        }

        _configWatcher = new FileSystemWatcher(directory, fileName)
        {
            NotifyFilter = NotifyFilters.LastWrite,
            EnableRaisingEvents = true
        };

        _configWatcher.Changed += (_, _) => ConfigChanged = true;

        Logger.LogInfo($"Config file watcher started: {configPath}");
    }
}
