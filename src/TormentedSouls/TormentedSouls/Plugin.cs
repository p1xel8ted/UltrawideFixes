namespace TormentedSouls;

[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BasePlugin
{
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static WindowPositioner WindowPositioner { get; set; }
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ManualLogSource Logger { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    public static ConfigEntry<bool> RapidOldTVVignette { get; private set; }
    public static ConfigEntry<bool> TiltShiftBlur { get; private set; }
    public static ConfigEntry<bool> Sharpen { get; private set; }
    public static ConfigEntry<bool> Streak { get; private set; }
    public static ConfigEntry<bool> ColorAdjustments { get; private set; }
    public static ConfigEntry<bool> Bloom { get; private set; }
    public static ConfigEntry<bool> PostProcessingEffects { get; private set; }
    public static ConfigEntry<bool> AmbientOcclusion { get; private set; }
    public static ConfigEntry<bool> ScreenSpaceReflections { get; private set; }
    public static ConfigEntry<int> FieldOfView { get; private set; }


    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<FoVController>();

        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes {Order = 17}));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 16}));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        FieldOfView = Config.Bind("02. Camera", "Field of View", 0, new ConfigDescription("Adjust the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 100), new ConfigurationManagerAttributes {Order = 15}));

        CorrectFixedUpdateRate = Config.Bind("03. Performance", "Modify Physics Rate", false, new ConfigDescription("Adjust the fixed update rate to reduce camera judder based on your refresh rate. This may affect the game in unexpected ways.", null, new ConfigurationManagerAttributes {Order = 14}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => UpdateFixedDeltaTime();

        UseRefreshRateForFixedUpdateRate = Config.Bind("03. Performance", "Use Refresh Rate for Physics Rate", false, new ConfigDescription("Set the fixed update rate based on the monitor's refresh rate for smoother gameplay. May impact performance on lower-end systems.", null, new ConfigurationManagerAttributes {Order = 13}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => UpdateFixedDeltaTime();

        AnisotropicFiltering = Config.Bind("04. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering.", null, new ConfigurationManagerAttributes {Order = 12}));
        AnisotropicFiltering.SettingChanged += (_, _) => QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;

        PostProcessingEffects = Config.Bind("05. Post Processing", "Post Processing Effects", true, new ConfigDescription("Allow modification of Post Processing Effects. You can switch this off after making changes if you notice your FPS drop.", null, new ConfigurationManagerAttributes {Order = 11}));

        AmbientOcclusion = Config.Bind("06. Post Processing Effects", "Ambient Occlusion", true, new ConfigDescription("Enable Ambient Occlusion Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 10}));
        AmbientOcclusion.SettingChanged += (_, _) => EnablePostProcessEditing();

        Bloom = Config.Bind("06. Post Processing Effects", "Bloom", true, new ConfigDescription("Enable Bloom Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 9}));
        Bloom.SettingChanged += (_, _) => EnablePostProcessEditing();

        ColorAdjustments = Config.Bind("06. Post Processing Effects", "Color Adjustments", true, new ConfigDescription("Enable Color Adjustments Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 8}));
        ColorAdjustments.SettingChanged += (_, _) => EnablePostProcessEditing();

        RapidOldTVVignette = Config.Bind("06. Post Processing Effects", "Rapid Old TV Vignette", true, new ConfigDescription("Enable Rapid Old TV Vignette Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 7}));
        RapidOldTVVignette.SettingChanged += (_, _) => EnablePostProcessEditing();

        ScreenSpaceReflections = Config.Bind("06. Post Processing Effects", "Screen Space Reflections", true, new ConfigDescription("Enable Screen Space Reflections Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 6}));

        Sharpen = Config.Bind("06. Post Processing Effects", "Sharpen", true, new ConfigDescription("Enable Sharpen Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 5}));
        Sharpen.SettingChanged += (_, _) => EnablePostProcessEditing();

        Streak = Config.Bind("06. Post Processing Effects", "Streak", true, new ConfigDescription("Enable Streak Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 4}));
        Streak.SettingChanged += (_, _) => EnablePostProcessEditing();

        TiltShiftBlur = Config.Bind("06. Post Processing Effects", "Tilt Shift Blur", true, new ConfigDescription("Enable Tilt Shift Blur Post Processing Effect.", null, new ConfigurationManagerAttributes {Order = 3}));
        TiltShiftBlur.SettingChanged += (_, _) => EnablePostProcessEditing();

        RunInBackground = Config.Bind("07. Miscellaneous", "Run in Background", true, new ConfigDescription("Allow the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 2}));
        RunInBackground.SettingChanged += (_, _) => Application.runInBackground = RunInBackground.Value;

        MuteInBackground = Config.Bind("07. Miscellaneous", "Mute in Background", false, new ConfigDescription("Mute the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 1}));

        Application.focusChanged += new Action<bool>(_ => AudioListener.pause = MuteInBackground.Value && !Application.isFocused);

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        Logger.LogInfo($"Plugin {Const.PluginGuid} is loaded!");
    }


    private static void EnablePostProcessEditing()
    {
        if (!PostProcessingEffects.Value)
        {
            PostProcessingEffects.Value = true;
        }
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }
        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = 1f / Time.fixedDeltaTime;
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
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
        Logger.LogInfo($"Physics update rate set to {Mathf.RoundToInt(1f / Time.fixedDeltaTime)}Hz");
    }

    private static void UpdateGraphicsQualitySettings()
    {
        QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
        QualitySettings.antiAliasing = 8;
        QualitySettings.realtimeReflectionProbes = true;
        QualitySettings.softParticles = true;
        QualitySettings.particleRaycastBudget = 4096;
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;
        QualitySettings.lodBias = 10.0f;
        QualitySettings.maximumLODLevel = 0;
    }

    private static void DisableMetaDataCollectors()
    {
        string[] metaPaths =
        [
            "[LoadingCurtainsManager]/Canvas/CinematicBlackBars/BottomBar",
            "[LoadingCurtainsManager]/Canvas/CinematicBlackBars/TopBar",
            "FeedbackFrom/MetadataCollectors",
            "FeedbackFrom/MetadataCollectors/GraphicsInfoCollector",
            "FeedbackFrom/MetadataCollectors/PlayerInfoCollector",
            "FeedbackFrom/MetadataCollectors/SystemInfoCollector",
            "FeedbackFrom/MetadataCollectors/DebugLogCollector",
            "MainCanvas/OptionsMenuVIew/Panel/LegalLines",
            "MainCanvas/OptionsMenuVIew/Panel/version"
        ];

        foreach (var path in metaPaths)
        {
            var meta = GameObject.Find(path);
            if (!meta) continue;
            meta.SetActive(false);
        }
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        CheckIntroSkip(arg0);
        UpdateGraphicsQualitySettings();
        UpdateDisplay();
        UpdateFixedDeltaTime();
        DisableMetaDataCollectors();
        FixBackgrounds();
    }

    private static void CheckIntroSkip(Scene arg0)
    {
        if (arg0.name.Equals(Const.LogosInit) && (SteamManager.Initialized || SteamManager.Instance is null))
        {
            SceneManager.LoadScene(Const.MenuInit);
        }
    }
    private static void FixBackgrounds()
    {
        var backgrounds = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var background in backgrounds)
        {
            if (background.name.Equals(Const.Background) &&
                Mathf.Approximately(background.color.a, 0.949f) &&
                background.color is {r: 0, g: 0, b: 0})
            {
                background.transform.localScale = new Vector3(10, 1, 1);
            }
        }
    }
}