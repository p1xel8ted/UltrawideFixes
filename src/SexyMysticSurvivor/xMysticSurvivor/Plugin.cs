namespace xMysticSurvivor;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.sexymysticsurvivor.xmysticsurvivor";
    private const string PluginName = "Beautiful/Sexy Mystic Survivors Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    
    private const float BaseAspectRatio = 16f / 9f;
    internal static ManualLogSource LOG { get; private set; }
    private static float NativeWidth => MainHeight * BaseAspectRatio;
    internal static float MainAspect => (float) MainWidth / MainHeight;
    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2;
    internal static float PositiveScaleFactor => MainAspect / BaseAspectRatio;
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static ConfigEntry<bool> IncreaseCameraZoom { get; set; }
    private static ConfigEntry<int> MaxZoomOut { get; set; }
    internal static ConfigEntry<float> CurrentZoomLevel { get; private set; }
    internal static ConfigEntry<bool> StopTransparentTrees { get; private set; }
    internal static ConfigEntry<bool> AutoOpenChests { get; private set; }
    internal static CameraZoomer CameraZoomer { get; set; }
    internal static ConfigEntry<bool> LevelUpVoice { get; private set; }
    internal static ConfigEntry<bool> CollectCrystalsSound { get; private set; }
    internal static ConfigEntry<float> LevelUpVoiceVolume { get; private set; }
    internal static ConfigEntry<float> CollectCrystalsVolume { get; private set; }
    internal static ConfigEntry<float> SunStoneVolume { get; private set; }

    private void Awake()
    {
        LOG = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 112}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 111}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        CurrentZoomLevel = Config.Bind("0. Hidden", "CurrentZoomLevel", 0.0f,
            new ConfigDescription("Current Zoom Level", null,
                new ConfigurationManagerAttributes {Browsable = false, Order = 110}));
        
        IncreaseCameraZoom = Config.Bind("02. Camera Zoom", "Increase Camera Zoom", true,
            new ConfigDescription("Enable or disable increased camera zoom. When enabled, you can zoom out further than the default limit.", null,
                new ConfigurationManagerAttributes {Order = 109}));
        IncreaseCameraZoom.SettingChanged += (_, _) =>
        {
            SetZoom();
        };

        MaxZoomOut = Config.Bind("02. Camera Zoom", "Max Zoom Out", 10,
            new ConfigDescription("Set the maximum zoom-out level. This determines how far out you can zoom. The game's default level is 10. Zooming too far will expose un-rendered areas.", new AcceptableValueRange<int>(2, 20),
                new ConfigurationManagerAttributes {Order = 108}));
        MaxZoomOut.SettingChanged += (_, _) =>
        {
            SetZoom();
        };

        LevelUpVoice = Config.Bind("03. Sound", "Level Up Voice", true,
            new ConfigDescription("Enable or disable the level up voice sound. Check the box to enable the sound, uncheck to disable it.", null,
                new ConfigurationManagerAttributes {Order = 107}));
       
        LevelUpVoiceVolume = Config.Bind("03. Sound", "Level Up Voice Volume", 0f,
            new ConfigDescription("Adjust the level up voice volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                new ConfigurationManagerAttributes {Order = 106}));

        CollectCrystalsSound = Config.Bind("03. Sound", "Collect Crystals", true,
            new ConfigDescription("Enable or disable the crystal collection sound. Check the box to enable the sound, uncheck to disable it.", null,
                new ConfigurationManagerAttributes {Order = 105}));
        CollectCrystalsVolume = Config.Bind("03. Sound", "Collect Crystal Volume", 0f,
            new ConfigDescription("Adjust the collect crystal volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                new ConfigurationManagerAttributes {Order = 104}));

        SunStoneVolume = Config.Bind("03. Sound", "Sun Stone Volume", 0f,
            new ConfigDescription("Adjust the sun stone volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                new ConfigurationManagerAttributes {Order = 103}));

        StopTransparentTrees = Config.Bind("04. Misc", "Stop Transparent Trees", true,
            new ConfigDescription("Prevent trees from becoming transparent when the camera is close or zooming in.", null,
                new ConfigurationManagerAttributes {Order = 102}));
        AutoOpenChests = Config.Bind("04. Misc", "Auto Open Chests", true,
            new ConfigDescription("Automatically open chests when the dialog appears.", null,
                new ConfigurationManagerAttributes {Order = 101}));
        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", true, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        AudioListener.pause = !focus && MuteInBackground.Value;
    }
    
    internal static void SetZoom()
    {
        if (!CameraZoomer) return;
        if (IncreaseCameraZoom.Value)
        {
            CameraZoomer.MaxZoomValue = 1f;
            CameraZoomer.MinZoomValue = MaxZoomOut.Value;
        }
        else
        {
            CameraZoomer.MaxZoomValue = 6f;
            CameraZoomer.MinZoomValue = 10f;
        }
    }
    

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

   

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        var menuBackground = GameObject.Find("CanvasWorld/BackgroundComp/BackgroundImage2");
        if (menuBackground)
        {
            menuBackground.ResizeRect();
            menuBackground.transform.position = new Vector3(0, 0, -10f);
        }
        
        var disableMe = GameObject.Find("CanvasCamera/WrapperCC/holder");
        if (disableMe)
        {
            disableMe.SetActive(false);
        }

        //disable the left and right black bars
        var leftPane = GameObject.Find("CanvasOverlay/ScreenWrapper/OVERLAY_PLANE_LEFT");
        if (leftPane)
        {
            leftPane.SetActive(false);
        }

        var rightPane = GameObject.Find("CanvasOverlay/ScreenWrapper/OVERLAY_PLANE_RIGHT");
        if (rightPane)
        {
            rightPane.SetActive(false);
        }
        
    }

}