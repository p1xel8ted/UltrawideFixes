namespace EverafterFalls;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.everafterfalls.ultrawide";
    private const string PluginName = "Everafter Falls Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> CameraZoom { get; private set; }
    internal static ConfigEntry<int> CutsceneCameraZoom { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<CanvasScaler.ScreenMatchMode> ScreenMatchMode { get; private set; }
    internal static ConfigEntry<CanvasScaler.ScaleMode> ScaleMode { get; private set; }
    internal static ConfigEntry<float> ScaleFactor { get; private set; }
    internal static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Log { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    internal static WriteOnce<float> OriginalFixedDeltaTime { get; } = new();
    public static ConfigEntry<float> ActionBarScaleFactor { get; set; }
    public static ConfigEntry<float> HUDScaleFactor { get; set; }

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 103}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        ScaleMode = Config.Bind("02. Scaling", "Scaling Mode", CanvasScaler.ScaleMode.ScaleWithScreenSize, new ConfigDescription("The scaling mode to use for the CanvasScaler component. Switch to ConstantPixelSize if you wish to modify the UI scale.", null, new ConfigurationManagerAttributes {Order = 95}));
        ScreenMatchMode = Config.Bind("02. Scaling", "Canvas Scaler Screen Match Mode", CanvasScaler.ScreenMatchMode.Expand, new ConfigDescription("The screen match mode to use for the CanvasScaler component. Has no effect unless Scale Mode is set to ScaleWithScreenSize.", null, new ConfigurationManagerAttributes {Order = 94}));
        ScaleFactor = Config.Bind("02. Scaling", "General Scale Factor", 1f, new ConfigDescription("Controls the scale of menus and dialogs. Probably other things. Has no effect when Scale Mode is set to ScaleWithScreenSize.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 93}));
        ScaleFactor.SettingChanged += (_, _) =>
        {
            ScaleFactor.Value = Mathf.Round(ScaleFactor.Value * 4) / 4;
        };

        ActionBarScaleFactor = Config.Bind("02. Scaling", "Action Bar Scale", 1f, new ConfigDescription("Controls the scale of the players action/toolbar. Has no effect when Scale Mode is set to ScaleWithScreenSize.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 92}));
        ActionBarScaleFactor.SettingChanged += (_, _) =>
        {
            ActionBarScaleFactor.Value = Mathf.Round(ActionBarScaleFactor.Value * 4) / 4;
        };

        HUDScaleFactor = Config.Bind("02. Scaling", "HUD Scale", 1f, new ConfigDescription("Controls the scale of the HUD (top of the screen). Has no effect when Scale Mode is set to ScaleWithScreenSize.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 91}));
        HUDScaleFactor.SettingChanged += (_, _) =>
        {
            HUDScaleFactor.Value = Mathf.Round(HUDScaleFactor.Value * 4) / 4;
        };

        CameraZoom = Config.Bind("03. Camera", "Camera Zoom", 1, new ConfigDescription("Zoom level. The first 3 options are the games default values.", new AcceptableValueList<int>(0, 1, 2, 3, 4, 5), new ConfigurationManagerAttributes {Order = 93}));
        CameraZoom.SettingChanged += (_, _) =>
        {
            UpdateZoom();
        };

        CutsceneCameraZoom = Config.Bind("03. Camera", "Cutscene Camera Zoom", 1, new ConfigDescription("Zoom level for cutscenes. Option 0 is the games default value.", new AcceptableValueList<int>(0, 1, 2, 3, 4, 5), new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate = Config.Bind("04. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 91}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        RunInBackground = Config.Bind("05. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 90}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("05. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));

        Application.focusChanged += FocusChanged;


        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
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

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
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
        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateDisplay()
    {
        // Check if WindowPositioner is not null and start it if necessary
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        // Set the application to run in the background based on the configuration value
        Application.runInBackground = RunInBackground.Value;

        // Set the target frame rate to the maximum refresh rate
        Application.targetFrameRate = MaxRefresh;

        // Activate the specified display
        Display.displays[DisplayToUse.Value].Activate();

        // Set the screen resolution based on the configuration
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);

        UpdateZoom();
    }

    internal static void UpdateZoom()
    {
        if (!Singleton<GameManager>.Instance) return;

        if (!Singleton<GameManager>.Instance.InGame)
        {
            return;
        }
        if (!Singleton<GameManager>.Instance.InPlay)
        {
            return;
        }
        Singleton<SettingsData>.Instance.CameraZoom = CameraZoom.Value;
        
        var cameraZoom = Singleton<MultiplayerSplitCameraRig>.Instance.cameraZooms[CameraZoom.Value];
        var cutsceneZoom = Singleton<MultiplayerSplitCameraRig>.Instance.cameraZooms[CutsceneCameraZoom.Value];
        Singleton<MultiplayerSplitCameraRig>.Instance.cameraZoomCustscene = cutsceneZoom;
        Singleton<MultiplayerSplitCameraRig>.Instance.updateCameraZoom(cameraZoom);
    }

}