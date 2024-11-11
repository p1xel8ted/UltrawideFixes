using System.Reflection.Emit;

namespace TheMessenger;

[Harmony]
public static class Patches
{
    private static readonly List<Action> OnResolutionUpdate = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InGameHud), nameof(InGameHud.Start))]
    [HarmonyPatch(typeof(InGameHud), nameof(InGameHud.ShowHud))]
    public static void InGameHud_OnEnable(InGameHud __instance)
    {
        var hud1Bg = __instance.hud_8.transform.Find("Background");
        if (hud1Bg)
        {
            var img = hud1Bg.GetComponent<Image>();
            if (img)
            {
                img.color = img.color with { a = 0.25f };
            }
        }

        var hud2Bg = __instance.hud_16.transform.Find("Background");
        if (hud2Bg)
        {
            var img = hud2Bg.GetComponent<Image>();
            if (img)
            {
                img.color = img.color with { a = 0.25f };
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(RoomBackground), nameof(RoomBackground.Awake))]
    [HarmonyPatch(typeof(RoomBackground), nameof(RoomBackground.OnEnterPool))]
    public static void RoomBackground_OnEnable(RoomBackground __instance)
    {
        __instance.transform.localScale = __instance.transform.localScale with { x = 1.1f, y = 1.1f };
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        var cinematic = __instance.GetComponent<CinematicBordersScreen>();
        if (cinematic)
        {
            var images = cinematic.GetComponentsInChildren<Image>();
            foreach (var img in images)
            {
                img.maskable = false;
                img.RecalculateMasking();
            }

            var top = cinematic.transform.Find("TopBorder");
            if (top)
            {
                top.transform.localScale = top.transform.localScale with { x = Plugin.PositiveScaleFactor };
            }

            var bottom = cinematic.transform.Find("BottomBorder");
            if (bottom)
            {
                bottom.transform.localScale = bottom.transform.localScale with { x = Plugin.PositiveScaleFactor };
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(View), nameof(View.Init))]
    public static void View_Init(ref View __instance)
    {
        Plugin.UpdateCameras();
    }

    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SpawnZone), nameof(SpawnZone.Update))]
    private static bool SpawnZone_Update(SpawnZone __instance)
    {
        __instance.delayToNextSpawn -= Time.deltaTime;
        if (__instance.delayToNextSpawn <= 0f)
        {
            __instance.SpawnObject();
            __instance.delayToNextSpawn = __instance.spawnInterval;
        }

        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(View), nameof(View.OnOutDone))]
    public static void View_OnOutDone(ref View __instance)
    {
        Plugin.UpdateCameras();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResolutionManager), "add_onResolutionUpdate")]
    public static void ResolutionManager_add_onResolutionUpdate(Action value)
    {
        OnResolutionUpdate.Add(value);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResolutionManager), nameof(ResolutionManager.UpdateResolution))]
    public static void ResolutionManager_UpdateResolution(ref ResolutionManager __instance)
    {
        var resVector = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        __instance.currentResolution = resVector;
        __instance.currentRenderResolution = resVector;
        foreach (var action in OnResolutionUpdate)
        {
            action?.Invoke();
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RetroCamera), nameof(RetroCamera.Awake))]
    public static void RetroCamera_Awake(ref RetroCamera __instance)
    {
        var y = __instance.spawnZone.size.y;
        var newX = y * Plugin.MainAspectRatio;
        __instance.spawnZone.size = new Vector2(newX, y);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ObjectSpawner), nameof(ObjectSpawner.IsInCamView))]
    [HarmonyPatch(typeof(ObjectSpawner), nameof(ObjectSpawner.CanSpawn))]
    private static void ObjectSpawner_IsInCamView(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ObjectSpawner), nameof(ObjectSpawner.OnEnterRoom))]
    private static void ObjectSpawner_OnEnterRoom(ObjectSpawner __instance)
    {
        __instance.spawnOnlyOnceWhileInRoom = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ObjectSpawner), nameof(ObjectSpawner.Update))]
    private static bool UpdatePatch_Update(ObjectSpawner __instance)
    {
        // Ensure spawning only when active and in SPAWN_WHEN_VISIBLE mode
        if (__instance.active && __instance.spawnMode == ObjectSpawner.ESpawnMode.SPAWN_WHEN_VISIBLE)
        {
            // Check if spawning is possible without room/camera view checks
            if (__instance.spawnedObject == null && (__instance.triggerConditions == null || __instance.triggerConditions.IsTrue()))
            {
                __instance.Spawn();
            }
        }

        // Return false to skip the original Update method logic
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OutOfViewDetector), nameof(OutOfViewDetector.Update))]
    public static void OutOfViewDetector_Update(OutOfViewDetector __instance)
    {
        __instance.ForceAsVisible();
    }

    private static readonly Vector3 Offset = new(0, 3, -40);

    [HarmonyPostfix]
    [HarmonyPatch(typeof(RetroCamera), nameof(RetroCamera.LateUpdate))]
    public static void RetroCamera_ChangeScreen(ref RetroCamera __instance)
    {
        __instance.ForceUpdate = true;
        __instance.allowScreenChange = true;
        __instance.ForceScreenChange = true;
        var desiredPosition = __instance.playerCtrl.transform.position + Offset;
        __instance.camera.transform.position = desiredPosition;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.Start))]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.ResizeCamera))]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.UpdateResolution))]
    public static void CameraResizer_Start(ref CameraResizer __instance)
    {
        __instance.cam.aspect = Plugin.MainAspectRatio;
        __instance.cam.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);

        var backgroundMask = __instance.transform.Find("BackgroundMaskLayer");
        if (backgroundMask)
        {
            backgroundMask.transform.localScale = backgroundMask.transform.localScale with { x = Plugin.PositiveScaleFactor };
        }

        if (__instance.name == "ShopCamera")
        {
            var sky = __instance.transform.Find("Asset_Sky");
            if (sky)
            {
                sky.transform.localScale = sky.transform.localScale with { x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor };
            }
        }
    }
}