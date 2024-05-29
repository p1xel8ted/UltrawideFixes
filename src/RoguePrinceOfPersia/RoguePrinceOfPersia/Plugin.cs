namespace RoguePrinceOfPersia;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.rogueprinceofpersia.ultrawide";
    private const string PluginName = "The Rogue Prince of Persia Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> Scaling { get; set; }
    private static ConfigEntry<bool> IncludeDialogue { get; set; }

    public override void Load()
    {
        Scaling = Config.Bind("01. Scaling", "Scaling", false, new ConfigDescription("Toggle scaling behaviour. Turn off to make UI smaller.", null, new ConfigurationManagerAttributes {Order = 100}));
        Scaling.SettingChanged += (_, _) =>
        {
            RunScalers();
        };
        IncludeDialogue = Config.Bind("01. Scaling", "Include Dialogue", false, new ConfigDescription("Include dialogue in scaling.", null, new ConfigurationManagerAttributes {Order = 99}));
        IncludeDialogue.SettingChanged += (_, _) =>
        {
            RunScalers();
        };
        RunInBackground = Config.Bind("02. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };
        
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
    
    private static void RunScalers()
    {
        var scalers = Utils.FindIl2CppType<CanvasScaler>();
        foreach (var scaler in scalers.Where(scaler => !scaler.name.Contains("sinai")))
        {
            scaler.enabled = Scaling.Value;
            if (!Scaling.Value && scaler.name.Equals("DiablogueViewsCanvas"))
            {
                scaler.enabled = !IncludeDialogue.Value;
            }
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        RunScalers();
    }

}