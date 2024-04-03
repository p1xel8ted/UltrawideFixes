using HarmonyLib;
using UnityEngine;

namespace TwentyMinutesTillDawn;

[Harmony]
public static class ScreenResolution
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        preferredRefreshRate = Plugin.MaxRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(  ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution),typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        preferredRefreshRate = Plugin.MaxRefresh;
    } 
}