namespace VigilTheLongestNight;

[Harmony]
public static class Patches
{
    private readonly static string[] BackgroundsToScale =
    [
        "BG",
        "whitebox"
    ];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LayerScroller), nameof(LayerScroller.Start))]
    public static void LayerScroller_Start(ref LayerScroller __instance)
    {
        Plugin.UpdateComponents();

        foreach (var background in BackgroundsToScale)
        {
            var bg = __instance.transform.FindChildByRecursive(background);
            if (!bg) continue;
            
            var x = bg.transform.localScale.x * Plugin.PositiveScaleFactor;
            bg.transform.localScale = bg.transform.localScale with {x = x};
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LayerStageMask), nameof(LayerStageMask.stagePosToMapPos))]
    public static void LayerStageMask_stagePosToMapPos(ref LayerStageMask __instance, ref Point posInStage, ref Point __result)
    {
        __result = __result with {y = __result.y * Plugin.PositiveScaleFactor};
    }

    private static GameObject LeftHud;
    private static GameObject RightHud;
    
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
        LeftHud.transform.SetParent(parent.transform, true);
        
        topLeft.transform.SetParent(LeftHud.transform,true);
        bottomLeft.transform.SetParent(LeftHud.transform,true);
        
        RightHud ??= new GameObject("RightHUD");
        RightHud.transform.SetParent(parent.transform, true);
        bottomRight.transform.SetParent(RightHud.transform, true);

        LeftHud.TryAddComponent<LeftHudMover>();
        
        RightHud.TryAddComponent<RightHudMover>();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoCom), nameof(VideoCom.init))]
    [HarmonyPatch(typeof(VideoCom), nameof(VideoCom.play))]
    public static void VideoCom_Start(ref VideoCom __instance)
    {
        __instance.videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
        var scaler = __instance.GetComponentInChildren<CanvasScaler>();
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.scaleFactor = 1.6f; //unsure of this value - I can't work out how to get the correct value mathematically
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ResolutionListUI), nameof(ResolutionListUI.work))]
    public static void ResolutionListUI_work(ref ResolutionListUI __instance)
    {
        var myResExists = __instance.vValidResolution.ToArray().Any(a => a.width == Plugin.MainWidth && a.height == Plugin.MainHeight);
        if (myResExists) return;
        var myRes = new Resolution
        {
            width = Plugin.MainWidth,
            height = Plugin.MainHeight,
            refreshRate = Plugin.MaxRefresh
        };

        __instance.addValidResolution(myRes);
    }
}