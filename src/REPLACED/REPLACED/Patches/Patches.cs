namespace REPLACED.Patches;

[Harmony]
public static class Patches
{
    private const float NativeAspect = 16f / 9f;

    private static readonly string[] ConstrainedCanvases = ["MainMenuCanvas", "NewSettingsMenu"];
    private static readonly string[] HudCanvases = ["ScreenSpaceCanvas"];

    // One-shot flags: log first occurrence of each fix so users' bug reports show what engaged, without flooding the log.
    private static bool _loggedPauseFix;
    private static bool _loggedHudConstrain;
    private static bool _loggedPhysicalRestore;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIGameIntroScreen), nameof(UIGameIntroScreen.Start))]
    public static void UIGameIntroScreen_Start(UIGameIntroScreen __instance)
    {
        __instance.shownScreens = new Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo>(0);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIPauseMenu), nameof(UIPauseMenu.Start))]
    public static void UIPauseMenu_Start(UIPauseMenu __instance)
    {
        if (Plugin.CurrentAspect <= Plugin.NativeMaxAspect) return;

        if (!_loggedPauseFix)
        {
            _loggedPauseFix = true;
            Plugin.BLog?.LogInfo("Applied 16:9 AspectRatioFitter to pause menu (super-ultrawide pillarbox fix).");
        }

        // Root ARF — use FitInParent instead of HeightControlsWidth. FitInParent is guaranteed to constrain
        // BOTH dimensions to stay within the parent rect while maintaining the aspect ratio, so at 32:9 screen
        // Pause renders 1600x900 centered and NO child can render outside that rect. HeightControlsWidth had
        // an edge case where it only constrained width, leaving height uncapped — which made the nested
        // Options submenu render oversized in both axes.
        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
            arf.aspectRatio = NativeAspect;
        }

        // Background ARF — stretches the Pause Background child to cover the entire screen at any aspect ratio,
        // so the semi-transparent darkening overlay extends beyond the 16:9 pillarboxed Pause rect. Safe now
        // that the root ARF uses FitInParent (not HeightControlsWidth) — the previous interaction that shifted
        // the nested in-game Settings was root-ARF-mode-specific, not caused by this Background ARF.
        var background = FindDeepChild(__instance.transform, "Background");
        if (background)
        {
            var bArf = background.gameObject.TryAddComponent<AspectRatioFitter>();
            if (bArf)
            {
                bArf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
                bArf.aspectRatio = (float)Plugin.MainWidth / Plugin.MainHeight;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        // Skip at sub-ultrawide aspects — game is already correct there.
        if (Plugin.CurrentAspect <= Plugin.NativeMaxAspect) return;

        var name = __instance.name;

        // Blanket fix: set every ScaleWithScreenSize CanvasScaler to Expand mode. This gives uniform
        // min(widthRatio, heightRatio) scaling so UI never overflows either axis.
        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize &&
            __instance.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        // 16:9 pillarbox wrap for specific canvases.
        if (ConstrainedCanvases.Contains(name))
        {
            var canvas = __instance.GetComponent<Canvas>();
            if (canvas)
            {
                ConstrainCanvasTo16By9(canvas);
            }
        }

        if (Plugin.ConstrainHud != null && Plugin.ConstrainHud.Value && HudCanvases.Contains(name))
        {
            var canvas = __instance.GetComponent<Canvas>();
            if (canvas)
            {
                ConstrainCanvasTo16By9(canvas);
                if (!_loggedHudConstrain)
                {
                    _loggedHudConstrain = true;
                    Plugin.BLog?.LogInfo($"Constrained HUD canvas '{name}' to 16:9 (Constrain HUD config enabled).");
                }
            }
        }
    }

    private static void ConstrainCanvasTo16By9(Canvas canvas)
    {
        if (!canvas) return;
        if (canvas.transform.Find("UWContainer")) return;

        var container = new GameObject("UWContainer");
        container.transform.SetParent(canvas.transform, false);

        var containerRect = container.TryAddComponent<RectTransform>();
        containerRect.anchorMin = Vector2.zero;
        containerRect.anchorMax = Vector2.one;
        containerRect.sizeDelta = Vector2.zero;
        containerRect.anchoredPosition = Vector2.zero;

        var arf = container.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
        arf.aspectRatio = NativeAspect;

        var children = new List<Transform>();
        for (var i = 0; i < canvas.transform.childCount; i++)
        {
            var child = canvas.transform.GetChild(i);
            if (child.gameObject != container)
            {
                children.Add(child);
            }
        }

        foreach (var child in children)
        {
            child.SetParent(containerRect, false);
        }
    }

    private static void PollFovKeybinds()
    {
        if (Plugin.FovIncreaseKey == null || Plugin.FovDecreaseKey == null ||
            Plugin.FovResetKey == null || Plugin.FovMultiplier == null) return;

        if (Input.GetKeyDown(Plugin.FovIncreaseKey.Value))
        {
            Plugin.FovMultiplier.Value = Mathf.Clamp(Plugin.FovMultiplier.Value + Plugin.FovStep, 0.3f, 1.5f);
        }
        else if (Input.GetKeyDown(Plugin.FovDecreaseKey.Value))
        {
            Plugin.FovMultiplier.Value = Mathf.Clamp(Plugin.FovMultiplier.Value - Plugin.FovStep, 0.3f, 1.5f);
        }
        else if (Input.GetKeyDown(Plugin.FovResetKey.Value))
        {
            Plugin.FovMultiplier.Value = 1f;
        }
    }

    private static Transform FindDeepChild(Transform parent, string name)
    {
        for (var i = 0; i < parent.childCount; i++)
        {
            var child = parent.GetChild(i);
            if (child.name == name) return child;
            var result = FindDeepChild(child, name);
            if (result) return result;
        }

        return null;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneManager_Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (Plugin.CurrentAspect <= NativeAspect) return;

        var fixedCameras = 0;
        foreach (var cam in Camera.allCameras)
        {
            if (!cam.name.Contains("ui", StringComparison.OrdinalIgnoreCase))
            {
                cam.gateFit = Camera.GateFitMode.Vertical;
                fixedCameras++;
            }
        }

        Plugin.BLog?.LogInfo($"Scene '{scene.name}' loaded - set vertical gate fit on {fixedCameras} non-UI camera(s).");
    }

    // Cinemachine pushes vcam lens state onto the output Unity camera here every frame. Cutscene vcams can
    // demote the camera from physical→non-physical (narrower FOV at 21:9+) and the demotion persists after
    // the blend. Re-assert physical properties + gate after the brain has done its work.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.LateUpdate))]
    public static void CinemachineBrain_LateUpdate(CinemachineBrain __instance)
    {
        var cam = __instance.m_OutputCamera;
        if (!cam) return;

        // Input polling — piggybacks on LateUpdate since we can't attach a custom MonoBehaviour (IL2CPP
        // ClassInjector crashes in this game). Only fires during gameplay where the Cinemachine brain ticks;
        // menus don't need FOV adjustment anyway.
        PollFovKeybinds();

        // FOV multiplier — applied at all aspects so sub-ultrawide users can tune too. Each frame the brain
        // pushes the authored vFov; we scale it by the multiplier. Main Camera only — UI/helper cameras left alone.
        if (cam.name == "Main Camera")
        {
            var multiplier = Plugin.FovMultiplier?.Value ?? 1f;
            if (Mathf.Abs(multiplier - 1f) > 0.001f)
            {
                cam.fieldOfView *= multiplier;
            }
        }

        if (Plugin.CurrentAspect <= NativeAspect) return;

        // Force physical + vertical gate on the Main Camera specifically. Other cameras (UI overlays,
        // render-texture helpers) may legitimately be non-physical — don't clobber those.
        if (cam.name == "Main Camera")
        {
            var wasPhysical = cam.usePhysicalProperties;
            cam.usePhysicalProperties = true;
            cam.gateFit = Camera.GateFitMode.Vertical;

            if (!wasPhysical && !_loggedPhysicalRestore)
            {
                _loggedPhysicalRestore = true;
                Plugin.BLog?.LogInfo("Restored Main Camera physical=true (was non-physical, likely cutscene demotion).");
            }
        }
    }

    // Fallback: intercept the physical→non-physical flip at the Camera property setter itself. Belt-and-braces
    // for cases where something other than Cinemachine (Timeline animation track, custom cutscene script) writes
    // to usePhysicalProperties on the Main Camera.
    // NOTE: IL2CPP requires string method name for property setters — MethodType.Setter silently fails.
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), "set_usePhysicalProperties")]
    public static void Camera_set_usePhysicalProperties(Camera __instance, ref bool value)
    {
        if (!__instance || __instance.name != "Main Camera") return;
        if (value) return;

        value = true;
    }
}
