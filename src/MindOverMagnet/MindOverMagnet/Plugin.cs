namespace MindOverMagnet;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInDependency("com.bepis.bepinex.configurationmanager", "99.0")]
public class Plugin : BaseUnityPlugin
{
    internal static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    
    private const string PluginGuid = "p1xel8ted.mindovermagnet.uwfixes";
    private const string PluginName = "Mind Over Magnet Ultra-Wide";
    private const string PluginVersion = "0.1.0";

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

    internal static ManualLogSource Log { get; private set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth; //3440
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight; //1440
    internal static float MainAspect => (float)MainWidth / MainHeight;
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    public static float NegScaleFactor => NativeAspect / MainAspect;
    public static float PosScaleFactor => MainAspect / NativeAspect;

    internal const float NativeAspect = 16f / 9f;
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Off", 0 },
        { "Every VBlank", 1 },
        { "Every Second VBlank", 2 }
    };
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
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

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = MainWidth,
            height = MainHeight,
            refreshRate = MaxRefresh
        };
        var resList = new List<Resolution> { mainRes };
        resList.AddRange(  Screen.resolutions);
        resList.SortByPixelCount();
       
        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }
    
    private void Awake()
    {
        Debug.unityLogger.logEnabled = true;

        var customRates = MergeUnityRefreshRates();
       
        Log = Logger;

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 100 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();
        
        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}", new ConfigDescription("Set the resolution to use.", new AcceptableValueList<string>(GetResolutions()), new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => UpdateDisplay();
        
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) => { UpdateDisplay(); };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }
        
        // Define VSync setting with user-friendly text
        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Every VBlank",
            new ConfigDescription(
                "Set the VSync mode.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray())
            ));
        VSyncSetting.SettingChanged += (_, _) => UpdateDisplay();
        
        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => { UpdateDisplay(); };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) => { UpdateDisplay(); };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => { UpdateDisplay(); };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 83 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));

        SceneManager.sceneLoaded += OnSceneLoaded;
        Application.focusChanged += FocusChanged;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
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
        
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;

        Display.displays[DisplayToUse.Value].Activate();

        Screen.SetResolution(res.width, res.height, FullScreenModeConfig.Value, RefreshRate);

        Application.targetFrameRate = Mathf.RoundToInt(TargetFramerate.Value);

        var refreshRate = RefreshRate;
        var targetFramerate = TargetFramerate.Value;

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
        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateCameras();
    }

    private static void UpdateCameras()
    {
        var cameras = Camera.allCameras;
        foreach (var camera in cameras)
        {
    
            var ppc = camera.gameObject.TryAddComponent<PixelPerfectCamera>();
            ppc.enabled = false;

            if (ppc)
            {
                ppc.assetsPPU = 26;
                ppc.refResolutionX = 1280;
                ppc.refResolutionY = 720;
                ppc.enabled = true;
                ppc.m_CinemachineCompatibilityMode = true;
                ppc.cropFrameX = false;
                ppc.cropFrameY = false;
            }

            camera.aspect = MainAspect;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            
        }
    }
}