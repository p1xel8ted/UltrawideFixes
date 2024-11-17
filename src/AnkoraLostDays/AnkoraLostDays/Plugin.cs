namespace AnkoraLostDays;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.ankora.uwfixes";
    private const string PluginName = "Ankora Lost Days Ultra-Wide";
    private const string PluginVersion = "0.1.0";

 internal static ConfigEntry<bool> AmbientOcclusion { get; private set; }
    internal static ConfigEntry<bool> EyeAdaptation { get; private set; }
    internal static ConfigEntry<bool> DepthOfField { get; private set; }
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> ChromaticAberration { get; private set; }
    internal static ConfigEntry<bool> ColorGrading { get; private set; }


    internal static ConfigEntry<bool> Grain { get; private set; }

    // internal static ConfigEntry<bool> Fxaa { get; private set; }


    private static readonly float[] CustomRefreshRates =
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

    internal static float RefreshRate
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

    private static ManualLogSource Log { get; set; }
    private static float MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<float> CustomRefreshRate { get; set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth; //3440
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight; //1440
    private static ConfigEntry<int> PostProcessingUpdateInterval { get; set; }
    internal static ConfigEntry<bool> AnisotropicFiltering { get; private set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static ConfigEntry<float> TargetFramerate { get; set; }
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    public static ConfigEntry<float> Sharpen { get; private set; }

    private void Awake()
    {
        Debug.unityLogger.logEnabled = false;
        var customRates = MergeUnityRefreshRates();
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => { UpdateDisplay(); };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<float>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) => { UpdateDisplay(); };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<float>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => { UpdateDisplay(); };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("This is a generic Unity fix. Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 94 }));
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
        
        AnisotropicFiltering = Config.Bind("02. Performance", "Anisotropic Filtering", true, new ConfigDescription("Enables anisotropic filtering.", null, new ConfigurationManagerAttributes { Order = 92 }));
        AnisotropicFiltering.SettingChanged += (_, _) => { QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable; };

        PostProcessingUpdateInterval = Config.Bind("03. Post-Processing", "Post-Processing Update Interval", 1, new ConfigDescription("The interval in seconds between post-processing updates. 0 means updates will occur every frame which can be taxing.", new AcceptableValueRange<int>(0, 5), new ConfigurationManagerAttributes { Order = 92 }));

        AmbientOcclusion = Config.Bind("03. Post-Processing", "Ambient Occlusion", false, new ConfigDescription("Enables ambient occlusion.", null, new ConfigurationManagerAttributes { Order = 91 }));
        AmbientOcclusion.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };

        EyeAdaptation = Config.Bind("03. Post-Processing", "Eye Adaptation", false, new ConfigDescription("Enables eye adaptation.", null, new ConfigurationManagerAttributes { Order = 86 }));
        EyeAdaptation.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };

        DepthOfField = Config.Bind("03. Post-Processing", "Depth of Field", true, new ConfigDescription("Enables depth of field.", null, new ConfigurationManagerAttributes { Order = 85 }));
        DepthOfField.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };

        Bloom = Config.Bind("03. Post-Processing", "Bloom", false, new ConfigDescription("Enables bloom.", null, new ConfigurationManagerAttributes { Order = 84 }));
        Bloom.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };

        ChromaticAberration = Config.Bind("03. Post-Processing", "Chromatic Aberration", true, new ConfigDescription("Enables chromatic aberration.", null, new ConfigurationManagerAttributes { Order = 83 }));
        ChromaticAberration.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };

        ColorGrading = Config.Bind("03. Post-Processing", "Color Grading", true, new ConfigDescription("Enables color grading.", null, new ConfigurationManagerAttributes { Order = 82 }));
        ColorGrading.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };
        
        Grain = Config.Bind("03. Post-Processing", "Grain", false, new ConfigDescription("Enables grain.", null, new ConfigurationManagerAttributes { Order = 80 }));
        Grain.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };

        Sharpen = Config.Bind("03. Post-Processing", "Sharpen", 0.25f, new ConfigDescription("Sharpen the image.", new AcceptableValueRange<float>(0, 2), new ConfigurationManagerAttributes { Order = 96 }));
        Sharpen.SettingChanged += (_, _) => { Patches.UpdatePostProcessing(); };
        
        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 83 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));

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
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;

        Display.displays[DisplayToUse.Value].Activate();

        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, Mathf.RoundToInt(RefreshRate));

        Application.targetFrameRate = Mathf.RoundToInt(TargetFramerate.Value);
    }

    private static float[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions
            .Select(a => (float)a.refreshRate) // Convert double to float
            .Distinct()
            .ToArray();


        var customRates = new List<float>();
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
        Patches.UpdatePostProcessing();

        var camera = Camera.main;
        if (camera)
        {
            camera.gameObject.TryAddComponent<PpEnforcer>();
        }
    }


    public class PpEnforcer : MonoBehaviour
    {
        private PostProcessingBehaviour _ppb;
        private float _timer; // Timer to track elapsed time

        private void Start()
        {
            _ppb = GetComponent<PostProcessingBehaviour>();
        }

        private void Awake()
        {
            _ppb = GetComponent<PostProcessingBehaviour>();
        }

        private void OnEnable()
        {
            _ppb = GetComponent<PostProcessingBehaviour>();
        }

        private void Update()
        {
            _timer += Time.deltaTime; // Increment timer by time since last frame

            var parsedInterval = int.TryParse(PostProcessingUpdateInterval.Value.ToString(), out var interval);
            if (!parsedInterval)
            {
                Log.LogWarning("Failed to parse PostProcessingUpdateInterval. Using default value of 1.");
                interval = 1;
            }
            
            if (_timer >= interval) // Check if the interval has elapsed
            {
                _timer = 0f; // Reset timer

                if (!_ppb)
                {
                    _ppb = GetComponent<PostProcessingBehaviour>();
                }

                if (_ppb)
                {
                    Patches.PostProcessingBehaviour_Toggle(_ppb);
                }
            }
        }
    }
}