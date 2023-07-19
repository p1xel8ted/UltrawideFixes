using System.Linq;
using HarmonyLib;
using SaonaStudios.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Display = UnityEngine.Display;

namespace DeathOrTreatUltrawideFix;

/// <summary>
/// Contains Harmony patches for the CanvasScaler, GraphicsMenu classes.
/// </summary>
[HarmonyPatch]
public static class Patches
{
    /// <summary>
    /// This method gets executed after CanvasScaler's OnEnable method.
    /// It adjusts the scale factor and the UI scale mode of the CanvasScaler instance.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void GraphicsMenu_OnEnable(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return; //UnityExplorer
       
        if (!(Display.main.systemWidth / (float) Display.main.systemHeight > 16 / 9f)) return;

        if (__instance.name.Contains("Death Menu"))
        {
            GameManager.Instance.EnableControls();
            return;
        }
        
        var exists = Plugin.CanvasScalers.TryGetValue(__instance, out _);
        if (!exists)
        {
            Plugin.CanvasScalers.Add(__instance);
        }
            
        __instance.scaleFactor = Plugin.CustomScale.Value > 1 ? 1 * Plugin.CustomScale.Value : Plugin.CustomScale.Value;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
    }


    /// <summary>
    /// This method gets executed after GraphicsMenu's Start method.
    /// It updates the resolution text in the GraphicsMenu.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsMenu), nameof(GraphicsMenu.Start))]
    private static void GraphicsMenu_Start(ref GraphicsMenu __instance)
    {
        if (!(Display.main.systemWidth / (float) Display.main.systemHeight > 16 / 9f)) return;
        
        var resText = __instance.transform.Find("ScreenPanel/Medium/Text (TMP)").GetComponent<TextMeshProUGUI>();
        if (resText != null)
        {
            resText.text = $"{Display.main.systemWidth}x{Display.main.systemHeight}";
        }
    }

    /// <summary>
    /// This method gets executed after GraphicsMenu's SetResolution method.
    /// It sets the resolution based on the user's display resolution.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsMenu), nameof(GraphicsMenu.SetResolution), typeof(int))]
    private static void GraphicsMenu_SetResolution(ref GraphicsMenu __instance, int resolutionInt)
    {
        if (resolutionInt != 2) return;
        
        __instance.SetResolution(Display.main.systemWidth, Display.main.systemHeight);
        PlayerPrefs.SetInt("Resolution", resolutionInt);
    }
}