namespace ByeSweetCarole.Patches;

[Harmony]
public static class ScreenResolution
{
    // Helper property to convert FullScreenMode to boolean
    private static bool IsFullScreen => Mod.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen ||
                                        Mod.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Mod.NativeDisplayWidth;
        height = Mod.NativeDisplayHeight;
        fullscreen = IsFullScreen;
        preferredRefreshRate = Mod.MaxRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height,ref bool fullscreen)
    {
        width = Mod.NativeDisplayWidth;
        height = Mod.NativeDisplayHeight;
        fullscreen = IsFullScreen;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Mod.NativeDisplayWidth;
        height = Mod.NativeDisplayHeight;
        fullscreenMode = Mod.FullScreenModeConfig.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Five(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Mod.NativeDisplayWidth;
        height = Mod.NativeDisplayHeight;
        fullscreenMode = Mod.FullScreenModeConfig.Value;
        preferredRefreshRate = Mod.MaxRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreen), MethodType.Setter)]
    public static void Screen_fullScreen_Setter(ref bool value)
    {
#if DEBUG
        value = false;
#else
        value = IsFullScreen;
#endif
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
    public static void Screen_fullScreenMode_Setter(ref FullScreenMode value)
    {
#if DEBUG
        value = FullScreenMode.Windowed;
#else
        value = Mod.FullScreenModeConfig.Value;
#endif
    }

}