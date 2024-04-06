using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace MiniShoot;

[Harmony]
public static class Patches
{
    
    /// <summary>
    /// Postfix patch for the Options.Awake method. Syncs the lens distortion toggle state in the options menu with the plugin's lens distortion setting.
    /// </summary>
    /// <param name="__instance">Reference to the instance of Options being patched.</param>
    /// <remarks>
    /// This method ensures that when the options menu is loaded, the toggle for lens distortion reflects the current setting of the plugin.
    /// Additionally, changes made to the toggle by the user are applied to the plugin's configuration, allowing for real-time updates without restarting the game.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Options), nameof(Options.Awake))]
    public static void Options_Awake(ref Options __instance)
    {
        // Add listener to sync the plugin setting with the UI toggle state.
        __instance.lensDistorsion.onValueChanged.AddListener(value =>
        {
            Plugin.LensDistortion.Value = value;
        });

        // Sync the UI toggle state with the plugin setting upon opening the options.
        var options = __instance;
        Plugin.LensDistortion.SettingChanged += (_, _) =>
        {
            options.lensDistorsion.isOn = Plugin.LensDistortion.Value;
        };
    }
    
    /// <summary>
    /// Postfix patch for HUD.Activate method. Adjusts the scale of trap spikes in the HUD based on a predefined positive scale factor.
    /// </summary>
    /// <param name="__instance">Reference to the instance of HUD being patched.</param>
    /// <remarks>
    /// Corrects the boss spikes' scaling to ensure they are displayed correctly on the screen. Should only be visible during a boss.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUD), nameof(HUD.Activate))]
    public static void HUD_Activate(ref HUD __instance)
    {
        __instance.TrapSpikes.transform.parent.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
    }
   
    /// <summary>
    /// Postfix patch for CanvasScaler.OnEnable method. Sets the screenMatchMode to Expand to ensure the canvas scales properly across different resolutions.
    /// </summary>
    /// <param name="__instance">Reference to the instance of CanvasScaler being patched.</param>
    /// <remarks>
    /// Corrects UI scaling behaviour so that no elements are cut off or misaligned on the screen.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    /// <summary>
    /// Postfix patch for InfoBox.DisplayControlMode method. Adjusts the position of the InfoBox based on a calculated value.
    /// </summary>
    /// <param name="__instance">Reference to the instance of InfoBox being patched.</param>
    /// <remarks>
    /// This ensures that the tooltips on the configuration screen are displayed in the correct position on the X axis.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(InfoBox), nameof(InfoBox.DisplayControlMode))]
    public static void InfoBox_OnEnable(ref InfoBox __instance)
    {
        var x = Plugin.BlackBarSize - Plugin.BlackBarSize * 0.1f;
        __instance.transform.localPosition = __instance.transform.localPosition with { x = x };
    }

    /// <summary>
    /// Postfix patch for AspectUtility.SetCamera method. Configures the camera's aspect ratio and dimensions to specific values.
    /// </summary>
    /// <param name="__instance">Reference to the instance of AspectUtility being patched.</param>
    /// <remarks>
    /// Removes black bars from the game's camera view by adjusting the aspect ratio and dimensions to match the main display's resolution.
    /// </remarks>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectUtility), nameof(AspectUtility.SetCamera))]
    public static void AspectUtility_SetCamera(ref AspectUtility __instance)
    {
        __instance._wantedAspectRatio = Plugin.MainAspectRatio;
        AspectUtility.wantedAspectRatio = Plugin.MainAspectRatio;
        AspectUtility.cam.rect = new Rect(0, 0, 1, 1);
        AspectUtility.cam.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        AspectUtility.cam.aspect = Plugin.MainAspectRatio;
    }
}