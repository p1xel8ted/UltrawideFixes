namespace MousePiForHire;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    private const string DashIndicator = "DashIndicator";
    private const string Sinai = "sinai";

    // Cached on first GraphicsStateSettings.Get; live UI sliders self-register via SetSetting postfix.
    private static MouseSettings.SettingInt _fovSetting;
    private static (int min, int max, int outMin, int outMax)? _originalFovBounds;
    private static readonly List<UI.ValueChangeSelectableSlider> _fovSliders = [];

    // Dedupe sets: hot patches log at most once per unique key so bug-report logs stay readable.
    private static readonly HashSet<(int, int)> _isUltraWideLogged = [];
    private static readonly HashSet<int> _canvasScalerLogged = [];
    private static readonly HashSet<int> _overlayFitterLogged = [];
    private static bool _fpsCapLifted;
    private static bool _steamSuppressionLogged;
    private static bool _powerUpSkipLogged;
    private static bool _startScreenSkipLogged;

    // Idempotent fitter add. HeightControlsWidth + native aspect makes 16:9 sprite art cover full
    // ultrawide on overlay rects.
    private static void EnsureAspectRatioFitter(GameObject go, float aspectRatio, string context)
    {
        var hadFitter = go.TryGetComponent<AspectRatioFitter>(out _);
        var arf = go.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = aspectRatio;
        if (_overlayFitterLogged.Add(go.GetInstanceID()))
        {
            Plugin.Log.LogInfo($"[Fitter] '{go.name}' ({context}): {(hadFitter ? "updated" : "added")} AspectRatioFitter HeightControlsWidth ratio={aspectRatio:F4}");
        }
    }

    // Writes config-driven FOV bounds onto the SettingInt SO and pushes to any live UI sliders.
    public static void ApplyFovBounds()
    {
        if (!_fovSetting || _originalFovBounds == null)
        {
            Plugin.Log.LogInfo($"[FOV] ApplyFovBounds called but FOV setting not yet captured (setting={_fovSetting != null}, original={_originalFovBounds != null}); skipping.");
            return;
        }

        var min = Plugin.FovMin?.Value ?? _originalFovBounds.Value.min;
        var max = Plugin.FovMax?.Value ?? _originalFovBounds.Value.max;
        if (max <= min) max = min + 1;

        _fovSetting.minValue = min;
        _fovSetting.maxValue = max;
        _fovSetting.minValueOutput = min;
        _fovSetting.maxValueOutput = max;

        var pushed = 0;
        var pruned = 0;
        for (var i = _fovSliders.Count - 1; i >= 0; i--)
        {
            var sel = _fovSliders[i];
            if (!sel || !sel.slider)
            {
                _fovSliders.RemoveAt(i);
                pruned++;
                continue;
            }

            sel.slider.minValue = min;
            sel.slider.maxValue = max;
            sel.RefreshValueDisplay();
            pushed++;
        }

        Plugin.Log.LogInfo($"[FOV] Bounds applied: {min}-{max} (config: min={Plugin.FovMin?.Value}, max={Plugin.FovMax?.Value}; original min={_originalFovBounds.Value.min}, max={_originalFovBounds.Value.max}). Pushed to {pushed} live slider(s), pruned {pruned} stale.");
    }

    // Core ultrawide unlock - the same bool gates the resolution dropdown filter, the windowed-mode
    // fallback, and the ExclusiveFullScreen block.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DisplayUtility), nameof(DisplayUtility.IsUltraWide))]
    public static void DisplayUtility_IsUltraWide(int width, int height, ref bool __result)
    {
        var wasTrue = __result;
        __result = false;
        if (wasTrue && _isUltraWideLogged.Add((width, height)))
        {
            Plugin.Log.LogInfo($"[IsUltraWide] {width}x{height}: forced true->false (game considered this ultrawide; we keep it in the resolution list).");
        }
    }

    // Auto-advance past the press-any-key screen by triggering the same MainMenu transition the user
    // would have on input.
    [HarmonyPrefix]
    [HarmonyPatch(typeof(StartScreenController), nameof(StartScreenController.EnableInput))]
    public static void StartScreenController_EnableInput(StartScreenController __instance)
    {
        __instance.waitingForInput = false;
        __instance.StartLoadingMainMenu();
        if (!_startScreenSkipLogged)
        {
            _startScreenSkipLogged = true;
            Plugin.Log.LogInfo("[StartScreen] Press-any-key skipped, advancing directly to MainMenu.");
        }
    }

    // Fullscreen-effect overlays (dash, power-up tints, etc.) - 16:9 art stretched to ultrawide.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UiOverlay), nameof(UiOverlay.TryDisplaying))]
    public static void UiOverlay_TryDisplaying(UiOverlay __instance)
    {
        EnsureAspectRatioFitter(__instance.gameObject, DisplayMetrics.NativeSystemAspect, "fullscreen overlay");
    }

    // Main menu kept at native 16:9 aspect (menu UI was authored for 16:9; stretching looks wrong).
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.Start))]
    public static void MainMenuController_Start(MainMenuController __instance)
    {
        EnsureAspectRatioFitter(__instance.gameObject, DisplayMetrics.NativeAspect, "main menu (16:9)");
    }

    // Dash indicator overlay - same fullscreen-cover treatment as UiOverlay.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIOneTimeSpritePlayer), nameof(UIOneTimeSpritePlayer.Start))]
    public static void UIOneTimeSpritePlayer_Start(UIOneTimeSpritePlayer __instance)
    {
        if (__instance.name != DashIndicator) return;
        EnsureAspectRatioFitter(__instance.gameObject, DisplayMetrics.NativeSystemAspect, "dash indicator");
    }

    // Register FOV-bound UI sliders so ApplyFovBounds can push live without scene-wide FindObjects.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI.ValueChangeSelectableSlider), nameof(UI.ValueChangeSelectableSlider.SetSetting))]
    public static void ValueChangeSelectableSlider_SetSetting(UI.ValueChangeSelectableSlider __instance, MouseSettings.BaseSettingAsset settingAsset)
    {
        if (!settingAsset || settingAsset != _fovSetting) return;
        if (_fovSliders.Contains(__instance)) return;
        _fovSliders.Add(__instance);
        Plugin.Log.LogInfo($"[FOV] Registered live slider '{__instance.gameObject.name}' (now tracking {_fovSliders.Count}). Future bound changes via config will push directly without scene scan.");
    }

    // Earliest universally-reached hook for the FOV SettingInt - captures stock bounds on first
    // call so we have an "original" to revert to and apply config bounds.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Mouse.GraphicsStateSettings), nameof(Mouse.GraphicsStateSettings.Get))]
    public static void GraphicsStateSettings_Get(Mouse.GraphicsStateSettings __result)
    {
        var setting = __result?.settingFieldOfView;
        if (!setting || _fovSetting == setting) return;
        _fovSetting = setting;
        _originalFovBounds = (setting.minValue, setting.maxValue, setting.minValueOutput, setting.maxValueOutput);
        Plugin.Log.LogInfo($"[FOV] Captured stock bounds from settingFieldOfView SO: min={setting.minValue}, max={setting.maxValue}, output={setting.minValueOutput}-{setting.maxValueOutput}, increment={setting.incrementalValue}.");
        ApplyFovBounds();
    }

    // Force MatchWidthOrHeight/1.0 (height-match) so HUD anchors reach actual screen edges instead
    // of horizontally stretching. UnityExplorer's own canvases are skipped.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.IndexOf(Sinai, StringComparison.OrdinalIgnoreCase) >= 0)
        {
            if (_canvasScalerLogged.Add(__instance.GetInstanceID()))
            {
                Plugin.Log.LogInfo($"[CanvasScaler] '{__instance.name}': skipped (UnityExplorer-owned, leaving alone).");
            }

            return;
        }

        if (__instance.screenMatchMode == CanvasScaler.ScreenMatchMode.MatchWidthOrHeight && Mathf.Approximately(__instance.matchWidthOrHeight, 1f))
        {
            if (_canvasScalerLogged.Add(__instance.GetInstanceID()))
            {
                Plugin.Log.LogInfo($"[CanvasScaler] '{__instance.name}': already MatchWidthOrHeight/1.0, no change.");
            }

            return;
        }

        var beforeMode = __instance.screenMatchMode;
        var beforeMatch = __instance.matchWidthOrHeight;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        __instance.matchWidthOrHeight = 1f;
        if (_canvasScalerLogged.Add(__instance.GetInstanceID()))
        {
            Plugin.Log.LogInfo($"[CanvasScaler] '{__instance.name}': {beforeMode}/{beforeMatch:F2} -> MatchWidthOrHeight/1.0");
        }
    }

    // Drops noisy Unity warnings (e.g. BoxCollider negative-scale) from BepInEx's LogOutput.log.
    // See LogFilter for the suppression list.
    [HarmonyPrefix]
    [HarmonyPatch(typeof(UnityLogSource), nameof(UnityLogSource.OnUnityLogMessageReceived))]
    public static bool UnityLogSource_OnUnityLogMessageReceived_Prefix(string message)
    {
        return !LogFilter.ShouldSuppressFromBepInEx(message);
    }

    // Suppresses the "Tried to Initialize the SteamAPI twice" throw caused by
    // ApplicationStateWatcher.OnDestroy lazy-recreating SteamManager during shutdown.
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Instance), MethodType.Getter)]
    public static bool SteamManager_Instance_Prefix(ref SteamManager __result)
    {
        if (!SteamManager.s_EverInitialized || SteamManager.s_instance) return true;
        __result = null;
        if (!_steamSuppressionLogged)
        {
            _steamSuppressionLogged = true;
            Plugin.Log.LogInfo("[SteamManager] Suppressed lazy-recreate during shutdown (s_instance fake-null + s_EverInitialized=true). Returning null to avoid 'Tried to Initialize the SteamAPI twice' throw.");
        }

        return false;
    }

    // Skips refresh during Player.OnDestroy teardown when ScriptableObject presets have been
    // destroyed - avoids NRE from ItemData.GetId reading .name on a fake-null SO.
    [HarmonyPrefix]
    [HarmonyPatch(typeof(PowerUpInventory), nameof(PowerUpInventory.RefreshPowerUps))]
    public static bool PowerUpInventory_RefreshPowerUps_Prefix(PowerUpInventory __instance)
    {
        var presets = __instance.powerupPresets;
        if (presets == null) return true;
        if (presets.All(preset => preset)) return true;
        if (_powerUpSkipLogged) return false;
        _powerUpSkipLogged = true;
        Plugin.Log.LogInfo("[PowerUpInventory] Skipping RefreshPowerUps: a powerupPreset SO has been destroyed (Player.OnDestroy teardown cascade). Avoids NRE in ItemData.GetId.");

        return false;

    }

    // Lifts the FPS slider's artificial refresh*2 cap up to maxFPSBeforeUnlimited (500), the
    // existing ceiling already on the SO.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MouseSettings.SettingFPSLimit), nameof(MouseSettings.SettingFPSLimit.CalculateMaxFramerate))]
    public static void SettingFPSLimit_CalculateMaxFramerate(MouseSettings.SettingFPSLimit __instance, ref int __result)
    {
        var vanilla = __result;
        if (vanilla >= __instance.maxFPSBeforeUnlimited) return;
        __result = __instance.maxFPSBeforeUnlimited;
        if (_fpsCapLifted) return;
        _fpsCapLifted = true;
        Plugin.Log.LogInfo($"[FPSLimit] CalculateMaxFramerate vanilla returned {vanilla} (refresh*2 clamp); lifting to maxFPSBeforeUnlimited={__instance.maxFPSBeforeUnlimited}.");
    }
}
