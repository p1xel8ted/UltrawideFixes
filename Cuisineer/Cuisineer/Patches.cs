using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace Cuisineer;

[Harmony]
public static class Patches
{
   
    [HarmonyPrefix]
    [HarmonyPatch(typeof(UI_GameplayOptions), nameof(UI_GameplayOptions.Setup))]
    public static void UI_GameplayOptions_Setup()
    {
        Plugin.Logger.LogInfo("UI_GameplayOptions.Setup");

        var myResData = new ResolutionData
        {
            m_Height = Display._mainDisplay.systemHeight,
            m_Width = Display._mainDisplay.systemWidth
        };
        var resDatas = UI_GameplayOptions.ResolutionDatas.ToList();
        if (!resDatas.Exists(a=>a.m_Height == Display._mainDisplay.systemHeight && a.m_Width == Display._mainDisplay.systemWidth))
        {
            resDatas.Add(myResData);
            Plugin.Logger.LogInfo($"Added {myResData.m_Width}x{myResData.m_Height} to resolution list");  
        }

        UI_GameplayOptions.ResolutionDatas = resDatas.ToArray();
    }
}