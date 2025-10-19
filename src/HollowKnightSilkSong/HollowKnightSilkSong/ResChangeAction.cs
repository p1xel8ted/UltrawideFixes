
// Namespace for Hollow Knight Silksong Ultra-Wide mod
// ReSharper disable InconsistentNaming
namespace HollowKnightSilkSong;


/// <summary>
/// Static class that hooks into Unity's Screen.SetResolution to detect resolution changes.
/// Triggers an event when the resolution changes, allowing other systems to respond.
/// </summary>
[Harmony]
public static class ResChangeAction
{
    /// <summary>
    /// Event invoked when the screen resolution changes. Subscribers receive the new resolution as a Vector2.
    /// </summary>
    internal static Action<Vector2> OnResolutionChange;

    // Stores the most recent resolution processed this frame to avoid duplicate events
    private static Vector2 _pendingResolution;
    // Tracks the last frame in which a resolution change was processed
    private static int _lastProcessedFrame = -1;

    /// <summary>
    /// Harmony prefix patch for all overloads of Screen.SetResolution.
    /// Captures the current resolution before it changes, storing it in __state for use in the postfix.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void SetResolution_Prefix(int width, int height, out Vector2 __state)
    {
        // Store the current screen resolution before it changes
        __state = new Vector2(Screen.width, Screen.height);
    }

    /// <summary>
    /// Harmony postfix patch for all overloads of Screen.SetResolution.
    /// Compares the new resolution to the previous one and triggers the OnResolutionChange event if changed.
    /// Ensures only one event per frame, even if multiple overloads are called.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void SetResolution_Postfix(int width, int height, Vector2 __state)
    {
        // The new resolution requested
        var newRes = new Vector2(width, height);

        // If the resolution didn't actually change, do nothing
        if (newRes == __state) return;

        // Prevent duplicate processing in the same frame (multiple overloads may be called)
        if (_lastProcessedFrame == Time.frameCount && _pendingResolution == newRes) return;

        // Update tracking variables for this frame
        _pendingResolution = newRes;
        _lastProcessedFrame = Time.frameCount;

        // Log the resolution change for diagnostics
        Plugin.Log.LogInfo($"Resolution changed from {__state.x}x{__state.y} to {newRes.x}x{newRes.y}");
        // Invoke the event so subscribers can respond to the new resolution
        OnResolutionChange?.Invoke(newRes);
    }
}