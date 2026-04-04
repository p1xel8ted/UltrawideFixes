// Plugin.cs

namespace SeaOfStars;

[BepInPlugin(Core.Constants.PluginGuid, Core.Constants.PluginName, Core.Constants.PluginVersion)]
public class Plugin : BasePlugin
{
    public static ManualLogSource Logger { get; private set; }

    public override void Load()
    {
        Logger = Log;

        ClassInjector.RegisterTypeInIl2Cpp<LayoutController>();
        ClassInjector.RegisterTypeInIl2Cpp<EventSystemSwitcher>();
        
        DisplayManager.CaptureOriginalFixedDeltaTime();
        Configuration.Configuration.SetupConfig(Config);
        DisplayManager.RefreshDisplayInfo();

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneHandlers.OnSceneLoaded;
        SceneManager.sceneUnloaded += (UnityAction<Scene>)SceneHandlers.OnSceneUnloaded;

        Logger.LogInfo($"Plugin {Core.Constants.PluginName} is loaded!");
        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Core.Constants.PluginGuid);

        UniverseLibPatches.Apply(harmony);
    }
}
