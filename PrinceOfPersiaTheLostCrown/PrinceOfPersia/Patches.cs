namespace PrinceOfPersia;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsSupportedResolution))]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsValidAspectRatio))]
    public static void ScreenResolutionHandler_IsValid(ref bool __result)
    {
        __result = true;
    }
}