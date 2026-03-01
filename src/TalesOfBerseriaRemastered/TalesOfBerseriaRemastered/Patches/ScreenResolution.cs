// ScreenResolution.cs — Resolution and fullscreen enforcement via Harmony prefixes
// Originally authored by p1xel8ted (all SetResolution overload patches, fullscreen setter patches)
// Modified by Claude (comprehensive comments)

namespace TalesOfBerseriaRemastered.Patches;

/// <summary>
/// Harmony prefix patches on all Screen.SetResolution overloads and fullscreen property setters.
///
/// The game's native code periodically calls Screen.SetResolution with hardcoded 16:9 values
/// (e.g. 1920x1080), which would override the ultrawide resolution. These prefixes intercept
/// every overload and force the monitor's native resolution and borderless fullscreen mode.
///
/// All 5 SetResolution overloads are patched because different code paths in the game
/// (and Unity internals) may call different overloads. The fullScreen and fullScreenMode
/// property setters are also patched to prevent the game from switching to exclusive fullscreen
/// or windowed mode.
/// </summary>
[Harmony]
public static class ScreenResolution
{
    // --- SetResolution overloads (bool fullscreen variants) ---

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = true;
    }

    // --- SetResolution overloads (FullScreenMode variants) ---
    // These use FullScreenMode.FullScreenWindow (borderless) instead of ExclusiveFullScreen
    // to avoid resolution-switch delays and allow seamless alt-tabbing on ultrawide monitors.

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    // --- Fullscreen property setters ---
    // Prevent the game from switching out of fullscreen or changing the fullscreen mode.

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreen), MethodType.Setter)]
    public static void Screen_fullScreen_Setter(ref bool value)
    {
        value = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
    public static void Screen_fullScreenMode_Setter(ref FullScreenMode value)
    {
        value = FullScreenMode.FullScreenWindow;
    }
}
