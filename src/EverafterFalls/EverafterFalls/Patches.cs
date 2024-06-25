namespace EverafterFalls;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        UpdaterScaler(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsScreen), nameof(SettingsScreen.triggerAllSettings))]
    public static void SettingsScreen_triggerAllSettings(SettingsScreen __instance)
    {
        Plugin.UpdateZoom();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsManager), nameof(GraphicsManager.updateVsync))]
    public static void GraphicsManager_updateVsync(int value)
    {
        if (value == 1)
        {
            QualitySettings.vSyncCount = 1;
            Application.targetFrameRate = Plugin.MaxRefresh;
            return;
        }

        Application.targetFrameRate = -1;
        QualitySettings.vSyncCount = 0;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(MultiplayerSplitCameraRig), nameof(MultiplayerSplitCameraRig.OnMMEvent))]
    [HarmonyPatch(typeof(MultiplayerSplitCameraRig), nameof(MultiplayerSplitCameraRig.setCameraMode))]
    public static void MultiplayerSplitCameraRig_OnMMEvent(MultiplayerSplitCameraRig __instance)
    {
        __instance.cameraZooms = [22f, 26f, 33f, 43f, 56f, 72f];
        __instance.cameraZoomCustscene = __instance.cameraZooms[Plugin.CutsceneCameraZoom.Value];
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SQLevelManager), nameof(SQLevelManager.SpawnPlayerAndPetAtBed))]
    [HarmonyPatch(typeof(SQLevelManager), nameof(SQLevelManager.spawnPlayerAtCheckpoint))]
    public static void SQLevelManager_spawnPlayerAtCheckpoint(SQLevelManager __instance)
    {
        Plugin.UpdateZoom();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SQLevelManager), nameof(SQLevelManager.lateNewDayFunctions3))]
    public static void SQLevelManager_lateNewDayFunctions3(SQLevelManager __instance)
    {
        Plugin.UpdateZoom();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.getZoomValueSetting))]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.setDefaultValues))]
    public static void SettingsManager_setDefaultValues(SettingsManager __instance)
    {
        __instance.zoomValues = [18f, 23f, 28f, 33f, 38f, 43f];
    }

    private static void UpdaterScaler(CanvasScaler scaler)
    {
        if (scaler.name.Contains("sinai")) return;
        scaler.uiScaleMode = Plugin.ScaleMode.Value;
        scaler.screenMatchMode = Plugin.ScreenMatchMode.Value;

        if (scaler.uiScaleMode != CanvasScaler.ScaleMode.ConstantPixelSize) return;

        scaler.scaleFactor = Plugin.ScaleFactor.Value;

        scaler.scaleFactor = scaler.name switch
        {
            "Player1" or "Player2" => Plugin.ActionBarScaleFactor.Value,
            "SharedHUD" => Plugin.HUDScaleFactor.Value,
            _ => Plugin.ScaleFactor.Value
        };
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    public static void CanvasScaler_Handle(CanvasScaler __instance)
    {
        UpdaterScaler(__instance);
    }
}