namespace WinterBurrows.UI.Patches;

/// <summary>
/// Harmony patches for dynamically adjusting canvas scaler screen match modes based on aspect ratio.
/// Switches to Expand mode for ultra-wide displays to prevent UI stretching.
/// </summary>
[Harmony]
public static class CanvasScalerPatches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
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
        UpdateScalers(Plugin.CurrentAspect);
    }

    /// <summary>
    /// Updates all registered canvas scalers to use Expand mode for ultra-wide displays or original mode for standard displays.
    /// </summary>
    /// <param name="aspect">Current display aspect ratio.</param>
    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            // Store the original screen match mode for each scaler
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            // Switch to Expand mode for ultra-wide displays to prevent stretching
            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }
}