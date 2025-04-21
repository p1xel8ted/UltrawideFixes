namespace HollowKnight;

[Harmony]
public static class Patches
{
    private const string StartManager = "StartManager";
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

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

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Animator), nameof(Animator.SetBool), typeof(string), typeof(bool))]
    public static void Animator_SetBool(Animator __instance, ref bool value)
    {
        if (__instance.name == StartManager)
        {
            value = false;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(StartManager), nameof(global::StartManager.FadeIn))]
    [HarmonyPatch(typeof(StartManager), nameof(global::StartManager.FadeOut))]
    public static void StartManager_FadeIn(StartManager __instance, ref float duration)
    {
        __instance.fadeSpeed = 0;
        duration = 0;
    }

    private class ResolutionComparer : IEqualityComparer<Resolution>
    {
        public bool Equals(Resolution a, Resolution b) =>
            a.width == b.width &&
            a.height == b.height &&
            a.refreshRate == b.refreshRate;

        public int GetHashCode(Resolution r)
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + r.width;
                hash = hash * 23 + r.height;
                hash = hash * 23 + r.refreshRate;
                return hash;
            }
        }
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
            .Select(r => r.refreshRate)
            .Distinct()
            .OrderBy(r => r)
            .ToArray();

        var resList = new List<Resolution>();

        if (!Plugin.ShowMainResolutionOnly.Value)
        {
            resList.AddRange(Screen.resolutions);
        }

        resList.AddRange(refreshRates.Select(refreshRate => new Resolution { width = Display.main.systemWidth, height = Display.main.systemHeight, refreshRate = refreshRate }));

        var unique = resList
            .Distinct(new ResolutionComparer())
            .OrderBy(r => r.width)
            .ThenBy(r => r.height)
            .ThenBy(r => r.refreshRate)
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

    private static SpriteRenderer DonutLightTransform { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroController), nameof(HeroController.FixedUpdate))]
    public static void HeroController_FixedUpdate(HeroController __instance)
    {
        __instance.heroLight.enabled = Plugin.HeroLight.Value;
        DonutLightTransform ??= __instance.transform.Find("white_light_donut")?.GetComponent<SpriteRenderer>();
        if (DonutLightTransform)
        {
            DonutLightTransform.enabled = Plugin.HeroLightDonut.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(tk2dCamera), nameof(tk2dCamera.UpdateCameraMatrix))]
    public static void tk2dCamera_UpdateCameraMatrix(tk2dCamera __instance)
    {
        if (__instance._unityCamera)
        {
            __instance._unityCamera.fieldOfView *= Plugin.CameraFieldOfView.Value;
        }
    }

    private static readonly WriteOnce<float> OriginalBorderSize = new();
    private static readonly WriteOnce<float> OriginalBackboardSize = new();
    private static readonly WriteOnce<float> OriginalMapSize = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUDCamera), nameof(HUDCamera.OnEnable))]
    public static void HUDCamera_OnEnable(HUDCamera __instance)
    {
        var scaleFactor = Plugin.CurrentAspect / Plugin.NativeAspect;

        var b1 = __instance.transform.Find("Inventory/Border/Menu_Border_Black");
        if (b1)
        {
            OriginalBorderSize.Value = b1.localScale.x;
            b1.localScale = b1.localScale with { x = b1.localScale.x * scaleFactor };
        }

        var b2 = __instance.transform.Find("Inventory/Border/backboard");
        if (b2)
        {
            OriginalBackboardSize.Value = b2.localScale.x;
            b2.localScale = b2.localScale with { x = b2.localScale.x * scaleFactor };
        }

        var b3 = __instance.transform.Find("Quick Map/BG");
        if (b3)
        {
            OriginalMapSize.Value = b3.localScale.x;
            b3.localScale = b3.localScale with { x = b3.localScale.x * scaleFactor };
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoLanguage), nameof(LogoLanguage.OnEnable))]
    [HarmonyPatch(typeof(SetVersionNumber), nameof(SetVersionNumber.Start))]
    public static void LogoLanguage_OnEnable(MonoBehaviour __instance)
    {
        __instance.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.Awake))]
    public static void ForceCameraAspect_Awake(ForceCameraAspect __instance)
    {
        ForceCameraAspect.CurrentViewportAspect = Plugin.CurrentAspect;
       
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForceCameraAspect), nameof(ForceCameraAspect.AutoScaleViewport))]
    public static void ForceCameraAspect_AutoScaleViewport(ForceCameraAspect __instance, ref float __result)
    {
        var aspect = Plugin.CurrentAspect;
        ForceCameraAspect.CurrentViewportAspect = aspect;
        var rect = new Rect(0, 0, 1, 1);
        __instance.tk2dCam.CameraSettings.rect = rect;
        __instance.hudCam.rect = rect;
        __result = aspect;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }
}