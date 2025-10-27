namespace ScarletMaiden.Resolutions;

/// <summary>
/// Harmony patches for detecting resolution changes and triggering update events.
/// Monitors all Screen.SetResolution overloads to notify subscribers when the resolution changes.
/// </summary>
[Harmony]
public static class ResolutionChangeHandler
{
    /// <summary>
    /// Event triggered when the screen resolution changes, passing the new resolution as a Vector2.
    /// </summary>
    internal static Action<Vector2> OnResolutionChange;

    /// <summary>
    /// Stores the most recent resolution change that's waiting to be processed.
    /// Used for duplicate detection within the same frame.
    /// </summary>
    private static Vector2 _pendingResolution;

    /// <summary>
    /// The Unity frame number when a resolution change was last processed.
    /// Prevents duplicate processing of the same resolution change in a single frame.
    /// </summary>
    private static int _lastProcessedFrame = -1;

    /// <summary>
    /// Prefix patch that captures the current resolution before it changes.
    /// </summary>
    /// <param name="__state">Output parameter storing the resolution before the change.</param>
    [HarmonyPrefix]
   // [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void SetResolution_Prefix(int width, int height, out Vector2 __state)
    {
        __state = new Vector2(Screen.width, Screen.height);
    }

    /// <summary>
    /// Postfix patch that detects resolution changes and triggers the OnResolutionChange event.
    /// Includes duplicate prevention to avoid multiple triggers for the same resolution change.
    /// </summary>
    /// <param name="width">New screen width.</param>
    /// <param name="height">New screen height.</param>
    /// <param name="__state">Previous resolution captured in prefix.</param>
    [HarmonyPostfix]
   // [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void SetResolution_Postfix(int width, int height, Vector2 __state)
    {
        var newRes = new Vector2(width, height);

        // Skip if resolution didn't actually change
        if (newRes == __state) return;

        // Prevent duplicate processing of the exact same resolution in the same frame
        if (_lastProcessedFrame == Time.frameCount && _pendingResolution == newRes) 
        {
            Plugin.Log.LogDebug($"Ignoring duplicate resolution change to {newRes.x}x{newRes.y} in same frame");
            return;
        }

        _pendingResolution = newRes;
        _lastProcessedFrame = Time.frameCount;

        Plugin.Log.LogInfo($"Resolution changed from {__state.x}x{__state.y} to {newRes.x}x{newRes.y}");
        OnResolutionChange?.Invoke(newRes);
    }
}