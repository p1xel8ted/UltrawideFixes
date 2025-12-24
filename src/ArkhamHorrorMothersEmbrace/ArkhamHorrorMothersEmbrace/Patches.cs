namespace ArkhamHorrorMothersEmbrace;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HUDScreen), nameof(HUDScreen.FadeBlackBars))]
    public static void HUDScreen_FadeBlackBars(ref bool _IsVisible, ref float _BlackBarsSize)
    {
        _BlackBarsSize = 0;
        _IsVisible = false;
        Plugin.Log.LogInfo("Disabled HUD black bars.");
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        if (__instance.renderMode == VideoRenderMode.RenderTexture &&
            __instance.targetTexture &&
            __instance.targetTexture.width != Plugin.CurrentWidth)
        {
            var tex = __instance.targetTexture;
            tex.Release();
            tex.width = Plugin.CurrentWidth;
            tex.height = Plugin.CurrentHeight;
            tex.Create();
            Plugin.Log.LogInfo($"Resized VideoPlayer RenderTexture to {tex.width}x{tex.height}");
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ForceRatioCamera), nameof(ForceRatioCamera.Start))]
    [HarmonyPatch(typeof(ForceRatioCamera), nameof(ForceRatioCamera.RefreshScreen))]
    public static void ForceRatioCamera_Start(ForceRatioCamera __instance)
    {
        __instance.Aspect = new Vector2(Screen.width, Screen.height);
        Plugin.Log.LogInfo($"Setting ForceRatioCamera aspect to screen dimensions on {__instance.name} at {__instance.gameObject.Path()}");
    }
    
    // Registers post-processing volumes for runtime configuration
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    public static void VolumeManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    // Applies configured post-processing settings when a volume is enabled
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void Volume_OnEnable(PostProcessVolume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenuScreen), nameof(PauseMenuScreen.Start))]
    [HarmonyPatch(typeof(PauseMenuScreen), nameof(PauseMenuScreen.InitInfo))]
    public static void PauseMenuScreen_Start(PauseMenuScreen __instance)
    {
        var bg = __instance.transform.Find("ImgThumbnail");
        if (bg)
        {
            bg.localScale = bg.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled background in PauseMenuScreen.");
        }
        else
        {
            Plugin.Log.LogWarning("Background not found in PauseMenuScreen.");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadingScreen), nameof(LoadingScreen.Start))]
    [HarmonyPatch(typeof(LoadingScreen), nameof(LoadingScreen.Init))]
    public static void LoadingScreen_Start(LoadingScreen __instance)
    {
        var bg = __instance.transform.Find("LoadingContentDefault(Clone)/Canvas/Background");
        if (bg)
        {
            bg.localScale = bg.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled background in LoadingScreen.");
        }
        else
        {
            Plugin.Log.LogWarning("Background not found in LoadingScreen.");
        }

        var stars = __instance.transform.Find("LoadingContentDefault(Clone)/Canvas/Stars");
        if (stars)
        {
            stars.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            Plugin.Log.LogInfo("Rescaled stars in LoadingScreen.");
        }
        else
        {
            Plugin.Log.LogWarning("Stars not found in LoadingScreen.");
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenManager), nameof(ScreenManager.Awake))]
    [HarmonyPatch(typeof(ScreenManager), nameof(ScreenManager.Initialize))]
    public static void ScreenManager_Initialize(ScreenManager __instance)
    {
        var overlay = __instance.transform.Find("Canvas_BlackBorder");
        if (overlay)
        {
            if (!overlay.gameObject.activeSelf) return;

            overlay.gameObject.SetActive(false);
            Plugin.Log.LogInfo("Disabled pillarbox border overlay in ScreenManager.");
        }
        else
        {
            Plugin.Log.LogWarning("Black border overlay not found in ScreenManager.");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TutorialPopup), nameof(TutorialPopup.InitInfo))]
    [HarmonyPatch(typeof(TutorialPopup), nameof(TutorialPopup.SetPopupWidth))]
    public static void TutorialPopup_InitInfo(TutorialPopup __instance)
    {
        var parent = __instance.transform.parent.gameObject;
        if (parent)
        {
            var arf = parent.TryAddComponent<AspectRatioFitter>();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.NativeAspect;
            Plugin.Log.LogInfo("Added AspectRatioFitter to TutorialPopup parent to maintain native aspect ratio.");
        }

        var vignette = __instance.transform.Find("Canvas/ImgThumbnail");
        if (vignette)
        {
            vignette.localScale = vignette.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled vignette in TutorialPopup.");
        }
        else
        {
            Plugin.Log.LogWarning("Vignette not found in TutorialPopup.");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuScreen), nameof(MainMenuScreen.Start))]
    public static void MainMenuScreen_Start(MainMenuScreen __instance)
    {
        var parent = __instance.transform.parent.gameObject;
        if (parent)
        {
            var arf = parent.TryAddComponent<AspectRatioFitter>();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = Plugin.NativeAspect;
            Plugin.Log.LogInfo("Added AspectRatioFitter to MainMenuScreen parent to maintain native aspect ratio.");
        }
        else
        {
            Plugin.Log.LogWarning("MainMenuScreen parent not found.");
        }

        var loadingBackground = __instance.transform.Find("BlackFade");
        if (loadingBackground)
        {
            var newX = (1080 * Plugin.CurrentAspect) / 2f; //(1080 * 2.38889) = 2580 / 2 = 1290
            loadingBackground.localPosition = loadingBackground.localPosition with { x = newX };
            loadingBackground.localScale = loadingBackground.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled and repositioned BlackFade in MainMenuScreen.");
        }
        else
        {
            Plugin.Log.LogWarning("BlackFade not found in MainMenuScreen.");
        }

        var bar1 = __instance.transform.Find("BlackBar1");
        var bar2 = __instance.transform.Find("BlackBar2");
        if (bar1)
        {
            bar1.localScale = bar1.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled BlackBar1 in MainMenuScreen.");
        }
        else
        {
            Plugin.Log.LogWarning("BlackBar1 not found in MainMenuScreen.");
        }

        if (bar2)
        {
            bar2.localScale = bar2.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled BlackBar2 in MainMenuScreen.");
        }
        else
        {
            Plugin.Log.LogWarning("BlackBar2 not found in MainMenuScreen.");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUDNotificationPanel), nameof(HUDNotificationPanel.LateUpdate))]
    public static void LateUpdate_Postfix(HUDNotificationPanel __instance)
    {
        if (__instance.IsHidden && __instance.transform.position.x > -Screen.width)
        {
            __instance.transform.position = new Vector3(-Screen.width, __instance.transform.position.y, __instance.transform.position.z);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), typeof(object))]
    private static bool Debug_LogWarning_Prefix(object message)
    {
        return message switch
        {
            string str1 when str1.Contains("CameraWall") || str1.Contains("Binary") => false,
            _ => true
        };
    }

    internal static void UpdateCameraGateFit()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras.Where(a => a))
        {
            if (cam.gateFit != Camera.GateFitMode.Vertical)
            {
                cam.gateFit = Camera.GateFitMode.Vertical;
                Plugin.Log.LogInfo($"Set Camera.gateFit to Vertical on camera {cam.name} at {cam.gameObject.Path()}");
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InteractionPopup), nameof(InteractionPopup.Activate))]
    [HarmonyPatch(typeof(InteractionPopup), nameof(InteractionPopup.Awake))]
    public static void InteractionPopup_OnEnable(InteractionPopup __instance)
    {
        var vignette = __instance.transform.Find("Canvas/IMG_Vignette");
        if (vignette)
        {
            vignette.localScale = vignette.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.Log.LogInfo("Rescaled vignette in InteractionPopup.");
        }
        else
        {
            Plugin.Log.LogWarning("Vignette not found in InteractionPopup.");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}