using HarmonyLib;
using UnityEngine;

namespace WonderBoyReturnsRemix;

[HarmonyPatch]
public static class Patches
{
   
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleRoop), nameof(TitleRoop.Start))]
    public static void TitleRoop_Start(ref TitleRoop __instance)
    {
        var t1 = __instance.transform.Find("title_back_pattern");
        if (t1 != null)
        {
            var x1 = t1.localScale.x * Plugin.PositiveScaleFactor;
            var y1 = t1.localScale.y * Plugin.PositiveScaleFactor;
            var z1 = t1.localScale.z;
            t1.localScale = new Vector3(x1, y1, z1);
        }

        var t2 = __instance.transform.Find("title_bg");
        if (t2 != null)
        {
            var x2 = t2.localScale.x * Plugin.PositiveScaleFactor;
            var y2 = t2.localScale.y * Plugin.PositiveScaleFactor;
            var z2 = t2.localScale.z;
            t2.localScale = new Vector3(x2, y2, z2);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WBSelectCharacter), nameof(WBSelectCharacter.OnEnable))]
    public static void WBSelectCharacter_OnEnable(ref WBSelectCharacter __instance)
    {
        var t = __instance.transform.Find("black");
        if (t != null)
        {
            var x = t.localScale.x * Plugin.PositiveScaleFactor;
            var y = t.localScale.y * Plugin.PositiveScaleFactor;
            var z = t.localScale.z;
            t.localScale = new Vector3(x, y, z);
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(WBSelectLevel), nameof(WBSelectLevel.OnEnable))]
    public static void WBSelectLevel_OnEnable(ref WBSelectLevel __instance)
    {
        var t = __instance.transform.Find("black");
        if (t != null)
        {
            var x = t.localScale.x * Plugin.PositiveScaleFactor;
            var y = t.localScale.y * Plugin.PositiveScaleFactor;
            var z = t.localScale.z;
            t.localScale = new Vector3(x, y, z);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenOption), nameof(ScreenOption.Height), MethodType.Getter)]
    public static bool ScreenOption_Height_Getter(ref int __result)
    {
        __result = Plugin.MainHeight;
        return false;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenOption), nameof(ScreenOption.Width), MethodType.Getter)]
    public static bool ScreenOption_Width_Getter(ref int __result)
    {
        __result = Plugin.MainWidth;
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoScriptMgr), nameof(LogoScriptMgr.Start))]
    [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
    public static void LogoScriptMgr_Start()
    {
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, true,120);
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenOption), nameof(ScreenOption.SetResolution))]
    public static bool ScreenOption_Resolutions_Prefix()
    {
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, true, 120);
        return false;
    }
    
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.aspect), MethodType.Getter)]
    public static bool Camera_aspect(ref float __result)
    {
        __result = Plugin.MainWidth / (float) Plugin.MainHeight;
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
        __result = Plugin.MainHeight;
        return false;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.pixelWidth), MethodType.Getter)]
    [HarmonyPatch(typeof(Camera), nameof(Camera.scaledPixelWidth), MethodType.Getter)]
    public static bool Camera_scaledPixelWidth(ref int __result)
    {
        __result = Plugin.MainWidth;
        return false;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.rect), MethodType.Getter)]
    [HarmonyPatch(typeof(Camera), nameof(Camera.pixelRect), MethodType.Getter)]
    [HarmonyPatch(typeof(Canvas), nameof(Canvas.pixelRect), MethodType.Getter)]
    public static bool Camera_pixelRect(ref Rect __result)
    {
        __result = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlatformerCamera), nameof(PlatformerCamera.FixedUpdate))]
    public static void PlatformerCamera_FixedUpdate(ref PlatformerCamera __instance)
    {
        __instance.bCanGoBack = Plugin.EnableGoingBackwards.Value;
        __instance.cameraMoveSpeed = 50f;
    }

}