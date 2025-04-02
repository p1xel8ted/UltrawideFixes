using System.Collections;
using CoreKeeper.Helpers;
using Pug.RP;

namespace CoreKeeper.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    private static void UpdateScalers()
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = Resolutions.CurrentAspect > Resolutions.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }



    [HarmonyPostfix]
    [HarmonyPatch(typeof(PugCamera), nameof(PugCamera.OnEnable))]
    public static void PugCamera_OnEnable(PugCamera __instance)
    {
        if (Plugin.MatchAspectRatio.Value)
        {
            __instance.SetPreferredOutputMode(OutputMode.MatchAspect);
        }
        else
        {
            __instance.SetPreferredOutputMode(OutputMode.Fixed);
            __instance.outputWidth = Plugin.CustomViewPortWidth.Value;
        }
        
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Awake))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Start))]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.Init))]
    public static void CameraManager_Start(CameraManager __instance)
    {
        __instance.cameraMovementStyle = CameraManager.CameraMovementStyle.Smooth;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadingScene), nameof(LoadingScene.ProgressiveLoader))]
    public static bool LoadingScene_ProgressiveLoader(LoadingScene __instance, ref IEnumerator __result)
    {
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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;
  
        CanvasScalers.Add(__instance);

        UpdateScalers();
    }
}