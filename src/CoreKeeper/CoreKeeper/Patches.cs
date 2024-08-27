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
        __instance.cameraMovementStyle = CameraManager.CameraMovementStyle.Smooth;
    }

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
    [HarmonyPatch(typeof(LoadingScene), nameof(LoadingScene.ProgressiveLoader))]
    public static bool LoadingScene_ProgressiveLoader(LoadingScene __instance, ref IEnumerator __result)
    {
        if (!Plugin.SkipSplashScreens.Value) return true;
        __result = SkipLogos(__instance);
        return false;
    }

    private static IEnumerator SkipLogos(LoadingScene loadingScene)
    {
        if (loadingScene._slowLoading)
        {
            yield return Yielders.Pause(0.2f);
        }
        yield return Yielders.WaitForEndOfFrame();
        yield return Yielders.WaitForEndOfFrame();

        if (loadingScene._slowLoading)
        {
            yield return Manager.InitializeGlobalManager(true);
        }
        else
        {
            Manager.ExecuteIEnumeratorInstantly(Manager.InitializeGlobalManager());
        }
        loadingScene.sceneHandler.gameObject.SetActive(true);
        loadingScene.initialCamera.gameObject.SetActive(false);
        int num;
        for (var i = 0; i < 5; i = num + 1)
        {
            yield return Yielders.WaitForEndOfFrame();
            num = i;
        }
        loadingScene.HideLoadingLogo();
        yield return new WaitForSecondsRealtime(0.5f);
        if (CommandLineArgs.Has("-benchmark"))
        {
            Manager.load.QueueScene("Benchmark", 0f, 0f, FadePresets.cut);
            yield break;
        }
        Manager.load.QueueScene(loadingScene.sceneToLoad, 0f, 0f, FadePresets.blackToBlack);
    }

}