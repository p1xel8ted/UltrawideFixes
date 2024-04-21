namespace TerraMemoriaUltraWide;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Pillarboxes), nameof(Pillarboxes.Awake))]
    [HarmonyPatch(typeof(Pillarboxes), nameof(Pillarboxes.Refresh))]
    public static void Pillarboxes_Awake(ref Pillarboxes __instance)
    {
        if (!Plugin.UltraWideFixes.Value) return;
        __instance?.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TimelineContainer), nameof(TimelineContainer.OnEnable))]
    public static void TimelineContainer_Start(ref TimelineContainer __instance)
    {
        if (!Plugin.UltraWideFixes.Value) return;
        var newX = Plugin.MainWidth / 2f + Plugin.AspectDifference;
        __instance.transform.parent.position = __instance.transform.parent.position with {x = newX};
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraRationizerManager), nameof(CameraRationizerManager.Init))]
    public static void CameraRationizerManager_Init(ref CameraRationizerManager __instance)
    {
        if (!Plugin.UltraWideFixes.Value) return;
        __instance._minAuthorizedRatio = Plugin.MainAspectRatio;
        __instance._maxAuthorizedRatio = Plugin.MainAspectRatio;
        __instance._currentViewportMode = CameraRationizerManager.ViewportMode.Unrestricted;
        __instance.ForceRefresh();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AmbientManager), nameof(AmbientManager.Update))]
    public static void AmbientManager_Update(ref AmbientManager __instance)
    {
        Plugin.UpdateVolumeProfiles();
        __instance.DepthOfFieldEnabled = Plugin.DepthOfField.Value;
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(ref CinemachineVirtualCamera __instance)
    {
        Plugin.VirtualCameras.TryAdd(__instance, __instance.m_Lens.FieldOfView);

        if (!Plugin.VirtualCameras.TryGetValue(__instance, out var fov)) return;
        
        if (Plugin.ModifyFieldOfView.Value)
        {
            __instance.m_Lens = __instance.m_Lens with {FieldOfView = Plugin.FieldOfViewValue.Value + fov};
        }
        else
        {
            __instance.m_Lens = __instance.m_Lens with {FieldOfView = fov}; 
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCameraBase), nameof(CinemachineVirtualCameraBase.Update))]
    public static void CinemachineVirtualCameraBase_Update(ref CinemachineVirtualCameraBase __instance)
    {
        if (__instance is CinemachineVirtualCamera cvc)
        {
            var cam = Plugin.VirtualCameras.TryGetValue(cvc, out var fov);
            if (cam)
            {
                if (Plugin.ModifyFieldOfView.Value)
                {
                    cvc.m_Lens = cvc.m_Lens with {FieldOfView = Plugin.FieldOfViewValue.Value + fov};
                }
                else
                {
                    cvc.m_Lens = cvc.m_Lens with {FieldOfView = fov};
                }
            }
        }
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (!Plugin.UltraWideFixes.Value) return;
        
        Plugin.OriginalScreenMatchModes.TryAdd(__instance, __instance.screenMatchMode);

        __instance.screenMatchMode = Plugin.AdjustUIScalingBehaviour.Value ? CanvasScaler.ScreenMatchMode.Expand : Plugin.OriginalScreenMatchModes[__instance];
    }
}