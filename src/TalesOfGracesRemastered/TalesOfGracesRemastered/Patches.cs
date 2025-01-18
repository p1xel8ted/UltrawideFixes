using Noble;
using UnityEngine.Rendering;

namespace TalesOfGracesRemastered;

[Harmony]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CommandBuffer), nameof(CommandBuffer.SetViewport))]
    public static void CommandBuffer_SetViewport(CommandBuffer __instance, ref Rect pixelRect)
    {
        if (__instance.name.StartsWith("NobleUI"))
        {
            pixelRect = new Rect(0, 0, 2580, 1440);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(FrameRateManager), nameof(FrameRateManager.SetTargetFrameRate))]
    [HarmonyPatch(typeof(FrameRateManager), nameof(FrameRateManager.SetQualitySettingFrameRate))]
    public static void FrameRateManager_SetTargetFrameRate(FrameRateManager __instance, ref float rate)
    {
        rate = Plugin.TargetFramerate.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MovieManager), nameof(MovieManager.Play))]
    public static void MovieManager_Play(MovieManager __instance)
    {
        Plugin.Log.LogWarning("MovieManager.Play");
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MovieManager), nameof(MovieManager.Stop))]
    public static void MovieManager_Stop(MovieManager __instance)
    {
        Plugin.Log.LogWarning("MovieManager.Stop");
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.SetCameraAspect))]
    public static void CameraManager_SetCameraAspect(ref float aspect)
    {
        aspect = Plugin.CurrentAspect;
        SingletonBase<PrimitiveManager>.GetSingletonInstance().CalcUIOrthoMatrix(true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.SetCameraViewportRect))]
    public static void CameraManager_SetCameraViewportRect(ref Rect rect)
    {
        rect = new Rect(0, 0, 1, 1);
        SingletonBase<PrimitiveManager>.GetSingletonInstance().CalcUIOrthoMatrix(true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DisableAltEnter), nameof(DisableAltEnter.Start))]
    public static void DisableAltEnter_Start(ref DisableAltEnter __instance)
    {
        __instance.enabled = false;
        __instance.gameObject.SetActive(false);
    }
}