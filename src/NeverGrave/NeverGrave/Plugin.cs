using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace NeverGrave;

/// <summary>
/// BepInEx IL2CPP plugin that patches NeverGrave for ultrawide display support.
/// Corrects camera aspect ratio, forces native resolution, and adjusts UI scaling.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.nevergrave.ultrawide";
    private const string PluginName = "NeverGrave Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>
    /// Shared logger instance used by Harmony patches.
    /// </summary>
    internal static ManualLogSource Logger { get; private set; }

    /// <summary>
    /// Plugin entry point. Initializes display metrics, registers scene callbacks, and applies all Harmony patches.
    /// </summary>
    public override void Load()
    {
        Logger = Log;
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneLoaded;

        DisplayMetrics.Initialize();
        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}");

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    /// <summary>
    /// Scales fade sprites to cover the full ultrawide viewport on scene load.
    /// The default "Spr_Fade" sprites are sized for 16:9 and leave gaps at the edges on wider displays.
    /// </summary>
    private static void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Logger.LogInfo($"Scene loaded: {scene.name} (build index {scene.buildIndex}), load mode: {mode}");

        foreach (var sr in Resources.FindObjectsOfTypeAll<SpriteRenderer>())
        {
            if (sr.name != "Spr_Fade") continue;
            sr.transform.localScale = sr.transform.localScale with { x = 100f };
            Logger.LogInfo($"Scaled fade sprite: {sr.name} at {sr.transform.position}, new scale: {sr.transform.localScale}");
        }
    }
}
