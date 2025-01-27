using Doozy.Runtime.UIManager.Containers;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace RoguePrinceOfPersia;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";
    private const string Raycast = "raycast";
    internal static bool VolumeUpdateRequired;

    private static readonly List<GameObject> CleanMenuItems = [];

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];
    internal static CanvasScaler ConfigCanvasScaler { get; private set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.Update))]
    private static void Volume_Update_Vignette(Volume __instance)
    {
        var ap = __instance.profile;
        if (ap.TryGet(out Vignette vignetteComponent))
        {
            vignetteComponent.active = Plugin.Vignette.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.Update))]
    private static void Volume_Update(Volume __instance)
    {
        if (!VolumeUpdateRequired) return;
        VolumeUpdateRequired = false;

        var ap = __instance.profile;

        if (ap.TryGet(out Bloom bloomComponent))
        {
            bloomComponent.active = Plugin.Bloom.Value;
        }

        if (ap.TryGet(out FilmGrain filmGrainComponent))
        {
            filmGrainComponent.active = Plugin.FilmGrain.Value;
        }

        if (ap.TryGet(out ChromaticAberration chromaticAberrationComponent))
        {
            chromaticAberrationComponent.active = Plugin.ChromaticAberration.Value;
        }

        if (ap.TryGet(out DepthOfField depthOfFieldComponent))
        {
            depthOfFieldComponent.active = Plugin.DepthOfField.Value;
            depthOfFieldComponent.aperture.value = Plugin.DepthOfFieldAperture.Value;
            depthOfFieldComponent.focusDistance.value = Plugin.DepthOfFieldFocusDistance.Value;
            depthOfFieldComponent.highQualitySampling.value = true;
        }

        if (ap.TryGet(out ColorAdjustments colorAdjustmentsComponent))
        {
            colorAdjustmentsComponent.active = Plugin.ColorAdjustments.Value;
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ConfirmationPopup), nameof(ConfirmationPopup.Show))]
    private static void ConfirmationPopup_Show(ConfirmationPopup __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BackgroundBlurred), nameof(BackgroundBlurred.OnEnable))]
    private static void BackgroundBlurred_OnEnable(BackgroundBlurred __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveSlotsViewUI), nameof(SaveSlotsViewUI.OnEnable))]
    private static void SaveSlotsViewUI_OnEnable(SaveSlotsViewUI __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ImageColorTarget), nameof(ImageColorTarget.SetColor))]
    private static void ImageColorTarget_SetColor(ImageColorTarget __instance, Color value)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlayableDirector), nameof(PlayableDirector.Play), [])]
    private static void PlayableDirector_Play(PlayableDirector __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, false);
        
        var videoPlayerRawImage = __instance.transform.FindChild("Canvas/VideoPanel");
        if (videoPlayerRawImage)
        {
            LayoutController.AddLayoutControllerRoot(videoPlayerRawImage.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        }
        
        var ee =  __instance.transform.FindChild("Canvas/EE");
        if (ee)
        {
            LayoutController.AddLayoutControllerRoot(ee.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        }
        
        var ubiLogo =  __instance.transform.FindChild("Canvas/Ubisoft");
        if (ubiLogo)
        {
            LayoutController.AddLayoutControllerRoot(ubiLogo.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        }
        
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseStackController), nameof(PauseStackController.Pause))]
    private static void PauseStackController_Pause(PauseStackController __instance)
    {
        var pauseView = __instance.transform.FindChild("Pause View");
        if (pauseView)
        {
            LayoutController.AddLayoutControllerRoot(pauseView, LayoutController.LayoutSize.ForceSixteenNine, 0, true);    
        }
       
    }

    internal static void UpdateCleanMenu()
    {
        foreach (var go in CleanMenuItems.Where(go => go))
        {
            go.SetActive(!Plugin.CleanMenu.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BuildInfoWatermark), nameof(BuildInfoWatermark.Start))]
    private static void BuildInfoWatermark_Start(BuildInfoWatermark __instance)
    {
        CleanMenuItems.Add(__instance.gameObject);
        UpdateCleanMenu();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIBehaviourHandler), nameof(UIBehaviourHandler.OnEnable))]
    private static void UIBehaviourHandler_OnEnable(UIBehaviourHandler __instance)
    {
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForgeMenuController), nameof(ForgeMenuController.Start))]
    private static void ForgeMenuController_Start(ForgeMenuController __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);    
    }

    internal static void ProcessScaler(CanvasScaler scaler)
    {
        if (scaler.name.Contains("sinai", StringComparison.OrdinalIgnoreCase) && !scaler.name.Contains("BepInExConfigManager", StringComparison.OrdinalIgnoreCase)) return;

        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        if (scaler.name.Contains("BepInExConfigManager", StringComparison.OrdinalIgnoreCase))
        {
            ConfigCanvasScaler = scaler;
            scaler.uiScaleMode = Plugin.CurrentAspect >= 3.7f ? CanvasScaler.ScaleMode.ScaleWithScreenSize : CanvasScaler.ScaleMode.ConstantPixelSize;
        }

        scaler.screenMatchMode = Plugin.MainAspectRatio > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CutsceneDirector), nameof(CutsceneDirector.Init))]
    private static void CutsceneDirector_Init(CutsceneDirector __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NarratorDialogueView), nameof(NarratorDialogueView.Awake))]
    private static void NarratorDialogueView_Awake(NarratorDialogueView __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }

    internal static void UpdateCanvasScalers()
    {
        var scalers = Scalers;
        foreach (var scaler in scalers.Where(scaler => scaler))
        {
            ProcessScaler(scaler);
        }
    }
}