namespace Lunacid;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.Update))]
    public static void PostProcessVolume_Update(ref PostProcessVolume __instance)
    {
        var ap = __instance.profile;
        ap.TryGetSettings(out ScreenSpaceReflections ssr);
        if (ssr)
        {
            ssr.resolution.value = ScreenSpaceReflectionResolution.FullSize;
            ssr.preset.value = ScreenSpaceReflectionPreset.Ultra;
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.UpdateVolumeSystem))]
    public static void PostProcessLayer_UpdateVolumeSystem(ref PostProcessLayer __instance)
    {
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.Init))]
    public static void PostProcessLayer_Init(ref PostProcessLayer __instance)
    {
        __instance.gameObject.TryGetComponent(out PostProcessVolume volume);
        if (!volume)
        {
            volume = __instance.gameObject.AddComponent<PostProcessVolume>();
        }
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;

        var ap = volume.profile;
        ap.TryGetSettings(out ScreenSpaceReflections ssr);
        if (!ssr)
        {
            ssr = ScriptableObject.CreateInstance<ScreenSpaceReflections>();
            ap.AddSettings(ssr);
            ssr.active = true;
        }

        ssr.resolution.value = ScreenSpaceReflectionResolution.FullSize;
        ssr.preset.value = ScreenSpaceReflectionPreset.Ultra;
    }

}