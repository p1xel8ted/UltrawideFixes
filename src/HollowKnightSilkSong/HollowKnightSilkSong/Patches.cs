// ReSharper disable InconsistentNaming

namespace HollowKnightSilkSong;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];
    private static readonly WriteOnce<float> OriginalBorderSize = new();
    private static readonly WriteOnce<float> OriginalBackboardSize = new();
    private static readonly WriteOnce<float> OriginalMapSize = new();
    private static bool _cachedHeroLight;
    private static bool _cachedHeroLightDonut;
    private static bool _cachedVignette;
    private static float _cachedVignetteAlpha;
    private static float _cachedFieldOfView;
    private static float _cachedHudOffset;
    private static readonly WriteOnce<float> OriginalFOV = new();
    private static SpriteRenderer DonutLightTransform { get; set; }
    private static WriteOnce<float> OriginalAlpha { get; } = new();
    private static Transform AnchorTransform { get; set; }
    private static WriteOnce<float> OriginalVignetteAlpha { get; } = new();
    private static WriteOnce<Vector3> OriginalVignetteSize { get; } = new();

    internal static void Cleanup()
    {
        // Clear collections
        CanvasScalers.Clear();
        OriginalScreenMatchModes.Clear();
        TrackedBorders.Clear();

        // Reset transforms
        DonutLightTransform = null;
        AnchorTransform = null;

        // Reset WriteOnce values
        OriginalAlpha.ResetValue();
        OriginalBorderSize.ResetValue();
        OriginalBackboardSize.ResetValue();
        OriginalMapSize.ResetValue();
        OriginalFOV.ResetValue();
        OriginalVignetteAlpha.ResetValue();
        OriginalVignetteSize.ResetValue();
    }

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

        if (currentScaleState != _lastScaleState || currentFeatherState != _lastFeatherState)
        {
            UpdateAllBorders();
            _lastScaleState = currentScaleState;
            _lastFeatherState = currentFeatherState;
        }
    }

    private static void UpdateAllBorders()
    {
        var scaleFactor = Plugin.ShouldScaleBlackEdges ? 5f : 1f;
        var showFeathering = Plugin.ShouldScaleBlackEdges && !Plugin.ShouldRemoveFeathering;

        Plugin.Log.LogInfo($"[BORDERS] Updating {TrackedBorders.Count} borders - Scale: {scaleFactor}, Feathering: {showFeathering}");
        
        foreach (var border in TrackedBorders)
        {
            if (!border.GameObject) continue;

            var transform = border.GameObject.transform;

            // Calculate the scale change ratio
            var oldScaleFactor = border.FinalScale.x / border.OriginalScaleX;
            var scaleRatio = scaleFactor / oldScaleFactor;

            // Update scale
            var newScale = border.FinalScale;
            newScale.x = border.OriginalScaleX * scaleFactor;
            transform.localScale = newScale;

            // Recalculate position based on new scale
            // The original positioning uses x/2 (half the border width) for positioning
            // So we need to adjust the position proportionally
            var newPos = border.FinalPosition;

            // Positions that use x/2 need to be adjusted
            // Check rotation to determine which axis was affected
            if (Mathf.Approximately(border.FinalRotation.z, 180f) || Mathf.Approximately(border.FinalRotation.z, 0f))
            {
                // Right/Left borders - X position uses x/2
                newPos.x = border.FinalPosition.x * scaleRatio;
            }
            else if (Mathf.Approximately(border.FinalRotation.z, 90f) || Mathf.Approximately(border.FinalRotation.z, -90f))
            {
                // Top/Bottom borders - Y position uses x/2
                newPos.y = border.FinalPosition.y * scaleRatio;
            }

            transform.localPosition = newPos;

            // Update feathered edge
            if (border.FeatheredEdge != null)
            {
                border.FeatheredEdge.SetActive(showFeathering);
            }
        }

        // Clean up null references
        var removed = TrackedBorders.RemoveAll(b => b.GameObject == null);
        if (removed > 0)
        {
            Plugin.Log.LogInfo($"[BORDERS] Cleaned up {removed} null border references");
        }
    }

    private static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    internal static void UpdateHudOffset()
    {
        if (AnchorTransform)
        {
            AnchorTransform.localPosition = AnchorTransform.localPosition with { x = _cachedHudOffset };
        }
    }

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

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MenuResolutionSetting), nameof(MenuResolutionSetting.ResetToDefaultResolution))]
    public static bool MenuResolutionSetting_ResetToDefaultResolution(MenuResolutionSetting __instance)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow);
        __instance.currentRes = Screen.currentResolution;
        __instance.StartCoroutine(__instance.RefreshOnNextFrame());
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuResolutionSetting), nameof(MenuResolutionSetting.RefreshAvailableResolutions))]
    public static void MenuResolutionSetting_RefreshAvailableResolutions(MenuResolutionSetting __instance)
    {
        var refreshRates = Screen.resolutions
            .Select(r => r.refreshRateRatio)
            .Distinct()
            .OrderBy(r => r)
            .ToArray();

        var resList = new List<Resolution>();

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
        resList.AddRange(refreshRates.Select(refreshRate => new Resolution { width = resWidth, height = resHeight, refreshRateRatio = refreshRate }));

        var unique = resList
            .Distinct(new ResolutionComparer())
            .OrderBy(r => r.width)
            .ThenBy(r => r.height)
            .ThenBy(r => r.refreshRateRatio.value)
            .ToArray();

        __instance.availableResolutions = unique;

        __instance.RefreshCurrentIndex();
        __instance.PushUpdateOptionList();
        __instance.UpdateText();
    }


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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.Awake))]
    public static void ForceCameraAspect_Awake()
    {
        ForceCameraAspect.CurrentViewportAspect = Plugin.CurrentAspect;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.SetOverscanViewport))]
    public static void ForceCameraAspect_SetOverscanViewport(ref float adjustment)
    {
        adjustment = 0;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.AutoScaleViewport))]
    public static void ForceCameraAspect_AutoScaleViewport(ref float __result)
    {
        __result = Plugin.CurrentAspect;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoMenuOptions), nameof(VideoMenuOptions.ConfigureNavigation))]
    public static void VideoMenuOptions_ConfigureNavigation(VideoMenuOptions __instance)
    {
        __instance.screenScaleOption.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroController), nameof(HeroController.FixedUpdate))]
    public static void HeroController_FixedUpdate(HeroController __instance)
    {
        if (__instance.heroLight)
        {
            OriginalAlpha.Value = __instance.heroLight.Alpha;

            __instance.heroLight.Alpha = _cachedHeroLight ? OriginalAlpha.Value : 0f;
        }

        DonutLightTransform ??= __instance.transform.Find("HeroLight/white_light_donut")?.GetComponent<SpriteRenderer>();
        if (DonutLightTransform)
        {
            DonutLightTransform.enabled = !_cachedHeroLightDonut;
        }

        if (!__instance.vignette) return;
        
        __instance.vignette.enabled = _cachedVignette;

        if (!__instance.vignette.enabled) return;

        OriginalVignetteAlpha.Value = __instance.vignette.color.a;

        __instance.vignette.color = __instance.vignette.color with { a = _cachedVignetteAlpha };
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(tk2dCamera), nameof(tk2dCamera.UpdateCameraMatrix))]
    public static void tk2dCamera_UpdateCameraMatrix(tk2dCamera __instance)
    {
        if (!GameManager.SilentInstance || !GameManager.SilentInstance.IsGameplayScene()) return;
        
        OriginalFOV.Value = __instance.SettingsRoot.CameraSettings.fieldOfView;
        __instance.SettingsRoot.CameraSettings.fieldOfView = OriginalFOV.Value + _cachedFieldOfView;
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(StartManager), nameof(StartManager.Start))]
    [HarmonyPatch(typeof(StartManager), nameof(StartManager.Start), MethodType.Enumerator)]
    public static IEnumerable<CodeInstruction> StartManager_Start_Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var originalCode = instructions.ToList();
        var modifiedCode = new List<CodeInstruction>(originalCode);

        if (Plugin.SplashScreens.Value) return originalCode;

        try
        {
            for (var i = 0; i < modifiedCode.Count; i++)
            {
                if (i + 2 < modifiedCode.Count &&
                    modifiedCode[i].opcode == OpCodes.Ldarg_0 &&
                    modifiedCode[i + 1].opcode == OpCodes.Ldc_I4_1 &&
                    modifiedCode[i + 2].opcode == OpCodes.Stfld &&
                    modifiedCode[i + 2].operand is FieldInfo fi && fi.Name.Contains("<showIntroSequence>"))
                {
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

    public static float GetScaleFactor()
    {
        return Plugin.ShouldScaleBlackEdges ? 5f : 1f;
    }

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

    public static void ModifyGameObject(GameObject go)
    {
        // Store original scale before any modifications
        var currentScaleFactor = GetScaleFactor();
        var originalScaleX = go.transform.localScale.x / currentScaleFactor;

        var featheredEdge = go.transform.Find("Feathered Edge")?.gameObject;

        // Track this border with original scale
        var borderInfo = new BorderInfo
        {
            GameObject = go,
            OriginalScaleX = originalScaleX,
            FeatheredEdge = featheredEdge
        };

        // Add with memory management - remove oldest if at capacity
        if (TrackedBorders.Count >= MaxTrackedBorders)
        {
            // Remove oldest entry (first in list)
            TrackedBorders.RemoveAt(0);
            Plugin.Log.LogInfo($"[BORDERS] Reached max capacity ({MaxTrackedBorders}), removed oldest border");
        }
        TrackedBorders.Add(borderInfo);

        // Apply initial feathering state
        if (Plugin.ShouldScaleBlackEdges && featheredEdge && featheredEdge.activeSelf)
        {
            featheredEdge.SetActive(!Plugin.ShouldRemoveFeathering);
        }
    }

    private class BorderInfo
    {
        public GameObject GameObject { get; set; }
        public float OriginalScaleX { get; set; }
        public GameObject FeatheredEdge { get; set; }
        public Vector3 FinalPosition { get; set; }
        public Vector3 FinalScale { get; set; }
        public Vector3 FinalRotation { get; set; }
    }

    public static void StoreGameObjectPosition(GameObject go)
    {
        // Find the matching border info and store final positioning
        // Optimized loop without LINQ for better performance
        var borderInfo = TrackedBorders.FirstOrDefault(t => t.GameObject == go);

        if (borderInfo == null) return;
        
        borderInfo.FinalPosition = go.transform.localPosition;
        borderInfo.FinalScale = go.transform.localScale;
        borderInfo.FinalRotation = go.transform.eulerAngles;

        Plugin.Log.LogInfo($"[BORDER] Stored position for border: Pos={borderInfo.FinalPosition}, Scale={borderInfo.FinalScale}");
    }

    private static readonly List<BorderInfo> TrackedBorders = [];
    private const int MaxTrackedBorders = 100; // Prevent unbounded list growth
    private static bool _lastScaleState;
    private static bool _lastFeatherState;



    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoLanguage), nameof(LogoLanguage.OnEnable))]
    public static void LogoLanguage_OnEnable(LogoLanguage __instance)
    {
        if (__instance.uiImage)
        {
            __instance.uiImage.enabled = Plugin.MenuClutter.Value;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(SetVersionNumber), nameof(SetVersionNumber.Start))]
    public static void SetVersionNumber_Start(SetVersionNumber __instance)
    {
        if (__instance.textUi)
        {
            __instance.textUi.enabled = Plugin.MenuClutter.Value;
        }
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.AutoScaleViewport))]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var originalCode = instructions.ToList();
        var modifiedCode = new List<CodeInstruction>(originalCode);

        const float defaultMin = 1.6f;
        const float defaultMax = 2.3916667f;

        try
        {
            var foundMin = false;
            var foundMax = false;

            foreach (var t in modifiedCode)
            {
                if (t.opcode != OpCodes.Ldc_R4) continue;
                
                var value = (float)t.operand;

                // Replace minimum value for 4:3 support
                if (!foundMin && Mathf.Approximately(value, defaultMin))
                {
                    t.operand = 1.0f; // Lower minimum to support 4:3 (1.333)
                    Plugin.Log.LogInfo($"[TRANSPILER] Replaced min aspect {defaultMin} with 1.0 for 4:3 support.");
                    foundMin = true;
                }
                // Replace maximum value for ultra-wide support
                else if (!foundMax && Mathf.Approximately(value, defaultMax))
                {
                    t.operand = 10f; // Higher maximum for ultra-wide
                    Plugin.Log.LogInfo($"[TRANSPILER] Replaced max aspect {defaultMax} with 10 for ultra-wide support.");
                    foundMax = true;
                }

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


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }

    private class ResolutionComparer : IEqualityComparer<Resolution>
    {
        public bool Equals(Resolution a, Resolution b) =>
            a.width == b.width &&
            a.height == b.height &&
            Mathf.Approximately((float)a.refreshRateRatio.value, (float)b.refreshRateRatio.value);

        public int GetHashCode(Resolution r)
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + r.width;
                hash = hash * 23 + r.height;
                hash = hash * 23 + Mathf.RoundToInt((float)r.refreshRateRatio.value);
                return hash;
            }
        }
    }
}