namespace PrinceOfPersia;

/// <summary>
/// Game is extremely sensitive to Harmony Patches. If you get random CTD's with no error, remove the Harmony patch you just added.
/// Need to ensure Unity Log Listening is set to False in BepInEx.
/// Custom build is also required to enable support for Ubisoft+ version. See GitHub repo. https://github.com/p1xel8ted/UltrawideFixes/tree/main/PrinceOfPersiaTheLostCrown/Custom%20BepInEx
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.princeofpersia.ultrawide";
    private const string PluginName = "Prince of Persia: The Lost Crown Ultra-Wide";
    private const string PluginVersion = "0.1.5";

    internal static ConfigEntry<bool> RemoveAllMapFog { get; private set; }

    internal static ConfigFile ConfigInstance { get; private set; }
    internal static ManualLogSource Logger { get; set; }


    public override void Load()
    {
        ConfigInstance = Config;

        RemoveAllMapFog = Config.Bind("General", "Remove All Map Fog", true, "Remove all map fog. Recommend using Guided Exploration mode if you have this on.");
        
        Logger = Log;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
}