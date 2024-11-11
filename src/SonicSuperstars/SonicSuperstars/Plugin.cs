using Il2CppInterop.Runtime.Injection;

namespace SonicSuperstars;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.sonicsuperstars.ultrawide";
    private const string PluginName = "Sonic Superstars Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static readonly int MaxRefresh = Screen.resolutions.Max(a => a.refreshRate);
    internal static readonly int MainWidth = Display.main.systemWidth; //3440
    internal static readonly int MainHeight = Display.main.systemHeight; //1440
    internal static readonly float MainAspect = MainWidth / (float)MainHeight; //2.388888888888889
    internal const float NativeAspect = 16f / 9f; //1.777777777777778
    internal static readonly float PositiveScaleFactor = MainAspect / NativeAspect; //1.344444444444444

    public override void Load()
    {
        Log.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
}