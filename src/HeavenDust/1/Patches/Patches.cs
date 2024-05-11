namespace HeavenDustOne.Patches;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Utils), nameof(Utils.OnChangeFullScreen))]
    public static bool Utils_OnChangeFullScreen()
    {
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, Plugin.FullScreenModeConfig.Value, Plugin.MaxRefresh);
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        
        var overlay = __instance.transform.Find("ImgMask");
        if (overlay)
        {
            overlay.gameObject.GetOrAddComponent<ImageToggler>();
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumetricFog), nameof(VolumetricFog.Update))]
    public static void VolumetricFog_Update(VolumetricFog __instance)
    {
        __instance.alpha = Plugin.FogOfWar.Value ? 0.9f : 0f;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VignetteAndChromaticAberration), nameof(VignetteAndChromaticAberration.OnRenderImage))]
    public static void VignetteAndChromaticAberration_OnRenderImage(VignetteAndChromaticAberration __instance)
    {
        __instance.intensity = Plugin.Vignette.Value ? 0.3f : 0f;
        __instance.chromaticAberration = Plugin.ChromaticAberration.Value ? -4f : 0f;
    }
}