// ReSharper disable InconsistentNaming


// Main namespace for the Hollow Knight Silksong Ultra-Wide mod
namespace HollowKnightSilkSong;

/// <summary>
/// Contains all Harmony patches and runtime logic for the Hollow Knight Silksong Ultra-Wide mod.
/// Handles UI scaling, border fixes, HUD offset, and config-driven visual changes.
/// </summary>
[Harmony]
public static class Patches
{
    // Stores the original screen match mode for each CanvasScaler instance, so it can be restored if needed
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    // Tracks all CanvasScaler components for aspect ratio adjustments
    private static readonly List<CanvasScaler> CanvasScalers = [];
    // WriteOnce wrappers to store original sizes for UI elements and prevent accidental overwrites
    private static readonly WriteOnce<float> OriginalBorderSize = new();
    private static readonly WriteOnce<float> OriginalBackboardSize = new();
    private static readonly WriteOnce<float> OriginalMapSize = new();
    // Cached config values for performance and consistency
    private static bool _cachedHeroLight;
    private static bool _cachedHeroLightDonut;
    private static bool _cachedVignette;
    private static float _cachedVignetteAlpha;
    private static float _cachedFieldOfView;
    private static float _cachedHudOffset;
    private static readonly WriteOnce<float> OriginalFOV = new();
    // References to specific UI and light transforms for runtime manipulation
    private static SpriteRenderer DonutLightTransform { get; set; }
    private static WriteOnce<float> OriginalAlpha { get; } = new();
    private static Transform AnchorTransform { get; set; }
    private static WriteOnce<float> OriginalVignetteAlpha { get; } = new();
    private static WriteOnce<Vector3> OriginalVignetteSize { get; } = new();


    /// <summary>
    /// Cleans up all cached and tracked state for the mod, typically called on plugin unload.
    /// </summary>
    internal static void Cleanup()
    {
        // Clear tracked CanvasScalers and screen match modes
        CanvasScalers.Clear();
        OriginalScreenMatchModes.Clear();
        TrackedBorders.Clear();

        // Reset references to transforms and WriteOnce values
        DonutLightTransform = null;
        AnchorTransform = null;
        OriginalAlpha.ResetValue();
        OriginalBorderSize.ResetValue();
        OriginalBackboardSize.ResetValue();
        OriginalMapSize.ResetValue();
        OriginalFOV.ResetValue();
        OriginalVignetteAlpha.ResetValue();
        OriginalVignetteSize.ResetValue();
    }


    /// <summary>
    /// Updates cached config values for performance and triggers border updates if edge fix settings changed.
    /// </summary>
    internal static void UpdateConfigCache()
    {
        _cachedHeroLight = Plugin.HeroLight.Value;
        _cachedHeroLightDonut = Plugin.ReduceHeroLight.Value;
        _cachedVignette = Plugin.Vignette.Value;
        _cachedFieldOfView = Plugin.CameraFieldOfView.Value;
        _cachedHudOffset = Plugin.HudOffset.Value;
        _cachedVignetteAlpha = Plugin.VignetteAlpha.Value;
        var currentScaleState = Plugin.ShouldScaleBlackEdges;
        var currentFeatherState = Plugin.ShouldRemoveFeathering;

        // Only update borders if scale or feathering state changed
        if (currentScaleState != _lastScaleState || currentFeatherState != _lastFeatherState)
        {
            UpdateAllBorders();
            _lastScaleState = currentScaleState;
            _lastFeatherState = currentFeatherState;
        }
    }

    //rotation 0 0 0 == left edge
    //rotation 0 0 180 = right edge
    //rotation 0 0 90 == bottom edge
    //rotation 0 0 270 == top edge

