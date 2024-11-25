namespace MindOverMagnet;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains(Sinai, StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(cutsceneMeta), nameof(cutsceneMeta.showLetterbox))]
    public static bool cutsceneMeta_showLetterbox()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(transitionManager), nameof(transitionManager.Awake))]
    [HarmonyPatch(typeof(transitionManager), nameof(transitionManager.setCanvas))]
    [HarmonyPatch(typeof(transitionManager), nameof(transitionManager.Start))]
    public static void uiManagement_correctAspectRatio(transitionManager __instance)
    {
        var iris = __instance.transform.Find("Images/Iris");
        if (iris)
        {
            iris.localScale *= Plugin.PosScaleFactor;
        }

        var topBorder = __instance.transform.Find("Level Start/Borders/Border Top");
        if (topBorder)
        {
            topBorder.gameObject.SetActive(false);
        }

        var bottomBorder = __instance.transform.Find("Level Start/Borders/Border Bottom");
        if (bottomBorder)
        {
            bottomBorder.gameObject.SetActive(false);
        }
    }


    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(uiManagement), nameof(uiManagement.correctAspectRatio))]
    // public static void uiManagement_correctAspectRatio(ref bool __result)
    // {
    //     __result = false;
    // }
}