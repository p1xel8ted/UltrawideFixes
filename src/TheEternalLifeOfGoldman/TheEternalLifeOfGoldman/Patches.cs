// Patches.cs — All Harmony patches for ultrawide support.
// Enforces native resolution and borderless fullscreen on all Screen.SetResolution overloads.
// Fixes AspectRatioFitter on the game's "BlackBars" overlay to match the ultrawide aspect ratio.
// Applies configurable screen effect toggles (paper, color bleed, distortion) via ScreenEffectsUber,
// skipping the IntroCamera instance to avoid breaking the intro sequence.
// Configures PPv2 anti-aliasing mode and discovers post-processing volumes at runtime.
// Adds AspectRatioFitter to BaseWindow child elements (dialog backgrounds, vignettes, masks)
// via a centralized WindowsStackLayer.AddWindow hook to prevent pillarboxing.

namespace TheEternalLifeOfGoldman;

[Harmony]
public static class Patches
{
    private static ScreenEffectsUber _introCameraScreenEffects;

    // --- Resolution Enforcement ---

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(RefreshRate))]
    public static bool Screen_SetResolution(ref int width, ref int height)
    {
        if (width != DisplayMetrics.MainWidth || height != DisplayMetrics.MainHeight) return false;
        if (Screen.width == DisplayMetrics.MainWidth && Screen.height == DisplayMetrics.MainHeight) return false;
        Plugin.Logger.LogInfo($"[Screen.SetResolution]: Forced resolution to {width}x{height}.");
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
        return true;
    }


    // --- Black Bars / Pillarboxing ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        if (__instance.name != "BlackBars") return;
        __instance.aspectRatio = DisplayMetrics.MainAspect;
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        Plugin.Logger.LogInfo($"[AspectRatioFitter]: Updated BlackBars AspectRatioFitter with aspect {__instance.aspectRatio:F4} -> Full path: {__instance.gameObject.GetPath()}.");
    }


    // --- Screen Effects ---

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenEffectsUber), nameof(ScreenEffectsUber.OnRenderImage))]
    public static void ScreenEffectsUber_OnRenderImage(ScreenEffectsUber __instance)
    {
        if (!_introCameraScreenEffects && __instance.gameObject.GetPath().Contains("IntroCamera", StringComparison.OrdinalIgnoreCase))
        {
            _introCameraScreenEffects = __instance;
            Plugin.Logger.LogInfo($"[ScreenEffectsUber]: IntroCamera instance identified, skipping screen effects for this instance.");
        }

        if (__instance == _introCameraScreenEffects) return;
        ScreenEffects.ApplyToInstance(__instance);
    }

    // --- Post-Processing ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraPostProcess), nameof(CameraPostProcess.LateUpdate))]
    public static void CameraPostProcess_LateUpdate_PostProcess(CameraPostProcess __instance)
    {
        var layer = __instance.GetComponent<PostProcessLayer>();
        if (!layer) return;

        PostProcessing.ApplyToInstance(layer);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void PostProcessVolume_OnEnable(PostProcessVolume __instance)
    {
        Volumes.ProcessVolume(__instance);
    }

    // --- Windows / UI Scaling ---

    /// <summary>
    /// Appears all windows are derived from BaseWindow and created via WindowsStackLayer.AddWindow, so patching that method allows us to apply an AspectRatioFitter to the relevant child elements of any window as soon as it's created. This is necessary because some windows (notably the first boss intro drawing) have their own custom aspect ratio handling that doesn't account for wider-than-16:9 ratios, and we need to override that to prevent stretching and pillarboxing.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(WindowsStackLayer), nameof(WindowsStackLayer.AddWindow))]
    public static void WindowsStackLayer_Show(WindowsStackLayer __instance, BaseWindow window)
    {
        var windowContent = window?.WindowContent;
        if (!windowContent)
        {
            Plugin.Logger.LogWarning($"[WindowsStackLayer]: Could not find WindowContent for {window?.GetType().Name ?? "null"} window, skipping aspect ratio adjustment.");
            return;
        }

        if (windowContent.GetPath().Contains("DrawingWindow", StringComparison.OrdinalIgnoreCase))
        {
            Plugin.Logger.LogInfo($"[WindowsStackLayer]: Detected DrawingWindow, skipping. Window path: {windowContent.GetPath()}");
            return;
        }

        //first boss intro drawing background (parchment)
        var background = windowContent.transform.FindChild("Background");

        //first boss intro drawing video
        var drawingVideo = windowContent.transform.FindChild("DrawingVideo");

        //dialog windows, two backgrounds
        var darkBackground = windowContent.transform.FindChild("WindowBackground");
        var vignette = windowContent.transform.FindChild("Vignette");

        //cutscene mask in space
        var mask = windowContent.transform.FindChild("Mask");

        var scaleThese = new[] { background, drawingVideo, darkBackground, vignette, mask };

        foreach (var element in scaleThese)
        {
            if (!element) continue;

            var arf = element.gameObject.TryAddComponent<AspectRatioFitter>();

            if (!arf) continue;

            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = DisplayMetrics.MainAspect;
            Plugin.Logger.LogInfo($"[WindowsStackLayer]: AspectRatioFitter added to {window.GetType().Name} {element.name} with aspect {arf.aspectRatio:F4} -> Full path: {element.gameObject.GetPath()}.");
        }
    }

    // --- Resolution Menu ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuOptionsDisplayPanel), nameof(MainMenuOptionsDisplayPanel.InitializeResolutions))]
    public static void MainMenuOptionsDisplayPanel_InitializeResolutions(MainMenuOptionsDisplayPanel __instance)
    {
        var nativeRes = new Vector2Int(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight);
        var nativeText = $"{DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}";

        for (var i = 0; i < __instance.resolutions.Count; i++)
        {
            __instance.resolutions[i] = nativeRes;
            __instance.resolutionTexts[i] = nativeText;
        }

        __instance.Resolution.Initialize(__instance.resolutionTexts, 0, __instance.Resolution.callback);

        Plugin.Logger.LogInfo($"[MainMenuOptionsDisplayPanel]: Replaced all {__instance.resolutions.Count} resolutions with {nativeText}.");
    }

    // --- Video ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroVideoLayer), nameof(IntroVideoLayer.Prepare))]
    [HarmonyPatch(typeof(IntroVideoLayer), nameof(IntroVideoLayer.Play))]
    [HarmonyPatch(typeof(IntroVideoLayer), nameof(IntroVideoLayer.InitializeRenderTexture))]
    public static void IntroVideoLayer_Prepare_Play_InitializeRenderTexture(IntroVideoLayer __instance)
    {
        __instance.AlphaVideo.aspectRatio = VideoAspectRatio.FitVertically;
        __instance.ColorVideo.aspectRatio = VideoAspectRatio.FitVertically;

        //resize render textures to 16:9
        var alphaTexture = __instance.AlphaVideo?.targetTexture;
        if (alphaTexture && (alphaTexture.width != DisplayMetrics.BaselineWidth || alphaTexture.height != DisplayMetrics.MainHeight))
        {
            alphaTexture.Release();
            alphaTexture.width = DisplayMetrics.BaselineWidth;
            alphaTexture.height = DisplayMetrics.MainHeight;
            alphaTexture.Create();
            Plugin.Logger.LogInfo($"[IntroVideoLayer]: Alpha video render texture resized to {alphaTexture.width}x{alphaTexture.height}.");
        }

        var colorTexture = __instance.ColorVideo?.targetTexture;
        if (colorTexture && (colorTexture.width != DisplayMetrics.BaselineWidth || colorTexture.height != DisplayMetrics.MainHeight))
        {
            colorTexture.Release();
            colorTexture.width = DisplayMetrics.BaselineWidth;
            colorTexture.height = DisplayMetrics.MainHeight;
            colorTexture.Create();
            Plugin.Logger.LogInfo($"[IntroVideoLayer]: Color video render texture resized to {colorTexture.width}x{colorTexture.height}.");
        }
    }
}