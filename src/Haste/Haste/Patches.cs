namespace Haste;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void PostProcessVolume_OnEnable(PostProcessVolume __instance)
    {
        Volumes.UpdateVolumes();
    }


    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CutsceneBorderPost), nameof(CutsceneBorderPost.OnRenderImage))]
    public static void CutsceneBorderPost_OnRenderImage(CutsceneBorderPost __instance)
    {
        __instance.enabled = false;
    }


    [HarmonyFinalizer]
    [HarmonyPatch(typeof(JiggleBone), nameof(JiggleBone.LateLateUpdate))]
    [HarmonyPatch(typeof(LateLateUpdateCaller), nameof(LateLateUpdateCaller.LateUpdate))]
    [HarmonyPatch(typeof(LookAtPlayer), nameof(LookAtPlayer.LateUpdate))]
    [HarmonyPatch(typeof(LevelSelectionNode), nameof(LevelSelectionNode.UpdateMaterialProperties))]
    [HarmonyPatch(typeof(LevelSelectionNode), nameof(LevelSelectionNode.Update))]
    [HarmonyPatch(typeof(Portal), nameof(Portal.Update))]
    [HarmonyPatch(typeof(SlowStep), nameof(SlowStep.OnEnable))]
    public static Exception ExceptionSpamSuppress()
    {
        return null;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        if (__instance.name.Contains("MessageCanvas")) return;

        CanvasScalers.Add(__instance);
        
        UpdateScalers(Plugin.CurrentAspect);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameplayUIManager), nameof(GameplayUIManager.Start))]
    public static void GameplayUIManager_Start(GameplayUIManager __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraMovement), nameof(CameraMovement.Update))]
    public static void CameraMovement_Update(CameraMovement __instance)
    {
        if (Plugin.CameraFieldOfView.Value == 0)
        {
            Plugin.CameraFieldOfView.Value = 1f;
        }

        __instance.cam.cam.fieldOfView *= Plugin.CameraFieldOfView.Value;
    }
}