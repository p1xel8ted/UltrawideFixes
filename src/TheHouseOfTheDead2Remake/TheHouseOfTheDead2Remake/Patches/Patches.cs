namespace TheHouseOfTheDead2Remake.Patches;

[Harmony]
public static class Patches
{
    /// <summary>
    /// Overrides quality settings set by the game based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int))]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel()
    {
        QualSettings.UpdateSettings();
    }

    /// <summary>
    /// Forces game to apply expensive changes when quality settings are changed    
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel(ref bool applyExpensiveChanges)
    {
        applyExpensiveChanges = true;
    }

    private static readonly Dictionary<int, Camera.GateFitMode> OriginalGateFits = new();

    internal static void UpdateAllCameras()
    {
        var cameras = Camera.allCameras.ToList();
        foreach (var cam in cameras)
        {
            UpdateCamera(cam);
        }
    }

    private static void UpdateCamera(Camera cam)
    {
        if (!cam) return;

        var cameraID = cam.GetInstanceID();
        var gateFit = cam.gateFit;
        if (!OriginalGateFits.TryGetValue(cameraID, out var originalGateFit))
        {
            OriginalGateFits.Add(cameraID, gateFit);
            originalGateFit = gateFit;
        }

        cam.gateFit = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : originalGateFit;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CR_HUD), nameof(CR_HUD.Awake))]
    public static void CR_HUD_Awake(CR_HUD __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false, 1080f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CR_NewGampaignMenu), nameof(CR_NewGampaignMenu.OnEnable))]
    public static void CR_NewCampaignMenu_Awake(CR_NewGampaignMenu __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false, Screen.height);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CR_CharacterSelectionMenu), nameof(CR_CharacterSelectionMenu.OnEnable))]
    public static void CR_CharacterSelectionMenu_Awake(CR_CharacterSelectionMenu __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false, Screen.height);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CR_CreditsManager), nameof(CR_CreditsManager.OnEnable))]
    public static void CR_CreditsManager_Play(CR_CreditsManager __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CR_ChapterSelectionMenu), nameof(CR_ChapterSelectionMenu.OnEnable))]
    public static void CR_ChapterSelectionMenu_Awake(CR_ChapterSelectionMenu __instance)
    {
       //  LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false, Screen.height);
       // // LayoutController.AddLayoutControllerPath(__instance.transform, "parent_Menu", LayoutController.LayoutSize.ConfigBased, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_HDRPVolumeSetter), nameof(MP_HDRPVolumeSetter.initComponents))]
    public static void MP_HDRPVolumeSetter_initComponents(MP_HDRPVolumeSetter __instance)
    {
        Volumes.ProcessVolumeRegistration(__instance.volume);

        __instance.AmbientOcclusion?.SetQuality(ScalableSettingLevelParameter.Level.High);
        __instance.Bloom?.SetQuality(ScalableSettingLevelParameter.Level.High);
        __instance.ContactShadows?.SetQuality(ScalableSettingLevelParameter.Level.High);
        __instance.DepthOfField?.SetQuality(ScalableSettingLevelParameter.Level.High);
        __instance.MotionBlur?.SetQuality(ScalableSettingLevelParameter.Level.High);

        Volumes.UpdateSingleVolume(__instance.volume);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CR_CutsceneUI), nameof(CR_CutsceneUI.makeVisible))]
    [HarmonyPatch(typeof(CR_CutsceneUI), nameof(CR_CutsceneUI.slidePanels))]
    [HarmonyPatch(typeof(HD_CutsceneUI), nameof(HD_CutsceneUI.makeVisible))]
    [HarmonyPatch(typeof(HD_CutsceneUI), nameof(HD_CutsceneUI.slidePanels))]
    public static void CutsceneUI_Patches(MonoBehaviour __instance, ref bool _visible)
    {
        _visible = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CR_VideoPlayer), nameof(CR_VideoPlayer.playVideo))]
    public static void CR_VideoPlayer_playVideo(CR_VideoPlayer __instance, int _id, VideoPlayerPlayMode _mode)
    {
        ToggleBlackVideoBackground(true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CR_LoadingScreen), nameof(CR_LoadingScreen.SetActive))]
    public static void CR_LoadingScreen_SetActive(CR_LoadingScreen __instance, bool _active)
    {
        var arf = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = 16f / 9f;

        // Add a fullscreen black image behind the loading screen
        const string blackBgName = "UltrawideFix_LoadingBackground";
        const string clonedBgName = "UltrawideFix_ClonedBackground";
        var imgBackground = __instance.transform.Find("img_Background");
        var existingBg = imgBackground?.parent?.Find(blackBgName);

        if (!existingBg && _active && imgBackground)
        {
            var parent = imgBackground.parent;

            // Create fullscreen black background
            var blackBackground = new GameObject(blackBgName);
            blackBackground.transform.SetParent(parent, false);
            blackBackground.transform.SetAsFirstSibling(); // Put it behind other elements

            var blackImage = blackBackground.AddComponent<Image>();
            blackImage.color = Color.black;

            var blackRectTransform = blackBackground.GetComponent<RectTransform>();
            blackRectTransform.anchorMin = Vector2.zero;
            blackRectTransform.anchorMax = Vector2.one;
            blackRectTransform.offsetMin = Vector2.zero;
            blackRectTransform.offsetMax = Vector2.zero;
            blackBackground.transform.localScale = new Vector3(4, 4, 1);

            // Clone the original img_Background
            var clonedBackground = Object.Instantiate(imgBackground.gameObject, parent);
            clonedBackground.name = clonedBgName;
            clonedBackground.transform.SetSiblingIndex(blackBackground.transform.GetSiblingIndex() + 1);

            // Disable the original img_Background
            imgBackground.gameObject.SetActive(false);
        }
    }


    static Patches()
    {
#if DEBUG
        Debug.developerConsoleEnabled = true;
        Debug.developerConsoleVisible = true;
        Debug.unityLogger.logEnabled = false;
#endif
        CR_VideoPlayer.OnCinematicFinished += CR_VideoPlayerOnOnCinematicFinished;
        CR_VideoPlayer.OnVideoFinished += CR_VideoPlayerOnOnVideoFinished;
    }

    private static void CR_VideoPlayerOnOnVideoFinished(VideoID id)
    {
        ToggleBlackVideoBackground(false);
    }

    private static void ToggleBlackVideoBackground(bool enable)
    {
        if (CR_VideoPlayer.instance)
        {
            if (CR_VideoPlayer.instance.blackBackgroundGameObject)
            {
                CR_VideoPlayer.instance.blackBackgroundGameObject.SetActive(enable);
            }
        }
    }


    private static void CR_VideoPlayerOnOnCinematicFinished(CinematicID id)
    {
        ToggleBlackVideoBackground(false);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CR_VideoPlayer), nameof(CR_VideoPlayer.createRenderTexture))]
    public static bool CR_VideoPlayer_createRenderTexture(CR_VideoPlayer __instance)
    {
        if (!__instance.playerRenderTexture)
        {
            __instance.playerRenderTexture = new RenderTexture(Screen.width, Screen.height, 32, RenderTextureFormat.ARGB32);
        }

        if (!__instance.playerRenderTexture.IsCreated())
        {
            __instance.playerRenderTexture.Create();
        }

        __instance.playerRenderTexture.Clear();

        return false;
    }

    /// <summary>
    /// Corrects scaling for certain UI components    
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;

        //the post-processing notifications canvas
        if (__instance.name == "MessageCanvas") return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MP_CursorSetterModule), nameof(MP_CursorSetterModule.changeCursorLockMode))]
    public static void MP_CursorSetterModule_MP_CursorSetterModule(ref CursorLockMode _cursorLockMode)
    {
        _cursorLockMode = CursorLockMode.None;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MP_CursorSetterModule), nameof(MP_CursorSetterModule.changeCursorVisibility))]
    public static void MP_CursorSetterModule_MP_changeCursorVisibility(ref bool _shouldBeVisible)
    {
        _shouldBeVisible = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.PushStateToUnityCamera))]
    public static void CinemachineBrain_PushStateToUnityCamera(CinemachineBrain __instance, CameraState state)
    {
        if (__instance.name != "cam_MainCamera") return;
        var outputCamera = __instance.OutputCamera;
        if (outputCamera)
        {
            outputCamera.fieldOfView = Plugin.PlayerFieldOfView.Value > 0f
                ? state.Lens.FieldOfView * Plugin.PlayerFieldOfView.Value
                : state.Lens.FieldOfView;
        }
    }


    /// <summary>
    /// Forces VideoPlayer to fit vertically, and scales the raw image accordingly so that the video is maintained to 16:9 and not cut-off.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MP_VideoPlayableAsset), nameof(MP_VideoPlayableAsset.CreateVideoPlayer))]
    public static void MP_VideoPlayableAsset_CreateVideoPlayer(MP_VideoPlayableAsset __instance)
    {
        __instance.AspectRatio = VideoAspectRatio.FitVertically;
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CR_EndingManager), nameof(CR_EndingManager.GetEnding))]
    public static void CR_EndingManager_GetEnding(CR_EndingManager __instance, ref GameEnding __result)
    {
        if (Plugin.EndingToShow.Value != Plugin.ModdedGameEnding.Disabled)
        {
            __result = Plugin.EndingToShow.Value switch
            {
                Plugin.ModdedGameEnding.NormalEnding => GameEnding.Normal,
                Plugin.ModdedGameEnding.GoodEnding => GameEnding.Good,
                Plugin.ModdedGameEnding.BadEnding => GameEnding.Bad,
                _ => __result
            };
        }
    }
}