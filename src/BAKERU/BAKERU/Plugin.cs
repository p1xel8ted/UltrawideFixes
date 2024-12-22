namespace BAKERU;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.bakeru.ultrawide";
    private const string PluginName = "BAKERU Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal const float NativeAspect = 16f / 9f;
    internal static float CurrentAspect => (float)Screen.currentResolution.width / Screen.currentResolution.height;
    internal static ManualLogSource Logger { get; set; }

    internal static ConfigEntry<string> HUDAspect { get; private set; }

    private static List<string> HUDAspects { get; } =
    [
        "16:9",
        "21:9",
        "21.5:9",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    public override void Load()
    {
        Logger = Log;
        ClassInjector.RegisterTypeInIl2Cpp<LayoutController>();

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneLoaded;

        HUDAspect = Config.Bind("01. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 99 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAll();

        Logger.LogInfo($"Plugin {PluginName} is loaded!");

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }

    private static void UpdateLayoutControllers()
    {
        var layoutControllers = Resources.FindObjectsOfTypeAll<LayoutController>();
        foreach (var lc in layoutControllers)
        {
            if (!lc) continue;

            lc.UpdateAspect();
        }
    }

    private static void UpdateGateFitStuff()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            if (!camera) continue;
            camera.gateFit = CurrentAspect > NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }

        var cuts = Resources.FindObjectsOfTypeAll<CommonCutScene>();
        foreach (var cut in cuts)
        {
            if (!cut) continue;
            cut.m_FixedAspectRatio = false;
            cut.m_CameraGateFitMode = CurrentAspect > NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }

    internal static void UpdateAll()
    {
        UpdateLayoutControllers();
        UpdateGateFitStuff();
    }
}