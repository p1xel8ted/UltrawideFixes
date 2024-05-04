namespace CoreKeeper;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.corekeeper.ultrawide";
    private const string PluginName = "Core Keeper Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private const string LeftPillarBoxName = "Left";
    private const string RightPillarBoxName = "Right";
    
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static float MainAspectRatio => MainWidth / (float) MainHeight;
    private static ConfigEntry<bool> UseCustomMaxWidth { get; set; }
    private static ConfigEntry<int> CustomMaxWidth { get; set; }

    internal static RefreshRate MaxRefreshRate = Screen.resolutions
        .Select(a => a.refreshRateRatio)
        .Aggregate((max, current) => current.value > max.value ? current : max);

    internal static int MaxRefresh => Mathf.RoundToInt((float) MaxRefreshRate.value);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<bool> SkipSplashScreens { get; private set; }
    internal static ConfigEntry<bool> DontDestroyTiles { get; private set; }
    private static ManualLogSource Log { get; set; }

    private void Awake()
    {
        Log = Logger;
       
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode",null, new ConfigurationManagerAttributes {Order = 100}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 99}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        var maxWidth = CalculateMaxWidth();
        UseCustomMaxWidth = Config.Bind("02. Viewport", "Use Custom Max Width", false, new ConfigDescription("At auto, you will see the world spawning/de-spawning. It's not so bad at 21:9, but will be worse at wider resolutions. Adjust this value to your liking.",null, new ConfigurationManagerAttributes {Order = 98}));;
        UseCustomMaxWidth.SettingChanged += (_, _) =>
        {
            UpdatePugCameras();
        };
        CustomMaxWidth = Config.Bind("02. Viewport", "Max Width", maxWidth, new ConfigDescription("This is not the width in screen pixels. For example at 3440x1440 (21:9), a value of 648 expands the viewport entirely.", new AcceptableValueRange<int>(480, maxWidth), new ConfigurationManagerAttributes {Order = 97}));
        CustomMaxWidth.SettingChanged += (_, _) =>
        {
            UpdatePugCameras();
        };
        
        DontDestroyTiles = Config.Bind("02. Viewport", "Dont Destroy Tiles", true, new ConfigDescription("This stops the tiles being removed after they been generated. Not sure of the performance impact.",null, new ConfigurationManagerAttributes {Order = 96}));

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 95}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            FocusChanged(Application.isFocused);
        };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 94}));
        MuteInBackground.SettingChanged += (_, _) =>
        {
            FocusChanged(Application.isFocused);
        };

        SkipSplashScreens = Config.Bind("03. Misc", "Skip Splash Screens", true, new ConfigDescription("Skip the splash screens.", null, new ConfigurationManagerAttributes {Order = 93}));
        
        Application.focusChanged += FocusChanged;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        FocusChanged(Application.isFocused);
        UpdateDisplay();
        UpdateCameras();
        UpdatePugCameras();
        RemovePillars();
    }

    private static int CalculateMaxWidth()
    {
        // Define your reference points (16:9 and 3440x1440)
        const float minAspect = 16f / 9f;
        const float refAspect = 3440f / 1440f; // Actual aspect ratio for 3440x1440

        const float minWidth = 480;
        const float refWidth = 648; // Corresponding width value for the reference aspect

        float maxWidth;

        // If the aspect is less than or equal to the reference aspect (3440x1440)
        if (MainAspectRatio <= refAspect)
        {
            // Interpolate between minWidth (480) and refWidth (648) based on the aspect ratio
            var t = (MainAspectRatio - minAspect) / (refAspect - minAspect);
            maxWidth = minWidth + (refWidth - minWidth) * t;
        }
        else
        {
            // If the aspect is larger than the reference aspect, scale proportionally
            maxWidth = refWidth * (MainAspectRatio / refAspect);
        }

        // Increase by 2% and round
        var roundedMaxWidth = Mathf.RoundToInt(maxWidth * 1.02f);

        return roundedMaxWidth;
    }

    private static void UpdatePugCameras()
    {
        var pugCameras = Resources.FindObjectsOfTypeAll<PugCamera>();
        foreach (var cam in pugCameras)
        {
            if (UseCustomMaxWidth.Value)
            {
                cam.m_outputMode = OutputMode.Fixed;
                cam.m_outputWidth = CustomMaxWidth.Value;
            }
            else
            {
                cam.m_outputMode = OutputMode.MatchAspect;
            }
            if (cam.camera != null)
            {
                cam.camera.aspect = MainAspectRatio;
            }

            cam.outputSmoothing = true;
        }
    }

    private static void RemovePillars()
    {
        var ppb = Resources.FindObjectsOfTypeAll<PP_BlackBorders>();
        foreach (var pp in ppb)
        {
            pp.aspectRatio = MainAspectRatio;
            pp.letterboxHeight = MainHeight;
            pp.letterboxWidth = MainWidth;
        }
        var spr = Resources.FindObjectsOfTypeAll<SpriteRenderer>();
        foreach (var s in spr)
        {
            if (s.name == LeftPillarBoxName)
            {
                s.gameObject.SetActive(false);
            }

            if (s.name == RightPillarBoxName)
            {
                s.gameObject.SetActive(false);
            }
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

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
            cam.aspect = MainAspectRatio;
            cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            cam.rect = new Rect(0, 0, MainWidth, MainHeight);
        }
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefreshRate);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

}