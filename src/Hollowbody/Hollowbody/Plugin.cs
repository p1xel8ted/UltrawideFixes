namespace Hollowbody;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.hollowbody.ultrawide";
    private const string PluginName = "Hollowbody Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    private const string VSyncOff = "Uncapped";
    private const string VSyncOn = "Target: Monitor Refresh Rate";
    private const string VSyncHalfRefreshRate = "Target: Half Monitor Refresh Rate";
    internal static readonly int MainHeight = Display._mainDisplay.systemHeight;

    private static readonly int NativeWidth = Mathf.RoundToInt(MainHeight * NativeAspect);
    internal static readonly float WidthDifference = MainWidth - NativeWidth;
    internal static readonly float BlackBarWidth = WidthDifference / 2f;

    private static readonly string[] VsyncOptions = [VSyncOff, VSyncOn, VSyncHalfRefreshRate];
  
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display._mainDisplay.systemWidth;

    internal static float MainDisplayAspectRatio =>
        Display._mainDisplay.systemWidth / (float)Display._mainDisplay.systemHeight;

    private static float NativeAspect => 16f / 9f;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ConfigEntry<PostProcessLayer.Antialiasing> AntiAliasing { get; private set; }
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> SkipSplash { get; set; }
    private static ConfigEntry<bool> FollowCamera { get; set; }

    private static Resolution MainDisplayResolution
    {
        get
        {
            var res = new Resolution
            {
                width = Display._mainDisplay.systemWidth,
                height = Display._mainDisplay.systemHeight,
                refreshRate = MaxRefresh
            };
            return res;
        }
    }

    private static Resolution ChosenResolution
    {
        get
        {
            var graphics = Resources.FindObjectsOfTypeAll<GraphicOptions>().FirstOrDefault();
            if (!graphics) return MainDisplayResolution;
            var saveData = graphics.GetSaveData();
            if (saveData == null) return MainDisplayResolution;
            var resIndex = saveData.screenResolutionIndex;
            if (resIndex < 0 || resIndex >= graphics.supportedResolutions.Count) return MainDisplayResolution;
            var res = graphics.supportedResolutions[resIndex];
            return res;
        }
    }

    internal static Resolution[] SupportedResolutions
    {
        get
        {
            var resolutions = Screen.resolutions.ToList();
            resolutions.RemoveAll(a => a.width != MainWidth || a.height != MainHeight);
            return resolutions.ToArray();
        }
    }

    private static ConfigEntry<string> Vsync { get; set; }
    private static ConfigEntry<int> AntiAliasingNormal { get; set; }

    private static ConfigEntry<string> QualityPreset { get; set; }

    private static ConfigEntry<bool> UnityDebug { get; set; }
    private static ManualLogSource Log { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    public static ConfigEntry<bool> CenterText { get; private set; }
    public static ConfigEntry<bool> CorrectUiElements { get; private set; }
    internal static ConfigEntry<bool> AmbientOcclusion { get; private set; }
    internal static ConfigEntry<bool> ColorGrading { get; private set; }
    internal static ConfigEntry<bool> MotionBlur { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> AutoExposure { get; private set; }

    internal static ConfigEntry<bool> ChromaticAberration { get; private set; }
    internal static ConfigEntry<bool> Grain { get; private set; }
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> Crt { get; private set; }
    internal static ConfigEntry<bool> TVEffect { get; private set; }
    internal static ConfigEntry<bool> PictureCorrection { get; private set; }
    private static ConfigEntry<int> FirstPersonFOV { get; set; }

    private static WriteOnce<float> OriginalFirstPersonFieldOfView { get; } = new();

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        UnityDebug = Config.Bind("00. General", "Unity Debug", false,
            new ConfigDescription("Enable Unity Debug logging.", null,
                new ConfigurationManagerAttributes { Order = 104 }));
        UnityDebug.SettingChanged += (_, _) => { UpdateDebug(); };

        UpdateDebug();

        SkipSplash = Config.Bind("00. General", "Skip Splash", true,
            new ConfigDescription("Skip the splash screen.", null, new ConfigurationManagerAttributes { Order = 105 }));

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription("Set the full screen mode", null,
                new ConfigurationManagerAttributes { Order = 103 }));
        FullScreenModeConfig.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        Vsync = Config.Bind("01. Display", "VSync", VSyncOff,
            new ConfigDescription("Set the VSync mode", new AcceptableValueList<string>(VsyncOptions),
                new ConfigurationManagerAttributes { Order = 102 }));
        Vsync.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        QualityPreset = Config.Bind("02. Quality", "Quality Preset", "Ultra",
            new ConfigDescription("Quality Preset to use.", new AcceptableValueList<string>(QualitySettings.names),
                new ConfigurationManagerAttributes { Order = 101 }));
        QualityPreset.SettingChanged += (_, _) =>
        {
            UpdateAA();
            UpdateGraphicsQualitySettings();
        };

        AnisotropicFiltering = Config.Bind("02. Quality", "Anisotropic Filtering", true,
            new ConfigDescription("Enable Anisotropic Filtering.", null,
                new ConfigurationManagerAttributes { Order = 99 }));
        AnisotropicFiltering.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        AntiAliasingNormal = Config.Bind("02. Quality", "MSAA", 0,
            new ConfigDescription(
                "Set the level of Multi-Sample Anti-Aliasing (MSAA) to smooth out edges in the game graphics. Higher levels provide better quality but may impact performance.",
                new AcceptableValueList<int>(0, 2, 4, 8), new ConfigurationManagerAttributes { Order = 98 }));
        AntiAliasingNormal.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        AntiAliasing = Config.Bind("02. Quality", "Post-Process AA", PostProcessLayer.Antialiasing.TemporalAntialiasing,
            new ConfigDescription(
                "Choose the anti-aliasing method applied during post-processing. Different methods offer various balances between performance and visual quality.",
                null, new ConfigurationManagerAttributes { Order = 97 }));
        AntiAliasing.SettingChanged += (_, _) => { UpdateGraphicsQualitySettings(); };

        CenterText = Config.Bind("04. UI", "Center Scene Title", false,
            new ConfigDescription("Center the scene title", null, new ConfigurationManagerAttributes { Order = 95 }));
        CenterText.SettingChanged += (_, _) => { Patches.UpdateTitleBars(); };

        CorrectUiElements = Config.Bind("04. UI", "Correct UI Elements", false,
            new ConfigDescription("Corrects certain UI elements to be constrained to 16:9 like the others.", null,
                new ConfigurationManagerAttributes { Order = 94 }));
        
        FirstPersonFOV = Config.Bind("05. Camera", "First Person FOV", 60, new ConfigDescription("Set the first person camera field of view.", new AcceptableValueRange<int>(30, 150), new ConfigurationManagerAttributes { Order = 93 }));
        FirstPersonFOV.SettingChanged += (_, _) => { UpdateFirstPersonCamera(); };

        FollowCamera = Config.Bind("05. Camera", "Follow Camera", false,
            new ConfigDescription("Camera will follow the player instead of being room-based.", null,
                new ConfigurationManagerAttributes { Order = 93 }));
        FollowCamera.SettingChanged += (_, _) => { UpdateFollowCamera(); };

        CorrectFixedUpdateRate = Config.Bind("06. Performance", "Modify Physics Rate", false,
            new ConfigDescription(
                "Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.",
                null, new ConfigurationManagerAttributes { Order = 92 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("06. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription(
                "Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.",
                null, new ConfigurationManagerAttributes { Order = 91 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        AmbientOcclusion = Config.Bind("07. Post-Processing", "Ambient Occlusion", true,
            "Enable or disable Ambient Occlusion");
        AmbientOcclusion.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        ColorGrading = Config.Bind("07. Post-Processing", "Color Grading", true, "Enable or disable Color Grading");
        ColorGrading.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        MotionBlur = Config.Bind("07. Post-Processing", "Motion Blur", true, "Enable or disable Motion Blur");
        MotionBlur.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        Vignette = Config.Bind("07. Post-Processing", "Vignette", true, "Enable or disable Vignette");
        Vignette.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        AutoExposure = Config.Bind("07. Post-Processing", "Auto Exposure", true, "Enable or disable Auto Exposure");
        AutoExposure.SettingChanged += (_, _) => { UpdatePostProcessing(); };
        
        ChromaticAberration = Config.Bind("07. Post-Processing", "Chromatic Aberration", false,
            "Enable or disable Chromatic Aberration");
        ChromaticAberration.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        Grain = Config.Bind("07. Post-Processing", "Grain", false, "Enable or disable Grain");
        Grain.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        Bloom = Config.Bind("07. Post-Processing", "Bloom", true, "Enable or disable Bloom");
        Bloom.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        Crt = Config.Bind("07. Post-Processing", "CRT", true, "Enable or disable CRT effect");
        Crt.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        TVEffect = Config.Bind("07. Post-Processing", "TV Effect", false, "Enable or disable TV effect");
        TVEffect.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        PictureCorrection = Config.Bind("07. Post-Processing", "Picture Correction", true,
            "Enable or disable Picture Correction");
        PictureCorrection.SettingChanged += (_, _) => { UpdatePostProcessing(); };

        RunInBackground = Config.Bind("08. Misc", "Run In Background", true,
            new ConfigDescription("Allows the game to run even when not in focus.", null,
                new ConfigurationManagerAttributes { Order = 90 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };


        MuteInBackground = Config.Bind("08. Misc", "Mute In Background", false,
            new ConfigDescription("Mutes the game's audio when it is not in focus.", null,
                new ConfigurationManagerAttributes { Order = 89 }));


        Application.focusChanged += FocusChanged;


        UpdateAA();


        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateFollowCamera()
    {
        var cameras = Resources.FindObjectsOfTypeAll<CinemachineVirtualCamera>();
        foreach (var camera in cameras)
        {
            if (camera.GetPath().Contains("RoomCameras"))
            {
                camera.enabled = !FollowCamera.Value;
            }
        }
    }

    private static void UpdatePlayers()
    {
        var players = Resources.FindObjectsOfTypeAll<VideoPlayer>();
        foreach (var player in players)
        {
            player.aspectRatio = VideoAspectRatio.FitVertically;
        }
    }


    private static void UpdateDebug()
    {
        if (UnityDebug.Value)
        {
            KickStarter.settingsManager.showDebugLogs = ShowDebugLogs.Always;
            Debug.unityLogger.logEnabled = true;
        }
        else
        {
            KickStarter.settingsManager.showDebugLogs = ShowDebugLogs.Never;
            Debug.unityLogger.logEnabled = false;
        }
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
        try
        {
            if (WindowPositioner)
            {
                WindowPositioner.Start();
            }

            // Set the application to run in the background based on the configuration value
            Application.runInBackground = RunInBackground.Value;

            var res = ChosenResolution;
            Screen.SetResolution(res.width, res.height, FullScreenModeConfig.Value, res.refreshRate);
            Log.LogInfo("Set resolution to " + res.width + "x" + res.height + " @ " + res.refreshRate + "Hz");

            // Get the index of the desired quality preset
            var qualityIndex = QualitySettings.names.ToList().IndexOf(QualityPreset.Value);
            if (qualityIndex >= 0)
            {
                QualitySettings.SetQualityLevel(qualityIndex, true);
                Log.LogInfo("Set quality to " + QualityPreset.Value);
            }
            else
            {
                Log.LogWarning($"Quality preset '{QualityPreset.Value}' not found. Using default quality level.");
            }

            // Set anisotropic filtering
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value
                ? UnityEngine.AnisotropicFiltering.ForceEnable
                : UnityEngine.AnisotropicFiltering.Disable;

            Log.LogInfo("Set anisotropic filtering to " + (AnisotropicFiltering.Value ? "enabled" : "disabled"));

            // Set LOD bias
            QualitySettings.lodBias = 10.0f;
            Log.LogInfo("Set LOD bias to 10.0");


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
                    Log.LogWarning($"Unknown VSync option '{Vsync.Value}'. Keeping current settings.");
                    break;
            }

            Log.LogInfo("Set VSync to " + Vsync.Value);

            // Set antialiasing with validation
            int[] validAALevels = [0, 2, 4, 8];
            if (validAALevels.Contains(AntiAliasingNormal.Value))
            {
                QualitySettings.antiAliasing = AntiAliasingNormal.Value;
            }
            else
            {
                Log.LogWarning($"Invalid anti-aliasing value '{AntiAliasingNormal.Value}'. Setting to 0 (Off).");
                QualitySettings.antiAliasing = 0;
            }

            Log.LogInfo("Set anti-aliasing to " + AntiAliasingNormal.Value);
        }
        catch (Exception e)
        {
            Log.LogError("Error setting graphics quality settings: " + e.Message);
            // throw;
        }
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        Log.LogInfo("Scene loaded: " + a.name);
        UpdateDebug();

        if (SkipSplash.Value && a.name.Equals("HeadwareSplash"))
        {
            SceneManager.LoadScene("TitleMenu");
        }

        UpdateFixedDeltaTime();
        UpdateGraphicsQualitySettings();
        UpdateFollowCamera();
        UpdatePostProcessing();
        UpdateFirstPersonCamera();
        UpdatePlayers();
    }

    private static void UpdateFirstPersonCamera()
    {
        var cam = Resources.FindObjectsOfTypeAll<CinemachineVirtualCamera>().FirstOrDefault(a => a.name.Equals("C_FPV"));
        if (cam)
        {
            OriginalFirstPersonFieldOfView.Value = cam.m_Lens.FieldOfView;
            cam.m_Lens.FieldOfView = FirstPersonFOV.Value;
        }
    }

    private static void UpdatePostProcessing()
    {
        var ppv = Resources.FindObjectsOfTypeAll<PostProcessVolume>();
        foreach (var volume in ppv)
        {
            Patches.PostProcessVolume_OnEnable(volume);
        }
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(Screen.currentResolution.refreshRate, OriginalFixedDeltaTime.Value) ||
            OriginalFixedDeltaTime.Value > Screen.currentResolution.refreshRate)
        {
            Log.LogInfo(
                "Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / Screen.currentResolution.refreshRate;
            }
            else
            {
                Time.fixedDeltaTime =
                    1f / Utils.FindLowestFrameRateMultipleAboveFifty(Screen.currentResolution.refreshRate);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }
}