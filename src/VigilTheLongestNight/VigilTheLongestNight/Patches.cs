using VigilTheLongestNight.HUD;

#pragma warning disable CS0618 // Type or member is obsolete
namespace VigilTheLongestNight;

[Harmony]
public static class Patches
{
    private static readonly string[] BackgroundsToScale =
    [
        "BG",
        "whitebox",
        "BlackMask",
        "MASK"
    ];

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    private static readonly WriteOnce<float> OriginalX = new();
    private static readonly WriteOnce<float> OriginalY = new();

    private static GameObject LeftHud { get; set; }
    private static GameObject RightHud { get; set; }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(LayerScroller), nameof(LayerScroller.Start))]
    public static void LayerScroller_Start(ref LayerScroller __instance)
    {
        Plugin.UpdateComponents();

        foreach (var background in BackgroundsToScale)
        {
            var bg = __instance.transform.FindChildByRecursive(background);
            if (!bg) continue;

            var path = bg.transform.GetPath();
            if (path.Contains("layer/GROUND/BLACK", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("layer/House0.5/HOLE", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("Dirt05_Hole (1)", StringComparison.OrdinalIgnoreCase)) continue;

            //var originalScale = bg.transform.localScale;
            var x = bg.transform.localScale.x * Plugin.PositiveScaleFactor;
            x += x * 0.50f;
            //Plugin.Log.LogInfo($"Scaling {bg.transform.GetPath()} from {originalScale.x} to {x}");
            bg.transform.localScale = bg.transform.localScale with { x = x };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LayerStageMask), nameof(LayerStageMask.stagePosToMapPos))]
    public static void LayerStageMask_stagePosToMapPos(ref Point __result)
    {
        __result = __result with { y = __result.y * Plugin.PositiveScaleFactor };
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Stage), nameof(Stage.load))]
    public static void Stage_load()
    {
        Plugin.ConfigChanges();
        var deathFade = GameObject.Find("Main Camera/FADE_SPRITE");
        if (deathFade)
        {
            deathFade.transform.localScale = new Vector3(1000f, 500f, 1f);
        }

        var parent = GameObject.Find("GameUI");
        var topLeft = GameObject.Find("GameUI/Status");
        var bottomLeft = GameObject.Find("GameUI/MainWeapon");
        var bottomRight = GameObject.Find("GameUI/QuickItem");

        LeftHud ??= new GameObject("LeftHUD");
        if (!parent) return;

        LeftHud.transform.SetParent(parent.transform, true);

        if (topLeft)
        {
            topLeft.transform.SetParent(LeftHud.transform, true);
        }

        if (bottomLeft)
        {
            bottomLeft.transform.SetParent(LeftHud.transform, true);
        }

        RightHud ??= new GameObject("RightHUD");

        RightHud.transform.SetParent(parent.transform, true);

        if (bottomRight)
        {
            bottomRight.transform.SetParent(RightHud.transform, true);
        }

        LeftHud.TryAddComponent<LeftHudMover>();

        RightHud.TryAddComponent<RightHudMover>();
    }

    private static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoCom), nameof(VideoCom.init))]
    [HarmonyPatch(typeof(VideoCom), nameof(VideoCom.play))]
    [HarmonyPatch(typeof(VideoCom), nameof(VideoCom.PlayVideo))]
    [HarmonyPatch(typeof(VideoCom), nameof(VideoCom.PlayVideo), MethodType.Enumerator)]
    public static void VideoCom_Start(VideoCom __instance)
    {
        if (__instance?.videoPlayer)
        {
            __instance.videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
            var rawImage = __instance.rawImage;
            if (rawImage)
            {
                OriginalX.Value = rawImage.transform.localScale.x;
                OriginalY.Value = rawImage.transform.localScale.y;

                var newX = OriginalX.Value * Plugin.NegativeScaleFactor;
                var newY = OriginalY.Value * Plugin.NegativeScaleFactor;

                rawImage.transform.localScale = new Vector3(newX, newY, 1f);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ResolutionListUI), nameof(ResolutionListUI.work))]
    public static void ResolutionListUI_work(ResolutionListUI __instance)
    {
        var refreshRates = Screen.resolutions
            .Select(r => r.refreshRate)
            .Distinct()
            .OrderBy(r => r)
            .ToArray();

        var resList = new List<Resolution>();

        if (!Plugin.ShowMainResolutionOnly.Value)
        {
            resList.AddRange(Screen.resolutions);
        }

        resList.AddRange(refreshRates.Select(refreshRate => new Resolution { width = Display.main.systemWidth, height = Display.main.systemHeight, refreshRate = refreshRate }));

        var unique = resList
            .Distinct(new ResolutionComparer())
            .OrderBy(r => r.width)
            .ThenBy(r => r.height)
            .ThenBy(r => r.refreshRate)
            .ToArray();

        __instance.vValidResolution.Clear();
        __instance.vValidResolution.AddRange(unique);
    }

    private class ResolutionComparer : IEqualityComparer<Resolution>
    {
        public bool Equals(Resolution a, Resolution b) =>
            a.width == b.width &&
            a.height == b.height &&
            Mathf.Approximately((float)a.refreshRateRatio.value, (float)b.refreshRateRatio.value);

        public int GetHashCode(Resolution r)
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + r.width;
                hash = hash * 23 + r.height;
                hash = hash * 23 + Mathf.RoundToInt((float)r.refreshRateRatio.value);
                return hash;
            }
        }
    }
}