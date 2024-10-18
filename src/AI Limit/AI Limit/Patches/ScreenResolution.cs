namespace AI_Limit.Patches;

[Harmony]
public static class ScreenResolution
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
        preferredRefreshRate = Plugin.MaxRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height,ref bool fullscreen)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        preferredRefreshRate = Plugin.MaxRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        var refreshRate = new RefreshRate
        {
            denominator = 1,
            numerator = (uint)Plugin.MaxRefresh
        };

        preferredRefreshRate = refreshRate;
    }


}