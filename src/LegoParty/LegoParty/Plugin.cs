using LegoParty.MonoBehaviours;

namespace LegoParty;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.legoparty.ultrawide";
    private const string PluginName = "LEGO Party Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>The game's native aspect ratio (16:9).</summary>
    public const float NativeAspectRatio = 16f / 9f;

    internal static ManualLogSource Logger { get; private set; }

    /// <summary>Primary display width in pixels.</summary>
    internal static int MainWidth => Display.main.systemWidth;

    /// <summary>Primary display height in pixels.</summary>
    internal static int MainHeight => Display.main.systemHeight;

    /// <summary>Primary display aspect ratio.</summary>
    internal static float MainAspectRatio => MainWidth / (float)MainHeight;

    /// <summary>Scale factor to convert from native 16:9 to current aspect ratio. Used to expand UI elements horizontally.</summary>
    public static float PositiveScaleFactor => MainAspectRatio / NativeAspectRatio;
  

    public override void Load()
    {
        Logger = Log;
        ClassInjector.RegisterTypeInIl2Cpp<CameraAspectEnforcer>();
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        
        Log.LogInfo($"Plugin {PluginName} is loaded!");

       
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        var rawImages = Resources.FindObjectsOfTypeAll<RawImage>();
        foreach (var rawImage in rawImages)
        {
            if (rawImage.texture is not RenderTexture rt) continue;

            // Only resize RenderTextures that are at native 16:9 aspect ratio
            var rtAspect = rt.width / (float)rt.height;
            if (!Mathf.Approximately(rtAspect, NativeAspectRatio)) continue;

            Logger.LogInfo($"[OnSceneLoaded] Adjusting RenderTexture on RawImage '{rawImage.gameObject.name}' from {rt.width}x{rt.height} to {MainWidth}x{MainHeight}");
            rt.Release();
            rt.width = MainWidth;
            rt.height = MainHeight;
            rt.Create();
        }
    }
}