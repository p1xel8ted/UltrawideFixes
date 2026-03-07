namespace NeverGrave;

/// <summary>
/// Intercepts all Screen.SetResolution overloads to force the display's native resolution.
/// </summary>
[Harmony]
public static class ScreenResolution
{
    /// <summary>
    /// Forces native resolution for SetResolution(int, int, bool, int).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }

    /// <summary>
    /// Forces native resolution for SetResolution(int, int, bool).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }

    /// <summary>
    /// Forces native resolution for SetResolution(int, int, FullScreenMode).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }

    /// <summary>
    /// Forces native resolution for SetResolution(int, int, FullScreenMode, int).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }

    /// <summary>
    /// Forces native resolution for SetResolution(int, int, FullScreenMode, RefreshRate).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }
}
