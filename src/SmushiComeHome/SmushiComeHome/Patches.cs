using Cinemachine;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace SmushiComeHome;

[Harmony]
public static class Patches
{

    private const string CmVcamPlayer = "CM VCAM Player";
    private const string PixelCanvas = "Pixel Canvas";
    private const string ComSinai = "com.sinai";

    private readonly static ResItem ResItem = new()
    {
        horizontal = Plugin.MainWidth,
        vertical = Plugin.MainHeight
    };

    private readonly static WriteOnce<float> OriginalFoV = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(ref CinemachineVirtualCamera __instance)
    {
        if (__instance is not {Name: CmVcamPlayer}) return;
        OriginalFoV.Value = __instance.m_Lens.FieldOfView;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCameraBase), nameof(CinemachineVirtualCameraBase.Update))]
    public static void CinemachineVirtualCameraBase_Update(ref CinemachineVirtualCameraBase __instance)
    {
        if (__instance is not CinemachineVirtualCamera {Name: CmVcamPlayer} vcam) return;

        if (Plugin.CustomFieldOfView.Value)
        {
            vcam.m_Lens.FieldOfView = Plugin.CustomFieldOfViewValue.Value;
        }
        else
        {
            vcam.m_Lens.FieldOfView = OriginalFoV.Value;
        }
    }

    private static float GetNewScale(float reference)
    {
        var scale = 1f / (reference / Plugin.MainHeight);
        return scale;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Equals(PixelCanvas) || __instance.name.Contains(ComSinai)) return;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_Handle(ref CanvasScaler __instance)
    {
        if (__instance.name.Equals(PixelCanvas) || __instance.name.Contains(ComSinai)) return;
        var newScale = GetNewScale(__instance.referenceResolution.y);
        __instance.scaleFactor = Plugin.CustomScale.Value ? newScale * Plugin.CustomScaleValue.Value : newScale;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveSystem), nameof(SaveSystem.LoadSettingsData))]
    public static void SaveSystem_LoadSettingsData(ref SaveSystem __instance)
    {
        var resolutions = __instance._gameSettings.resolutions;
        resolutions.Clear();
        resolutions.Add(ResItem);
        resolutions.Add(ResItem);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsConfigMainMenu), nameof(SettingsConfigMainMenu.GetScreenResolution))]
    public static bool SettingsConfigMainMenu_GetScreenResolution(ref SettingsConfigMainMenu __instance)
    {
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefreshRate);
        var resolutions = SaveSystem.GetGameSettings().resolutions;
        resolutions.Clear();
        resolutions.Add(ResItem);
        resolutions.Add(ResItem);
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsConfigMainMenu), nameof(SettingsConfigMainMenu.SetFullScreen))]
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.SetFullScreen))]
    [HarmonyPatch(typeof(SettingsConfigMainMenu), nameof(SettingsConfigMainMenu.ChangeResolution))]
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.ChangeResolution))]
    public static void Settings_ChangeResolution()
    {
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefreshRate);
    }
}