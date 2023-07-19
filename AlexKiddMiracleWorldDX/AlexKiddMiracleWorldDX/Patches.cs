using System.Linq;
using Assets.Scripts.Manager;
using Assets.Scripts.UI;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace AlexKiddMiracleWorldDX;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIProjectionScaler), nameof(UIProjectionScaler.Awake))]
    [HarmonyPatch(typeof(UIProjectionScaler), nameof(UIProjectionScaler.LateUpdate))]
    public static void UIProjectionScaler_Awake(ref UIProjectionScaler __instance)
    {
        if (Plugin.KeepUICentered.Value)
        {
            __instance.targetAspectRatio = new Vector2(16, 9);
            return;
        }

        __instance.targetAspectRatio = new Vector2(Plugin.SimplifiedWidth, Plugin.SimplifiedHeight);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Logos), nameof(Logos.Update))]
    public static bool Logos_Patches(ref Logos __instance)
    {
        if (!Plugin.SkipDevLogos.Value) return true;
        Singleton<SceneLoader>.Instance.LoadLevel(DemoMode.DemoModeEnabled ? "demo_menu" : "main_menu");
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.Awake))]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_Patches(ref PixelPerfectCamera __instance)
    {
        Plugin.GlobalVolumeObj = GameObject.Find("GameController/Default Illumination/Global Volume");
        __instance.cropFrameX = false;
        __instance.cropFrameY = false;
        var refreshRate = Screen.resolutions.Max(x => x.refreshRate);
        Application.targetFrameRate = refreshRate;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraResolutionController), nameof(CameraResolutionController.Awake))]
    [HarmonyPatch(typeof(CameraResolutionController), nameof(CameraResolutionController.Start))]
    public static void CanvasScaler_OnEnable(ref CameraResolutionController __instance)
    {
        var width = Display.main.systemWidth;
        var height = Display.main.systemHeight;

        __instance.targetRatio = new Vector2(Plugin.SimplifiedWidth, Plugin.SimplifiedHeight);
        __instance.width = width;
        __instance.heigth = height;
        __instance.AdjustFixedRatio(width / (float) height);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ResolutionController), nameof(ResolutionController.GetOptionsValues))]
    private static bool ResolutionController_GetOptionsValues(ref ResolutionController __instance)
    {
        __instance.FullscreenToggle.Toggle(Screen.fullScreenMode == FullScreenMode.FullScreenWindow);

        var list = Screen.resolutions
            .Select(r => $"{r.width} x {r.height}")
            .Distinct()
            .Select(rv => new AbstractCustomSelector.TextValue { text = rv, value = rv })
            .ToList();

        list.Add(new AbstractCustomSelector.TextValue { text = $"{Display.main.systemWidth} x {Display.main.systemHeight}", value = $"{Display.main.systemWidth} x {Display.main.systemHeight}" });

        __instance.ResolutionSelector.Items = list;
        __instance.ResolutionSelector.UpdateSelectedItem($"{Screen.width} x {Screen.height}");

        return false;
    }
}