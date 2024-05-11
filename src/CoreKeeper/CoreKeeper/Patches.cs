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


    // private static Dictionary<int, List<SendClientSubMapToPugMapSystem.TileUpdate>> GroupTilesByY(NativeArray<SendClientSubMapToPugMapSystem.TileUpdate> tileUpdates)
    // {
    //     // Group by 'pos.y' and convert to dictionary
    //     return tileUpdates
    //         .GroupBy(tile => tile.pos.y)
    //         .ToDictionary(group => group.Key, group => group.ToList());
    // }


    //this sort of works, not really
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(SendClientSubMapToPugMapSystem), nameof(SendClientSubMapToPugMapSystem.Apply))]
    // public static void SendClientSubMapToPugMapSystem_Apply(SendClientSubMapToPugMapSystem __instance)
    // {
    //     if (__instance.tileUpdates.Length <= 0) return;
    //     var data = __instance.tileUpdates.ToArray(Allocator.Temp);
    //     var groupedTiles = GroupTilesByY(data);
    //
    //     foreach (var (y, tiles) in groupedTiles)
    //     {
    //         //find max x in tiles
    //         var start = tiles.Max(tile => tile.pos.x) + 1;
    //         var end = start + 20;
    //         for (var i = start; i < end; i++)
    //         {
    //             var tile = tiles.FirstOrDefault(t => t.pos.x == start - 1 && t.pos.y == y);
    //             var pos = new int2(Manager.camera.RenderOrigo.ToInt2().x + i, y);
    //             var tileType = tile.tileType;
    //             var tileset = tile.tileset;
    //             __instance.AddTileOverride(pos, tileset, tileType);
    //         }
    //     }
    // }
    
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