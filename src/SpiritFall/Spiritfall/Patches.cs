using System.Collections.Generic;
using Avrahamy;
using Avrahamy.GG;
using HarmonyLib;
using Product.UI;
using UnityEngine;

namespace Spiritfall;

/// <summary>
/// Represents a Harmony plugin that patches several methods in order to change game settings and behavior.
/// </summary>
[HarmonyPatch]
public partial class Plugin
{
    /// <summary>
    /// A prefix patch for both <see cref="SettingsModel.SupportedWindowedResolutions"/> and <see cref="SettingsModel.SupportedFullscreenResolutions"/> getters.
    /// This patch sets the supported resolutions and refresh rates to custom ones defined in <see cref="ScreenResolutionsPatch"/>.
    /// </summary>
    /// <param name="__instance">The instance of the <see cref="SettingsModel"/> that is being patched.</param>
    /// <param name="__result">The result of the getter that will be changed by this patch.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsModel), nameof(SettingsModel.SupportedWindowedResolutions), MethodType.Getter)]
    [HarmonyPatch(typeof(SettingsModel), nameof(SettingsModel.SupportedFullscreenResolutions), MethodType.Getter)]
    public static void SettingsModel_SupportedResolutions(ref SettingsModel __instance, ref List<Vector2Int> __result)
    {
        __instance.supportedResolutions = ScreenResolutionsPatch.VectorResolutions;
        __instance.supportedFPS = ScreenResolutionsPatch.SupportRefresh;
    }

    /// <summary>
    /// A prefix patch for <see cref="CompanyLogo.Update"/> method.
    /// This patch hides the company logo and shows the loading animation instead.
    /// </summary>
    /// <param name="__instance">The instance of the <see cref="CompanyLogo"/> that is being patched.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CompanyLogo), nameof(CompanyLogo.Update))]
    private static void CompanyLogo_Update(ref CompanyLogo __instance)
    {
        __instance.logo.gameObject.SetActive(false);
        __instance.loadingAnimation.SetActive(true);
        __instance.enabled = false;
    }
        
    /// <summary>
    /// A prefix patch for <see cref="SettingsMenuController.OnWindowedModeChanged"/> and <see cref="SettingsMenuController.OnBorderlessChanged"/> methods.
    /// This patch forces borderless fullscreen to be always enabled.
    /// </summary>
    /// <param name="__instance">The instance of the <see cref="SettingsMenuController"/> that is being patched.</param>
    /// <param name="value">The new value of the windowed mode setting.</param>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenuController), nameof(SettingsMenuController.OnWindowedModeChanged))]
    [HarmonyPatch(typeof(SettingsMenuController), nameof(SettingsMenuController.OnBorderlessChanged))]
    private static void SettingsMenuController_OnWindowedModeChanged(ref SettingsMenuController __instance, ref bool value) => value = true;
}