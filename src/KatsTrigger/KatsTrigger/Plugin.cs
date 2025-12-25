namespace KatsTrigger;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.katstrigger.ultrawide";
    private const string PluginName = "Kats Trigger Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    internal static float MainAspect => MainWidth / (float)MainHeight;
    internal static ManualLogSource Logger { get; private set; }
    internal static float NativeAspectRatio => 16f / 9f;
    internal static float CurrentAspectRatio => MainWidth / (float)MainHeight;

    public static RefreshRate RefreshRateStruct => new()
    {
        denominator = 1,
        numerator = (uint)MaxRefresh,
    };

    private static void UpdateCanvasScalers()
    {
        var scalers = Patches.Patches.Scalers.ToList();
        foreach (var scaler in scalers)
        {
            Patches.Patches.ProcessScaler(scaler);
        }
    }

    private static void RunFixes()
    {
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        UpdateCanvasScalers();
    }

    public override void Load()
    {
        Logger = Log;
        
        RunFixes();

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }


    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RunFixes();
    }
}