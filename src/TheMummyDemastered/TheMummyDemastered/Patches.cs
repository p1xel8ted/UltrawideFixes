using System.Linq;

namespace TheMummyDemastered;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), [typeof(int), typeof(int), typeof(bool), typeof(int)])]
    public static void Screen_SetResolution_WithRefresh(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        var w = DisplayMetrics.MainWidth;
        var h = DisplayMetrics.MainHeight;
        Plugin.Log.LogInfo($"Screen.SetResolution({width}x{height}, fs={fullscreen}, refresh={preferredRefreshRate}) -> ({w}x{h}, fs=true)");
        width = w;
        height = h;
        fullscreen = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), [typeof(int), typeof(int), typeof(bool)])]
    public static void Screen_SetResolution(ref int width, ref int height, ref bool fullscreen)
    {
        var w = DisplayMetrics.MainWidth;
        var h = DisplayMetrics.MainHeight;
        Plugin.Log.LogInfo($"Screen.SetResolution({width}x{height}, fs={fullscreen}) -> ({w}x{h}, fs=true)");
        width = w;
        height = h;
        fullscreen = true;
    }

    
    // Set to true while ProCamera2DRooms is clamping the view to fit a specific room
    // (either explicitly via ScaleCameraToFit/Zoom, or because the room is wider than our
    // display). While true, the orthoSize getter skips the PositiveScaleFactor multiplier
    // so the game's intended room framing isn't inflated past the room's bounds.
    private static bool s_roomConstrainingSize;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ProCamera2DRooms), nameof(ProCamera2DRooms.TransitionToRoom))]
    public static void ProCamera2DRooms_TransitionToRoom_Prefix(Room room)
    {
        if (room == null)
        {
            s_roomConstrainingSize = false;
            return;
        }

        var w = room.Dimensions.width;
        var h = room.Dimensions.height;
        var roomAspect = h > 0f ? w / h : 0f;
        var roomIsWide = roomAspect >= DisplayMetrics.NativeAspect;
        s_roomConstrainingSize = room.ScaleCameraToFit || room.Zoom || roomIsWide;

        Plugin.Log.LogInfo($"ProCamera2DRooms.TransitionToRoom: id='{room.ID}' dims={w:F2}x{h:F2} aspect={roomAspect:F3} scaleToFit={room.ScaleCameraToFit} zoom={room.Zoom} -> constraining={s_roomConstrainingSize}");
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ProCamera2DRooms), nameof(ProCamera2DRooms.ExitRoom))]
    public static void ProCamera2DRooms_ExitRoom_Prefix()
    {
        if (s_roomConstrainingSize)
        {
            Plugin.Log.LogInfo("ProCamera2DRooms.ExitRoom: clearing room-constraining flag");
        }
        s_roomConstrainingSize = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Getter)]
    public static void Camera_orthographicSize_Getter(Camera __instance, ref float __result)
    {
        if (s_roomConstrainingSize) return;
        __result *= DisplayMetrics.PositiveScaleFactor;
    }

    // Pillarbox every cinematic, not just the Quote intro. All cinematic controllers
    // derive from CinematicController and call base.Start(), so patching the base
    // covers the whole lineage (IntroCinematicController, EndCinematicController,
    // AhmanetIntroCinematic, BossScarabDeathCinematic, etc.) with a single hook.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinematicController), nameof(CinematicController.Start))]
    public static void CinematicController_Start(CinematicController __instance)
    {
        if (!DisplayMetrics.IsWiderThanNative) return;

        // Primary target: existing known path (preserves the original Quote-intro behavior).
        var panel = GameObject.Find("Canvas/MainPanel/Panel_1");
        if (panel)
        {
            ApplyPillarbox(panel, "Canvas/MainPanel/Panel_1");
            return;
        }

        // Fallback: scan every active Canvas in the scene and pillarbox its first
        // full-stretch direct child (the typical "full-screen cutscene frame").
        var canvases = UnityEngine.Object.FindObjectsOfType<Canvas>();
        Plugin.Log.LogInfo($"CinematicController.Start '{__instance.GetType().Name}' on '{__instance.name}': Canvas/MainPanel/Panel_1 not found, scanning {canvases.Length} canvas(es)");

        foreach (var canvas in canvases)
        {
            var canvasRt = canvas.transform as RectTransform;
            if (!canvasRt) continue;

            for (var i = 0; i < canvasRt.childCount; i++)
            {
                var child = canvasRt.GetChild(i) as RectTransform;
                if (!child) continue;
                if (!child.gameObject.activeInHierarchy) continue;

                var amin = child.anchorMin;
                var amax = child.anchorMax;
                var isFullStretch = amin.x <= 0.01f && amin.y <= 0.01f && amax.x >= 0.99f && amax.y >= 0.99f;
                if (!isFullStretch) continue;

                ApplyPillarbox(child.gameObject, $"{canvas.name}/{child.name}");
            }
        }
    }

    private static void ApplyPillarbox(GameObject go, string pathLabel)
    {
        if (!go) return;
        var existing = go.GetComponent<AspectRatioFitter>();
        if (existing != null)
        {
            Plugin.Log.LogInfo($"CinematicController.Start: '{pathLabel}' already has AspectRatioFitter (ratio={existing.aspectRatio:F4}) - skipping");
            return;
        }
        var arf = go.AddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.aspectRatio = DisplayMetrics.NativeAspect;
        Plugin.Log.LogInfo($"CinematicController.Start: added AspectRatioFitter to '{pathLabel}' with ratio {arf.aspectRatio:F4}");
    }

    // Diagnostic: log the RectTransform anchoring of every cinematic subtitle so we can
    // figure out why text escapes the 16:9 safe area on ultrawide. Once anchors are
    // known, this block gets replaced with the actual re-anchor fix.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinematicText), nameof(CinematicText.Start))]
    public static void CinematicText_Start(CinematicText __instance)
    {
        if (!__instance || !__instance.m_textComponent) return;

        var rt = __instance.m_textComponent.rectTransform;
        var path = BuildTransformPath(__instance.transform);
        var hasFitter = __instance.GetComponentInParent<AspectRatioFitter>() != null;

        Plugin.Log.LogInfo(
            $"CinematicText.Start '{__instance.name}': " +
            $"anchorMin={rt.anchorMin} anchorMax={rt.anchorMax} pivot={rt.pivot} " +
            $"anchoredPos={rt.anchoredPosition} sizeDelta={rt.sizeDelta} " +
            $"alignment={__instance.m_textComponent.alignment} " +
            $"parentHasFitter={hasFitter} " +
            $"path='{path}'");
    }

    private static string BuildTransformPath(Transform t)
    {
        if (!t) return "<null>";
        var names = new List<string>();
        var cur = t;
        while (cur)
        {
            names.Add(cur.name);
            cur = cur.parent;
        }
        names.Reverse();
        return string.Join("/", names.ToArray());
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.Start))]
    public static bool SplashScreen_Start_Prefix(SplashScreen __instance)
    {
        Plugin.Log.LogInfo($"SplashScreen.Start '{__instance.name}' prefix: bypassing splash, going to '{__instance.NextScene}'.");
        DynamicAssets.PreloadBundle("startup");
        SceneLoader.GotoScene(__instance.NextScene, string.Empty, Vector2.zero, 1f, 0f);
        Transition.Snap();
        return false;
    }

    // UI scaling. Expand keeps UI anchored to the 16:9 safe area on ultrawide instead of stretching it horizontally.
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.screenMatchMode == CanvasScaler.ScreenMatchMode.Expand) return;

        Plugin.Log.LogInfo($"CanvasScaler '{__instance.name}': screenMatchMode {__instance.screenMatchMode} -> Expand");

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    // Hud.FixedUpdate writes localPosition every frame as m_*BasePos + slide-in offset. Set the base
    // positions to the manually-dialed-in targets: X stays on the 16:9 inner column, Y pushed to the
    // canvas top/bottom edges (canvas ref is 480x270, so ±130 is 5 units from each horizontal edge).
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Hud), nameof(Hud.Start))]
    public static void Hud_Start(Hud __instance)
    {
        __instance.m_healthBasePos = new Vector2(-230f, 130f);
        __instance.m_weaponsBasePos = new Vector2(219f, 130f);
        __instance.m_minimapBasePos = new Vector2(219f, -130f);

        Plugin.Log.LogInfo($"Hud.Start: Health={__instance.m_healthBasePos} Weapons={__instance.m_weaponsBasePos} MiniMap={__instance.m_minimapBasePos}");
    }

    // Allow cinematic hide calls through, but ignore other callers' setMinimapVisible(false) — those
    // are keeping enterT.targetPos at 0 in scenes where the minimap should be visible with the new basePos.
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Hud), nameof(Hud.setMinimapVisible))]
    public static bool Hud_setMinimapVisible_Prefix(ref bool bVisible)
    {
        if (bVisible) return true;

        var frames = new System.Diagnostics.StackTrace(1, false).GetFrames();
        var fromCinematic = frames != null && frames.Any(f =>
        {
            var t = f.GetMethod()?.DeclaringType;
            return t != null && (t.Name.Contains("Cinematic") || t.FullName.Contains("Cinematic"));
        });

        if (fromCinematic) return true; // let cinematics hide it

        Plugin.Log.LogInfo("Hud.setMinimapVisible(false) skipped (not from cinematic)");
        return false; // skip original method; leave enterT.targetPos alone
    }

}