using UnityEngine.Rendering;
using WinterBurrow.PostProcessing;
using WinterBurrow.UI.Components;

namespace WinterBurrow.UI.Patches;

/// <summary>
/// Harmony patches for applying aspect ratio fitters to specific UI components and managing post-processing volumes.
/// Tracks HUD, fullscreen, and custom aspect fitters for dynamic updates.
/// </summary>
[Harmony]
public static class UIComponentPatches
{
    private static readonly List<AspectRatioFitter> HUDFitters = [];
    private static readonly List<CustomAspectFitter> CustomAspectFitters = [];
    private static readonly List<AspectRatioFitter> FullScreenFitters = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BurrowStorageScreenController), nameof(BurrowStorageScreenController.OnEnable))]
    public static void BurrowStorageScreenController_OnEnable(BurrowStorageScreenController __instance)
    {
        var bg = __instance.transform.Find("Background");
        if (bg)
        {
            var fitter = AspectRatioFitterFactory.AddFullScreenFitter(bg.gameObject);
            FullScreenFitters.Add(fitter);
        }
    }
    
    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerUI), nameof(PlayerUI.Awake))]
    public static void PlayerUI_Awake(PlayerUI __instance)
    {
        var fitter = AspectRatioFitterFactory.AddPreferredAspectFitter(__instance.gameObject);
        HUDFitters.Add(fitter);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISlotPanel), nameof(UISlotPanel.Initialization_AssignUISlotPanelParent))]
    [HarmonyPatch(typeof(UISlotPanel), nameof(UISlotPanel.Awake))]
    public static void UISlotPanel_Initialization_AssignUISlotPanelParent(UISlotPanel __instance)
    {
        if (__instance.name == "Settings_ButtonsPanel")
        {
            var res = __instance.transform.Find("Resolution");
            if (res)
            {
                res.gameObject.SetActive(false);
                if (__instance.TryGetComponent(out VerticalLayoutGroup vlg))
                {
                    vlg.enabled = true;
                }
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(TheUI), nameof(TheUI.Awake))]
    public static void TheUI_Awake(TheUI __instance)
    {
        var customFitter = AspectRatioFitterFactory.AddCustomAspectFitter(__instance.gameObject);
        CustomAspectFitters.Add(customFitter);

        var damageOverlay = __instance.transform.Find("FrostOverlay");
        if (damageOverlay)
        {
            var fitter = AspectRatioFitterFactory.AddFullScreenFitter(damageOverlay.gameObject);
            FullScreenFitters.Add(fitter);
        }
    }

    [HarmonyPrefix]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIIngameMenu), nameof(UIIngameMenu.Submenu_OpenSubmenu))]
    public static void UIInGameMenu_Submenu_OpenSubmenu(UIIngameMenu __instance)
    {
        var bg = __instance.transform.Find("Content/Background/Backdrop");
        if (bg)
        {
            var fitter = AspectRatioFitterFactory.AddFullScreenFitter(bg.gameObject);
            FullScreenFitters.Add(fitter);
        }
    }

    /// <summary>
    /// Updates all registered aspect ratio fitters to match the current display configuration.
    /// </summary>
    internal static void UpdateFitters()
    {
        // Update HUD fitters to use preferred aspect ratio
        foreach (var fitter in HUDFitters.Where(fitter => fitter))
        {
            AspectRatioFitterFactory.UpdateFitter(fitter, false);
        }

        // Update fullscreen fitters to use current display aspect ratio
        foreach (var fitter in FullScreenFitters.Where(fitter => fitter))
        {
            AspectRatioFitterFactory.UpdateFitter(fitter, true);
        }

        // Update custom fitters with new width calculations
        foreach (var fitter in CustomAspectFitters.Where(fitter => fitter))
        {
            fitter.UpdateWidth();
        }
    }
}