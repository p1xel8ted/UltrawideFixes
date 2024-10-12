namespace SeaOfStars;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.seaofstars.ultrawide";
    private const string PluginName = "Sea of Stars Ultra-Wide";
    private const string PluginVersion = "0.3.0";
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspect => MainWidth / (float)MainHeight;
    internal static Rect CameraRect => new(0, 0, MainWidth, MainHeight);
    private static float NormalWidth => MainHeight * 16f / 9f; //2560
    internal static float PositiveScaleFactor => MainWidth / NormalWidth; //1.34375
    internal static float NegativeScaleFactor => 1 / PositiveScaleFactor; //0.74375
    internal static ManualLogSource Logger { get; private set; }

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

    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnceInt OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static float NativeAspectRatio => 16f / 9f;
    private static float CameraWidth => MainHeight * NativeAspectRatio;
    internal static float BlackBarSize => (MainWidth - CameraWidth) / 2f;

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Utils.FindIl2CppType<AudioSource>();
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


    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();

        Logger = Log;

        var customRates = MergeUnityRefreshRates();

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

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


        // Bloom = Config.Bind("02. Post-Processing", "Bloom", true, new ConfigDescription("Enable Bloom", null, new ConfigurationManagerAttributes { Order = 92 }));
        // Bloom.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };
        //
        // ToneMapping = Config.Bind("02. Post-Processing", "Tone Mapping", true, new ConfigDescription("Enable Tone Mapping", null, new ConfigurationManagerAttributes { Order = 91 }));
        // ToneMapping.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };
        //
        // Vignette = Config.Bind("02. Post-Processing", "Vignette", true, new ConfigDescription("Enable Vignette", null, new ConfigurationManagerAttributes { Order = 90 }));
        // Vignette.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };
        //
        // DepthOfField = Config.Bind("02. Post-Processing", "Depth of Field", true, new ConfigDescription("Enable Depth of Field", null, new ConfigurationManagerAttributes { Order = 89 }));
        // DepthOfField.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };
        //
        // SpanHud = Config.Bind("04. UI", "Span HUD", true, new ConfigDescription("Spans the HUD across the entire screen.", null, new ConfigurationManagerAttributes { Order = 88 }));
        //
        // FieldOfView = Config.Bind("05. Camera", "Field of View", Mathf.RoundToInt(24 * PositiveScaleFactor), new ConfigDescription("Increase or decrease the field of view of the camera.", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes { Order = 87 }));
        // FieldOfView.SettingChanged += (_, _) => { Patches.UpdateCamera(); };
        //
        // ShowStaff = Config.Bind("06. Equipment", "Show Staff", true, new ConfigDescription("Show Staff", null, new ConfigurationManagerAttributes { Order = 86 }));
        // ShowSkirt = Config.Bind("06. Equipment", "Show Skirt", true, new ConfigDescription("Show Skirt", null, new ConfigurationManagerAttributes { Order = 85 }));
        // ShowHat = Config.Bind("06. Equipment", "Show Hat", true, new ConfigDescription("Show Hat", null, new ConfigurationManagerAttributes { Order = 84 }));
        // ShowRobe = Config.Bind("06. Equipment", "Show Robe", true, new ConfigDescription("Show Robe", null, new ConfigurationManagerAttributes { Order = 83 }));


        RunInBackground = Config.Bind("07. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("07. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

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


    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;

        Display.displays[DisplayToUse.Value].Activate();

        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);

        Application.targetFrameRate = TargetFramerate.Value;
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals("InitialScene"))
        {
            Time.timeScale = 10000f;
        }

        UpdateDisplay();
        UpdateFixedDeltaTime();
    }
}