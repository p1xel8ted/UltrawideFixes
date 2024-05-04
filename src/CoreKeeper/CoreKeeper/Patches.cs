namespace CoreKeeper;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Awake))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Start))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Init))]
    public static void CameraManager_Start(CameraManager __instance)
    {
        __instance.cameraMovementStyle = CameraManager.CameraMovementStyle.SMOOTH;
        __instance.cameraFiltering = CameraManager.CameraFiltering.FILTER_DYNAMIC;
    }

    //this stops the tiles being removed as the player moves around
    //not sure of the performance implications of this
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SinglePugMap), nameof(SinglePugMap._ClearTileOfTypeAndTileset))]
    public static bool SinglePugMap__ClearTileOfTypeAndTileset()
    {
        return !Plugin.DontDestroyTiles.Value;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadingScene), nameof(LoadingScene.Awake))]
    public static bool LoadingScene_Start(ref LoadingScene __instance)
    {
        if (!Plugin.SkipSplashScreens.Value) return true;
        Manager.InitializeGlobalManager();
        Manager.load.LoadSceneImmediately(new LoadManager.LoadingQueueEntry("Title", 0f, 0f, FadePresets.blackToBlack, 0), false);
        return false;
    }
}