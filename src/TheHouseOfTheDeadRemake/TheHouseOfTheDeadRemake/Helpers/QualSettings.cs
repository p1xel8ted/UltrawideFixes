namespace TheHouseOfTheDeadRemake.Helpers;

public static class QualSettings
{
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
            QualitySettings.masterTextureLimit = 0; // Disable mipmap limits / Full-resolution textures
            QualitySettings.maximumLODLevel = 0; // Use highest LOD level
        
            // Particles
            QualitySettings.particleRaycastBudget = 2048; // High particle raycast budget
            QualitySettings.softParticles = true; // Enable soft particles
            QualitySettings.softVegetation = true; // Smooth vegetation blending
            
            // Reflections
            QualitySettings.realtimeReflectionProbes = true; // Enable dynamic reflections
            
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
        
    }
}