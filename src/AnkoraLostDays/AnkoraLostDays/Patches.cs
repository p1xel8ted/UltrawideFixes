namespace AnkoraLostDays;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";
    
    public static void PostProcessingBehaviour_Toggle(PostProcessingBehaviour __instance)
    {
        var ao = __instance.m_AmbientOcclusion;
        var aoModel = ao.GetModel();
        if (aoModel != null)
        {
            aoModel.enabled = Plugin.AmbientOcclusion.Value;
        }

        var eyeAdaptation = __instance.m_EyeAdaptation;
        var eyeAdaptationModel = eyeAdaptation.GetModel();
        if (eyeAdaptationModel != null)
        {
            eyeAdaptationModel.enabled = Plugin.EyeAdaptation.Value;
        }

        var dof = __instance.m_DepthOfField;
        var dofModel = dof.GetModel();
        if (dofModel != null)
        {
            dofModel.enabled = Plugin.DepthOfField.Value;
        }


        var bloom = __instance.m_Bloom;
        var bloomModel = bloom.GetModel();
        if (bloomModel != null)
        {
            bloomModel.enabled = Plugin.Bloom.Value;
        }

        var chromaticAberration = __instance.m_ChromaticAberration;
        var chromaticAberrationModel = chromaticAberration.GetModel();
        if (chromaticAberrationModel != null)
        {
            chromaticAberrationModel.enabled = Plugin.ChromaticAberration.Value;
        }


        var colorGrading = __instance.m_ColorGrading;
        var colorGradingModel = colorGrading.GetModel();
        if (colorGradingModel != null)
        {
            colorGradingModel.enabled = Plugin.ColorGrading.Value;
        }

        var grain = __instance.m_Grain;
        var grainModel = grain.GetModel();
        if (grainModel != null)
        {
            grainModel.enabled = Plugin.Grain.Value;
        }

        var vignette = __instance.m_Vignette;
        var vignetteModel = vignette.GetModel();
        if (vignetteModel != null)
        {
            vignetteModel.enabled = false;
        }

        var fxaa = __instance.m_Fxaa;
        var fxaaModel = fxaa.GetModel();
        if (fxaaModel != null)
        {
            fxaaModel.enabled = true;
            
            var modelSettings = fxaa.model.settings;
            
            modelSettings.taaSettings.sharpen = Plugin.Sharpen.Value;
            modelSettings.fxaaSettings.preset = AntialiasingModel.FxaaPreset.ExtremeQuality;
            
            fxaa.model.settings = modelSettings;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), MethodType.Constructor)]
    [HarmonyPatch(typeof(QualitySettings), MethodType.StaticConstructor)]
    internal static void QualitySettings_Postfix()
    {
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures - needed otherwise some UI text is garbage

        // Anisotropic Filtering
        QualitySettings.anisotropicFiltering = Plugin.AnisotropicFiltering.Value ? AnisotropicFiltering.ForceEnable : AnisotropicFiltering.Disable; // Enable anisotropic filtering

        // // Texture Quality
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures
        QualitySettings.streamingMipmapsActive = false; // Disable mipmap streaming

        // Shadows
        QualitySettings.shadows = ShadowQuality.All;
        QualitySettings.shadowCascades = 4; // Use 4 shadow cascades
        QualitySettings.shadowDistance = 300f; // Max shadow draw distance
        QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
        QualitySettings.shadowProjection = ShadowProjection.CloseFit; // Use close-fit projection
        QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask; // Use distance shadowmask
        QualitySettings.shadowNearPlaneOffset = 0.0f; // Minimize near plane offset
        QualitySettings.shadowCascade4Split = new Vector3(0.05f, 0.15f, 0.3f); // Fine-tune cascade splits

        // LOD Bias
        QualitySettings.lodBias = float.MaxValue; // Force highest LOD models

        // Maximum LOD Level
        QualitySettings.maximumLODLevel = 0; // Use highest LOD level

        // Skin Weights
        QualitySettings.skinWeights = SkinWeights.FourBones; // Use four bone weights per vertex

        // Realtime Reflection Probes
        QualitySettings.realtimeReflectionProbes = true; // Enable real-time reflection probes

        // Soft Particles
        QualitySettings.softParticles = true; // Enable soft particles

        // Soft Vegetation
        QualitySettings.softVegetation = true; // Enable soft vegetation

        // Particle Raycast Budget
        QualitySettings.particleRaycastBudget = 4096; // Increase particle raycast budget

        // VSync Count
        // QualitySettings.vSyncCount = 0; // Disable VSync for maximum frame rate (optional)

        // Billboards Face Camera Position
        QualitySettings.billboardsFaceCameraPosition = true; // Ensure billboards face the camera

        // Shadowmask Mode
        QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask; // High-quality shadowmask
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains(Sinai)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    public static void UpdatePostProcessing()
    {
        QualitySettings_Postfix();
        if (Camera.main)
        {
            PostProcessingBehaviour_Toggle(Camera.main.GetComponent<PostProcessingBehaviour>());
        }
    }
}