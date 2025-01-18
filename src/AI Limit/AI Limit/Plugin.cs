namespace AI_Limit;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.ailimit.ultrawide";
    private const string PluginName = "AI Limit Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    internal const float NativeAspect = 16.0f / 9.0f;

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

    // internal static float NativeDisplayAspect = Display.main.systemWidth / (float)Display.main.systemHeight;

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

    internal static RefreshRate RefreshRateNew = new()
    {
        denominator = 1,
        numerator = (uint)RefreshRate
    };
    
    internal static ManualLogSource Logger { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }

    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();


    // internal static float BlackBarSize => (MainWidth - MainHeight * NativeAspectRatio) / 2f; //3440 - 2560 = 880 / 2 = 440
    public static float NegativeScaleFactor => NativeAspect / CurrentAspect; //0.7454545454545455
    public static ConfigEntry<bool> ScaleMenuBackground { get; private set; }
    public static ConfigEntry<float> CameraFieldOfView { get; private set; }

    internal static float MainAspectRatio => MainWidth / (float)MainHeight;
    internal static float PositiveScaleFactor => MainAspectRatio / NativeAspect;
    private static int MaxRefresh => (int)Screen.resolutions.Max(a => a.refreshRateRatio.value);

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
    
    internal static float CurrentAspect => (float)SelectedResolution.width / SelectedResolution.height;

    private static bool RequiresUpdate { get; set; }


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
            refreshRateRatio = RefreshRateNew
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }


    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceString>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceGateFit>();
        ClassInjector.RegisterTypeInIl2Cpp<CameraGateFitEnforcer>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector2>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector3>();
   
        Logger = Log;
        var customRates = MergeUnityRefreshRates();

        // SixteenTenTesting = Config.Bind("00. Testing", "16:10 Testing", false,
        //     new ConfigDescription(
        //         "Enable this option to test 16:10 aspect ratio.",
        //         null,
        //         new ConfigurationManagerAttributes { IsAdvanced = true, Order = 102 }));
        // SixteenTenTesting.SettingChanged += (_, _) =>
        // {
        //     if (SixteenTenTesting.Value)
        //     {
        //         ThirtyTwoNineTesting.Value = false;
        //         FourtyEightNineTesting.Value = false;
        //     }
        //
        //     RequiresUpdate = true;
        //     
        //     UpdateAll();
        // };
        //
        // ThirtyTwoNineTesting = Config.Bind("00. Testing", "32:9 Testing", false,
        //     new ConfigDescription(
        //         "Enable this option to test 32:9 aspect ratio.",
        //         null,
        //         new ConfigurationManagerAttributes { IsAdvanced = true, Order = 101 }));
        // ThirtyTwoNineTesting.SettingChanged += (_, _) =>
        // {
        //     if (ThirtyTwoNineTesting.Value)
        //     {
        //         SixteenTenTesting.Value = false;
        //         FourtyEightNineTesting.Value = false;
        //     }
        //
        //     RequiresUpdate = true;
        //     UpdateAll();
        // };
        //
        // FourtyEightNineTesting = Config.Bind("00. Testing", "48:9 Testing", false,
        //     new ConfigDescription(
        //         "Enable this option to test 48:9 aspect ratio.",
        //         null,
        //         new ConfigurationManagerAttributes { IsAdvanced = true, Order = 100 }));
        // FourtyEightNineTesting.SettingChanged += (_, _) =>
        // {
        //     if (FourtyEightNineTesting.Value)
        //     {
        //         SixteenTenTesting.Value = false;
        //         ThirtyTwoNineTesting.Value = false;
        //     }
        //
        //     RequiresUpdate = true;
        //     UpdateAll();
        // };

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
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
            UpdateAll();
        };

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
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. The games controls are tied to this, so you may have to reduce mouse/controller sensitivity.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };
        
        CameraFieldOfView = Config.Bind("03. Camera", "Field of View", 25f, new ConfigDescription("Adjust the camera's field of view by a percentage.", new AcceptableValueRange<float>(-99f, 200f), new ConfigurationManagerAttributes { Order = 90 }));
        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            CameraFieldOfView.Value = Mathf.Round(CameraFieldOfView.Value * 4f) / 4f;
            Patches.Patches.UpdateCamera();
        };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }


    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0)
        {
            Logger.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
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

        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }
    
    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            if (!camera) continue;
            camera.gameObject.TryAddComponent<CameraGateFitEnforcer>();
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
            Logger.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;


        if (!RequiresUpdate) return;


        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRateNew);
        Logger.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");


        RequiresUpdate = false;
    }

    private static void UpdateAll()
    {
        UpdateDisplay();
        UpdateCameras();
        UpdateFixedDeltaTime();
        Patches.Patches.UpdateCamera();
        Patches.Patches.UpdateTransforms();
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }
}