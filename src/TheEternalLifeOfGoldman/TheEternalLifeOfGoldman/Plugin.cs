// Plugin.cs — BepInEx 6 IL2CPP entry point for The Eternal Life of Goldman ultrawide fix.
// Initializes display metrics, applies Harmony patches, forces native ultrawide resolution,
// and sets the game's widescreen aspect ratio.

namespace TheEternalLifeOfGoldman;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.theeternallifeofgoldman.ultrawide";
    private const string PluginName = "The Eternal Life of Goldman Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Logger { get; private set; }
    internal static ConfigFile ConfigFile { get; private set; }

    public override void Load()
    {
        Logger = Log;
        ConfigFile = Config;

        DisplayMetrics.Initialize();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneLoaded;
        PlayerCamera.WideScreenAspectRatio = DisplayMetrics.MainAspect;

        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}");

#if DEBUG
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.Windowed);
#else
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow, DisplayMetrics.MaxRefresh);
#endif
    }

    private static void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Plugin.Logger.LogInfo($"Scene loaded: {scene.name}. Enforcing resolution and aspect ratio.");
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow, DisplayMetrics.MaxRefresh);
    }

}