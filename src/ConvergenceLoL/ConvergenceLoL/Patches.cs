namespace ConvergenceLoL;

[Harmony]
public static class Patches
{
    private static readonly string[] SkipNames = ["SplashScreen_Video_DS.mp4", "SplashScreen_Video_RiotForge.mp4", "Convergence_Logo.mp4"];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ManagementScreen), nameof(ManagementScreen.OnShow))]
    [HarmonyPatch(typeof(ManagementScreen), nameof(ManagementScreen.OnTabChanged))]
    public static void ManagementScreen_OnShow(ManagementScreen __instance)
    {
        var bg = __instance.transform.Find("OverscanHandler/Background");
        if (bg)
        {
            bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioAdaptiveRect), nameof(AspectRatioAdaptiveRect.OnEnable))]
    [HarmonyPatch(typeof(AspectRatioAdaptiveRect), nameof(AspectRatioAdaptiveRect.FitToAspectRatio))]
    [HarmonyPatch(typeof(AspectRatioAdaptiveRect), nameof(AspectRatioAdaptiveRect.OnResolutionChanged))]
    public static void AspectRatioAdaptiveRect_OnEnable(AspectRatioAdaptiveRect __instance)
    {
        var y = __instance.RectTransform.sizeDelta.y;
        var x = Utils.GetHudRes(y);
        __instance.RectTransform.sizeDelta = new Vector2(x, y);


        var path = __instance.gameObject.GetPath();
        if (path == "ManagementScreen/OverscanHandler")
        {
            var bg = __instance.transform.Find("Background");
            if (bg)
            {
                bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
            }

            var header = __instance.transform.Find("Header");
            if (header)
            {
                var hBg = header.Find("Background");
                if (hBg)
                {
                    hBg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
                }
            }

            var footer = __instance.transform.Find("Footer_NT");
            if (footer)
            {
                var fBg = footer.Find("Background");
                if (fBg)
                {
                    fBg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
                }
            }
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        if (__instance.name == "Main Camera")
        {
      
            var mcBloomFound = __instance.profile.TryGet(out Bloom b1);
            if (mcBloomFound)
            {
                b1.active = Plugin.MainBloom.Value;
            }
            
            var mcVigFound = __instance.profile.TryGet(out Vignette v1);
            if (mcVigFound)
            {
                v1.active = Plugin.MainVignette.Value;
            }
        }

        if (__instance.name == "LowHPPostProcessing")
        {
            var lhpVigFound = __instance.profile.TryGet(out Vignette v2);
            if (lhpVigFound)
            {
                v2.active = Plugin.LowHpVignette.Value;
            }
          
            var lhpBloomFound = __instance.profile.TryGet(out Bloom b2);
            if (lhpBloomFound)
            {
                b2.active = Plugin.LowHpBloom.Value;
            }
            
            var lhpCaFound = __instance.profile.TryGet(out ChromaticAberration ca2);    
            if (lhpCaFound)
            {
                ca2.active = Plugin.LowHpChromaticAberration.Value;
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoScreen), nameof(VideoScreen.OnShow))]
    [HarmonyPatch(typeof(VideoScreen), nameof(VideoScreen.Awake))]
    public static void VideoScreen_OnEnable(VideoScreen __instance)
    {
        if (__instance._input == null) return;

        __instance._input.ShowCopyright = false;
        __instance._input.IsSkippable = true;
        __instance._input.PressAToSkip = true;

        foreach (var name in SkipNames)
        {
            if (!__instance._input.VideoFilePath.EndsWith(name)) continue;
            __instance.OnSkipButtonPressed();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.OnEnable))]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.FitToAspectRatio))]
    public static void CameraController_OnEnable(CameraController __instance)
    {
        __instance.MainCamera.aspect = Plugin.MainAspect;
        __instance.MainCamera.pixelRect = new Rect(0, 0, Plugin.SelectedResolution.width, Plugin.SelectedResolution.height);
        __instance.MainCamera.rect = new Rect(0, 0, 1, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UITransitions), nameof(UITransitions.Initialize))]
    [HarmonyPatch(typeof(UITransitions), nameof(UITransitions.FadeIn))]
    public static void UITransitions_OnShow(UITransitions __instance)
    {
        __instance._fadeCanvas.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        var bg = __instance.transform.Find("LoadingScreen/LoadingScreenBackground");
        if (bg)
        {
            bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.OnShow))]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.OnShow))]
    public static void UIScene_OnShow(UIScene __instance)
    {
        var bg = __instance.transform.Find("TitleScreenBG");
        if (bg && Plugin.MainAspect is > 1.777777777777778f and < 2.4f)
        {
            bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        // Skip processing if the CanvasScaler's name contains "sinai"
        if (__instance.name.Contains("sinai")) return;

        // Ensure the CanvasScaler uses the "Expand" match mode if it is set to ScaleWithScreenSize
        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        var blackBars = __instance.transform.Find("BlackBars");
        if (blackBars)
        {
            Plugin.Log.LogInfo("Disabling letterboxing");
            blackBars.gameObject.SetActive(false);
        }

        var pillars = __instance.transform.Find("ResolutionFrame");
        if (pillars)
        {
            Plugin.Log.LogInfo("Disabling pillarboxing");
            pillars.gameObject.SetActive(false);
        }
    }
}