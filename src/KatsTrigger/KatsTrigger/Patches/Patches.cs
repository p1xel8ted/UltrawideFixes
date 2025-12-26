using System.Diagnostics.CodeAnalysis;

namespace KatsTrigger.Patches;

/// <summary>
/// Contains Harmony patches for UI and camera components to enable ultrawide support.
/// Handles CanvasScaler and PixelPerfectCamera adjustments for non-standard aspect ratios.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    /// <summary>
    /// Stores the original ScreenMatchMode for each CanvasScaler by instance ID.
    /// Used to restore the original mode when aspect ratio returns to normal (16:9 or narrower).
    /// </summary>
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();

    /// <summary>
    /// List of all tracked CanvasScaler instances for batch updates.
    /// Cleared on scene unload to prevent memory leaks from destroyed objects.
    /// </summary>
    internal static readonly List<CanvasScaler> Scalers = [];

    /// <summary>
    /// Clears both the scaler cache and original mode dictionary.
    /// Called on scene unload to prevent memory leaks from holding references to destroyed Unity objects.
    /// </summary>
    internal static void ClearScalerCache()
    {
        OriginalScaleModes.Clear();
        Scalers.Clear();
    }

    /// <summary>
    /// Processes a CanvasScaler to apply ultrawide-compatible scaling.
    /// For aspect ratios wider than 16:9, switches to Expand mode to prevent UI clipping.
    /// For normal aspect ratios, preserves the original scaling mode.
    /// Only applies changes if the target mode differs from the current mode.
    /// </summary>
    /// <param name="scaler">The CanvasScaler to process.</param>
    /// <param name="aspect">The current display aspect ratio.</param>
    internal static void ProcessScaler(CanvasScaler scaler, float aspect)
    {
        // Guard against destroyed Unity objects
        if (scaler == null) return;

        var instanceID = scaler.GetInstanceID();

        // Store original mode on first encounter
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        // Determine target mode: Expand for ultrawide, original for standard
        var targetMode = aspect > Plugin.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;

        // Only apply if different from current
        if (scaler.screenMatchMode == targetMode) return;

        scaler.screenMatchMode = targetMode;
        Plugin.Logger.LogInfo($"CanvasScaler '{scaler.name}' mode changed to {targetMode}");
    }

    /// <summary>
    /// Harmony postfix patch for PixelPerfectCamera.OnEnable.
    /// Adjusts the reference resolution to match the ultrawide aspect ratio,
    /// preventing black bars and ensuring the game renders to the full screen width.
    /// Only applies changes if values differ from target values.
    /// </summary>
    /// <param name="__instance">The PixelPerfectCamera instance being enabled.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        // Calculate target X resolution based on the Y resolution and target aspect ratio
        var targetRefResolutionX = Mathf.RoundToInt(__instance.refResolutionY * Plugin.MainAspect);

        // Only update if different
        if (__instance.refResolutionX != targetRefResolutionX)
        {
            __instance.refResolutionX = targetRefResolutionX;
            Plugin.Logger.LogInfo($"PixelPerfectCamera '{__instance.name}' adjusted: {__instance.refResolutionX}x{__instance.refResolutionY}");
        }

        // Also adjust the underlying Camera component if present
        var camera = __instance.GetComponent<Camera>();
        if (!camera) return;

        var targetAspect = Plugin.MainAspect;
        var targetRect = new Rect(0, 0, 1, 1);
        var targetPixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);

        // Check if any camera values need updating
        // Use approximate comparison for floats
        var needsUpdate = !Mathf.Approximately(camera.aspect, targetAspect) ||
                          camera.rect != targetRect ||
                          camera.pixelRect != targetPixelRect;

        if (!needsUpdate) return;

        camera.aspect = targetAspect;
        camera.rect = targetRect;
        camera.pixelRect = targetPixelRect;
        Plugin.Logger.LogInfo($"Camera '{camera.name}' aspect adjusted: {camera.aspect} Rect: {camera.rect} PixelRect: {camera.pixelRect}");
    }

    /// <summary>
    /// Harmony postfix patch for CanvasScaler.OnEnable.
    /// Automatically adjusts canvas scaling mode when UI canvases are enabled.
    /// </summary>
    /// <param name="__instance">The CanvasScaler instance being enabled.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        ProcessScaler(__instance, Plugin.MainAspect);
    }
}
