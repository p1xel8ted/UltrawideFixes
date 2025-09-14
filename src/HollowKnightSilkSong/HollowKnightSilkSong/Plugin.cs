namespace HollowKnightSilkSong;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.silksonghollowknight.ultrawide";
    private const string PluginName = "Hollow Knight Silksong Ultra-Wide";
    private const string PluginVersion = "0.1.3";
    public const float NativeAspect = 16f / 9f;

    // Edge threshold formula constants
    private const float BaseThreshold = 3.556f;
    private const float FOVFactor = 0.0711f;

    // Rounding precision multipliers
    private const float FOVRoundingMultiplier = 10f; // 0.1 precision
    private const float VignetteRoundingMultiplier = 20f; // 0.05 precision
    private const float HudOffsetRoundingMultiplier = 2f; // 0.5 precision

    // Configuration value ranges
    private const float MinFOV = -5f;
    private const float MaxFOV = 25f;
    private const float DefaultFOV = 0f;

    private const float MinHudOffset = -50f;
    private const float MaxHudOffset = 50f;
    private const float DefaultHudOffset = 0f;

    private const float MinVignetteAlpha = 0f;
    private const float MaxVignetteAlpha = 1f;
    private const float DefaultVignetteAlpha = 1f;

    internal static ManualLogSource Log { get; private set; }

    // UI element cache for performance
    private static readonly Dictionary<Type, Array> CachedUIElements = new();
    private static bool _uiCacheValid;

    // Config entries
    public static ConfigEntry<float> CameraFieldOfView { get; private set; }
    public static ConfigEntry<bool> ReduceHeroLight { get; private set; }
    public static ConfigEntry<bool> HeroLight { get; private set; }
    public static ConfigEntry<bool> ShowMainResolutionOnly { get; private set; }
    public static ConfigEntry<bool> SplashScreens { get; private set; }
    public static ConfigEntry<bool> Vignette { get; private set; }
    public static ConfigEntry<bool> MenuClutter { get; private set; }
    public static ConfigEntry<float> HudOffset { get; private set; }
    public static ConfigEntry<float> VignetteAlpha { get; private set; }
    private static ConfigEntry<EdgeFixQuality> EdgeQuality { get; set; }

#if DEBUG
    internal const int TestWidth = 3200;
    internal const int TestHeight = 300;
    public static float CurrentAspect => TestWidth / (float)TestHeight;
#else
    public static float CurrentAspect => Screen.width / (float)Screen.height;