    internal static void UpdateAllBorders()
    {
        var scaleFactor = Plugin.ShouldScaleBlackEdges ? 5f : 1f;
        var showFeathering = Plugin.ShouldScaleBlackEdges && !Plugin.ShouldRemoveFeathering;

        Plugin.Log.LogInfo($"[BORDERS] Updating {TrackedBorders.Count} borders - Scale: {scaleFactor}, Feathering: {showFeathering}");

        foreach (var border in TrackedBorders)
        {
            if (!border.GameObject) continue;

            // Only scale left/right borders
            var isLeftBorder = Mathf.Approximately(border.FinalRotation.z, 0f);
            var isRightBorder = Mathf.Approximately(border.FinalRotation.z, 180f);
        
            if (isLeftBorder || isRightBorder)
            {
                var transform = border.GameObject.transform;
            
                // Calculate new border width
                var newX = border.OriginalScaleX * scaleFactor;
            
                // Update scale
                var newScale = border.FinalScale;
                newScale.x = newX;
                transform.localScale = newScale;
            
                // Recalculate position based on new border width
                var newPos = border.FinalPosition;
                if (isLeftBorder)
                {
                    // Left border: position.x = -(x/2)
                    newPos.x = -(newX / 2f);
                }
                else  // Must be right border
                {
                    // Right border: position.x = sceneWidth + (x/2)
                    newPos.x = border.SceneWidth + newX / 2f;
                }
                transform.localPosition = newPos;
            
                // Force Unity to update
                transform.hasChanged = true;
            }
        
            // Update feathered edge for all borders
            if (border.FeatheredEdge)
            {
                border.FeatheredEdge.SetActive(showFeathering);
            }
        }

        TrackedBorders.RemoveAll(b => !b.GameObject);
    }


