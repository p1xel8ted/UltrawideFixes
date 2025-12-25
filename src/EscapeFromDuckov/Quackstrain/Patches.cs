namespace Quackstrain;

/// <summary>
/// Contains all Harmony patches that intercept game UI component initialization to apply ultrawide fixes.
/// Each patch is automatically applied by HarmonyLib when ModBehaviour.OnEnable() calls PatchAll().
/// Patches use Postfix (after original method) or Prefix (before original method) to modify UI behavior.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")] // Harmony uses __instance convention
public static class Patches
{
    // ===== ASPECT RATIO CONSTANTS =====
    /// <summary>Standard 16:9 aspect ratio (1.777...)</summary>
    internal const float SixteenNineAspect = 16f / 9f;

    /// <summary>
    /// Current screen's aspect ratio (e.g., 2.37 for 21:9, 3.55 for 32:9).
    /// Calculated dynamically from Screen.width and Screen.height.
    /// </summary>
    internal static float FullScreenAspect => Screen.width / (float)Screen.height;

    // ===== HUD LAYOUT CONTROLLER CACHING =====
    // The HUD uses LayoutElement mode and needs special handling for cursor positioning
    /// <summary>
    /// Cached reference to the HUD's LayoutController for performance.
    /// Used by AimMarker patch to calculate pillarbox offset without repeated component lookups.
    /// </summary>
    private static LayoutController HUDLayoutController { get; set; }

    /// <summary>
    /// Tracks whether we've attempted to find the HUDLayoutController.
    /// Prevents repeated expensive GetComponentInParent calls in hot path (every frame during aiming).
    /// </summary>
    private static bool _hudLayoutControllerSearched;

    /// <summary>
    /// Tracks whether we've logged a warning about missing HUDLayoutController.
    /// Prevents log spam when controller cannot be found.
    /// </summary>
    private static bool _hudLayoutControllerWarningLogged;

