using System.Reflection.Emit;
using ScarletMaiden.UI.Utils;

namespace ScarletMaiden.UI.Patches;

/// <summary>
/// Harmony patches for menu-related UI components including pause menus, title screen, and game menus.
/// Handles aspect ratio fitters, background image replacements, and menu-specific UI adjustments.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MenuPatches
{
    /// <summary>
    /// Postfix patch that hides version and copyright text on the title screen.
    /// Removes UI elements that may not display correctly on ultrawide screens.
    /// </summary>
    /// <param name="__instance">The TitleScreen instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.Start))]
    public static void TitleScreen_Start(TitleScreen __instance)
    {
        var version = __instance.transform.Find("MenuBg/Version");
        if (version)
        {
            version.gameObject.SetActive(false);
        }

        var copyright = __instance.transform.Find("MenuBg/Copyright");
        if (copyright)
        {
            copyright.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Postfix patch that replaces the gallery background with an ultrawide-optimized version.
    /// Loads a pre-made ultrawide background sprite and applies proper aspect ratio container.
    /// </summary>
    /// <param name="__instance">The Gallery instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Gallery), nameof(Gallery.Start))]
    public static void Gallery_Start(Gallery __instance)
    {
        var bg = __instance.transform.Find("BG")?.GetComponent<Image>();
        if (bg)
        {
            var newSprite = SpriteUtils.LoadSpriteFromResources($"{bg.sprite.name}_fixed.png", bg.sprite);
            bg.sprite = newSprite;
            SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, "BG", Plugin.MaxAspect);
        }
    }

    /// <summary>
    /// Postfix patch that applies aspect ratio fitter to the pause menu settings tab.
    /// Ensures the settings menu scales properly on ultrawide displays.
    /// </summary>
    /// <param name="__instance">The PauseMenuTabSettings instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenuTabSettings), nameof(PauseMenuTabSettings.Start))]
    public static void PauseMenuTabSettings_Start(PauseMenuTabSettings __instance)
    {
        SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, __instance.name, ResolutionManager.CurrentAspect);
    }

    /// <summary>
    /// Postfix patch that replaces the journal tab background with an ultrawide-optimized version.
    /// Loads and applies ultrawide background sprite with proper aspect ratio container.
    /// </summary>
    /// <param name="__instance">The PauseMenuTabJournal instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenuTabJournal), nameof(PauseMenuTabJournal.Start))]
    public static void PauseMenuTabJournal_Start(PauseMenuTabJournal __instance)
    {
        var image = __instance.GetComponent<Image>();
        if (image)
        {
            var newSprite = SpriteUtils.LoadSpriteFromResources($"{image.sprite.name}_fixed.png", image.sprite);
            image.sprite = newSprite;
        }

        SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, __instance.name, Plugin.MaxAspect);
    }

    /// <summary>
    /// Postfix patch that replaces the character tab background with an ultrawide-optimized version.
    /// Loads and applies ultrawide background sprite with proper aspect ratio container.
    /// </summary>
    /// <param name="__instance">The PauseMenuTabCharacter instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenuTabCharacter), nameof(PauseMenuTabCharacter.Start))]
    public static void PauseMenuTabCharacter_Start(PauseMenuTabCharacter __instance)
    {
        var image = __instance.GetComponent<Image>();
        if (image)
        {
            var newSprite = SpriteUtils.LoadSpriteFromResources($"{image.sprite.name}_fixed.png", image.sprite);
            image.sprite = newSprite;
        }

        SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, __instance.name, Plugin.MaxAspect);
    }

    /// <summary>
    /// Postfix patch that applies aspect ratio fitter to the lewd dungeon menu UI.
    /// Ensures the menu scales according to user's preferred HUD aspect ratio.
    /// </summary>
    /// <param name="__instance">The LewdDungeonMenu instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LewdDungeonMenu), nameof(LewdDungeonMenu.Start))]
    public static void LewdDungeonMenu_Start(LewdDungeonMenu __instance)
    {
        var ui = __instance.transform.Find("MenuUI");
        if (ui)
        {
            var fitter = AspectRatioFitterFactory.AddPreferredAspectFitter(ui.gameObject, false);
            AspectRatioFitterFactory.MainHudFitters.Add(fitter);
        }
    }

    /// <summary>
    /// Postfix patch that replaces the item swap menu background with an ultrawide-optimized version.
    /// Loads ultrawide background sprite and applies proper aspect ratio containers to menu elements.
    /// </summary>
    /// <param name="__instance">The ItemSwapMenu instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ItemSwapMenu), nameof(ItemSwapMenu.Start))]
    public static void ItemSwapMenu_Start(ItemSwapMenu __instance)
    {
        var bgImage = __instance.transform.Find("ItemSwapMenuBG")?.GetComponent<Image>();
        if (bgImage)
        {
            var newSprite = SpriteUtils.LoadSpriteFromResources($"{bgImage.sprite.name}_fixed.png", bgImage.sprite);
            bgImage.sprite = newSprite;
            SpriteUtils.MoveImageToUltraWideContainer(bgImage.transform, "ItemSwapMenuBG", Plugin.MaxAspect);
        }

        SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, __instance.name, Plugin.MaxAspect);
    }

    /// <summary>
    /// Postfix patch that replaces the game over menu background with an ultrawide-optimized version.
    /// Loads ultrawide background sprite and applies proper aspect ratio container.
    /// </summary>
    /// <param name="__instance">The GameOverMenu instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameOverMenu), nameof(GameOverMenu.Start))]
    public static void GameOverMenu_Start(GameOverMenu __instance)
    {
        var bgImage = __instance.transform.Find("BGImage")?.GetComponent<Image>();
        if (bgImage)
        {
            var newSprite = SpriteUtils.LoadSpriteFromResources($"{bgImage.sprite.name}_fixed.png", bgImage.sprite);
            bgImage.sprite = newSprite;
            SpriteUtils.MoveImageToUltraWideContainer(bgImage.transform, "BGImage", Plugin.MaxAspect);
        }
    }

    /// <summary>
    /// Postfix patch that handles skill tree background replacement when pause menu tabs are activated.
    /// Replaces skill tree backgrounds with ultrawide-optimized versions and applies proper aspect ratio containers.
    /// Handles both main menu and in-game skill tree access paths.
    /// </summary>
    /// <param name="__instance">The BasePauseMenuTab instance being activated.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BasePauseMenuTab), nameof(BasePauseMenuTab.OnActivated))]
    public static void BasePauseMenuTab_OnActivated(BasePauseMenuTab __instance)
    {
        if (__instance is PauseMenuTabSkillTree skillTree)
        {
            var bg = skillTree.transform.Find("BG");
            if (bg)
            {
                SpriteUtils.MoveImageToUltraWideContainer(__instance.transform, "BG", Plugin.MaxAspect);

                var image = bg.Find("BGGraphic")?.GetComponent<Image>();
                if (image)
                {
                    var newSprite = SpriteUtils.LoadSpriteFromResources($"{image.sprite.name}_fixed.png", image.sprite);
                    image.sprite = newSprite;
                    SpriteUtils.MoveImageToUltraWideContainer(bg.transform, "BGGraphic", Plugin.MaxAspect);
                }
            }
            else
            {
                var bgGraphic = skillTree.GetComponent<Image>();
                if (bgGraphic)
                {
                    var newSprite = SpriteUtils.LoadSpriteFromResources($"{bgGraphic.sprite.name}_fixed.png", bgGraphic.sprite);
                    bgGraphic.sprite = newSprite;
                    SpriteUtils.MoveImageToUltraWideContainer(bgGraphic.transform, skillTree.name, Plugin.MaxAspect);
                }
            }
        }
    }

    /// <summary>
    /// Disables camera aspect ratio adjustments by setting the loading screen flag.
    /// Used during dungeon transitions to prevent camera flickering.
    /// </summary>
    public static void DisableCameraAdjustments()
    {
        CameraPatches.LoadingScreen = true;
        CameraPatches.UpdateCameras();
    }

    /// <summary>
    /// Re-enables camera aspect ratio adjustments by clearing the loading screen flag.
    /// Called after dungeon transitions complete to restore normal camera behavior.
    /// </summary>
    public static void EnableCameraAdjustments()
    {
        CameraPatches.LoadingScreen = false;
        CameraPatches.UpdateCameras();
    }

    /// <summary>
    /// Transpiler that injects camera adjustment controls during dungeon sub-dungeon transitions.
    /// Disables camera adjustments when the game pauses (SetGamePaused(true, true)) and
    /// re-enables them when unpausing (SetGamePaused(false, true)) to prevent visual glitches.
    /// </summary>
    /// <param name="instructions">The original IL instructions from the method.</param>
    /// <returns>Modified IL instructions with injected DisableCameraAdjustments/EnableCameraAdjustments calls.</returns>
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(DungeonManager), nameof(DungeonManager.SubDungeonTransitionCoroutine))]
    [HarmonyPatch(typeof(DungeonManager), nameof(DungeonManager.SubDungeonTransitionCoroutine), MethodType.Enumerator)]
    public static IEnumerable<CodeInstruction> DungeonManager_SubDungeonTransitionCoroutine_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var code = new List<CodeInstruction>(instructions);
        var modifiedCode = new List<CodeInstruction>(code);

        try
        {
            var disableMethod = AccessTools.Method(typeof(MenuPatches), nameof(DisableCameraAdjustments));
            var enableMethod = AccessTools.Method(typeof(MenuPatches), nameof(EnableCameraAdjustments));
            var setPaused = AccessTools.Method(typeof(GameManager), nameof(GameManager.SetGamePaused));

            for (var i = 0; i < modifiedCode.Count; i++)
            {
                if (!modifiedCode[i].Calls(setPaused)) continue;

                // Check the two instructions before the call for the boolean parameters
                if (i < 2) continue;

                var firstParam = modifiedCode[i - 2];
                var secondParam = modifiedCode[i - 1];

                if (firstParam.opcode == OpCodes.Ldc_I4_1 && secondParam.opcode == OpCodes.Ldc_I4_1)
                {
                    // SetGamePaused(true, true) - inject DisableCameraAdjustments before
                    modifiedCode.Insert(i - 2, new CodeInstruction(OpCodes.Call, disableMethod));
                    i++;
                }
                else if (firstParam.opcode == OpCodes.Ldc_I4_0 && secondParam.opcode == OpCodes.Ldc_I4_1)
                {
                    // SetGamePaused(false, true) - inject EnableCameraAdjustments after
                    modifiedCode.Insert(i + 1, new CodeInstruction(OpCodes.Call, enableMethod));
                    i++;
                }
            }

            return modifiedCode.AsEnumerable();
        }
        catch (Exception e)
        {
            Plugin.Log.LogError($"Transpiler failed in DungeonManager_SubDungeonTransitionCoroutine_Transpiler: {e.Message}");
            return code.AsEnumerable();
        }
    }

    /// <summary>
    /// Postfix patch that replaces dungeon overlay sprite with ultrawide-optimized version.
    /// Called when exiting a sub-dungeon to ensure the overlay displays correctly on ultrawide screens.
    /// </summary>
    /// <param name="__instance">The DungeonManager instance.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonManager), nameof(DungeonManager.OnExitSubDungeon))]
    public static void DungeonManager_OnExitSubDungeon_Postfix(DungeonManager __instance)
    {
        var overlay = __instance.dungeonDisplay.transform.Find("Overlay");
        if (overlay)
        {
            var sr = overlay.GetComponent<SpriteRenderer>();
            if (sr)
            {
                var newSprite = SpriteUtils.LoadSpriteFromResources($"{sr.sprite.name}_fixed.png", sr.sprite);
                sr.sprite = newSprite;
            }
        }
    }
}