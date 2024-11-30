namespace VampireSurvivors;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.vampiresurvivors.ultrawide";
    private const string PluginName = "Vampire Survivors Ultra-Wide (BepInEx)";
    private const string PluginVersion = "0.2.1";
    
    private const float NativeAspectRatio = 1.6f;
    internal static readonly int MainWidth = Display.main.systemWidth;
    internal static readonly int MainHeight = Display.main.systemHeight; //1440
    internal static readonly float MainAspect = MainWidth / (float)MainHeight; //2.388888888888889
    internal static readonly float PositiveScaleFactor = MainAspect / NativeAspectRatio; //1.493827160493827
    private static ManualLogSource Logger { get; set; }
    public static ConfigEntry<bool> ExpandSpawnZone { get; private set; }
    
    public override void Load()
    {
        Logger = Log;
        
        ExpandSpawnZone = Config.Bind("01. Gameplay", "Expand Spawn Zone", true, new ConfigDescription("Expands the spawn zone to fit the new resolution.", null, new ConfigurationManagerAttributes { Order = 92 }));
        ExpandSpawnZone.SettingChanged += (_, _) => { UpdateStageRects(); };
    
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void UpdateStageRects()
    {
        var stage = Resources.FindObjectsOfTypeAll<Stage>().FirstOrDefault();
        if (stage)
        {
            stage.InitRects();
        }
    }
}