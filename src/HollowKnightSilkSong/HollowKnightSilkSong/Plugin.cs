// Main namespace for the Hollow Knight Silksong Ultra-Wide mod

namespace HollowKnightSilkSong;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    // Plugin metadata constants used for BepInEx registration
    private const string PluginGuid = "p1xel8ted.silksonghollowknight.ultrawide"; // Unique identifier for the plugin
    private const string PluginName = "Hollow Knight Silksong Ultra-Wide"; // Display name for the plugin
    private const string PluginVersion = "0.1.6"; // Current version of the plugin
    public const float NativeAspect = 16f / 9f; // Native aspect ratio for the game (16:9)

    // Constants for edge threshold calculation (used to determine when to fix black edges)
    // private const float BaseThreshold = 3.556f; // Base aspect threshold before edge fix is needed
    // private const float FOVFactor = 0.0711f; // How much FOV affects the edge threshold

    private const float MinThresholdBuffer = 0f;
    private const float MaxThresholdBuffer = 1f;

    // Multipliers for rounding config values to user-friendly increments
    private const float FOVRoundingMultiplier = 40f; // Rounds FOV to nearest 0.025
    private const float VignetteRoundingMultiplier = 40f; // Rounds vignette alpha to nearest 0.025
    private const float HudOffsetRoundingMultiplier = 40f; // Rounds HUD offset to nearest 0.025

    // Value ranges for configuration options
    private const float MinFOV = -5f; // Minimum allowed FOV adjustment
    private const float MaxFOV = 25f; // Maximum allowed FOV adjustment
    private const float DefaultFOV = 0f; // Default FOV adjustment

    private const float MinHudOffset = -50f; // Minimum HUD offset
    private const float MaxHudOffset = 50f; // Maximum HUD offset
    private const float DefaultHudOffset = 0f; // Default HUD offset

    private const float MinVignetteAlpha = 0f; // Minimum vignette alpha
    private const float MaxVignetteAlpha = 1f; // Maximum vignette alpha
    private const float DefaultVignetteAlpha = 1f; // Default vignette alpha


    // Logger for plugin messages
    internal static ManualLogSource Log { get; private set; }

    // Cache for UI elements to avoid repeated expensive lookups
    private static readonly Dictionary<Type, Array> CachedUIElements = new();
    private static bool _uiCacheValid;

    // Configuration entries exposed to the user via BepInEx config
    public static ConfigEntry<float> CameraFieldOfView { get; private set; } // Camera FOV adjustment
    public static ConfigEntry<bool> ReduceHeroLight { get; private set; } // Option to reduce hero light
    public static ConfigEntry<bool> HeroLight { get; private set; } // Option to enable/disable hero light
    public static ConfigEntry<bool> ShowMainResolutionOnly { get; private set; } // Show only native resolution in menu
    public static ConfigEntry<bool> SplashScreens { get; private set; } // Control splash screen appearance
    public static ConfigEntry<bool> Vignette { get; private set; } // Toggle vignette effect
    public static ConfigEntry<bool> MenuClutter { get; private set; } // Toggle menu clutter (logos, credits, etc)
    public static ConfigEntry<float> HudOffset { get; private set; } // HUD offset adjustment
    public static ConfigEntry<float> VignetteAlpha { get; private set; } // Vignette alpha adjustment
    private static ConfigEntry<EdgeFixQuality> EdgeQuality { get; set; } // Quality setting for edge fixes

    private static ConfigEntry<float> EdgeThresholdBuffer { get; set; } // Sensitivity buffer for edge detection

#if DEBUG
    // Debug-only test resolution for aspect calculations
    internal const int TestWidth = 3200;
    internal const int TestHeight = 600;
    public static float CurrentAspect => TestWidth / (float)TestHeight;
#else
    // Actual aspect ratio based on current screen resolution
    public static float CurrentAspect => Screen.width / (float)Screen.height;
