namespace WinterBurrows;

/// <summary>
/// Main BepInEx plugin class that coordinates ultra-wide monitor support for Winter Burrows.
/// Manages resolution, UI scaling, camera field of view, and post-processing effects.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.winterburrows.ultrawide";
    private const string PluginName = "Winter Burrows Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>
    /// The game's native aspect ratio (16:9).
    /// </summary>
    public const float NativeAspect = 16f / 9f;

    /// <summary>
    /// BepInEx logger for plugin diagnostics.
    /// </summary>
    internal static ManualLogSource Log { get; private set; }

    /// <summary>
    /// Gets the current display aspect ratio.
    /// </summary>
    public static float CurrentAspect => Screen.width / (float)Screen.height;

    /// <summary>
    /// Shared config file reference for cross-system access.
    /// </summary>
    internal static ConfigFile ConfigFile { get; set; }

    /// <summary>
    /// Initializes the plugin, sets up configuration, subscribes to events, and applies Harmony patches.
    /// </summary>
    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;

        // Initialize all configuration subsystems
        DisplayConfig.Initialize(Config);
        UIConfig.Initialize(Config);
        VolumeConfig.Initialize(Config);
        FoVConfig.Initialize(Config);

        // Subscribe to configuration change events
        DisplayConfig.SubscribeToEvents((_, _) => UpdateDisplay(true), (_, _) => UpdateAll(true));
        UIConfig.SubscribeToEvents((_, _) => UpdateFitterScalers());

        // Initialize camera FoV caching system
        CameraPatches.Initialize();
        CameraPatches.SubscribeToFovChanges();

        // Subscribe to Unity events
        SceneManager.sceneLoaded += OnSceneLoaded;
        ResolutionChangeHandler.OnResolutionChange += OnResolutionChanged;

        // Apply Harmony patches to modify game behavior
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    /// <summary>
    /// Called when a new scene is loaded. Updates all display and UI settings.
    /// </summary>
    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }

    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    private static bool RequiresUpdate { get; set; }

    /// <summary>
    /// Called when the screen resolution changes. Triggers a full system update.
    /// </summary>
    private static void OnResolutionChanged(Vector2 newRes)
    {
        UpdateAll(true);
    }

    /// <summary>
    /// Updates both display settings and UI fitters/scalers.
    /// </summary>
    /// <param name="force">If true, forces a resolution change even if settings haven't changed.</param>
    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
        UpdateFitterScalers();
    }

    /// <summary>
    /// Updates canvas scalers and aspect ratio fitters to match the current aspect ratio.
    /// </summary>
    private static void UpdateFitterScalers()
    {
        CanvasScalerPatches.UpdateScalers(ResolutionManager.CurrentAspect);
        UIComponentPatches.UpdateFitters();
    }

    /// <summary>
    /// Updates display settings including VSync, framerate, and resolution.
    /// </summary>
    /// <param name="force">If true, forces a resolution change even if settings haven't changed.</param>
    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync and framerate settings
        QualitySettings.vSyncCount = DisplayConfig.GetVSyncValue();
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? DisplayConfig.TargetFramerate.Value : -1;

        if (force)
        {
            RequiresUpdate = true;
        }

        // Update UI to match new aspect ratio
        CanvasScalerPatches.UpdateScalers(ResolutionManager.CurrentAspect);
        UIComponentPatches.UpdateFitters();

        if (!RequiresUpdate) return;

        // Apply resolution change
        Screen.SetResolution(ResolutionManager.SelectedResolution.width, ResolutionManager.SelectedResolution.height, DisplayConfig.FullScreenMode.Value, ResolutionManager.MaxRefreshRate);
        Log.LogInfo($"Resolution updated: {ResolutionManager.SelectedResolution.width}x{ResolutionManager.SelectedResolution.height}, Full Screen Mode={DisplayConfig.FullScreenMode.Value}, Refresh Rate={ResolutionManager.RefreshRate}Hz");

        // Refresh ConfigurationManager window if open to reflect new resolution
        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        RequiresUpdate = false;
    }
}