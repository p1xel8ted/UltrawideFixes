namespace PrinceOfPersia;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.princeofpersia.ultrawide";
    private const string PluginName = "Prince of Persia: The Lost Crown Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private static ManualLogSource Logger { get; set; }
    public override void Load()
    {
        Logger = Log;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

}