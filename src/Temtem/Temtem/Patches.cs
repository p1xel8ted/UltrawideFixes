namespace Temtem;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(WideScreenSideBarsUI), nameof(WideScreenSideBarsUI.Awake))]
    public static void WideScreenSideBarsUI_Awake(WideScreenSideBarsUI __instance)
    {
        __instance.leftImage?.enabled = false;
        __instance.rightImage?.enabled = false;
        __instance.enabled = false;
        if (__instance.gameObject)
        {
            __instance.gameObject.SetActive(false);
        }

        Plugin.Logger.LogInfo($"WideScreenSideBarsUI.Awake: Disabled side bars.");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleMenuUI), nameof(BattleMenuUI.Awake))]
    public static void BattleMenuUI_Awake(BattleMenuUI __instance)
    {
        var bg = __instance.backgroundCanvasGroup.transform.FindChild("Background");
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with { x = Plugin.ScaleFactor };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapDraggingArea), nameof(MapDraggingArea.Method_Public_Void_Action_1_Vector2_0))]
    public static void MapDraggingArea_Method_Public_Void_Action_1_Vector2_0(MapDraggingArea __instance)
    {
        if (__instance.transform)
        {
            __instance.transform.localScale = __instance.transform.localScale with { x = Plugin.ScaleFactor };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(InGameMapUI), nameof(InGameMapUI.OnWorldMapButtonClicked))]
    [HarmonyPatch(typeof(InGameMapUI), nameof(InGameMapUI.Awake))]
    public static void InGameMapUI_Awake(InGameMapUI __instance)
    {
        var buttonBg = __instance.contentRT.transform.FindChild("UI/KeysLegendLayoutBackground");
        if (buttonBg)
        {
            buttonBg.localScale = buttonBg.localScale with { x = Plugin.ScaleFactor };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldCamera), nameof(WorldCamera.Update))]
    public static void WorldCamera_Update(WorldCamera __instance)
    {
        __instance.myCamera.aspect = Plugin.Aspect;
        __instance.myCamera.rect = new Rect(0f, 0f, 1f, 1f);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(FadeUI), nameof(FadeUI.Awake))]
    public static void FadeUI_Awake(FadeUI __instance)
    {
        var bg = __instance.fadeImage;
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with { x = Plugin.ScaleFactor };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CommonPopupUI), nameof(CommonPopupUI.Awake))]
    public static void CommonPopupUI_Awake(CommonPopupUI __instance)
    {
        var bg = __instance.imageRaycastBlock;
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with { x = Plugin.ScaleFactor };
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinematicBarsUI), nameof(CinematicBarsUI.Awake))]
    public static void CinematicBarsUI_Awake(CinematicBarsUI __instance)
    {
        __instance.upperBarRT?.gameObject.SetActive(false);
        __instance.lowerBarRT?.gameObject.SetActive(false);
        __instance.enabled = false;
        if (__instance.gameObject)
        {
            __instance.gameObject.SetActive(false);
        }

        Plugin.Logger.LogInfo($"CinematicBarsUI.Awake: Disabled letterbox bars.");
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LimitCameraAspectRatio), nameof(LimitCameraAspectRatio.Update))]
    public static bool LimitCameraAspectRatio_Update(LimitCameraAspectRatio __instance)
    {
        if (!__instance) return false;

        var cam = __instance.myCamera;
        if (!cam) return false;
        cam.ResetAspect();
        cam.rect = new Rect(0f, 0f, 1f, 1f);

        return false;
    }
}