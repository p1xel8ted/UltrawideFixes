using System.Collections.Generic;
using Rewired.Utils.Classes.Utility;
using Unity.Mathematics;

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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MultiPugMap), nameof(MultiPugMap.GetMapsCloseToPosition))]
    public static void MultiPugMap_GetMapsCloseToPosition(MultiPugMap __instance, ref int2 position, ref List<SinglePugMap> maps, ref List<int2> localPositions)
    {
        Plugin.Log.LogWarning($"MultiPugMap.GetMapsCloseToPosition, position: {position}");
        maps.Clear();
        localPositions.Clear();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MultiPugMap), nameof(MultiPugMap.SetTile))]
    public static bool MultiPugMap_SetTile(MultiPugMap __instance, int2 worldPosition, int tileset, TileType tileType, int state = 0)
    {
        List<SinglePugMap> list;
        List<int2> list2;
        __instance.GetMapsCloseToPosition(worldPosition, out list, out list2);
        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetHiddenTile(list2[i], tileset, tileType, state);
        }
Plugin.Log.LogWarning($"MultiPugMap.SetTile, worldPosition: {worldPosition}, tileset: {tileset}, tileType: {tileType}, state: {state}");
        __instance.GetMapAtPosition(worldPosition, true).SetTile(__instance.ToLocal(worldPosition), tileset, tileType, state);
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SinglePugMap), nameof(SinglePugMap.SetTile))]
    public static bool SendClientSubMapToPugMapSystem_OnEnable(SinglePugMap __instance, int2 worldPosition, int tileset, TileType tileType, int state = 0)
    {
        int2 @int = (Application.isPlaying ? Manager.camera.RenderOrigo.ToInt2() : int2.zero);
        if (math.lengthsq(worldPosition - @int) > 22500f)
        {
            Plugin.Log.LogWarning($"Ignoring tile at {worldPosition} because it's too far away from the camera.");
            return true;
        }

        __instance.setTileRequests.Add(new SinglePugMap.TileChangeRequest
        {
            WorldPosition = worldPosition,
            Tile = new TileInfo
            {
                tileset = tileset,
                tileType = tileType,
                state = state
            },
            Add = true
        });
        Plugin.Log.LogWarning($"SinglePugMap.SetTile, worldPosition: {worldPosition}, tileset: {tileset}, tileType: {tileType}, state: {state}");
        return false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(SinglePugMap), nameof(SinglePugMap._SetTile))]
    private static bool SinglePugMap__SetTile(SinglePugMap __instance, int2 worldPosition, int tileset, TileType tileType, int state = 0)
    {
        if (Application.isPlaying && tileType.ShouldRerenderLights())
        {
            Manager.lights.UpdateShadowsAtTilePosition(worldPosition);
        }

        PugMapLayer2 pugMapLayer = __instance.EnsureLayerPresent(tileset, TileTypeToLayerName.GetLayerName(tileType));
        if (pugMapLayer == null)
        {
            Debug.LogError("no such tileset/type");
            return true;
        }

        if (pugMapLayer.quadGenerator.isDataLayer)
        {
            var instanceLayerDataUpdate = __instance.layerDataUpdates[pugMapLayer.layerDataLookupKey];
            instanceLayerDataUpdate[worldPosition] = state;
            __instance.layerDataUpdatesDirty[pugMapLayer.layerDataLookupKey] = true;
            for (int i = 0; i < pugMapLayer.extraDependentLayers.Count; i++)
            {
                int layerDataLookupKey = pugMapLayer.extraDependentLayers[i].layerDataLookupKey;
                __instance.layerDataUpdates[layerDataLookupKey].TryAdd(worldPosition, -2);
                __instance.layerDataUpdatesDirty[layerDataLookupKey] = true;
            }
        }

        Plugin.Log.LogWarning($"SinglePugMap._SetTile, worldPosition: {worldPosition}, tileset: {tileset}, tileType: {tileType}, state: {state}");
        return false;
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