using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace UltraWide.Patches;

[HarmonyPatch]
public static class ResolutionPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsGraphicTabContent), nameof(OptionsGraphicTabContent.CheckResolutions))]
    public static void OptionsGraphicTabContent_CheckResolutions(ref OptionsGraphicTabContent __instance)
    {
        if (!Plugin.UltrawideFixes.Value) return;

        var nativeResolution = new Resolution
        {
            width = Plugin.MainWidth,
            height = Plugin.MainHeight,
            refreshRate = Plugin.MaxRefresh
        };

        var exists = __instance._availableResolutions.ToArray().Any(r => r.width == Plugin.MainWidth && r.height == Plugin.MainHeight);
        if (exists) return;
        
        __instance._availableResolutions.Add(nativeResolution);
        __instance._availableAR.Add(Plugin.MainWidth / (float) Plugin.MainHeight);
    }
}