#endif

    public enum EdgeFixQuality
    {
        Off, // Never fix edges (original game behavior)
        [UsedImplicitly] Automatic, // Fix edges when needed, keep feathering
        High // Fix edges and remove feathering for cleaner visuals
    }

    // Calculate edge threshold based on FOV
    private static float EdgeThreshold => BaseThreshold - (FOVFactor * CameraFieldOfView.Value);

    // Properties for patches to use
    public static bool ShouldScaleBlackEdges
    {
        get
        {
            if (EdgeQuality.Value == EdgeFixQuality.Off) return false;
            return CurrentAspect > EdgeThreshold;
        }
    }

    public static bool ShouldRemoveFeathering => EdgeQuality.Value == EdgeFixQuality.High && ShouldScaleBlackEdges;

    private void Awake()
    {
        Log = Logger;

        SceneManager.sceneLoaded += OnSceneLoaded;

        SetupConfigs(Config);
        ValidateAllSettings();
        SetupConfigBindings();

        // Subscribe to resolution changes
        ResChangeAction.OnResolutionChange += OnResolutionChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Patches.UpdateConfigCache(); // Initialize cache

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void ValidateAllSettings()
    {
        Log.LogInfo("Validating settings loaded from config file...");

        // Round values to their proper increments
        CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * FOVRoundingMultiplier) / FOVRoundingMultiplier;
        VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * VignetteRoundingMultiplier) / VignetteRoundingMultiplier;
        HudOffset.Value = (float)Math.Round(HudOffset.Value * HudOffsetRoundingMultiplier) / HudOffsetRoundingMultiplier;

        // Validate ranges
        if (CameraFieldOfView.Value is < MinFOV or > MaxFOV)
        {
            Log.LogWarning($"FOV value {CameraFieldOfView.Value} out of range, resetting to {DefaultFOV}");
            CameraFieldOfView.Value = DefaultFOV;
        }

        if (HudOffset.Value is < MinHudOffset or > MaxHudOffset)
        {
            Log.LogWarning($"HUD Offset value {HudOffset.Value} out of range, resetting to {DefaultHudOffset}");
            HudOffset.Value = DefaultHudOffset;
        }

        if (VignetteAlpha.Value is < MinVignetteAlpha or > MaxVignetteAlpha)
        {
            Log.LogWarning($"Vignette Alpha value {VignetteAlpha.Value} out of range, resetting to {DefaultVignetteAlpha}");
            VignetteAlpha.Value = DefaultVignetteAlpha;
        }

        // Validate dependent settings (bidirectional validation)
        if (!HeroLight.Value && ReduceHeroLight.Value)
        {
            ReduceHeroLight.Value = false;
            Log.LogInfo("Disabled 'Reduce Hero Light' since 'Hero Light' is disabled");
        }

        if (ReduceHeroLight.Value && !HeroLight.Value)
        {
            HeroLight.Value = true;
            Log.LogInfo("Enabled 'Hero Light' since 'Reduce Hero Light' is enabled");
        }

        // Log edge fix status
        LogEdgeStatus();

        Log.LogInfo($"Settings validated: FOV={CameraFieldOfView.Value:F1}, Aspect={CurrentAspect:F3}, " +
                    $"EdgeQuality={EdgeQuality.Value}");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        InvalidateUICache();
    }

    private static void OnResolutionChanged(Vector2 newRes)
    {
        Patches.UpdateConfigCache();

        if (Mathf.Approximately(HudOffset.Value, DefaultHudOffset)) return;

        HudOffset.Value = DefaultHudOffset;
        Log.LogInfo($"Reset HUD Offset to 0 due to resolution change to {newRes.x}x{newRes.y}");

        Patches.UpdateHudOffset();
    }

    private static T[] GetCachedUIElements<T>() where T : UnityEngine.Object
    {
        var type = typeof(T);

        if (!_uiCacheValid || !CachedUIElements.ContainsKey(type))
        {
            CachedUIElements[type] = Resources.FindObjectsOfTypeAll<T>();
        }

        return (T[])CachedUIElements[type];
    }

    private static void InvalidateUICache()
    {
        CachedUIElements.Clear();
        _uiCacheValid = false;
    }

    private static void LogEdgeStatus()
    {
        Log.LogInfo($"Edge Fix Status: Quality={EdgeQuality.Value}, " +
                    $"Threshold={EdgeThreshold:F3}, CurrentAspect={CurrentAspect:F3}, " +
                    $"ScalingActive={ShouldScaleBlackEdges}, RemoveFeather={ShouldRemoveFeathering}");
    }

    private static void SetupConfigs(ConfigFile config)
    {
        ShowMainResolutionOnly = config.Bind("01. Resolution", "Show Main Resolution Only", true,
            new ConfigDescription("Show only your displays native resolution in the settings menu.",
                null, new ConfigurationManagerAttributes { Order = 91 }));

        CameraFieldOfView = config.Bind("02. Camera", "Field of View", DefaultFOV,
            new ConfigDescription("Adjust the camera's field of view in degrees.",
                new AcceptableValueRange<float>(MinFOV, MaxFOV),
                new ConfigurationManagerAttributes { Order = 90 }));

        HeroLight = config.Bind("03. Hero", "Hero Light", true,
            new ConfigDescription("Toggle the fake light that surrounds the player character.",
                null, new ConfigurationManagerAttributes { Order = 89 }));

        ReduceHeroLight = config.Bind("03. Hero", "Reduce Hero Light", false,
            new ConfigDescription("Reduce the light instead of outright disabling.",
                null, new ConfigurationManagerAttributes { Order = 88 }));

        Vignette = config.Bind("04. Screen", "Vignette", true,
            new ConfigDescription("Toggle the vignette effect that darkens the edges of the screen.",
                null, new ConfigurationManagerAttributes { Order = 87 }));

        VignetteAlpha = config.Bind("04. Screen", "Vignette Alpha", DefaultVignetteAlpha,
            new ConfigDescription("Adjust the vignette alpha to your liking.",
                new AcceptableValueRange<float>(MinVignetteAlpha, MaxVignetteAlpha),
                new ConfigurationManagerAttributes { Order = 83 }));

        SplashScreens = config.Bind("05. Misc", "Splash Screens", true,
            new ConfigDescription("Control splash screen appearance prior to main-menu.",
                null, new ConfigurationManagerAttributes { Order = 86 }));

        MenuClutter = config.Bind("05. Misc", "Menu Clutter", true,
            new ConfigDescription("Control menu clutter on the main menu i.e. logos, version numbers, credits etc",
                null, new ConfigurationManagerAttributes { Order = 85 }));

        HudOffset = config.Bind("06. HUD", "HUD Offset", DefaultHudOffset,
            new ConfigDescription("Adjust the HUD offset to your liking.",
                new AcceptableValueRange<float>(MinHudOffset, MaxHudOffset),
                new ConfigurationManagerAttributes { Order = 84 }));

        EdgeQuality = config.Bind("07. Display", "Edge Fix Quality", EdgeFixQuality.High,
            new ConfigDescription("Automatically fixes black edges when they appear at wide aspects or high FOV.\n" +
                                  "Off: Original game behavior\n" +
                                  "Automatic: Fix edges when needed (may have feathered edges)\n" +
                                  "High: Fix edges and remove feathering for cleaner visuals",
                null,
                new ConfigurationManagerAttributes { Order = 80 }));
    }

    private static void SetupConfigBindings()
    {
        ShowMainResolutionOnly.SettingChanged += (_, _) =>
        {
            var mrs = GetCachedUIElements<MenuResolutionSetting>().ToList();
            foreach (var setting in mrs)
            {
                setting.RefreshAvailableResolutions();
            }
        };

        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * FOVRoundingMultiplier) / FOVRoundingMultiplier;
            LogEdgeStatus(); // Log when threshold changes
            Patches.UpdateConfigCache();
        };

        HeroLight.SettingChanged += (_, _) =>
        {
            // Validate dependent setting - disable ReduceHeroLight if HeroLight is disabled
            if (!HeroLight.Value && ReduceHeroLight.Value)
            {
                ReduceHeroLight.Value = false;
                Log.LogInfo("Disabled 'Reduce Hero Light' since 'Hero Light' was disabled");
            }
            Patches.UpdateConfigCache();
        };

        ReduceHeroLight.SettingChanged += (_, _) =>
        {
            // Validate dependent setting - enable HeroLight if ReduceHeroLight is enabled
            if (ReduceHeroLight.Value && !HeroLight.Value)
            {
                HeroLight.Value = true;
                Log.LogInfo("Enabled 'Hero Light' since 'Reduce Hero Light' was enabled");
            }
            Patches.UpdateConfigCache();
        };

        Vignette.SettingChanged += (_, _) => Patches.UpdateConfigCache();
        VignetteAlpha.SettingChanged += (_, _) =>
        {
            VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * VignetteRoundingMultiplier) / VignetteRoundingMultiplier;
            Patches.UpdateConfigCache();
        };

        MenuClutter.SettingChanged += (_, _) => UpdateMenuClutter();

        HudOffset.SettingChanged += (_, _) =>
        {
            HudOffset.Value = (float)Math.Round(HudOffset.Value * HudOffsetRoundingMultiplier) / HudOffsetRoundingMultiplier;
            Patches.UpdateConfigCache();
            Patches.UpdateHudOffset();
        };

        EdgeQuality.SettingChanged += (_, _) =>
        {
            LogEdgeStatus();
            Patches.UpdateConfigCache();
        };
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;

        // Unsubscribe from resolution changes
        ResChangeAction.OnResolutionChange -= OnResolutionChanged;

        Patches.Cleanup();
    }

    private static void UpdateMenuClutter()
    {
        var logoLanguages = GetCachedUIElements<LogoLanguage>().ToList();
        foreach (var logo in logoLanguages)
        {
            logo.OnEnable();
        }

        var versionNumbers = GetCachedUIElements<SetVersionNumber>().ToList();
        foreach (var version in versionNumbers)
        {
            version.Start();
        }

        var mainMenu = GetCachedUIElements<MenuButtonList>().ToList();
        foreach (var menu in mainMenu)
        {
            menu.SetupActive();
        }

        // Mark cache as valid after first use
        _uiCacheValid = true;
    }
}