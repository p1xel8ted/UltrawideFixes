using Il2CppInterop.Runtime.Injection;
using KatsTrigger.MonoBehaviours;
using KatsTrigger.Utils;

namespace KatsTrigger;

/// <summary>
/// Main plugin class for Kats Trigger Ultra-Wide support.
/// Provides ultrawide monitor compatibility by intercepting and adjusting resolution,
/// aspect ratio, and UI scaling settings.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.katstrigger.ultrawide";
    private const string PluginName = "Kats Trigger Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>
    /// The baseline aspect ratio (16:9) used to determine when ultrawide adjustments are needed.
    /// UI scaling switches to Expand mode when the current aspect ratio exceeds this value.
    /// </summary>
    internal const float NativeAspectRatio = 16f / 9f;

    /// <summary>
    /// The scene name that requires special FPS handling due to animation timing issues.
    /// </summary>
    private const string SpecialFPSScene = "JKScene_CH0_1";

    /// <summary>
    /// Cached flag indicating if the current scene requires special FPS handling.
    /// Updated on scene load to avoid repeated string comparisons in hot paths.
    /// </summary>
    internal static bool IsSpecialFPSScene { get; private set; }

    #region Resolution Caching

    /// <summary>
    /// Cached parsed resolution to avoid repeated string parsing on every property access.
    /// </summary>
    private static Resolution _cachedResolution;

    /// <summary>
    /// Flag indicating whether the cached resolution is valid.
    /// Set to false when the resolution config changes to trigger reparsing.
    /// </summary>
    private static bool _resolutionCacheValid;

    /// <summary>
    /// Invalidates the resolution cache, forcing a reparse on next access.
    /// Called when the user changes the resolution setting.
    /// </summary>
    private static void InvalidateResolutionCache() => _resolutionCacheValid = false;

    /// <summary>
    /// Gets the currently selected resolution with caching.
    /// Parses the resolution string only when the cache is invalid.
    /// </summary>
    private static Resolution SelectedResolution
    {
        get
        {
            if (_resolutionCacheValid) return _cachedResolution;

            _cachedResolution = ParseResolution();
            _resolutionCacheValid = true;
            return _cachedResolution;
        }
    }

    /// <summary>
    /// Parses the resolution string from the config entry into a Resolution struct.
    /// Expected format: "WIDTHxHEIGHT" (e.g., "3440x1440").
    /// Falls back to native display resolution on parse failure.
    /// </summary>
    /// <returns>The parsed resolution, or native resolution if parsing fails.</returns>
    private static Resolution ParseResolution()
    {
        // Defensive check for early access before Load() completes
        if (Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

        try
        {
            var res = Resolution.Value.Split('x');
            if (res.Length != 2)
            {
                Logger?.LogWarning($"Invalid resolution format: {Resolution.Value}. Using native resolution.");
                return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
            }

            if (!int.TryParse(res[0], out var width) || !int.TryParse(res[1], out var height) || width <= 0 || height <= 0)
            {
                Logger?.LogWarning($"Invalid resolution values: {Resolution.Value}. Using native resolution.");
                return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
            }

            return new Resolution { width = width, height = height };
        }
        catch (Exception ex)
        {
            Logger?.LogError($"Error parsing resolution {Resolution.Value}: {ex.Message}. Using native resolution.");
            return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
        }
    }

    #endregion

    #region Display Properties

    /// <summary>
    /// The native width of the primary display, captured at plugin initialization.
    /// </summary>
    private static readonly int NativeDisplayWidth = Display.main.systemWidth;

    /// <summary>
    /// The native height of the primary display, captured at plugin initialization.
    /// </summary>
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;

    /// <summary>
    /// Gets the maximum refresh rate supported by the display.
    /// Used to set optimal refresh rate when applying resolution changes.
    /// </summary>
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    /// <summary>
    /// Gets the width of the currently selected resolution.
    /// </summary>
    internal static int MainWidth => SelectedResolution.width;

    /// <summary>
    /// Gets the height of the currently selected resolution.
    /// </summary>
    internal static int MainHeight => SelectedResolution.height;

    /// <summary>
    /// Gets the aspect ratio of the currently selected resolution.
    /// Used to determine UI scaling mode and camera adjustments.
    /// </summary>
    internal static float MainAspect => MainWidth / (float)MainHeight;

    /// <summary>
    /// Creates a RefreshRate struct for use with Unity's newer resolution APIs.
    /// Sets the refresh rate to the maximum supported value.
    /// </summary>
    public static RefreshRate RefreshRateStruct => new()
    {
        denominator = 1,
        numerator = (uint)MaxRefresh,
    };

    #endregion

    #region Configuration

    /// <summary>
    /// Maps user-friendly VSync option names to Unity's vSyncCount values.
    /// 0 = disabled, 1 = every refresh, 2 = every 2nd refresh.
    /// </summary>
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    /// <summary>
    /// BepInEx logger instance for outputting plugin messages.
    /// </summary>
    internal static ManualLogSource Logger { get; private set; }

    /// <summary>
    /// Configuration entry for the fullscreen mode.
    /// Public to allow access from Harmony patches.
    /// </summary>
    public static ConfigEntry<FullScreenMode> FullScreenMode { get; private set; }

    /// <summary>
    /// Configuration entry for the resolution (stored as "WIDTHxHEIGHT" string).
    /// </summary>
    private static ConfigEntry<string> Resolution { get; set; }

    /// <summary>
    /// Configuration entry for the VSync setting.
    /// </summary>
    private static ConfigEntry<string> VSyncSetting { get; set; }

    /// <summary>
    /// Configuration entry for the target framerate when VSync is disabled.
    /// </summary>
    private static ConfigEntry<int> TargetFramerate { get; set; }

    /// <summary>
    /// Converts the user-friendly VSync setting to Unity's vSyncCount value.
    /// Defaults to 1 (enabled) if the setting is not found.
    /// </summary>
    private static int GetVSyncValue() => VSyncOptions.GetValueOrDefault(VSyncSetting.Value, 1);

    #endregion

    #region Update Methods

    /// <summary>
    /// Applies all display settings. Called on scene load and during initial plugin load.
    /// </summary>
    private static void UpdateAll()
    {
        UpdateResolution();
        UpdateScreenMode();
        UpdateCanvasScalers(MainAspect);
        ApplySceneFPSOverride();
    }

    /// <summary>
    /// Iterates through all tracked canvas scalers and updates their scaling mode.
    /// Filters out destroyed scalers (Unity objects that have been garbage collected).
    /// </summary>
    /// <param name="aspect">The current aspect ratio to use for scaling decisions.</param>
    private static void UpdateCanvasScalers(float aspect)
    {
        // Filter with Unity's implicit bool operator to skip destroyed objects
        foreach (var scaler in Patches.Patches.Scalers.Where(scaler => scaler))
        {
            Patches.Patches.ProcessScaler(scaler, aspect);
        }
    }

    /// <summary>
    /// Applies the selected fullscreen mode to Unity's Screen settings.
    /// Only applies changes if the current mode differs from the target.
    /// </summary>
    private static void UpdateScreenMode()
    {
        if (Screen.fullScreenMode == FullScreenMode.Value) return;

        Screen.fullScreenMode = FullScreenMode.Value;
        Logger.LogInfo($"Screen mode updated to {FullScreenMode.Value}");
    }

    /// <summary>
    /// Applies VSync and target framerate settings.
    /// When VSync is enabled (vSyncCount > 0), targetFrameRate is set to -1 (unlimited/VSync-controlled).
    /// When VSync is disabled, targetFrameRate is set to the user's configured value.
    /// Only applies changes if the current settings differ from the target.
    /// </summary>
    internal static void UpdateFramerateSettings()
    {
        var targetVSync = GetVSyncValue();
        var targetFramerate = targetVSync == 0 ? TargetFramerate.Value : -1;

        // Check if any changes are needed
        if (QualitySettings.vSyncCount == targetVSync && Application.targetFrameRate == targetFramerate) return;

        QualitySettings.vSyncCount = targetVSync;
        Application.targetFrameRate = targetFramerate;
        Logger.LogInfo($"Framerate settings updated - VSync: {VSyncSetting.Value} ({targetVSync}), Target: {TargetFramerate.Value}");
    }

    /// <summary>
    /// Applies the selected resolution to Unity's Screen settings.
    /// Only applies changes if the current resolution differs from the target.
    /// </summary>
    private static void UpdateResolution()
    {
        // Check if resolution change is needed
        if (Screen.width == MainWidth && Screen.height == MainHeight) return;

        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.Value, MaxRefresh);
        Logger.LogInfo($"Resolution updated to {SelectedResolution.width}x{SelectedResolution.height}");
    }

    #endregion

    #region Resolution List Generation

    /// <summary>
    /// Builds the list of available resolutions for the configuration dropdown.
    /// Includes the native display resolution and all Unity-reported resolutions.
    /// In DEBUG builds, additional test resolutions are added for ultrawide testing.
    /// </summary>
    /// <returns>Array of resolution strings in "WIDTHxHEIGHT" format.</returns>
    private static string[] GetResolutions()
    {
        // Always include native resolution first
        var mainRes = new Resolution
        {
            width = NativeDisplayWidth,
            height = NativeDisplayHeight,
            refreshRateRatio = RefreshRateStruct
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);

#if DEBUG
        // Add test resolutions for various ultrawide aspect ratios during development

        // 16:10 (1.6:1) - Common widescreen format
        var height = 1200;
        var width = Mathf.RoundToInt(height * 1.6f);
        var res1 = new Resolution { width = width, height = height };

        // 32:9 (3.56:1) - Super ultrawide (Samsung Odyssey G9, etc.)
        height = 900;
        width = Mathf.RoundToInt(height * 3.555555555555556f);
        var res2 = new Resolution { width = width, height = height };

        // 48:9 (5.33:1) - Triple monitor simulation
        height = 600;
        width = Mathf.RoundToInt(height * 5.333333333333333f);
        var res3 = new Resolution { width = width, height = height };

        // 24:10 (2.4:1) - Dual 16:10 simulation
        height = 800;
        width = Mathf.RoundToInt(height * 2.4f);
        var res4 = new Resolution { width = width, height = height };

        // 32:10 (3.2:1) - Dual 16:10 wide simulation
        height = 1000;
        width = Mathf.RoundToInt(height * 3.2f);
        var res5 = new Resolution { width = width, height = height };

        resList.Add(res1);
        resList.Add(res2);
        resList.Add(res3);
        resList.Add(res4);
        resList.Add(res5);
#endif

        // Sort by total pixel count (ascending) and remove duplicates
        resList.SortByPixelCount();
        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    #endregion

    #region Plugin Lifecycle

    /// <summary>
    /// BepInEx plugin entry point. Initializes configuration, registers event handlers,
    /// and applies Harmony patches.
    /// </summary>
    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<FramerateRestorer>();
        Logger = Log;

        // Resolution config with dropdown of available resolutions
        Resolution = Config.Bind("01. Display", "Resolution", $"{Display.main.systemWidth}x{Display.main.systemHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>
        {
            InvalidateResolutionCache();
            UpdateResolution();
        };

        // Fullscreen mode config
        FullScreenMode = Config.Bind("01. Display", "Full Screen Mode", UnityEngine.FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenMode.SettingChanged += (_, _) => UpdateScreenMode();

        // Target framerate config (only effective when VSync is disabled)
        // Sort framerates from highest to lowest for better UX
        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(Screen.resolutions.Select(a => Mathf.RoundToInt((float)a.refreshRateRatio.value)).Distinct().OrderByDescending(x => x).ToArray()),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateFramerateSettings();

        // VSync config with user-friendly options
        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game's frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateFramerateSettings();

        // Apply all settings immediately
        UpdateAll();

        // Register scene event handlers
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        SceneManager.sceneUnloaded += (UnityAction<Scene>)OnSceneUnloaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");

        // Apply all Harmony patches from this assembly
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    /// <summary>
    /// Called when a new scene is loaded. Reapplies all display settings
    /// since some games reset these values on scene transitions.
    /// </summary>
    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Cache the special scene flag to avoid string comparisons in hot paths
        IsSpecialFPSScene = scene.name == SpecialFPSScene;
        Logger.LogInfo($"Scene '{scene.name}' loaded.");
        UpdateAll();
    }

    /// <summary>
    /// Applies scene-specific FPS overrides. Some scenes have animation timing issues
    /// at high framerates and require a temporary 60 FPS lock.
    /// </summary>
    private static void ApplySceneFPSOverride()
    {
        if (IsSpecialFPSScene)
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;
            Logger.LogInfo($"Applied special framerate limit of 60 FPS for {SpecialFPSScene}.");
        }
        else
        {
            UpdateFramerateSettings();
        }
    }

    /// <summary>
    /// Called when a scene is unloaded. Clears the canvas scaler cache
    /// to prevent memory leaks from holding references to destroyed objects.
    /// </summary>
    private static void OnSceneUnloaded(Scene scene)
    {
        Logger.LogInfo($"Scene '{scene.name}' unloaded. Clearing scaler cache.");
        Patches.Patches.ClearScalerCache();
    }

    #endregion
}
