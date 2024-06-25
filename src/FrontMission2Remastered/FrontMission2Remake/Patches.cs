using System;
using System.Collections.Generic;
using MonoMod.Utils;

namespace FrontMission2Remake;

[Harmony]
public static class Patches
{

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenUtility), nameof(ScreenUtility.SetResolution))]
    public static bool ScreenUtility_SetResolution(ref int width, ref int height, ref FullScreenMode fullScreenMode)
    {
        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            if (Plugin.WindowPositioner)
            {
                Plugin.WindowPositioner.Start();
            }
        }
        Screen.SetResolution(width, height, fullScreenMode, Plugin.MaxRefresh);
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenUtility), nameof(ScreenUtility.GetResolutions))]
    public static void ScreenUtility_GetResolutions(ref ValueTuple<int, int>[] __result)
    {
        List<ValueTuple<int, int>> list = [];
        list.AddRange(Screen.resolutions.Select(resolution => new ValueTuple<int, int>(resolution.width, resolution.height)));
        __result = list.Distinct().ToArray();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}