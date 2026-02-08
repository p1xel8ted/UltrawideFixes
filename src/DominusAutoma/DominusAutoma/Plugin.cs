using System.Linq;
using UnityEngine.SceneManagement;

namespace DominusAutoma;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.dominusautoma.ultrawide";
    private const string PluginName = "Dominus Automa Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal const float NativeAspect = 16f / 9f; // 1.777778

    internal static ManualLogSource Log { get; private set; }

    private static int MaxRefresh => Screen.resolutions.Max(a => Mathf.RoundToInt((float)a.refreshRateRatio.value));

    private static RefreshRate MaxRefreshRate => new()
    {
        denominator = 1,
        numerator = (uint)MaxRefresh
    };

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        ForceResolution();
    }

    private static void ForceResolution()
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);
        Application.targetFrameRate = MaxRefresh;
        Log.LogInfo($"Set resolution to {Display.main.systemWidth}x{Display.main.systemHeight} @ {MaxRefresh}Hz");
    }
}
