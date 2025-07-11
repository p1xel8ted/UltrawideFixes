﻿namespace YouWillDieTonight.Patches;

[Harmony]
public static class ScreenResolution
{
    private static Resolution ChosenResolution => Plugin.SelectedResolution;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
        preferredRefreshRate = Plugin.RefreshRate;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        preferredRefreshRate = Plugin.RefreshRate;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreen), MethodType.Setter)]
    public static void Screen_fullScreen_Setter(ref bool value)
    {
#if DEBUG
        value = false;
#else
        value = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
#endif
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.fullScreenMode), MethodType.Setter)]
    public static void Screen_fullScreenMode_Setter(ref FullScreenMode value)
    {
#if DEBUG
        value = FullScreenMode.Windowed;
#else
        value = Plugin.FullScreenModeConfig.Value;
#endif
    }

}