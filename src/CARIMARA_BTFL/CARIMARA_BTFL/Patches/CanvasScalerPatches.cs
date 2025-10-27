namespace CARIMARA_BTFL.UI.Patches;

/// <summary>
/// Harmony patches for dynamically adjusting canvas scaler screen match modes based on aspect ratio.
/// Switches to Expand mode for ultra-wide displays to prevent UI stretching.
/// </summary>
[Harmony]
public static class CanvasScalerPatches
{
    /// <summary>
    /// Stores the original screen match mode for each canvas scaler by instance ID.
    /// Allows restoration to original mode when returning to standard aspect ratios.
    /// </summary>
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();

    /// <summary>
    /// List of all canvas scalers found in the scene.
    /// Tracked to allow updating when aspect ratio changes.
    /// </summary>
    private static readonly List<CanvasScaler> CanvasScalers = [];

    /// <summary>
    /// Postfix patch that registers canvas scalers and applies appropriate screen match mode.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        // Skip ConfigurationManager UI
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);
        UpdateScalers(ResolutionManager.CurrentAspect);
    }

    /// <summary>
    /// Updates all registered canvas scalers to use Expand mode for ultra-wide displays or original mode for standard displays.
    /// Cleans up destroyed objects to prevent memory leaks.
    /// </summary>
    /// <param name="aspect">Current display aspect ratio.</param>
    internal static void UpdateScalers(float aspect)
    {
        // Clean up destroyed scalers to prevent memory leaks
        CanvasScalers.RemoveAll(scaler => scaler == null);

        // Clean up original modes for scalers that no longer exist
        foreach (var key in OriginalScreenMatchModes.Keys.ToArray())
        {
            if (!CanvasScalers.Any(scaler => scaler != null && scaler.GetInstanceID() == key))
            {
                OriginalScreenMatchModes.Remove(key);
            }
        }

        foreach (var scaler in CanvasScalers)
        {
            // Store the original screen match mode for each scaler
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            // Switch to Expand mode for ultra-wide displays to prevent stretching
            scaler.screenMatchMode = aspect > Constants.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }
}