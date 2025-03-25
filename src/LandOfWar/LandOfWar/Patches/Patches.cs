using UnityEngine.Rendering.HighDefinition;

namespace LandOfWar.Patches;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateVolumes();
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(Camera), nameof(Camera.fieldOfView), MethodType.Setter)]
    // public static void Camera_fieldOfView(Camera __instance, ref float value)
    // {
    //     var stackFrame = new System.Diagnostics.StackTrace().GetFrame(2);
    //     if (stackFrame != null)
    //     {
    //         var method = stackFrame.GetMethod();
    //         var decType = method.DeclaringType;
    //         Plugin.Log.LogWarning($"Camera.fieldOfView Setter: {decType?.Name}.{method.Name}, {value}");
    //     }
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.UpdateFieldOfView))]
    public static void CameraController_UpdateFieldOfView_Postfix(CameraController __instance)
    {
        if (IgnoreTheseCameras.Contains(__instance.name)) return;

        var fov = __instance.currentLimitsSettings.fov * Plugin.GameCameraFieldOfViewMultiplier.Value;
        __instance.virtualCamera.m_Lens.FieldOfView = fov;
        PlayerManager.Instance.baseCamera.fieldOfView = fov;
    }

    private static readonly string[] IgnoreTheseCameras = [""];


    [HarmonyPostfix]
    [HarmonyPatch(typeof(InGameGraficSettings), nameof(InGameGraficSettings.ApplyResolution))]
    [HarmonyPatch(typeof(SettingsGraphics), nameof(SettingsGraphics.ApplyResolution))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Resolution_Change()
    {
        Plugin.UpdateCameraGateFit();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineBrain), nameof(CinemachineBrain.PushStateToUnityCamera))]
    public static void CinemachineBrain_PushStateToUnityCamera(CinemachineBrain __instance, CameraState state)
    {
        if (IgnoreTheseCameras.Contains(__instance.name)) return;
        
        var outputCamera = __instance.OutputCamera;
        if (outputCamera)
        {
            outputCamera.fieldOfView = state.Lens.FieldOfView * Plugin.GameCameraFieldOfViewMultiplier.Value;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayerController), nameof(VideoPlayerController.Awake))]
    public static bool VideoPlayerController_Awake(VideoPlayerController __instance)
    {
        Cursor.lockState = CursorLockMode.None;
        CursorHandler.Instance.Visible = false;
        PlayerPrefs.SetString("mapToLoad", "MainMenu");
        SceneManager.LoadScene("MapLoader");
        return false;
    }
}