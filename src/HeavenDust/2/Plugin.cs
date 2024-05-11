namespace HeavenDustTwo;

[BepInPlugin(PluginGuid, PluginName, PluginVer)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.heavendust.two";
    private const string PluginName = "Heaven Dust 2 Ultra-Wide";
    private const string PluginVer = "0.1.3";
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ConfigEntry<bool> CameraOverlay { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> ChromaticAberration { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> FogOfWar { get; private set; }
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> AlternateUiScaleMode { get; private set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> FieldOfView { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ManualLogSource Log { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }

    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode",null, new ConfigurationManagerAttributes {Order = 109}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 108}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

       
        FieldOfView = Config.Bind("02. Camera", "Field of View", 0, new ConfigDescription("Increase or decrease the field of view of the camera.", new AcceptableValueRange<int>(-50, 100), new ConfigurationManagerAttributes {Order = 107}));
        FieldOfView.SettingChanged += (_, _) =>
        {
            UpdateCamera();
        };

        CameraOverlay = Config.Bind("02. Camera", "Camera Overlay", true, new ConfigDescription("Hide the camera overlay.", null, new ConfigurationManagerAttributes {Order = 105}));


        Vignette = Config.Bind("03. Post-Processing", "Vignette", true, new ConfigDescription("Disable the vignette effect.", null, new ConfigurationManagerAttributes {Order = 104}));
        ChromaticAberration = Config.Bind("03. Post-Processing", "Chromatic Aberration", true, new ConfigDescription("Disable the chromatic aberration effect.", null, new ConfigurationManagerAttributes {Order = 103}));
        FogOfWar = Config.Bind("03. Post-Processing", "Fog of War", true, new ConfigDescription("Disable the fog of war effect.", null, new ConfigurationManagerAttributes {Order = 102}));
        Bloom = Config.Bind("03. Post-Processing", "Bloom", true, new ConfigDescription("Disable the bloom effect.", null, new ConfigurationManagerAttributes {Order = 101}));
       
        CorrectFixedUpdateRate = Config.Bind("04. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate.", null, new ConfigurationManagerAttributes {Order = 101}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };
        UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 100}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };
        
        AlternateUiScaleMode = Config.Bind("05. UI", "Alternate UI Scale Mode", false, new ConfigDescription("Use a different UI scale mode.", null, new ConfigurationManagerAttributes {Order = 99}));
        
        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 97}));


        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
        UpdateCamera();
        UpdateFixedDeltaTime();
    }

    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        Log.LogInfo($"Original FDT: {OriginalFixedDeltaTime.Value}");
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
                Time.fixedDeltaTime = 1f / Misc.Utils.FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }
        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }


    private static void UpdateCamera()
    {
        if (!Camera.main) return;
        
        var pct = FieldOfView.Value / 100f;
        Camera.main.fieldOfView = 36f + 36f * pct;
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
}