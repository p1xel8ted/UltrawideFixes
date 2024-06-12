namespace LifeIsStrangeBTSR;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.lifeisstrangebtsrm.ultrawide";
    private const string PluginName = "Life is Strange: Before the Storm Remastered Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ManualLogSource Logger { get; set; }
    private static ConfigEntry<bool> Vignette { get; set; }
    private static ConfigEntry<bool> Chromatic { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    public static ConfigEntry<int> FieldOfView { get; private set; }
    
    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes {Order = 17}));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 16}));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        FieldOfView = Config.Bind("02. Camera", "Field of View", 0, new ConfigDescription("Adjust the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 200), new ConfigurationManagerAttributes {Order = 15}));
        FieldOfView.SettingChanged += (_, _) => UpdateFoV();

        AnisotropicFiltering = Config.Bind("03. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering.", null, new ConfigurationManagerAttributes {Order = 12}));
        AnisotropicFiltering.SettingChanged += (_, _) => QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;

        Vignette = Config.Bind("04. Post Processing", "Vignette", false, new ConfigDescription("Enable Vignette.", null, new ConfigurationManagerAttributes {Order = 10}));
        Vignette.SettingChanged += (_, _) => UpdatePostProcessing();

        Chromatic = Config.Bind("04. Post Processing", "Chromatic Aberration", false, new ConfigDescription("Enable Chromatic Aberration.", null, new ConfigurationManagerAttributes {Order = 9}));
        Chromatic.SettingChanged += (_, _) => UpdatePostProcessing();

        RunInBackground = Config.Bind("05. Miscellaneous", "Run in Background", true, new ConfigDescription("Allow the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 2}));
        RunInBackground.SettingChanged += (_, _) => Application.runInBackground = RunInBackground.Value;

        MuteInBackground = Config.Bind("05. Miscellaneous", "Mute in Background", false, new ConfigDescription("Mute the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 1}));

        Application.focusChanged += new Action<bool>(_ => AudioListener.pause = MuteInBackground.Value && !Application.isFocused);

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginGuid} is loaded!");
    }
    internal static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }
        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        UpdateCameraAspects();
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateCameraAspects();
        UpdateFoV();
        UpdatePostProcessing();
    }

    private static void UpdateFoV()
    {
        Patches.UpdateCamerasFoV();
    }

    private static void UpdatePostProcessing()
    {
        var postProcessing = Utils.FindIl2CppType<PostProcessingBehaviour>();
        foreach (var pp in postProcessing)
        {
            pp.profile.vignette.enabled = Vignette.Value;
            pp.profile.chromaticAberration.enabled = Chromatic.Value;
        }
    }
    private static void UpdateCameraAspects()
    {
        var cameras = Utils.FindIl2CppType<Camera>();
        foreach (var cam in cameras)
        {
            cam.aspect = MainWidth / (float) MainHeight;
            cam.rect = new Rect(0, 0, 1, 1);
            cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
        }
    }

}