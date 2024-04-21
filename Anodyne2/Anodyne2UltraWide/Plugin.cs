namespace Anodyne2UltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.anodyne2.ultrawide";
    private const string PluginName = "Anodyne 2 Ultra-Wide";
    private const string PluginVersion = "0.1.2";

    private const string TwoDee = "2D";

    private static float MainAspectRatio => (float) MainWidth / MainHeight;
    private static float BaseAspectRatio => 16f / 9f;
    private static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    private static int MainWidth => Display.displays[0].systemWidth;
    private static int MainHeight => Display.displays[0].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ManualLogSource Log { get; private set; }
  

    private void Awake()
    {
        Log = Logger;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += OnSceneLoaded;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Display.displays[0].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, true, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;

        //despite the resolution setting this info, we need to set it again here to update the AR for some reason
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            if (camera.name.Contains(TwoDee)) continue;
            camera.aspect = MainAspectRatio;
        }
    }

}