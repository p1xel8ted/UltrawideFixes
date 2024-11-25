namespace RuinedKingLoL.Patches;

[Harmony]
public static class Patches
{
    
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

        if(Plugin.ConfigPlatform.Value is Misc.PlatformHelper.Platform.Xbox)
        {
            __instance.transform.localScale = Vector3.one;
            return;
        }

        // Get the appropriate sprite based on the current platform
        var replacementSprite = Misc.PlatformHelper.GetPlatformSprite(value.name);

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