namespace TinyTerrysTurboTrip.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];
    private static readonly Dictionary<int, float> OriginalMenuXPositions = new();
    private static readonly string[] SkipTheseMenus = ["Main Menu", "Settings"];

    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Plugin.MainAspect > Plugin.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayerUtility), nameof(VideoPlayerUtility.Start))]
    public static void VideoPlayerUtility_Start(VideoPlayerUtility __instance)
    {
        if (__instance.name == "Splash Screens")
        {
            __instance.videos.Clear();
        }
    }

    [HarmonyPrefix]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.HoleTransitionStart), typeof(bool), typeof(float))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.HoleTransitionStart), typeof(bool), typeof(float), typeof(Material), typeof(bool))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.Start))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.UpdateLoadingScreenTerry))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.LoadScene), typeof(string))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.LoadScene), typeof(int))]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.LoadScene), typeof(SceneLoader.SceneReference))]
    public static void SceneLoader_Start(SceneLoader __instance)
    {
        __instance.backgroundImage.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UITutorialCard), nameof(UITutorialCard.Update))]
    public static void UITutorialCard_OnEnable(UITutorialCard __instance)
    {
        if(Mathf.Approximately(__instance.currentTargetPositionX, __instance.invisiblePositionX))
        {
            __instance.transform.localPosition = __instance.transform.localPosition with { x = __instance.invisiblePositionX * Plugin.PositiveScaleFactor };
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ScenematicBars), nameof(ScenematicBars.InitWithoutDomainReload))]
    [HarmonyPatch(typeof(ScenematicBars), nameof(ScenematicBars.AnimateIn))]
    [HarmonyPatch(typeof(ScenematicBars), nameof(ScenematicBars.AnimateOut))]
    [HarmonyPatch(typeof(ScenematicBars), nameof(ScenematicBars._AnimateOut_b__9_0))]
    [HarmonyPatch(typeof(ScenematicBars), nameof(ScenematicBars.Spawn))]
    public static bool ScenematicBars_Start()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SimpleMenuWindow), nameof(SimpleMenuWindow.Open))]
    public static void SimpleMenuWindow_Open(SimpleMenuWindow __instance)
    {
        Plugin.Logger.LogWarning("Opening menu: " + __instance.name);

        if (SkipTheseMenus.Contains(__instance.name))
        {
            Plugin.Logger.LogWarning("Skipping menu adjustments for (exact match): " + __instance.name);
            return;
        }

        if (SkipTheseMenus.Any(s => __instance.name.Contains(s)))
        {
            Plugin.Logger.LogWarning("Skipping menu adjustments for (skip any): " + __instance.name);
            return;
        }

        var instanceID = __instance.GetInstanceID();
        if (!OriginalMenuXPositions.TryGetValue(instanceID, out var originalX))
        {
            OriginalMenuXPositions.Add(instanceID, __instance.transform.localPosition.x);
            originalX = __instance.transform.localPosition.x;
        }

        var newX = originalX * (1f / Plugin.PositiveScaleFactor);
        __instance.transform.localPosition = __instance.transform.localPosition with { x = newX };
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(TitleScreenManager), nameof(TitleScreenManager.Start))]
    public static void TitleScreenManager_Start(TitleScreenManager __instance)
    {
        var menu = __instance.transform.FindChild("Main Menu Canvas 2D");
        if (menu)
        {
            var le = menu.gameObject.TryAddComponent<LayoutElement>();
            le.preferredWidth = 1920;

            var csf = menu.gameObject.TryAddComponent<ContentSizeFitter>();
            csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        if (__instance.renderMode == VideoRenderMode.RenderTexture &&
            __instance.targetTexture &&
            __instance.targetTexture.width != Plugin.SelectedResolution.width)
        {
            var tex = __instance.targetTexture;
            tex.Release();
            tex.width = Plugin.SelectedResolution.width;
            tex.height = Plugin.SelectedResolution.height;
            tex.Create();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }
}