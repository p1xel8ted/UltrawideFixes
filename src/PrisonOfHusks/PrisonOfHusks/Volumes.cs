namespace PrisonOfHusks;

/// <summary>
/// Manages Haunted PSX Render Pipeline volume overrides via BepInEx config.
/// Creates a persistent global Volume with max priority to override PSX rendering parameters.
/// </summary>
public static class Volumes
{
    private static bool _configCreated;
    private static Volume _overrideVolume;
    private static VolumeProfile _overrideProfile;

    // CameraVolume config — width is auto-calculated from height * screen aspect
    private static ConfigEntry<int> _rasterHeight;
    private static ConfigEntry<bool> _frameLimitEnabled;
    private static ConfigEntry<int> _frameLimit;

    // PrecisionVolume config
    private static ConfigEntry<float> _colorPrecision;
    private static ConfigEntry<float> _chromaPrecision;
    private static ConfigEntry<float> _framebufferDither;
    private static ConfigEntry<int> _ditherSize;
    private static ConfigEntry<float> _affineTextureWarping;

    // CathodeRayTubeVolume config
    private static ConfigEntry<bool> _crtEnabled;
    private static ConfigEntry<float> _crtBloom;
    private static ConfigEntry<float> _crtScanlineSharpness;
    private static ConfigEntry<float> _crtImageSharpness;
    private static ConfigEntry<float> _crtNoiseIntensity;
    private static ConfigEntry<float> _crtBarrelDistortionX;
    private static ConfigEntry<float> _crtBarrelDistortionY;
    private static ConfigEntry<float> _crtVignette;

    // CompressionVolume config
    private static ConfigEntry<bool> _compressionEnabled;
    private static ConfigEntry<float> _compressionWeight;

    // QualityOverrideVolume config
    private static ConfigEntry<bool> _psxQualityEnabled;

    // LightingVolume config
    private static ConfigEntry<bool> _lightingEnabled;
    private static ConfigEntry<float> _bakedLightingMultiplier;
    private static ConfigEntry<float> _vertexColorLightingMultiplier;
    private static ConfigEntry<float> _dynamicLightingMultiplier;

    // FogVolume config
    private static ConfigEntry<bool> _fogEnabled;
    private static ConfigEntry<float> _fogDistanceMin;
    private static ConfigEntry<float> _fogDistanceMax;
    private static ConfigEntry<float> _fogFalloffCurve;
    private static ConfigEntry<float> _fogPrecisionAlpha;
    private static ConfigEntry<float> _fogPrecisionAlphaDither;
    private static ConfigEntry<bool> _fogHeightFalloffEnabled;
    private static ConfigEntry<float> _fogHeightMin;
    private static ConfigEntry<float> _fogHeightMax;

    // TonemapperVolume config
    private static ConfigEntry<bool> _tonemapperEnabled;
    private static ConfigEntry<float> _tonemapperContrast;
    private static ConfigEntry<float> _tonemapperShoulder;
    private static ConfigEntry<float> _tonemapperGraypointIn;
    private static ConfigEntry<float> _tonemapperGraypointOut;
    private static ConfigEntry<float> _tonemapperWhitepoint;
    private static ConfigEntry<float> _tonemapperCrossTalk;
    private static ConfigEntry<float> _tonemapperSaturation;
    private static ConfigEntry<float> _tonemapperCrossTalkSaturation;

    // AccumulationMotionBlurVolume config
    private static ConfigEntry<float> _motionBlurWeight;
    private static ConfigEntry<float> _motionBlurVignette;
    private static ConfigEntry<float> _motionBlurDither;
    private static ConfigEntry<float> _motionBlurZoom;
    private static ConfigEntry<float> _motionBlurAnisotropy;

    // SkyVolume config
    private static ConfigEntry<float> _skyDitherWeight;

    // Reset
    private static bool _showResetConfirmation;

    /// <summary>
    /// Scans scene volumes for PSX components, creates config entries from runtime defaults,
    /// and applies overrides via a persistent global Volume.
    /// </summary>
    internal static void ScanAndApply()
    {
        if (!_configCreated)
        {
            CreateConfigFromSceneVolumes();
        }

        if (_configCreated)
        {
            ApplyOverrides();
        }
    }

