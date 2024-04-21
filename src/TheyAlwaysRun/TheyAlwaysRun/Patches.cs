using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace TheyAlwaysRun;

[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    internal static Dictionary<string, Vector3> OriginalPositions { get; } = new();


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CurrencyUI), nameof(CurrencyUI.OnEnable))]
    private static void CurrencyUI_Init(ref CurrencyUI __instance)
    {
        var path = Util.GetFullPath(__instance.transform);
        OriginalPositions.TryAdd(path, __instance.transform.position);
        Plugin.TopRightHud = __instance.gameObject;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LevelGraphicsBackController), nameof(LevelGraphicsBackController.Init))]
    private static void LevelGraphicsBackController_Init(ref LevelGraphicsBackController __instance)
    {
        var back = GameObject.Find("ProCamera2DShakeContainer/CameraGameplay/CameraMainBack(Clone)/MainBack");
        if (Plugin.StretchBackGround.Value)
        {
            var scaleRatio = Util.GetScaleRatio();
            back.transform.localScale = new Vector3(scaleRatio, 1, 1);
        }
        else
        {
            back.transform.localScale = new Vector3(1, 1, 1);
        }

        Plugin.BackImage = back;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EnergyUI), nameof(EnergyUI.OnEnable))]
    private static void EnergyUI_OnEnable(ref EnergyUI __instance)
    {
        var path = Util.GetFullPath(__instance.transform);
        if (!path.Equals("UI/InGameUI/ThirdHandUI")) return;
        OriginalPositions.TryAdd(path, new Vector3(30, Display.main.systemHeight - 30, 0));
        Plugin.TopLeftHud = __instance.gameObject;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerUI), nameof(PlayerUI.Init))]
    private static void PlayerUI_Init(ref PlayerUI __instance)
    {
        var path = Util.GetFullPath(__instance.transform);
        OriginalPositions.TryAdd(path, __instance.transform.position);
        Plugin.BottomLeftHud = __instance.gameObject;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        if (__instance.name.Equals("InGameUI"))
        {
            Plugin.HudScaler = __instance;
            __instance.scaleFactor = Plugin.UIScale.Value;
        }

        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        if (!Util.GetFullPath(__instance.transform).Contains("UI"))
        {
            __instance.scaleFactor = 0.5f;
        }

        if (__instance.name.Contains("Menu"))
        {
            const float ar = 16 / 9f;
            var width = Mathf.RoundToInt(Display.main.systemHeight * ar);
            Screen.SetResolution(width, Display.main.systemHeight, Screen.fullScreenMode, 120);
            Plugin.Log.LogWarning($"Setting menu resolution to {Display.main.systemWidth}x{Display.main.systemHeight}");
        }
    }
}