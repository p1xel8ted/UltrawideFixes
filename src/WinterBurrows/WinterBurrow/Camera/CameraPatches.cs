using WinterBurrow.Core.Configuration;

namespace WinterBurrow.Camera;

[Harmony]
public static class CameraPatches
{
    private static float _cachedFovMultiplier = 1.0f;
    private static bool _isFovDefault = true;

    /// <summary>
    /// Initializes the FoV cache with the current configuration value.
    /// </summary>
    internal static void Initialize()
    {
        UpdateFovCache();
    }

    /// <summary>
    /// Subscribes to FoV configuration changes to keep the cache in sync.
    /// </summary>
    internal static void SubscribeToFovChanges()
    {
        FoVConfig.FieldOfViewMultiplier.SettingChanged += (_, _) => UpdateFovCache();
    }

    /// <summary>
    /// Updates the cached FoV multiplier and default flag.
    /// </summary>
    private static void UpdateFovCache()
    {
        _cachedFovMultiplier = FoVConfig.FieldOfViewMultiplier.Value;
        _isFovDefault = Mathf.Approximately(_cachedFovMultiplier, 1.0f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.PushStateToUnityCamera))]
    public static void CinemachineBrain_PushStateToUnityCamera(CinemachineBrain __instance, CameraState state)
    {
        var outputCamera = __instance.OutputCamera;
        if (outputCamera)
        {
            outputCamera.fieldOfView = _isFovDefault
                ? state.Lens.FieldOfView
                : state.Lens.FieldOfView * _cachedFovMultiplier;
        }
    }
}