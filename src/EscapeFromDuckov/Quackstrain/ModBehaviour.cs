namespace Quackstrain;

/// <summary>
/// Main mod entry point for the Quackstrain ultrawide support mod.
/// Handles initialization, patching, and cleanup of Harmony patches and LayoutController instances.
/// </summary>
[Harmony]
public class ModBehaviour : Duckov.Modding.ModBehaviour
{
    /// <summary>
    /// Harmony instance used to apply runtime patches to game UI components.
    /// Static to persist across mod enable/disable cycles.
    /// </summary>
    private static Harmony HarmonyInstance { get; set; }

    /// <summary>
    /// Unity lifecycle: Called when the mod component is first created.
    /// Initializes the Harmony instance with a unique identifier.
    /// </summary>
    private void Awake()
    {
        HarmonyInstance = new Harmony("com.p1xel8ted.quackstrain");
    }

    /// <summary>
    /// Unity lifecycle: Called when the mod is enabled or re-enabled.
    /// Applies all Harmony patches to intercept UI component initialization.
    /// </summary>
    private void OnEnable()
    {
        HarmonyInstance.PatchAll();
        Tools.Log("OnEnable: Patches applied successfully.");
    }

    /// <summary>
    /// Unity lifecycle: Called when the mod GameObject is being destroyed.
    /// Removes all patches and cleans up all created LayoutController instances.
    /// </summary>
    private void OnDestroy()
    {
        HarmonyInstance.UnpatchAll("com.p1xel8ted.quackstrain");
        DestroyAllLayoutControllers();
        Tools.Log("OnDestroy: Patches removed successfully.");
    }

    /// <summary>
    /// Unity lifecycle: Called when the mod is disabled but not destroyed.
    /// Removes patches and cleans up controllers to revert UI to original state.
    /// </summary>
    private void OnDisable()
    {
        HarmonyInstance.UnpatchAll("com.p1xel8ted.quackstrain");
        DestroyAllLayoutControllers();
        Tools.Log("OnDisable: Patches removed successfully.");
    }

    /// <summary>
    /// Destroys all active LayoutController instances to clean up UI modifications.
    /// Creates a copy of the collection to safely iterate while destroying instances.
    /// </summary>
    private static void DestroyAllLayoutControllers()
    {
        // Get a snapshot of all instances to avoid collection modification during iteration
        var instances = LayoutController.GetAllInstances().ToList();

        // Destroy each controller that hasn't already been destroyed
        foreach (var instance in instances.Where(instance => instance))
        {
            Destroy(instance);
        }
    }
}