namespace TheLastCampfire;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.thelastcampfire.ultrawide";
    private const string PluginName = "The Last Campfire Ultra-Wide";
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

    private static ManualLogSource Log { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static float NativeAspectRatio => 16f / 9f; // 1.77777777778

    private static float CameraWidth => MainHeight * NativeAspectRatio; // 1440 * 16/9 = 2560
    // internal static float BlackBarSize => (MainWidth - CameraWidth) / 2f; // (3440 - 2560) / 2 = 440
    // internal static float MainAspectRatio => MainWidth / (float)MainHeight; // 3440 / 1440 = 2.38889
    internal static float WithDifference => MainWidth - CameraWidth; // 3440 - 2560 = 880
    internal static ConfigEntry<bool> RestrictHUD { get; private set; }
    // internal static float PositiveScaleFactor => MainAspectRatio / NativeAspectRatio;

    public static ConfigEntry<bool> DebugViews { get; private set; }
    public static ConfigEntry<bool> AmbientOcclusion { get; private set; }
    public static ConfigEntry<float> AmbientOcclusionIntensity { get; private set; } // Adjustment for Ambient Occlusion
    public static ConfigEntry<bool> ScreenSpaceReflection { get; private set; }
    private static ConfigEntry<ScreenSpaceReflectionModel.SSRResolution> ScreenSpaceReflectionQuality { get; set; } // SSR quality adjustment
    public static ConfigEntry<bool> Fog { get; private set; }
    public static ConfigEntry<bool> MotionBlur { get; private set; }
    public static ConfigEntry<float> MotionBlurStrength { get; private set; } // Adjustment for Motion Blur
    public static ConfigEntry<bool> Taa { get; private set; }
    public static ConfigEntry<float> TaaSharpness { get; private set; } // Adjustment for TAA sharpness
    public static ConfigEntry<bool> EyeAdaptation { get; private set; }
    public static ConfigEntry<bool> DepthOfField { get; private set; }
    public static ConfigEntry<float> DepthOfFieldFocusDistance { get; private set; } // Adjustment for Depth of Field
    public static ConfigEntry<bool> Bloom { get; private set; }
    public static ConfigEntry<float> BloomIntensity { get; private set; } // Adjustment for Bloom intensity
    public static ConfigEntry<float> BloomDirtIntensity { get; private set; } // Adjustment for Bloom dirt intensity
    public static ConfigEntry<bool> ChromaticAberration { get; private set; }
    public static ConfigEntry<float> ChromaticAberrationIntensity { get; private set; } // Adjustment for Chromatic Aberration
    public static ConfigEntry<bool> UserLut { get; private set; }
    public static ConfigEntry<bool> Grain { get; private set; }
    public static ConfigEntry<float> GrainIntensity { get; private set; } // Adjustment for Grain intensity
    public static ConfigEntry<bool> Vignette { get; private set; }
    public static ConfigEntry<float> VignetteIntensity { get; private set; } // Adjustment for Vignette intensity
    public static ConfigEntry<bool> Dithering { get; private set; }
    public static ConfigEntry<bool> Fxaa { get; private set; }

    private void Awake()
{
    var customRates = MergeUnityRefreshRates();
    Log = Logger;

    FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 500 }));
    FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

    DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 499 }));
    DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

    if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
    {
        WindowPositioner = gameObject.AddComponent<WindowPositioner>();
    }

    UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 498 }));
    UseCustomRefreshRate.SettingChanged += (_, _) =>
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    };

    CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 497 }));
    CustomRefreshRate.SettingChanged += (_, _) =>
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    };

    TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 496 }));
    TargetFramerate.SettingChanged += (_, _) =>
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    };

    CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", false, new ConfigDescription("Adjusts the fixed update rate to reduce camera judder based on your refresh rate.", null, new ConfigurationManagerAttributes { Order = 495 }));
    CorrectFixedUpdateRate.SettingChanged += (_, _) =>
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    };

    UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false, new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay.", null, new ConfigurationManagerAttributes { Order = 494 }));
    UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
    };

    RestrictHUD = Config.Bind("03. UI", "Restrict HUD", false, new ConfigDescription("Restrict the HUD to 16:9.", null, new ConfigurationManagerAttributes { Order = 493 }));
    RestrictHUD.SettingChanged += (_, _) => { Utils.UpdateHUD(); };

    DebugViews = Config.Bind("04. Post-Processing", "DebugViews", true, new ConfigDescription("Enable or disable Debug Views.", null, new ConfigurationManagerAttributes { Order = 492 }));
    AmbientOcclusion = Config.Bind("04. Post-Processing", "AmbientOcclusion", false, new ConfigDescription("Enable or disable Ambient Occlusion.", null, new ConfigurationManagerAttributes { Order = 491 }));
    AmbientOcclusionIntensity = Config.Bind("04. Post-Processing", "AmbientOcclusionIntensity", 1.0f, new ConfigDescription("Adjust the intensity of Ambient Occlusion.", new AcceptableValueRange<float>(0.0f, 3.0f), new ConfigurationManagerAttributes { Order = 490 }));
    ScreenSpaceReflection = Config.Bind("04. Post-Processing", "ScreenSpaceReflection", false, new ConfigDescription("Enable or disable Screen Space Reflection.", null, new ConfigurationManagerAttributes { Order = 489 }));
    ScreenSpaceReflectionQuality = Config.Bind("04. Post-Processing", "ScreenSpaceReflectionQuality", ScreenSpaceReflectionModel.SSRResolution.High, new ConfigDescription("Adjust the quality of Screen Space Reflection.", null, new ConfigurationManagerAttributes { Order = 488 }));
    Fog = Config.Bind("04. Post-Processing", "Fog", true, new ConfigDescription("Enable or disable Fog.", null, new ConfigurationManagerAttributes { Order = 487 }));
    MotionBlur = Config.Bind("04. Post-Processing", "MotionBlur", false, new ConfigDescription("Enable or disable Motion Blur.", null, new ConfigurationManagerAttributes { Order = 486 }));
    MotionBlurStrength = Config.Bind("04. Post-Processing", "MotionBlurStrength", 0.5f, new ConfigDescription("Adjust the strength of Motion Blur.", new AcceptableValueRange<float>(0.0f, 1.0f), new ConfigurationManagerAttributes { Order = 485 }));
    Taa = Config.Bind("04. Post-Processing", "Taa", false, new ConfigDescription("Enable or disable Temporal Anti-Aliasing (TAA).", null, new ConfigurationManagerAttributes { Order = 484 }));
    TaaSharpness = Config.Bind("04. Post-Processing", "TaaSharpness", 0.8f, new ConfigDescription("Adjust the sharpness of TAA.", new AcceptableValueRange<float>(0.0f, 1.0f), new ConfigurationManagerAttributes { Order = 483 }));
    EyeAdaptation = Config.Bind("04. Post-Processing", "EyeAdaptation", false, new ConfigDescription("Enable or disable Eye Adaptation.", null, new ConfigurationManagerAttributes { Order = 482 }));
    DepthOfField = Config.Bind("04. Post-Processing", "DepthOfField", false, new ConfigDescription("Enable or disable Depth of Field.", null, new ConfigurationManagerAttributes { Order = 481 }));
    DepthOfFieldFocusDistance = Config.Bind("04. Post-Processing", "DepthOfFieldFocusDistance", 10.0f, new ConfigDescription("Adjust the focus distance for Depth of Field.", new AcceptableValueRange<float>(0.0f, 100.0f), new ConfigurationManagerAttributes { Order = 480 }));
    Bloom = Config.Bind("04. Post-Processing", "Bloom", true, new ConfigDescription("Enable or disable Bloom.", null, new ConfigurationManagerAttributes { Order = 479 }));
    BloomIntensity = Config.Bind("04. Post-Processing", "BloomIntensity", 1.0f, new ConfigDescription("Adjust the intensity of Bloom.", new AcceptableValueRange<float>(0.0f, 2.0f), new ConfigurationManagerAttributes { Order = 478 }));
    BloomDirtIntensity = Config.Bind("04. Post-Processing", "BloomDirtIntensity", 1.0f, new ConfigDescription("Adjust the intensity of Bloom dirt.", new AcceptableValueRange<float>(0.0f, 2.0f), new ConfigurationManagerAttributes { Order = 477 }));
    ChromaticAberration = Config.Bind("04. Post-Processing", "ChromaticAberration", false, new ConfigDescription("Enable or disable Chromatic Aberration.", null, new ConfigurationManagerAttributes { Order = 476 }));
    ChromaticAberrationIntensity = Config.Bind("04. Post-Processing", "ChromaticAberrationIntensity", 0.2f, new ConfigDescription("Adjust the intensity of Chromatic Aberration.", new AcceptableValueRange<float>(0.0f, 1.0f), new ConfigurationManagerAttributes { Order = 475 }));
    UserLut = Config.Bind("04. Post-Processing", "UserLut", false, new ConfigDescription("Enable or disable User LUT (Lookup Table).", null, new ConfigurationManagerAttributes { Order = 474 }));
    Grain = Config.Bind("04. Post-Processing", "Grain", false, new ConfigDescription("Enable or disable Grain.", null, new ConfigurationManagerAttributes { Order = 473 }));
    GrainIntensity = Config.Bind("04. Post-Processing", "GrainIntensity", 0.5f, new ConfigDescription("Adjust the intensity of Grain.", new AcceptableValueRange<float>(0.0f, 1.0f), new ConfigurationManagerAttributes { Order = 472 }));
    Vignette = Config.Bind("04. Post-Processing", "Vignette", true, new ConfigDescription("Enable or disable Vignette.", null, new ConfigurationManagerAttributes { Order = 471 }));
    VignetteIntensity = Config.Bind("04. Post-Processing", "VignetteIntensity", 0.5f, new ConfigDescription("Adjust the intensity of Vignette.", new AcceptableValueRange<float>(0.0f, 1.0f), new ConfigurationManagerAttributes { Order = 470 }));
    Dithering = Config.Bind("04. Post-Processing", "Dithering", false, new ConfigDescription("Enable or disable Dithering.", null, new ConfigurationManagerAttributes { Order = 469 }));
    Fxaa = Config.Bind("04. Post-Processing", "Fxaa", false, new ConfigDescription("Enable or disable Fast Approximate Anti-Aliasing (FXAA).", null, new ConfigurationManagerAttributes { Order = 468 }));

    AttachSettingChangedEvents();

    RunInBackground = Config.Bind("05. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 467 }));
    RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

    Application.runInBackground = RunInBackground.Value;

    MuteInBackground = Config.Bind("05. Misc", "Mute In Background", true, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 466 }));

    SceneManager.sceneLoaded += OnSceneLoaded;
    Application.focusChanged += FocusChanged;
    Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    Log.LogInfo($"Plugin {PluginName} is loaded!");
}


    private static void AttachSettingChangedEvents()
    {
        DebugViews.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        AmbientOcclusion.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        AmbientOcclusionIntensity.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        ScreenSpaceReflection.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        ScreenSpaceReflectionQuality.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Fog.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        MotionBlur.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        MotionBlurStrength.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Taa.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        TaaSharpness.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        EyeAdaptation.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        DepthOfField.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        DepthOfFieldFocusDistance.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Bloom.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        BloomIntensity.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        BloomDirtIntensity.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        ChromaticAberration.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        ChromaticAberrationIntensity.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        UserLut.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Grain.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        GrainIntensity.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Vignette.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        VignetteIntensity.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Dithering.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
        Fxaa.SettingChanged += (_, _) => { Patches.UpdateEffects = true; };
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
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


    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Log.LogInfo($"Scene loaded: {arg0.name}");
        UpdateDisplay();
        Utils.UpdateHUD();
        UpdateFixedDeltaTime();
        Patches.UpdateEffects = true;
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

        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);

        Application.targetFrameRate = TargetFramerate.Value;
    }
}