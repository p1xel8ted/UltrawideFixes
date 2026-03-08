namespace HollowKnight;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.hollowknight.ultrawide";
    private const string PluginName = "Hollow Knight Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    public const float NativeAspect = 16f / 9f;

    private const float FOVRoundingMultiplier = 40f;
    private const float HudOffsetRoundingMultiplier = 40f;

    private const float MinFOV = 0.75f;
    private const float MaxFOV = 3f;
    private const float DefaultFOV = 1f;

    private const float MinHudOffset = -50f;
    private const float MaxHudOffset = 50f;
    private const float DefaultHudOffset = 0f;

    internal static ManualLogSource Log { get; private set; }

    public static ConfigEntry<float> CameraFieldOfView { get; private set; }
    public static ConfigEntry<bool> ReduceHeroLight { get; private set; }
    public static ConfigEntry<bool> HeroLight { get; private set; }
    public static ConfigEntry<bool> ShowMainResolutionOnly { get; private set; }
    public static ConfigEntry<bool> SplashScreens { get; private set; }
    public static ConfigEntry<bool> MenuClutter { get; private set; }
    public static ConfigEntry<float> HudOffset { get; private set; }

#if DEBUG
    internal const int TestWidth = 3200;
    internal const int TestHeight = 600;
    public static float CurrentAspect => TestWidth / (float)TestHeight;
#else
    public static float CurrentAspect => Screen.width / (float)Screen.height;
#endif

    private void Awake()
    {
        Log = Logger;

        UnityEngine.SceneManagement.SceneManager.sceneLoaded += OnSceneLoaded;

        SetupConfigs(Config);
        ValidateAllSettings();
        SetupConfigBindings();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Patches.UpdateConfigCache();

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void ValidateAllSettings()
    {
        Log.LogInfo("Validating settings loaded from config file...");

        CameraFieldOfView.Value = Mathf.Round(CameraFieldOfView.Value * FOVRoundingMultiplier) / FOVRoundingMultiplier;
        HudOffset.Value = (float)Math.Round(HudOffset.Value * HudOffsetRoundingMultiplier) / HudOffsetRoundingMultiplier;

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

        Log.LogInfo($"Settings validated: FOV={CameraFieldOfView.Value:F2}, Aspect={CurrentAspect:F3}");
    }

    private static void SetupConfigs(ConfigFile config)
    {
        ShowMainResolutionOnly = config.Bind("01. Resolution", "Show Main Resolution Only", true,
            new ConfigDescription("Show only your display's native resolution in the settings menu.",
                null, new ConfigurationManagerAttributes { Order = 91 }));

        CameraFieldOfView = config.Bind("02. Camera", "Field of View", DefaultFOV,
            new ConfigDescription("Adjust the camera's field of view multiplier.",
                new AcceptableValueRange<float>(MinFOV, MaxFOV),
                new ConfigurationManagerAttributes { Order = 90 }));

        HeroLight = config.Bind("03. Hero", "Hero Light", true,
            new ConfigDescription("Toggle the fake light that surrounds the player character.",
                null, new ConfigurationManagerAttributes { Order = 89 }));

        ReduceHeroLight = config.Bind("03. Hero", "Reduce Hero Light", false,
            new ConfigDescription("Reduce the donut light instead of outright disabling.",
                null, new ConfigurationManagerAttributes { Order = 88 }));

        SplashScreens = config.Bind("04. Misc", "Splash Screens", false,
            new ConfigDescription("Control splash screen appearance prior to main menu.",
                null, new ConfigurationManagerAttributes { Order = 87 }));

        MenuClutter = config.Bind("04. Misc", "Menu Clutter", false,
            new ConfigDescription("Control menu clutter on the main menu i.e. logos, version numbers etc.",
                null, new ConfigurationManagerAttributes { Order = 86 }));

        HudOffset = config.Bind("05. HUD", "HUD Offset", DefaultHudOffset,
            new ConfigDescription("Adjust the HUD offset to your liking.",
                new AcceptableValueRange<float>(MinHudOffset, MaxHudOffset),
                new ConfigurationManagerAttributes { Order = 84 }));
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
            CameraFieldOfView.Value = Mathf.Round(CameraFieldOfView.Value * FOVRoundingMultiplier) / FOVRoundingMultiplier;
            Patches.UpdateConfigCache();
        };

        HeroLight.SettingChanged += (_, _) =>
        {
            if (!HeroLight.Value && ReduceHeroLight.Value)
            {
                ReduceHeroLight.Value = false;
                Log.LogInfo("Disabled 'Reduce Hero Light' since 'Hero Light' was disabled");
            }

            Patches.UpdateConfigCache();
        };

        ReduceHeroLight.SettingChanged += (_, _) =>
        {
            if (ReduceHeroLight.Value && !HeroLight.Value)
            {
                HeroLight.Value = true;
                Log.LogInfo("Enabled 'Hero Light' since 'Reduce Hero Light' was enabled");
            }

            Patches.UpdateConfigCache();
        };

        MenuClutter.SettingChanged += (_, _) => UpdateMenuClutter();

        HudOffset.SettingChanged += (_, _) =>
        {
            HudOffset.Value = (float)Math.Round(HudOffset.Value * HudOffsetRoundingMultiplier) / HudOffsetRoundingMultiplier;
            Patches.UpdateConfigCache();
            Patches.UpdateHudOffset();
        };
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
#if DEBUG
        Screen.SetResolution(TestWidth, TestHeight, FullScreenMode.Windowed, Screen.currentResolution.refreshRateRatio);
#endif

        Patches.UpdateHudOffset();
        Patches.UpdateScalers(CurrentAspect);
    }

    private void OnDestroy()
    {
        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= OnSceneLoaded;
        Patches.Cleanup();
    }

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
    }
}
