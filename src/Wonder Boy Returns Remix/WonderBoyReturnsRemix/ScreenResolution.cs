using HarmonyLib;
using UnityEngine;

namespace WonderBoyReturnsRemix;

[Harmony]
[HarmonyPatch]
public static class ScreenResolution
{
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        fullscreen = true;
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
        Application.targetFrameRate = Plugin.MaxRefresh;
        preferredRefreshRate = Plugin.MaxRefresh;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        fullscreen = true;
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
}