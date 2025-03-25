namespace BAKERU.Patches;

[Harmony]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenFitter), nameof(ScreenFitter.Start))]
    [HarmonyPatch(typeof(ScreenFitter), nameof(ScreenFitter.OnEnable))]
    public static void ScreenFitter_OnEnable(ScreenFitter __instance)
    {
        __instance.gameObject.TryAddComponent<ScreenFitterOverride>();

        string[] children = ["BG_L", "BG_R", "BG_B", "BG_T", "Top", "Bottom"];
        foreach (var child in children)
        {
            var found = __instance.transform.FindChild(child);
            if (found)
            {
                found.gameObject.SetActive(false);
            }
        }


        var back = __instance.transform.FindChild("Back");
        if (back)
        {
            AddLayoutElementAndContentSizeFitterRoot(back, Size.ForceFullScreen);
            back.transform.position = back.transform.position with { x = 0 };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FadeManager), nameof(FadeManager.Initialize))]
    [HarmonyPatch(typeof(FadeManager), nameof(FadeManager.FadeIn))]
    [HarmonyPatch(typeof(FadeManager), nameof(FadeManager.FadeOut))]
    public static void FadeManager_Initialize(FadeManager __instance)
    {
        if (__instance && __instance.transform)
        {
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "FadeCanvas/FadeImage", Size.ForceFullScreen);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneCutscene), nameof(SceneCutscene.Awake))]
    [HarmonyPatch(typeof(SceneCutscene), nameof(SceneCutscene.Setup))]
    public static void SceneCutscene_Awake(SceneCutscene __instance)
    {
        __instance.m_ShowSkipUI = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CommonCutScene), nameof(CommonCutScene.Awake))]
    [HarmonyPatch(typeof(CommonCutScene), nameof(CommonCutScene.Setup))]
    public static void CommonCutScene_Awake(CommonCutScene __instance)
    {
        __instance.m_ShowSkipUI = true;
        __instance.m_FixedAspectRatio = false;
        __instance.m_CameraGateFitMode = Plugin.CurrentAspect > Plugin.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DynamicResolution), nameof(DynamicResolution.Awake))]
    [HarmonyPatch(typeof(DynamicResolution), nameof(DynamicResolution.Start))]
    public static void DynamicResolution_Start(DynamicResolution __instance)
    {
        __instance.enabled = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraScaler), nameof(CameraScaler.UpdateCameraRect))]
    [HarmonyPatch(typeof(CameraScaler), nameof(CameraScaler.UpdateCameraStackRect))]
    public static void CameraScaler_UpdateCameraRect(CameraScaler __instance)
    {
        var camera = __instance.GetComponent<Camera>();
        if (camera)
        {
            camera.aspect = Resolutions.CurrentAspect;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, Resolutions.SelectedResolution.width, Resolutions.SelectedResolution.height);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraScaler), nameof(CameraScaler.UpdateCameraStackRect))]
    public static void CameraScaler_UpdateCameraStackRect(CameraScaler __instance, ref Rect newRect)
    {
        newRect = new Rect(0, 0, 1, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraScaler), nameof(CameraScaler.OnEnable))]
    public static void CameraScaler_OnEnable(CameraScaler __instance)
    {
        var camera = __instance.GetComponent<Camera>();
        if (camera)
        {
            camera.gateFit = Plugin.CurrentAspect > Plugin.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsSettings), nameof(GraphicsSettings.ApplySettings))]
    [HarmonyPatch(typeof(GraphicsSettings), nameof(GraphicsSettings.SetPostProcessAAOnCameras))]
    public static void GraphicsSettings_ApplySettings()
    {
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldMapHub), nameof(WorldMapHub.Start))]
    [HarmonyPatch(typeof(WorldMapHub), nameof(WorldMapHub.ShowUI), [])]
    [HarmonyPatch(typeof(WorldMapHub), nameof(WorldMapHub.ShowUI), typeof(EWorldMapLayer))]
    public static void WorldMapHub_Start(WorldMapHub __instance)
    {
        if (__instance && __instance.transform)
        {
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "PurposeInfoCanvas", Size.ConfigBased);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuHub), nameof(MainMenuHub.OnEnable))]
    [HarmonyPatch(typeof(MainMenuHub), nameof(MainMenuHub.Initialize))]
    public static void MainMenuHub_OnEnable(WorldMapHub __instance)
    {
        if (__instance && __instance.transform)
        {
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "Canvas_Back", Size.ConfigBased);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleMenuController), nameof(TitleMenuController.Initialize))]
    public static void TitleMenuController_Initialize(TitleMenuController __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ConfigBased);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TopBottomFrameUI), nameof(TopBottomFrameUI.Awake))]
    public static void TopBottomFrameUI_Awake(TopBottomFrameUI __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ForceFullScreen);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadingUI), nameof(LoadingUI.Start))]
    public static void LoadingUI_Start(LoadingUI __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ConfigBased);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveMenuController), nameof(SaveMenuController.Awake))]
    public static void SaveMenuController_Awake(SaveMenuController __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ConfigBased);
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "BlackBoard", Size.ForceFullScreen);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleHUD), nameof(TitleHUD.Start))]
    public static void TitleHUD_Start(TitleHUD __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "Fitter/UIGroup_SettingMenu_ForTitleMenu/UIGroup_Settings_TitleMenuSteam", Size.ConfigBased);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseMenuHub), nameof(PauseMenuHub.OnEnable))]
    public static void PauseMenuHub_OnEnable(PauseMenuHub __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ConfigBased);
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "Fitter/Back", Size.ForceFullScreen);
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "Fitter/Black75", Size.ForceFullScreen);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIPlayHUD), nameof(UIPlayHUD.Start))]
    [HarmonyPatch(typeof(UITutorialPlayerHUD), nameof(UITutorialPlayerHUD.Start))]
    [HarmonyPatch(typeof(UITutorialPlayerHUD), nameof(UITutorialPlayerHUD.Start))]
    public static void UIPlayHUD_Start(MonoBehaviour __instance)
    {
        if (__instance.transform)
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ConfigBased);
        }

        Plugin.UpdateAll();
    }

    private static void AddLayoutElementAndContentSizeFitterRoot(Transform transform, Size size)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
        lc.Size = size;

        lc.UpdateAspect();
    }

    private static void AddLayoutElementAndContentSizeFitterPath(Transform transform, string findPath, Size size)
    {
        var found = transform.Find(findPath);

        if (!found) return;

        AddLayoutElementAndContentSizeFitterRoot(found, size);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("BepInExConfigManager", StringComparison.OrdinalIgnoreCase))
        {
            __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            return;
        }

        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WakeUpScript), nameof(WakeUpScript.Start))]
    public static void CameraScaler_GetMaxAspectRatio(WakeUpScript __instance)
    {
        foreach (var logo in __instance.m_Logos)
        {
            logo.m_LogoShowDuration = 0;
            logo.m_LogoFadeInDuration = 0;
            logo.m_LogoFadeOutDuration = 0;
        }

        __instance.m_LogoDelay = 0;
        __instance.m_FadeInDuration = 0;
        __instance.m_FadeOutDuration = 0;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraScaler), "get_c_MaxAspectRatio")]
    [HarmonyPatch(typeof(ScreenManager), "get_MaxAspectRatio")]
    public static void ScreenManager_GetMaxAspectRatio(ref float __result)
    {
        var aspect = DeviceScreen.mainWindowDisplayInfo.width / (float)DeviceScreen.mainWindowDisplayInfo.height;
        __result = aspect + 1f;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScreenManager), nameof(ScreenManager.FixAspectRatio))]
    public static void ScreenManager_FixAspectRatio(ref bool enabled)
    {
        enabled = false;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenManager), nameof(ScreenManager.IsAvailableAspectRatio))]
    [HarmonyPatch(typeof(ScreenFitter), nameof(ScreenFitter.IsAspectModeValid))]
    public static void ScreenManager_IsAvailableAspectRatio(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenManager), nameof(ScreenManager.Initialize))]
    [HarmonyPatch(typeof(ScreenManager), nameof(ScreenManager.OnUpdate))]
    public static void ScreenManager_Initialize(ScreenManager __instance)
    {
        ScreenManager.FixedAspectRatio = false;
        __instance.m_FixedAspectRatio = false;
    }

    internal enum Size
    {
        ConfigBased,
        ForceFullScreen,
        ForceSixteenNine
    }
}