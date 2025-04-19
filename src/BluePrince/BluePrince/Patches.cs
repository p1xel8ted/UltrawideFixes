using HutongGames.PlayMaker.Actions;

namespace BluePrince;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectUtility), nameof(AspectUtility.Awake))]
    [HarmonyPatch(typeof(AspectUtility), nameof(AspectUtility.SetCamera))]
    public static void AspectUtility_OnEnable(AspectUtility __instance)
    {
        __instance._wantedAspectRatio = Plugin.CurrentAspect;
        AspectUtility.wantedAspectRatio = Plugin.CurrentAspect;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(DrawTexture), nameof(DrawTexture.OnGUI))]
    public static void DrawTexture_OnGUI(DrawTexture __instance)
    {
     
        Plugin.Logger.LogWarning($"DrawTexture OnGUI: {__instance.rect} - {__instance.screenRect.Value}");
    }
    
    
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(ResolutionSetter), "set_TargetAspectRatio")]
    // public static void ResolutionSetter_set_TargetAspectRatio(ResolutionSetter __instance, ref float value)
    // {
    //     value = Plugin.CurrentAspect;
    //     Plugin.Logger.LogWarning($"ResolutionSetter get_TargetAspectRatio: {value}");
    //     
    // }
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(ResolutionSetter), "get_TargetAspectRatio")]
    // public static void ResolutionSetter_get_TargetAspectRatio(ResolutionSetter __instance, ref float __result)
    // {
    //     __result = Plugin.CurrentAspect;
    //     Plugin.Logger.LogWarning($"ResolutionSetter get_TargetAspectRatio: {__result}");
    // }



    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        if (__instance.name.Contains("MessageCanvas")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }
}