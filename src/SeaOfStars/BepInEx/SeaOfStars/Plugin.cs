// Plugin.cs

namespace SeaOfStars;

[BepInPlugin(Core.Constants.PluginGuid, Core.Constants.PluginName, Core.Constants.PluginVersion)]
[BepInDependency("com.p1xel8ted.BepInExConfigManager", "2.1.0")]
public class Plugin : BasePlugin
{
    public static ManualLogSource Logger { get; private set; }

    public override void Load()
    {
        Logger = Log;

        ConfigManager.ConfigManager.OnMenuVisibilityChanged += SoSuiManager.HandleConfigManager;
        
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        ClassInjector.RegisterTypeInIl2Cpp<LayoutController>();
        
        var customRates = Utilities.Utilities.MergeUnityRefreshRates();

        // Configuration setup
        Configuration.Configuration.SetupConfig(Config, customRates);

        Application.focusChanged += (Il2CppSystem.Action<bool>)DisplayManager.FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneHandlers.OnSceneLoaded;
        SceneManager.sceneUnloaded += (UnityAction<Scene>)SceneHandlers.OnSceneUnloaded;

        Logger.LogInfo($"Plugin {Core.Constants.PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Core.Constants.PluginGuid);
    }
}