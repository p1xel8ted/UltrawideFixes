using System;
using System.Linq;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScarletMaiden;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.GetSettings))]
    public static void GameManager_Postfix(ref GameManager __instance, ref SettingsState __result)
    {
        __result.resolutionState = (ResolutionState) 10;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.GetResolutionForState))]
    public static void CameraFix_GetResolutionForState(ref ResolutionState resolutionState, ref ValueTuple<int, int> __result)
    {
        //create a new resolution state enum for UltraWide with a value of 10
        if (resolutionState == (ResolutionState) 10)
        {
            __result = new ValueTuple<int, int>(Display.main.systemWidth, Display.main.systemHeight);
        }
    }

    private static void UpdateFramerate(ref CameraFix cameraFix)
    {
        //get the highest framerate supported by the current resolution
        var currentRes = CameraFix.GetResolutionForState(cameraFix.resolutionState);

        var highestRefreshRate = Screen.resolutions
            .Where(mode => mode.width == currentRes.Item1 && mode.height == currentRes.Item2)
            .Max(mode => mode.refreshRate);

        cameraFix.targetFramerate = highestRefreshRate;
        Application.targetFrameRate = highestRefreshRate;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.Start))]
    public static void CameraFix_Start(ref CameraFix __instance)
    {
        UpdateFramerate(ref __instance);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenuResolution), nameof(SettingsMenuResolution.SetupOptions))]
    public static void SettingsMenuResolution_SetupOptions(ref SettingsMenuResolution __instance)
    {
        //convert the 4K option to UltraWide
        __instance.options[__instance.options.Length - 1].gameObject.GetComponent<TextMeshProUGUI>().text = $"UW ({Display.main.systemWidth}x{Display.main.systemHeight})";
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenuResolution), nameof(SettingsMenuResolution.OnConfirm))]
    public static void SettingsMenuResolution_OnOptionSelected(ref SettingsMenuResolution __instance)
    {
        //if selection is 4K, return UltraWide
        if (__instance.pointerIndex == 6)
        {
            __instance.pointerIndex = 10;
        }
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.Update))]
    public static void CameraFix_Update(ref CameraFix __instance)
    {
        if (!Plugin.EnableCustomOrthographicSize.Value) return;

        var increaseZoom = Plugin.IncreaseZoom.Value.IsUp();
        var decreaseZoom = Plugin.DecreaseZoom.Value.IsUp();
        var reset = Plugin.Reset.Value.IsUp();

        var orthographicSize = __instance.cam.orthographicSize;

        if (increaseZoom)
        {
            orthographicSize += 0.25f;
        }
        else if (decreaseZoom)
        {
            orthographicSize -= 0.25f;
        }
        else
        {
            if (reset)
            {
                Plugin.ResetZoom();
            }
            return;
        }

        __instance.cam.orthographicSize = orthographicSize;
        Plugin.CustomOrthographicSize.Value = orthographicSize;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(OttersideSplash), nameof(OttersideSplash.Start))]
    public static void OttersideSplash_Start(ref OttersideSplash __instance)
    {
        __instance.LoadNextScene();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.UpdateOrthographicSize))]
    public static void CameraFix_UpdateOrthographicSize(ref CameraFix __instance)
    {
        //convert ultrawide back into 16:9 equivalent to attempt to get correct orthographic size
        var screenHeight = CameraFix.GetResolutionForState(__instance.resolutionState).Item2;
        const float ar = 16f / 9f;
        var newWidth = (int) (screenHeight * ar);
        var res = CameraFix.GetStateForResolution(newWidth, screenHeight);
        Plugin.OriginalZoom = __instance.cam.orthographicSize = CameraFix.GetResolutionForState(__instance.resolutionState).Item2 / __instance.ppu / 2f / (float) res / __instance.currenZoomLevel;

        if (Plugin.EnableCustomOrthographicSize.Value)
        {
            __instance.cam.orthographicSize = Plugin.CustomOrthographicSize.Value;
        }

        UpdateFramerate(ref __instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIBehaviour), nameof(UIBehaviour.OnEnable))]
    [HarmonyPatch(typeof(UIBehaviour), nameof(UIBehaviour.Awake))]
    public static void UIBehaviour_Awake(ref UIBehaviour __instance)
    {
        if (__instance is CanvasScaler canvasScaler)
        {
            canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        }
    }
}