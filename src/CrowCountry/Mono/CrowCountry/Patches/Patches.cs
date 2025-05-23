﻿using CrowCountry.Generics;

namespace CrowCountry.Patches;

[Harmony]
public static class Patches
{


    private static readonly int ColorMat = Shader.PropertyToID("colorMat");
    private static readonly int BlurTex = Shader.PropertyToID("_BlurTex");

    private static readonly WriteOnce<float> BgMainX = new();
    private static readonly WriteOnce<float> BgMainY = new();


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIPixelate), nameof(UIPixelate.OnEnable))]
    public static void UIPixelate_OnEnable(UIPixelate __instance)
    {
        var rect = __instance.GetComponent<RectTransform>();
        if (rect && __instance.name.Equals(Const.BgMain, StringComparison.OrdinalIgnoreCase))
        {
            BgMainX.Value = rect.sizeDelta.x;
            BgMainY.Value = rect.sizeDelta.y;

            var x = BgMainX.Value * Plugin.PositiveScaleFactor;
            var y = BgMainY.Value * Plugin.PositiveScaleFactor;
            rect.sizeDelta = new Vector2(x, y);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(PMFullscreen), nameof(PMFullscreen.SetResolution))]
    public static void PMFullscreen_SetResolution(ref int w, ref int h, ref FullScreenMode fullscreenMode)
    {
        w = Plugin.MainWidth;
        h = Plugin.MainHeight;
        fullscreenMode = Plugin.FullScreenModeConfig.Value;
        ScalingCorrections.UpdatePoison();
        if (Instances.CrowCountryCamEffectInstance)
        {
            Renderer.PixelationAdjust(Instances.CrowCountryCamEffectInstance);
            Instances.CrowCountryCamEffectInstance.UpdateColorMatrices();
        }
    }


    internal static bool FovAdjusterEnabled()
    {
        return Instances.ItemFovAdjusterInstance && Instances.ItemFovAdjusterInstance.gameObject.activeSelf ||
               Instances.TipFovAdjusterInstance && Instances.TipFovAdjusterInstance.gameObject.activeSelf ||
               Instances.InventoryFovAdjusterInstance && Instances.InventoryFovAdjusterInstance.gameObject.activeSelf;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.Start))]
    [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.OnEnable))]
    public static void PlayMakerFSM_OnEnable(PlayMakerFSM __instance)
    {
        if (__instance.name.Equals(Const.PoisonFrame, StringComparison.OrdinalIgnoreCase))
        {
            Instances.PoisonInstance = __instance;
            ScalingCorrections.PoisonScale.Value = __instance.transform.localScale;
        }

        if (__instance.name.Equals(Const.ItemsPlayMaker, StringComparison.OrdinalIgnoreCase))
        {
            var onOff = __instance.transform.GetChild(0);
            Instances.ItemFovAdjusterInstance = onOff.gameObject.TryAddComponent<FovAdjuster>();
            Instances.ItemFovAdjusterInstance.enableDuration = 0.4f;
            Instances.ItemFovAdjusterInstance.disableDuration = 0.75f;
        }

        if (__instance.name.Equals(Const.TipsBackgroundPlayMaker, StringComparison.OrdinalIgnoreCase))
        {
            var onOff = __instance.transform.GetChild(0);
            Instances.TipFovAdjusterInstance = onOff.gameObject.TryAddComponent<FovAdjuster>();
            Instances.TipFovAdjusterInstance.enableDuration = 0f;
            Instances.ItemFovAdjusterInstance.disableDuration = 0.75f;
        }

        if (__instance.name.Equals(Const.TipsPlayMaker, StringComparison.OrdinalIgnoreCase))
        {
            __instance.transform.localScale = __instance.transform.localScale with {x = 0.9f, y = 0.9f};
        }

        if (!Instances.CrowCountryCamEffectInstance) return;

        Renderer.PixelationAdjust(Instances.CrowCountryCamEffectInstance);
        Instances.CrowCountryCamEffectInstance.UpdateColorMatrices();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.OnRenderImage))]
    public static void CrowCountryCamEffect_OnRenderImage(CrowCountryCamEffect __instance)
    {
        Instances.CrowCountryCamEffectInstance = __instance;
        __instance.enableCRTBlurFilter = Plugin.CRTEffect.Value;
        __instance.enableCRTPostFilter = Plugin.CRTEffect.Value;

        __instance.enablePSXFilter = Plugin.PSXEffect.Value;

        __instance.enableSFBFilter = Plugin.FlashbackEffect.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.Awake))]
    public static void CrowCountryCamEffect_Awake(CrowCountryCamEffect __instance)
    {
        Instances.CrowCountryCamEffectInstance = __instance;

        if (Application.isPlaying)
        {
            Application.targetFrameRate = (int) Plugin.RefreshRateNew.value;
        }

        Renderer.PixelationAdjust(__instance);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CrowCountryCamEffect), nameof(CrowCountryCamEffect.UpdateColorMatrices))]
    public static void CrowCountryCamEffect_UpdateColorMatrices(CrowCountryCamEffect __instance)
    {
        var brightnessAdjustment = Plugin.CRTEffectBrightness.Value;
        var brightnessVector = new Vector4(brightnessAdjustment, brightnessAdjustment, brightnessAdjustment, 1f);
    
        var contractAdjustment = Plugin.CRTEffectContrast.Value;
        var contrastVector = new Vector4(contractAdjustment, contractAdjustment, contractAdjustment, 1f);
    
        var saturationAdjustment = Plugin.CRTEffectSaturation.Value;
        var saturationVector = new Vector4(saturationAdjustment, saturationAdjustment, saturationAdjustment, 1f);
    
        __instance.crtBrightnessMat.SetColumn(3, brightnessVector);
        __instance.crtContrastMat.SetColumn(3, contrastVector);
        __instance.crtSaturationMat.SetColumn(3, saturationVector);
    
        __instance.crtColorMat = __instance.crtBrightnessMat * __instance.crtContrastMat * __instance.crtSaturationMat;
    
        __instance.crtPostProMaterial.SetTexture(BlurTex,  __instance.texC1248x702);
        __instance.crtPostProMaterial.SetMatrix(ColorMat, __instance.crtColorMat);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnDisable))]
    public static void CanvasScaler_OnDisable(CanvasScaler __instance)
    {
        if (__instance.name.Equals(Const.UICanvasInventoryOff, StringComparison.OrdinalIgnoreCase))
        {
            Utils.DisablePillarBoxing();
            ScalingCorrections.UpdatePoison();
        }

        if (__instance.name.Equals(Const.UICanvasPauseOff, StringComparison.OrdinalIgnoreCase))
        {
            ScalingCorrections.UpdatePoison();
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Equals(Const.UICanvasPauseOff, StringComparison.OrdinalIgnoreCase))
        {
            ScalingCorrections.CorrectPauseScreen(__instance.transform);
        }

        ScalingCorrections.CorrectMapBackground();
       

        ScalingCorrections.CorrectResultsScreen(__instance.transform);

        if (__instance.name.Equals(Const.Canvas, StringComparison.OrdinalIgnoreCase))
        {
            ScalingCorrections.CorrectCreditsScreen(__instance.transform);
            ScalingCorrections.CorrectBlackBackground(__instance.transform);
            ScalingCorrections.CorrectFooter(__instance.transform);
        }


        if (!__instance.name.Equals(Const.UICanvasInventoryOff, StringComparison.OrdinalIgnoreCase)) return;

        Utils.EnablePillarBoxing();
        Instances.InventoryFovAdjusterInstance = __instance.gameObject.TryAddComponent<FovAdjuster>();
        Instances.InventoryFovAdjusterInstance.enableDuration = 0f;
        Instances.InventoryFovAdjusterInstance.disableDuration = 0f;
    }
    
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];
    
    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Plugin.MainAspectRatio > Plugin.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_Handle(CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }
}