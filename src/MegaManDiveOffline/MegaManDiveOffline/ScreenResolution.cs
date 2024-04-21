namespace MegaManDiveOffline;

[Harmony]
public static class ScreenResolution
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        if(Plugin.SelectedResolution.width == 0 || Plugin.SelectedResolution.height == 0) return;
        width = Plugin.SelectedWidth;
        height = Plugin.SelectedHeight;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow || Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen;
        preferredRefreshRate = Plugin.SelectedRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        if(Plugin.SelectedResolution.width == 0 || Plugin.SelectedResolution.height == 0) return;
        width = Plugin.SelectedWidth;
        fullscreen = true;
        height = Plugin.SelectedHeight;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow || Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(  ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        if(Plugin.SelectedResolution.width == 0 || Plugin.SelectedResolution.height == 0) return;
        width = Plugin.SelectedWidth;
        height = Plugin.SelectedHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        if(Plugin.SelectedResolution.width == 0 || Plugin.SelectedResolution.height == 0) return;
        width = Plugin.SelectedWidth;
        height = Plugin.SelectedHeight;
        preferredRefreshRate = Plugin.SelectedRefresh;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
    } 
}