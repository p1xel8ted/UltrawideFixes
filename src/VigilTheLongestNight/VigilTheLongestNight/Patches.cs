using System.Collections.Generic;
using UnityEngine.Analytics;
using Object = UnityEngine.Object;

namespace VigilTheLongestNight;

[Harmony]
public static class Patches
{
    private readonly static string[] BackgroundsToScale =
    [
        "BG",
        "whitebox",
        "BlackMask"
    ];

    private readonly static Dictionary<int, float> TimeOnScreen = new();

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(DamageInfoMan), nameof(DamageInfoMan.work))]
    public static void DamageInfoMan_work(ref DamageInfoMan __instance)
    {
        var damageInfos = GameObject.Find("Damage Info");
        if (!damageInfos) return;

        foreach (var o in damageInfos.transform)
        {
            var child = o.TryCast<Transform>();
            if (!child || !child.gameObject.activeSelf) continue;

            var instanceId = child.gameObject.GetInstanceID();
            
            if (!TimeOnScreen.TryAdd(instanceId, 0))
            {
                TimeOnScreen[instanceId] += Time.deltaTime;
            }

            if (!(TimeOnScreen[instanceId] > 2f)) continue;
            
            child.gameObject.SetActive(false);
            TimeOnScreen.Remove(instanceId);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LayerScroller), nameof(LayerScroller.Start))]
    public static void LayerScroller_Start(ref LayerScroller __instance)
    {
        Plugin.UpdateComponents();

        // if(__instance.name.Equals("MASK"))
        // {
        //     if(__instance.transform.FindChild("BlackMask"))
        //     {
        //         var x = __instance.transform.localScale.x * Plugin.PositiveScaleFactor;
        //         __instance.transform.localScale = __instance.transform.localScale with {x = x};
        //     }
        // }
        foreach (var background in BackgroundsToScale)
        {
            var bg = __instance.transform.FindChildByRecursive(background);
            if (!bg) continue;

            if (bg.transform.GetPath().Contains("layer/GROUND/BLACK")) continue;
            
            Plugin.Logger.LogInfo($"Scaling {bg.GetPath()}");
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