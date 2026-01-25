namespace Broforce;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.broforce.ultrawide";
    private const string PluginName = "Broforce Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal const float NativeAspect = 16f / 9f; // 1.777778

    private static ManualLogSource Log { get; set; }

    private void Awake()
    {
        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
        Log.LogInfo($"Screen: {Screen.width}x{Screen.height} (Aspect: {(float)Screen.width / Screen.height:F4})");
        Log.LogInfo($"Hor+ ultrawide fix enabled for aspects wider than {NativeAspect:F4} (16:9)");
    }
}