    /// <summary>
    /// Updates all CanvasScaler components to use Expand mode if aspect ratio exceeds native, otherwise restores original mode.
    /// </summary>
    private static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            // Store original screen match mode if not already tracked
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            // Use Expand mode for ultra-wide, otherwise restore original
            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }


    /// <summary>
    /// Updates the HUD anchor's X position to match the configured HUD offset.
    /// </summary>
    internal static void UpdateHudOffset()
    {
        if (AnchorTransform)
        {
            AnchorTransform.localPosition = AnchorTransform.localPosition with { x = _cachedHudOffset };
        }
    }


    /// <summary>
    /// Harmony prefix patch for HUDCamera.SetIsGameplayMode. Sets up anchor transform for HUD offset when entering gameplay mode.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HUDCamera), nameof(HUDCamera.SetIsGameplayMode))]
    public static void HUDCamera_SetIsGameplayMode(HUDCamera __instance, bool isGameplayMode)
    {
        if (!isGameplayMode) return;

        var anchor = __instance.transform.Find("In-game/Anchor TL");
        if (!anchor) return;
        AnchorTransform = anchor;
        UpdateHudOffset();
    }

    /// <summary>
    /// Harmony prefix patch for MenuResolutionSetting.ResetToDefaultResolution.
    /// Forces resolution reset to use the native display resolution instead of a predetermined default.
    /// Prevents the original method from executing by returning false.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MenuResolutionSetting), nameof(MenuResolutionSetting.ResetToDefaultResolution))]
    public static bool MenuResolutionSetting_ResetToDefaultResolution(MenuResolutionSetting __instance)
    {
        // Set resolution to native display size in fullscreen windowed mode
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow);
        // Update the current resolution tracking
        __instance.currentRes = Screen.currentResolution;
        // Refresh the UI on the next frame to reflect changes
        __instance.StartCoroutine(__instance.RefreshOnNextFrame());
        // Skip original method execution
        return false;
    }


    /// <summary>
    /// Harmony postfix patch for MenuResolutionSetting.RefreshAvailableResolutions.
    /// Updates the available resolutions in the settings menu, optionally restricting to native resolution only.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuResolutionSetting), nameof(MenuResolutionSetting.RefreshAvailableResolutions))]
    public static void MenuResolutionSetting_RefreshAvailableResolutions(MenuResolutionSetting __instance)
    {
        // Extract all unique refresh rates from available system resolutions
        // This ensures we can offer native resolution at all supported refresh rates
        var refreshRates = Screen.resolutions
            .Select(r => r.refreshRateRatio)    // Get refresh rate from each resolution
            .Distinct()                         // Remove duplicates
            .OrderBy(r => r)                    // Sort ascending
            .ToArray();

        var resList = new List<Resolution>();

        // Add all system resolutions if user wants full list, otherwise only native
        if (!Plugin.ShowMainResolutionOnly.Value)
        {
            resList.AddRange(Screen.resolutions);
        }
#if DEBUG
        const int resWidth = Plugin.TestWidth;
        const int resHeight = Plugin.TestHeight;
#else
        var resWidth = Display.main.systemWidth;
        var resHeight = Display.main.systemHeight;
#endif
        // Create native resolution entries for each available refresh rate
        // This ensures users can select native resolution at any supported refresh rate
        resList.AddRange(refreshRates.Select(refreshRate => new Resolution { width = resWidth, height = resHeight, refreshRateRatio = refreshRate }));

        // Remove duplicate resolutions and sort by dimensions, then refresh rate
        var unique = resList
            .Distinct(new ResolutionComparer())         // Remove duplicates using custom comparer
            .OrderBy(r => r.width)                      // Primary sort: width (ascending)
            .ThenBy(r => r.height)                      // Secondary sort: height (ascending)
            .ThenBy(r => r.refreshRateRatio.value)      // Tertiary sort: refresh rate (ascending)
            .ToArray();

        __instance.availableResolutions = unique;
        __instance.RefreshCurrentIndex();
        __instance.PushUpdateOptionList();
        __instance.UpdateText();
    }


    /// <summary>
    /// Harmony postfix patch for MenuButtonList.SetupActive.
    /// Shows or hides the Extras button in the main menu based on the MenuClutter config setting.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuButtonList), nameof(MenuButtonList.SetupActive))]
    public static void MenuButtonList_SetupActive(MenuButtonList __instance)
    {
        foreach (var entry in __instance.entries)
        {
            if (entry.selectable.name == "ExtrasButton")
            {
                entry.selectable.gameObject.SetActive(Plugin.MenuClutter.Value);
            }
        }
    }

    /// <summary>
    /// Harmony postfix patch for ForceCameraAspect.Awake.
    /// Sets the current viewport aspect ratio to match the plugin's calculated aspect.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.Awake))]
    public static void ForceCameraAspect_Awake()
    {
        ForceCameraAspect.CurrentViewportAspect = Plugin.CurrentAspect;
    }

    /// <summary>
    /// Harmony prefix patch for ForceCameraAspect.SetOverscanViewport.
    /// Disables overscan adjustment by forcing the value to zero.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.SetOverscanViewport))]
    public static void ForceCameraAspect_SetOverscanViewport(ref float adjustment)
    {
        adjustment = 0;
    }

    /// <summary>
    /// Harmony postfix patch for ForceCameraAspect.AutoScaleViewport.
    /// Forces the viewport aspect ratio to match the plugin's calculated aspect.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.AutoScaleViewport))]
    public static void ForceCameraAspect_AutoScaleViewport(ref float __result)
    {
        __result = Plugin.CurrentAspect;
    }


    /// <summary>
    /// Harmony postfix patch for VideoMenuOptions.ConfigureNavigation.
    /// Hides the screen scale option in the video menu for clarity.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoMenuOptions), nameof(VideoMenuOptions.ConfigureNavigation))]
    public static void VideoMenuOptions_ConfigureNavigation(VideoMenuOptions __instance)
    {
        __instance.screenScaleOption.gameObject.SetActive(false);
    }

    /// <summary>
    /// Harmony postfix patch for HeroController.FixedUpdate.
    /// Updates hero light, donut light, and vignette effect based on plugin config values.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroController), nameof(HeroController.FixedUpdate))]
    public static void HeroController_FixedUpdate(HeroController __instance)
    {
        // Control hero light visibility and intensity
        if (__instance.heroLight)
        {
            // Store original alpha once, then apply configured setting
            OriginalAlpha.Value = __instance.heroLight.Alpha;
            __instance.heroLight.Alpha = _cachedHeroLight ? OriginalAlpha.Value : 0f;
        }

        // Control donut light sprite (inner glow effect)
        // Use null-coalescing assignment to find the sprite renderer only once
        DonutLightTransform ??= __instance.transform.Find("HeroLight/white_light_donut")?.GetComponent<SpriteRenderer>();
        if (DonutLightTransform)
        {
            // Invert the setting: true = reduce light = disable sprite
            DonutLightTransform.enabled = !_cachedHeroLightDonut;
        }

        // Control vignette effect (screen darkening around edges)
        if (!__instance.vignette) return;
        __instance.vignette.enabled = _cachedVignette;
        if (!__instance.vignette.enabled) return;   // Skip alpha changes if vignette is disabled

        // Store original alpha and apply configured intensity
        OriginalVignetteAlpha.Value = __instance.vignette.color.a;
        __instance.vignette.color = __instance.vignette.color with { a = _cachedVignetteAlpha };
    }

    /// <summary>
    /// Harmony prefix patch for tk2dCamera.UpdateCameraMatrix.
    /// Adjusts the camera field of view for gameplay scenes based on plugin config.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(tk2dCamera), nameof(tk2dCamera.UpdateCameraMatrix))]
    public static void tk2dCamera_UpdateCameraMatrix(tk2dCamera __instance)
    {
        // Only apply FOV changes during actual gameplay, not in menus or cutscenes
        if (!GameManager.SilentInstance || !GameManager.SilentInstance.IsGameplayScene()) return;

        // Store original FOV and apply configured adjustment
        OriginalFOV.Value = __instance.SettingsRoot.CameraSettings.fieldOfView;
        __instance.SettingsRoot.CameraSettings.fieldOfView = OriginalFOV.Value + _cachedFieldOfView;
    }

    /// <summary>
    /// Harmony transpiler patch for StartManager.Start.
    /// Modifies IL code to disable the intro sequence (splash screens) when configured to do so.
    /// Searches for the field assignment that enables intro sequence and changes it from true (1) to false (0).
    /// </summary>
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(StartManager), nameof(StartManager.Start))]
    [HarmonyPatch(typeof(StartManager), nameof(StartManager.Start), MethodType.Enumerator)]
    public static IEnumerable<CodeInstruction> StartManager_Start_Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var originalCode = instructions.ToList();
        var modifiedCode = new List<CodeInstruction>(originalCode);

        // If splash screens are enabled in config, return unmodified code
        if (Plugin.SplashScreens.Value) return originalCode;

        try
        {
            // Search through IL instructions to find the showIntroSequence field assignment
            for (var i = 0; i < modifiedCode.Count; i++)
            {
                // Look for the pattern: ldarg.0, ldc.i4.1, stfld <showIntroSequence>
                // This represents: this.showIntroSequence = true;
                if (i + 2 < modifiedCode.Count &&
                    modifiedCode[i].opcode == OpCodes.Ldarg_0 &&      // Load 'this' onto stack
                    modifiedCode[i + 1].opcode == OpCodes.Ldc_I4_1 && // Load constant 1 (true)
                    modifiedCode[i + 2].opcode == OpCodes.Stfld &&    // Store field
                    modifiedCode[i + 2].operand is FieldInfo fi && fi.Name.Contains("<showIntroSequence>"))
                {
                    // Replace ldc.i4.1 (load constant 1) with ldc.i4.0 (load constant 0)
                    // This changes: this.showIntroSequence = true; to: this.showIntroSequence = false;
                    modifiedCode[i + 1] = new CodeInstruction(OpCodes.Ldc_I4_0);
                    Plugin.Log.LogInfo("[SKIP SPLASH] Successfully disabled intro sequence.");
                    break;
                }
            }

            return modifiedCode.AsEnumerable();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SKIP SPLASH] Transpiler failed in {__originalMethod.Name}: {ex}");
            return originalCode;
        }
    }

    /// <summary>
    /// Gets the current scale factor for black borders based on configuration.
    /// Returns 5.0 when border scaling is enabled, 1.0 when disabled.
    /// </summary>
    /// <returns>Scale factor for border modifications</returns>
    public static float GetScaleFactor()
    {
        return Plugin.ShouldScaleBlackEdges ? 5f : 1f;
    }

    /// <summary>
    /// Harmony prefix patch for CustomSceneManager.DrawBlackBorders.
    /// Clears all tracked border references before new borders are drawn during scene transitions.
    /// This prevents memory leaks and ensures clean state for each scene.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CustomSceneManager), nameof(CustomSceneManager.DrawBlackBorders))]
    public static void DrawBlackBorders_Prefix()
    {
        // Clear tracked borders before drawing new ones
        TrackedBorders.Clear();
        Plugin.Log.LogInfo("[BORDERS] Clearing tracked borders for new scene transition");
    }

    /// <summary>
    /// Complex IL transpiler that modifies the DrawBlackBorders method to:
    /// 1. Scale border width by multiplying with GetScaleFactor()
    /// 2. Inject ModifyGameObject and StoreGameObjectPosition calls for each border
    ///
    /// This transpiler is brittle and may break with game updates. It modifies the IL at runtime by:
    /// - Finding where the border width (x) is stored (Stloc_0) and multiplying it by our scale factor
    /// - Finding all MoveGameObjectToScene calls and injecting our tracking methods before them
    ///
    /// WARNING: This uses low-level IL manipulation and assumes specific compiler output patterns.
    /// If the game's CustomSceneManager.DrawBlackBorders method changes, this will likely break.
    /// </summary>
    /// <param name="instructions">Original IL instructions from DrawBlackBorders method</param>
    /// <returns>Modified IL instructions with our scaling and tracking injected</returns>
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(CustomSceneManager), nameof(CustomSceneManager.DrawBlackBorders))]
    private static IEnumerable<CodeInstruction> DrawBlackBorders_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);
        var modifiedCodes = new List<CodeInstruction>(codes);

        try
        {
            var modifyMethod = AccessTools.Method(typeof(Patches), nameof(ModifyGameObject));
            var storePositionMethod = AccessTools.Method(typeof(Patches), nameof(StoreGameObjectPosition));
            var getScaleFactorMethod = AccessTools.Method(typeof(Patches), nameof(GetScaleFactor));
            var moveGameObjectMethod = AccessTools.Method(typeof(SceneManager), nameof(SceneManager.MoveGameObjectToScene));

            // PHASE 1: Scale the border width by our scale factor
            // Original C#: float x = Screen.width / 4f;
            // We modify this to: x = x * GetScaleFactor();
            //
            // IL Pattern we're looking for:
            // ldsfld    valuetype UnityEngine.Screen::width
            // ldc.r4    4
            // div
            // stloc.0   <- We insert our scaling here
            //
            // What we insert after stloc.0:
            // ldloc.0   (load x back onto stack)
            // call      GetScaleFactor
            // mul       (multiply x * scale factor)
            // stloc.0   (store modified x back to local variable)
            for (var i = 0; i < modifiedCodes.Count; i++)
            {
                if (modifiedCodes[i].opcode != OpCodes.Stloc_0) continue;
                
                modifiedCodes.InsertRange(i + 1, [
                    new CodeInstruction(OpCodes.Ldloc_0),        // Load x
                    new CodeInstruction(OpCodes.Call, getScaleFactorMethod), // Get our scale factor
                    new CodeInstruction(OpCodes.Mul),            // Multiply x * scale
                    new CodeInstruction(OpCodes.Stloc_0)         // Store scaled x
                ]);
                break; // Only modify the first stloc.0 (the border width variable)
            }

            // PHASE 2: Inject our tracking methods before each border is moved to the scene
            // Original C# looks like: SceneManager.MoveGameObjectToScene(gameObject, this.gameObject.scene);
            //
            // IL Pattern we're looking for:
            // [GameObject on stack]
            // ldarg.0              <- 'this' reference
            // call get_gameObject  <- get this.gameObject
            // call get_scene       <- get scene property
            // call MoveGameObjectToScene <- The call we're hooking
            //
            // What we want to inject before ldarg.0:
            // dup                  (duplicate GameObject for our first call)
            // call ModifyGameObject (our method to set up border tracking)
            // dup                  (duplicate GameObject for our second call)
            // call StoreGameObjectPosition (our method to capture final positioning)
            //
            // We iterate backwards to avoid index shifting issues when inserting
            for (var i = modifiedCodes.Count - 1; i >= 0; i--)
            {
                if (!modifiedCodes[i].Calls(moveGameObjectMethod)) continue;
                
                // Walk backwards to find the ldarg.0 that loads 'this' for the MoveGameObjectToScene call
                var insertIndex = i - 2; // Start looking before the call
                while (insertIndex > 0 && modifiedCodes[insertIndex].opcode != OpCodes.Ldarg_0)
                {
                    insertIndex--;
                }

                if (insertIndex <= 0) continue;
                
                // Insert our border tracking calls before the ldarg.0
                // At this point, the GameObject is on the stack ready for MoveGameObjectToScene
                modifiedCodes.InsertRange(insertIndex, [
                    new CodeInstruction(OpCodes.Dup),                    // Copy GameObject reference
                    new CodeInstruction(OpCodes.Call, modifyMethod),     // Call our ModifyGameObject method
                    new CodeInstruction(OpCodes.Dup),                    // Copy GameObject reference again
                    new CodeInstruction(OpCodes.Call, storePositionMethod) // Call our StoreGameObjectPosition method
                ]);

                i += 4; // Adjust loop counter since we inserted 4 instructions
            }

            return modifiedCodes;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[TRANSPILER] Transpiler failed in DrawBlackBorders: {ex}");
            return codes;
        }
    }

    /// <summary>
    /// Called by the DrawBlackBorders transpiler to set up tracking for each border GameObject.
    /// Calculates original scale values and manages memory by limiting tracked borders.
    /// Also applies initial feathering configuration based on current settings.
    /// </summary>
    /// <param name="go">The border GameObject to track and modify</param>
    public static void ModifyGameObject(GameObject go)
    {
        // Store original scale before any modifications by reversing current scaling
        var currentScaleFactor = GetScaleFactor();
        var originalScaleX = go.transform.localScale.x / currentScaleFactor;

        // Find the feathered edge child object for later control
        var featheredEdge = go.transform.Find("Feathered Edge")?.gameObject;

        // Create tracking info for this border
        var borderInfo = new BorderInfo
        {
            GameObject = go,
            OriginalScaleX = originalScaleX,
            FeatheredEdge = featheredEdge
        };

        // Implement memory management to prevent unbounded growth
        if (TrackedBorders.Count >= MaxTrackedBorders)
        {
            // Remove oldest entry (first in list) to make room
            TrackedBorders.RemoveAt(0);
            Plugin.Log.LogInfo($"[BORDERS] Reached max capacity ({MaxTrackedBorders}), removed oldest border");
        }
        TrackedBorders.Add(borderInfo);

        // Apply initial feathering state based on current configuration
        if (Plugin.ShouldScaleBlackEdges && featheredEdge && featheredEdge.activeSelf)
        {
            featheredEdge.SetActive(!Plugin.ShouldRemoveFeathering);
        }
    }

    /// <summary>
    /// Data structure to track information about border GameObjects.
    /// Stores original dimensions and references needed for runtime scaling adjustments.
    /// </summary>
    private class BorderInfo
    {
        public GameObject GameObject { get; set; }
        public float OriginalScaleX { get; set; }
        public GameObject FeatheredEdge { get; set; }
        public Vector3 FinalPosition { get; set; }
        public Vector3 FinalScale { get; set; }
        public Vector3 FinalRotation { get; set; }
        public float SceneWidth { get; set; }
        public float SceneHeight { get; set; }
    }

