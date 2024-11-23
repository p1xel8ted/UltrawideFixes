// Patches.cs

namespace SeaOfStars;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerMovementProfile), nameof(PlayerMovementProfile.GetRunSpeed))]
    [HarmonyPatch(typeof(PlayerMovementProfile), nameof(PlayerMovementProfile.GetWalkSpeed))]
    [HarmonyPatch(typeof(WorldMapPlayerController), nameof(WorldMapPlayerController.GetRunSpeed))]
    public static void PlayerMovementProfile_GetSpeed(ref float __result)
    {
        var speedMultiplier = Configuration.Configuration.RunSpeedMultiplier.Value;
        __result *= speedMultiplier;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenResolutionManager), nameof(ScreenResolutionManager.InitResolutionLists))]
    public static void ScreenResolutionManager_InitVideoSettings(ScreenResolutionManager __instance)
    {
        var res = new Resolution
        {
            width = DisplayManager.MainWidth,
            height = DisplayManager.MainHeight,
            refreshRate = DisplayManager.MaxRefresh
        };

        var exclusiveExists = __instance.exclusiveResolutions.Exists(new Func<Resolution, bool>(r => r.width == res.width && r.height == res.height));
        if (!exclusiveExists)
        {
            __instance.exclusiveResolutions.Add(res);
            __instance.exclusiveResolutions.SortByPixelCount();
        }

        var fullscreenExists = __instance.fullscreenResolutions.Exists(new Func<Resolution, bool>(r => r.width == res.width && r.height == res.height));
        if (!fullscreenExists)
        {
            __instance.fullscreenResolutions.Add(res);
            __instance.fullscreenResolutions.SortByPixelCount();
        }

        var windowedExists = __instance.windowedResolutions.Exists(new Func<Resolution, bool>(r => r.width == res.width && r.height == res.height));
        if (!windowedExists)
        {
            __instance.windowedResolutions.Add(res);
            __instance.windowedResolutions.SortByPixelCount();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.Start))]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.OnEnable))]
    public static void TitleScreen_Start(TitleScreen __instance)
    {
        Utilities.Utilities.UpdateScreenTransform(__instance.transform, false, Core.Constants.TransitionIn);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GenericPopupScreen), nameof(GenericPopupScreen.Init))]
    [HarmonyPatch(typeof(GenericPopupScreen), nameof(GenericPopupScreen.OnInDone))]
    public static void GenericPopupScreen_Init(GenericPopupScreen __instance)
    {
        Utilities.Utilities.UpdateScreenTransform(__instance.transform, false, Core.Constants.Background);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.Init))]
    [HarmonyPatch(typeof(OptionsScreen), nameof(OptionsScreen.OnInDone))]
    [HarmonyPatch(typeof(SaveSelectionScreen), nameof(SaveSelectionScreen.OnEnable))]
    [HarmonyPatch(typeof(SaveSelectionScreen), nameof(SaveSelectionScreen.Init))]
    [HarmonyPatch(typeof(HowToPlayScreen), nameof(HowToPlayScreen.OnInDone))]
    [HarmonyPatch(typeof(HowToPlayScreen), nameof(HowToPlayScreen.Init))]
    public static void Overlay_Init(View __instance)
    {
        Utilities.Utilities.UpdateScreenTransform(__instance.transform, true, Core.Constants.Overlay);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadingScreen), nameof(LoadingScreen.Init))]
    [HarmonyPatch(typeof(SkipCutsceneTransitionScreen), nameof(SkipCutsceneTransitionScreen.Init))]
    [HarmonyPatch(typeof(SkipCutsceneTransitionScreen), nameof(SkipCutsceneTransitionScreen.FadeIn))]
    [HarmonyPatch(typeof(FishingPanelScreen), nameof(FishingPanelScreen.OnEnable))]
    [HarmonyPatch(typeof(FishingPanelScreen), nameof(FishingPanelScreen.InitData))]
    [HarmonyPatch(typeof(ShopMenu), nameof(ShopMenu.Init))]
    [HarmonyPatch(typeof(ShopMenu), nameof(ShopMenu.OnInDone))]
    [HarmonyPatch(typeof(GameMenu), nameof(GameMenu.Init))]
    [HarmonyPatch(typeof(GameMenu), nameof(GameMenu.OnInDone))]
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.Init))]
    [HarmonyPatch(typeof(AchievementScreen), nameof(AchievementScreen.Init))]
    [HarmonyPatch(typeof(AchievementScreen), nameof(AchievementScreen.OnInDone))]
    [HarmonyPatch(typeof(CookingScreen), nameof(CookingScreen.Init))]
    [HarmonyPatch(typeof(CookingScreen), nameof(CookingScreen.OnInDone))]
    [HarmonyPatch(typeof(AssignControllersScreen), nameof(AssignControllersScreen.Init))]
    [HarmonyPatch(typeof(AssignControllersScreen), nameof(AssignControllersScreen.OnEnable))]
    [HarmonyPatch(typeof(FishRewardScreen), nameof(FishRewardScreen.Init))]
    [HarmonyPatch(typeof(FishRewardScreen), nameof(FishRewardScreen.OnInDone))]
    [HarmonyPatch(typeof(MultipleChoiceDialog), nameof(MultipleChoiceDialog.Init))]
    [HarmonyPatch(typeof(MultipleChoiceDialog), nameof(MultipleChoiceDialog.OnInDone))]
    [HarmonyPatch(typeof(ConchScreen), nameof(ConchScreen.Init))]
    [HarmonyPatch(typeof(ConchScreen), nameof(ConchScreen.OnInDone))]
    [HarmonyPatch(typeof(ColorFadeTransitionScreen), nameof(ColorFadeTransitionScreen.Init))]
    [HarmonyPatch(typeof(ColorFadeTransitionScreen), nameof(ColorFadeTransitionScreen.FadeIn))]
    [HarmonyPatch(typeof(MapScreen), nameof(MapScreen.Init))]
    public static void Screen_Init(View __instance)
    {
        Utilities.Utilities.UpdateScreenTransform(__instance.transform, true, Core.Constants.Screen);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PanelCutsceneScreen), nameof(PanelCutsceneScreen.Init))]
    [HarmonyPatch(typeof(PanelCutsceneScreen), nameof(PanelCutsceneScreen.DisplayPanel))]
    public static void PanelCutSceneScreen_Init(PanelCutsceneScreen __instance)
    {
        Utilities.Utilities.UpdateScreenTransform(__instance.transform, true, Core.Constants.Screen);
        
        var cloudVision = __instance.transform.FindChild(Core.Constants.CloudVision);
        
        if (!cloudVision) return;
        
        var top = cloudVision.FindChild(Core.Constants.Top);
        if (top)
        {
            top.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1.1f, 1f);
        }
        var bottom = cloudVision.FindChild(Core.Constants.Bottom);
        if (bottom)
        {
            bottom.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1.1f, 1f);
        }
        var left = cloudVision.FindChild(Core.Constants.Left);
        if (left)
        {
            left.localPosition = new Vector3(-DisplayManager.BlackBarSize, 0f, 0f);
        }
        var right = cloudVision.FindChild(Core.Constants.Right);
        if (right)
        {
            right.localPosition = new Vector3(DisplayManager.BlackBarSize, 0f, 0f);
        }


    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CutsceneBars_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains(Core.Constants.Sinai, StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        if (__instance.name == Core.Constants.VideoPlayerUICanvas)
        {
            Utilities.Utilities.AddContentSizeFitter(__instance.gameObject, true);
        }

        if (__instance.name == Core.Constants.CutsceneBars)
        {
            var screen = __instance.transform.FindChild(Core.Constants.Screen);
            if (screen)
            {
                screen.localScale = new Vector3(1000f, 1f, 1f);
                screen.gameObject.SetActive(Configuration.Configuration.CinematicLetterboxing.Value);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FishingPreviewRenderer), nameof(FishingPreviewRenderer.EndFishingCamera))]
    public static void FishingPreviewRenderer_EndFishingCamera(FishingPreviewRenderer __instance)
    {
        SoSuiManager.ToggleContentFitter(true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FishermanController), nameof(FishermanController.SetPlayer))]
    public static void FishermanController_SetPlayer(FishermanController __instance)
    {
        SoSuiManager.ToggleContentFitter(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        if (__instance.name == Core.Constants.FishingPreviewCamera) return;

        SoSuiManager.PixelPerfectRefRes.Add(new Vector2(__instance.refResolutionX, __instance.refResolutionY));
        __instance.cropFrameX = false;
        __instance.cropFrameY = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasUpscaleViewport), nameof(CanvasUpscaleViewport.OnEnable))]
    public static void CanvasUpscaleViewport_OnEnable(CanvasUpscaleViewport __instance)
    {
        __instance.canvasRectTransform.sizeDelta = SoSuiManager.GetPixelPerfectVector();
        Utilities.Utilities.AddContentSizeFitter(__instance.gameObject);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenResolutionManager), nameof(ScreenResolutionManager.EnsureAspectRatio))]
    public static void ScreenResolutionManager_EnsureAspectRatio(ref float targetAspect)
    {
        targetAspect = DisplayManager.MainAspectRatio;
    }
}