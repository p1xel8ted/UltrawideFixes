// Plugin.cs

using SeaOfStars.Components;
using SeaOfStars.Handlers;
using SeaOfStars.Managers;
using SeaOfStars.Utilities;

namespace SeaOfStars.Core;

[BepInPlugin(Constants.PluginGuid, Constants.PluginName, Constants.PluginVersion)]
[BepInDependency("com.p1xel8ted.BepInExConfigManager", "2.1.0")]
public class Plugin : BasePlugin
{
    public static ManualLogSource Logger { get; private set; }

    public override void Load()
    {
        Logger = Log;

        ConfigManager.ConfigManager.OnMenuVisibilityChanged += SoSuiManager.HandleConfigManager;
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        AddComponent<MonoMethods>();
        AddComponent<WindowPositioner>(); // Add WindowPositioner as a component

        var customRates = Utilities.Utilities.MergeUnityRefreshRates();

        // Configuration setup
        Configuration.Configuration.SetupConfig(Config, customRates);

        Application.focusChanged += (Il2CppSystem.Action<bool>)DisplayManager.FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneHandlers.OnSceneLoaded;
        SceneManager.sceneUnloaded += (UnityAction<Scene>)SceneHandlers.OnSceneUnloaded;

        Logger.LogInfo($"Plugin {Constants.PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Constants.PluginGuid);

        State.FishingViewPortUpdated = false;
        State.FishingActive = false;
    }
}