namespace TailsOfIron;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.tailsofiron.uwfixes";
    private const string PluginName = "Tails of Iron Super Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const float BaseAspectRatio = 16f / 9f;
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

    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<PostProcessLayer.Antialiasing> AntiAliasing { get; private set; }
    private static ManualLogSource Log { get; set; }
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static float MainAspectRatio => Display.main.systemWidth / (float)Display.main.systemHeight;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static ConfigEntry<int> TargetFramerate { get; set; }
    public static ConfigEntry<bool> ShadowsMidtonesHighlights { get; private set; }
    public static ConfigEntry<bool> ColorCurves { get; private set; }
    public static ConfigEntry<bool> WhiteBalance { get; private set; }
    public static ConfigEntry<bool> ChromaticAberration { get; private set; }
    public static ConfigEntry<bool> FilmGrain { get; private set; }
    public static ConfigEntry<bool> LiftGammaGain { get; private set; }
    public static ConfigEntry<bool> ColorAdjustments { get; private set; }
    internal static float CurrentFixedDeltaTime { get; private set; }

    private void Awake()
    {
        var customRates = MergeUnityRefreshRates();
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };


        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix, may not be applicable to this particular game. May even cause unintended behaviour.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        AnisotropicFiltering = Config.Bind("02. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering."));
        AnisotropicFiltering.SettingChanged += (_, _) => { QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable; };

        Vignette = Config.Bind("03. Post-Processing", "Vignette", true, new ConfigDescription("Enable Vignette effect on the game screen."));
        Vignette.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };

        AntiAliasing = Config.Bind("03. Post-Processing", "Anti-Aliasing", PostProcessLayer.Antialiasing.TemporalAntialiasing, new ConfigDescription("Enable Anti-Aliasing effect on the game screen."));
        AntiAliasing.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };

        ShadowsMidtonesHighlights = Config.Bind("03. Post-Processing", "Shadows Midtones Highlights", true, new ConfigDescription("Enable Shadows Midtones Highlights effect on the game screen. Color Adjustments will be enabled as well."));
        ShadowsMidtonesHighlights.SettingChanged += (_, _) =>
        {
            if (ShadowsMidtonesHighlights.Value)
            {
                ColorAdjustments.Value = true;
            }

            Patches.UpdateVolumes();
        };

        ColorCurves = Config.Bind("03. Post-Processing", "Color Curves", true, new ConfigDescription("Enable Color Curves effect on the game screen. Color Adjustments will be enabled as well."));
        ColorCurves.SettingChanged += (_, _) =>
        {
            if (ColorCurves.Value)
            {
                ColorAdjustments.Value = true;
            }

            Patches.UpdateVolumes();
        };

        WhiteBalance = Config.Bind("03. Post-Processing", "White Balance", true, new ConfigDescription("Enable White Balance effect on the game screen. Color Adjustments will be enabled as well."));
        WhiteBalance.SettingChanged += (_, _) =>
        {
            if (WhiteBalance.Value)
            {
                ColorAdjustments.Value = true;
            }

            Patches.UpdateVolumes();
        };

        ChromaticAberration = Config.Bind("03. Post-Processing", "Chromatic Aberration", true, new ConfigDescription("Enable Chromatic Aberration effect on the game screen."));
        ChromaticAberration.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };

        FilmGrain = Config.Bind("03. Post-Processing", "Film Grain", true, new ConfigDescription("Enable Film Grain effect on the game screen."));
        FilmGrain.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };

        LiftGammaGain = Config.Bind("03. Post-Processing", "Lift Gamma Gain", true, new ConfigDescription("Enable Lift Gamma Gain effect on the game screen."));
        LiftGammaGain.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };

        ColorAdjustments = Config.Bind("03. Post-Processing", "Color Adjustments", true, new ConfigDescription("Enable Color Adjustments effect on the game screen."));
        ColorAdjustments.SettingChanged += (_, _) => { Patches.UpdateVolumes(); };

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 83 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));

        SceneManager.sceneLoaded += OnSceneLoaded;
        Application.focusChanged += FocusChanged;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static void UpdateDisplay()
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenModeConfig.Value, MaxRefresh);
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
        Application.runInBackground = RunInBackground.Value;
        Application.targetFrameRate = TargetFramerate.Value;

        UpdateFixedDeltaTime();

        Patches.UpdateVolumes();
    }

    internal static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0) return;

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh) return;

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

        CurrentFixedDeltaTime = Time.fixedDeltaTime;
    }
}