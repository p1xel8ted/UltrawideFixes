namespace SorryWereClosed;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains(Sinai, StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.SetupSettingsMenu))]
    public static void SettingsMenu_SetupSettingsMenu(SettingsMenu __instance)
    {
        var visualSettingsButton = __instance.settingsButtons.FirstOrDefault(x => x.button.name == "Video Settings Button");
        if (visualSettingsButton != null)
        {
            var button = visualSettingsButton.button;
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => Plugin.ConfigurationManager.OpenWindow());
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.TriggerThirdPersonView))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.TriggerFirstPersonView))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.OnFirstPersonViewStart))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.EnableCameraLogic))]
    public static void CameraManager_Start(CameraManager __instance)
    {
        var cameras = Camera.allCameras;
        foreach (var cam in cameras)
        {
            cam.aspect = Plugin.MainAspect;
            cam.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
            cam.rect = new Rect(0, 0, 1, 1);
        }
    }
}