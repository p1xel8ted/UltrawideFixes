using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace LegoParty;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.legoparty.ultrawide";
    private const string PluginName = "LEGO Party Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Logger { get; private set; }
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    internal static float MainAspectRatio => MainWidth / (float)MainHeight;

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<CameraAspectEnforcer>();
        Logger = Log;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        var rawImages = Resources.FindObjectsOfTypeAll<RawImage>();
        foreach (var rawImage in rawImages)
        {
            if (rawImage.texture is RenderTexture rt)
            {
                Logger.LogInfo($"[OnSceneLoaded] Adjusting RenderTexture on RawImage '{rawImage.gameObject.name}' from {rt.width}x{rt.height} to {MainWidth}x{MainHeight}");
                rt.Release();
                rt.width = MainWidth;
                rt.height = MainHeight;
                rt.Create();
            }
        }
    }
}