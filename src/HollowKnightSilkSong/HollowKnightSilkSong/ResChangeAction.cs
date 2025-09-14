namespace HollowKnightSilkSong;

[Harmony]
public static class ResChangeAction
{
    internal static Action<Vector2> OnResolutionChange;
    
    private static Vector2 _pendingResolution;
    private static int _lastProcessedFrame = -1;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void SetResolution_Prefix(int width, int height, out Vector2 __state)
    {
        // Store current resolution in __state for the postfix
        __state = new Vector2(Screen.width, Screen.height);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void SetResolution_Postfix(int width, int height, Vector2 __state)
    {
        var newRes = new Vector2(width, height);
        
        // Skip if resolution didn't change
        if (newRes == __state)
            return;
        
        // Only process once per frame (handles multiple overloads in same frame)
        if (_lastProcessedFrame == Time.frameCount && _pendingResolution == newRes)
            return;
        
        _pendingResolution = newRes;
        _lastProcessedFrame = Time.frameCount;
        
        Plugin.Log.LogInfo($"Resolution changed from {__state.x}x{__state.y} to {newRes.x}x{newRes.y}");
        OnResolutionChange?.Invoke(newRes);
    }
}