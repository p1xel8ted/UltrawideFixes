namespace TrainValleyOne;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.trainvalleyone.ultrawide";
    private const string PluginName = "Train Valley Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    private const string UIRootLeftBlackBar = "UI Root/leftBlackBar";
    private const string UIRootRightBlackBar = "UI Root/rightBlackBar";
    private static ManualLogSource Log { get; set; }
    internal static ConfigEntry<bool> ExpandUI { get; private set; }
    internal static ConfigEntry<int> GaugeAdjustment { get; private set; }
    private GameObject LeftBar { get; set; }
    private GameObject RightBar { get; set; }

    private void Awake()
    {
        ExpandUI = Config.Bind("General", "Expand UI", true, "Expand UI to fill the screen.");
        GaugeAdjustment = Config.Bind("General", "Gauge Adjustment", 5, new ConfigDescription("Fine-tune the gauge position if needed. Default of 5 should be fine however.", new AcceptableValueRange<int>(-50, 50)));
        Log = Logger;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        LeftBar = GameObject.Find(UIRootLeftBlackBar);
        RightBar = GameObject.Find(UIRootRightBlackBar);

        if (LeftBar != null)
        {
            LeftBar.SetActive(false);
        }

        if (RightBar != null)
        {
            RightBar.SetActive(false);
        }
    }

}