    private static void CreateConfigFromSceneVolumes()
    {
        // Find PSX volume components from scene volumes to read runtime defaults
        var volumes = Resources.FindObjectsOfTypeAll<Volume>();
        Plugin.Log.LogInfo($"Found {volumes.Length} SRP Volume(s) in scene");

        CameraVolume sceneCam = null;
        PrecisionVolume scenePrec = null;
        CathodeRayTubeVolume sceneCrt = null;
        CompressionVolume sceneComp = null;
        QualityOverrideVolume sceneQuality = null;
        LightingVolume sceneLighting = null;
        FogVolume sceneFog = null;
        TonemapperVolume sceneTone = null;
        AccumulationMotionBlurVolume sceneMotionBlur = null;
        SkyVolume sceneSky = null;

        foreach (var vol in volumes)
        {
            if (!vol || !vol.profile) continue;

            Plugin.Log.LogInfo($"  Volume '{vol.name}' on '{vol.gameObject.name}' (global={vol.isGlobal}, priority={vol.priority}, components={vol.profile.components.Count})");

            foreach (var comp in vol.profile.components)
            {
                Plugin.Log.LogInfo($"    Component: {comp.GetType().Name} (active={comp.active})");
            }

            if (sceneCam == null && vol.profile.TryGet(out sceneCam))
            {
                Plugin.Log.LogInfo($"  Found CameraVolume: rasterW={sceneCam.targetRasterizationResolutionWidth.value}, rasterH={sceneCam.targetRasterizationResolutionHeight.value}, aspectMode={sceneCam.aspectMode.value}");
            }

            if (scenePrec == null && vol.profile.TryGet(out scenePrec))
            {
                Plugin.Log.LogInfo($"  Found PrecisionVolume: color={scenePrec.color.value}, chroma={scenePrec.chroma.value}, dither={scenePrec.framebufferDither.value}, ditherSize={scenePrec.ditherSize.value}, affine={scenePrec.affineTextureWarping.value}");
            }

            if (sceneCrt == null && vol.profile.TryGet(out sceneCrt))
            {
                Plugin.Log.LogInfo($"  Found CathodeRayTubeVolume: enabled={sceneCrt.isEnabled.value}, bloom={sceneCrt.bloom.value}, scanline={sceneCrt.scanlineSharpness.value}");
            }

            if (sceneComp == null && vol.profile.TryGet(out sceneComp))
            {
                Plugin.Log.LogInfo($"  Found CompressionVolume: enabled={sceneComp.isEnabled.value}, weight={sceneComp.weight.value}");
            }

            if (sceneQuality == null && vol.profile.TryGet(out sceneQuality))
            {
                Plugin.Log.LogInfo($"  Found QualityOverrideVolume: isPSXQualityEnabled={sceneQuality.isPSXQualityEnabled.value}");
            }

            if (sceneLighting == null && vol.profile.TryGet(out sceneLighting))
            {
                Plugin.Log.LogInfo($"  Found LightingVolume: enabled={sceneLighting.lightingIsEnabled.value}, baked={sceneLighting.bakedLightingMultiplier.value}, vertex={sceneLighting.vertexColorLightingMultiplier.value}, dynamic={sceneLighting.dynamicLightingMultiplier.value}");
            }

            if (sceneFog == null && vol.profile.TryGet(out sceneFog))
            {
                Plugin.Log.LogInfo($"  Found FogVolume: enabled={sceneFog.isEnabled.value}, distMin={sceneFog.distanceMin.value}, distMax={sceneFog.distanceMax.value}");
            }

            if (sceneTone == null && vol.profile.TryGet(out sceneTone))
            {
                Plugin.Log.LogInfo($"  Found TonemapperVolume: enabled={sceneTone.isEnabled.value}, contrast={sceneTone.contrast.value}, saturation={sceneTone.saturation.value}");
            }

            if (sceneMotionBlur == null && vol.profile.TryGet(out sceneMotionBlur))
            {
                Plugin.Log.LogInfo($"  Found AccumulationMotionBlurVolume: weight={sceneMotionBlur.weight.value}, zoom={sceneMotionBlur.zoom.value}");
            }

            if (sceneSky == null && vol.profile.TryGet(out sceneSky))
            {
                Plugin.Log.LogInfo($"  Found SkyVolume: ditherWeight={sceneSky.framebufferDitherWeight.value}");
            }
        }

        if (sceneCam == null && scenePrec == null && sceneCrt == null && sceneQuality == null)
        {
            Plugin.Log.LogInfo("No PSX volume components found in scene - skipping config creation");
            return;
        }

        CreateConfig(sceneCam, scenePrec, sceneCrt, sceneComp, sceneQuality, sceneLighting, sceneFog, sceneTone, sceneMotionBlur, sceneSky);
        CreateOverrideVolume(sceneCam, scenePrec, sceneCrt, sceneComp, sceneQuality, sceneLighting, sceneFog, sceneTone, sceneMotionBlur, sceneSky);
        _configCreated = true;
    }

