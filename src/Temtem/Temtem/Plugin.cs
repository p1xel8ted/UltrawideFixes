namespace Temtem;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.temtem.ultrawide";
    private const string PluginName = "Temtem Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Logger { get; private set; }

    internal static int DisplayWidth => Screen.width;
    internal static int DisplayHeight => Screen.height;
    internal static float Aspect => Screen.width / (float)Screen.height;
    internal static float NativeAspect = 16f / 9f;
    internal static float ScaleFactor = Aspect / NativeAspect;

    public override void Load()
    {
        Logger = Log;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        SetRes();

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneLoaded;
        Log.LogInfo($"Loaded Temtem Ultra-Wide plugin.");
    }

    private static void SetRes()
    {
        var w = Screen.width;
        var h = Screen.height;
        var mode = Screen.fullScreenMode;
#if DEBUG
        w = 3200;
        h = 900;
        mode = FullScreenMode.Windowed;
#endif
        Screen.SetResolution(w, h, mode);
    }

    private static void SceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
        SetRes();

        foreach (var camera in Resources.FindObjectsOfTypeAll<Camera>())
        {
            var path = camera.gameObject.GetPath();

            if (camera.targetTexture) continue;
            if (path.Contains("(Clone)")) continue;

            var r = camera.rect;
            if (r is { x: 0f, y: 0f } && Mathf.Approximately(r.width, 1f) && Mathf.Approximately(r.height, 1f)) continue;

            camera.rect = new Rect(0f, 0f, 1f, 1f);
            camera.ResetAspect();
        }
    }
}