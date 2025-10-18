// ReSharper disable InconsistentNaming

namespace ImmortalLegacyTheJadeCipher.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];


    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Resolutions.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
            Plugin.Log.LogInfo($"Updated CanvasScaler '{scaler.name}' (ID: {scaler.GetInstanceID()}): ScreenMatchMode={scaler.screenMatchMode}");
        }
    }

    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConsoleUiCanvasCamera), nameof(ConsoleUiCanvasCamera.Awake))]
    public static void ConsoleUiCanvasCamera_Awake(ConsoleUiCanvasCamera __instance)
    {
        __instance.collectionViewBackground.TryAddComponent<AspectRatioFitter>();
        __instance.inventoryBackground.gameObject.TryAddComponent<AspectRatioFitter>();
        __instance.uiCamera.TryAddComponent<AspectRatioFitter>();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        __instance.aspectRatio = Resolutions.CurrentAspect;
    }

    private static readonly string[] IgnoreTheseCameras = [""];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.PushStateToUnityCamera))]
    public static void CinemachineBrain_PushStateToUnityCamera(CinemachineBrain __instance, CameraState state)
    {
        if (IgnoreTheseCameras.Contains(__instance.name)) return;

        var outputCamera = __instance.OutputCamera;
        if (outputCamera)
        {
            outputCamera.fieldOfView = state.Lens.FieldOfView * ConfigManager.GameCameraFieldOfViewMultiplier.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register), typeof(Volume), typeof(int))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.OnEnable))]
    public static void PostProcessLayer_OnEnable(PostProcessLayer __instance)
    {
        Volumes.UpdateSingleAntialiasing(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Cursor), nameof(Cursor.lockState), MethodType.Setter)]
    public static void Cursor_LockState_Setter(CursorLockMode value)
    {
        Cursor.visible = value != CursorLockMode.Locked;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessEffectSettings), nameof(PostProcessEffectSettings.OnEnable))]
    public static void PostProcessProfile_OnEnable(PostProcessEffectSettings __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Resolutions.CurrentAspect);
    }
}