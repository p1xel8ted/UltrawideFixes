using Hazard.Camera;

namespace YouWillDieTonight;

[Harmony]
[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    internal const float NativeAspectRatio = 16.0f / 9.0f;
    internal static ConfigEntry<bool> Notifications { get; private set; }

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

    // private static ConfigEntry<bool> SixteenTenTesting { get; set; }
    // private static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    // private static ConfigEntry<bool> FourtyEightNineTesting { get; set; }

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static float CurrentAspectRatio => MainWidth / (float)MainHeight;
    internal static ManualLogSource Log { get; set; }
    internal static float PositiveScaleFactor => CurrentAspectRatio / NativeAspectRatio;
    private static int MaxRefresh => (int)Screen.resolutions.Max(a => a.refreshRate);

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

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
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

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static float NativeWidth => MainHeight * Const.NativeAspectRatio;

    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2f;
    internal static ConfigEntry<bool> HeartBeatEffect { get; private set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigFile ConfigFile { get; private set; }

    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();

    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    private static bool RequiresUpdate { get; set; }

    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;
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

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 87 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 86 }));

        HeartBeatEffect = Config.Bind("03. Misc", "Enable Heartbeat Effect", true,
            new ConfigDescription("Toggle the heartbeat post-processing effect that plays when you are low on health.", null, new ConfigurationManagerAttributes { Order = 85 }));
        HeartBeatEffect.SettingChanged += (_, _) =>
        {
            if (!HeartBeatEffect.Value)
            {
                var heartBeatVolumes = Resources.FindObjectsOfTypeAll<HeartRateVolumeWeight>().ToList();
                foreach (var heartBeatVolume in heartBeatVolumes)
                {
                    heartBeatVolume.OnDisable();
                }
            }
        };
        Notifications = Config.Bind("05. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 86 }));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        Log.LogInfo($"Plugin {Const.PluginName} is loaded!");
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

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => (int)a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static void UpdateCanvasScalers()
    {
        var scalers = Patches.Patches.Scalers.ToList();
        foreach (var scaler in scalers)
        {
            Patches.Patches.ProcessScaler(scaler);
        }
    }

    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
    }


    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
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

        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();

        //ForceCameraChanges();

        UpdateCanvasScalers();
    }

    // private static void ForceCameraChanges()
    // {
    //     foreach (var camera in Camera.allCameras)
    //     {
    //         camera.rect = new Rect(0, 0, MainWidth, MainHeight);
    //         camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
    //         camera.aspect = MainWidth / (float)MainHeight;
    //     }
    // }

    private static void UpdateDisplay(bool force = false)
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

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;


        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRate);

        Log.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        RequiresUpdate = false;
    }
}