namespace PrinceOfPersia;


[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.princeofpersia.ultrawide";
    private const string PluginName = "Prince of Persia: The Lost Crown Ultra-Wide";
    private const string PluginVersion = "0.1.3";
    internal static ManualLogSource Logger { get; set; }
    internal static ConfigEntry<bool> ExpandUI { get; private set; }
    internal static Plugin Instance { get; private set; }
    public override void Load()
    {
        Instance = this;
        ExpandUI = Config.Bind("General", "Expand UI", true, "Expand UI to the edges of the screen.");
        Logger = Log;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

}