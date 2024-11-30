namespace ConvergenceLoL;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency("com.bepis.bepinex.configurationmanager", "99.0")]
public class Plugin : BaseUnityPlugin
{
    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;

    private const string PluginGuid = "p1xel8ted.convergencelol.uwfixes";
    private const string PluginName = "Conv/rgence: A League of Legends Story Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    public static ConfigEntry<bool> MainVignette { get; private set; }

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

    internal static ManualLogSource Log { get; private set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float PositiveScaleFactor => MainAspect / NativeAspect;
    private const float NativeAspect = 16f / 9f;
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static int MainWidth => SelectedResolution.width;
    private static int MainHeight => SelectedResolution.height;
    internal static float MainAspect => (float)MainWidth / MainHeight;
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }
    internal static ConfigEntry<string> HUDAspect { get; private set; }

    private static List<string> HUDAspects { get; } =
    [
        "16:9",
        "21:9",
        "21.5:9",
        "24:10",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    private static ConfigEntry<string> Resolution { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
            if (Resolution == null) return MainDisplayRes;
            
            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };

        }
    }
    
    internal static Resolution MainDisplayRes = new()
    {
        width = Display.main.systemWidth,
        height = Display.main.systemHeight,
        refreshRate = RefreshRate
    };

    public static ConfigEntry<bool> MainBloom { get; private set; }

    public static ConfigEntry<bool> LowHpVignette { get; private set; }
    public static ConfigEntry<bool> LowHpBloom { get; private set; }
    public static ConfigEntry<bool> LowHpChromaticAberration { get; private set; }

    private static string[] GetResolutions()
    {
        var resList = new List<Resolution> { MainDisplayRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static WriteOnce<float> OriginalFixedDeltaTime { get; } = new();

    private void Awake()
    {
        Debug.unityLogger.logEnabled = true;

        var customRates = MergeUnityRefreshRates();

        Log = Logger;

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateDisplay();
        };

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
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateDisplay();
        };
        

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateDisplay();
        };

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateDisplay();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateDisplay();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => { Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1; };
        
        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(true); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(true); };

        MainVignette = Config.Bind("03. Main Post-Processing", "Vignette", true,
            new ConfigDescription(
                "Enable or disable the vignette effect. Vignette darkens the edges of the screen to draw focus to the center.",
                null,
                new ConfigurationManagerAttributes { Order = 85 }));
        MainVignette.SettingChanged += (_, _) => UpdateVolumes();

        MainBloom = Config.Bind("03. Main Post-Processing", "Bloom", true,
            new ConfigDescription(
                "Enable or disable the bloom effect. Bloom adds a soft glow to bright areas of the screen.",
                null,
                new ConfigurationManagerAttributes { Order = 84 }));
        MainBloom.SettingChanged += (_, _) => UpdateVolumes();

        LowHpVignette = Config.Bind("04. Low HP Post-Processing", "Vignette", true,
            new ConfigDescription(
                "Enable or disable the vignette effect when the player's health is low. Vignette darkens the edges of the screen to draw focus to the center.",
                null,
                new ConfigurationManagerAttributes { Order = 80 }));
        LowHpVignette.SettingChanged += (_, _) => UpdateVolumes();

        LowHpBloom = Config.Bind("04. Low HP Post-Processing", "Bloom", true,
            new ConfigDescription(
                "Enable or disable the bloom effect when the player's health is low. Bloom adds a soft glow to bright areas of the screen.",
                null,
                new ConfigurationManagerAttributes { Order = 79 }));
        LowHpBloom.SettingChanged += (_, _) => UpdateVolumes();

        LowHpChromaticAberration = Config.Bind("04. Low HP Post-Processing", "Chromatic Aberration", true,
            new ConfigDescription(
                "Enable or disable the chromatic aberration effect when the player's health is low. Chromatic aberration adds a color fringe to the edges of the screen.",
                null,
                new ConfigurationManagerAttributes { Order = 78 }));
        LowHpChromaticAberration.SettingChanged += (_, _) => UpdateVolumes();

        HUDAspect = Config.Bind("05. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 77 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAspect();

        SceneManager.sceneLoaded += OnSceneLoaded;

        RequiresUpdate = true;

        UpdateAll();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateFixedDeltaTime(bool player = false)
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0)
        {
            Log.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / targetRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        if (player)
        {
            Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
        }
    }

    private static void UpdateVolumes()
    {
        var volumes = Resources.FindObjectsOfTypeAll<Volume>();
        foreach (var volume in volumes)
        {
            if (volume)
            {
                Patches.Volume_OnEnable(volume);
            }
        }
    }

    private static void UpdateAll()
    {
        UpdateCameras();
        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateAspect();
        UpdateVolumes();
    }

    private static void UpdateCameras()
    {
        var cameras = Camera.allCameras;
        foreach (var camera in cameras)
        {
            camera.aspect = MainAspect;
            camera.pixelRect = new Rect(0, 0, SelectedResolution.width, SelectedResolution.height);
            camera.rect = new Rect(0, 0, 1, 1);
        }
    }

    private static void UpdateAspect()
    {
        var aspectRatioAdaptiveRects = Resources.FindObjectsOfTypeAll<AspectRatioAdaptiveRect>();
        foreach (var aspectRatioAdaptiveRect in aspectRatioAdaptiveRects)
        {
            var y = aspectRatioAdaptiveRect.RectTransform.sizeDelta.y;
            var x = Utils.GetHudRes(y);
            aspectRatioAdaptiveRect.RectTransform.sizeDelta = new Vector2(x, y);
        }
    }

    private static void UpdateDisplay()
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Log.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;


        if (!RequiresUpdate) return;

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRate);
        Log.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz, Physics Rate={1f / Time.fixedDeltaTime}Hz");

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        RequiresUpdate = false;
    }

    private static bool RequiresUpdate { get; set; }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions
            .Select(a => a.refreshRate) // Convert double to float
            .Distinct()
            .ToArray();


        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }
}