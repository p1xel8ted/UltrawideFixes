namespace TurnipBoyCommitsTaxEvasion;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.turnipboycommitstaxevasion.ultrawide";
    private const string PluginName = "Turnip Boy Commits Tax Evasion Ultrawide";
    private const string PluginVersion = "0.1.1";

    internal static ConfigEntry<float> NpcChatDialogScale { get; private set; }
    internal static ConfigEntry<float> NpcChatDialogPosition { get; private set; }
    private static ConfigEntry<float> CameraZoom { get; set; }
    internal static ConfigEntry<float> MoveSpeed { get; private set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdate { get; set; }
    private static List<CanvasScaler> CanvasScalers { get; set; } = [];
    private static List<PixelPerfectCamera> PixelPerfectCameras { get; set; } = [];
    private const float MinAspectRatio = 16f / 9f;
    private static ManualLogSource Log { get; set; }

    private static IEnumerable<string> FastForwardThese { get; } = ["Snoozy", "fblk", "Graffiti", "Partners", "FMOD", "Warning"];
    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        NpcChatDialogScale = Config.Bind("General", "NPC Dialog Scale", 0.75f, new ConfigDescription("Scale of the dialogues when talking to an NPC.", new AcceptableValueRange<float>(0.1f, 2f), new ConfigurationManagerAttributes {Order = 0}));
        NpcChatDialogPosition = Config.Bind("General", "NPC Dialog Position", 0f, new ConfigDescription("Vertical position of the dialogues when talking to an NPC.", new AcceptableValueRange<float>(-1000, 1000), new ConfigurationManagerAttributes {Order = 1}));
        CameraZoom = Config.Bind("General", "Camera Zoom", 7f, new ConfigDescription("Zoom of the camera.", new AcceptableValueRange<float>(0.5f, 20f), new ConfigurationManagerAttributes {Order = 2}));
        CameraZoom.SettingChanged += (_, _) => UpdateCameras();
        MoveSpeed = Config.Bind("General", "Move Speed", 1.5f, new ConfigDescription("Speed of the player.", new AcceptableValueRange<float>(0.5f, 5f), new ConfigurationManagerAttributes {Order = 3}));
        UseRefreshRateForFixedUpdate = Config.Bind("General", "Use Refresh Rate For Fixed Update", true, new ConfigDescription("Use the refresh rate of the monitor for the fixed update. If not, it will be bumped from 50fps to 60fps.", null, new ConfigurationManagerAttributes {Order = 4}));
        UseRefreshRateForFixedUpdate.SettingChanged += (_, _) => UpdateFixedUpdate();
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateFixedUpdate()
    {
        if (UseRefreshRateForFixedUpdate.Value)
        {
            Time.fixedDeltaTime = 1f / Screen.currentResolution.refreshRate;
        }
        else
        {
            Time.fixedDeltaTime = 1f / FindLowestFrameRateMultipleAboveFifty(Screen.currentResolution.refreshRate);
        }   
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, Screen.fullScreenMode, Screen.currentResolution.refreshRate);

        UpdateFixedUpdate();

        Time.timeScale = FastForwardThese.Contains(__arg0.name) ? 1000f : 1f;

        PixelPerfectCameras = FindObjectsOfType<PixelPerfectCamera>().ToList();

        UpdateScalers();
        UpdatePixelPerfectCameras();
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

    private static void UpdateScalers()
    {
        CanvasScalers = FindObjectsOfType<CanvasScaler>().ToList();
        var selectResolution = Screen.currentResolution;

        var aspectRatio = (float) selectResolution.width / selectResolution.height;
        if (!(aspectRatio > MinAspectRatio)) return;

        foreach (var canvasScaler in CanvasScalers.Where(a => a != null))
        {
            canvasScaler.referenceResolution = new Vector2(selectResolution.width, selectResolution.height);
        }
    }

    private static void UpdatePixelPerfectCameras()
    {
        foreach (var pixelPerfectCamera in PixelPerfectCameras.Where(a => a != null))
        {
            pixelPerfectCamera.enabled = false;
        }
    }

    private static void UpdateCameras()
    {
        foreach (var allCamera in Camera.allCameras.Where(a => a != null))
        {
            allCamera.orthographicSize = CameraZoom.Value;
        }
    }
}