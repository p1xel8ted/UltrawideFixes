namespace NEOTheWorldEndsWithYouUltraWide;

[Harmony]
[HarmonyWrapSafe]
public static class Patches
{
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GlobalBehaviour), nameof(GlobalBehaviour.CalcAspectAdjustSize16By9))]
    [HarmonyPatch(typeof(GlobalBehaviour), nameof(GlobalBehaviour.CalcAspectAdjustSize))]
    public static void GlobalBehaviour_CalcAspectAdjustSize(ref Vector2Int size, ref Vector2Int __result)
    {
        size = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
        __result = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
    }
}