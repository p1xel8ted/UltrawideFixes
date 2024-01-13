using System.Linq;
using UnityEngine;

namespace PrinceOfPersia;

[Harmony]
public static class Patches
{
    private const string CnvCharacter = "CNV_Character";
    private const string SargonSilhouette = "SargonSilhouette";
    private static float BaseAspect => 16f / 9f;
    private static float CurrentAspect => (float) Screen.width / Screen.height;
    private static float PositiveScaleFactor => CurrentAspect / BaseAspect;
  

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
        
        if (!__instance.name.Equals(CnvCharacter)) return;
        
        var player = __instance.transform.FindChild(SargonSilhouette);
        if (player != null)
        {
            player.localScale = player.localScale with {x = PositiveScaleFactor};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.NearestResolution))]
    public static void ScreenResolutionHandler_NearestResolution(ref Resolution __result)
    {
        var myRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };

        __result = myRes;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsSupportedResolution))]
    [HarmonyPatch(typeof(ScreenResolutionHandler), nameof(ScreenResolutionHandler.IsValidAspectRatio))]
    public static void ScreenResolutionHandler_IsValid(ref bool __result)
    {
        __result = true;
    }
}