using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace SmushiComeHome;

[Harmony]
public static class Patches
{
    private static readonly ResItem ResItem = new()
    {
        horizontal = Display.main.systemWidth,
        vertical = Display.main.systemHeight
    };
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.aspect), MethodType.Getter)]
    public static bool Camera_aspect(ref float __result)
    {
        __result = (float) Display.main.systemWidth / Display.main.systemHeight;
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveSystem), nameof(SaveSystem.LoadSettingsData))]
    public static void SaveSystem_LoadSettingsData(ref SaveSystem __instance)
    {
        __instance._gameSettings.resolutions.Clear();
        __instance._gameSettings.resolutions.Add(ResItem);
        __instance._gameSettings.resolutions.Add(ResItem);
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsConfigMainMenu), nameof(SettingsConfigMainMenu.GetScreenResolution))]
    public static bool SettingsConfigMainMenu_GetScreenResolution(ref SettingsConfigMainMenu __instance)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, Screen.resolutions.Max(a => a.refreshRate));
        SaveSystem.GetGameSettings().resolutions.Clear();
        SaveSystem.GetGameSettings().resolutions.Add(ResItem);
        SaveSystem.GetGameSettings().resolutions.Add(ResItem);
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsConfigMainMenu), nameof(SettingsConfigMainMenu.SetFullScreen))]
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.SetFullScreen))]
    [HarmonyPatch(typeof(SettingsConfigMainMenu), nameof(SettingsConfigMainMenu.ChangeResolution))]
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.ChangeResolution))]
    public static void Settings_ChangeResolution()
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, Screen.resolutions.Max(a => a.refreshRate));
    }
}