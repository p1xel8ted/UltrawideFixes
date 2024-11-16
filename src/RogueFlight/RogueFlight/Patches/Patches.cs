using ShadowQuality = UnityEngine.ShadowQuality;
using ShadowResolution = UnityEngine.ShadowResolution;

namespace RogueFlight.Patches;

[Harmony]
public static class Patches
{
    private static readonly List<AspectRatioFitter> AspectRatioFitters = [];

    private static readonly string[] PillarThese = ["GameMenu/Menu", "GameMenu/LevelComplete", "TitleScreen/Canvas"];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResolutionDialogue), nameof(ResolutionDialogue.Awake))]
    public static void ResolutionDialogue_Awake(ResolutionDialogue __instance)
    {
        var customRes = Plugin.GetCustomRes();

        var newResList = new Il2CppSystem.Collections.Generic.List<Resolution>();
        newResList.Add(customRes);

        __instance.resolutions = (Il2CppStructArray<Resolution>)newResList.ToArray();
        __instance.filteredResolutions = newResList;

        __instance.resolutionDropDown.options.Clear();

        var resDropDown = __instance.resolutionDropDown;
        var resText = $"[{customRes.width}x{customRes.height} {customRes.refreshRate}Hz]";
        var newResOption = new Dropdown.OptionData(resText);
        resDropDown.options.Add(newResOption);

        __instance.currentResolutionIndex = 0;
        __instance.SetResolution(0);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DynamicResolution), nameof(DynamicResolution.Awake))]
    [HarmonyPatch(typeof(DynamicResolution), nameof(DynamicResolution.Start))]
    public static void DynamicResolution_Start(DynamicResolution __instance)
    {
        DynamicResolution.SystemEnabled = GameManager.saveGame.dynamicRes = false;
        DynamicResolution.Disable();
        __instance.enabled = false;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(SetResolutionFirstRun), nameof(SetResolutionFirstRun.Start))]
    public static void SetResolutionFirstRun_Start(SetResolutionFirstRun __instance)
    {
        var res = Plugin.GetCustomRes();
        Screen.SetResolution(res.width, res.height, Plugin.FullScreenModeConfig.Value, Plugin.RefreshRate);
        Plugin.Logger.LogInfo($"Resolution set to {res.width}x{res.height} fullscreen: {Plugin.FullScreenModeConfig.Value} refresh rate: {Plugin.RefreshRate}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnDisable))]
    public static void CanvasScaler_OnDisable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;

        var path = __instance.gameObject.GetPath();
        if (PillarThese.Contains(path))
        {
            Utils.DisablePillarBoxing();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;

        var path = __instance.gameObject.GetPath();
        if (PillarThese.Contains(path))
        {
            Utils.EnablePillarBoxing();
        }

        var referenceResolution = __instance.referenceResolution; //800,600
        var match = __instance.matchWidthOrHeight;

        var customNative = Plugin.GetCustomRes().height * Plugin.NativeAspectRatio; //1440 * 1.777777777777778f = 2560f

        var scaleFactorWidth = customNative / referenceResolution.x; //2560 / 800 = 3.2f  
        var scaleFactorHeight = Plugin.GetCustomRes().width / referenceResolution.y; //3440 / 600 = 5.733333333333333f

        var calculatedScaleFactor = Mathf.Lerp(scaleFactorWidth, scaleFactorHeight, match); //3.2f

        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.scaleFactor = calculatedScaleFactor;

        var hud = __instance.transform.Find("HUD");
        if (!hud) return;

        var arf = AddAspectRatioFitter(hud.gameObject);
        AspectRatioFitters.Add(arf);
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

    internal static void UpdateAspectRatioFitters()
    {
        foreach (var arf in AspectRatioFitters.Where(arf => arf))
        {
            var chosenAspect = GetPreferredAspect();
            arf.aspectRatio = chosenAspect;
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.enabled = true;
        }
    }

    internal static void UpdateVolumes()
    {
        var app = Utils.FindIl2CppType<AdjustPostProcessing>();
        foreach (var ap in app.Where(ap => ap))
        {
            if (ap.b)
            {
                ap.b.active = Plugin.Blur.Value;
            }

            if (ap.c)
            {
                ap.c.active = Plugin.ChromaticAberration.Value;
            }

            if (ap.cs)
            {
                ap.cs.active = Plugin.ColorSplit.Value;
            }

            if (ap.f)
            {
                ap.f.active = Plugin.FilmGrain.Value;
            }

            if (ap.s)
            {
                ap.s.active = Plugin.Sharpen.Value;
            }
        }

        var volumes = Utils.FindIl2CppType<VolumeProfile>();
        foreach (var ap in volumes)
        {
            if (ap.TryGet(out Vignette vignette))
            {
                vignette.active = Plugin.Vignette.Value;
            }

            if (ap.TryGet(out ChromaticAberration chromaticAberration))
            {
                chromaticAberration.active = Plugin.ChromaticAberration.Value;
            }

            if (ap.TryGet(out ColorAdjustments colorAdjustments))
            {
                colorAdjustments.active = Plugin.ColorAdjustments.Value;
            }

            if (ap.TryGet(out Scanlines scanlines))
            {
                scanlines.active = Plugin.Scanlines.Value;
            }

            if (ap.TryGet(out LUT lut))
            {
                lut.active = Plugin.Lut.Value;
            }

            if (ap.TryGet(out Blur blur))
            {
                blur.active = Plugin.Blur.Value;
            }

            if (ap.TryGet(out Overlay overlay))
            {
                overlay.active = Plugin.Overlay.Value;
            }

            if (ap.TryGet(out FilmGrain filmGrain))
            {
                filmGrain.active = Plugin.FilmGrain.Value;
            }

            if (ap.TryGet(out Sharpen sharpen))
            {
                sharpen.active = Plugin.Sharpen.Value;
            }

            if (ap.TryGet(out ColorSplit colorSplit))
            {
                colorSplit.active = Plugin.ColorSplit.Value;
            }

            if (ap.TryGet(out Bloom bloom))
            {
                bloom.active = Plugin.Bloom.Value;
            }

            if (ap.TryGet(out SpeedLines speedLines))
            {
                speedLines.active = Plugin.SpeedLines.Value;
            }

            if (ap.TryGet(out LensDistortion lensDistortion))
            {
                lensDistortion.active = Plugin.LensDistortion.Value;
            }

            ap.isDirty = true;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), MethodType.Constructor)]
    [HarmonyPatch(typeof(QualitySettings), MethodType.StaticConstructor)]
    internal static void QualitySettings_Postfix()
    {
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures - needed otherwise some UI text is garbage

        if (!Plugin.UseCustomQualitySettings.Value)
        {
            return;
        }

        // Anti-Aliasing
        if (Plugin.AntiAliasing.Value != (Plugin.AntialiasingMode)AntialiasingMode.None)
        {
            QualitySettings.antiAliasing = Plugin.MSAA.Value; // 8x MSAA for high-quality anti-aliasing   
        }

        if (Plugin.MSAA.Value <= 0 && Camera.main)
        {
            var cameraData = Camera.main.GetUniversalAdditionalCameraData();
            if (cameraData)
            {
                cameraData.antialiasing = (AntialiasingMode)Plugin.AntiAliasing.Value;
                cameraData.antialiasingQuality = AntialiasingQuality.High;
            }
        }

        // Anisotropic Filtering
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable; // Enable anisotropic filtering

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
    [HarmonyPatch(typeof(UniversalRenderPipelineAsset), nameof(UniversalRenderPipelineAsset.CreatePipeline))]
    [HarmonyPatch(typeof(UniversalRenderPipelineAsset), nameof(UniversalRenderPipelineAsset.CreateRenderers))]
    public static void UniversalRenderPipelineAsset_OnEnable(UniversalRenderPipelineAsset __instance)
    {
        QualitySettings_Postfix();

        if (!Plugin.UseCustomQualitySettings.Value)
        {
            return;
        }

        // Shadows
        __instance.shadowCascadeOption = ShadowCascadesOption.FourCascades; // Use 4 cascades for best quality
        __instance.shadowDistance = 300f; // Max shadow draw distance
        __instance.mainLightShadowmapResolution = 8192; // Max main light shadowmap resolution
        __instance.additionalLightsShadowmapResolution = 4096; // Max additional lights shadowmap resolution
        __instance.supportsSoftShadows = true; // Enable soft shadows
        __instance.supportsAdditionalLightShadows = true; // Enable shadows for additional lights
        __instance.softShadowQuality = SoftShadowQuality.High; // High-quality soft shadows

        // Configure shadow bias
        __instance.shadowDepthBias = 0.5f; // Adjust to reduce shadow acne
        __instance.shadowNormalBias = 0.4f; // Adjust to minimize artifacts

        // Configure shadow cascade splits
        __instance.cascade4Split = new Vector3(0.05f, 0.15f, 0.3f); // Fine-tuned splits for 4-cascade shadows

        // Lighting
        __instance.mainLightRenderingMode = LightRenderingMode.PerPixel; // Per-pixel lighting for main light
        __instance.additionalLightsRenderingMode = LightRenderingMode.PerPixel; // Per-pixel lighting for additional lights
        __instance.maxAdditionalLightsCount = 16; // Increase number of additional lights
        __instance.m_AdditionalLightsPerObjectLimit = 8; // Increase per-object light limit
        __instance.m_MixedLightingSupported = true; // Enable mixed lighting (realtime + baked)

        // Anti-Aliasing
        __instance.msaaSampleCount = Plugin.MSAA.Value; // 8x MSAA for highest quality anti-aliasing

        // Rendering
        __instance.renderScale = Plugin.RenderScale.Value; // Supersampling: 200% render scale for high fidelity

        __instance.supportsDynamicBatching = false; // Disable batching for highest rendering precision
        __instance.supportsCameraDepthTexture = true; // Enable camera depth texture for effects
        __instance.supportsCameraOpaqueTexture = true; // Enable opaque texture for effects
        __instance.m_OpaqueDownsampling = Downsampling.None; // Disable downsampling for opaque textures
        __instance.useSRPBatcher = false; // Disable SRP Batcher for potential quality gains
        __instance.useAdaptivePerformance = false; // Disable adaptive performance

        // Post-Processing
        __instance.colorGradingMode = ColorGradingMode.LowDynamicRange; // HDR color grading
        __instance.colorGradingLutSize = 65; // Max LUT resolution for color grading
        __instance.m_VolumeFrameworkUpdateMode = VolumeFrameworkUpdateMode.EveryFrame; // Update volumes every frame

        // Additional Visual Quality Tweaks
        __instance.m_SupportsLightLayers = true; // Enable light layers
        __instance.conservativeEnclosingSphere = true; // Improve culling precision
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AdjustPostProcessing), nameof(AdjustPostProcessing.OnEnable))]
    [HarmonyPatch(typeof(AdjustPostProcessing), nameof(AdjustPostProcessing.OnVHSEffect))]
    [HarmonyPatch(typeof(AdjustPostProcessing), nameof(AdjustPostProcessing.OnResolutionChange))]
    public static void AdjustPostProcessing_OnEnable(AdjustPostProcessing __instance)
    {
        UpdateVolumes();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void PostProcessVolume_OnEnable(Volume __instance)
    {
        UpdateVolumes();
    }

    private static AspectRatioFitter AddAspectRatioFitter(GameObject go)
    {
        var arf = go.TryAddComponent<AspectRatioFitter>();
        arf.aspectRatio = GetPreferredAspect();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.enabled = true;
        return arf;
    }
}