    private static void CreateConfig(CameraVolume cam, PrecisionVolume prec, CathodeRayTubeVolume crt, CompressionVolume comp,
        QualityOverrideVolume quality, LightingVolume lighting, FogVolume fog, TonemapperVolume tone, AccumulationMotionBlurVolume motionBlur, SkyVolume sky)
    {
        const string qualitySection = "01. PSX Quality";
        const string camSection = "02. Pixelation (Camera)";
        const string precSection = "03. Color & Precision";
        const string crtSection = "04. CRT Effects";
        const string compSection = "05. Compression";
        const string lightingSection = "06. Lighting";
        const string fogSection = "07. Fog";
        const string toneSection = "08. Tonemapper";
        const string motionBlurSection = "09. Motion Blur";
        const string skySection = "10. Sky";

        var order = 90;

        // QualityOverrideVolume
        if (quality != null)
        {
            _psxQualityEnabled = Plugin.ConfigFile.Bind(qualitySection, "PSX Quality Enabled", quality.isPSXQualityEnabled.value,
                new ConfigDescription("Master toggle for all PSX rendering effects. Disabling removes all retro visual processing.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _psxQualityEnabled.SettingChanged += (_, _) => ApplyOverrides();
        }

        // CameraVolume — only expose height; width is auto-calculated from screen aspect
        if (cam != null)
        {
            _rasterHeight = Plugin.ConfigFile.Bind(camSection, "Rasterization Height", cam.targetRasterizationResolutionHeight.value,
                new ConfigDescription("Vertical resolution of the pixelated rendering. Width is auto-calculated from your screen's aspect ratio. Higher values = less pixelated.",
                    new AcceptableValueRange<int>(1, 2160), new ConfigurationManagerAttributes { Order = order-- }));

            _frameLimitEnabled = Plugin.ConfigFile.Bind(camSection, "Frame Limit Enabled", cam.isFrameLimitEnabled.value,
                new ConfigDescription("Enable the PSX-style frame rate limiter. Disable for smooth full-framerate rendering.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _frameLimit = Plugin.ConfigFile.Bind(camSection, "Frame Limit", cam.frameLimit.value,
                new ConfigDescription("Target frame rate when frame limiter is enabled.",
                    new AcceptableValueRange<int>(1, 240), new ConfigurationManagerAttributes { Order = order-- }));

            _rasterHeight.SettingChanged += (_, _) => ApplyOverrides();
            _frameLimitEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _frameLimit.SettingChanged += (_, _) => ApplyOverrides();
        }

        // PrecisionVolume
        if (prec != null)
        {
            order = 90;

            _colorPrecision = Plugin.ConfigFile.Bind(precSection, "Color Precision", prec.color.value,
                new ConfigDescription("Color depth/precision. Higher = more colors, less retro. 1.0 = full color.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _chromaPrecision = Plugin.ConfigFile.Bind(precSection, "Chroma Precision", prec.chroma.value,
                new ConfigDescription("Chroma (color saturation) precision. Higher = more color accuracy.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _framebufferDither = Plugin.ConfigFile.Bind(precSection, "Framebuffer Dither", prec.framebufferDither.value,
                new ConfigDescription("Dithering intensity applied to the framebuffer. 0 = no dithering.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _ditherSize = Plugin.ConfigFile.Bind(precSection, "Dither Size", prec.ditherSize.value,
                new ConfigDescription("Size of the dither pattern.",
                    new AcceptableValueRange<int>(1, 8), new ConfigurationManagerAttributes { Order = order-- }));

            _affineTextureWarping = Plugin.ConfigFile.Bind(precSection, "Affine Texture Warping", prec.affineTextureWarping.value,
                new ConfigDescription("PS1-style affine texture warping intensity. 0 = no warping (modern), 1 = full PS1 warping.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _colorPrecision.SettingChanged += (_, _) => ApplyOverrides();
            _chromaPrecision.SettingChanged += (_, _) => ApplyOverrides();
            _framebufferDither.SettingChanged += (_, _) => ApplyOverrides();
            _ditherSize.SettingChanged += (_, _) => ApplyOverrides();
            _affineTextureWarping.SettingChanged += (_, _) => ApplyOverrides();
        }

        // CathodeRayTubeVolume
        if (crt != null)
        {
            order = 90;

            _crtEnabled = Plugin.ConfigFile.Bind(crtSection, "CRT Effects Enabled", crt.isEnabled.value,
                new ConfigDescription("Enable or disable all CRT simulation effects (scanlines, barrel distortion, vignette, noise).",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _crtBloom = Plugin.ConfigFile.Bind(crtSection, "CRT Bloom", crt.bloom.value,
                new ConfigDescription("CRT phosphor bloom intensity.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtScanlineSharpness = Plugin.ConfigFile.Bind(crtSection, "Scanline Sharpness", crt.scanlineSharpness.value,
                new ConfigDescription("Sharpness of CRT scanlines. Higher = more visible scanlines.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtImageSharpness = Plugin.ConfigFile.Bind(crtSection, "Image Sharpness", crt.imageSharpness.value,
                new ConfigDescription("Overall image sharpness through the CRT filter.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtNoiseIntensity = Plugin.ConfigFile.Bind(crtSection, "Noise Intensity", crt.noiseIntensity.value,
                new ConfigDescription("CRT noise/static intensity.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtBarrelDistortionX = Plugin.ConfigFile.Bind(crtSection, "Barrel Distortion X", crt.barrelDistortionX.value,
                new ConfigDescription("Horizontal CRT barrel distortion (screen curvature). 0 = flat.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtBarrelDistortionY = Plugin.ConfigFile.Bind(crtSection, "Barrel Distortion Y", crt.barrelDistortionY.value,
                new ConfigDescription("Vertical CRT barrel distortion (screen curvature). 0 = flat.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtVignette = Plugin.ConfigFile.Bind(crtSection, "Vignette", crt.vignette.value,
                new ConfigDescription("CRT vignette (edge darkening) intensity. 0 = no vignette.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _crtEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _crtBloom.SettingChanged += (_, _) => ApplyOverrides();
            _crtScanlineSharpness.SettingChanged += (_, _) => ApplyOverrides();
            _crtImageSharpness.SettingChanged += (_, _) => ApplyOverrides();
            _crtNoiseIntensity.SettingChanged += (_, _) => ApplyOverrides();
            _crtBarrelDistortionX.SettingChanged += (_, _) => ApplyOverrides();
            _crtBarrelDistortionY.SettingChanged += (_, _) => ApplyOverrides();
            _crtVignette.SettingChanged += (_, _) => ApplyOverrides();
        }

        // CompressionVolume
        if (comp != null)
        {
            order = 90;

            _compressionEnabled = Plugin.ConfigFile.Bind(compSection, "Compression Enabled", comp.isEnabled.value,
                new ConfigDescription("Enable JPEG-like compression artifacts for extra retro feel.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _compressionWeight = Plugin.ConfigFile.Bind(compSection, "Compression Weight", comp.weight.value,
                new ConfigDescription("Strength of the compression artifact effect.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _compressionEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _compressionWeight.SettingChanged += (_, _) => ApplyOverrides();
        }

        // LightingVolume
        if (lighting != null)
        {
            order = 90;

            _lightingEnabled = Plugin.ConfigFile.Bind(lightingSection, "Lighting Enabled", lighting.lightingIsEnabled.value,
                new ConfigDescription("Enable PSX-style vertex lighting.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _bakedLightingMultiplier = Plugin.ConfigFile.Bind(lightingSection, "Baked Lighting Multiplier", lighting.bakedLightingMultiplier.value,
                new ConfigDescription("Multiplier for baked/lightmap lighting intensity.",
                    new AcceptableValueRange<float>(0f, 10f), new ConfigurationManagerAttributes { Order = order-- }));

            _vertexColorLightingMultiplier = Plugin.ConfigFile.Bind(lightingSection, "Vertex Color Lighting Multiplier", lighting.vertexColorLightingMultiplier.value,
                new ConfigDescription("Multiplier for vertex color lighting contribution.",
                    new AcceptableValueRange<float>(0f, 10f), new ConfigurationManagerAttributes { Order = order-- }));

            _dynamicLightingMultiplier = Plugin.ConfigFile.Bind(lightingSection, "Dynamic Lighting Multiplier", lighting.dynamicLightingMultiplier.value,
                new ConfigDescription("Multiplier for dynamic/realtime light intensity.",
                    new AcceptableValueRange<float>(0f, 10f), new ConfigurationManagerAttributes { Order = order-- }));

            _lightingEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _bakedLightingMultiplier.SettingChanged += (_, _) => ApplyOverrides();
            _vertexColorLightingMultiplier.SettingChanged += (_, _) => ApplyOverrides();
            _dynamicLightingMultiplier.SettingChanged += (_, _) => ApplyOverrides();
        }

        // FogVolume
        if (fog != null)
        {
            order = 90;

            _fogEnabled = Plugin.ConfigFile.Bind(fogSection, "Fog Enabled", fog.isEnabled.value,
                new ConfigDescription("Enable distance-based fog.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _fogDistanceMin = Plugin.ConfigFile.Bind(fogSection, "Fog Distance Min", fog.distanceMin.value,
                new ConfigDescription("Distance where fog starts.",
                    new AcceptableValueRange<float>(0f, 1000f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogDistanceMax = Plugin.ConfigFile.Bind(fogSection, "Fog Distance Max", fog.distanceMax.value,
                new ConfigDescription("Distance where fog reaches full density.",
                    new AcceptableValueRange<float>(0f, 1000f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogFalloffCurve = Plugin.ConfigFile.Bind(fogSection, "Fog Falloff Curve", fog.fogFalloffCurve.value,
                new ConfigDescription("Fog density falloff curve. -1 = rapid start, 0 = linear, 1 = gradual start.",
                    new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogPrecisionAlpha = Plugin.ConfigFile.Bind(fogSection, "Fog Precision Alpha", fog.precisionAlpha.value,
                new ConfigDescription("Fog alpha precision. Lower values create more banded/stepped fog.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogPrecisionAlphaDither = Plugin.ConfigFile.Bind(fogSection, "Fog Precision Alpha Dither", fog.precisionAlphaDither.value,
                new ConfigDescription("Dithering applied to fog alpha banding to smooth transitions.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogHeightFalloffEnabled = Plugin.ConfigFile.Bind(fogSection, "Height Falloff Enabled", fog.heightFalloffEnabled.value,
                new ConfigDescription("Enable height-based fog falloff in addition to distance.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _fogHeightMin = Plugin.ConfigFile.Bind(fogSection, "Height Min", fog.heightMin.value,
                new ConfigDescription("Minimum height for height-based fog.",
                    new AcceptableValueRange<float>(-500f, 500f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogHeightMax = Plugin.ConfigFile.Bind(fogSection, "Height Max", fog.heightMax.value,
                new ConfigDescription("Maximum height for height-based fog.",
                    new AcceptableValueRange<float>(-500f, 500f), new ConfigurationManagerAttributes { Order = order-- }));

            _fogEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _fogDistanceMin.SettingChanged += (_, _) => ApplyOverrides();
            _fogDistanceMax.SettingChanged += (_, _) => ApplyOverrides();
            _fogFalloffCurve.SettingChanged += (_, _) => ApplyOverrides();
            _fogPrecisionAlpha.SettingChanged += (_, _) => ApplyOverrides();
            _fogPrecisionAlphaDither.SettingChanged += (_, _) => ApplyOverrides();
            _fogHeightFalloffEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _fogHeightMin.SettingChanged += (_, _) => ApplyOverrides();
            _fogHeightMax.SettingChanged += (_, _) => ApplyOverrides();
        }

        // TonemapperVolume
        if (tone != null)
        {
            order = 90;

            _tonemapperEnabled = Plugin.ConfigFile.Bind(toneSection, "Tonemapper Enabled", tone.isEnabled.value,
                new ConfigDescription("Enable PSX tonemapping.",
                    null, new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperContrast = Plugin.ConfigFile.Bind(toneSection, "Contrast", tone.contrast.value,
                new ConfigDescription("Tonemapper contrast.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperShoulder = Plugin.ConfigFile.Bind(toneSection, "Shoulder", tone.shoulder.value,
                new ConfigDescription("Tonemapper shoulder (highlight rolloff).",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperGraypointIn = Plugin.ConfigFile.Bind(toneSection, "Graypoint In", tone.graypointIn.value,
                new ConfigDescription("Input graypoint for tonemapping curve.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperGraypointOut = Plugin.ConfigFile.Bind(toneSection, "Graypoint Out", tone.graypointOut.value,
                new ConfigDescription("Output graypoint for tonemapping curve.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperWhitepoint = Plugin.ConfigFile.Bind(toneSection, "Whitepoint", tone.whitepoint.value,
                new ConfigDescription("Scene whitepoint - values above this are clipped to white.",
                    new AcceptableValueRange<float>(0f, 100f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperCrossTalk = Plugin.ConfigFile.Bind(toneSection, "Cross Talk", tone.crossTalk.value,
                new ConfigDescription("Channel cross-talk amount. Higher values cause color bleeding between channels.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperSaturation = Plugin.ConfigFile.Bind(toneSection, "Saturation", tone.saturation.value,
                new ConfigDescription("Color saturation adjustment.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperCrossTalkSaturation = Plugin.ConfigFile.Bind(toneSection, "Cross Talk Saturation", tone.crossTalkSaturation.value,
                new ConfigDescription("Saturation of the cross-talk color bleeding.",
                    new AcceptableValueRange<float>(0.001f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _tonemapperEnabled.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperContrast.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperShoulder.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperGraypointIn.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperGraypointOut.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperWhitepoint.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperCrossTalk.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperSaturation.SettingChanged += (_, _) => ApplyOverrides();
            _tonemapperCrossTalkSaturation.SettingChanged += (_, _) => ApplyOverrides();
        }

        // AccumulationMotionBlurVolume
        if (motionBlur != null)
        {
            order = 90;

            _motionBlurWeight = Plugin.ConfigFile.Bind(motionBlurSection, "Motion Blur Weight", motionBlur.weight.value,
                new ConfigDescription("Accumulation motion blur intensity. 0 = disabled.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _motionBlurVignette = Plugin.ConfigFile.Bind(motionBlurSection, "Motion Blur Vignette", motionBlur.vignette.value,
                new ConfigDescription("Motion blur vignette effect.",
                    new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _motionBlurDither = Plugin.ConfigFile.Bind(motionBlurSection, "Motion Blur Dither", motionBlur.dither.value,
                new ConfigDescription("Dithering applied to motion blur.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _motionBlurZoom = Plugin.ConfigFile.Bind(motionBlurSection, "Motion Blur Zoom", motionBlur.zoom.value,
                new ConfigDescription("Radial zoom motion blur effect.",
                    new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _motionBlurAnisotropy = Plugin.ConfigFile.Bind(motionBlurSection, "Motion Blur Anisotropy", motionBlur.anisotropy.value,
                new ConfigDescription("Directional bias of the motion blur.",
                    new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _motionBlurWeight.SettingChanged += (_, _) => ApplyOverrides();
            _motionBlurVignette.SettingChanged += (_, _) => ApplyOverrides();
            _motionBlurDither.SettingChanged += (_, _) => ApplyOverrides();
            _motionBlurZoom.SettingChanged += (_, _) => ApplyOverrides();
            _motionBlurAnisotropy.SettingChanged += (_, _) => ApplyOverrides();
        }

        // SkyVolume
        if (sky != null)
        {
            order = 90;

            _skyDitherWeight = Plugin.ConfigFile.Bind(skySection, "Sky Dither Weight", sky.framebufferDitherWeight.value,
                new ConfigDescription("Dithering applied to the sky/background rendering.",
                    new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = order-- }));

            _skyDitherWeight.SettingChanged += (_, _) => ApplyOverrides();
        }

        // Field of View — not a volume, but placed last for correct ConfigManager section ordering
        const string fovSection = "11. Field of View";
        Plugin.AdditionalFov = Plugin.ConfigFile.Bind(fovSection, "Additional FOV", 0f,
            new ConfigDescription("Additive field of view adjustment in degrees. Positive values zoom out, negative values zoom in. Only affects the main camera.",
                new AcceptableValueRange<float>(-30f, 30f), new ConfigurationManagerAttributes { Order = 90 }));

        // Reset button
        const string resetSection = "12. Reset";
        Plugin.ConfigFile.Bind(resetSection, "Reset All", true,
            new ConfigDescription("Reset all settings to their game defaults.", null,
                new ConfigurationManagerAttributes { Order = 90, HideDefaultButton = true, CustomDrawer = ResetButtonDrawer }));

        Plugin.Log.LogInfo("PSX volume config entries created.");
    }

    private static void CreateOverrideVolume(CameraVolume cam, PrecisionVolume prec, CathodeRayTubeVolume crt, CompressionVolume comp,
        QualityOverrideVolume quality, LightingVolume lighting, FogVolume fog, TonemapperVolume tone, AccumulationMotionBlurVolume motionBlur, SkyVolume sky)
    {
        if (_overrideVolume) return;

        var go = new GameObject("PSXConfigOverride");
        UnityEngine.Object.DontDestroyOnLoad(go);

        _overrideVolume = go.AddComponent<Volume>();
        _overrideVolume.isGlobal = true;
        _overrideVolume.priority = float.MaxValue;

        _overrideProfile = ScriptableObject.CreateInstance<VolumeProfile>();
        _overrideVolume.profile = _overrideProfile;

        if (cam != null)
        {
            var camOverride = _overrideProfile.Add<CameraVolume>();
            camOverride.targetRasterizationResolutionWidth.overrideState = true;
            camOverride.targetRasterizationResolutionHeight.overrideState = true;
            camOverride.isFrameLimitEnabled.overrideState = true;
            camOverride.frameLimit.overrideState = true;
        }

        if (prec != null)
        {
            var precOverride = _overrideProfile.Add<PrecisionVolume>();
            precOverride.color.overrideState = true;
            precOverride.chroma.overrideState = true;
            precOverride.framebufferDither.overrideState = true;
            precOverride.ditherSize.overrideState = true;
            precOverride.affineTextureWarping.overrideState = true;
        }

        if (crt != null)
        {
            var crtOverride = _overrideProfile.Add<CathodeRayTubeVolume>();
            crtOverride.isEnabled.overrideState = true;
            crtOverride.bloom.overrideState = true;
            crtOverride.scanlineSharpness.overrideState = true;
            crtOverride.imageSharpness.overrideState = true;
            crtOverride.noiseIntensity.overrideState = true;
            crtOverride.barrelDistortionX.overrideState = true;
            crtOverride.barrelDistortionY.overrideState = true;
            crtOverride.vignette.overrideState = true;
        }

        if (comp != null)
        {
            var compOverride = _overrideProfile.Add<CompressionVolume>();
            compOverride.isEnabled.overrideState = true;
            compOverride.weight.overrideState = true;
        }

        if (quality != null)
        {
            var qualityOverride = _overrideProfile.Add<QualityOverrideVolume>();
            qualityOverride.isPSXQualityEnabled.overrideState = true;
        }

        if (lighting != null)
        {
            var lightingOverride = _overrideProfile.Add<LightingVolume>();
            lightingOverride.lightingIsEnabled.overrideState = true;
            lightingOverride.bakedLightingMultiplier.overrideState = true;
            lightingOverride.vertexColorLightingMultiplier.overrideState = true;
            lightingOverride.dynamicLightingMultiplier.overrideState = true;
        }

        if (fog != null)
        {
            var fogOverride = _overrideProfile.Add<FogVolume>();
            fogOverride.isEnabled.overrideState = true;
            fogOverride.distanceMin.overrideState = true;
            fogOverride.distanceMax.overrideState = true;
            fogOverride.fogFalloffCurve.overrideState = true;
            fogOverride.precisionAlpha.overrideState = true;
            fogOverride.precisionAlphaDither.overrideState = true;
            fogOverride.heightFalloffEnabled.overrideState = true;
            fogOverride.heightMin.overrideState = true;
            fogOverride.heightMax.overrideState = true;
        }

        if (tone != null)
        {
            var toneOverride = _overrideProfile.Add<TonemapperVolume>();
            toneOverride.isEnabled.overrideState = true;
            toneOverride.contrast.overrideState = true;
            toneOverride.shoulder.overrideState = true;
            toneOverride.graypointIn.overrideState = true;
            toneOverride.graypointOut.overrideState = true;
            toneOverride.whitepoint.overrideState = true;
            toneOverride.crossTalk.overrideState = true;
            toneOverride.saturation.overrideState = true;
            toneOverride.crossTalkSaturation.overrideState = true;
        }

        if (motionBlur != null)
        {
            var mbOverride = _overrideProfile.Add<AccumulationMotionBlurVolume>();
            mbOverride.weight.overrideState = true;
            mbOverride.vignette.overrideState = true;
            mbOverride.dither.overrideState = true;
            mbOverride.zoom.overrideState = true;
            mbOverride.anisotropy.overrideState = true;
        }

        if (sky != null)
        {
            var skyOverride = _overrideProfile.Add<SkyVolume>();
            skyOverride.framebufferDitherWeight.overrideState = true;
        }

        Plugin.Log.LogInfo("Created PSX config override Volume (global, max priority)");
    }

    private static void ApplyOverrides()
    {
        if (!_overrideProfile) return;

        if (_rasterHeight != null && _overrideProfile.TryGet<CameraVolume>(out var camOv))
        {
            var h = _rasterHeight.Value;
            var w = Mathf.FloorToInt(h * DisplayMetrics.MainAspect + 0.5f);
            camOv.targetRasterizationResolutionHeight.value = h;
            camOv.targetRasterizationResolutionWidth.value = w;
            camOv.isFrameLimitEnabled.value = _frameLimitEnabled.Value;
            camOv.frameLimit.value = _frameLimit.Value;
            Plugin.Log.LogInfo($"Applied CameraVolume overrides: rasterH={h}, rasterW={w}, frameLimitEnabled={_frameLimitEnabled.Value}, frameLimit={_frameLimit.Value}");
        }

        if (_colorPrecision != null && _overrideProfile.TryGet<PrecisionVolume>(out var precOv))
        {
            precOv.color.value = _colorPrecision.Value;
            precOv.chroma.value = _chromaPrecision.Value;
            precOv.framebufferDither.value = _framebufferDither.Value;
            precOv.ditherSize.value = _ditherSize.Value;
            precOv.affineTextureWarping.value = _affineTextureWarping.Value;
            Plugin.Log.LogInfo($"Applied PrecisionVolume overrides: color={_colorPrecision.Value}, chroma={_chromaPrecision.Value}, dither={_framebufferDither.Value}");
        }

        if (_crtEnabled != null && _overrideProfile.TryGet<CathodeRayTubeVolume>(out var crtOv))
        {
            crtOv.isEnabled.value = _crtEnabled.Value;
            crtOv.bloom.value = _crtBloom.Value;
            crtOv.scanlineSharpness.value = _crtScanlineSharpness.Value;
            crtOv.imageSharpness.value = _crtImageSharpness.Value;
            crtOv.noiseIntensity.value = _crtNoiseIntensity.Value;
            crtOv.barrelDistortionX.value = _crtBarrelDistortionX.Value;
            crtOv.barrelDistortionY.value = _crtBarrelDistortionY.Value;
            crtOv.vignette.value = _crtVignette.Value;
            Plugin.Log.LogInfo($"Applied CathodeRayTubeVolume overrides: enabled={_crtEnabled.Value}, bloom={_crtBloom.Value}");
        }

        if (_compressionEnabled != null && _overrideProfile.TryGet<CompressionVolume>(out var compOv))
        {
            compOv.isEnabled.value = _compressionEnabled.Value;
            compOv.weight.value = _compressionWeight.Value;
            Plugin.Log.LogInfo($"Applied CompressionVolume overrides: enabled={_compressionEnabled.Value}, weight={_compressionWeight.Value}");
        }

        if (_psxQualityEnabled != null && _overrideProfile.TryGet<QualityOverrideVolume>(out var qualOv))
        {
            qualOv.isPSXQualityEnabled.value = _psxQualityEnabled.Value;
            Plugin.Log.LogInfo($"Applied QualityOverrideVolume overrides: isPSXQualityEnabled={_psxQualityEnabled.Value}");
        }

        if (_lightingEnabled != null && _overrideProfile.TryGet<LightingVolume>(out var lightOv))
        {
            lightOv.lightingIsEnabled.value = _lightingEnabled.Value;
            lightOv.bakedLightingMultiplier.value = _bakedLightingMultiplier.Value;
            lightOv.vertexColorLightingMultiplier.value = _vertexColorLightingMultiplier.Value;
            lightOv.dynamicLightingMultiplier.value = _dynamicLightingMultiplier.Value;
            Plugin.Log.LogInfo($"Applied LightingVolume overrides: enabled={_lightingEnabled.Value}, baked={_bakedLightingMultiplier.Value}, dynamic={_dynamicLightingMultiplier.Value}");
        }

        if (_fogEnabled != null && _overrideProfile.TryGet<FogVolume>(out var fogOv))
        {
            fogOv.isEnabled.value = _fogEnabled.Value;
            fogOv.distanceMin.value = _fogDistanceMin.Value;
            fogOv.distanceMax.value = _fogDistanceMax.Value;
            fogOv.fogFalloffCurve.value = _fogFalloffCurve.Value;
            fogOv.precisionAlpha.value = _fogPrecisionAlpha.Value;
            fogOv.precisionAlphaDither.value = _fogPrecisionAlphaDither.Value;
            fogOv.heightFalloffEnabled.value = _fogHeightFalloffEnabled.Value;
            fogOv.heightMin.value = _fogHeightMin.Value;
            fogOv.heightMax.value = _fogHeightMax.Value;
            Plugin.Log.LogInfo($"Applied FogVolume overrides: enabled={_fogEnabled.Value}, distMin={_fogDistanceMin.Value}, distMax={_fogDistanceMax.Value}");
        }

        if (_tonemapperEnabled != null && _overrideProfile.TryGet<TonemapperVolume>(out var toneOv))
        {
            toneOv.isEnabled.value = _tonemapperEnabled.Value;
            toneOv.contrast.value = _tonemapperContrast.Value;
            toneOv.shoulder.value = _tonemapperShoulder.Value;
            toneOv.graypointIn.value = _tonemapperGraypointIn.Value;
            toneOv.graypointOut.value = _tonemapperGraypointOut.Value;
            toneOv.whitepoint.value = _tonemapperWhitepoint.Value;
            toneOv.crossTalk.value = _tonemapperCrossTalk.Value;
            toneOv.saturation.value = _tonemapperSaturation.Value;
            toneOv.crossTalkSaturation.value = _tonemapperCrossTalkSaturation.Value;
            Plugin.Log.LogInfo($"Applied TonemapperVolume overrides: enabled={_tonemapperEnabled.Value}, contrast={_tonemapperContrast.Value}, saturation={_tonemapperSaturation.Value}");
        }

        if (_motionBlurWeight != null && _overrideProfile.TryGet<AccumulationMotionBlurVolume>(out var mbOv))
        {
            mbOv.weight.value = _motionBlurWeight.Value;
            mbOv.vignette.value = _motionBlurVignette.Value;
            mbOv.dither.value = _motionBlurDither.Value;
            mbOv.zoom.value = _motionBlurZoom.Value;
            mbOv.anisotropy.value = _motionBlurAnisotropy.Value;
            Plugin.Log.LogInfo($"Applied AccumulationMotionBlurVolume overrides: weight={_motionBlurWeight.Value}, zoom={_motionBlurZoom.Value}");
        }

        if (_skyDitherWeight != null && _overrideProfile.TryGet<SkyVolume>(out var skyOv))
        {
            skyOv.framebufferDitherWeight.value = _skyDitherWeight.Value;
            Plugin.Log.LogInfo($"Applied SkyVolume overrides: ditherWeight={_skyDitherWeight.Value}");
        }
    }

    private static void ResetButtonDrawer(ConfigEntryBase entry)
    {
        if (_showResetConfirmation)
        {
            GUILayout.Label("Are you sure you want to reset all settings to default?");
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Yes", GUILayout.ExpandWidth(true)))
            {
                ResetAllToDefaults();
                _showResetConfirmation = false;
            }

            if (GUILayout.Button("No", GUILayout.ExpandWidth(true)))
            {
                _showResetConfirmation = false;
            }

            GUILayout.EndHorizontal();
        }
        else
        {
            if (GUILayout.Button("Reset All Settings to Default", GUILayout.ExpandWidth(true)))
            {
                _showResetConfirmation = true;
            }
        }
    }

    private static void ResetAllToDefaults()
    {
        foreach (var kvp in Plugin.ConfigFile)
        {
            // Skip the reset button's own dummy entry
            if (kvp.Key.Key == "Reset All") continue;

            kvp.Value.BoxedValue = kvp.Value.DefaultValue;
        }

        Plugin.Log.LogInfo("All settings reset to defaults.");
    }
}
