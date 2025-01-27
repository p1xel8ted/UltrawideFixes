namespace TheHouseOfTheDeadRemake.Patches;

[Harmony]
public static class Patches
{
    
    /// <summary>
    /// Forces the white chapter title screens to be 16:9, otherwise they are stretched.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_DisableImageAfterVideo), nameof(HD_DisableImageAfterVideo.Awake))]
    public static void HD_DisableImageAfterVideo_Awake(HD_DisableImageAfterVideo __instance)
    {
        if (__instance.name == "canvas_ChapterTitleVideo")
        {
            //main screen
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);

            //restores the opaque background to full screen
            LayoutController.AddLayoutControllerPath(__instance.transform, "img_ChapterTitleBackground", LayoutController.LayoutSize.ForceFullScreen, 0, true);
        }
    }

    /// <summary>
    /// Overrides the resolution and full screen mode settings to use the selected resolution and full screen mode.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HD_QualitySettingsHandler), nameof(HD_QualitySettingsHandler.ChangeCurrentResolution))]
    public static void HD_QualitySettingsHandler_ChangeCurrentResolution(ref int _width, ref int _height, ref FullScreenMode _mode)
    {
        _width = Resolutions.SelectedResolution.width;
        _height = Resolutions.SelectedResolution.height;
        _mode = Plugin.FullScreenModeConfig.Value;
    }

    /// <summary>
    /// Overrides the resolution and full screen mode settings to use the selected resolution and full screen mode.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HD_QualitySettingsHandler), nameof(HD_QualitySettingsHandler.ChangeFullScreenMode))]
    public static void HD_QualitySettingsHandler_ChangeFullScreenMode(ref FullScreenMode _mode)
    {
        _mode = Plugin.FullScreenModeConfig.Value;
    }

    /// <summary>
    /// Forces the loading screens to be 16:9, otherwise they are stretched.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_CanvasGroupController), nameof(MP_CanvasGroupController.Awake))]
    public static void MP_CanvasGroupController_Awake(MP_CanvasGroupController __instance)
    {
        if (__instance.name == "grp_LoadingScreen")
        {
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        }

        var grad = __instance.transform.Find("grp_Gradient");
        if (grad)
        {
            grad.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Forces the loading screens to be 16:9, otherwise they are stretched.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_LevelLoader), nameof(MP_LevelLoader.Awake))]
    public static void MP_LevelLoader_Awake(MP_LevelLoader __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, false);
    }

    /// <summary>
    /// Corrects gate-fit mode based on the aspect ratio of the current resolution.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HD_PlayerCamera), nameof(HD_PlayerCamera.init))]
    [HarmonyPatch(typeof(HD_PlayerCamera), nameof(HD_PlayerCamera.Awake))]
    public static void HD_PlayerCamera_Awake(HD_PlayerCamera __instance)
    {
        if (__instance.MainCamera)
        {
            __instance.MainCamera.gateFit = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }

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

    /// <summary>
    /// Corrects gate-fit mode based on the aspect ratio of the current resolution.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_CutsceneCamera), nameof(HD_CutsceneCamera.OnEnable))]
    [HarmonyPatch(typeof(HD_CutsceneCamera), nameof(HD_CutsceneCamera.togglePlayerCamera))]
    public static void HD_PlayerCamera_OnEnable(HD_CutsceneCamera __instance)
    {
        if (__instance.Camera)
        {
            __instance.Camera.gateFit = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }

        if (__instance.playerCam)
        {
            __instance.playerCam.gateFit =  Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }

    /// <summary>
    /// Configures the tips (accept,back,press any key) based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_HintsManager), nameof(MP_HintsManager.Awake))]
    [HarmonyPatch(typeof(MP_HintsManager), nameof(MP_HintsManager.onHintStateUpdate))]
    public static void MP_HintsManager_Awake(MP_HintsManager __instance)
    {
        var lc = LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBasedWithOffset, 0, false);
        HudLayout.HudControllers.Add(lc);
    }
    
    /// <summary>
    /// Configures the character selection screen (modern mode) based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_CharacterSelectionMenu), nameof(HD_CharacterSelectionMenu.OnEnable))]
    public static void HD_CharacterSelectionMenu_OnEnable(HD_CharacterSelectionMenu __instance)
    {
        var hudLc = LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
        HudLayout.HudControllers.Add(hudLc);
    }

    /// <summary>
    /// Configures the death screen based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_DeathScreenManager), nameof(HD_DeathScreenManager.Awake))]
    [HarmonyPatch(typeof(HD_DeathScreenManager), nameof(HD_DeathScreenManager.OnEnable))]
    public static void HD_DeathScreenManager_OnEnable(HD_DeathScreenManager __instance)
    {
        //death/continue screen
        var hudLc = LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
        HudLayout.HudControllers.Add(hudLc);
        
        //blood overlay
        var lc = LayoutController.AddLayoutControllerPath(__instance.transform, "group_Backgrounds", Plugin.ExpandBloodOverlay.Value ? LayoutController.LayoutSize.ForceFullScreen : LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        HudLayout.BloodOverlays.Add(lc);
    }
    

    /// <summary>
    /// Stores the original level fov's for later reference, and then adjusts player camera fov based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_PlayerCamera), nameof(HD_PlayerCamera.init))]
    public static void HD_PlayerCamera_init(HD_PlayerCamera __instance)
    {
        FoV.OriginalFieldOfViewPerLevel.Value = HD_Data.CAMERA_FOV_PER_LEVEL;

        var pct = Plugin.FieldOfView.Value / 100; // e.g., 0.5 for +50%, -0.5 for -50%
        __instance.startingFOV += __instance.startingFOV * pct; // Add or subtract percentage change
        __instance.VirtualCamera.m_Lens.FieldOfView = __instance.startingFOV;
        __instance.AnimationCamera.m_Lens.FieldOfView = __instance.startingFOV;

        FoV.UpdateFieldOfViewData(__instance.startingFOV);
    }
    

    /// <summary>
    /// Remove logos from main menu
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_CopyCanvasGroupOptions), nameof(HD_CopyCanvasGroupOptions.Awake))]
    public static void HD_CopyCanvasGroupOptions_Awake(HD_CopyCanvasGroupOptions __instance)
    {
        if (__instance.name == "canvas_Logos")
        {
            __instance.gameObject.SetActive(false);
        }
    }
    
    /// <summary>
    /// Stops the cinematic bars from being displayed.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(HD_CutsceneUI), nameof(HD_CutsceneUI.slidePanels))]
    public static void HD_CutsceneUI_slidePanels(ref bool _visible)
    {
        _visible = false;
    }

    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.name.Replace("(Clone)", "");
            var configEntryGlobal = Plugin.ConfigFile.Bind("06. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes.StartOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { Volumes.UpdateVolumes(); };
            if (Volumes.ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 5, Color.white);
            }
        }
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateVolumes();
    }


    /// <summary>
    /// Configures the main in-game player HUD based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_HUDScaler), nameof(HD_HUDScaler.Awake))]
    [HarmonyPatch(typeof(HD_HUDScaler), nameof(HD_HUDScaler.OnEnable))]
    public static void HD_HUDScaler_OnEnable(HD_HUDScaler __instance)
    {
        var hud = __instance.transform.Find("canvas_HUD");
        if (hud)
        {
            var lc = LayoutController.AddLayoutControllerRoot(hud, LayoutController.LayoutSize.ConfigBased, 0, true);
            HudLayout.HudControllers.Add(lc);
        }
    }


    /// <summary>
    /// Corrects the size of the hints group (press any key to continue, esc to go back etc) so they aren't cutoff
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_AspectRatioSetter), nameof(MP_AspectRatioSetter.SetRatio))]
    [HarmonyPatch(typeof(MP_AspectRatioSetter), nameof(MP_AspectRatioSetter.SetChildAspectRatio))]
    public static void MP_AspectRatioSetter_MatchParentAspectRatio(MP_AspectRatioSetter __instance)
    {
        if (__instance.name == "group_Hints")
        {
            __instance.aspectRatioFitter.aspectRatio = 1f;
        }
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(MP_DistanceCulling), nameof(MP_DistanceCulling.Cull))]
    // public static bool MP_DistanceCulling_Cull()
    // {
    //     return false;
    // }


    /// <summary>
    /// Configures main player camera based on user preferences after the game has set it up
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_PrepareCameraForURP), nameof(MP_PrepareCameraForURP.setupCamera))]
    public static void MP_PrepareCameraForURP_Start(Camera _cam)
    {
        if (_cam.name == "cam_MainCamera")
        {
            var data = _cam.GetComponent<HDAdditionalCameraData>();
            if (data)
            {
                Cameras.HdAdditionalCameraDataInstance = data;
                Cameras.UpdatePostProcessingAA();
            }
        }
    }

    /// <summary>
    /// Corrects the size of the hints group (press any key to continue, esc to go back etc) so they aren't cutoff
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_AspectRatioFitter), nameof(MP_AspectRatioFitter.MatchParentAspectRatio))]
    public static void MP_AspectRatioFitter_MatchParentAspectRatio(MP_AspectRatioFitter __instance)
    {
        if (__instance.name == "group_Hints")
        {
            __instance.aspectRatio = 1f;
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_GalleryManager), nameof(HD_GalleryManager.Start))]
    public static void HD_GalleryManager_OnEnable(HD_GalleryManager __instance)
    {
        var lc = LayoutController.AddLayoutControllerPath(__instance.transform, "canvas_MainCanvas", LayoutController.LayoutSize.ConfigBased, 0, false);
        HudLayout.HudControllers.Add(lc);
    }

    /// <summary>
    /// Forces level selection menu to 16:9, and configures the blood overlay accordingly.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_LevelSelectionMenu), nameof(HD_LevelSelectionMenu.Awake))]
    [HarmonyPatch(typeof(HD_LevelSelectionMenu), nameof(HD_LevelSelectionMenu.OnEnable))]
    public static void HD_LevelSelectionMenu_OnEnable(HD_LevelSelectionMenu __instance)
    {
        //the main level selection screen
        var hudLc = LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
        HudLayout.HudControllers.Add(hudLc);
        
        //the blood overlay
        var lc = LayoutController.AddLayoutControllerPath(__instance.transform, "img_BloodBackground", Plugin.ExpandBloodOverlay.Value ? LayoutController.LayoutSize.ForceFullScreen : LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        HudLayout.BloodOverlays.Add(lc);
    }

    /// <summary>
    /// Configures the main menu blood overlay based on the users preferences and stores a reference for later updating
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_MainMenuBloodOverlayController), nameof(HD_MainMenuBloodOverlayController.Awake))]
    [HarmonyPatch(typeof(HD_MainMenuBloodOverlayController), nameof(HD_MainMenuBloodOverlayController.Start))]
    public static void HD_MainMenuBloodOverlayController_Awake(HD_MainMenuBloodOverlayController __instance)
    {
        var lc = LayoutController.AddLayoutControllerRoot(__instance.transform, Plugin.ExpandBloodOverlay.Value ? LayoutController.LayoutSize.ForceFullScreen : LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        HudLayout.BloodOverlays.Add(lc);
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

        //fixes the end credits video being scaled strangely, allowing to be corrected to 16:9
        if (__instance.name == "canvas_EndingRender")
        {
            __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            __instance.scaleFactor = 0;
        }

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    /// <summary>
    /// Forces the end credits to be 16:9
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_CreditsManager), nameof(HD_CreditsManager.OnEnable))]
    public static void HD_CreditsManager_Play(HD_CreditsManager __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, false);
    }

    /// <summary>
    /// Redirects the ending video to the selected ending based on the users preferences instead of score-based
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_EndingManager), nameof(HD_EndingManager.pickEnding))]
    public static void HD_EndingManager_pickEnding(HD_EndingManager __instance, ref HD_EndingManager.EndingVideo __result)
    {
        if (Plugin.EndingToShow.Value != Plugin.ModdedGameEnding.Disabled)
        {
            __result = Plugin.EndingToShow.Value switch
            {
                Plugin.ModdedGameEnding.NormalEnding => __instance.neutralEnding,
                Plugin.ModdedGameEnding.GoodEnding => __instance.goodEnding,
                Plugin.ModdedGameEnding.BadEnding => __instance.badEnding,
                _ => __result
            };
        }
    }

    /// <summary>
    /// Corrects the aspect of the end credits video to 16:9
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_EndingManager), nameof(HD_EndingManager.ShowEnding))]
    [HarmonyPatch(typeof(HD_EndingManager), nameof(HD_EndingManager.Start))]
    public static void HD_EndingManager_ShowEnding(HD_EndingManager __instance)
    {
        //doesnt have an effect when video players use RenderTextures, but it's here just in-case
        __instance.endingPlayer.player.aspectRatio = VideoAspectRatio.FitVertically;
        
        //video player outputs to a RawImage, which is then scaled to 16:9
        var rawImage = __instance.transform.Find("canvas_EndingRender/rawimg_EndingRender");
        LayoutController.AddLayoutControllerRoot(rawImage, LayoutController.LayoutSize.ForceSixteenNine, 0, true);

        //stored for later updating in-case the user changes their resolution
        Videos.CreditsVideoPlayers.Add(__instance.endingPlayer);
    }

    /// <summary>
    /// Forces VideoPlayer to fit vertically, and scales the raw image accordingly so that the video is maintained to 16:9 and not cut-off.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.Play))]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.PlayClip))]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.OnEnable))]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.showVideoImage))]
    public static void MP_VideoPlayerController_Play(MP_VideoPlayerController __instance)
    {
        if (__instance.videoPlayer)
        {
            Videos.UpdatePlayer(__instance);

            Videos.VideoPlayers.Add(__instance);
        }
    }
}