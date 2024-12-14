namespace WildWoods;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.wildwoods.uwfixes";
    private const string PluginName = "Wild Woods Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    public const float NativeAspect = 16f / 9f;
    internal static float MainAspect => Screen.width / (float)Screen.height;
    internal static ConfigFile ConfigFile { get; private set; }
    private static ManualLogSource Log { get; set; }
    internal static ConfigEntry<string> HUDAspect { get; private set; }
    internal static ConfigEntry<int> MSAA { get; private set; }
    internal static ConfigEntry<float> RenderScale { get; private set; }
    private static ConfigEntry<bool> RestrictToLocalPlay { get; set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }

    private static List<string> HUDAspects { get; } =
    [
        "16:9",
        "21:9",
        "21.5:9",
        "24:10",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    public static ConfigEntry<bool> MaximumQuality { get; private set; }

    private void Awake()
    {
        ConfigFile = Config;

        Debug.unityLogger.logEnabled = true;

        Log = Logger;

        RestrictToLocalPlay = Config.Bind("01. General", "Restrict to Local Play", false,
            new ConfigDescription(
                "Enable this to restrict the ultra-wide portion of the fix to local play only.",
                null,
                new ConfigurationManagerAttributes { Order = 100 }));
        RestrictToLocalPlay.SettingChanged += (_, _) => UpdateAll();

        HUDAspect = Config.Bind("02. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 99 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAll();

        MaximumQuality = Config.Bind("03. Graphics", "Maximum Quality", false,
            new ConfigDescription(
                "Enable this to use the highest quality settings for the game. This may reduce performance. If you disable this, you will need to restart the game to undo the changes.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        MaximumQuality.SettingChanged += (_, _) => { UpdateAll(); };

        MSAA = Config.Bind("03. Graphics", "MSAA", 0,
            new ConfigDescription(
                "Set the level of Multi-Sample Anti-Aliasing (MSAA) to use. Higher values result in better quality but lower performance.",
                new AcceptableValueList<int>(0, 2, 4, 8),
                new ConfigurationManagerAttributes { Order = 97 }));
        MSAA.SettingChanged += (_, _) => UpdateAll();

        RenderScale = Config.Bind("03. Graphics", "Render Scale", 1f,
            new ConfigDescription(
                "Set the render scale for the game. Higher values result in better quality but lower performance.",
                new AcceptableValueRange<float>(0.25f, 4f),
                new ConfigurationManagerAttributes { Order = 96 }));
        RenderScale.SettingChanged += (_, _) =>
        {
            RenderScale.Value = Mathf.Round(RenderScale.Value * 4) / 4;
            UpdateAll();
        };

        Notifications = Config.Bind("04. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 95 }));

        SceneManager.sceneLoaded += (_, _) => UpdateAll();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    internal static bool ShouldApplyUltrawideFix()
    {
        if (Patches.Online)
        {
            return !RestrictToLocalPlay.Value; // Allow override in online play
        }

        return true; // Always allow fix offline
    }

    internal static void UpdateAll()
    {
        UpdateLayoutControllers();
        QualSettings.UpdateSettings();
        UpdateVirtualCameras();
        UpdateAspectRatioCameraFitters();
        Patches.UpdateVolumes();
    }

    private static void UpdateVirtualCameras()
    {
        var virtualCameras = Resources.FindObjectsOfTypeAll<CinemachineVirtualCamera>();
        foreach (var cam in virtualCameras)
        {
            if (cam)
            {
                var lens = cam.m_Lens;
                lens.FarClipPlane = Mathf.Max(10000f, cam.m_Lens.FarClipPlane);
                cam.m_Lens = lens;
            }
        }
    }

    private static void UpdateAspectRatioCameraFitters()
    {
        var aspectRatioCameraFitters = Resources.FindObjectsOfTypeAll<AspectRatioCameraFitter>();
        var vector = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
        foreach (var fitter in aspectRatioCameraFitters)
        {
            if (fitter)
            {
                fitter.CalculateCameraRect(vector);
            }
        }
    }

    private static void UpdateLayoutControllers()
    {
        var layoutControllers = Resources.FindObjectsOfTypeAll<LayoutController>();
        foreach (var lc in layoutControllers)
        {
            if (lc)
            {
                lc.UpdateAspect();
            }
        }
    }
}