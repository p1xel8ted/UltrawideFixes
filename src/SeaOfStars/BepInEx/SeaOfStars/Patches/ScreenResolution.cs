namespace SeaOfStars;

[Harmony]
public static class ScreenResolution
{
    private static Resolution ChosenResolution => DisplayManager.SelectedResolution;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreen = Configuration.Configuration.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Configuration.Configuration.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
        preferredRefreshRate = DisplayManager.RefreshRate;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreen = Configuration.Configuration.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Configuration.Configuration.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreenMode = Configuration.Configuration.FullScreenModeConfig.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreenMode = Configuration.Configuration.FullScreenModeConfig.Value;
        preferredRefreshRate = DisplayManager.RefreshRate;
    }
}