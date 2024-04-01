namespace DeathMustDie;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.deathmustdie.ultrawide";
    private const string PluginName = "Death Must Die Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static float MainAspectRatio => MainWidth / (float) MainHeight;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspect;
    private static float BaseAspect => 16f / 9f;
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<bool> RemoveExcessMenuItems { get; private set; }
    internal static ConfigEntry<bool> LoadStraightIntoGame { get; private set; }
    internal static ConfigEntry<bool> CorrectMainMenuBackground { get; private set; }
    internal static ManualLogSource Log { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private void Awake()
    {
        Log = Logger;
        DisplayToUse = Config.Bind("01. General", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        };
        RemoveExcessMenuItems = Config.Bind("01. General", "Remove Excess Menu Items", true, new ConfigDescription("Remove excess menu items", null));
        LoadStraightIntoGame = Config.Bind("01. General", "Load Straight Into Game", true, new ConfigDescription("Load straight into game", null));
        CorrectMainMenuBackground = Config.Bind("01. General", "Correct Main Menu Background", true, new ConfigDescription("Correct main menu background", null));
        
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }
    
    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.Windowed, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }
}