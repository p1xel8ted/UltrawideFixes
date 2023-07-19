using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GoldenLight;

[HarmonyPatch]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    // public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    // {
    //     __instance.referenceResolution = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Selectable), nameof(Selectable.OnEnable))]
    public static void Button_OnEnable(ref Button __instance)
    {
        if (__instance.name.Equals("Resolution 0"))
        {
            __instance.GetComponentInChildren<TextMeshProUGUI>().text = $"{Display.main.systemWidth}x{Display.main.systemHeight}";
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerSettingsController), nameof(PlayerSettingsController.SetResolution))]
    public static void PlayerSettingsController_SetResolution(int scale)
    {
        switch (scale)
        {
            case 0:
                Plugin.Log.LogWarning("Setting resolution to native resolution!");
                Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow);
                break;
        }
    }
}