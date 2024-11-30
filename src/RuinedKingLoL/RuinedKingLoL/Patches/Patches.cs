namespace RuinedKingLoL.Patches;

[Harmony]
public static class Patches
{
    private static readonly string[] ScaleTheseBackground = ["backgroundElements", "statBGDark", "statBGDark (1)", "statBGDark (2)"];
    private static DungeonPlayer _dungeonPlayer;
    private static readonly string[] SkippableScenes = ["Video/cinematic_cg_intro.mp4"];

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
        if(SkippableScenes.Contains(path) && Plugin.SkipIntroCinematic.Value)
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


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AirshipButton), nameof(AirshipButton.OnLeftClick))]
    public static void AirshipButton_OnLeftClick(AirshipButton __instance)
    {
        if (__instance.name == "clickableInputPrompt_LeftAligned")
        {
            var path = __instance.gameObject.GetPath();
            if (path.Contains("UI_Casper_CharacterScreen") || path.Contains("UI_Casper_Crafting"))
            {
                Plugin.DisablePillarboxes();
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PageNavigationController), nameof(PageNavigationController.SetPage))]
    public static void PageNavigationController_SetPage(int newPageIndex)
    {
        if (SceneManager.GetActiveScene().name.Contains("MainMenu")) return;

        if (newPageIndex == -1)
        {
            Plugin.DisablePillarboxes();
        }
        else
        {
            Plugin.EnablePillarboxes();
        }
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