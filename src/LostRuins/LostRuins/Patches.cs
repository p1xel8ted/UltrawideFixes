using Nunppong;

namespace LostRuins;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.Awake))]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.CameraOn))]
    public static void CameraController_CameraOn(CameraController __instance)
    {
        __instance.width = __instance.height * Plugin.MainAspect;
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(CameraController), nameof(CameraController.UpdateTargetPosition))]
    // public static void GUIManager_UpdateTargetPosition(CameraMode mode, 
    //     Vector2 targetPosition, 
    //     Vector2 playerPosition, 
    //     Vector2 playerGroundPosition)
    // {
    //     Plugin.Log.LogWarning($"CameraController.UpdateTargetPosition, mode {mode}, targetPosition {targetPosition}, playerPosition {playerPosition}, playerGroundPosition {playerGroundPosition}");
    //     
    // }
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(CameraController), nameof(CameraController.UpdateLensPosition))]
    // public static void GUIManager_UpdateLensPosition(CameraMode mode, Vector2 playerPosition)
    // {
    //     Plugin.Log.LogWarning($"CameraController.UpdateLensPosition, mode {mode}, playerPosition {playerPosition}");
    // }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.UpdateTargetPosition))]
    public static void CameraController_PixelPerfect(CameraController __instance)
    {
        var x = 0.8f * Plugin.ScaleFactor;
        var y = __instance.maxDistance.y;
        __instance.maxDistance = new Vector2(10, 0.8f);
        Plugin.Log.LogWarning($"CameraController.UpdateTargetPosition: {__instance.maxDistance}");
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(GUIManager), nameof(GUIManager.Resolutions), MethodType.Getter)]
    public static void GUIManager_Resolutions(ref List<string> __result)
    {
        __result.Add($"{Plugin.MainWidth}x{Plugin.MainHeight}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}