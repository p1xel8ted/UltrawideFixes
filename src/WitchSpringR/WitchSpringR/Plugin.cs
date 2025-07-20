namespace WitchSpringR;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.witchspringr.ultrawide";
    private const string PluginName = "WitchSpring R Ultra-Wide";
    private const string PluginVersion = "0.1.4";

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

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    private static readonly int NativeDisplayWidth = Display.main.systemWidth;
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static int MainWidth => SelectedResolution.width;
    internal static int MainHeight => SelectedResolution.height;
    internal static float MainAspect => MainWidth / (float)MainHeight;
    internal static Rect CameraRect => new(0, 0, MainWidth, MainHeight);
    private static float NormalWidth => MainHeight * 16f / 9f; //2560
    internal static float PositiveScaleFactor => MainWidth / NormalWidth; //1.34375
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> ToneMapping { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> SpanHud { get; private set; }
    internal static ConfigEntry<bool> ShowSkirt { get; private set; }
    internal static ConfigEntry<bool> ShowHat { get; private set; }
    internal static ConfigEntry<bool> ShowRobe { get; private set; }
    internal static ConfigEntry<bool> ShowStaff { get; private set; }
    internal static ConfigEntry<bool> DepthOfField { get; private set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    internal static ManualLogSource Logger { get; private set; }

    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnceInt OriginalFixedDeltaTime { get; } = new();

    private static ConfigEntry<int> TargetFramerate { get; set; }
    internal static float NativeAspectRatio => 16f / 9f;
    private static float CameraWidth => MainHeight * NativeAspectRatio;
    internal static float BlackBarSize => (MainWidth - CameraWidth) / 2f;

    /// private static int MaxRefresh => (int)Screen.resolutions.Max(a => a.refreshRate);

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

    internal static float CurrentAspectRatio => MainWidth / (float)MainHeight;

    internal static Resolution SelectedResolution
    {
        get
        {
            // if (SixteenTenTesting.Value)
            // {
            //     const int height = 1200;
            //     var width = Mathf.RoundToInt(height * 1.6f); // 1200 * 1.6f = 1920
            //     return new Resolution { width = width, height = height };
            // }
            //
            // if (ThirtyTwoNineTesting.Value)
            // {
            //     const int height = 900;
            //     var width = Mathf.RoundToInt(height * 3.555555555555556f); // 900 * 3.555555555555556f = 3200
            //     return new Resolution { width = width, height = height };
            // }
            //
            // if (FourtyEightNineTesting.Value)
            // {
            //     const int height = 600;
            //     var width = Mathf.RoundToInt(height * 5.333333333333333f); // 600 * 5.333333333333333f = 3200
            //     return new Resolution { width = width, height = height };
            // }

            if (Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }


    private static ConfigEntry<string> Resolution { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }
    private static bool RequiresUpdate { get; set; }

    private static void UpdateCanvasScalers()
    {
        var scalers = Patches.Patches.Scalers.ToList();
        foreach (var scaler in scalers)
        {
            Patches.Patches.ProcessScaler(scaler);
        }
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

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

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<LeftHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<RightHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<MiniMapMover>();
        ClassInjector.RegisterTypeInIl2Cpp<ClothsToggler>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        // ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();
        ClassInjector.RegisterTypeInIl2Cpp<FieldMenuToggler>();

        Logger = Log;

        var customRates = MergeUnityRefreshRates();

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => { UpdateAll(true); };

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

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

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
        
        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.", null, new ConfigurationManagerAttributes { Order = 92 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 91 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        Bloom = Config.Bind("03. Post-Processing", "Bloom", true, new ConfigDescription("Enable Bloom", null, new ConfigurationManagerAttributes { Order = 92 }));
        Bloom.SettingChanged += (_, _) => { Patches.Patches.VolumeUpdateRequired = true; };

        ToneMapping = Config.Bind("03. Post-Processing", "Tone Mapping", true, new ConfigDescription("Enable Tone Mapping", null, new ConfigurationManagerAttributes { Order = 91 }));
        ToneMapping.SettingChanged += (_, _) => { Patches.Patches.VolumeUpdateRequired = true; };

        Vignette = Config.Bind("03. Post-Processing", "Vignette", true, new ConfigDescription("Enable Vignette", null, new ConfigurationManagerAttributes { Order = 90 }));
        Vignette.SettingChanged += (_, _) => { Patches.Patches.VolumeUpdateRequired = true; };

        DepthOfField = Config.Bind("03. Post-Processing", "Depth of Field", true, new ConfigDescription("Enable Depth of Field", null, new ConfigurationManagerAttributes { Order = 89 }));
        DepthOfField.SettingChanged += (_, _) => { Patches.Patches.VolumeUpdateRequired = true; };

        SpanHud = Config.Bind("04. UI", "Span HUD", true, new ConfigDescription("Spans the HUD across the entire screen.", null, new ConfigurationManagerAttributes { Order = 88 }));

        FieldOfView = Config.Bind("05. Camera", "Field of View", Mathf.RoundToInt(24 * PositiveScaleFactor), new ConfigDescription("Increase or decrease the field of view of the camera.", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes { Order = 87 }));
        FieldOfView.SettingChanged += (_, _) => { Patches.Patches.UpdateCamera(); };

        ShowStaff = Config.Bind("06. Equipment", "Show Staff", true, new ConfigDescription("Show Staff", null, new ConfigurationManagerAttributes { Order = 86 }));
        ShowSkirt = Config.Bind("06. Equipment", "Show Skirt", true, new ConfigDescription("Show Skirt", null, new ConfigurationManagerAttributes { Order = 85 }));
        ShowHat = Config.Bind("06. Equipment", "Show Hat", true, new ConfigDescription("Show Hat", null, new ConfigurationManagerAttributes { Order = 84 }));
        ShowRobe = Config.Bind("06. Equipment", "Show Robe", true, new ConfigDescription("Show Robe", null, new ConfigurationManagerAttributes { Order = 83 }));


        RunInBackground = Config.Bind("07. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("07. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        FieldMenu = Config.Bind("07. Misc", "Field Menu", true, new ConfigDescription("Toggles visibility of the field menu", null, new ConfigurationManagerAttributes { Order = 80 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    public static ConfigEntry<bool> FieldMenu { get; set; }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / MaxRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
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


        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRate);

        Logger.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        // if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        // {
        //     ConfigurationManager.CloseWindow();
        //     ConfigurationManager.OpenWindow();
        // }

        RequiresUpdate = false;
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals("#Logo"))
        {
            SceneManager.LoadScene("#Title");
        }

        Patches.Patches.VolumeUpdateRequired = true;
        
        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateCanvasScalers();
    }
}