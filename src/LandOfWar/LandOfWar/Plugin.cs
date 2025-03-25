namespace LandOfWar;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    // Plugin Metadata
    private const string PluginGuid = "p1xel8ted.landofwar.uwfixes";
    private const string PluginName = "Land of War Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; set; }
    internal static ConfigFile ConfigFile { get; private set; }
    internal static ConfigEntry<float> GameCameraFieldOfViewMultiplier { get; private set; }
    internal static ConfigEntry<float> MenuCameraFieldOfViewMultiplier { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    private void Awake()
    {
        ConfigFile = Config;
        Log = Logger;

        GameCameraFieldOfViewMultiplier = Config.Bind("01. Camera", "Field of View Multiplier", 1f,
            new ConfigDescription("The multiplier applied to the game's field of view. Default is 1.0.", new AcceptableValueRange<float>(0.25f, 2f), new ConfigurationManagerAttributes { Order = 86 }));
        GameCameraFieldOfViewMultiplier.SettingChanged += (_, _) =>
        {
            GameCameraFieldOfViewMultiplier.Value = Mathf.Round(GameCameraFieldOfViewMultiplier.Value * 10) / 10;
        };
        
        RunInBackground =   Config.Bind("01. Camera", "Run In Background", true,
            new ConfigDescription("Enable or disable running the game in the background.", null, new ConfigurationManagerAttributes { Order = 85 }));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };
        
        Notifications = Config.Bind("02. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 84 }));

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    internal static void UpdateCameraGateFit()
    {
        const float baseAspect = 16f / 9f;
        var cameras = Camera.allCameras.ToList();
        foreach (var cam in cameras.Where(cam => cam.aspect > 1f))
        {
            cam.gateFit = cam.aspect > baseAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
            Log.LogWarning($"Updated GateFit for '{cam.name}'");
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        UpdateCameraGateFit();
        Application.runInBackground = RunInBackground.Value;
    }
}