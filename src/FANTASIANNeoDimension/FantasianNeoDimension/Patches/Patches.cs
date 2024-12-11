using System.Diagnostics;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace FantasianNeoDimension.Patches;

[Harmony]
public static class Patches
{
    private static readonly int AspectRatio = Shader.PropertyToID("_AspectRatio");

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameOption), nameof(GameOption.GetAvailableResolutions))]
    public static void GameOption_GetAvailableResolutions(ref Il2CppStructArray<Vector2Int> __result)
    {
        var myResX = new Vector2Int(3440, 0);
        var myResY = new Vector2Int(1440, 0);
        var existingResolutions = __result.ToList();
        existingResolutions.Add(myResX);
        existingResolutions.Add(myResY);
        __result = new Il2CppStructArray<Vector2Int>(existingResolutions.ToArray());
    }

    public static List<T> FindIl2CppType<T>() where T : Object
    {
        var list = new List<T>();
        list.AddRange(Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UzuraManager), nameof(UzuraManager.updateCameraArea))]
    public static void UzuraManager_updateCameraArea(UzuraManager __instance)
    {
        Plugin.Logger.LogWarning($"UzuraManager.updateCameraArea");
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraImageInfo), nameof(CameraImageInfo.ApplyCamera))]
    public static void CameraImageInfo_ApplyCamera(CameraImageInfo __instance, Camera camera, CameraClipper cameraClipper, float scale)
    {
        __instance.useAreaSize = 1.348f;
        __instance.useTrimedTexture = true;
        // __instance.useAreaOffset *= Plugin.NegativeScaleFactor;
        // __instance.
        Plugin.Logger.LogWarning($"CameraImageInfo.ApplyCamera: {camera.name} -{__instance.useTrimedTexture} - {__instance.useAreaOffset}");
    }
    
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenMonitor), nameof(ScreenMonitor.UpdateRenderingSize))]
    public static void ScreenMonitor_UpdateRenderingSize(ref float scale)
    {
        scale = Plugin.PositiveScaleFactor;
        Plugin.Logger.LogWarning($"ScreenMonitor.UpdateRenderingSize: {scale}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MoviePlayer), nameof(MoviePlayer.Load))]
    [HarmonyPatch(typeof(MoviePlayer), nameof(MoviePlayer.Update))]
    [HarmonyPatch(typeof(MoviePlayer), nameof(MoviePlayer.Play))]
    public static void MoviePlayer_OnEnable(MoviePlayer __instance)
    {
        if (__instance.movieInfo != null)
        {
            __instance.videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
            __instance.movieInfo.enableSkip = true;
            __instance.movieInfo.fastForward = true;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}