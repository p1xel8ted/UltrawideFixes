namespace xRESIST;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.1000xresist.ultrawide";
    private const string PluginName = "1000xRESIST Ultra-Wide";
    private const string PluginVersion = "0.1.1";

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

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static int MainWidth => SelectedResolution.width;
    private static int MainHeight => SelectedResolution.height;

    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }

    internal static ConfigEntry<float> OffsetX { get; set; }
    internal static ConfigEntry<float> OffsetY { get; set; }
    internal static ConfigEntry<float> OffsetZ { get; set; }
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
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }


    public override void Load()
    {
        Logger = Log;
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<LayoutController>();
        ClassInjector.RegisterTypeInIl2Cpp<Patches.Forcer>();
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
                new ConfigurationManagerAttributes { Order = 100 }));
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
        Resolution.SettingChanged += (_, _) => UpdateAll(true);

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

        OffsetX =  Config.Bind("00. Testing", "OffsetX", Plugin.PositiveScaleFactor,
            new ConfigDescription(
                "Offset",
                new AcceptableValueRange<float>(-25f,25f),
                new ConfigurationManagerAttributes { Order = 102 }));
        OffsetY =  Config.Bind("00. Testing", "OffsetY", Plugin.PositiveScaleFactor,
            new ConfigDescription(
                "Offset",
                new AcceptableValueRange<float>(-25f,25f),
                new ConfigurationManagerAttributes { Order = 102 }));
        OffsetZ =  Config.Bind("00. Testing", "OffsetZ", Plugin.PositiveScaleFactor,
            new ConfigDescription(
                "Offset",
                new AcceptableValueRange<float>(-25f,25f),
                new ConfigurationManagerAttributes { Order = 102 }));
        
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;
        RequiresUpdate = true;

        UpdateAll(true);

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


        var nativeDisplayWidth = NativeDisplayHeight * NativeAspect;
        var uiCamera = Resources.FindObjectsOfTypeAll<Camera>().FirstOrDefault(a => a.name == "UICamera");
        if (uiCamera)
        {
            if (!Mathf.Approximately(uiCamera.pixelRect.width, nativeDisplayWidth))
            {
                RequiresUpdate = true;
            }
        }

        var mainCamera = Resources.FindObjectsOfTypeAll<Camera>().FirstOrDefault(a => a.name == "Main Camera");
        if (mainCamera)
        {
            if (!Mathf.Approximately(mainCamera.aspect, MainAspectRatio))
            {
                RequiresUpdate = true;
            }
        }

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
        UpdateCameras();
    }

    private static readonly Dictionary<int, Camera.GateFitMode> OriginalGateFitModes = new();

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            if (!camera) continue;

            if (!OriginalGateFitModes.TryGetValue(camera.GetInstanceID(), out var gf))
            {
                OriginalGateFitModes.Add(camera.GetInstanceID(), camera.gateFit);
                gf = camera.gateFit;
            }

            camera.gateFit = CurrentAspect > NativeAspect ? Camera.GateFitMode.Vertical : gf;

            if (camera.name != "UICamera") continue;

            camera.aspect = NativeAspect;

            if (CurrentAspect > NativeAspect)
            {
                var widthDiff = MainWidth - MainHeight * NativeAspect; //3440 - (1440 * 1.7777778) = 3440 - 2560 = 880
                var blackBarSize = widthDiff / 2; // 880 / 2 = 440
                camera.rect = new Rect(0, 0, NativeAspect / CurrentAspect, 1);
                camera.pixelRect = new Rect(blackBarSize, 0, SelectedResolution.height * NativeAspect, SelectedResolution.height);
            }
            else
            {
                camera.rect = new Rect(0, 0, 1, 1);
                camera.pixelRect = new Rect(0, 0, SelectedResolution.width, SelectedResolution.height);
            }
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }
}