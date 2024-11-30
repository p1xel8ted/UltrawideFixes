namespace RuinedKingLoL.Patches;

[Harmony]
public static class Patches
{
    private static readonly string[] ScaleTheseBackground = ["backgroundElements", "statBGDark", "statBGDark (1)", "statBGDark (2)"];
    private static DungeonPlayer _dungeonPlayer;
    private static readonly string[] SkippableScenes = ["Video/cinematic_cg_intro.mp4"];
    private static readonly Dictionary<string, float> OriginalFoV = new();

    internal static DungeonPlayer DungeonPlayer
    {
        get
        {
            if (!_dungeonPlayer)
            {
                _dungeonPlayer = Object.FindObjectOfType<DungeonPlayer>();
            }

            return _dungeonPlayer;
        }
        private set => _dungeonPlayer = value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonCombatUI), nameof(DungeonCombatUI.OnEnable))]
    public static void DungeonCombatUI_OnEnable(DungeonCombatUI __instance)
    {
        var vig = __instance.transform.FindChild("Vignette");
        if (vig)
        {
            Object.Destroy(vig.gameObject);
        }

        __instance.SetVisibility(!Plugin.HideHudOnStartup.Value);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonCombatUI), nameof(DungeonCombatUI.Update))]
    public static void DungeonCombatUI_Update(DungeonCombatUI __instance)
    {
        if (Input.GetKeyUp(Plugin.HudToggleKeybind.Value))
        {
            __instance.SetVisibility(!__instance.isShown);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InitialLoadingScreen), nameof(InitialLoadingScreen.Update))]
    public static void InitialLoadingScreen_Start(InitialLoadingScreen __instance)
    {
        Plugin.DisablePillarboxes();

        if (__instance.timer.elapsedSeconds > 6f)
        {
            Plugin.EnablePillarboxes();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.DoVisualTransition))]
    public static void MainMenu_DoVisualTransition(ref MainMenu.MainMenuState previousState)
    {
        Plugin.EnablePillarboxes();

        if (previousState == MainMenu.MainMenuState.Exiting)
        {
            Plugin.DisablePillarboxes();
        }
    }

    internal static void UpdateDungeonCamera()
    {
        var dungeonCamera = Resources.FindObjectsOfTypeAll<DungeonCamera>();
        foreach (var dc in dungeonCamera)
        {
            if (dc && dc.selfCamera)
            {
                UpdateDungeonCamera(dc);
            }
        }
    }

    private static void UpdateDungeonCamera(DungeonCamera dc)
    {
        if (!dc.selfCamera) return;

        var path = dc.gameObject.GetPath();
        if (!OriginalFoV.TryGetValue(path, out var originalFoV))
        {
            OriginalFoV.Add(path, dc.selfCamera.fieldOfView);
            originalFoV = dc.selfCamera.fieldOfView;
        }

        var newFov = originalFoV * Plugin.FieldOfViewMultiplier.Value;
        dc.selfCamera.fieldOfView = newFov;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        var caFound = __instance.profile.TryGet(out ChromaticAberration chromaticAberration);
        if (caFound)
        {
            chromaticAberration.active = Plugin.ChromaticAberration.Value;
        }

        var vigFound = __instance.profile.TryGet(out Vignette vignette);
        if (vigFound)
        {
            vignette.active = Plugin.Vignette.Value;
        }

        var dofFound = __instance.profile.TryGet(out DepthOfField depthOfField);
        if (dofFound)
        {
            depthOfField.active = Plugin.DepthOfField.Value;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonCamera), nameof(DungeonCamera.OnEnable))]
    public static void DungeonCamera_OnEnable(DungeonCamera __instance)
    {
        UpdateDungeonCamera(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FishingUI), nameof(FishingUI.Show))]
    [HarmonyPatch(typeof(FishingUI), nameof(FishingUI.OnEnable))]
    public static void FishingUI_OnEnable(FishingUI __instance)
    {
        Plugin.DisablePillarboxes();
        var details = __instance.transform.FindChild("Canvas/BGDetails (2)");
        if (details)
        {
            details.gameObject.SetActive(false);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Image), "set_sprite")]
    private static void Image_SetSprite(Image __instance, ref Sprite value)
    {
        if (!value) return;

        if (!value.name.StartsWith("UI_Input_Xbox"))
        {
            // Handle PC input icons (do not replace)
            if (value.name.StartsWith("UI_Input_PC"))
            {
                //restore to original scale
                __instance.transform.localScale = Vector3.one;
                return;
            }

            return;
        }

        if (Plugin.ConfigPlatform.Value is PlatformHelper.Platform.Xbox)
        {
            __instance.transform.localScale = Vector3.one;
            return;
        }

        // Get the appropriate sprite based on the current platform
        var replacementSprite = PlatformHelper.GetPlatformSprite(value.name);

        if (replacementSprite)
        {
            // Replace the sprite and reset the scale
            Plugin.Logger.LogInfo($"Replacing {value.name} with {replacementSprite.name}");
            value = replacementSprite;
            __instance.transform.localScale = new Vector3(0.6f, 0.6f, 1); // Scale down to match UI
        }
        else
        {
            // Default to original Xbox sprite if no replacement is found
            __instance.transform.localScale = Vector3.one;
            Plugin.Logger.LogWarning($"No replacement found for {value.name}, using default Xbox sprite.");
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(StoryPopupManager), nameof(StoryPopupManager.Awake))]
    [HarmonyPatch(typeof(StoryPopupManager), nameof(StoryPopupManager.Proceed))]
    [HarmonyPatch(typeof(StoryPopupManager), nameof(StoryPopupManager.ShowNPCRoom))]
    public static void StoryPopupManager_Awake(StoryPopupManager __instance)
    {
        if (__instance.darkBG)
        {
            __instance.darkBG.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoOptionsMenu), nameof(VideoOptionsMenu.ConfirmChanges))]
    [HarmonyPatch(typeof(VideoOptionsMenu), nameof(VideoOptionsMenu.ApplyChanges))]
    public static void VideoOptionsMenu_ConfirmChanges()
    {
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_OnEnable(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraResRetarget), nameof(CameraResRetarget.OnEnable))]
    public static void CameraResRetarget_OnEnable(CameraResRetarget __instance)
    {
        __instance.selfCamera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
        __instance.gameObject.TryAddComponent<AspectEnforcer>();
        __instance.m_targetRes = new Vector2(Plugin.MainWidth * 2, Plugin.MainHeight * 2);
        __instance.bCameraResRetargetEnabled = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LogoMovieSequence), nameof(LogoMovieSequence.Run))]
    public static void LogoMovieSequence_Run(LogoMovieSequence __instance)
    {
        __instance.m_skippable = true;
        __instance.logoVideoFilepaths.Clear();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MoviePlayer), nameof(MoviePlayer.Play))]
    public static void MoviePlayer_OnEnable(MoviePlayer __instance)
    {
        __instance.m_instantSkip = true;
        __instance.m_skippable = true;

        Plugin.Logger.LogInfo($"Checking if we should skip '{__instance.m_currentPath}'");

        var path = __instance.m_currentPath;
        if (SkippableScenes.Contains(path) && Plugin.SkipIntroCinematic.Value)
        {
            Plugin.Logger.LogMessage($"Skipping '{path}'");
            __instance.Skip();
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CinematicBars), nameof(CinematicBars.ShowCinematicBars))]
    public static bool CinematicBars_ShowCinematicBars()
    {
        return Plugin.CinematicLetterboxing.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        if (__instance.name == "Canvas_pauseMenuRoot")
        {
            var bg = __instance.transform.FindChild("AirshipTitleSafe/BGDetails");
            if (bg)
            {
                bg.gameObject.SetActive(false);
            }
        }

        foreach (var bg in ScaleTheseBackground)
        {
            var tr = Utils.DeepSearchByName(__instance.transform, bg);
            if (!tr) continue;

            tr.localScale = tr.localScale with { x = Plugin.PositiveScaleFactor };
        }

        if (__instance.name == "Canvas_craftingRoot")
        {
            var bg = __instance.transform.FindChild("backgroundElements");
            if (bg)
            {
                bg.gameObject.TryAddComponent<ScaleForcer>();
            }
        }

        if (__instance.name == "Canvas_mapViewer")
        {
            var bg = __instance.transform.FindChild("UIroot_dungeonMap/BGELements");
            if (bg)
            {
                bg.transform.localScale = bg.transform.localScale with { x = Plugin.PositiveScaleFactor };
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.Update))]
    public static void DungeonPlayer_Update(DungeonPlayer __instance)
    {
        DungeonPlayer = __instance;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.OnEnable))]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.Start))]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.ResetSpeedScaling))]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.OnPartyChanged))]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.ResetFighter))]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.SetFighter))]
    [HarmonyPatch(typeof(DungeonPlayer), nameof(global::DungeonPlayer.SpawnFighter))]
    public static void DungeonPlayer_OnEnable(DungeonPlayer __instance)
    {
        __instance.moveSpeedScaling = Plugin.MoveSpeedMultiplier.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CharacterScreenUI), nameof(CharacterScreenUI.ShowPage))]
    [HarmonyPatch(typeof(CharacterScreenUI), nameof(CharacterScreenUI.Show))]
    [HarmonyPatch(typeof(CraftingUI_Casper), nameof(CraftingUI_Casper.Show))]
    public static void CharacterScreenUI_ShowPage()
    {
        Plugin.EnablePillarboxes();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CharacterScreenUI), nameof(CharacterScreenUI.OnBackPressed))]
    [HarmonyPatch(typeof(CharacterScreenUI), nameof(CharacterScreenUI.OnBackClicked))]
    [HarmonyPatch(typeof(CraftingUI_Casper), nameof(CraftingUI_Casper.CloseMenu))]
    public static void CharacterScreenUI_OnLeftClick()
    {
        Plugin.DisablePillarboxes();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseMenuUI), nameof(PauseMenuUI.OnBackPressed))]
    public static void PauseMenuUI_OnBackPressed()
    {
        Plugin.DisablePillarboxes();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UserGuideUI), nameof(UserGuideUI.ShowPage))]
    [HarmonyPatch(typeof(UserGuideCombatUI), nameof(UserGuideCombatUI.SetPage))]
    [HarmonyPatch(typeof(UserGuideCombatUI), nameof(UserGuideCombatUI.Awake))]
    public static void UserGuideUI_SetPage()
    {
        Plugin.EnablePillarboxes();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UserGuideUI), nameof(UserGuideUI.OnBackPressed))]
    [HarmonyPatch(typeof(UserGuideCombatUI), nameof(UserGuideCombatUI.OnBackPressed))]
    public static void UserGuideUI_OnBackPressed()
    {
        Plugin.DisablePillarboxes();
    }


    internal static void QualitySettings_Postfix()
    {
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures - needed otherwise some UI text is garbage
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable; // Enable anisotropic filtering
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures
        QualitySettings.streamingMipmapsActive = false; // Disable mipmap streaming
        QualitySettings.lodBias = float.MaxValue; // Force highest LOD models
        QualitySettings.maximumLODLevel = 0; // Use highest LOD level
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UniversalRenderPipelineAsset), nameof(UniversalRenderPipelineAsset.CreatePipeline))]
    [HarmonyPatch(typeof(UniversalRenderPipelineAsset), nameof(UniversalRenderPipelineAsset.CreateRenderers))]
    public static void UniversalRenderPipelineAsset_OnEnable(UniversalRenderPipelineAsset __instance)
    {
        QualitySettings_Postfix();
    }
}