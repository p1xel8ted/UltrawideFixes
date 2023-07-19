using HarmonyLib;
using UnityEngine;

namespace WonderBoyReturnsRemix;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenOption), nameof(ScreenOption.Height), MethodType.Getter)]
    public static bool ScreenOption_Height_Getter(ref int __result)
    {
        __result = Display.main.systemHeight;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenOption), nameof(ScreenOption.Width), MethodType.Getter)]
    public static bool ScreenOption_Width_Getter(ref int __result)
    {
        __result = Display.main.systemWidth;
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoScriptMgr), nameof(LogoScriptMgr.Start))]
    [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
    public static void LogoScriptMgr_Start()
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true,120);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenOption), nameof(ScreenOption.SetResolution))]
    public static bool ScreenOption_Resolutions_Prefix()
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, 120);
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.aspect), MethodType.Getter)]
    public static bool Camera_aspect(ref float __result)
    {
        __result = (float) Display.main.systemWidth / (float) Display.main.systemHeight;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Getter)]
    public static bool Camera_orthographicSize(ref float __result)
    {
        __result = Plugin.CameraZoom.Value;
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.pixelHeight), MethodType.Getter)]
    [HarmonyPatch(typeof(Camera), nameof(Camera.scaledPixelHeight), MethodType.Getter)]
    public static bool Camera_scaledPixelHeight(ref int __result)
    {
        __result = Display.main.systemHeight;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.pixelWidth), MethodType.Getter)]
    [HarmonyPatch(typeof(Camera), nameof(Camera.scaledPixelWidth), MethodType.Getter)]
    public static bool Camera_scaledPixelWidth(ref int __result)
    {
        __result = Display.main.systemWidth;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.rect), MethodType.Getter)]
    [HarmonyPatch(typeof(Camera), nameof(Camera.pixelRect), MethodType.Getter)]
    [HarmonyPatch(typeof(Canvas), nameof(Canvas.pixelRect), MethodType.Getter)]
    public static bool Camera_pixelRect(ref Rect __result)
    {
        __result = new Rect(0, 0, Display.main.systemWidth, Display.main.systemHeight);
        return false;
    }
}