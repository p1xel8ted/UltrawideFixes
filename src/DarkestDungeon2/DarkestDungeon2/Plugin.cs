namespace DarkestDungeon2;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.darkestdungeon2.ultrawide";
    private const string PluginName = "Darkest Dungeon 2 Ultra-Wide";
    private const string PluginVersion = "0.1.3";
        
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    internal static RefreshRate MaxRefresh => Screen.resolutions.Max(a => a.refreshRateRatio);
    internal static ManualLogSource LOG { get; private set; }

    private void Awake()
    {
        LOG = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

}