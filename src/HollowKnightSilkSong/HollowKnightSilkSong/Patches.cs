// ReSharper disable InconsistentNaming

namespace HollowKnightSilkSong;

[Harmony]
public static class Patches
{
    private const float UltraWideAspectThreshold = 2.38f; // ~21.5:9 aspect ratio
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    private static readonly WriteOnce<float> OriginalBorderSize = new();
    private static readonly WriteOnce<float> OriginalBackboardSize = new();
    private static readonly WriteOnce<float> OriginalMapSize = new();

    private static bool _cachedHeroLight;
    private static bool _cachedHeroLightDonut;
    private static bool _cachedVignette;
    private static float _cachedVignetteAlpha;
    private static float _cachedVignetteHorizontalSize;
    private static float _cachedVignetteVerticalSize;
    private static float _cachedFieldOfView;
    private static float _cachedHudOffset;

    private static readonly WriteOnce<float> OriginalBorderScaleX = new();
    private static readonly WriteOnce<float> OriginalFOV = new();
    private static SpriteRenderer DonutLightTransform { get; set; }
    private static WriteOnce<float> OriginalAlpha { get; } = new();
    private static Transform AnchorTransform { get; set; }

    private static WriteOnce<float> OriginalVignetteAlpha { get; } = new();
    private static WriteOnce<Vector3> OriginalVignetteSize { get; } = new();

    internal static void Cleanup()
    {
        CanvasScalers.Clear();
        OriginalScreenMatchModes.Clear();
        DonutLightTransform = null;
        AnchorTransform = null;
        OriginalAlpha.ResetValue();
        OriginalBorderSize.ResetValue();
        OriginalBackboardSize.ResetValue();
        OriginalMapSize.ResetValue();
        OriginalBorderScaleX.ResetValue();
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
        _cachedVignetteHorizontalSize = Plugin.VignetteHorizontalSize.Value;
        _cachedVignetteVerticalSize = Plugin.VignetteVerticalSize.Value;
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

        resList.AddRange(refreshRates.Select(refreshRate => new Resolution { width = Display.main.systemWidth, height = Display.main.systemHeight, refreshRateRatio = refreshRate }));

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

        if (__instance.vignette)
        {
            __instance.vignette.enabled = _cachedVignette;

            if (!__instance.vignette.enabled) return;

            OriginalVignetteAlpha.Value = __instance.vignette.color.a;
            OriginalVignetteSize.Value = __instance.vignette.transform.localScale;

            __instance.vignette.color = __instance.vignette.color with { a = _cachedVignetteAlpha };

            var x = OriginalVignetteSize.Value.x + _cachedVignetteHorizontalSize;
            var y = OriginalVignetteSize.Value.y + _cachedVignetteVerticalSize;

            __instance.vignette.transform.localScale = new Vector3(x, y, OriginalVignetteSize.Value.z);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(tk2dCamera), nameof(tk2dCamera.UpdateCameraMatrix))]
    public static void tk2dCamera_UpdateCameraMatrix(tk2dCamera __instance)
    {
        if (GameManager.SilentInstance && GameManager.SilentInstance.IsGameplayScene())
        {
            OriginalFOV.Value = __instance.SettingsRoot.CameraSettings.fieldOfView;
            __instance.SettingsRoot.CameraSettings.fieldOfView = OriginalFOV.Value + _cachedFieldOfView;
        }
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
                    modifiedCode[i + 2].operand is FieldInfo { Name: "<showIntroSequence>5__3" })
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

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CustomSceneManager), nameof(CustomSceneManager.DrawBlackBorders))]
    public static void CustomSceneManager_DrawBlackBorders(CustomSceneManager __instance)
    {
        var featheredEdge = __instance.borderPrefab.transform.Find("Feathered Edge");
        if (Plugin.CurrentAspect > UltraWideAspectThreshold)
        {
            OriginalBorderScaleX.Value = __instance.borderPrefab.transform.localScale.x;

            __instance.borderPrefab.transform.localScale = __instance.borderPrefab.transform.localScale with { x = OriginalBorderScaleX.Value * (Plugin.CurrentAspect / Plugin.NativeAspect) };

            if (featheredEdge)
            {
                featheredEdge.gameObject.SetActive(false);
            }
        }
        else
        {
            __instance.borderPrefab.transform.localScale = __instance.borderPrefab.transform.localScale with { x = OriginalBorderScaleX.Value };
            if (featheredEdge)
            {
                featheredEdge.gameObject.SetActive(true);
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoLanguage), nameof(LogoLanguage.OnEnable))]
    public static void LogoLanguage_OnEnable(LogoLanguage __instance)
    {
        if (__instance.uiImage && !Plugin.MenuClutter.Value)
        {
            __instance.uiImage.enabled = false;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(SetVersionNumber), nameof(SetVersionNumber.Start))]
    public static void SetVersionNumber_Start(SetVersionNumber __instance)
    {
        if (__instance.textUi && !Plugin.MenuClutter.Value)
        {
            __instance.textUi.enabled = false;
        }
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.AutoScaleViewport))]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var originalCode = instructions.ToList();
        var modifiedCode = new List<CodeInstruction>(originalCode);

        const float defaultMax = 2.3916667f;

        try
        {
            foreach (var t in modifiedCode.Where(t => t.opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float)t.operand, defaultMax)))
            {
                Plugin.Log.LogInfo($"[TRANSPILER] Replaced hardcoded max aspect {defaultMax} with much higher value to avoid clamping.");
                t.operand = 10f; // Set a very high max aspect ratio to avoid clamping
                break;
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