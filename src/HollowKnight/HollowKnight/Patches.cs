namespace HollowKnight;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];
    private static readonly WriteOnce<float> OriginalBorderSize = new();
    private static readonly WriteOnce<float> OriginalBackboardSize = new();
    private static readonly WriteOnce<float> OriginalMapSize = new();
    private static readonly WriteOnce<float> OriginalHudOffset = new();

    private static bool _cachedHeroLight;
    private static bool _cachedReduceHeroLight;
    private static float _cachedFieldOfView;
    private static float _cachedHudOffset;

    private static SpriteRenderer DonutLightTransform { get; set; }
    private static Transform HudTransform { get; set; }

    internal static void UpdateConfigCache()
    {
        _cachedHeroLight = Plugin.HeroLight.Value;
        _cachedReduceHeroLight = Plugin.ReduceHeroLight.Value;
        _cachedFieldOfView = Plugin.CameraFieldOfView.Value;
        _cachedHudOffset = Plugin.HudOffset.Value;
        UpdateHudOffset();
    }

    internal static void Cleanup()
    {
        CanvasScalers.Clear();
        OriginalScreenMatchModes.Clear();
        DonutLightTransform = null;
        HudTransform = null;
        OriginalBorderSize.ResetValue();
        OriginalBackboardSize.ResetValue();
        OriginalMapSize.ResetValue();
        OriginalHudOffset.ResetValue();
    }

    internal static void UpdateScalers(float aspect)
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

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Animator), nameof(Animator.SetBool), typeof(string), typeof(bool))]
    public static void Animator_SetBool(Animator __instance, ref bool value)
    {
        if (!Plugin.SplashScreens.Value && __instance.name == "StartManager")
        {
            value = false;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(StartManager), nameof(global::StartManager.FadeIn))]
    [HarmonyPatch(typeof(StartManager), nameof(global::StartManager.FadeOut))]
    public static void StartManager_FadeIn(StartManager __instance, ref float duration)
    {
        if (Plugin.SplashScreens.Value) return;

        __instance.fadeSpeed = 0;
        duration = 0;
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
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.UIGoToPauseMenu))]
    [HarmonyPatch(typeof(UIManager), nameof(UIManager.TogglePauseGame))]
    public static void UIManager_ShowCanvas(UIManager __instance)
    {
        __instance.modalDimmer.transform.localScale = new Vector3(5, 5, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(tk2dCamera), nameof(tk2dCamera.GetScreenPixelDimensions))]
    public static void tk2dCamera_GetScreenPixelDimensions(tk2dCamera __instance, ref Vector2 __result)
    {
        __instance.CameraSettings.rect = new Rect(0, 0, 1, 1);
        __result = new Vector2(Screen.width, Screen.height);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroController), nameof(HeroController.FixedUpdate))]
    public static void HeroController_FixedUpdate(HeroController __instance)
    {
        __instance.heroLight.enabled = _cachedHeroLight;

        if (!DonutLightTransform)
        {
            DonutLightTransform = __instance.transform.Find("white_light_donut")?.GetComponent<SpriteRenderer>();
        }

        if (DonutLightTransform)
        {
            DonutLightTransform.enabled = !_cachedReduceHeroLight;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinematicSequence), nameof(CinematicSequence.Begin))]
    public static void CinematicSequence_Begin(CinematicSequence __instance)
    {
        // Correct cinematic aspect ratio to prevent horizontal squishing on ultrawide
        var ogX = __instance.targetRenderer.transform.localScale.x;
        var newX = ogX * (Plugin.CurrentAspect / Plugin.NativeAspect);
        __instance.targetRenderer.transform.localScale = __instance.targetRenderer.transform.localScale with { x = newX };

        // Disable black bars (blanker) that would appear on ultrawide displays
        __instance.blankerRenderer.gameObject.SetActive(false);
    }

    private static bool InGame()
    {
        return GameManager.UnsafeInstance && GameManager.UnsafeInstance.IsGameplayScene();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(tk2dCamera), nameof(tk2dCamera.UpdateCameraMatrix))]
    public static void tk2dCamera_UpdateCameraMatrix(tk2dCamera __instance)
    {
        if (!InGame()) return;

        if (__instance._unityCamera)
        {
            __instance._unityCamera.fieldOfView *= _cachedFieldOfView;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUDCamera), nameof(HUDCamera.OnEnable))]
    public static void HUDCamera_OnEnable(HUDCamera __instance)
    {
        var hud = GameCameras.instance.hudCanvas?.transform;
        if (!HudTransform)
        {
            HudTransform = hud;
        }

        UpdateHudOffset();

        var scaleFactor = Plugin.CurrentAspect / Plugin.NativeAspect;

        var b1 = __instance.transform.Find("Inventory/Border/Menu_Border_Black");
        if (b1)
        {
            OriginalBorderSize.Value = b1.localScale.x;
            b1.localScale = b1.localScale with { x = b1.localScale.x * scaleFactor };
        }
        else
        {
            Plugin.Log.LogWarning("Could not find Inventory/Border/Menu_Border_Black");
        }

        var b2 = __instance.transform.Find("Inventory/Border/backboard");
        if (b2)
        {
            OriginalBackboardSize.Value = b2.localScale.x;
            b2.localScale = b2.localScale with { x = b2.localScale.x * scaleFactor };
        }
        else
        {
            Plugin.Log.LogWarning("Could not find Inventory/Border/backboard");
        }

        var b3 = __instance.transform.Find("Quick Map/BG");
        if (b3)
        {
            OriginalMapSize.Value = b3.localScale.x;
            b3.localScale = b3.localScale with { x = b3.localScale.x * scaleFactor };
        }
        else
        {
            Plugin.Log.LogWarning("Could not find Quick Map/BG");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuButtonList), nameof(MenuButtonList.OnEnable))]
    [HarmonyPatch(typeof(MenuButtonList), nameof(MenuButtonList.Start))]
    public static void MenuButtonList_SetupActive(MenuButtonList __instance)
    {
        foreach (var entry in __instance.entries)
        {
            if (entry.selectable.name == "ScreenScaleButton")
            {
                entry.selectable.gameObject.SetActive(false);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoLanguage), nameof(LogoLanguage.OnEnable))]
    public static void LogoLanguage_OnEnable(LogoLanguage __instance)
    {
        __instance.gameObject.SetActive(Plugin.MenuClutter.Value);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SetVersionNumber), nameof(SetVersionNumber.Start))]
    public static void SetVersionNumber_Start(SetVersionNumber __instance)
    {
        __instance.gameObject.SetActive(Plugin.MenuClutter.Value);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.Awake))]
    public static void ForceCameraAspect_Awake(ForceCameraAspect __instance)
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
    public static void ForceCameraAspect_AutoScaleViewport(ForceCameraAspect __instance, ref float __result)
    {
        var rect = new Rect(0, 0, 1, 1);
        __instance.tk2dCam.CameraSettings.rect = rect;
        __instance.hudCam.rect = rect;
        __result = Plugin.CurrentAspect;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameCameras), nameof(GameCameras.SetOverscan))]
    public static void GameCameras_SetOverscan(GameCameras __instance, ref float value)
    {
        value = 0;
    }

    internal static void UpdateHudOffset()
    {
        if (!InGame()) return;

        if (HudTransform)
        {
            var pos = HudTransform.localPosition;
            OriginalHudOffset.Value = pos.x;
            pos.x = OriginalHudOffset.Value + _cachedHudOffset;
            HudTransform.localPosition = pos;
        }
        else
        {
            Plugin.Log.LogWarning("[HUD OFFSET] HudTransform is null, cannot update HUD offset");
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
            a.refreshRateRatio.Equals(b.refreshRateRatio);

        public int GetHashCode(Resolution r)
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + r.width;
                hash = hash * 23 + r.height;
                hash = hash * 23 + r.refreshRateRatio.GetHashCode();
                return hash;
            }
        }
    }
}