#endif

    // Enum for edge fix quality settings
    public enum EdgeFixQuality
    {
        Off, // Never fix edges (original game behavior)
        [UsedImplicitly] Automatic, // Fix edges when needed, keep feathering
        High // Fix edges and remove feathering for cleaner visuals
    }

    private const float BaseThreshold = 4.7056f;
    private const float FOVFactor = 0.1192f;

    // SUBTRACT buffer to make threshold lower (edge scaling kicks in earlier)
    private static float EdgeThreshold => BaseThreshold - FOVFactor * CameraFieldOfView.Value - EdgeThresholdBuffer.Value;

    // Determines if black edges should be scaled based on aspect ratio and edge quality
    public static bool ShouldScaleBlackEdges
    {
        get
        {
            if (EdgeQuality.Value == EdgeFixQuality.Off) return false;

            // Edge scaling activates earlier to prevent any visible edges
            return CurrentAspect > EdgeThreshold;
        }
    }


    // // Calculates the current edge threshold based on FOV
    // private static float EdgeThreshold => BaseThreshold - FOVFactor * CameraFieldOfView.Value;
    //
    // // Determines if black edges should be scaled based on aspect ratio and edge quality
    // public static bool ShouldScaleBlackEdges
    // {
    //     get
    //     {
    //         if (EdgeQuality.Value == EdgeFixQuality.Off) return false; // No edge fix if set to Off
    //         return CurrentAspect > EdgeThreshold; // Only scale if aspect exceeds threshold
    //     }
    // }

    // Determines if feathering should be removed (for High quality edge fix)
    public static bool ShouldRemoveFeathering => EdgeQuality.Value == EdgeFixQuality.High && ShouldScaleBlackEdges;
    //public static float PositiveScaleFactor => CurrentAspect / NativeAspect;

    /// <summary>
    /// Called when the plugin is loaded. Sets up config, event handlers, and applies patches.
    /// </summary>
    private void Awake()
    {
        Log = Logger; // Initialize logger

#if DEBUG
        gameObject.AddComponent<TestResolutions>();
#endif
        // Listen for scene load events to invalidate UI cache
        SceneManager.sceneLoaded += OnSceneLoaded;

        // Set up configuration entries and validate their values
        SetupConfigs(Config);
        ValidateAllSettings();
        SetupConfigBindings();

        // Listen for resolution changes to reset HUD offset
        ResChangeAction.OnResolutionChange += OnResolutionChanged;

        // Apply Harmony patches for runtime modifications
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Patches.UpdateConfigCache(); // Initialize config cache for patches

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    /// <summary>
    /// Validates and clamps all config values to their allowed ranges, applies rounding, and logs status.
    /// </summary>
    private static void ValidateAllSettings()
    {
        Log.LogInfo("Validating settings loaded from config file...");

        // Round config values to user-friendly increments
        CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * FOVRoundingMultiplier) / FOVRoundingMultiplier;
        VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * VignetteRoundingMultiplier) / VignetteRoundingMultiplier;
        HudOffset.Value = (float)Math.Round(HudOffset.Value * HudOffsetRoundingMultiplier) / HudOffsetRoundingMultiplier;

        // Clamp FOV to allowed range
        if (CameraFieldOfView.Value is < MinFOV or > MaxFOV)
        {
            Log.LogWarning($"FOV value {CameraFieldOfView.Value} out of range, resetting to {DefaultFOV}");
            CameraFieldOfView.Value = DefaultFOV;
        }

        // Clamp HUD offset to allowed range
        if (HudOffset.Value is < MinHudOffset or > MaxHudOffset)
        {
            Log.LogWarning($"HUD Offset value {HudOffset.Value} out of range, resetting to {DefaultHudOffset}");
            HudOffset.Value = DefaultHudOffset;
        }

        // Clamp vignette alpha to allowed range
        if (VignetteAlpha.Value is < MinVignetteAlpha or > MaxVignetteAlpha)
        {
            Log.LogWarning($"Vignette Alpha value {VignetteAlpha.Value} out of range, resetting to {DefaultVignetteAlpha}");
            VignetteAlpha.Value = DefaultVignetteAlpha;
        }

        // Ensure ReduceHeroLight is only enabled if HeroLight is enabled
        if (!HeroLight.Value && ReduceHeroLight.Value)
        {
            ReduceHeroLight.Value = false;
            Log.LogInfo("Disabled 'Reduce Hero Light' since 'Hero Light' is disabled");
        }

        // Ensure HeroLight is enabled if ReduceHeroLight is enabled
        if (ReduceHeroLight.Value && !HeroLight.Value)
        {
            HeroLight.Value = true;
            Log.LogInfo("Enabled 'Hero Light' since 'Reduce Hero Light' is enabled");
        }

        if (EdgeThresholdBuffer.Value is < MinThresholdBuffer or > MaxThresholdBuffer)
        {
            Log.LogWarning($"Edge Detection Sensitivity value {EdgeThresholdBuffer.Value} out of range, resetting to 0.2");
            EdgeThresholdBuffer.Value = 0.2f;
        }

        // Log current edge fix status
        LogEdgeStatus();

        Log.LogInfo($"Settings validated: FOV={CameraFieldOfView.Value:F1}, Aspect={CurrentAspect:F3}, " +
                    $"EdgeQuality={EdgeQuality.Value}");
    }

    /// <summary>
    /// Called when a new scene is loaded. Invalidates the UI cache and resets FOV tracking so elements are refreshed.
    /// </summary>
    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        InvalidateUICache();

        // Reset FOV tracking so it gets reapplied when entering gameplay
        Patches.ResetFovTracking();

