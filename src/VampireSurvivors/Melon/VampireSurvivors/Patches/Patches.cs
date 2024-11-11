using Il2Cpp;
using Il2CppDoozy.Engine.UI;
using Il2CppVampireSurvivors.Objects;
using Il2CppVampireSurvivors.UI;

namespace VampireSurvivors.Patches;

[Harmony]
public static class Patches
{
    private static readonly string[] ScaleThese = ["YellowBackground", "Fade", "Image - SceneTransition", "YellowBackground_ADD"];

    private static Rect AdjustRect(Rect rect)
    {
        rect.width *= Plugin.PositiveScaleFactor;
        return rect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Stage), nameof(Stage.InitRects))]
    public static void Stage_InitRects(Stage __instance)
    {
        if (!Plugin.ExpandSpawnZone.Value) return;

        __instance._spawnInnerRect = AdjustRect(__instance.SpawnInnerRect);
        __instance._spawnOuterRect = AdjustRect(__instance.SpawnOuterRect);
        __instance._enemiesDespawnRect = AdjustRect(__instance.EnemiesDespawnRect);
        __instance._containmentExactRect = AdjustRect(__instance.ContainmentExactRect);
        __instance._containmentScreenRect = AdjustRect(__instance.ContainmentScreenRect);
        __instance._tiledInnerRect = AdjustRect(__instance._tiledInnerRect);
        __instance._tiledOuterRect = AdjustRect(__instance._tiledOuterRect);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Stage), nameof(Stage.SetupFancyBackground))]
    public static void Stage_SetupFancyBackground(Stage __instance)
    {
        if (!Camera.main) return;

        var camera = Camera.main.transform;

        for (var index = 0; index < camera.childCount; index++)
        {
            var child = camera.GetChild(index);
            if (child && child.name.Contains("Background", StringComparison.OrdinalIgnoreCase))
            {
                child.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIView), nameof(UIView.OnEnable))]
    public static void UIView_OnEnable(UIView __instance)
    {
        foreach (var image in ScaleThese)
        {
            var img = __instance.transform.Find(image);
            if (img)
            {
                img.localScale = new Vector3(Plugin.PositiveScaleFactor, 1f, 1f);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GoldFeverUIManager), nameof(GoldFeverUIManager.OnEnable))]
    public static bool GoldFeverUIManager_OnEnable(GoldFeverUIManager __instance)
    {
        __instance.IntroTween();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ViewportCrop), nameof(ViewportCrop.Awake))]
    public static void ViewportCrop_Awake(ViewportCrop __instance)
    {
        __instance._referenceResolution = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        __instance._referenceAspectRatio = Plugin.MainAspect;
        __instance.xOffset = 0;
        __instance.yOffset = 0;
        __instance.xSize = 0;
        __instance.ySize = 0;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectMask), nameof(AspectMask.Start))]
    public static void AspectMask_Start(AspectMask __instance)
    {
        __instance.gameObject.SetActive(false);
    }
}