namespace TurnipBoyCommitsTaxEvasion;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.turnipboycommitstaxevasion.ultrawide";
    private const string PluginName = "Turnip Boy Commits Tax Evasion Ultra-Wide";
    private const string PluginVersion = "0.1.2";

    internal static ConfigEntry<float> NpcChatDialogScale { get; private set; }
    internal static ConfigEntry<float> NpcChatDialogPosition { get; private set; }
    private static ConfigEntry<float> CameraZoom { get; set; }
    internal static ConfigEntry<float> MoveSpeed { get; private set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdate { get; set; }

    private static ManualLogSource Log { get; set; }

    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }

    private static IEnumerable<string> FastForwardThese { get; } = ["Snoozy", "fblk", "Graffiti", "Partners", "FMOD", "Warning"];
    
    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode",null, new ConfigurationManagerAttributes {Order = 100}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            RunDisplayFixes();
        };
        DisplayToUse = Config.Bind("01. Display", "Display Selection", 0, new ConfigDescription("Select the monitor to be used for display.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 99}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            RunDisplayFixes();
        };
        RunInBackground = Config.Bind("01. Display", "Background Running", true, new ConfigDescription("Allow the game to continue running when it is not the active window.", null, new ConfigurationManagerAttributes {Order = 98}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };
        NpcChatDialogScale = Config.Bind("02. User Interface", "NPC Chat Scale", 0.75f, new ConfigDescription("Adjusts the scale of NPC dialog boxes.", new AcceptableValueRange<float>(0.1f, 2f), new ConfigurationManagerAttributes {Order = 97}));
        NpcChatDialogPosition = Config.Bind("02. User Interface", "NPC Chat Vertical Position", 0f, new ConfigDescription("Sets the vertical position of NPC chat dialog boxes.", new AcceptableValueRange<float>(-1000, 1000), new ConfigurationManagerAttributes {Order = 96}));
        CameraZoom = Config.Bind("03. Camera", "Camera Zoom Level", 7f, new ConfigDescription("Controls the zoom level of the game camera.", new AcceptableValueRange<float>(0.5f, 20f), new ConfigurationManagerAttributes {Order = 95}));
        CameraZoom.SettingChanged += (_, _) => UpdateCameras();
        MoveSpeed = Config.Bind("03. Gameplay", "Player Movement Speed", 1.5f, new ConfigDescription("Determines the speed at which the player moves.", new AcceptableValueRange<float>(0.5f, 5f), new ConfigurationManagerAttributes {Order = 94}));
        UseRefreshRateForFixedUpdate = Config.Bind("03. Gameplay", "Physics Update Rate Refresh", true, new ConfigDescription("Uses the monitor's refresh rate to determine the physics update rate, reducing camera jitter.", null, new ConfigurationManagerAttributes {Order = 93}));
        UseRefreshRateForFixedUpdate.SettingChanged += (_, _) => UpdateFixedUpdate();

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
    }

    private static void UpdateFixedUpdate()
    {
        if (UseRefreshRateForFixedUpdate.Value)
        {
            Time.fixedDeltaTime = 1f / MaxRefresh;
        }
        else
        {
            Time.fixedDeltaTime = 1f / FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
        }
    }

    private static void RunDisplayFixes()
    {
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.runInBackground = RunInBackground.Value;
        Application.targetFrameRate = MaxRefresh;
        UpdateFixedUpdate();
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        RunDisplayFixes();

        Time.timeScale = FastForwardThese.Contains(__arg0.name) ? 1000f : 1f;

        UpdateCameras();
    }

    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        // Start from half of the original rate and decrement by one to find the highest multiple above 50.
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        // Fallback, though this scenario is unlikely with standard monitor refresh rates
        return originalRate;
    }
    private static void UpdateCameras()
    {
        foreach (var allCamera in Camera.allCameras.Where(a => a))
        {
            allCamera.orthographicSize = CameraZoom.Value;
        }
    }
}