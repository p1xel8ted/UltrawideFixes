namespace CARIMARA_BTFL.Patches;

/// <summary>
/// Harmony patches for managing post-processing effects and volumes.
/// </summary>
[Harmony]
public static class PostProcessingPatches
{
    internal static bool ConfigDirty;

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessEffectSettings), nameof(PostProcessEffectSettings.OnEnable))]
    public static void PostProcessProfile_OnEnable(PostProcessEffectSettings __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    /// <summary>
    /// Applies user config settings AFTER Unity finishes blending volumes.
    /// This runs every frame and ensures your settings persist.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.UpdateVolumeSystem))]
    public static void PostProcessLayer_UpdateVolumeSystem_Post(PostProcessLayer __instance)
    {
        if (!ConfigDirty) return;
        ConfigDirty = false;

        // Update AA settings
        Volumes.UpdateAntialiasing();

        // Force update all active effects in this layer
        var volumes = __instance.volumeTrigger.GetComponentsInChildren<PostProcessVolume>();
        foreach (var volume in volumes)
        {
            foreach (var effect in volume.profile.settings)
            {
                Volumes.UpdateSingleVolume(effect);
            }
        }
    }
}
