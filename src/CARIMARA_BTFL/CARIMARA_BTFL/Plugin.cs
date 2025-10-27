namespace CARIMARA_BTFL;

/// <summary>
/// Main BepInEx plugin class that coordinates ultra-wide monitor support for CARIMARA Beneath The Forlorn Limbs.
/// Manages resolution, UI scaling, and camera viewport settings.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.carimara.btfl.ultrawide";
    private const string PluginName = "CARIMARA Beneath The Forlorn Limbs Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>
    /// BepInEx logger for plugin diagnostics.
    /// </summary>
    internal static ManualLogSource Log { get; private set; }

    internal static ConfigFile ConfigFileInstance { get; private set; }

    /// <summary>
    /// Initializes the plugin, sets up configuration, subscribes to events, and applies Harmony patches.
    /// </summary>
    private void Awake()
    {
        ConfigFileInstance = Config;
        Log = Logger;

        // Initialize all configuration subsystems
        DisplayConfig.Initialize(Config);
        FixedDeltaTimeConfig.Initialize(Config);
        VolumeConfig.Initialize(Config);

        // Subscribe to configuration change events
        DisplayConfig.SubscribeToEvents((_, _) => UpdateDisplay(true), (_, _) => UpdateAll(true));
        FixedDeltaTimeConfig.SubscribeToEvents((_, _) => UpdateFixedDeltaTime());

        // Subscribe to Unity events
        SceneManager.sceneLoaded += OnSceneLoaded;
        ResolutionChangeHandler.OnResolutionChange += OnResolutionChanged;

        // Apply Harmony patches to modify game behavior
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateFixedDeltaTime()
    {
        FixedDeltaTimeConfig.OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
            var targetRefresh = Resolutions.ResolutionManager.RefreshRateValue;
            if (targetRefresh <= 0)
            {
                Log.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
                return;
            }

            if (Mathf.Approximately(targetRefresh, FixedDeltaTimeConfig.OriginalFixedDeltaTime.Value) || FixedDeltaTimeConfig.OriginalFixedDeltaTime.Value > targetRefresh)
            {
                Log.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
                return;
            }

            if (FixedDeltaTimeConfig.CorrectFixedUpdateRate.Value)
            {
                if (FixedDeltaTimeConfig.UseRefreshRateForFixedUpdateRate.Value)
                {
                    Time.fixedDeltaTime = 1f / targetRefresh;
                }
                else
                {
                    Time.fixedDeltaTime = 1f / Utils.Extensions.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
                }
            }
            else
            {
                Time.fixedDeltaTime = 1f / FixedDeltaTimeConfig.OriginalFixedDeltaTime.Value;
            }

            Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }


    /// <summary>
    /// Called when a new scene is loaded. Updates all display and UI settings.
    /// </summary>
    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }

    /// <summary>
    /// Gets the ConfigurationManager instance for accessing the in-game configuration window.
    /// Used to refresh the UI when resolution changes occur.
    /// </summary>
    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;

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
        Volumes.UpdateAntialiasing();
        Volumes.UpdateVolumes();
        UpdateFixedDeltaTime();
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

        // Update UI to match new aspect ratio
        CanvasScalerPatches.UpdateScalers(ResolutionManager.CurrentAspect);

        // Apply resolution change if forced (e.g., resolution/fullscreen mode changed)
        if (force)
        {
            Screen.SetResolution(ResolutionManager.SelectedResolution.width, ResolutionManager.SelectedResolution.height, DisplayConfig.FullScreenMode.Value, ResolutionManager.RefreshRate);
            Log.LogInfo($"Resolution updated: {ResolutionManager.SelectedResolution.width}x{ResolutionManager.SelectedResolution.height}, Full Screen Mode={DisplayConfig.FullScreenMode.Value}, Refresh Rate={ResolutionManager.RefreshRateValue}Hz");


            // Refresh ConfigurationManager window if open to reflect new resolution
            if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
            {
                ConfigurationManager.CloseWindow();
                ConfigurationManager.OpenWindow();
            }
        }
    }
}