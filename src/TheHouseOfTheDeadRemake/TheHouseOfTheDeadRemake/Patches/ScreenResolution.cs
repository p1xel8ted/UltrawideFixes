﻿namespace TheHouseOfTheDeadRemake.Patches;

/// <summary>
/// Harmony patches for overriding screen resolution settings.
/// </summary>
public static class ScreenResolution
{
    /// <summary>
    /// Gets the selected resolution based on the plugin configuration.
    /// </summary>
    private static Resolution ChosenResolution => Resolutions.SelectedResolution;

    /// <summary>
    /// Overrides the parameters for Screen.SetResolution with the chosen resolution, fullscreen mode, and refresh rate (with int refresh rate).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(
        ref int width, 
        ref int height, 
        ref bool fullscreen, 
        ref int preferredRefreshRate)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || 
                     Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
        preferredRefreshRate = Resolutions.RefreshRate;
    }

    /// <summary>
    /// Overrides the parameters for Screen.SetResolution with the chosen resolution and fullscreen mode (without refresh rate).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(
        ref int width, 
        ref int height, 
        ref bool fullscreen)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreen = Plugin.FullScreenModeConfig.Value == FullScreenMode.ExclusiveFullScreen || 
                     Plugin.FullScreenModeConfig.Value == FullScreenMode.FullScreenWindow;
    }

    /// <summary>
    /// Overrides the parameters for Screen.SetResolution with the chosen resolution and fullscreen mode (FullScreenMode type).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(
        ref int width, 
        ref int height, 
        ref FullScreenMode fullscreenMode)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
    }

    /// <summary>
    /// Overrides the parameters for Screen.SetResolution with the chosen resolution, fullscreen mode, and refresh rate (FullScreenMode and int refresh rate).
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(
        ref int width, 
        ref int height, 
        ref FullScreenMode fullscreenMode, 
        ref int preferredRefreshRate)
    {
        width = ChosenResolution.width;
        height = ChosenResolution.height;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        preferredRefreshRate = Resolutions.RefreshRate;
    }
}