namespace Sunderfolk;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.sunderfolk.ultrawide";
    private const string PluginName = "Sunderfolk Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static float CurrentAspect => Screen.width / (float)Screen.height;
    internal static float CurrentWidth => Screen.width;
    internal static float CurrentHeight => Screen.height;
    internal const float NativeAspect = 16f / 9f;
    private static ManualLogSource Logger { get; set; }

    public override void Load()
    {
        Logger = Log;
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Patches.UpdateAllCameras();
        Patches.UpdateCanvasScalers();
    }
}