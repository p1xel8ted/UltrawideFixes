namespace TheMessenger;

[Harmony]
public static class Patches
{
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

    private static RichPresenceDiscord RichPresenceDiscordInstance { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(RichPresenceDiscord), nameof(RichPresenceDiscord.Init))]
    [HarmonyPatch(typeof(RichPresenceDiscord), nameof(RichPresenceDiscord.Update))]
    public static void RichPresenceDiscord_Init(RichPresenceDiscord __instance)
    {
        RichPresenceDiscordInstance = __instance;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.ResizeCamera))]
    public static bool CameraResizer_ResizeCamera(ref CameraResizer __instance)
    {
        return false;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(View), nameof(View.Init))]
    public static void View_Init(ref View __instance)
    {
        Plugin.UpdateCameras();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(View), nameof(View.OnOutDone))]
    public static void View_OnOutDone(ref View __instance)
    {
        Plugin.UpdateCameras();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.Start))]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.ResizeCamera))]
    [HarmonyPatch(typeof(CameraResizer), nameof(CameraResizer.UpdateResolution))]
    public static void CameraResizer_Start(ref CameraResizer __instance)
    {
        __instance.cameraRect = new Rect(0, 0, 1, 1);

        var backgroundMask = __instance.transform.Find("BackgroundMaskLayer");
        if (backgroundMask)
        {
            backgroundMask.transform.localScale = backgroundMask.transform.localScale with { x = Plugin.PositiveScaleFactor };
        }
    }
}