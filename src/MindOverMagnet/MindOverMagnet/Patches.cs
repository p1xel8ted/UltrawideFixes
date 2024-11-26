namespace MindOverMagnet;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(transitionManager), nameof(transitionManager.Start))]
    public static void uiManagement_correctAspectRatio(transitionManager __instance)
    {
        var iris = __instance.transform.Find("Images/Iris");
        if (iris)
        {
            iris.localScale *= Plugin.PositiveScaleFactor;
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
}