namespace REPLACED.Patches;

[Harmony]
public static class Patches
{
    private const float NativeAspect = 16f / 9f;

    private static readonly string[] ConstrainedCanvases = ["MainMenuCanvas", "NewSettingsMenu"];
    private static readonly string[] HudCanvases = ["ScreenSpaceCanvas"];
    

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIGameIntroScreen), nameof(UIGameIntroScreen.Start))]
    public static void UIGameIntroScreen_Start(UIGameIntroScreen __instance)
    {
        __instance.shownScreens = new Il2CppReferenceArray<UIGameIntroScreen.ScreenInfo>(0);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadingScreen), nameof(LoadingScreen.Start))]
    public static void LoadingScreen_Start(LoadingScreen __instance)
    {
        if (Plugin.CurrentAspect <= Plugin.NativeMaxAspect)
        {
            Console.WriteLine($"[REPLACED Ultra-Wide] Skipping fix — aspect {Plugin.CurrentAspect:F2} <= native max {Plugin.NativeMaxAspect:F2}");
            return;
        }

        var canvas = __instance.GetComponent<Canvas>();
        if (canvas)
        {
            ConstrainCanvasTo16By9(canvas);
            StretchToFullScreen(__instance.transform, "Image");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIPauseMenu), nameof(UIPauseMenu.Start))]
    public static void UIPauseMenu_Start(UIPauseMenu __instance)
    {
        if (Plugin.CurrentAspect <= Plugin.NativeMaxAspect)
        {
            Console.WriteLine($"[REPLACED Ultra-Wide] Skipping fix — aspect {Plugin.CurrentAspect:F2} <= native max {Plugin.NativeMaxAspect:F2}");
            return;
        }

        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        if (arf)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = NativeAspect;
        }

        var background = FindDeepChild(__instance.transform, "Background");
        if (background)
        {
            var bArf = background.gameObject.TryAddComponent<AspectRatioFitter>();
            if (!bArf) return;
            bArf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            bArf.aspectRatio = (float)Plugin.MainWidth / Plugin.MainHeight;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (Plugin.CurrentAspect <= Plugin.NativeMaxAspect)
        {
            Console.WriteLine($"[REPLACED Ultra-Wide] Skipping fix — aspect {Plugin.CurrentAspect:F2} <= native max {Plugin.NativeMaxAspect:F2}");
            return;
        }

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        if (ConstrainedCanvases.Contains(__instance.name))
        {
            var canvas = __instance.GetComponent<Canvas>();
            if (canvas)
            {
                ConstrainCanvasTo16By9(canvas);
            }
        }

        if (Plugin.ConstrainHud.Value && HudCanvases.Contains(__instance.name))
        {
            var canvas = __instance.GetComponent<Canvas>();
            if (canvas)
            {
                ConstrainCanvasTo16By9(canvas);
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

    private static void StretchToFullScreen(Transform root, string childName)
    {
        var child = FindDeepChild(root, childName);
        if (!child) return;

        child.transform.localScale = child.transform.localScale with { x = 500f };
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
        var cameras = Camera.allCameras.ToList();
        foreach (var cam in cameras.Where(cam => !cam.name.Contains("ui", StringComparison.OrdinalIgnoreCase)))
        {
            if (Plugin.CurrentAspect > NativeAspect)
            {
                cam.gateFit = Camera.GateFitMode.Vertical;
            }
        }

        if (Plugin.CurrentAspect <= Plugin.NativeMaxAspect)
        {
            Console.WriteLine($"[REPLACED Ultra-Wide] Skipping aspect fixes — aspect {Plugin.CurrentAspect:F2} <= native max {Plugin.NativeMaxAspect:F2}");
            return;
        }

        CameraAspectExtension.TargetWidthAspect = Plugin.TargetWidthAspect;
        CameraAspectExtension.TargetHeightAspect = 9f;
    }

    // private static void DumpHierarchy(this GameObject go, int depth = 0)
    // {
    //     var indent = new string(' ', depth * 2);
    //     var components = string.Join(", ", go.GetComponents<Component>().Select(c => c.GetIl2CppType().Name));
    //     var active = go.activeSelf ? "" : " [INACTIVE]";
    //     Console.WriteLine($"[REPLACED Ultra-Wide] {indent}{go.name}{active} ({components})");
    //     for (var i = 0; i < go.transform.childCount; i++)
    //     {
    //         go.transform.GetChild(i).gameObject.DumpHierarchy(depth + 1);
    //     }
    // }
}