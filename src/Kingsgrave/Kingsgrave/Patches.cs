namespace Kingsgrave;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains(Sinai)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        if (__instance.name == "CanvasMainMenu")
        {
            AddFixedLayoutController(__instance.gameObject, 1920);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GUIManager), nameof(GUIManager.OnEnable))]
    public static void GUIManager_OnEnable(GUIManager __instance)
    {
        var lc = __instance.MainCanvas.gameObject.TryAddComponent<LayoutController>();
        LayoutControllers.Add(lc);

        AddFixedLayoutController(__instance.PauseScreen.gameObject, Plugin.MainWidth);

        var deathSplash = __instance.MainCanvas.transform.Find("DeathSplash");
        if (deathSplash)
        {
            AddFixedLayoutController(deathSplash.gameObject, Plugin.MainWidth);
        }

        var finalSplash = __instance.MainCanvas.transform.Find("FinalSplash");
        if (finalSplash)
        {
            AddFixedLayoutController(finalSplash.gameObject, Plugin.MainWidth);
        }

        var infoPanel = __instance.MainCanvas.transform.Find("InformationPanel");
        if (infoPanel)
        {
            AddFixedLayoutController(infoPanel.gameObject, Plugin.MainWidth);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MMFlash), nameof(MMFlash.OnEnable))]
    public static void MMFlash_OnEnable(MMFlash __instance)
    {
        AddFixedLayoutController(__instance.gameObject, Plugin.MainWidth);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MMFader), nameof(MMFader.OnEnable))]
    public static void MMFader_OnEnable(MMFader __instance)
    {
        AddFixedLayoutController(__instance.gameObject, Plugin.MainWidth);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsGUI), nameof(SettingsGUI.Awake))]
    [HarmonyPatch(typeof(SettingsGUI), nameof(SettingsGUI.Start))]
    public static void SettingsGUI_OnEnable(SettingsGUI __instance)
    {
        AddFixedLayoutController(__instance.gameObject, Plugin.MainWidth);
    }

    private static void AddFixedLayoutController(GameObject gameObject, int width)
    {
        var le = gameObject.TryAddComponent<LayoutElement>();
        var csf = gameObject.TryAddComponent<ContentSizeFitter>();

        le.preferredWidth = width;

        csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

        le.SetDirty();
        csf.SetDirty();
        Canvas.ForceUpdateCanvases();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsController), nameof(SettingsController.GetResolutions))]
    [HarmonyPatch(typeof(SettingsController), nameof(SettingsController.GetResolutionByProportion))]
    public static void SettingsController_GetResolutions(ref Resolution[] __result)
    {
        var res = new Resolution
        {
            width = Plugin.MainWidth,
            height = Plugin.MainHeight,
            refreshRate = Mathf.RoundToInt(Plugin.RefreshRate)
        };
        __result = [res];
    }

    private static readonly List<LayoutController> LayoutControllers = [];

    internal static void UpdateLayoutControllers()
    {
        foreach (var layout in LayoutControllers.Where(layout => layout))
        {
            var width = LayoutController.GetPreferredWidth();
            layout.LayoutElement.preferredWidth = width;
            layout.ContentSizeFitter.horizontalFit = width == -99 ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize;
            layout.LayoutElement.SetDirty();
            layout.ContentSizeFitter.SetDirty();
            Canvas.ForceUpdateCanvases();
        }
    }
}