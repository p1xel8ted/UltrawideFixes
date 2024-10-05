namespace ScarletMaiden;

[Harmony]
public static class Patches
{
    private static readonly List<ContentSizeFitter> ContentSizeFitters = [];
    private static readonly string[] SkipTheseScenes = ["TitleScreen", "SetupScene", "Intro", "OttersideSplash"];
    internal static GameObject BlackBarCanvas { get; private set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.GetSettings))]
    public static void GameManager_Postfix(GameManager __instance, SettingsState __result)
    {
        __result.resolutionState = (ResolutionState)10;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.HandleInput))]
    public static bool CameraFix_HandleInput()
    {
        return false;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.GetResolutionForState))]
    public static void CameraFix_GetResolutionForState(ResolutionState resolutionState, ref ValueTuple<int, int> __result)
    {
        //create a new resolution state enum for UltraWide with a value of 10
        if (resolutionState == (ResolutionState)10)
        {
            __result = new ValueTuple<int, int>(Display.main.systemWidth, Display.main.systemHeight);
        }
    }

    private static void UpdateFramerate(CameraFix cameraFix)
    {
        //get the highest framerate supported by the current resolution
        var currentRes = CameraFix.GetResolutionForState(cameraFix.resolutionState);

        var highestRefreshRate = Screen.resolutions
            .Where(mode => mode.width == currentRes.Item1 && mode.height == currentRes.Item2)
            .Max(mode => mode.refreshRate);

        cameraFix.targetFramerate = highestRefreshRate;
        Application.targetFrameRate = highestRefreshRate;
    }

    internal static void CreateBlackBars()
    {
        if (!BlackBarCanvas)
        {
            BlackBarCanvas = new GameObject("BlackBarCanvas");
            var canvas = BlackBarCanvas.TryAddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            if (!LeftBlackBar)
            {
                LeftBlackBar = new GameObject("LeftBlackBar");
                LeftBlackBar.transform.SetParent(canvas.transform, false);
                var leftImage = LeftBlackBar.TryAddComponent<Image>();
                leftImage.color = Color.black;
                var leftRect = leftImage.GetComponent<RectTransform>();
                leftRect.anchorMin = new Vector2(0, 0);
                leftRect.anchorMax = new Vector2(0, 1);
                leftRect.offsetMin = new Vector2(0, 0);
                leftRect.offsetMax = new Vector2(Plugin.BlackBarSize, 0);
            }

            if (!RightBlackBar)
            {
                RightBlackBar = new GameObject("RightBlackBar");
                RightBlackBar.transform.SetParent(canvas.transform, false);
                var rightImage = RightBlackBar.TryAddComponent<Image>();
                rightImage.color = Color.black;
                var rightRect = rightImage.GetComponent<RectTransform>();
                rightRect.anchorMin = new Vector2(1, 0);
                rightRect.anchorMax = new Vector2(1, 1);
                rightRect.offsetMin = new Vector2(-Plugin.BlackBarSize, 0);
                rightRect.offsetMax = new Vector2(0, 0);
            }
        }
    }

    internal static void UpdateHUD()
    {
        foreach (var fitter in ContentSizeFitters.Where(fitter => fitter))
        {
            fitter.horizontalFit = Plugin.RestrictHUD.Value ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
        }
        
        Plugin.ToggleHud();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapMenu), nameof(MapMenu.Start))]
    public static void DungeonManager_Start(DungeonManager __instance)
    {
        AddContentSizeFitter(__instance.gameObject);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUD), nameof(HUD.Start))]
    public static void HUD_Start(HUD __instance)
    {
        AddContentSizeFitter(__instance.gameObject);
    }

    private static void AddContentSizeFitter(GameObject gameObject)
    {
        var le = gameObject.TryAddComponent<LayoutElement>();
        le.preferredWidth = 640;
        le.layoutPriority = 999;
        le.enabled = true;
        
        var csf = gameObject.TryAddComponent<ContentSizeFitter>();
        csf.horizontalFit = Plugin.RestrictHUD.Value ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
        csf.enabled = true;
        ContentSizeFitters.Add(csf);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameObject), nameof(GameObject.SetActive))]
    public static void ItemSwapMenu_Update(GameObject __instance, bool value)
    {
        // Get the calling method's name
        var methodName = new StackTrace().GetFrame(2).GetMethod()?.Name;

        // Exit early if the method is related to pillar boxing or HUD toggling
        if (methodName is nameof(Plugin.EnablePillarBoxing) or nameof(Plugin.DisablePillarBoxing) or nameof(Plugin.ToggleHud))
            return;

        // Only proceed for relevant objects
        if (__instance.name is not ("ScarletDeathAnimation" or "CharacterTab" or "ItemSwapMenu" or "SkillTreeTab" or "BGImage" or "LevelTransition"))
            return;

        // Handle BGImage based on HUD restrictions
        if (__instance.name == "BGImage" && !Plugin.RestrictHUD.Value)
        {
            Plugin.DisablePillarBoxing();
            return;  // No need for further checks
        }

        // Handle level transitions separately, always adjust pillar boxing during transitions
        if (__instance.name is "LevelTransition" or "ScarletDeathAnimation" )
        {
            if (value)
                Plugin.EnablePillarBoxing();
            else
                Plugin.DisablePillarBoxing();

            return;  // No further checks needed
        }

        // General handling for other relevant objects based on BlackBars setting and value
        if (value && Plugin.BlackBars.Value)
        {
            Plugin.EnablePillarBoxing();
        }
        else
        {
            Plugin.DisablePillarBoxing();
        }
    }



    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.Start))]
    public static void CameraFix_Start(CameraFix __instance)
    {
        UpdateFramerate(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFollow), nameof(CameraFollow.Start))]
    public static void CameraFollow_Start(CameraFollow __instance)
    {
        __instance.useCamBoundsOverride = Plugin.AlternateCameraMode.Value;
        __instance.verticalOffset = Plugin.CameraVerticality.Value;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenuResolution), nameof(SettingsMenuResolution.SetupOptions))]
    public static void SettingsMenuResolution_SetupOptions(SettingsMenuResolution __instance)
    {
        //convert the 4K option to UltraWide
        __instance.options[__instance.options.Length - 1].gameObject.GetComponent<TextMeshProUGUI>().text = $"UW ({Display.main.systemWidth}x{Display.main.systemHeight})";
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenuResolution), nameof(SettingsMenuResolution.OnConfirm))]
    public static void SettingsMenuResolution_OnOptionSelected(SettingsMenuResolution __instance)
    {
        //if selection is 4K, return UltraWide
        if (__instance.pointerIndex == 6)
        {
            __instance.pointerIndex = 10;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.Update))]
    public static void CameraFix_Update(CameraFix __instance)
    {
        if (!Plugin.EnableCustomOrthographicSize.Value) return;
        if (SkipTheseScenes.Contains(SceneManager.GetActiveScene().name)) return;

        var increaseZoom = Plugin.IncreaseZoom.Value.IsUp();
        var decreaseZoom = Plugin.DecreaseZoom.Value.IsUp();
        var reset = Plugin.Reset.Value.IsUp();

        var orthographicSize = __instance.cam.orthographicSize;

        if (increaseZoom)
        {
            orthographicSize += 0.25f;
        }
        else if (decreaseZoom)
        {
            orthographicSize -= 0.25f;
        }
        else
        {
            if (reset)
            {
                Plugin.ResetZoom();
            }

            return;
        }

        __instance.cam.orthographicSize = orthographicSize;
        Plugin.CustomOrthographicSize.Value = orthographicSize;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OttersideSplash), nameof(OttersideSplash.Start))]
    public static void OttersideSplash_Start(OttersideSplash __instance)
    {
        __instance.LoadNextScene();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraFix), nameof(CameraFix.UpdateOrthographicSize))]
    public static void CameraFix_UpdateOrthographicSize(CameraFix __instance)
    {
        //convert ultrawide back into 16:9 equivalent to attempt to get correct orthographic size
        var screenHeight = CameraFix.GetResolutionForState(__instance.resolutionState).Item2;
        const float ar = 16f / 9f;
        var newWidth = (int)(screenHeight * ar);
        var res = CameraFix.GetStateForResolution(newWidth, screenHeight);
        Plugin.OriginalZoom = __instance.cam.orthographicSize = CameraFix.GetResolutionForState(__instance.resolutionState).Item2 / __instance.ppu / 2f / (float)res / __instance.currenZoomLevel;

        if (Plugin.EnableCustomOrthographicSize.Value && !SkipTheseScenes.Contains(SceneManager.GetActiveScene().name))
        {
            __instance.cam.orthographicSize = Plugin.CustomOrthographicSize.Value;
        }

        UpdateFramerate(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains("sinai")) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.Start))]
    public static void TitleScreen_Start(TitleScreen __instance)
    {
        var version = __instance.transform.Find("MenuBg/Version");
        if (version)
        {
            version.gameObject.SetActive(false);
        }

        var copyright = __instance.transform.Find("MenuBg/Copyright");
        if (copyright)
        {
            copyright.gameObject.SetActive(false);
        }
    }
}