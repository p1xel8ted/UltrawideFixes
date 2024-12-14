namespace WildWoods;

public static class QualSettings
{
    private static MsaaQuality GetMsaaQuality()
    {
        return Plugin.MSAA.Value switch
        {
            0 => MsaaQuality.Disabled,
            2 => MsaaQuality._2x,
            4 => MsaaQuality._4x,
            8 => MsaaQuality._8x,
            _ => MsaaQuality.Disabled
        };
    }

    internal static void UpdateSettings()
    {
        //Anti-Aliasing
        QualitySettings.antiAliasing = Plugin.MSAA.Value; // Maximum anti-aliasing

        if (Plugin.MaximumQuality.Value)
        {
            // Lighting and Shadows
            QualitySettings.pixelLightCount = 8; // Maximum number of pixel lights
            QualitySettings.shadows = ShadowQuality.All; // Enable all shadows
            QualitySettings.shadowProjection = ShadowProjection.StableFit; // Stable shadows
            QualitySettings.shadowCascades = 4; // Four cascades for better shadow quality
            QualitySettings.shadowDistance = 300f; // Long shadow distance
            QualitySettings.shadowResolution = ShadowResolution.VeryHigh; // Highest shadow resolution
            QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask; // Dynamic and baked shadows
            QualitySettings.shadowNearPlaneOffset = 1f; // Lower near plane offset for accurate shadows
            QualitySettings.shadowCascade2Split = 0.5f; // Adjusted for 2 cascades
            QualitySettings.shadowCascade4Split = new Vector3(0.07f, 0.2f, 0.47f); // Split for 4 cascades
        
            // Level of Detail (LOD)
            QualitySettings.lodBias = 4f; // Use highest LOD models
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable; // Maximum texture filtering
            QualitySettings.globalTextureMipmapLimit = 0; // Disable mipmap limits / Full-resolution textures
            QualitySettings.maximumLODLevel = 0; // Use highest LOD level
            QualitySettings.enableLODCrossFade = true; // Enable smooth LOD transitions
        
            // Particles
            QualitySettings.particleRaycastBudget = 2048; // High particle raycast budget
            QualitySettings.softParticles = true; // Enable soft particles
            QualitySettings.softVegetation = true; // Smooth vegetation blending
        
            // Global Illumination (GI)
            QualitySettings.realtimeGICPUUsage = 100; // Maximum CPU usage for real-time GI
        
            // Reflections
            QualitySettings.realtimeReflectionProbes = true; // Enable dynamic reflections
        
            // Terrain
            QualitySettings.terrainPixelError = 1; // Maximum terrain resolution
            QualitySettings.terrainDetailDensityScale = 1; // Full terrain detail density
            QualitySettings.terrainBasemapDistance = 2000f; // Long-distance terrain detail
            QualitySettings.terrainDetailDistance = 200f; // Maximum detail draw distance
            QualitySettings.terrainTreeDistance = 5000f; // Long tree rendering distance
            QualitySettings.terrainBillboardStart = 50f; // Billboard rendering at a reasonable distance
            QualitySettings.terrainFadeLength = 5f; // Smooth fading
            QualitySettings.terrainMaxTrees = 2000; // Dense forests
        
            // Skinning and Animation
            QualitySettings.skinWeights = SkinWeights.FourBones; // High-quality skinning
        
            // Mipmap Streaming
            QualitySettings.streamingMipmapsActive = false; // Disable streaming mipmaps
            QualitySettings.streamingMipmapsMemoryBudget = 2048; // High memory budget if enabled
            QualitySettings.streamingMipmapsRenderersPerFrame = 1024; // Large capacity for renderers
            QualitySettings.streamingMipmapsMaxLevelReduction = 0; // No level reduction
            QualitySettings.streamingMipmapsAddAllCameras = true; // Include all cameras for mipmaps
            QualitySettings.streamingMipmapsMaxFileIORequests = 2048; // Maximize file I/O requests
        
            // Async Upload
            QualitySettings.asyncUploadTimeSlice = 4; // More time for async uploads
            QualitySettings.asyncUploadBufferSize = 32; // Larger buffer for texture uploads
            QualitySettings.asyncUploadPersistentBuffer = true; // Persistent buffer enabled
        }

        var renderAssets = Resources.FindObjectsOfTypeAll<UniversalRenderPipelineAsset>();
        foreach (var asset in renderAssets)
        {
            // General Settings
            asset.m_MSAA = GetMsaaQuality(); // Maximum MSAA
            asset.msaaSampleCount = Plugin.MSAA.Value; // Maximum MSAA
            asset.renderScale = Plugin.RenderScale.Value; // Supersampled rendering

            if (!Plugin.MaximumQuality.Value) return;
            
            // Depth and Opaque Textures
            asset.supportsCameraDepthTexture = true; // Enable depth texture
            asset.supportsCameraOpaqueTexture = true; // Enable opaque texture
            asset.m_OpaqueDownsampling = Downsampling.None; // Full-resolution opaque textures
            
            // Shadows
            asset.shadowDistance = 500f; // Maximum shadow distance
            asset.shadowCascadeCount = 4; // Use 4 shadow cascades
            asset.cascade4Split = new Vector3(0.05f, 0.15f, 0.3f); // Optimal split for 4 cascades
            asset.shadowDepthBias = 0.005f; // Reduce depth bias
            asset.shadowNormalBias = 0.002f; // Reduce normal bias
            asset.mainLightShadowmapResolution = 4096; // Highest resolution for main light shadows
            asset.additionalLightsShadowmapResolution = 2048; // High resolution for additional light shadows
            asset.additionalLightsShadowResolutionTierLow = 512; // Maximum resolution for low-tier shadows
            asset.additionalLightsShadowResolutionTierMedium = 1024; // Maximum resolution for medium-tier shadows
            asset.additionalLightsShadowResolutionTierHigh = 2048; // Maximum resolution for high-tier shadows
            asset.supportsSoftShadows = true; // Enable soft shadows
            asset.softShadowQuality = SoftShadowQuality.High; // High-quality soft shadows
            
            // Lighting
            asset.mainLightRenderingMode = LightRenderingMode.PerPixel; // Per-pixel main light
            asset.supportsMainLightShadows = true; // Enable main light shadows
            asset.additionalLightsRenderingMode = LightRenderingMode.PerPixel; // Per-pixel additional lights
            asset.maxAdditionalLightsCount = 8; // Support 8 additional lights
            asset.supportsAdditionalLightShadows = true; // Enable shadows for additional lights
            
            // Reflection Probes
            asset.reflectionProbeBlending = true; // Enable reflection probe blending
            asset.reflectionProbeBoxProjection = true; // Enable box projection for reflection probes
            
            // Post-Processing
            asset.colorGradingMode = ColorGradingMode.LowDynamicRange; // SDR color grading
            asset.colorGradingLutSize = 65; // Maximum LUT size for color grading
            
            // LOD and Upscaling
            asset.m_EnableLODCrossFade = true; // Enable smooth LOD transitions
            asset.m_LODCrossFadeDitheringType = LODCrossFadeDitheringType.BlueNoise; // Optimal dithering for LOD
            asset.upscalingFilter = UpscalingFilterSelection.Linear; // Linear upscaling
            asset.fsrOverrideSharpness = false; // FSR sharpening not applicable for SDR
            asset.fsrSharpness = 0.0f; // No sharpening
            
            // Terrain
            asset.m_SupportsTerrainHoles = true; // Allow terrain holes for flexibility
            
            // Performance and Debugging
            asset.useSRPBatcher = true; // Enable SRP batcher for efficient rendering
            asset.supportsDynamicBatching = true; // Enable dynamic batching
            asset.storeActionsOptimization = StoreActionsOptimization.Store; // Maximize rendering quality over memory usage
            
            // Miscellaneous
            asset.m_VolumeFrameworkUpdateMode = VolumeFrameworkUpdateMode.EveryFrame; // Continuous volume updates
            asset.useAdaptivePerformance = false; // Disable adaptive performance to lock quality
            asset.numIterationsEnclosingSphere = 128; // Increase sphere calculations for better precision
            asset.conservativeEnclosingSphere = false; // Use precise enclosing sphere calculations
        }
    }
}