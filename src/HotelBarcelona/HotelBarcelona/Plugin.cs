namespace HotelBarcelona;

/// <summary>
/// BepInEx IL2CPP plugin that enables ultrawide support for Hotel Barcelona.
/// Patches resolution enforcement, UI scaling, camera viewports, letterboxing,
/// video playback, and startup sequences.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    /// <summary>Unique identifier for this BepInEx plugin.</summary>
    private const string PluginGuid = "p1xel8ted.hotelbarcelona.ultrawide";

    /// <summary>Display name shown in BepInEx plugin listings.</summary>
    private const string PluginName = "Hotel Barcelona Ultra-Wide";

    /// <summary>Current semantic version of the plugin.</summary>
    private const string PluginVersion = "0.1.0";

    /// <summary>BepInEx log source for writing to the log output.</summary>
    private static ManualLogSource Logger { get; set; }

    /// <summary>
    /// Plugin entry point. Initializes display metrics, applies all Harmony patches,
    /// and runs initial global fixups for cameras and UI backgrounds.
    /// </summary>
    public override void Load()
    {
        Logger = Log;

        DisplayMetrics.Initialize();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}, IsWider: {DisplayMetrics.IsWiderThanNative}");

        Utils.ApplyGlobalFixups();
    }
}
