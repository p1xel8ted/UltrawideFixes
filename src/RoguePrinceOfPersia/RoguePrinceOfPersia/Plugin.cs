using Il2CppInterop.Runtime.Injection;

namespace RoguePrinceOfPersia;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
internal class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.rogueprinceofpersia.ultrawide";
    private const string PluginName = "The Rogue Prince of Persia Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> Fog { get; set; }
    private static ConfigEntry<bool> LightShafts { get; set; }
    private static ConfigEntry<bool> SmokyColor { get; set; }
    private static ConfigEntry<bool> Outlines { get; set; }
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> FilmGrain { get; private set; }
    internal static ConfigEntry<bool> ChromaticAberration { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> DepthOfField { get; private set; }
    internal static ConfigEntry<bool> ColorAdjustments { get; private set; }
    internal static ConfigEntry<float> ScaleAdjustment { get; private set; }
    public static ConfigEntry<float> DepthOfFieldAperture { get; private set; }
    public static ConfigEntry<float> DepthOfFieldFocusDistance { get; private set; }
    internal const float NativeAspect = 16f / 9f;

    internal static ConfigEntry<bool> RestrictHUD { get; private set; }
    internal static ConfigEntry<bool> IncludeUI { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    
    private static readonly int[] CustomRefreshRates =
    [
        30, // Uncommon
        50, // Uncommon
        60, // Common
        72, // Uncommon
        75, // Common
        90, // Uncommon
        100, // Uncommon
        120, // Common
        144, // Common
        165, // Common
        180, // Common
        200, // Uncommon
        240, // Common
        300, // Uncommon
        360, // Uncommon
        480 // Uncommon
    ];

    private static readonly int NativeDisplayWidth = Display.main.systemWidth;
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;
#if DEBUG
    private static ConfigEntry<bool> SixteenTenTesting { get; set; }
    private static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    private static ConfigEntry<bool> FourtyEightNineTesting { get; set; }
#endif
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static float NegativeScaleFactor => NativeAspect / MainAspectRatio;
    internal static float PositiveScaleFactor => MainAspectRatio / NativeAspect;
    internal static float MainAspectRatio => MainWidth / (float)MainHeight;
    public static ManualLogSource Logger { get; private set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    internal static int RefreshRate
    {
        get
        {
            if (UseCustomRefreshRate != null && CustomRefreshRate != null)
            {
                return UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
            }

            return MaxRefresh;
        }
    }


    private static ConfigEntry<int> CustomRefreshRate { get; set; }


    internal static int MainWidth => SelectedResolution.width;
    internal static int MainHeight => SelectedResolution.height;

    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }


    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static ConfigEntry<string> Resolution { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
#if DEBUG
            if (SixteenTenTesting.Value)
            {
                const int height = 1200;
                var width = Mathf.RoundToInt(height * 1.6f); // 1200 * 1.6f = 1920
                return new Resolution { width = width, height = height };
            }

            if (ThirtyTwoNineTesting.Value)
            {
                const int height = 900;
                var width = Mathf.RoundToInt(height * 3.555555555555556f); // 900 * 3.555555555555556f = 3200
                return new Resolution { width = width, height = height };
            }

            if (FourtyEightNineTesting.Value)
            {
                const int height = 600;
                var width = Mathf.RoundToInt(height * 5.333333333333333f); // 600 * 5.333333333333333f = 3200
                return new Resolution { width = width, height = height };
            }
#endif

            if (Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    private static bool RequiresUpdate { get; set; }
    
    internal static float CurrentAspect => (float)SelectedResolution.width / SelectedResolution.height;
    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = NativeDisplayWidth,
            height = NativeDisplayHeight,
            refreshRate = RefreshRate
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }
    
    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => (int)a.refreshRateRatio.value).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }
    
    internal static ConfigEntry<bool> CleanMenu { get; private set; }
 
    public override void Load()
    {
        Logger = Log;
        ClassInjector.RegisterTypeInIl2Cpp<LayoutController>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector3>();
        
        var customRates = MergeUnityRefreshRates();
        
#if DEBUG
        SixteenTenTesting = Config.Bind("00. Testing", "16:10 Testing", false,
            new ConfigDescription(
                "Enable this option to test 16:10 aspect ratio.",
                null,
                new ConfigurationManagerAttributes { Order = 102 }));
        SixteenTenTesting.SettingChanged += (_, _) =>
        {
            if (SixteenTenTesting.Value)
            {
                ThirtyTwoNineTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }
            UpdateAll(true);
        };
        
        ThirtyTwoNineTesting = Config.Bind("00. Testing", "32:9 Testing", false,
            new ConfigDescription(
                "Enable this option to test 32:9 aspect ratio.",
                null,
                new ConfigurationManagerAttributes { Order = 101 }));
        ThirtyTwoNineTesting.SettingChanged += (_, _) =>
        {
            if (ThirtyTwoNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };
        
        FourtyEightNineTesting = Config.Bind("00. Testing", "48:9 Testing", false,
            new ConfigDescription(
                "Enable this option to test 48:9 aspect ratio.",
                null,
                new ConfigurationManagerAttributes {Order = 100 }));
        FourtyEightNineTesting.SettingChanged += (_, _) =>
        {
            if (FourtyEightNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                ThirtyTwoNineTesting.Value = false;
            }
            UpdateAll(true);
        };
#endif
        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>UpdateAll(true);

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll(true);

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll(true);

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll(true);
        
        // ScaleAdjustment = Config.Bind("03. Scaling", "Scale Adjustment", -10f, new ConfigDescription("Adjusts the scale of the UI elements by a percentage.", new AcceptableValueRange<float>(-95f, 200f), new ConfigurationManagerAttributes { Order = 23 }));
        // ScaleAdjustment.SettingChanged += (_, _) => { Patches.UpdateScalers(); };
        
        Bloom = Config.Bind("04. Post-Processing", "Bloom", false, new ConfigDescription("Toggles the bloom effect.", null, new ConfigurationManagerAttributes { Order = 11 }));
        Bloom.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        ChromaticAberration = Config.Bind("04. Post-Processing", "Chromatic Aberration", false, new ConfigDescription("Toggles the chromatic aberration effect.", null, new ConfigurationManagerAttributes { Order = 10 }));
        ChromaticAberration.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        ColorAdjustments = Config.Bind("04. Post-Processing", "Color Adjustments", false, new ConfigDescription("Toggles the color adjustments effect.", null, new ConfigurationManagerAttributes { Order = 9 }));
        ColorAdjustments.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        DepthOfField = Config.Bind("04. Post-Processing", "Depth of Field", false, new ConfigDescription("Toggles the depth of field effect.", null, new ConfigurationManagerAttributes { Order = 8 }));
        DepthOfField.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        DepthOfFieldAperture = Config.Bind("04. Post-Processing", "Depth of Field Aperture", 7.5f, new ConfigDescription("Adjusts the depth of field aperture.", new AcceptableValueRange<float>(5.4f, 50), new ConfigurationManagerAttributes { Order = 7 }));
        DepthOfFieldAperture.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        DepthOfFieldFocusDistance = Config.Bind("04. Post-Processing", "Depth of Field Focus Distance", 40f, new ConfigDescription("Adjusts the depth of field focus distance.", new AcceptableValueRange<float>(40f, 50f), new ConfigurationManagerAttributes { Order = 6 }));
        DepthOfFieldFocusDistance.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        FilmGrain = Config.Bind("04. Post-Processing", "Film Grain", false, new ConfigDescription("Toggles the film grain effect.", null, new ConfigurationManagerAttributes { Order = 5 }));
        FilmGrain.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        Fog = Config.Bind("04. Post-Processing", "Fog", true, new ConfigDescription("Toggles the fog effect.", null, new ConfigurationManagerAttributes { Order = 4 }));
        Fog.SettingChanged += (_, _) => { ToggleEffects(); };
        LightShafts = Config.Bind("04. Post-Processing", "Light Shafts", true, new ConfigDescription("Toggles the light shafts effect.", null, new ConfigurationManagerAttributes { Order = 3 }));
        LightShafts.SettingChanged += (_, _) => { ToggleEffects(); };
        Outlines = Config.Bind("04. Post-Processing", "Outlines", true, new ConfigDescription("Toggles the outlines effect.", null, new ConfigurationManagerAttributes { Order = 2 }));
        Outlines.SettingChanged += (_, _) => { ToggleEffects(); };
        SmokyColor = Config.Bind("04. Post-Processing", "Smoky Color", true, new ConfigDescription("Toggles the smoky color effect.", null, new ConfigurationManagerAttributes { Order = 1 }));
        SmokyColor.SettingChanged += (_, _) => { ToggleEffects(); };
        Vignette = Config.Bind("04. Post-Processing", "Vignette", false, new ConfigDescription("Toggles the vignette effect.", null, new ConfigurationManagerAttributes { Order = 0 }));

        // RestrictHUD = Config.Bind("05. UI", "Restrict HUD", false, new ConfigDescription("Restrict the HUD to 16:9.", null, new ConfigurationManagerAttributes { Order = 22 }));
        // RestrictHUD.SettingChanged += (_, _) => { Patches.UpdateSpanHUD(); };
        //
        // IncludeUI = Config.Bind("05. UI", "Include UI", false, new ConfigDescription("Also include other UI components in the restriction. May not work correctly.", null, new ConfigurationManagerAttributes { Order = 20 }));
        // IncludeUI.SettingChanged += (_, _) => { Patches.UpdateSpanHUD(); };
        
        CleanMenu = Config.Bind("06. Misc", "Clean Menu", true, new ConfigDescription("Remove unnecessary options from the menu.", null, new ConfigurationManagerAttributes { Order = 21 }));
        CleanMenu.SettingChanged += (_, _) => { Patches.UpdateCleanMenu(); };
        
        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = -1 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        RequiresUpdate = true;
        
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Logger.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;
        
        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;

        if (Patches.ConfigCanvasScaler)
        {
            Patches.ConfigCanvasScaler.OnEnable();
        }
        
        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRate);
        Logger.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        RequiresUpdate = false;
    }
    
    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
    }

    private static void ToggleEffects()
    {
        Patches.VolumeUpdateRequired = true;
        var fog = Utils.FindIl2CppType<FogController>();
        foreach (var f in fog)
        {
            f.enabled = Fog.Value;
        }

        var lightShafts = Utils.FindIl2CppType<LightShaftController>();
        foreach (var l in lightShafts)
        {
            l.enabled = LightShafts.Value;
        }

        var smokyColor = Utils.FindIl2CppType<SmokyBiColorController>();
        foreach (var s in smokyColor)
        {
            s.enabled = SmokyColor.Value;
        }

        var outlines = Utils.FindIl2CppType<OutlinePostProcessController>();
        foreach (var o in outlines)
        {
            o.enabled = Outlines.Value;
        }
    }

    
    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        Logger.LogInfo($"Scene loaded: {a.name}");
        ToggleEffects();
        Patches.UpdateCanvasScalers();
        UpdateDisplay();
        Patches.UpdateCleanMenu();
    }
}