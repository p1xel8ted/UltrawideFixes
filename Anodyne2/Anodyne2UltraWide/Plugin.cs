namespace Anodyne2UltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.anodyne2.ultrawide";
    private const string PluginName = "Anodyne 2 Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private const string TwoDee = "2D";
    internal static ManualLogSource Log { get; private set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private void Awake()
    {
        Log = Logger;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += OnSceneLoaded;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, MaxRefresh);
        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;

        var currentAspect = (float) Display.main.systemWidth / Display.main.systemHeight;

        //despite the resolution setting this info, we need to set it again here to update the AR for some reason
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            if (camera.name.Contains(TwoDee)) continue;
            camera.aspect = currentAspect;
        }
    }
}