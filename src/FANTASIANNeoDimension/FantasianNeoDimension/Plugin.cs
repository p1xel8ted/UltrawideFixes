namespace FantasianNeoDimension;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.Ffantasianneo.ultrawide";
    private const string PluginName = "Fantasian Neo Dimensiong Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private const float NativeAspect = 16f / 9f; //1.777777777777778

    internal static readonly int MainWidth = Display.main.systemWidth; //3440

    //internal static readonly int MainWidth = 2560; //2560
    internal static readonly int MainHeight = Display.main.systemHeight; //1440
    private static readonly float MainAspect = MainWidth / (float)MainHeight; //2.388888888888889
    internal static readonly float PositiveScaleFactor = MainAspect / NativeAspect; //1.344444444444444
    internal static readonly float NegativeScaleFactor = NativeAspect / MainAspect; //0.7441860465116279

    internal static ManualLogSource Logger { get; private set; }


    public override void Load()
    {
        Logger = Log;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
}