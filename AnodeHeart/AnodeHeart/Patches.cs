using HarmonyLib;
using UnityEngine;

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
        __instance.SmoothFollow = true;
        __instance.Bounds = new Rect(-10000f, -10000f, 20000f, 20000f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Getter)]
    public static void Camera_orthographicSize(ref Camera __instance, ref float __result)
    {
        if (SceneSingleton<CameraController>.m_Instance == null) return;
        __result = SceneSingleton<CameraController>.m_Instance.targetOrthographicSize;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.NormalOrthographicSize), MethodType.Getter)]
    public static void CameraController_NormalOrthographicSize(ref CameraController __instance, ref float __result)
    {
        __result *= Plugin.ConfigZoom.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.targetOrthographicSize), MethodType.Getter)]
    public static void CameraController_targetOrthographicSize(ref CameraController __instance, ref float __result)
    {
        __result *= Plugin.ConfigZoom.Value;
    }
}