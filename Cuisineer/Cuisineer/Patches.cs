using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace Cuisineer;

[Harmony]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Inventory), nameof(Inventory.InsertHelper))]
    public static void Inventory_SetSlotData(ref ItemInstance item)
    {
        if (!Plugin.IncreaseStackSize.Value || item == null) return;
        item.ItemSO.m_MaxStack = 999;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_Cutscene), nameof(UI_Cutscene.RefreshText))]
    public static void UI_Cutscene_RefreshText(ref UI_Cutscene __instance)
    {
        if (!Plugin.InstantText.Value || __instance == null) return;
        __instance.Skip();
    }
    

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UI_GameplayOptions), nameof(UI_GameplayOptions.Setup))]
    public static void UI_GameplayOptions_Setup()
    {
        var myResData = new ResolutionData
        {
            m_Height = Display._mainDisplay.systemHeight,
            m_Width = Display._mainDisplay.systemWidth
        };
        var resDatas = UI_GameplayOptions.ResolutionDatas.ToList();
        if (!resDatas.Exists(a => a.m_Height == Display._mainDisplay.systemHeight && a.m_Width == Display._mainDisplay.systemWidth))
        {
            resDatas.Add(myResData);
            Plugin.Logger.LogInfo($"Added {myResData.m_Width}x{myResData.m_Height} to resolution list");
        }

        UI_GameplayOptions.ResolutionDatas = resDatas.ToArray();
    }
}