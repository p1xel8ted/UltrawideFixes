namespace BingWonderland;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
    
}