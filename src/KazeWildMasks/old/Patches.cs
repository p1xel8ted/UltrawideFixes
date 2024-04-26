using HarmonyLib;
using UnityEngine;

namespace KazeUW;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioEnforcer), nameof(AspectRatioEnforcer.Awake))]
    [HarmonyPatch(typeof(AspectRatioEnforcer), nameof(AspectRatioEnforcer.Update))]
    [HarmonyPatch(typeof(AspectRatioEnforcer), nameof(AspectRatioEnforcer.EnforceCameraToAspect))]
    public static void AspectRatioEnforcer_Patch(ref AspectRatioEnforcer __instance)
    {
        __instance._targetAspect = (float) Display.main.systemWidth / (float) Display.main.systemHeight;
        __instance._lastScreenHeight = Display.main.systemHeight;
        __instance._lastScreenWidth = Display.main.systemWidth;
        __instance._camera.aspect = __instance._targetAspect;
        __instance._camera.pixelRect = new Rect(0f, 0f, Display.main.systemWidth, Display.main.systemHeight);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LogoScreenManager), nameof(LogoScreenManager.SceneAwake))]
    public static void LogoScreenManager_SceneAwake(ref LogoScreenManager __instance)
    {
        __instance._logosAnimation = string.Empty;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameplayManager), nameof(GameplayManager.ShowCutsceneBars))]
    public static bool GameplayManager_ShowCutsceneBars()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectZoomController), nameof(PixelPerfectZoomController.Update))]
    public static void PixelPerfectZoomController_Update(ref PixelPerfectZoomController __instance)
    {
        __instance._camera.cropFrameX = false;
        __instance._camera.cropFrameY = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.Awake))]
    [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.Update))]
    public static void LetterboxCamera_Patches(ref LetterboxCamera __instance)
    {
        __instance._camera.pixelRect = new Rect(0f, 0f, Display.main.systemWidth, Display.main.systemHeight);
        __instance._camera.aspect = (float) Display.main.systemWidth / (float) Display.main.systemHeight;
    }
    
}