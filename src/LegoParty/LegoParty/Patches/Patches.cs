namespace LegoParty.Patches;

/// <summary>
/// Harmony patches for ultrawide support. Removes letterboxing, adjusts UI elements,
/// and ensures cameras and render textures use the correct resolution.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    /// <summary>
    /// Destroys the letterbox overlay that creates black bars on ultrawide displays.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LetterboxOverlay), nameof(LetterboxOverlay.Start))]
    [HarmonyPatch(typeof(LetterboxOverlay), nameof(LetterboxOverlay.StartAsync))]
    private static void LetterboxOverlay_Start(LetterboxOverlay __instance)
    {
        if (!__instance.gameObject) return;

        var goName = __instance.gameObject.name;
        var sceneName = __instance.gameObject.scene.name;
        Object.Destroy(__instance.gameObject);
        Plugin.Logger.LogInfo($"[LetterboxOverlay_Start] Destroyed LetterboxOverlay on GameObject '{goName}' in scene {sceneName}");
    }

    /// <summary>
    /// Constrains the settings panel container to 16:9 to prevent UI stretching.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsScreen), nameof(SettingsScreen.OnSetup))]
    [HarmonyPatch(typeof(SettingsScreen), nameof(SettingsScreen.OnShow))]
    private static void SettingsScreen_OnSetup(SettingsScreen __instance)
    {
        if (!__instance._accessibilityPanel) return;

        var panels = __instance._accessibilityPanel.transform.parent;
        if (!panels)
        {
            Plugin.Logger.LogWarning($"[SettingsScreen_OnSetup] AccessibilityPanel parent not found on SettingsScreen '{__instance.gameObject.name}'");
            return;
        }

        var arf = panels.gameObject.GetOrAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = Plugin.NativeAspectRatio;
        Plugin.Logger.LogInfo($"[SettingsScreen_OnSetup] Added AspectRatioFitter to SettingsScreen AccessibilityPanel parent '{panels.gameObject.name}' to enforce aspect ratio {Plugin.NativeAspectRatio}");
    }

    /// <summary>
    /// Scales the minigame loading wipe screen uniformly to cover the full ultrawide display.
    /// Uses uniform X+Y scaling to preserve the LEGO brick pattern.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MinigameWipeScreen), nameof(MinigameWipeScreen.Play))]
    [HarmonyPatch(typeof(MinigameWipeScreen), nameof(MinigameWipeScreen.Awake))]
    private static void MinigameWipeScreen_Play(MinigameWipeScreen __instance)
    {
        __instance.transform.localScale = __instance.transform.localScale with { x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor };
        Plugin.Logger.LogInfo($"[MinigameWipeScreen_Play] Adjusted MinigameWipeScreen scale on GameObject '{__instance.gameObject.name}' to x scale {__instance.transform.localScale.x} to accommodate aspect ratio {Plugin.MainAspectRatio}");
    }

    /// <summary>
    /// Expands the horizontal backing strips in player setup header to span the full width.
    /// Only scales X since these are horizontal bars.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerSetupHeader), nameof(PlayerSetupHeader.Initialize))]
    private static void PlayerSetupHeader_Initialize(PlayerSetupHeader __instance)
    {
        var bg1 = __instance._offlineContainer ? __instance._offlineContainer.FindChild("BackingStrip") : null;
        var bg2 = __instance._onlineContainer ? __instance._onlineContainer.FindChild("BackingStrip") : null;

        foreach (var bg in new[] { bg1, bg2 })
        {
            if (!bg)
            {
                Plugin.Logger.LogWarning($"[PlayerSetupHeader_Initialize] BackingStrip not found on PlayerSetupHeader '{__instance.gameObject.name}'");
                continue;
            }

            bg.localScale = bg.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Logger.LogInfo($"[PlayerSetupHeader_Initialize] Adjusted BackingStrip scale on PlayerSetupHeader '{bg.gameObject.name}' to x scale {bg.localScale.x} to accommodate aspect ratio {Plugin.MainAspectRatio}");
        }
    }

    /// <summary>
    /// Constrains the player slot container to 16:9 to prevent UI stretching.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerSetupScreen), nameof(PlayerSetupScreen.OnSetup))]
    [HarmonyPatch(typeof(PlayerSetupScreen), nameof(PlayerSetupScreen.OnShow))]
    private static void PlayerSetupScreen_OnSetup(PlayerSetupScreen __instance)
    {
        var selections = __instance._slotContainer;
        if (selections)
        {
            var arf = selections.gameObject.GetOrAddComponent<AspectRatioFitter>();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.NativeAspectRatio;
            Plugin.Logger.LogInfo($"[PlayerSetupScreen_OnSetup] Added AspectRatioFitter to PlayerSetupScreen SlotContainer '{selections.gameObject.name}' to enforce aspect ratio {Plugin.NativeAspectRatio}");
        }
        else
        {
            Plugin.Logger.LogWarning($"[PlayerSetupScreen_OnSetup] SlotContainer not found on PlayerSetupScreen '{__instance.gameObject.name}'");
        }
    }

    /// <summary>
    /// Adjusts the main menu play screen modal bar for ultrawide:
    /// - Expands the black background to fill the screen
    /// - Centers the LEGO box backing (offset too far right at ultrawide)
    /// - Expands the LEGO box width with padding
    /// - Disables TopEdging (decorative element with no functionality)
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuPlayScreen), nameof(MainMenuPlayScreen.OnSetup))]
    [HarmonyPatch(typeof(MainMenuPlayScreen), nameof(MainMenuPlayScreen.OnShow))]
    private static void MainMenuPlayScreen_OnSetup(MainMenuPlayScreen __instance)
    {
        if (!__instance.ModalBar) return;

        // Expand black background to fill ultrawide
        var blackBg = __instance.ModalBar._modalBackingContent;
        if (blackBg)
        {
            var arf = blackBg.GetOrAddComponent<AspectRatioFitter>();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.MainAspectRatio;
            Plugin.Logger.LogInfo($"[MainMenuPlayScreen_OnSetup] Added AspectRatioFitter to MainMenuPlayScreen ModalBar '{blackBg.gameObject.name}' to enforce aspect ratio {Plugin.MainAspectRatio}");
        }
        else
        {
            Plugin.Logger.LogWarning($"[MainMenuPlayScreen_OnSetup] ModalBar _modalBackingContent not found on MainMenuPlayScreen '{__instance.gameObject.name}'");
        }

        var raiser = __instance.ModalBar._raiser;
        if (raiser)
        {
            var legoBox = raiser.transform.FindChild("Backing");
            if (legoBox)
            {
                // Center the LEGO box - it's offset too far right at ultrawide
                legoBox.localPosition = legoBox.localPosition with { x = 0 };
                Plugin.Logger.LogInfo($"[MainMenuPlayScreen_OnSetup] Adjusted Lego Box position on MainMenuPlayScreen ModalBar '{legoBox.gameObject.name}'");

                // Expand width with padding (10f found through testing)
                var legoBoxRect = legoBox.GetComponent<RectTransform>();
                if (legoBoxRect)
                {
                    legoBoxRect.sizeDelta = legoBoxRect.sizeDelta with { x = legoBoxRect.sizeDelta.x * (Plugin.PositiveScaleFactor + 10f) };
                    Plugin.Logger.LogInfo($"[MainMenuPlayScreen_OnSetup] Adjusted Lego Box size on MainMenuPlayScreen ModalBar '{legoBox.gameObject.name}' to width {legoBoxRect.sizeDelta.x}");
                }
                else
                {
                    Plugin.Logger.LogWarning($"[MainMenuPlayScreen_OnSetup] RectTransform not found on MainMenuPlayScreen ModalBar Backing '{legoBox.gameObject.name}'");
                }
            }
            else
            {
                Plugin.Logger.LogWarning($"[MainMenuPlayScreen_OnSetup] Backing not found on MainMenuPlayScreen ModalBar Raiser '{raiser.gameObject.name}'");
            }

            // Disable decorative top edging (no functionality)
            var topEdging = raiser.transform.FindChild("TopEdging");
            if (topEdging)
            {
                topEdging.gameObject.SetActive(false);
                Plugin.Logger.LogInfo($"[MainMenuPlayScreen_OnSetup] Disabled TopEdging on MainMenuPlayScreen ModalBar '{topEdging.gameObject.name}'");
            }
            else
            {
                Plugin.Logger.LogWarning($"[MainMenuPlayScreen_OnSetup] TopEdging not found on MainMenuPlayScreen ModalBar Raiser '{raiser.gameObject.name}'");
            }
        }
    }

    /// <summary>
    /// Attaches CameraAspectEnforcer to game cameras and resizes their render textures.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraNode), nameof(CameraNode.OnEnable))]
    private static void CameraNode_OnEnable(CameraNode __instance)
    {
        if (__instance.Camera)
        {
            __instance.Camera.gameObject.GetOrAddComponent<CameraAspectEnforcer>();
            Plugin.Logger.LogInfo($"[CameraNode_OnEnable] Added CameraAspectEnforcer to CameraNode '{__instance.gameObject.name}' in scene {__instance.gameObject.scene.name} to enforce aspect ratio {Plugin.MainAspectRatio}");

            var rt = __instance.Camera.targetTexture;

            if (!rt) return;

            Plugin.Logger.LogInfo($"[CameraNode_OnEnable] Adjusting render texture on CameraNode '{__instance.gameObject.name}' to {Plugin.MainWidth}x{Plugin.MainHeight}");
            rt.Release();
            rt.width = Plugin.MainWidth;
            rt.height = Plugin.MainHeight;
            rt.Create();
        }
        else
        {
            Plugin.Logger.LogWarning($"[CameraNode_OnEnable] Camera not found on CameraNode '{__instance.gameObject.name}' in scene {__instance.gameObject.scene.name}");
        }
    }

    /// <summary>
    /// Sets CanvasScaler to Expand mode to properly fill ultrawide displays.
    /// Excludes UnityExplorer UI (contains "sinai" in name).
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}