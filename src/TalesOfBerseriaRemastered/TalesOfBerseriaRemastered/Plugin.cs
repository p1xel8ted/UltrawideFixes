namespace TalesOfBerseriaRemastered;

/// <summary>
/// BepInEx 6 IL2CPP plugin entry point for Tales of Berseria Remastered ultrawide support.
///
/// This game uses a single Unity scene ("SampleScene") for everything — the native rendering DLL
/// (TLSampleViewerTO12.dll) runs its own state machine (LOGO → SCAN → OPENING → TITLE → GAME)
/// entirely within that scene. SceneManager.sceneLoaded fires once at startup and cannot detect
/// native state transitions.
///
/// The plugin provides:
///   - Ultrawide aspect ratio correction (via native code cave in TLSampleViewerTO12.dll)
///   - UI scaling to prevent horizontal stretching
///   - Instant logo skip (zeroing native timing data)
///   - Framerate and VSync configuration with hot-reload
///   - Resolution enforcement to prevent the game from resetting to 16:9
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.talesofberseriaremastered.ultrawide";
    private const string PluginName = "Tales of Berseria Remastered Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>Monitor's native resolution width, used for resolution enforcement and aspect calculation.</summary>
    internal static readonly int MainWidth = Display.main.systemWidth;

    /// <summary>Monitor's native resolution height.</summary>
    internal static readonly int MainHeight = Display.main.systemHeight;

    /// <summary>
    /// The monitor's actual aspect ratio (e.g. 2.389 for 3440x1440).
    /// Used by native patches to set the perspective camera aspect and scale UI width.
    /// </summary>
    internal static readonly float CurrentAspect = MainWidth / (float)MainHeight;

    /// <summary>
    /// Maximum monitor refresh rate, detected safely at runtime with fallbacks.
    /// Initialized in Load() via GetSafeMaxRefreshRate() rather than as a static initializer
    /// because Screen.resolutions can fail early in IL2CPP startup.
    /// </summary>
    private static int MaxRefresh { get; set; }

    internal static ManualLogSource Logger;
    internal static ConfigEntry<int> TargetFramerate;
    internal static ConfigEntry<KeyCode> ReloadConfigKey;
    internal new static ConfigFile Config;

    /// <summary>
    /// Maps user-friendly VSync setting names to QualitySettings.vSyncCount values.
    /// Presented as a dropdown in BepInEx ConfigurationManager.
    /// </summary>
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    private static ConfigEntry<string> VSyncSetting { get; set; }

    /// <summary>
    /// BepInEx 6 IL2CPP plugin entry point. Sets up configuration, registers the
    /// config-reload MonoBehaviour, applies Harmony patches, and hooks scene loading.
    /// </summary>
    public override void Load()
    {
        Logger = Log;
        Config = base.Config;

        // Detect refresh rate safely — Screen.resolutions can be empty/null early in IL2CPP startup
        MaxRefresh = GetSafeMaxRefreshRate();

        ReloadConfigKey = Config.Bind("02. Keybinds", "Reload Config", KeyCode.F5,
            new ConfigDescription(
                "Press this key in-game to reload the config file and apply changes immediately."
            ));

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(Extensions.MergeUnityRefreshRates())
            ));

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game's frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray())
            ));

        // Register and create the config-reload MonoBehaviour.
        // ClassInjector.RegisterTypeInIl2Cpp is required for IL2CPP — without it, AddComponent fails.
        // HideAndDontSave + DontDestroyOnLoad ensures it persists across the game's lifetime.
        ClassInjector.RegisterTypeInIl2Cpp<ConfigReloader>();
        var go = new GameObject
        {
            name = "TalesOfBerseriaRemastered_ConfigReloader",
            hideFlags = HideFlags.HideAndDontSave
        };
        UnityEngine.Object.DontDestroyOnLoad(go);
        go.AddComponent<ConfigReloader>();

        Logger.LogInfo($"Plugin loaded! Resolution={MainWidth}x{MainHeight}, Aspect={CurrentAspect:F2}");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        // Note: This game uses a single scene ("SampleScene") for everything.
        // The native state machine (LOGO/SCAN/OPENING/TITLE/GAME) runs entirely within it.
        // sceneLoaded fires once at startup — it cannot detect native state transitions.
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneLoaded;
    }

    /// <summary>Returns the QualitySettings.vSyncCount value for the user's selected VSync option.</summary>
    internal static int GetVSyncValue() => VSyncOptions.GetValueOrDefault(VSyncSetting.Value, 1);

    /// <summary>
    /// Applies all display settings. Called on scene load and on config reload (F5 keybind).
    /// Sets VSync and framerate cap based on current config values.
    /// </summary>
    internal static void ApplySettings()
    {
        QualitySettings.vSyncCount = GetVSyncValue();
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;

        Logger.LogInfo(
            $"Settings applied - VSync={GetVSyncValue()}, FPS={Application.targetFrameRate}");
    }

    /// <summary>
    /// Called when a Unity scene loads. In this game, only "SampleScene" ever loads (once at startup).
    /// Re-applies settings to ensure they're active after the scene initializes.
    /// </summary>
    private static void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Logger.LogInfo($"Scene loaded: {scene.name}");
        ApplySettings();
    }

    /// <summary>
    /// Safely detects the monitor's maximum refresh rate with a cascade of fallbacks:
    ///   1. Screen.resolutions — enumerate all supported resolutions and take the highest refresh rate
    ///   2. Screen.currentResolution — use the current display mode's refresh rate
    ///   3. Hardcoded 60Hz — conservative fallback if all else fails
    ///
    /// This is necessary because Screen.resolutions can return null/empty early in IL2CPP startup,
    /// and accessing it can throw in some Unity versions.
    /// </summary>
    private static int GetSafeMaxRefreshRate()
    {
        try
        {
            var resolutions = Screen.resolutions;
            if (resolutions is { Length: > 0 })
            {
                return resolutions
                    .Select(r => Mathf.RoundToInt((float)r.refreshRateRatio.value))
                    .Where(r => r > 0)
                    .DefaultIfEmpty(60)
                    .Max();
            }
        }
        catch (Exception ex)
        {
            Logger?.LogWarning($"Failed to read Screen.resolutions, using fallback refresh rate: {ex.Message}");
        }

        var currentRefresh = Mathf.RoundToInt((float)Screen.currentResolution.refreshRateRatio.value);
        if (currentRefresh > 0)
        {
            Logger?.LogWarning($"Screen.resolutions unavailable/empty, using current resolution refresh: {currentRefresh}Hz");
            return currentRefresh;
        }

        Logger?.LogWarning("Screen resolution refresh unavailable, using conservative fallback: 60Hz");
        return 60;
    }
}
