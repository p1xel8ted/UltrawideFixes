namespace Doorstop;

[Harmony]
public static class ScreenResolution
{
    // private static Resolution ChosenResolution => Plugin.SelectedResolution;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Display.main.systemWidth;
        height = Display.main.systemHeight;
        fullscreen = true;
        preferredRefreshRate = (int)Screen.resolutions.Max(a => a.m_RefreshRate.value);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = Display.main.systemWidth;
        height = Display.main.systemHeight;
        fullscreen = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Display.main.systemWidth;
        height = Display.main.systemHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = Display.main.systemWidth;
        height = Display.main.systemHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
        preferredRefreshRate = Screen.resolutions
            .Select(resolution => resolution.m_RefreshRate)
            .OrderByDescending(refreshRate => refreshRate.value)
            .First();

    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Display.main.systemWidth;
        height = Display.main.systemHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
        preferredRefreshRate = (int)Screen.resolutions.Max(a => a.m_RefreshRate.value);
    }
}