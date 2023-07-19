using HarmonyLib;
using UnityEngine;

namespace AlwasLegacy;

[HarmonyPatch]
public partial class Plugin
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.Awake))]
    public static void SettingsManager_Awake(ref SettingsManager __instance)
    {
        __instance.resolutionTexts = new[] {"640x360", "1280x720", "1920x1080", "2560x1440", $"{Display.main.systemWidth}x{Display.main.systemHeight}"};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashScreens), nameof(SplashScreens.Start))]
    public static void SplashScreens_WaitForSplashScreens(ref SplashScreens __instance)
    {
        __instance.delay = 0f;
        __instance.splashScreens.videosToPlay.Clear();
        __instance.splashScreens.finishedPlaying = true;
        __instance.controllerNode.SetActive(false);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(EventCutsceneBorders), nameof(EventCutsceneBorders.Trigger))]
    public static bool EventCutsceneBorders_Trigger(ref EventCutsceneBorders __instance)
    {
        if (__instance.borderType == EventCutsceneBorders.BorderTypes.showBorders && CutsceneBorders.instance != null)
        {
            CutsceneBorders.instance.HideBorders();
        }
        __instance.NextInLine();
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.GetResolutionIndex))]
    public static bool SettingsManager_GetResolutionIndex(ref int __result)
    {
        var currentResolution = Screen.currentResolution;
        switch (currentResolution)
        {
            case {width: 640, height: 360}:
                __result = 1;
                return false;
            case {width: 1280, height: 720}:
                __result = 1;
                return false;
            case {width: 1920, height: 1080}:
                __result = 2;
                return false;
            case {width: 2560, height: 1440}:
                __result = 3;
                return false;
        }

        if (currentResolution.width == Display.main.systemWidth && currentResolution.height == Display.main.systemHeight)
        {
            __result = 4;
            return false;
        }

        __result = 1;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.ChangeResolution))]
    public static bool SettingsManager_ChangeResolution(ref SettingsManager __instance, ref int res, ref bool waitForConfirmation)
    {
        var fullScreen = SystemSaveSettings.instance.fullscreenIndex != 1;

        if (res == 0)
        {
            res = 1;
        }

        switch (res)
        {
            case 1:
                Screen.SetResolution(1280, 720, fullScreen);
                break;
            case 2:
                Screen.SetResolution(1920, 1080, fullScreen);
                break;
            case 3:
                Screen.SetResolution(2560, 1440, fullScreen);
                break;
            case 4:
                Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, fullScreen);
                break;
        }

        if (waitForConfirmation && SystemSaveSettings.instance.resolutionIndex != __instance.changedResolutionIndex)
        {
            __instance.confirmTimer = 10f;
            __instance.navigationActive = false;
            __instance.usingConfirmResolution = TranslationsManager.instance.FindOutput(__instance.confirmResolutionString);
            __instance.nodeOrder = SettingsManager.NodeOrders.confirmState;
        }

        return false;
    }
}