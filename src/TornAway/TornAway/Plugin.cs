namespace TornAway;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.tornaway.uwfixes";
    private const string PluginName = "Torn Away Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal const float NativeAspect = 16f / 9f;
    internal static readonly List<AspectRatioFitter> AspectRatioFitters = [];
    internal static readonly List<Transform> AspectRatioTransforms = [];
    internal static float MainAspect => Screen.width / (float)Screen.height;
    private static ManualLogSource Log { get; set; }
    public static float PositiveScaleFactor => MainAspect / NativeAspect;
    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<bool> AnimatedScreenOverlay { get; private set; }
    internal static ConfigEntry<bool> AllDialogSkippable { get; private set; }
    internal static ConfigEntry<bool> AutoPassDialog { get; private set; }
    internal static ConfigEntry<bool> FasterDialog { get; private set; }
    internal static ConfigFile ConfigFile { get; private set; }

    private void Awake()
    {
        ConfigFile = Config;
        Debug.unityLogger.logEnabled = true;
        Log = Logger;

        AllDialogSkippable = Config.Bind("01. Dialog", "All Dialog Skippable", false,
            new ConfigDescription("Enable or disable the ability to skip all dialog.", null, new ConfigurationManagerAttributes { Order = 100 }));
        
        AutoPassDialog = Config.Bind("01. Dialog", "Auto-Pass Dialog", false,    
            new ConfigDescription("Enable or disable the ability to auto-pass dialog.", null, new ConfigurationManagerAttributes { Order = 99 }));
        
        FasterDialog = Config.Bind("01. Dialog", "Faster Dialog", false,
            new ConfigDescription("Enable or disable faster dialog.", null, new ConfigurationManagerAttributes { Order = 98 }));
        
        Notifications = Config.Bind("02. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 98 }));
        
        AnimatedScreenOverlay = Config.Bind("02. Post-Processing", "Animated Screen Overlay", true,
            new ConfigDescription("Enable or disable the animated screen overlay. Best to turn off the other post-process effects to see what this setting does.", null, new ConfigurationManagerAttributes { Order = 97 }));
        AnimatedScreenOverlay.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };
        
        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static void UpdateAspects()
    {
        foreach (var fitter in AspectRatioFitters.Where(fitter => fitter))
        {
            fitter.aspectRatio = MainAspect;
        }

        foreach (var transform in AspectRatioTransforms.Where(transform => transform))
        {
            transform.localScale = transform.localScale with { x = PositiveScaleFactor };
        }
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAspects();
        UpdateCameras();
        Patches.UpdateVolumes();
    }

    internal static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
            if (!cam) continue;
            cam.gateFit = cam.aspect > NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }
}