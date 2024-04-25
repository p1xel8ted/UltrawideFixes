namespace LittleGoodyTwoShoes;

[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log { get; set; }
    
    private static float BaseAspect => 16f / 9f;
    internal static int SixteenNineWidth => MainHeight * 16 / 9;
    private static float CurrentAspect => MainWidth / (float) MainHeight;
    internal static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static LightingLoader LightingLoaderInstance { get; set; }
    internal static ConfigEntry<float> CameraZoomConfigValue { get; private set; }
    internal static ConfigEntry<bool> CameraZoomConfig { get; private set; }
    private static ConfigEntry<float> PostProcessingStrength { get; set; }
    internal static ConfigEntry<bool> DialogueFrameConfig { get; private set; }
    private static ConfigEntry<bool> PauseFrameConfig { get; set; }
    internal static ConfigEntry<bool> TitleMenuVoiceOver { get; private set; }
    internal static ConfigEntry<bool> AutoAdvanceConfig { get; private set; }
    internal static ConfigEntry<bool> GoStraightToTitleMenu { get; private set; }
    
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static GameObject PauseFrame { get; set; }
    private static GameObject DialogueFrame { get; set; }
    // private static List<CanvasScaler> Scalers { get; set; } = [];
    internal static ProCamera2D ProCamera2DInstance { get; set; }

    private void Awake()
    {
        Log = Logger;
        
        // Category: Display Settings
        DisplayToUse = Config.Bind("01. Display Settings", "Display To Use", 0, new ConfigDescription("The display to use for the game. 0 is generally the main.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()),new ConfigurationManagerAttributes {Order = 21}));
        DisplayToUse.SettingChanged += (_, _) => ChangeResolution();
        
        // Category: Camera Settings
        CameraZoomConfig = Config.Bind("02. Camera Settings", "Enable Camera Zoom", true,
            new ConfigDescription("Enables or disables the camera zoom feature.",
                null, new ConfigurationManagerAttributes {Order = 20}));
        CameraZoomConfigValue = Config.Bind("02. Camera Settings", "Camera Zoom Level", 1f,
            new ConfigDescription("Adjusts the zoom level of the camera. Range: -5 to 5.",
                new AcceptableValueRange<float>(-5f, 5f), new ConfigurationManagerAttributes {Order = 19}));
        CameraZoomConfigValue.SettingChanged += (_, _) =>
        {
            if (!CameraZoomConfig.Value) return;
            if (Camera.main != null)
            {
                Camera.main.orthographicSize = 5f; // Trigger event
            }
        };
        PostProcessingStrength = Config.Bind("02. Camera Settings", "Post-Processing Intensity", 1f,
            new ConfigDescription("Controls the intensity of post-processing effects. 0% (off) to 100% (full strength).",
                new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes {Order = 18}));
        PostProcessingStrength.SettingChanged += (_, _) => UpdateLightingWeight();

        // Category: UI Customization
        PauseFrameConfig = Config.Bind("03. UI Customization", "Pause Menu Frame", true,
            new ConfigDescription("Enables or disables the decorative frame in the pause menu.",
                null, new ConfigurationManagerAttributes {Order = 19}));
        PauseFrameConfig.SettingChanged += (_, _) => UpdatePauseFrame();
        DialogueFrameConfig = Config.Bind("03. UI Customization", "Dialogue Window Frame", true,
            new ConfigDescription("Enables or disables the decorative frame in dialogue windows.",
                null, new ConfigurationManagerAttributes {Order = 18}));
        DialogueFrameConfig.SettingChanged += (_, _) => UpdateDialogueFrame();

        // Category: Gameplay Settings
        AutoAdvanceConfig = Config.Bind("04. Gameplay Settings", "Auto-Advance Dialogue", true,
            new ConfigDescription("Automatically advances dialogue in new conversations.",
                null, new ConfigurationManagerAttributes {Order = 20}));

        // Category: Startup Settings
        GoStraightToTitleMenu = Config.Bind("05. Startup Settings", "Go Straight To Menu", false,
            new ConfigDescription("Skips the intro anime and goes straight to the title menu on startup.",
                null, new ConfigurationManagerAttributes {Order = 20}));
        TitleMenuVoiceOver = Config.Bind("05. Startup Settings", "Title Menu Voiceover", false,
            new ConfigDescription("Enables or disables the voiceover on the title menu.",
                null, new ConfigurationManagerAttributes {Order = 19}));

        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 18}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 17}));
        
        Application.focusChanged += _ =>
        {
            if (MuteInBackground.Value)
            {
                AudioListener.pause = !Application.isFocused;
            }
            else
            {
                AudioListener.pause = false; 
            }
        };

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        SceneManager.sceneLoaded += OnSceneLoaded;
        Logger.LogInfo($"Plugin {Const.PluginName} is loaded!");
    }


    private static void ChangeResolution()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;
    }
    

    internal static void UpdateDialogueFrame()
    {
        DialogueFrame = GameObject.Find(Const.DialogueWindowFramePath);
        if (DialogueFrame != null)
        {
            DialogueFrame.SetActive(DialogueFrameConfig.Value);
        }
    }

    internal static void UpdatePauseFrame()
    {
        PauseFrame = GameObject.Find(Const.PauseMenuFramePath);
        if (PauseFrame != null)
        {
            PauseFrame.SetActive(PauseFrameConfig.Value);
        }
    }


    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        ChangeResolution();
        
        // Scalers = Resources.FindObjectsOfTypeAll<CanvasScaler>().ToList();
        // Scalers.RemoveAll(a => a.name.Equals(Const.ToastManager));
        // Scalers.RemoveAll(a => a.name.Equals(Const.TutorialCanvas));
        // Scalers.RemoveAll(a => a.gameObject.GetGameObjectPath().Contains(Const.TitleUI));
        // UpdateScalers();
        UpdatePauseFrame();
        UpdateDialogueFrame();
       // UpdateVideoPlayers();
    }


    // private static void UpdateVideoPlayers()
    // {
    //     var videoPlayers = Resources.FindObjectsOfTypeAll<VideoPlayer>();
    //     foreach (var videoPlayer in videoPlayers)
    //     {
    //         videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
    //     }
    // }

    public static void UpdateLightingWeight()
    {
        if (LightingLoaderInstance != null)
        {
            LightingLoaderInstance._currentVolume.weight = PostProcessingStrength.Value;
        }
    }

    private void OnDestroy()
    {
       Log.LogError($"Plugin {Const.PluginName} is unloading!");
    }
    
    private void OnDisable()
    {
        Log.LogError($"Plugin {Const.PluginName} is disabling!");
    }
}