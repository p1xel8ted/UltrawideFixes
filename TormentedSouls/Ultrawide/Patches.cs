using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace Ultrawide;

[Harmony]
public static class Patches
{
    private const string Uw = "UW";

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicsBaseMenuController), nameof(GraphicsBaseMenuController.OnSResolutionPress))]
    public static void GraphicsBaseMenuController_OnSResolutionPress_Prefix(ref GraphicsBaseMenuController __instance,
        ref int pos)
    {
        if (__instance.sResolutionTextID.Exists(a => a.Equals(Uw))) return;
        __instance.sResolutionTextID.Add(Uw);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MultilanguageUIManager), nameof(MultilanguageUIManager.GetText))]
    public static bool GetText(ref MultilanguageUIManager __instance, ref string id,
        ref Dictionary<SceneDataSO.LanguagesEnum, string> __result)
    {
        if (!id.Equals(Uw)) return true;
        var dictionary = new Dictionary<SceneDataSO.LanguagesEnum, string>
        {
            {SceneDataSO.LanguagesEnum.EN, "Ultra Wide"},
            {SceneDataSO.LanguagesEnum.ES, "Ultra ancho"},
            {SceneDataSO.LanguagesEnum.GER, "Extra breit"},
            {SceneDataSO.LanguagesEnum.FR, "Ultra large"},
            {SceneDataSO.LanguagesEnum.RU, "Сверхширокий"},
            {SceneDataSO.LanguagesEnum.IT, "Ultra ampio"},
            {SceneDataSO.LanguagesEnum.POR, "Ultra amplo"},
            {SceneDataSO.LanguagesEnum.KR, "울트라와이드"},
            {SceneDataSO.LanguagesEnum.CH, "超广角"},
            {SceneDataSO.LanguagesEnum.JP, "超広角"},
            {SceneDataSO.LanguagesEnum.CHT, "超廣角"}
        };
        __result = dictionary;
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicsBaseMenuController), nameof(GraphicsBaseMenuController.OnSResolutionForceUpdate))]
    public static void GraphicsBaseMenuController_OnSResolutionForceUpdate(ref GraphicsBaseMenuController __instance)
    {
        if (__instance.sResolutionTextID.Exists(a => a.Equals(Uw))) return;
        __instance.sResolutionTextID.Add(Uw);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.IterateResolution), new Type[] { })]
    public static bool QualitySettingsManager_IterateResolution(ref QualitySettingsManager __instance, ref int __result)
    {
        __instance.debugResolution =
            (int) Mathf.Repeat(PersistentData.GetSettingsData().currentResolution + 1, 5f);
        __instance.SetupResolution();
        __instance.latestFixedDeltaTime = 1f / 120f;
        PersistentData.GetSettingsData().currentResolution = __instance.debugResolution;
        __result = __instance.debugResolution;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.IterateResolution), typeof(int))]
    public static bool QualitySettingsManager_IterateResolution_Int(ref QualitySettingsManager __instance, ref int pos,
        ref int __result)
    {
        __instance.debugResolution =
            (int) Mathf.Repeat(PersistentData.GetSettingsData().currentResolution + pos, 5f);
        __instance.SetupResolution();
        __instance.latestFixedDeltaTime = 1f / 120f;
        PersistentData.GetSettingsData().currentResolution = __instance.debugResolution;
        __result = __instance.debugResolution;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettingsManager), nameof(QualitySettingsManager.SetupResolution))]
    public static bool QualitySettingsManager_SetupResolution(ref QualitySettingsManager __instance)
    {
        switch (__instance.debugResolution)
        {
            case 4:
                Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, Plugin.MaxRefresh);
                break;
            case 3:
                Screen.SetResolution(3840, 2160, true, Plugin.MaxRefresh);
                break;
            case 2:
                Screen.SetResolution(2560, 1440, true, Plugin.MaxRefresh);
                break;
            case 1:
                Screen.SetResolution(1920, 1080, true, Plugin.MaxRefresh);
                break;
            case 0:
                Screen.SetResolution(1280, 720, true, Plugin.MaxRefresh);
                break;
        }

        __instance.latestFixedDeltaTime = 1f / 120f;
        return false;
    }
}