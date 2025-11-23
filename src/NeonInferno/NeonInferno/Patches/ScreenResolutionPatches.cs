namespace NeonInferno.Patches;

[Harmony]
public static class ScreenResolution
{
    
    private static bool IsFullScreen => Plugin.FullScreenMode.Value == FullScreenMode.ExclusiveFullScreen ||
                                        Plugin.FullScreenMode.Value == FullScreenMode.FullScreenWindow;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_BoolWithInt(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = IsFullScreen;
        preferredRefreshRate = Plugin.MaxRefresh;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Bool(ref int width, ref int height, ref bool fullscreen)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreen = IsFullScreen;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Mode(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenMode.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_ModeWithInt(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenMode.Value;
        preferredRefreshRate = Plugin.MaxRefresh;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static void Screen_SetResolution_ModeWithRefreshRate(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenMode.Value;
        preferredRefreshRate = Plugin.MaxRefreshStruct;
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
        value = Plugin.FullScreenMode.Value;
#endif
    }
}