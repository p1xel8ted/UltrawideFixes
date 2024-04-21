using System.Collections.Generic;

namespace BingWonderland;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(NewSplash), nameof(NewSplash.Start))]
    public static void NewSplash_Start(NewSplash __instance)
    {
        var f1X = __instance.First1.localScale.x * Plugin.PositiveScaleFactor;
        var f1y = __instance.First1.localScale.y * Plugin.PositiveScaleFactor;
        var lX = __instance.Last.localScale.x * Plugin.PositiveScaleFactor;
        var lY = __instance.Last.localScale.y * Plugin.PositiveScaleFactor;
        
        if (Plugin.MainAspectRatio >= Plugin.SuperWideAspectRatio)
        {
            __instance.First1.localScale = __instance.First1.localScale with {x = f1X, y = f1y};
            __instance.Last.localScale = __instance.Last.localScale with {x = lX, y = lY};   
        }
        else
        {

            __instance.First1.localScale = __instance.First1.localScale with {x = f1X};
            __instance.Last.localScale = __instance.Last.localScale with {x = lX};    
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsPanelTab), nameof(OptionsPanelTab.OnEnable))]
    public static void OptionsPanelTab_OnEnable(OptionsPanelTab __instance)
    {
        var graphicsTab = GameObject.Find("BattleLogic/UI_HyUI(Clone)/UI_Panels/UI_OptionsPanel(Clone)/Root/Panel/ToggleGroup/ToggleGraphics");
        if (graphicsTab)
        {
            graphicsTab.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HySteamHelper), nameof(HySteamHelper.WhiteListCheckLogic))]
    public static void HySteamHelper_WhiteListCheckLogic(HySteamHelper __instance, ref List<string> pendingDeleteDir,
        ref List<string> pendingDeleteFile, ref int __result)
    {
        pendingDeleteDir.Clear();
        pendingDeleteFile.Clear();
        __result = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HySteamHelper), nameof(HySteamHelper.ValidateFileHash))]
    public static bool HySteamHelper_ValidateFileHash(ref HySteamHelper __instance, string filePath, string sha256Hash, ref bool __result)
    {
        __instance._valid = true;
        __result = true;
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HySteamHelper), nameof(HySteamHelper.DeCaesarInit))]
    public static bool HySteamHelper_DeCaesarInit(ref HySteamHelper __instance)
    {
        __instance._valid = true;
        return false;
    }
}