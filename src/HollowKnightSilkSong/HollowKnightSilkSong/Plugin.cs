using JetBrains.Annotations;

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

    internal static ManualLogSource Log { get; private set; }

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
    public static ConfigEntry<EdgeFixQuality> EdgeQuality { get; private set; }

    internal const int TestWidth = 3200;
    internal const int TestHeight = 300;

#if DEBUG
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
#if DEBUG
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
#endif

        SetupConfigs(Config);
        ValidateAllSettings();
        SetupConfigBindings();

        // Subscribe to resolution changes
        ResChangeAction.OnResolutionChange += newRes =>
        {
            Patches.UpdateConfigCache();
            
            if (HudOffset.Value == 0f) return;
            
            HudOffset.Value = 0f;
            Log.LogInfo($"Reset HUD Offset to 0 due to resolution change to {newRes.x}x{newRes.y}");
          
            Patches.UpdateHudOffset();
        };

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Patches.UpdateConfigCache(); // Initialize cache

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void ValidateAllSettings()
    {
        Log.LogInfo("Validating settings loaded from config file...");

        // Round values to their proper increments
        CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * 10f) / 10f;
        VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * 20f) / 20f;
        HudOffset.Value = (float)Math.Round(HudOffset.Value * 2f) / 2f;

        // Validate ranges
        if (CameraFieldOfView.Value is < -5f or > 25f)
        {
            Log.LogWarning($"FOV value {CameraFieldOfView.Value} out of range, resetting to 0");
            CameraFieldOfView.Value = 0f;
        }

        if (HudOffset.Value is < -50f or > 50f)
        {
            Log.LogWarning($"HUD Offset value {HudOffset.Value} out of range, resetting to 0");
            HudOffset.Value = 0f;
        }

        if (VignetteAlpha.Value is < 0f or > 1f)
        {
            Log.LogWarning($"Vignette Alpha value {VignetteAlpha.Value} out of range, resetting to 1");
            VignetteAlpha.Value = 1f;
        }

        // Validate dependent settings
        if (!HeroLight.Value && ReduceHeroLight.Value)
        {
            ReduceHeroLight.Value = false;
            Log.LogInfo("Disabled 'Reduce Hero Light' since 'Hero Light' is disabled");
        }

        // Log edge fix status
        LogEdgeStatus();

        Log.LogInfo($"Settings validated: FOV={CameraFieldOfView.Value:F1}, Aspect={CurrentAspect:F3}, " +
                    $"EdgeQuality={EdgeQuality.Value}");
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

        CameraFieldOfView = config.Bind("02. Camera", "Field of View", 0f,
            new ConfigDescription("Adjust the camera's field of view in degrees.",
                new AcceptableValueRange<float>(-5f, 25f),
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

        VignetteAlpha = config.Bind("04. Screen", "Vignette Alpha", 1f,
            new ConfigDescription("Adjust the vignette alpha to your liking.",
                new AcceptableValueRange<float>(0f, 1f),
                new ConfigurationManagerAttributes { Order = 83 }));

        SplashScreens = config.Bind("05. Misc", "Splash Screens", true,
            new ConfigDescription("Control splash screen appearance prior to main-menu.",
                null, new ConfigurationManagerAttributes { Order = 86 }));

        MenuClutter = config.Bind("05. Misc", "Menu Clutter", true,
            new ConfigDescription("Control menu clutter on the main menu i.e. logos, version numbers, credits etc",
                null, new ConfigurationManagerAttributes { Order = 85 }));

        HudOffset = config.Bind("06. HUD", "HUD Offset", 0f,
            new ConfigDescription("Adjust the HUD offset to your liking.",
                new AcceptableValueRange<float>(-50f, 50f),
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
            var mrs = Resources.FindObjectsOfTypeAll<MenuResolutionSetting>().ToList();
            foreach (var setting in mrs)
            {
                setting.RefreshAvailableResolutions();
            }
        };

        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * 10f) / 10f;
            LogEdgeStatus(); // Log when threshold changes
            Patches.UpdateConfigCache();
        };

        HeroLight.SettingChanged += (_, _) => Patches.UpdateConfigCache();
        ReduceHeroLight.SettingChanged += (_, _) => Patches.UpdateConfigCache();

        Vignette.SettingChanged += (_, _) => Patches.UpdateConfigCache();
        VignetteAlpha.SettingChanged += (_, _) =>
        {
            VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * 20f) / 20f;
            Patches.UpdateConfigCache();
        };

        MenuClutter.SettingChanged += (_, _) => UpdateMenuClutter();

        HudOffset.SettingChanged += (_, _) =>
        {
            HudOffset.Value = (float)Math.Round(HudOffset.Value * 2f) / 2f;
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
#if DEBUG
        SceneManager.sceneLoaded -= SceneManagerOnSceneLoaded;
#endif
        Patches.Cleanup();
    }

#if DEBUG
    private static void SceneManagerOnSceneLoaded(Scene name, LoadSceneMode mode)
    {
        Screen.SetResolution(TestWidth, TestHeight, FullScreenMode.Windowed, 0);
    }
#endif

    private static void UpdateMenuClutter()
    {
        var logoLanguages = Resources.FindObjectsOfTypeAll<LogoLanguage>().ToList();
        foreach (var logo in logoLanguages)
        {
            logo.OnEnable();
        }

        var versionNumbers = Resources.FindObjectsOfTypeAll<SetVersionNumber>().ToList();
        foreach (var version in versionNumbers)
        {
            version.Start();
        }

        var mainMenu = Resources.FindObjectsOfTypeAll<MenuButtonList>().ToList();
        foreach (var menu in mainMenu)
        {
            menu.SetupActive();
        }
    }
}