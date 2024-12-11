namespace ValfarisMechaTherion;

[Harmony]
public static class Patches
{
    private static Resolution ChosenResolution => Plugin.SelectedResolution;

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Fader), nameof(Fader.Initiate))]
    [HarmonyPatch(typeof(Fader), nameof(Fader.RoutineFade))]
    public static void Fader_Initiate(Fader __instance)
    {
        __instance.RectTransform.sizeDelta = new Vector2(ChosenResolution.width, ChosenResolution.height);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(EnemyControl), nameof(EnemyControl.InitiateEnemyControl))]
    public static void EnemyControl_InitiateEnemyControl(EnemyToken enemyToken)
    {
        if (enemyToken)
        {
            enemyToken.transform.position = enemyToken.transform.position with { x = enemyToken.transform.position.x * Plugin.PositiveScaleFactor };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectManager), nameof(AspectManager.RescaleCamera))]
    public static void AspectManager_RescaleCamera(AspectManager __instance)
    {
        if (__instance.Cam)
        {
            __instance.Cam.aspect = Plugin.MainAspect;
            __instance.Cam.rect = new Rect(0, 0, 1, 1);
            __instance.Cam.pixelRect = new Rect(0, 0, ChosenResolution.width, ChosenResolution.height);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIImage), nameof(UIImage.SetVisibilty))]
    [HarmonyPatch(typeof(UIImage), nameof(UIImage.Initiate))]
    public static void UIImage_SetVisibility(UIImage __instance)
    {
        if (__instance.name == "UI Menu Background(Clone)")
        {
            __instance.transform.localScale = new Vector3(1f, Plugin.PositiveScaleFactor, 1f);
        }
    }
}