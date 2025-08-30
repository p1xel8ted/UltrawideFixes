namespace Sunderfolk;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    private static readonly List<CanvasScaler> Scalers = [];
    private static readonly Dictionary<int, Camera.GateFitMode> OriginalGateFits = new();

    internal static void UpdateAllCameras()
    {
        var cameras = Camera.allCameras.ToList();
        foreach (var cam in cameras)
        {
            UpdateCamera(cam);
        }
    }

    internal static void UpdateCanvasScalers()
    {
        var scalers = Scalers.ToList();
        foreach (var scaler in scalers)
        {
            ProcessScaler(scaler);
        }
    }

    private static void UpdateCamera(Camera cam)
    {
        if (!cam) return;
        
        var cameraID = cam.GetInstanceID();
        var gateFit = cam.gateFit;
        if (!OriginalGateFits.TryGetValue(cameraID, out var originalGateFit))
        {
            OriginalGateFits.Add(cameraID, gateFit);
            originalGateFit = gateFit;
        }


        cam.aspect = Plugin.CurrentAspect;
        cam.pixelRect = new Rect(0, 0, Plugin.CurrentWidth, Plugin.CurrentHeight);
        cam.rect = new Rect(0, 0, 1, 1);
        cam.gateFit = Plugin.CurrentAspect > Plugin.NativeAspect ? Camera.GateFitMode.Vertical : originalGateFit;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConstrainCameraAspectRatio), nameof(ConstrainCameraAspectRatio.OnEnable))]
    [HarmonyPatch(typeof(ConstrainCameraAspectRatio), nameof(ConstrainCameraAspectRatio.Awake))]
    public static void ConstrainCameraAspectRatio_OnEnable(ConstrainCameraAspectRatio __instance)
    {
        UpdateCamera(__instance.m_camera);
        UpdateCamera(__instance.m_clearCamera);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AbstractConstrainedAspectRatioSystem), nameof(AbstractConstrainedAspectRatioSystem.ClampToConstrainedAspectRatio))]
    public static void ConstrainedAspectRatioSystem_OnEnable(ref float __result)
    {
        __result = Plugin.CurrentAspect;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        __instance.aspectRatio = Plugin.CurrentAspect;
    }


    private static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Plugin.CurrentAspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }
}