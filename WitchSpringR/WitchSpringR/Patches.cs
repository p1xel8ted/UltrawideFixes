using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace WitchSpringR;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_BattleTotalDamage), nameof(Panel_BattleTotalDamage.SetDamage))]
    [HarmonyPatch(typeof(Panel_BattleTotalDamage), nameof(Panel_BattleTotalDamage.Update))]
    public static void Panel_BattleTotalDamage_Patches(ref Panel_BattleTotalDamage __instance)
    {
        __instance.transform.position = new Vector3(WitchSpringRUltrawide.Difference, __instance.transform.position.y,
            __instance.transform.position.z);
    }

    internal static Panel_ItemInfo_Left Panel_ItemInfo_Left_Instance { get; set; }
    
    [HarmonyPostfix]
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Panel_ItemInfo_Left), nameof(Panel_ItemInfo_Left.SetItemInfo))]
    [HarmonyPatch(typeof(Panel_ItemInfo_Left), nameof(Panel_ItemInfo_Left.EndBar))]
    [HarmonyPatch(typeof(Panel_ItemInfo_Left), nameof(Panel_ItemInfo_Left.SetItemInfo_Center))]
    public static void Panel_ItemInfo_Left_Patches(ref Panel_ItemInfo_Left __instance)
    {
        Panel_ItemInfo_Left_Instance = __instance;
        __instance.transform.position = new Vector3(WitchSpringRUltrawide.WidthDifference / 2f,
            __instance.transform.position.y, __instance.transform.position.z);
    }
}