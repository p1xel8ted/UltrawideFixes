using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace MoonlighterUltrawide.Patches;

[HarmonyPatch]
public static class ResolutionPatches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsGraphicTabContent), nameof(OptionsGraphicTabContent.CheckResolutions))]
    public static bool OptionsGraphicTabContent_CheckResolutions(ref OptionsGraphicTabContent __instance)
    {
        if (!Plugin.UltrawideFixes.Value) return true;
        
        var maxRefresh = Screen.resolutions.Max(a => a.refreshRate).refreshRate;
        var nativeResolution = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = maxRefresh
        };

        var newResList = Enumerable.ToList(Screen.resolutions);
        newResList.Add(nativeResolution);

        var newArList = Enumerable.ToList(newResList.Select(res => (float) res.width / res.height));

        __instance._availableResolutions = newResList;
        __instance._availableAR = newArList;

        return false;
    }
}