using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace TurnipBoyCommitsTaxEvasion;

[HarmonyPatch]
public static class Patches
{

    [HarmonyPrefix]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashController), nameof(SplashController.Start))]
    [HarmonyPatch(typeof(SplashController), nameof(SplashController.Update))]
    public static void SplashController_Start(ref SplashController __instance)
    {
        if (__instance == null) return;
        __instance.inputSkips = true;
        __instance.videoPlayer = null;
        __instance.screenTime = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsManager), nameof(OptionsManager.GetResolutions))]
    public static bool GetResolutionsPrefix(ref Resolution[] __result)
    {
        var resolutions = Screen.resolutions.ToList();
        var newRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = 120
        };

        var res = resolutions.Append(newRes);
        __result = (Resolution[]) res;
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsManager), nameof(OptionsManager.GetResolutionStrings))]
    public static bool GetResolutionStringsPrefix(ref string[] __result)
    {
        var resolutions = Screen.resolutions.ToList();
        var newRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = 120
        };

        resolutions.Add(newRes);

        __result = resolutions.Select(resolution => resolution.ToString()).ToArray();
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsManager), nameof(OptionsManager.GetResolution))]
    public static bool GetResolutionPrefix(ref int __result)
    {
        var resolutions = Screen.resolutions.ToList();
        var newRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = 120
        };

        resolutions.Add(newRes);

        for (var i = 0; i < resolutions.Count; i++)
        {
            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height &&
                resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {
                __result = i;
                return false;
            }
        }

        __result = 0;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsManager), nameof(OptionsManager.SetResolution))]
    public static bool SetResolutionPrefix(int _resolution)
    {
        var resolutions = Screen.resolutions.ToList();
        var newRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = 120
        };

        resolutions.Add(newRes);
        var fullScreenMode = FullScreenMode.Windowed;
        if (Screen.fullScreen)
        {
            fullScreenMode = FullScreenMode.FullScreenWindow;
        }

        Screen.SetResolution(resolutions[_resolution].width, resolutions[_resolution].height, fullScreenMode,
            resolutions[_resolution].refreshRate);
        return false;
    }
}