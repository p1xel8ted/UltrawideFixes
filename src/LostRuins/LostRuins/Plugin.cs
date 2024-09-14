namespace LostRuins;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.lostruins.ultrawide";
    private const string PluginName = "Lost Ruins Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const string VSyncOff = "VSync: Off";
    private const string VSyncOn = "VSync: On";
    private const string VSyncHalfRefreshRate = "VSync: Half Refresh Rate";

    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display._mainDisplay.systemWidth;
    internal static int MainHeight => Display._mainDisplay.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float ScaleFactor => MainAspect / NativeAspect;
    internal const float NativeAspect = 16f / 9f;
    internal static float MainAspect => (float)MainWidth / MainHeight;
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<string> Vsync { get; set; }
    private static readonly string[] VsyncOptions = [VSyncOff, VSyncOn, VSyncHalfRefreshRate];
    private static ConfigEntry<int> AntiAliasingNormal { get; set; }
    private static ConfigEntry<string> QualityPreset { get; set; }
    internal static ManualLogSource Log { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }

    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes { Order = 103 }));
        FullScreenModeConfig.SettingChanged += (_, _) => { UpdateDisplay(); };

        Vsync = Config.Bind("01. Display", "VSync", VSyncOff, new ConfigDescription("Set the VSync mode", new AcceptableValueList<string>(VsyncOptions), new ConfigurationManagerAttributes { Order = 102 }));
        Vsync.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        QualityPreset = Config.Bind("02. Quality", "Quality Preset", "Ultra", new ConfigDescription("Quality Preset to use.", new AcceptableValueList<string>(QualitySettings.names), new ConfigurationManagerAttributes { Order = 101 }));
        QualityPreset.SettingChanged += (_, _) =>
        {
            UpdateAA();
            UpdateGraphicsQualitySettings();
        };

        AnisotropicFiltering = Config.Bind("02. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering.", null, new ConfigurationManagerAttributes { Order = 99 }));
        AnisotropicFiltering.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        AntiAliasingNormal = Config.Bind("02. Quality", "MSAA", 0, new ConfigDescription("Set the level of Multi-Sample Anti-Aliasing (MSAA) to smooth out edges in the game graphics. Higher levels provide better quality but may impact performance.", new AcceptableValueList<int>(0, 2, 4, 8), new ConfigurationManagerAttributes { Order = 98 }));
        AntiAliasingNormal.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        CorrectFixedUpdateRate = Config.Bind("04. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 92 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 91 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        RunInBackground = Config.Bind("05. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 90 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("05. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 89 }));

        Application.focusChanged += FocusChanged;


        UpdateAA();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateAA()
    {
        AntiAliasingNormal.Value = QualityPreset.Value switch
        {
            "Low" => 0,
            "Medium" => 2,
            "High" => 4,
            "Ultra" => 8,
            _ => AntiAliasingNormal.Value
        };
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

    internal static void UpdateGraphicsQualitySettings()
    {
        // Get the index of the desired quality preset
        var qualityIndex = QualitySettings.names.ToList().IndexOf(QualityPreset.Value);
        if (qualityIndex >= 0)
        {
            QualitySettings.SetQualityLevel(qualityIndex, true);
        }
        else
        {
            Debug.LogWarning($"Quality preset '{QualityPreset.Value}' not found. Using default quality level.");
        }

        // Set anisotropic filtering
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value
            ? UnityEngine.AnisotropicFiltering.ForceEnable
            : UnityEngine.AnisotropicFiltering.Disable;

        // Set LOD bias
        QualitySettings.lodBias = 10.0f;

        // Define VSync options
        switch (Vsync.Value)
        {
            case VSyncOff:
                QualitySettings.vSyncCount = 0;
                break;
            case VSyncOn:
                QualitySettings.vSyncCount = 1;
                break;
            case VSyncHalfRefreshRate:
                QualitySettings.vSyncCount = 2;
                break;
            default:
                Debug.LogWarning($"Unknown VSync option '{Vsync.Value}'. Keeping current settings.");
                break;
        }

        // Set antialiasing with validation
        int[] validAALevels = [0, 2, 4, 8];
        if (validAALevels.Contains(AntiAliasingNormal.Value))
        {
            QualitySettings.antiAliasing = AntiAliasingNormal.Value;
        }
        else
        {
            Debug.LogWarning($"Invalid anti-aliasing value '{AntiAliasingNormal.Value}'. Setting to 0 (Off).");
            QualitySettings.antiAliasing = 0;
        }
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateGraphicsQualitySettings();
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

    private static void UpdateDisplay()
    {
        // Check if WindowPositioner is not null and start it if necessary
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        // Set the application to run in the background based on the configuration value
        Application.runInBackground = RunInBackground.Value;

        // Activate the specified display
        Display._mainDisplay.Activate();

        // Set the screen resolution based on the configuration
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
    }
}