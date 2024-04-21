using System.Collections.Generic;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace TalesOfTheNeonSea;

[HarmonyPatch]
public partial class Plugin
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameSettingManager), nameof(GameSettingManager.GetAllSuportedResolutions))]
    public static void GameSettingManager_GetAllSupportedResolutions(ref GameSettingManager __instance, ref Resolution[] __result)
    {
        var myRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
        };

        __result = new[] {myRes};
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.Init))]
    public static void UISetting_Init(ref UISetting __instance)
    {
        var myRes = new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
        };
        __instance.resolutions = new[] {myRes};
        __instance.ScreenResolutionDropdown.ClearOptions();

        var resString = $"{myRes.width}*{myRes.height}";
        __instance.ScreenResolutionDropdown.AddOptions(new List<string> {resString});
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.OnScreenResolutionSelect))]
    public static void UISetting_OnScreenResolutionSelect(ref UISetting __instance)
    {
        __instance.AudioPress.Play();
        __instance.TempSettings.ScreenResolution = 1;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("com.sinai")) return;
        _log?.LogWarning($"CanvasScaler_OnEnable: {__instance.name}");
        __instance.referenceResolution = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.scaleFactor = 1;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameSettingManager), nameof(GameSettingManager.DoScreenResolution))]
    public static bool GameSettingManager_DoScreenResolution(GameSettingManager.ScreenResolution resolution, bool isFullscreen)
    {

        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, isFullscreen);
        return false;
    }
}