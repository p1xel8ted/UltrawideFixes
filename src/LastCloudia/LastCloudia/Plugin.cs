namespace LastCloudia;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.lastcloudia.ultrawide";
    private const string PluginName = "Last Cloudia Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    internal const float SuperWideAspectRatio = 32f / 9f;
    internal const float BaseAspectRatio = 16f / 9f;

    private readonly static string[] CutsceneCameras = ["AdapsBgCamera", "AdapsDollsCamera", "AdapsEnvCamera"];

    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    internal static float NegativeScaleFactor => BaseAspectRatio / MainAspectRatio;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    internal static ConfigEntry<bool> MuteInBackground { get; private set; }
    internal static ConfigEntry<int> CutsceneFieldOfView { get; private set; }
    internal static ConfigEntry<HudLayout> HudLayoutOption { get; private set; }
    internal static ConfigEntry<int> BattleFieldOfView { get; private set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<bool> UseNewMainMenu { get; private set; }
    internal static ManualLogSource Logger { get; private set; }

    public static ConfigFile ConfigInstance { get; private set; }
    public override void Load()
    {
        ConfigInstance = Config;
        Config.ConfigReloaded += (_, _) =>
        {
            Logger.LogInfo("Config reloaded!");
            UpdateDisplay();
        };
        
        Logger = Log;


        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        CutsceneFieldOfView = Config.Bind("02. Camera", "Cutscene Field of View", 75, new ConfigDescription("Increase or decrease the field of view of the camera. Default is around 55.", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 100}));

        BattleFieldOfView = Config.Bind("02. Camera", "Battle Field of View", 75, new ConfigDescription("Increase or decrease the field of view of the camera. Default is around 55.", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 101}));

        HudLayoutOption = Config.Bind("03. HUD", "HUD Layout", HudLayout.New, new ConfigDescription("Select the HUD layout. You need to restart the game after changing this setting.", null, new ConfigurationManagerAttributes {Order = 102}));

        UseNewMainMenu = Config.Bind("04. Misc", "Use New Main Menu", true, new ConfigDescription("Use the partially AI generated main menu (fills the screen at 21:9 and 32:9).", null, new ConfigurationManagerAttributes {Order = 103}));
        
        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;
        
        AddComponent<MonoBehaviours.MonoBehaviours>();
        ClassInjector.RegisterTypeInIl2Cpp<CameraEffectRootScaler>();
        ClassInjector.RegisterTypeInIl2Cpp<CutsceneCameraFieldOfViewEnforcer>();
        ClassInjector.RegisterTypeInIl2Cpp<BattleCameraFieldOfViewEnforcer>();
        
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = Plugin.RunInBackground.Value;
        var audioSources = Utils.FindIl2CppType<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
        
    }

    private static void DisableShadowEffects()
    {
        var rects = Utils.FindIl2CppType<RectTransform>();
        foreach (var rect in rects.Where(rect => rect.name.Equals("shadow_effect")))
        {
            rect.gameObject.SetActive(false);
        }
    }

    private static void UpdateCameras()
    {
        var cameras = Utils.FindIl2CppType<Camera>();
        foreach (var camera in cameras)
        {
            //Targeting Camera, we want to ignore this
            if (camera.name.Equals("TargetCamera")) continue;
            
            //Battle Cameras
            var path = camera.transform.GetFullPath();
            if (path.Contains("CameraRoot/Shake"))
            {
                camera.gameObject.TryAddComponent<BattleCameraFieldOfViewEnforcer>();
                camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            }
            
            if (!CutsceneCameras.Contains(camera.name)) continue;

            //adds a scaler to screen effects that get rendered the size of a mobile screen, so they fill the screen
            var cameraEffects = camera.transform.parent.FindChild("CameraEffectRoot");
            if (cameraEffects)
            {
                cameraEffects.gameObject.TryAddComponent<CameraEffectRootScaler>();
            }
            
            //Cutscene Cameras
            camera.gameObject.TryAddComponent<CutsceneCameraFieldOfViewEnforcer>();
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateCameras();
        DisableShadowEffects();
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Logger.LogInfo($"Display set to {MainWidth}x{MainHeight} @ {MaxRefresh}Hz");
    }

    internal enum HudLayout
    {
        Default,
        New,
        Mix
    }
}