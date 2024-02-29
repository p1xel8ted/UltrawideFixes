namespace PeaksOfYore;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.peaksofyore.ultrawide";
    private const string PluginName = "Peaks of Yore Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static ManualLogSource LOG { get; set; }

    private void Awake()
    {
        LOG = Logger;

        DisplayToUse = Config.Bind("General", "Display To Use", 0, new ConfigDescription("The display to use for the game. 0 is generally the main.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (sender, args) => ChangeResolution();
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static void ChangeResolution()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }
    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        ChangeResolution();
    }
}