namespace ArtifactSeekerTweaks;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.terramemoria.ultrawide";
    private const string PluginName = "Terra Memoria Ultra-Wide";
    private const string PluginVersion = "0.1.0";


    internal readonly static Dictionary<CanvasScaler, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    internal static float MainAspectRatio => MainWidth / (float) MainHeight;
    internal static float AspectDifference => (MainWidth - NormalWidth) / 2f;
    private static float BaseAspect => 16f / 9f;
    private static float NormalWidth => MainHeight * BaseAspect;
    private static ConfigEntry<int> DisplayToUse { get; set; }
 
    private static ConfigFile ConfigInstance { get; set; }
    private static ManualLogSource Logger { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    private static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    

    public override void Load()
    {
        Logger = Log;
        ConfigInstance = Config;
        
        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);

     
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Logger.LogWarning($"Scene {scene.name} loaded. Current FixedDeltaTime: {1f / Time.fixedDeltaTime}");
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1 / FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
        Logger.LogWarning($"Scene {scene.name} loaded. Current FixedDeltaTime: {1f / Time.fixedDeltaTime}");
    }
    
    public static float FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }

}