#if DEBUG
        Screen.SetResolution(TestWidth, TestHeight, FullScreenMode.Windowed, Screen.currentResolution.refreshRateRatio); // For testing purposes
#endif
    }

    /// <summary>
    /// Called when the screen resolution changes. Resets HUD offset and updates config cache.
    /// </summary>
    private static void OnResolutionChanged(Vector2 newRes)
    {
        Patches.UpdateConfigCache();

        // Only reset HUD offset if it was changed from default
        if (Mathf.Approximately(HudOffset.Value, DefaultHudOffset)) return;

        HudOffset.Value = DefaultHudOffset;
        Log.LogInfo($"Reset HUD Offset to 0 due to resolution change to {newRes.x}x{newRes.y}");

        Patches.UpdateHudOffset();
    }

    /// <summary>
    /// Returns cached UI elements of the specified type, or finds and caches them if not already cached.
    /// </summary>
    private static T[] GetCachedUIElements<T>() where T : UnityEngine.Object
    {
        var type = typeof(T);

        // If cache is invalid or missing, find all objects of type T and cache them
        if (!_uiCacheValid || !CachedUIElements.ContainsKey(type))
        {
            CachedUIElements[type] = Resources.FindObjectsOfTypeAll<T>();
        }

        return (T[])CachedUIElements[type];
    }

    /// <summary>
    /// Clears the UI element cache and marks it as invalid.
    /// </summary>
    private static void InvalidateUICache()
    {
        CachedUIElements.Clear();
        _uiCacheValid = false;
    }

    /// <summary>
    /// Logs the current status of edge fix settings for debugging and diagnostics.
    /// </summary>
    private static void LogEdgeStatus()
    {
        Log.LogInfo($"Edge Fix Status: Quality={EdgeQuality.Value}, " +
                    $"Threshold={EdgeThreshold:F3}, CurrentAspect={CurrentAspect:F3}, " +
                    $"ScalingActive={ShouldScaleBlackEdges}, RemoveFeather={ShouldRemoveFeathering}");
    }

    /// <summary>
    /// Sets up all configuration entries for the plugin, including descriptions and value ranges.
    /// </summary>
    private static void SetupConfigs(ConfigFile config)
    {
        // Only show native resolution in settings menu
        ShowMainResolutionOnly = config.Bind("01. Resolution", "Show Main Resolution Only", true,
            new ConfigDescription("Show only your display's native resolution in the settings menu.",
                null, new ConfigurationManagerAttributes { Order = 91 }));

        // Camera FOV adjustment
        CameraFieldOfView = config.Bind("02. Camera", "Field of View", DefaultFOV,
            new ConfigDescription("Adjust the camera's field of view in degrees.",
                new AcceptableValueRange<float>(MinFOV, MaxFOV),
                new ConfigurationManagerAttributes { Order = 90 }));

        // Toggle fake light around player character
        HeroLight = config.Bind("03. Hero", "Hero Light", true,
            new ConfigDescription("Toggle the fake light that surrounds the player character.",
                null, new ConfigurationManagerAttributes { Order = 89 }));

        // Option to reduce hero light instead of disabling
        ReduceHeroLight = config.Bind("03. Hero", "Reduce Hero Light", false,
            new ConfigDescription("Reduce the light instead of outright disabling.",
                null, new ConfigurationManagerAttributes { Order = 88 }));

        // Toggle vignette effect
        Vignette = config.Bind("04. Screen", "Vignette", true,
            new ConfigDescription("Toggle the vignette effect that darkens the edges of the screen.",
                null, new ConfigurationManagerAttributes { Order = 87 }));

        // Adjust vignette alpha
        VignetteAlpha = config.Bind("04. Screen", "Vignette Alpha", DefaultVignetteAlpha,
            new ConfigDescription("Adjust the vignette alpha to your liking.",
                new AcceptableValueRange<float>(MinVignetteAlpha, MaxVignetteAlpha),
                new ConfigurationManagerAttributes { Order = 83 }));

        // Control splash screen appearance before main menu
        SplashScreens = config.Bind("05. Misc", "Splash Screens", true,
            new ConfigDescription("Control splash screen appearance prior to main-menu.",
                null, new ConfigurationManagerAttributes { Order = 86 }));

        // Control menu clutter (logos, version numbers, credits, etc)
        MenuClutter = config.Bind("05. Misc", "Menu Clutter", true,
            new ConfigDescription("Control menu clutter on the main menu i.e. logos, version numbers, credits etc",
                null, new ConfigurationManagerAttributes { Order = 85 }));

        // Adjust HUD offset
        HudOffset = config.Bind("06. HUD", "HUD Offset", DefaultHudOffset,
            new ConfigDescription("Adjust the HUD offset to your liking.",
                new AcceptableValueRange<float>(MinHudOffset, MaxHudOffset),
                new ConfigurationManagerAttributes { Order = 84 }));

        // Edge fix quality setting
        EdgeQuality = config.Bind("07. Display", "Edge Fix Quality", EdgeFixQuality.High,
            new ConfigDescription("Automatically fixes black edges when they appear at wide aspects or high FOV.\n" +
                                  "Off: Original game behavior\n" +
                                  "Automatic: Fix edges when needed (may have feathered edges)\n" +
                                  "High: Fix edges and remove feathering for cleaner visuals",
                null,
                new ConfigurationManagerAttributes { Order = 80 }));

        EdgeThresholdBuffer = config.Bind("07. Display", "Edge Detection Sensitivity", 0.2f,
            new ConfigDescription("Lower values = edges must be more obvious before scaling. Higher values = scale preemptively.",
                new AcceptableValueRange<float>(MinThresholdBuffer, MaxThresholdBuffer),
                new ConfigurationManagerAttributes { Order = 79 }));
    }


    /// <summary>
    /// Sets up event handlers for config changes, ensuring values are rounded, clamped, and UI is updated as needed.
    /// </summary>
    private static void SetupConfigBindings()
    {
        // When resolution setting changes, refresh available resolutions in menu
        ShowMainResolutionOnly.SettingChanged += (_, _) =>
        {
            var mrs = GetCachedUIElements<MenuResolutionSetting>().ToList();
            foreach (var setting in mrs)
            {
                setting.RefreshAvailableResolutions();
            }
        };

        // When FOV changes, round value, log status, and update config cache
        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * FOVRoundingMultiplier) / FOVRoundingMultiplier;
            LogEdgeStatus();
            Patches.UpdateConfigCache();
        };

        // When HeroLight changes, ensure ReduceHeroLight is disabled if HeroLight is off
        HeroLight.SettingChanged += (_, _) =>
        {
            if (!HeroLight.Value && ReduceHeroLight.Value)
            {
                ReduceHeroLight.Value = false;
                Log.LogInfo("Disabled 'Reduce Hero Light' since 'Hero Light' was disabled");
            }

            Patches.UpdateConfigCache();
        };

        // When ReduceHeroLight changes, ensure HeroLight is enabled if ReduceHeroLight is enabled
        ReduceHeroLight.SettingChanged += (_, _) =>
        {
            if (ReduceHeroLight.Value && !HeroLight.Value)
            {
                HeroLight.Value = true;
                Log.LogInfo("Enabled 'Hero Light' since 'Reduce Hero Light' was enabled");
            }

            Patches.UpdateConfigCache();
        };

        // When vignette toggled, update config cache
        Vignette.SettingChanged += (_, _) => Patches.UpdateConfigCache();

        // When vignette alpha changes, round value and update config cache
        VignetteAlpha.SettingChanged += (_, _) =>
        {
            VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * VignetteRoundingMultiplier) / VignetteRoundingMultiplier;
            Patches.UpdateConfigCache();
        };

        // When menu clutter setting changes, update menu UI
        MenuClutter.SettingChanged += (_, _) => UpdateMenuClutter();

        // When HUD offset changes, round value, update config cache, and update HUD position
        HudOffset.SettingChanged += (_, _) =>
        {
            HudOffset.Value = (float)Math.Round(HudOffset.Value * HudOffsetRoundingMultiplier) / HudOffsetRoundingMultiplier;
            Patches.UpdateConfigCache();
            Patches.UpdateHudOffset();
        };

        // When edge quality changes, log status and update config cache
        EdgeQuality.SettingChanged += (_, _) =>
        {
            LogEdgeStatus();
            Patches.UpdateConfigCache();
        };
    }

    /// <summary>
    /// Called when the plugin is destroyed/unloaded. Cleans up event handlers and patches.
    /// </summary>
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        ResChangeAction.OnResolutionChange -= OnResolutionChanged;
        Patches.Cleanup();
    }

    /// <summary>
    /// Updates menu clutter elements (logos, version numbers, buttons) based on config setting.
    /// </summary>
    private static void UpdateMenuClutter()
    {
        // Enable/disable logo language elements
        var logoLanguages = GetCachedUIElements<LogoLanguage>().ToList();
        foreach (var logo in logoLanguages)
        {
            logo.OnEnable();
        }

        // Update version number display
        var versionNumbers = GetCachedUIElements<SetVersionNumber>().ToList();
        foreach (var version in versionNumbers)
        {
            version.Start();
        }

        // Update main menu button list
        var mainMenu = GetCachedUIElements<MenuButtonList>().ToList();
        foreach (var menu in mainMenu)
        {
            menu.SetupActive();
        }

        // Mark UI cache as valid after update
        _uiCacheValid = true;
    }
}