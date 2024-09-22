namespace Hollowbody;

[Harmony]
public static class Patches
{
    private const string SelResolution = "UWF_Resolution";
    private static readonly List<HorizontalLayoutGroup> TitleBars = [];

    private static readonly string[] SkipThese = ["HeadwareSplash", "TitleMenu", "ViolenceWarning"];

    [HarmonyFinalizer]
    [HarmonyPatch(typeof(VirtualCameraGetLookAtTarget), nameof(VirtualCameraGetLookAtTarget.Execute))]
    private static Exception VirtualCameraGetLookAtTarget_Execute()
    {
        return null;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void PostProcessVolume_OnEnable(PostProcessVolume __instance)
    {
        if (SkipThese.Any(SceneManager.GetActiveScene().name.Contains)) return;

        var ap = __instance.profile;
        if (!ap) return;

        // Set Ambient Occlusion based on config value
        var ao = ap.TryGetSettings(out AmbientOcclusion ambientOcclusion);
        if (ao)
        {
            ambientOcclusion.active = Plugin.AmbientOcclusion.Value;
            ambientOcclusion.enabled.value = Plugin.AmbientOcclusion.Value;
        }

        // Set Color Grading based on config value
        ao = ap.TryGetSettings(out ColorGrading colorGrading);
        if (ao)
        {
            colorGrading.active = Plugin.ColorGrading.Value;
            colorGrading.enabled.value = Plugin.ColorGrading.Value;
        }

        // Set Motion Blur based on config value
        ao = ap.TryGetSettings(out MotionBlur motionBlur);
        if (ao)
        {
            motionBlur.active = Plugin.MotionBlur.Value;
            motionBlur.enabled.value = Plugin.MotionBlur.Value;
        }

        // Set Vignette based on config value
        ao = ap.TryGetSettings(out Vignette vignette);
        if (ao)
        {
            vignette.active = Plugin.Vignette.Value;
            vignette.enabled.value = Plugin.Vignette.Value;
        }

        // Set Auto Exposure based on config value
        ao = ap.TryGetSettings(out AutoExposure autoExposure);
        if (ao)
        {
            autoExposure.active = Plugin.AutoExposure.Value;
            autoExposure.enabled.value = Plugin.AutoExposure.Value;
        }
        
        // Set Chromatic Aberration based on config value
        ao = ap.TryGetSettings(out ChromaticAberration chromaticAberration);
        if (ao)
        {
            chromaticAberration.active = Plugin.ChromaticAberration.Value;
            chromaticAberration.enabled.value = Plugin.ChromaticAberration.Value;
        }

        // Set Grain based on config value
        ao = ap.TryGetSettings(out Grain grain);
        if (ao)
        {
            grain.active = Plugin.Grain.Value;
            grain.enabled.value = Plugin.Grain.Value;
        }

        // Set Bloom based on config value
        ao = ap.TryGetSettings(out Bloom bloom);
        if (ao)
        {
            bloom.active = Plugin.Bloom.Value;
            bloom.enabled.value = Plugin.Bloom.Value;
        }

        // Set CRT Effect based on config value
        ao = ap.TryGetSettings(out RLProCRTAperture crt);
        if (ao)
        {
            crt.active = Plugin.Crt.Value;
            crt.enabled.value = Plugin.Crt.Value;
        }

        // Set TV Effect based on config value
        ao = ap.TryGetSettings(out RLProTVEffect tv);
        if (ao)
        {
            tv.active = Plugin.TVEffect.Value;
            tv.enabled.value = Plugin.TVEffect.Value;
        }

        // Set Picture Correction based on config value
        ao = ap.TryGetSettings(out RLProPictureCorrection ppc);
        if (ao)
        {
            ppc.active = Plugin.PictureCorrection.Value;
            ppc.enabled.value = Plugin.PictureCorrection.Value;
        }

        // Mark the profile as dirty to update the changes
        ap.isDirty = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.OnEnable))]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.Init))]
    public static void PlayMakerFSM_OnEnable(ref PlayMakerFSM __instance)
    {
        if (!Plugin.CorrectUiElements.Value) return;

        if (__instance.name.Equals("UI_HotspotDetector"))
        {
            var dh = __instance.transform.Find("DetectorHolder");
            var rect = dh.GetComponent<RectTransform>();
            rect.offsetMax = rect.offsetMax with { x = Plugin.WidthDifference };
            rect.offsetMin = rect.offsetMin with { x = Plugin.BlackBarWidth };
        }

        if (__instance.name.Equals("UI_InfoText"))
        {
            var th = __instance.transform.Find("TextHolder");
            var rect = th.GetComponent<RectTransform>();
            rect.offsetMax = rect.offsetMax with { x = -Plugin.BlackBarWidth };
            rect.offsetMin = rect.offsetMin with { x = -Plugin.BlackBarWidth };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.Init))]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.UpdateVolumeSystem))]
    public static void PostProcessLayer_UpdateVolumeSystem(ref PostProcessLayer __instance)
    {
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicOptions), nameof(GraphicOptions.SaveAndApply))]
    public static void GraphicOptions_SaveAndApply(GraphicOptions __instance)
    {
        PlayerPrefs.SetInt(SelResolution, __instance.resolutionDropdown.value);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicOptions), nameof(GraphicOptions.SaveAndApply))]
    public static void GraphicOptions_SaveAndApply_Postfix(GraphicOptions __instance)
    {
        Plugin.UpdateGraphicsQualitySettings();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HorizontalLayoutGroup), nameof(HorizontalLayoutGroup.CalculateLayoutInputHorizontal))]
    [HarmonyPatch(typeof(HorizontalLayoutGroup), nameof(HorizontalLayoutGroup.CalculateLayoutInputVertical))]
    [HarmonyPatch(typeof(HorizontalLayoutGroup), nameof(HorizontalLayoutGroup.SetLayoutHorizontal))]
    [HarmonyPatch(typeof(HorizontalLayoutGroup), nameof(HorizontalLayoutGroup.SetLayoutVertical))]
    public static void HorizontalLayoutGroup_OnEnable(HorizontalLayoutGroup __instance)
    {
        if (__instance.GetPath().Contains("UI_Title"))
        {
            TitleBars.Add(__instance);
            __instance.enabled = !Plugin.CenterText.Value;
        }
    }

    internal static void UpdateTitleBars()
    {
        foreach (var titleBar in TitleBars.Where(titleBar => titleBar))
        {
            titleBar.enabled = !Plugin.CenterText.Value;
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicOptions), nameof(GraphicOptions.Awake))]
    public static void GraphicOptions_Awake_Prefix(GraphicOptions __instance)
    {
        __instance.supportedAspectRatios.Add(Plugin.MainDisplayAspectRatio);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicOptions), nameof(GraphicOptions.UpdateAdvancedUIValues))]
    public static void GraphicOptions_Awake(GraphicOptions __instance)
    {
        __instance.resolutionDropdown.Set(PlayerPrefs.GetInt(SelResolution, __instance.supportedResolutions.Count - 1), false);
        __instance.resolutionDropdown.RefreshShownValue();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ACDebug), nameof(ACDebug.CanDisplay))]
    public static void ACDebug_CanDisplay(ref bool __result)
    {
        __result = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Material), nameof(Material.HasProperty), typeof(string))]
    public static void Material_HasProperty(ref string name)
    {
        if (name.Contains("cull") || name.Contains("Cull"))
        {
            name = "_Cull";
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Material), nameof(Material.SetFloat), typeof(string), typeof(float))]
    [HarmonyPatch(typeof(Material), nameof(Material.SetInt), typeof(string), typeof(int))]
    public static void Material_SetInt(Material __instance, ref string name)
    {
        if (name.Contains("cull") || name.Contains("Cull"))
        {
            name = "_Cull";
        }
    }
}