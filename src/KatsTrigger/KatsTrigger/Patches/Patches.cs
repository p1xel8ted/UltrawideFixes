namespace KatsTrigger.Patches;

[Harmony]
public static class Patches
{
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

        scaler.screenMatchMode = Plugin.MainAspect > Plugin.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        __instance.refResolutionX = Mathf.RoundToInt(__instance.refResolutionY * Plugin.CurrentAspectRatio);
        Plugin.Logger.LogInfo($"PixelPerfectCamera '{__instance.name}' adjusted: {__instance.refResolutionX}x{__instance.refResolutionY}");
        var camera = __instance.GetComponent<Camera>();
        if (camera)
        {
            camera.aspect = Plugin.CurrentAspectRatio;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
            Plugin.Logger.LogInfo($"Camera '{camera.name}' aspect adjusted: {camera.aspect} Rect: {camera.rect} PixelRect: {camera.pixelRect}");
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }
}