public static void StoreGameObjectPosition(GameObject go)
{
    var borderInfo = TrackedBorders.FirstOrDefault(t => t.GameObject == go);
    if (borderInfo == null) return;

    // Store the final transform data
    borderInfo.FinalPosition = go.transform.localPosition;
    borderInfo.FinalScale = go.transform.localScale;
    borderInfo.FinalRotation = go.transform.eulerAngles;
    
    // Store which border this is based on position (we need this for recalculation)
    var gm = GameManager.instance;
    if (gm)
    {
        borderInfo.SceneWidth = gm.sceneWidth;
        borderInfo.SceneHeight = gm.sceneHeight;
    }
}


    // List of all tracked border GameObjects for scaling and positioning
    private static readonly List<BorderInfo> TrackedBorders = [];
    // Maximum number of borders to track to prevent memory leaks
    private const int MaxTrackedBorders = 100;
    // Last known scale and feathering states to avoid redundant updates
    private static bool _lastScaleState;
    private static bool _lastFeatherState;



    /// <summary>
    /// Harmony postfix patch for LogoLanguage.OnEnable.
    /// Controls visibility of the language logo image based on menu clutter settings.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoLanguage), nameof(LogoLanguage.OnEnable))]
    public static void LogoLanguage_OnEnable(LogoLanguage __instance)
    {
        if (__instance.uiImage)
        {
            // Show or hide logo based on menu clutter configuration
            __instance.uiImage.enabled = Plugin.MenuClutter.Value;
        }
    }


    /// <summary>
    /// Harmony postfix patch for SetVersionNumber.Start.
    /// Controls visibility of the version number text based on menu clutter settings.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SetVersionNumber), nameof(SetVersionNumber.Start))]
    public static void SetVersionNumber_Start(SetVersionNumber __instance)
    {
        if (__instance.textUi)
        {
            // Show or hide version text based on menu clutter configuration
            __instance.textUi.enabled = Plugin.MenuClutter.Value;
        }
    }

    /// <summary>
    /// Harmony transpiler patch for ForceCameraAspect.AutoScaleViewport.
    /// Modifies the hardcoded aspect ratio limits to support both 4:3 and ultra-wide displays.
    /// Replaces the original min (1.6) and max (2.39) aspect ratios with broader limits.
    /// </summary>
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.AutoScaleViewport))]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var originalCode = instructions.ToList();
        var modifiedCode = new List<CodeInstruction>(originalCode);

        // Original hardcoded aspect ratio limits in the game
        const float defaultMin = 1.6f;      // Original minimum aspect (16:10)
        const float defaultMax = 2.3916667f; // Original maximum aspect (21.5:9)

        try
        {
            var foundMin = false;
            var foundMax = false;

            // Search through IL instructions for float constants to replace
            foreach (var t in modifiedCode)
            {
                // Only interested in load float constant instructions
                if (t.opcode != OpCodes.Ldc_R4) continue;

                var value = (float)t.operand;

                // Replace minimum aspect ratio limit for 4:3 display support
                if (!foundMin && Mathf.Approximately(value, defaultMin))
                {
                    t.operand = 1.0f; // Lower minimum to support 4:3 (1.333) and other narrow aspects
                    Plugin.Log.LogInfo($"[TRANSPILER] Replaced min aspect {defaultMin} with 1.0 for 4:3 support.");
                    foundMin = true;
                }
                // Replace maximum aspect ratio limit for ultra-wide display support
                else if (!foundMax && Mathf.Approximately(value, defaultMax))
                {
                    t.operand = 10f; // Higher maximum for ultra-wide displays (32:9 = 3.56, so 10 gives plenty of headroom)
                    Plugin.Log.LogInfo($"[TRANSPILER] Replaced max aspect {defaultMax} with 10 for ultra-wide support.");
                    foundMax = true;
                }

                // Exit early once both values are found and replaced
                if (foundMin && foundMax) break;
            }

            return modifiedCode.AsEnumerable();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[TRANSPILER] Transpiler failed in {__originalMethod.Name}: {ex}");
            return originalCode.AsEnumerable();
        }
    }


    /// <summary>
    /// Harmony postfix patch for CanvasScaler.OnEnable.
    /// Tracks all CanvasScaler components for aspect ratio management, excluding debug tools.
    /// Automatically applies appropriate scaling mode based on current display aspect ratio.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        // Skip debug/mod UI components (UnityExplorer uses "sinai" in names)
        if (__instance.name.Contains("sinai")) return;

        // Add to our tracking list for aspect ratio management
        CanvasScalers.Add(__instance);

        // Immediately apply appropriate scaling mode based on current aspect ratio
        UpdateScalers(Plugin.CurrentAspect);
    }

    /// <summary>
    /// Custom equality comparer for Resolution objects.
    /// Used to remove duplicate resolutions when building the resolution list for the settings menu.
    /// Considers resolutions equal if they have the same width, height, and refresh rate.
    /// </summary>
    private class ResolutionComparer : IEqualityComparer<Resolution>
    {
        /// <summary>
        /// Determines whether two Resolution objects are equal by comparing dimensions and refresh rate.
        /// </summary>
        public bool Equals(Resolution a, Resolution b) =>
            a.width == b.width &&
            a.height == b.height &&
            Mathf.Approximately((float)a.refreshRateRatio.value, (float)b.refreshRateRatio.value);

        /// <summary>
        /// Generates a hash code for a Resolution object based on its width, height, and refresh rate.
        /// Uses unchecked arithmetic to prevent overflow exceptions.
        /// </summary>
        public int GetHashCode(Resolution r)
        {
            unchecked
            {
                // Use prime numbers for better hash distribution
                var hash = 17;
                hash = hash * 23 + r.width;
                hash = hash * 23 + r.height;
                hash = hash * 23 + Mathf.RoundToInt((float)r.refreshRateRatio.value);
                return hash;
            }
        }
    }
}