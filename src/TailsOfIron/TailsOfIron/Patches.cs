namespace TailsOfIron;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BootFlowController), nameof(BootFlowController.ProgressSplashScreen))]
    public static void BootFlowController_ProgressSplashScreen(BootFlowController __instance)
    {
        __instance.SkipCurrentSplashScreen();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains("sinai")) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        if (__instance.name == "OpeningMenu")
        {
            var bg = __instance.transform.Find("BookBackground");
            if (bg)
            {
                const float twn = 21.5f / 9f;
                const float epsilon = 0.0001f;
                if (Plugin.MainAspectRatio > twn + epsilon)
                {
                    bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);   
                }
            }
        }
    }

    internal static void UpdateVolumes()
    {
        var ppl = Resources.FindObjectsOfTypeAll<PostProcessLayer>();
        foreach (var layer in ppl)
        {
            layer.antialiasingMode = Plugin.AntiAliasing.Value;
        }

        var volumes = Resources.FindObjectsOfTypeAll<Volume>();
        foreach (var ap in volumes.Select(vol => vol.profile))
        {
            if (ap.TryGet(out Vignette vignette))
            {
                vignette.active = Plugin.Vignette.Value;
            }

            if (ap.TryGet(out ColorAdjustments colorAdjustments))
            {
                colorAdjustments.active = Plugin.ColorAdjustments.Value;
            }

            if (ap.TryGet(out LiftGammaGain liftGammaGain))
            {
                liftGammaGain.active = Plugin.LiftGammaGain.Value;
            }

            if (ap.TryGet(out FilmGrain filmGrain))
            {
                filmGrain.active = Plugin.FilmGrain.Value;
            }

            if (ap.TryGet(out ChromaticAberration chromaticAberration))
            {
                chromaticAberration.active = Plugin.ChromaticAberration.Value;
            }

            if (ap.TryGet(out WhiteBalance whiteBalance))
            {
                whiteBalance.active = Plugin.WhiteBalance.Value;
            }

            if (ap.TryGet(out ColorCurves colorCurves))
            {
                colorCurves.active = Plugin.ColorCurves.Value;
            }

            if (ap.TryGet(out ShadowsMidtonesHighlights shadowsMidtonesHighlights))
            {
                shadowsMidtonesHighlights.active = Plugin.ShadowsMidtonesHighlights.Value;
            }

            ap.isDirty = true;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioControlBase), nameof(AspectRatioControlBase.SetAspectRatio))]
    public static void AspectRatioControlBase_SetAspectRatio(AspectRatioControlBase __instance, int ScreenWidth, int ScreenHeight)
    {
        __instance.m_Camera.aspect = (float)ScreenWidth / ScreenHeight;
        __instance.m_Camera.pixelRect = new Rect(0, 0, ScreenWidth, ScreenHeight);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameStateManagerBase), nameof(GameStateManagerBase.SetTimeScale))]
    public static void GameStateManagerBase_SetTimeScale(ref float timescale)
    {
        if (timescale != 0f)
        {
            Time.fixedDeltaTime = Plugin.CurrentFixedDeltaTime * Time.timeScale;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsVideoSubMenu), nameof(SettingsVideoSubMenu.SetCurrentResolutionToProfile))]
    public static void SettingsVideoSubMenu_SetCurrentResolutionToProfile()
    {
        Plugin.UpdateDisplay();
        Plugin.UpdateFixedDeltaTime();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.Init))]
    public static void PostProcessVolume_OnEnable()
    {
        UpdateVolumes();
    }
}