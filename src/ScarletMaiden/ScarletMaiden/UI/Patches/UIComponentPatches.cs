using ScarletMaiden.UI.Utils;

namespace ScarletMaiden.UI.Patches;

/// <summary>
/// Harmony patches for core UI components including HUD, dialogs, and controls.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class UIComponentPatches
{
    /// <summary>
    /// Postfix patch that applies aspect ratio fitter to the dungeon manager UI.
    /// Ensures the dungeon UI scales according to user's preferred HUD aspect ratio.
    /// </summary>
    /// <param name="__instance">The DungeonManager instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonManager), nameof(DungeonManager.Start))]
    public static void DungeonManager_Start(DungeonManager __instance)
    {
        var fitter = AspectRatioFitterFactory.AddPreferredAspectFitter(__instance.gameObject, false);
        AspectRatioFitterFactory.MainHudFitters.Add(fitter);
    }

    /// <summary>
    /// Postfix patch that applies aspect ratio fitters to the map menu and its background image.
    /// Moves background to ultrawide container and ensures menu scales according to user's preferred HUD aspect ratio.
    /// </summary>
    /// <param name="__instance">The MapMenu instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapMenu), nameof(MapMenu.Start))]
    public static void MapMenu_Start(MapMenu __instance)
    {
        SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, "BGImage", ResolutionManager.CurrentAspect);
        var bgImage = __instance.transform.Find("BGImage");
        if (bgImage)
        {
            var arf = AspectRatioFitterFactory.AddPreferredAspectFitter(bgImage.gameObject, false);
            AspectRatioFitterFactory.MainHudFitters.Add(arf);
        }

        var fitter = AspectRatioFitterFactory.AddPreferredAspectFitter(__instance.gameObject, false);
        AspectRatioFitterFactory.MainHudFitters.Add(fitter);
    }

    /// <summary>
    /// Postfix patch that applies aspect ratio fitter to the main HUD UI.
    /// Ensures the HUD scales according to user's preferred HUD aspect ratio.
    /// </summary>
    /// <param name="__instance">The HUD instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUD), nameof(HUD.Start))]
    public static void HUD_Start(HUD __instance)
    {
        var fitter = AspectRatioFitterFactory.AddPreferredAspectFitter(__instance.ui.gameObject, false);
        AspectRatioFitterFactory.MainHudFitters.Add(fitter);
    }

    /// <summary>
    /// Postfix patch that applies aspect ratio fitter to NPC dialog boxes.
    /// Ensures dialog boxes scale according to user's preferred dialog aspect ratio.
    /// </summary>
    /// <param name="__instance">The NPCDialog instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(NPCDialog), nameof(NPCDialog.Start))]
    public static void NPCDialog_Start(NPCDialog __instance)
    {
        var fitter = AspectRatioFitterFactory.AddPreferredAspectFitter(__instance.gameObject, true);
        AspectRatioFitterFactory.DialogFitters.Add(fitter);
    }

    /// <summary>
    /// Postfix patch that applies restricted aspect ratio fitters to control mapper background elements.
    /// Keeps control mapper backgrounds at native 16:9 aspect ratio for proper display.
    /// </summary>
    /// <param name="__instance">The ControlMapper instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ControlMapper), nameof(ControlMapper.Start))]
    public static void ControlMapper_Start(ControlMapper __instance)
    {
        var bg = __instance.transform.Find("Canvas/BGImage/ContentAreaBG");
        if (bg)
        {
            var fitter = AspectRatioFitterFactory.AddRestrictedFitter(bg.gameObject);
            AspectRatioFitterFactory.RestrictedFitters.Add(fitter);
        }

        var bg1 = __instance.transform.Find("Canvas/BGImage/ContentAreaBG (1)");
        if (bg1)
        {
            var fitter = AspectRatioFitterFactory.AddRestrictedFitter(bg1.gameObject);
            AspectRatioFitterFactory.RestrictedFitters.Add(fitter);
        }
    }
}