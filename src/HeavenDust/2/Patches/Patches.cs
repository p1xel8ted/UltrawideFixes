namespace HeavenDustTwo.Patches;

[Harmony]
public static class Patches
{
    private const string ImgMask = "ImgMask";

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainUI), nameof(MainUI.ShowStudioName))]
    public static bool MainUI_ShowStudioName()
    {
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.DoStart))]
    public static void SplashScreen_DoStart()
    {
        OptionMgr_SetResolution(0);
        SplashScreen.m_bDone = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionMgr), nameof(OptionMgr.SetResolution), typeof(int))]
    public static bool OptionMgr_SetResolution(int nIndex)
    {
        AspectUtility.s_fWantedAspectRatio = Plugin.MainAspectRatio;
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, Plugin.FullScreenModeConfig.Value, Plugin.MaxRefresh);
        AspectUtility.SetCameraRects();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(FogOfWarLegacy), nameof(FogOfWarLegacy.Start))]
    public static void FogOfWarLegacy_Start(ref FogOfWarLegacy __instance)
    {
        __instance.GetOrAddComponent<FogOfWarLegacyController>();
        __instance.GetOrAddComponent<BloomToggler>();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainUI), nameof(MainUI.Start))]
    public static void MainUI_Start(ref MainUI __instance)
    {
        var overlay = __instance.transform.FindDeepChild(ImgMask);
        overlay.gameObject.GetOrAddComponent<ImageToggler>();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_Handle(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        if (Plugin.AlternateUiScaleMode.Value)
        {
            __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MobilePostProcessing), nameof(MobilePostProcessing.Start))]
    [HarmonyPatch(typeof(MobilePostProcessing), nameof(MobilePostProcessing.Update))]
    public static void MobilePostProcessing_Start(ref MobilePostProcessing __instance)
    {
        __instance.Vignette = Plugin.Vignette.Value;
        __instance.ChromaticAberration = Plugin.ChromaticAberration.Value;
    }
}