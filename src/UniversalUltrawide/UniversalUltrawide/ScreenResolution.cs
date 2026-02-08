namespace KatsTrigger.Patches;

/// <summary>
/// Contains Harmony patches for Unity's Screen class to enforce plugin-configured resolution settings.
/// Intercepts all Screen.SetResolution overloads and fullscreen property setters to prevent
/// the game from overriding the user's ultrawide resolution preferences.
/// </summary>
[Harmony]
public static class ScreenResolution
{
    /// <summary>
    /// Determines if the current fullscreen mode should be considered "fullscreen" for bool-based APIs.
    /// Returns true for both FullScreenWindow and ExclusiveFullScreen modes.
    /// </summary>
    private static bool IsFullScreen => Plugin.FullScreenMode.Value is FullScreenMode.ExclusiveFullScreen or FullScreenMode.FullScreenWindow;

    #region SetResolution Overload Patches

    /// <summary>
    /// Patches Screen.SetResolution(int, int, bool, int) to enforce plugin settings.
    /// This overload uses a boolean for fullscreen and includes refresh rate.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = IsFullScreen;
        preferredRefreshRate = Plugin.MaxRefresh;
    }

    /// <summary>
    /// Patches Screen.SetResolution(int, int, bool) to enforce plugin settings.
    /// This is the simplest overload with just dimensions and fullscreen flag.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = IsFullScreen;
    }

    /// <summary>
    /// Patches Screen.SetResolution(int, int, FullScreenMode) to enforce plugin settings.
    /// This overload uses the FullScreenMode enum instead of a boolean.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenMode.Value;
    }

    /// <summary>
    /// Patches Screen.SetResolution(int, int, FullScreenMode, int) to enforce plugin settings.
    /// This overload uses FullScreenMode enum and includes refresh rate as int.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenMode.Value;
        preferredRefreshRate = Plugin.MaxRefresh;
    }

    /// <summary>
    /// Patches Screen.SetResolution(int, int, FullScreenMode, RefreshRate) to enforce plugin settings.
    /// This is Unity's newer API that uses a RefreshRate struct instead of int.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenMode.Value;
        preferredRefreshRate = Plugin.RefreshRateStruct;
    }

    #endregion

    #region Fullscreen Property Patches

    /// <summary>
    /// Patches the Screen.fullScreen property setter to enforce plugin settings.
    /// In DEBUG builds, forces windowed mode for easier development/testing.
    /// In RELEASE builds, respects the user's fullscreen configuration.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreen), MethodType.Setter)]
    public static void Screen_fullScreen_Setter(ref bool value)
    {
#if DEBUG
        // Force windowed mode during development for easier debugging
        value = false;
#else
        value = IsFullScreen;
#endif
    }

    /// <summary>
    /// Patches the Screen.fullScreenMode property setter to enforce plugin settings.
    /// In DEBUG builds, forces Windowed mode for easier development/testing.
    /// In RELEASE builds, respects the user's fullscreen mode configuration.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
    public static void Screen_fullScreenMode_Setter(ref FullScreenMode value)
    {
#if DEBUG
        // Force windowed mode during development for easier debugging
        value = FullScreenMode.Windowed;
#else
        value = Plugin.FullScreenMode.Value;
#endif
    }

    #endregion
}