    // ===== HELPER METHODS =====
    /// <summary>
    /// Wraps patch execution in try-catch to prevent mod from crashing the game on errors.
    /// All patch methods use this wrapper for defensive error handling.
    /// Logs full exception details to help with debugging.
    /// </summary>
    /// <param name="action">The patch logic to execute</param>
    /// <param name="patchName">The name of the patch method (for logging)</param>
    private static void SafePatchExecution(Action action, string patchName)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            // Log error with stack trace but don't crash the game
            Tools.Log($"{patchName} failed: {ex.Message}\n{ex.StackTrace}", Tools.LogLevel.Error);
        }
    }

    /// <summary>
    /// Helper method to add a LayoutController and log the operation.
    /// Reduces code duplication across patch methods (DRY principle).
    /// </summary>
    /// <param name="transform">The Transform to add the LayoutController to</param>
    /// <param name="size">Layout size mode (FullScreen, SixteenNine, or Custom)</param>
    /// <param name="customSize">Custom value when using LayoutSize.Custom</param>
    /// <param name="useAspectRatioFitter">true for AspectRatioFitter mode, false for LayoutElement mode</param>
    /// <param name="contextName">Context for logging (e.g., "MainMenu_Awake")</param>
    /// <returns>The created or existing LayoutController</returns>
    private static LayoutController AddAndLogLayoutController(
        Transform transform,
        LayoutController.LayoutSize size,
        float customSize,
        bool useAspectRatioFitter,
        string contextName)
    {
        var lc = LayoutController.AddLayoutControllerRoot(transform, size, customSize, useAspectRatioFitter);
        Tools.Log($"{contextName} Applied LayoutController with LayoutSize: {lc.GetLayoutSize()}");
        return lc;
    }

    /// <summary>
    /// Helper method to add a LayoutController to a child found by path and log the operation.
    /// Convenience wrapper combining Transform.Find with AddAndLogLayoutController.
    /// </summary>
    /// <param name="transform">The parent Transform to search from</param>
    /// <param name="path">The child path (e.g., "BG" or "Content/Viewport")</param>
    /// <param name="size">Layout size mode</param>
    /// <param name="customSize">Custom value when using LayoutSize.Custom</param>
    /// <param name="useAspectRatioFitter">true for AspectRatioFitter mode, false for LayoutElement mode</param>
    /// <param name="contextName">Context for logging</param>
    private static void AddAndLogLayoutControllerPath(Transform transform,
        string path,
        LayoutController.LayoutSize size,
        float customSize,
        bool useAspectRatioFitter,
        string contextName)
    {
        var lc = LayoutController.AddLayoutControllerPath(transform, path, size, customSize, useAspectRatioFitter);
        Tools.Log($"{contextName} Applied LayoutController with LayoutSize: {lc.GetLayoutSize()}");
    }

    /// <summary>
    /// Harmony patch for TaskSkipperUI (task progression UI overlay).
    /// Applies 16:9 aspect ratio constraint using AspectRatioFitter to prevent UI stretching on ultrawide monitors.
    /// </summary>
    /// <param name="__instance">The TaskSkipperUI instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(TaskSkipperUI), nameof(TaskSkipperUI.Awake))]
    public static void TaskSkipperUI_Awake(TaskSkipperUI __instance)
    {
        SafePatchExecution(() => { AddAndLogLayoutController(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, true, "TaskSkipperUI_Awake"); }, nameof(TaskSkipperUI_Awake));
    }

    /// <summary>
    /// Harmony patch for ModChangedWarning (warning dialog when mod configuration changes).
    /// Moves the background Image component to a dedicated holder with full-screen layout.
    /// This ensures the warning overlay background fills the entire ultrawide display instead of being constrained to 16:9.
    /// </summary>
    /// <param name="__instance">The ModChangedWarning instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(ModChangedWarning), nameof(ModChangedWarning.Awake))]
    public static void ModChangedWarning_Awake(ModChangedWarning __instance)
    {
        SafePatchExecution(() => { Tools.MoveImageToHolder(__instance.transform); }, nameof(ModChangedWarning_Awake));
    }

    /// <summary>
    /// Harmony patch for UIPanel.Open (base class for various game UI panels).
    /// Specifically handles PauseMenu to apply 16:9 aspect ratio constraint and move blur effect to full-screen holder.
    /// The TranslucentImage (blur) is moved to ensure the background blur covers the entire ultrawide display
    /// while the menu content remains in 16:9 aspect ratio with pillarboxing.
    /// </summary>
    /// <param name="__instance">The UIPanel instance being opened (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(UIPanel), nameof(UIPanel.Open))]
    public static void UIPanel_Open(UIPanel __instance)
    {
        SafePatchExecution(() =>
        {
            if (__instance is PauseMenu pm)
            {
                AddAndLogLayoutController(pm.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, true, "UIPanel_Open");
                Tools.MoveTranslucentImageToHolder(pm.transform);
            }
        }, nameof(UIPanel_Open));
    }

    /// <summary>
    /// Harmony patch for ModManagerUI (in-game mod management interface).
    /// Applies dual layout strategy:
    /// - Main UI: 16:9 aspect ratio to keep mod list and controls properly proportioned
    /// - BG child: Full-screen to ensure background fills entire ultrawide display
    /// This creates a visually pleasing layout with centered content and full-width background.
    /// </summary>
    /// <param name="__instance">The ModManagerUI instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(ModManagerUI), nameof(ModManagerUI.Awake))]
    public static void ModManagerUI_Awake(ModManagerUI __instance)
    {
        SafePatchExecution(() =>
        {
            AddAndLogLayoutController(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, true, "ModManagerUI_Awake");
            AddAndLogLayoutControllerPath(__instance.transform, "BG", LayoutController.LayoutSize.ForceFullScreen, 0f, true, "ModManagerUI_Awake BG");
        }, nameof(ModManagerUI_Awake));
    }

    /// <summary>
    /// Harmony patch for HUDManager (heads-up display during gameplay).
    /// Applies 16:9 layout using LayoutElement mode (useAspectRatioFitter: false) instead of AspectRatioFitter.
    /// LayoutElement mode provides precise width calculations needed for the AimMarker patch to correctly
    /// calculate pillarbox offset for cursor positioning on ultrawide monitors.
    /// Caches the LayoutController reference in HUDLayoutController for AimMarker_SetAimMarkerPosScreenSpace performance.
    /// </summary>
    /// <param name="__instance">The HUDManager instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(HUDManager), nameof(HUDManager.Awake))]
    public static void HUDManager_Awake(HUDManager __instance)
    {
        SafePatchExecution(() => { HUDLayoutController = AddAndLogLayoutController(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false, "HUDManager_Awake"); }, nameof(HUDManager_Awake));
    }

    /// <summary>
    /// Harmony PREFIX patch for AimMarker.SetAimMarkerPosScreenSpace (cursor/reticle positioning during aiming).
    /// Adjusts the aim marker position to account for pillarboxing on ultrawide monitors.
    ///
    /// Critical performance optimization: Uses cached HUDLayoutController reference from HUDManager_Awake patch.
    /// Falls back to GetComponentInParent lookup only once if cache is empty (e.g., HUD loaded before mod).
    ///
    /// Pillarbox calculation: When HUD is constrained to 16:9 with black bars on sides,
    /// the game provides screen-space coordinates (0 to Screen.width). We subtract the pillarbox offset
    /// to translate coordinates into the 16:9 content area where the HUD actually renders.
    /// </summary>
    /// <param name="__instance">The AimMarker instance (Harmony injection parameter)</param>
    /// <param name="pos">The screen-space position to modify (ref parameter modified by Harmony)</param>
    [HarmonyPrefix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(AimMarker), nameof(AimMarker.SetAimMarkerPosScreenSpace))]
    public static void AimMarker_SetAimMarkerPosScreenSpace(AimMarker __instance, ref Vector3 pos)
    {
        try
        {
            // Lazy initialization: Try to find HUDLayoutController if not already cached
            if (!HUDLayoutController && !_hudLayoutControllerSearched)
            {
                HUDLayoutController = __instance.GetComponentInParent<LayoutController>();
                _hudLayoutControllerSearched = true;

                if (!HUDLayoutController && !_hudLayoutControllerWarningLogged)
                {
                    Tools.Log("AimMarker_SetAimMarkerPosScreenSpace: Could not find HUDLayoutController, aim position may be incorrect on ultrawide monitors", Tools.LogLevel.Warning);
                    _hudLayoutControllerWarningLogged = true;
                }
            }

            // Calculate and apply pillarbox offset if HUD layout is available
            if (HUDLayoutController && HUDLayoutController.GetLayoutElementWidth() > 0)
            {
                var pillarbox = (Screen.width - HUDLayoutController.GetLayoutElementWidth()) / 2f;
                pos.x -= pillarbox; // Translate from full screen space to 16:9 content space
            }
        }
        catch (Exception ex)
        {
            Tools.Log($"AimMarker_SetAimMarkerPosScreenSpace failed: {ex.Message}", Tools.LogLevel.Error);
        }
    }

    /// <summary>
    /// Harmony patch for MainMenu (game's main menu screen).
    /// Applies 16:9 aspect ratio to the MainMenuContainer to prevent menu stretching on ultrawide displays.
    ///
    /// Special handling: Uses Tools.FindMainMenuContainer() to locate the correct canvas hierarchy
    /// since the main menu structure differs from in-game UI. Logs error if container cannot be found.
    /// </summary>
    /// <param name="__instance">The MainMenu instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.Awake))]
    public static void MainMenu_Awake(MainMenu __instance)
    {
        SafePatchExecution(() =>
        {
            // Find the MainMenuContainer in the scene (not a direct child of MainMenu)
            var mainCanvas = Tools.FindMainMenuContainer();
            if (!mainCanvas)
            {
                Tools.Log("MainMenu_Awake: Could not find MainMenuContainer!", Tools.LogLevel.Error);
                return;
            }

            AddAndLogLayoutController(mainCanvas, LayoutController.LayoutSize.ForceSixteenNine, 0f, true, "MainMenu_Awake");
        }, nameof(MainMenu_Awake));
    }


    /// <summary>
    /// Harmony patch for ModUploadPanel (Steam Workshop mod upload interface).
    /// Applies dual layout strategy:
    /// - Root transform: Full-screen for background overlay
    /// - PanelContainer child: 16:9 aspect ratio for upload form and controls
    /// This creates a full-screen dimmed background with centered upload dialog on ultrawide monitors.
    /// </summary>
    /// <param name="__instance">The ModUploadPanel instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(ModUploadPanel), nameof(ModUploadPanel.Awake))]
    public static void ModUploadPanel_Awake(ModUploadPanel __instance)
    {
        SafePatchExecution(() =>
        {
            AddAndLogLayoutController(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, true, "ModUploadPanel_Awake (BG)");
            AddAndLogLayoutControllerPath(__instance.transform, "PanelContainer", LayoutController.LayoutSize.ForceSixteenNine, 0f, true, "ModUploadPanel_Awake (Content)");
        }, nameof(ModUploadPanel_Awake));
    }


    /// <summary>
    /// Harmony patch for GameplayUIManager (manages various in-game UI views during gameplay).
    /// Applies 16:9 aspect ratio to all registered UI views in the manager's views collection.
    ///
    /// Iterates through all views and applies consistent 16:9 layout to each, ensuring all gameplay UI
    /// elements (inventory, crafting, journal, etc.) maintain proper proportions on ultrawide monitors.
    /// Null checks each view before applying layout controller.
    /// </summary>
    /// <param name="__instance">The GameplayUIManager instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(GameplayUIManager), nameof(GameplayUIManager.Awake))]
    public static void GameplayUIManager_Awake(GameplayUIManager __instance)
    {
        SafePatchExecution(() =>
        {
            // Apply 16:9 layout to each gameplay view (inventory, crafting, etc.)
            foreach (var view in __instance.views.Where(view => view))
            {
                AddAndLogLayoutController(view.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, true, $"GameplayUIManager_Awake (view: {view.name})");
            }
        }, nameof(GameplayUIManager_Awake));
    }

    /// <summary>
    /// Harmony patch for ClosureView (end-game closure/credits screen).
    /// Applies full-screen layout to the "Image" child element to ensure the closure screen
    /// fills the entire ultrawide display without letterboxing or pillarboxing.
    /// </summary>
    /// <param name="__instance">The ClosureView instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(ClosureView), nameof(ClosureView.Awake))]
    public static void ClosureView_Awake(ClosureView __instance)
    {
        SafePatchExecution(() => { AddAndLogLayoutControllerPath(__instance.transform, "Image", LayoutController.LayoutSize.ForceFullScreen, 0f, true, "ClosureView_Awake"); }, nameof(ClosureView_Awake));
    }

    /// <summary>
    /// Harmony patch for MapMarkerManager (in-game map marker placement UI).
    /// Applies complex multi-element layout configuration for ultrawide support:
    ///
    /// 1. Top/Bottom viewport elements: Full-screen using LayoutElement mode (useAspectRatioFitter: false)
    ///    to ensure map marker boundaries extend across entire ultrawide display
    /// 2. TranslucentImage blur effect: Moved to dedicated holder with full-screen layout so background
    ///    blur covers the entire screen instead of being constrained to 16:9
    ///
    /// This creates an immersive map overlay experience on ultrawide monitors with full-width blur
    /// and properly positioned marker boundaries.
    /// </summary>
    /// <param name="__instance">The MapMarkerManager instance being initialized (Harmony injection parameter)</param>
    [HarmonyPostfix]
    [UsedImplicitly]
    [HarmonyPatch(typeof(MapMarkerManager), nameof(MapMarkerManager.Awake))]
    public static void MapMarkerManager_Awake(MapMarkerManager __instance)
    {
        SafePatchExecution(() =>
        {
            // Apply full-screen layout to top and bottom viewport boundaries (LayoutElement mode for precise control)
            AddAndLogLayoutControllerPath(__instance.transform, "Content/Scroll View/Viewport/Top", LayoutController.LayoutSize.ForceFullScreen, 0f, false, "MapMarkerManager_Awake Top");
            AddAndLogLayoutControllerPath(__instance.transform, "Content/Scroll View/Viewport/Bottom", LayoutController.LayoutSize.ForceFullScreen, 0f, false, "MapMarkerManager_Awake Bottom");

            // Move blur effect to full-screen holder for edge-to-edge background coverage
            var parent = __instance.transform.Find("Content");
            if (parent)
            {
                Tools.MoveTranslucentImageToHolder(parent);
            }
        }, nameof(MapMarkerManager_Awake));
    }
}