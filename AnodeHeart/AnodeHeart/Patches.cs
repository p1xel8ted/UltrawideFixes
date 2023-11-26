using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering;

namespace AnodeHeart;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionResolution), nameof(OptionResolution.isResolutionSupported))]
    public static void OptionResolution_isResolutionSupported(ref bool __result)
    {
        __result = true;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.LateUpdate))]
    public static void CameraController_Start(ref CameraController __instance)
    {
        __instance.SmoothFollow = false;
        __instance.Bounds = new Rect(-1000f, -1000f, 2000f, 2000f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.NormalOrthographicSize), MethodType.Getter)]
    public static void CameraController_NormalOrthographicSize(ref CameraController __instance, ref float __result)
    {
        if (__instance.cam.orthographic)
        {
            __result *= Plugin.ConfigZoom.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.targetOrthographicSize), MethodType.Getter)]
    public static void CameraController_targetOrthographicSize(ref CameraController __instance, ref float __result)
    {
        if (__instance.cam.orthographic)
        {
            __result *= Plugin.ConfigZoom.Value;
        }
    }
}