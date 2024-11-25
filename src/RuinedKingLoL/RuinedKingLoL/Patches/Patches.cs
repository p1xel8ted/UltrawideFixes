namespace RuinedKingLoL.Patches;

[Harmony]
public static class Patches
{
    public class AspectEnforcer : MonoBehaviour
    {
        private CameraResRetarget _cameraResRetarget;

        private void Awake()
        {
            _cameraResRetarget = gameObject.GetComponent<CameraResRetarget>();
        }

        private void OnEnable()
        {
            _cameraResRetarget = gameObject.GetComponent<CameraResRetarget>();
        }

        private void LateUpdate()
        {
            if (_cameraResRetarget)
            {
                if (_cameraResRetarget.bCameraResRetargetEnabled)
                {
                    _cameraResRetarget.selfCamera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
                }
            }
        }
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

    private static float GetPreferredAspect()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => Plugin.MainAspect,
            _ => Plugin.MainAspect
        };
        return width;
    }

    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
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