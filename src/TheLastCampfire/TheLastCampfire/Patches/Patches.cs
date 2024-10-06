// ReSharper disable InconsistentNaming

namespace TheLastCampfire;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains("sinai")) return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TBFGUIPage_Gameplay), nameof(TBFGUIPage_Gameplay.Init))]
    public static void TBFGUIPage_Gameplay_Init(TBFGUIPage_Gameplay __instance)
    {
        Utils.AddContentSizeFitter(__instance.gameObject);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TBFGUIPage_Interaction), nameof(TBFGUIPage_Interaction.DoShow))]
    public static void TBFGUIPage_Interaction_Init(TBFGUIPage_Interaction __instance)
    {
        Utils.AddContentSizeFitter(__instance.gameObject);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(TBFGUIPage_Shared), nameof(TBFGUIPage_Shared.CutsceneBarsIn))]
    [HarmonyPatch(typeof(TBFGUIPage_Shared), nameof(TBFGUIPage_Shared.CutsceneBarsOut))]
    [HarmonyPatch(typeof(TBFGUIPage_Shared), nameof(TBFGUIPage_Shared.DoCutsceneBars))]
    public static bool TBFGUIPage_Shared_Cutscene(TBFGUIPage_Shared __instance)
    {
        return false;
    }

    internal static bool UpdateEffects { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessingBehaviour), nameof(PostProcessingBehaviour.OnPreRender))]
    public static void PostProcessingBehaviour_OnPreRender(PostProcessingBehaviour __instance)
    {
        if (!__instance.profile) return;
        if (!Patches.UpdateEffects) return;
        Patches.UpdateEffects = false;

        var profile = __instance.profile;

        var dv = profile.debugViews;
        if (dv != null)
        {
            dv.enabled = Plugin.DebugViews.Value;
        }

        var ao = profile.ambientOcclusion;
        if (ao != null)
        {
            ao.enabled = Plugin.AmbientOcclusion.Value;
            ao.settings = ao.settings with { highPrecision = true };
            ao.settings = ao.settings with { intensity = Plugin.AmbientOcclusionIntensity.Value }; // Apply intensity adjustment
        }

        var ssr = profile.screenSpaceReflection;
        if (ssr != null)
        {
            ssr.enabled = Plugin.ScreenSpaceReflection.Value;
            ssr.settings = ssr.settings with { reflection = ssr.settings.reflection with { reflectionQuality = ScreenSpaceReflectionModel.SSRResolution.High } };
        }

        var fog = profile.fog;
        if (fog != null)
        {
            fog.enabled = Plugin.Fog.Value;
        }

        var mb = profile.motionBlur;
        if (mb != null)
        {
            mb.enabled = Plugin.MotionBlur.Value;
            mb.settings = mb.settings with { shutterAngle = Plugin.MotionBlurStrength.Value * 360f }; // Apply motion blur strength
        }

        if (__instance.m_Components.Find(a => a is TaaComponent) is TaaComponent taa)
        {
            taa.model.enabled = Plugin.Taa.Value;
            taa.model.settings = taa.model.settings with { method = AntialiasingModel.Method.Taa };
            taa.model.settings = taa.model.settings with { taaSettings = taa.model.settings.taaSettings with { sharpen = Plugin.TaaSharpness.Value } }; // Apply TAA sharpness
        }

        var ea = profile.eyeAdaptation;
        if (ea != null)
        {
            ea.enabled = Plugin.EyeAdaptation.Value;
        }

        var dof = profile.depthOfField;
        if (dof != null)
        {
            dof.enabled = Plugin.DepthOfField.Value;
            dof.settings = dof.settings with { useCameraFov = true };
            dof.settings = dof.settings with { focusDistance = Plugin.DepthOfFieldFocusDistance.Value }; // Apply DoF focus distance
        }

        var bloom = profile.bloom;
        if (bloom != null)
        {
            bloom.enabled = Plugin.Bloom.Value;
            bloom.settings = bloom.settings with { lensDirt = bloom.settings.lensDirt with { intensity = Plugin.BloomDirtIntensity.Value } }; // Apply bloom dirt intensity
            bloom.settings = bloom.settings with { bloom = bloom.settings.bloom with { intensity = Plugin.BloomIntensity.Value } }; // Apply bloom intensity
        }

        var ca = profile.chromaticAberration;
        if (ca != null)
        {
            ca.enabled = Plugin.ChromaticAberration.Value;
            ca.settings = ca.settings with { intensity = Plugin.ChromaticAberrationIntensity.Value }; // Apply chromatic aberration intensity
        }

        var ul = profile.userLut;
        if (ul != null)
        {
            ul.enabled = Plugin.UserLut.Value;
        }

        var gr = profile.grain;
        if (gr != null)
        {
            gr.enabled = Plugin.Grain.Value;
            gr.settings = gr.settings with { intensity = Plugin.GrainIntensity.Value }; // Apply grain intensity
        }

        var vignette = profile.vignette;
        if (vignette != null)
        {
            vignette.enabled = Plugin.Vignette.Value;
            vignette.settings = vignette.settings with { intensity = Plugin.VignetteIntensity.Value }; // Apply vignette intensity
        }

        var dither = profile.dithering;
        if (dither != null)
        {
            dither.enabled = Plugin.Dithering.Value;
        }

        if (__instance.m_Components.Find(a => a is FxaaComponent) is FxaaComponent fxaa)
        {
            fxaa.model.enabled = Plugin.Fxaa.Value;
            fxaa.model.settings = fxaa.model.settings with { method = AntialiasingModel.Method.Fxaa };
            fxaa.model.settings = fxaa.model.settings with { fxaaSettings = fxaa.model.settings.fxaaSettings with { preset = AntialiasingModel.FxaaPreset.ExtremeQuality } };
        }
    }
}