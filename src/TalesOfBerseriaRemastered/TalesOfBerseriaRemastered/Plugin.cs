// Plugin.cs - BepInEx 6 IL2CPP plugin entry point
// Originally authored by p1xel8ted (plugin structure, config entries, scene lifecycle)
// Modified by Claude (native-level framerate patches, simplified plugin after removing non-functional managed settings)

using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace TalesOfBerseriaRemastered;

/// <summary>
/// BepInEx 6 IL2CPP plugin entry point for Tales of Berseria Remastered ultrawide support.
///
/// This game uses a single Unity scene ("SampleScene") for everything - the native rendering DLL
/// (TLSampleViewerTO12.dll) runs its own state machine (LOGO -> SCAN -> OPENING -> TITLE -> GAME)
/// entirely within that scene.
///
/// The plugin provides:
///   - Ultrawide aspect ratio correction (via native code cave in TLSampleViewerTO12.dll)
///   - UI scaling to prevent horizontal stretching
///   - Instant logo skip (zeroing native timing data)
///   - Framerate uncapping (overriding native RenderManager FPS mode)
///   - Resolution enforcement to prevent the game from resetting to 16:9
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.talesofberseriaremastered.ultrawide";
    private const string PluginName = "Tales of Berseria Remastered Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>Monitor's native resolution width, used for resolution enforcement and aspect calculation.</summary>
    internal static readonly int MainWidth = Display.main.systemWidth;

    /// <summary>Monitor's native resolution height.</summary>
    internal static readonly int MainHeight = Display.main.systemHeight;

    /// <summary>
    /// The monitor's actual aspect ratio (e.g. 2.389 for 3440x1440).
    /// Used by native patches to set the perspective camera aspect and scale UI width.
    /// </summary>
    internal static readonly float CurrentAspect = MainWidth / (float)MainHeight;

    internal static ManualLogSource Logger;

    /// <summary>
    /// BepInEx 6 IL2CPP plugin entry point. Applies Harmony patches that handle all
    /// ultrawide fixes, resolution enforcement, and framerate uncapping.
    /// </summary>
    public override void Load()
    {
        Logger = Log;
        Logger.LogInfo($"Plugin loaded! Resolution={MainWidth}x{MainHeight}, Aspect={CurrentAspect:F2}");
       // SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
    //
    // private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    // {
    //     Time.fixedDeltaTime = 1f / 60f; // Ensure fixed timestep is 60 FPS for consistent physics and animations (optional)
    // }

}
