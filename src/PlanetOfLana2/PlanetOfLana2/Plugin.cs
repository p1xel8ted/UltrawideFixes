namespace PlanetOfLana2;

/// <summary>
/// BepInEx IL2CPP plugin that patches Planet of Lana 2 for ultrawide display support.
/// Removes pillarboxing, aspect ratio caps, and cinematic letterbox bars.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.planetoflana2.ultrawide";
    private const string PluginName = "Planet of Lana 2 Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>
    /// Shared logger instance used by Harmony patches.
    /// </summary>
    internal static ManualLogSource Logger { get; private set; }

    /// <summary>
    /// Plugin entry point. Initializes display metrics and applies all Harmony patches.
    /// </summary>
    public override void Load()
    {
        Logger = Log;

        DisplayMetrics.Initialize();
        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}");

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
}
