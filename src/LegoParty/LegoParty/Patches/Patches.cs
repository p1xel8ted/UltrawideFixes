namespace LegoParty.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LetterboxOverlay), nameof(LetterboxOverlay.Start))]
    private static void LetterboxOverlay_Start(LetterboxOverlay __instance)
    {
        Object.Destroy(__instance);
        Plugin.Logger.LogInfo($"[LetterboxOverlay_Start] Removed LetterboxOverlay from GameObject '{__instance.gameObject.name}' to prevent black bars.");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraNode), nameof(CameraNode.OnEnable))]
    private static void CameraNode_OnEnable(CameraNode __instance)
    {
        if (__instance.Camera)
        {
            __instance.Camera.gameObject.GetOrAddComponent<CameraAspectEnforcer>();
            Plugin.Logger.LogInfo($"[CameraNode_OnEnable] Added CameraAspectEnforcer to CameraNode '{__instance.gameObject.name}' to enforce aspect ratio {Plugin.MainAspectRatio}");

            var rt = __instance.Camera.targetTexture;
            
            if (!rt) return;

            Plugin.Logger.LogInfo($"[CameraNode_OnEnable] Adjusting render texture on CameraNode '{__instance.gameObject.name}' to {Plugin.MainWidth}x{Plugin.MainHeight}");
            rt.Release();
            rt.width = Plugin.MainWidth;
            rt.height = Plugin.MainHeight;
            rt.Create();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.Start))]
    private static void AspectRatioFitter_Start(AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        __instance.aspectRatio = Plugin.MainAspectRatio;
        Plugin.Logger.LogInfo($"[AspectRatioFitter_Start] Adjusted AspectRatioFitter on GameObject '{__instance.gameObject.name}' to aspect ratio {Plugin.MainAspectRatio}");
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}