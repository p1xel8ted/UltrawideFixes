namespace PrisonOfHusks;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.prisonofhusks.ultrawide";
    private const string PluginName = "Prison of Husks Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }
    public static ConfigFile ConfigFile { get; private set; }
    internal static ConfigEntry<float> AdditionalFov { get; set; }
    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;

        DisplayMetrics.Initialize();

        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}, IsWider: {DisplayMetrics.IsWiderThanNative}");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Log.LogInfo($"Scene loaded: {scene.name}");
        Volumes.ScanAndApply();
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow,0);
    }

}
