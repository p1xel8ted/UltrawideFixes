using Astronomics.Helpers;
using Astronomics.Misc;
using UnityEngine.Rendering.Universal;

namespace Astronomics;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    // Plugin Metadata
    private const string PluginGuid = "p1xel8ted.astronomics.uwfixes";
    private const string PluginName = "Astronomics Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }
    
    internal static ConfigEntry<AntialiasingMode> AntialiasingModeConfig { get; private set; }
    internal static ConfigEntry<int> MSAA { get; private set; }
    public static ConfigEntry<bool> MaximumQuality { get; private set; }

    
    internal static ConfigFile ConfigFile { get; private set; }
    /// <summary>
    /// Initializes the plugin, setting up configuration entries, debug options, and event handlers.
    /// </summary>
    private void Awake()
    {
        ConfigFile = Config;
        Log = Logger;

        SetupGraphicsConfigurations(); //01
        SetupPostProcessConfigurations(); //02
   
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    /// <summary>
    /// Sets up configurations related to post-processing.
    /// </summary>
    private void SetupPostProcessConfigurations()
    {
        Notifications = Config.Bind("02. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 86 }));
    }
    
    /// <summary>
    /// Sets up configurations related to graphics settings.
    /// </summary>
    private void SetupGraphicsConfigurations()
    {
        MaximumQuality = Config.Bind("01. Graphics", "Maximum Quality", false,
            new ConfigDescription(
                "Enable this to use the highest quality settings for the game. This may reduce performance. If you disable this, you will need to restart the game to undo the changes.",
                null,
                new ConfigurationManagerAttributes { Order = 90 }));
        MaximumQuality.SettingChanged += (_, _) => { UpdateAll(); };

        MSAA = Config.Bind("01. Graphics", "MSAA", 0,
            new ConfigDescription(
                "Set the level of Multi-Sample Anti-Aliasing (MSAA) to use. Higher values result in better quality but lower performance.",
                new AcceptableValueList<int>(0, 2, 4, 8),
                new ConfigurationManagerAttributes { Order = 89 }));
        MSAA.SettingChanged += (_, _) => UpdateAll();

        AntialiasingModeConfig = Config.Bind("01. Graphics", "Anti-Aliasing Mode", AntialiasingMode.TemporalAntiAliasing,
            new ConfigDescription(
                "Choose the anti-aliasing mode to use for the game. Different modes offer varying levels of quality and performance.", null,
                new ConfigurationManagerAttributes { Order = 88 }));
        AntialiasingModeConfig.SettingChanged += (_, _) => UpdateAll();
    }


    /// <summary>
    /// Updates all systems based on configuration changes.
    /// </summary>
    private static void UpdateAll()
    {
        QualSettings.UpdateSettings();
        // BlackBars.Resize();
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        UpdateAll();
    }
}