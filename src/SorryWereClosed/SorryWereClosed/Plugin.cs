namespace SorryWereClosed;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency("com.bepis.bepinex.configurationmanager", "99.0")]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.sorrywereclosed.uwfixes";
    private const string PluginName = "Sorry We're Closed Ultra-Wide";
    private const string PluginVersion = "0.1.1";

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

    // internal static RefreshRate RefreshRateRatio => new()
    // {
    //     numerator = 1,
    //     denominator = (uint)RefreshRate
    // };

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

    internal static ManualLogSource Log { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.main.systemWidth; //3440
    internal static int MainHeight => Display.main.systemHeight; //1440
    internal static float MainAspect => (float)MainWidth / MainHeight;
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static WriteOnce<float> OriginalFixedDeltaTime { get; } = new();
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }

    private static ConfigEntry<string> Resolution { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    internal static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;

    private void Awake()
    {
        Debug.unityLogger.logEnabled = true;
        Log = Logger;

        var customRates = MergeUnityRefreshRates();

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => UpdateAll();

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
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll();

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll();

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll();

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll();

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription(
                "Optimizes the physics update rate to minimize camera judder based on your monitor's refresh rate. " +
                "This is a general Unity fix that might not apply to all games. While it can improve smoothness, it may cause unintended side effects or have no noticeable impact.",
                null,
                new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => UpdateAll();

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription(
                "Automatically adjusts the physics update rate to match your monitor's refresh rate for smoother gameplay. " +
                "This setting may improve visual fluidity but could impact performance on lower-end systems.",
                null,
                new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => UpdateAll();


        RunInBackground = Config.Bind("03. Misc", "Run In Background", true,
            new ConfigDescription(
                "Allow the game to continue running even when it is not the active window. Useful for multitasking or background resource usage.",
                null,
                new ConfigurationManagerAttributes { Order = 89 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false,
            new ConfigDescription(
                "Mutes the game's audio when it is not the active window. Enable this if you want silence while multitasking.",
                null,
                new ConfigurationManagerAttributes { Order = 88 }));

        SceneManager.sceneLoaded += OnSceneLoaded;
        Application.focusChanged += FocusChanged;

        UpdateAll();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = MainWidth,
            height = MainHeight,
            refreshRate = MaxRefresh
        };
        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private static void UpdateAll()
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    }

    private static void UpdateFixedDeltaTime()
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

        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateDisplay()
    {
        var res = SelectedResolution;

        Application.runInBackground = RunInBackground.Value;

        Screen.SetResolution(res.width, res.height, FullScreenModeConfig.Value, RefreshRate);

        Application.targetFrameRate = Mathf.RoundToInt(TargetFramerate.Value);

        var refreshRate = RefreshRate;

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

        // Apply refresh rate and resolution

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, refreshRate);

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        Log.LogInfo($"Display updated: VSync={QualitySettings.vSyncCount}, Target FPS={Application.targetFrameRate}, Refresh Rate={refreshRate}Hz");
    }

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

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }
}