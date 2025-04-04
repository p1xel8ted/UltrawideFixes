namespace Haste;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.haste.ultrawide";
    private const string PluginName = "HASTE Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    public const float NativeAspect = 16f / 9f;
    private static ManualLogSource Log { get; set; }
    internal static ConfigEntry<string> HUDAspect { get; private set; }
    internal static ConfigFile ConfigFile { get; private set; }
    public static ConfigEntry<float> CameraFieldOfView { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    private static ConfigEntry<bool> UnityLogging { get; set; }
    public static float CurrentAspect => Screen.width / (float)Screen.height;
    private static List<string> HUDAspects { get; } =
    [
        "16:10",
        "16:9",
        "21:9",
        "21.5:9",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;
        Log.LogInfo($"Plugin {PluginName} is loaded!");
        SetupMiscConfigurations(); //00
        SetupUIConfigurations(); //01
        SetupCameraConfigurations(); //02
        SetupPostProcessConfigurations(); //03

        Debug.unityLogger.logEnabled = UnityLogging.Value;
        
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private void SetupMiscConfigurations()
    {
        UnityLogging = Config.Bind("00. Misc", "Unity Logging", true,
            new ConfigDescription("Enable or disable Unity's internal logging.", null, new ConfigurationManagerAttributes { Order = 88 }));
        UnityLogging.SettingChanged += (_, _) => Debug.unityLogger.logEnabled = UnityLogging.Value;
    }

    private void SetupUIConfigurations()
    {
        HUDAspect = Config.Bind("01. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 87 }));
        HUDAspect.SettingChanged += (_, _) => LayoutController.UpdateControllers();
    }

    private void SetupCameraConfigurations()
    {
        CameraFieldOfView = Config.Bind("02. Camera", "Field of View", 1f, new ConfigDescription("Adjust the camera's field of view multiplier.", new AcceptableValueRange<float>(-5f, 5f), new ConfigurationManagerAttributes { Order = 90 }));
        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            if (CameraFieldOfView.Value == 0)
            {
                CameraFieldOfView.Value = 1f;
            }

            CameraFieldOfView.Value = Mathf.Round(CameraFieldOfView.Value * 4f) / 4f;
        };
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.name.StartsWith("LogoScene", StringComparison.OrdinalIgnoreCase))
        {
            SceneManager.LoadScene("MainMenu");
        }

        UpdateCameraGateFit();
    }


    private void SetupPostProcessConfigurations()
    {
        Notifications = Config.Bind("03. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 86 }));
    }

    internal static void UpdateCameraGateFit()
    {
        var cameras = Camera.allCameras.ToList();
        foreach (var cam in cameras.Where(cam => cam.aspect > 1f))
        {
            cam.gateFit = cam.aspect > NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }
}