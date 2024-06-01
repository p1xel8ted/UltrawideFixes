namespace RoguePrinceOfPersia;

[Harmony]
public static class Patches
{
    internal static bool VolumeUpdateRequired;
    private const string Sinai = "sinai";
    private const string Raycast = "raycast";

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

    private static float GetNewScale(float reference)
    {
        var scale = 1f / (reference / Plugin.MainHeight);
        return scale;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        UpdateScaler(__instance);
    }

    private static void UpdateScaler(CanvasScaler scaler)
    {
        if (scaler.name.Contains(Sinai, StringComparison.OrdinalIgnoreCase)) return;
        if (scaler.name.Contains(Raycast, StringComparison.OrdinalIgnoreCase)) return;
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        var newScale = GetNewScale(scaler.referenceResolution.y);
        var pctFactor = Plugin.ScaleAdjustment.Value / 100f;
        var adjustedScale = newScale + newScale * pctFactor;
        scaler.scaleFactor = adjustedScale;
    }

    internal static void UpdateScalers()
    {
        foreach (var scaler in Utils.FindIl2CppType<CanvasScaler>())
        {
            UpdateScaler(scaler);
        }
    }
}