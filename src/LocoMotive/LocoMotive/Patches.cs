namespace LocoMotive;

[Harmony]
public static class Patches
{
    private static readonly string[] AddAspectFitters = ["GuiMainMenu(Clone)", "GuiSettings(Clone)", "GuiNavigation(Clone)", "GuiSave(Clone)", "GuiTitle(Clone)"];
    private static readonly string[] AddBlackBarsTo = ["GuiMainMenu(Clone)"];

    private static readonly string[] ScaleTheseTransforms = ["ImgFade", "ImgOutro", "ImgIntro", "ImgFog"];
    private static Resolution ChosenResolution => Plugin.SelectedResolution;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LetterBoxer), nameof(LetterBoxer.AddLetterBoxingCamera))]
    public static bool LetterBoxer_AddLetterBoxingCamera(LetterBoxer __instance)
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LetterBoxer), nameof(LetterBoxer.PerformSizing))]
    public static void LetterBoxer_PerformSizing(LetterBoxer __instance)
    {
        __instance.cam.aspect = Plugin.MainAspect;
        __instance.cam.rect = new Rect(0, 0, 1, 1);
        __instance.cam.pixelRect = new Rect(0, 0, ChosenResolution.width, ChosenResolution.height);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QuantumConsole), nameof(QuantumConsole.Activate))]
    public static bool QuantumConsole_Activate()
    {
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SystemConsole), nameof(SystemConsole.Update))]
    [HarmonyPatch(typeof(QuantumConsole), nameof(QuantumConsole.Update))]
    public static bool SystemConsole_Update()
    {
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GuiErrorHandler), nameof(GuiErrorHandler.Show))]
    public static bool GuiErrorHandler_Show()
    {
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreenVideo), nameof(SplashScreenVideo.Update))]
    [HarmonyPatch(typeof(SplashScreenVideo), nameof(SplashScreenVideo.EndReached))]
    public static void SplashScreenVideo_Update(SplashScreenVideo __instance)
    {
        __instance.m_isSkipping = true;
        __instance.m_showLoadingScreen = false;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreenVideo), nameof(SplashScreenVideo.Start))]
    public static bool SplashScreenVideo_Start(SplashScreenVideo __instance)
    {
        __instance.m_videoPlayer.Stop();
        SceneManager.LoadScene(__instance.m_sceneToLoadOnEnd);
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(RoomComponent), nameof(RoomComponent.Start))]
    [HarmonyPatch(typeof(RoomComponent), nameof(RoomComponent.SetData))]
    [HarmonyPatch(typeof(RoomComponent), nameof(RoomComponent.OnLoadComplete))]
    [HarmonyPatch(typeof(RoomComponent), nameof(RoomComponent.SetActiveWalkableArea))]
    public static void RoomComponent_SetActiveWalkableArea(RoomComponent __instance)
    {
        Plugin.UpdateAll();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GuiComponent), nameof(GuiComponent.Start))]
    public static void GuiComponent_Start(GuiComponent __instance)
    {
        Plugin.Log.LogInfo($"Checking for AspectRatioFitter on {__instance.name}");
        if (AddAspectFitters.Contains(__instance.name))
        {
            if (__instance.name == "GuiMainMenu(Clone)")
            {
                var addAspectFitterTo = __instance.transform.Find("LayoutGroup");
                if (addAspectFitterTo)
                {
                    var le = addAspectFitterTo.gameObject.TryAddComponent<LayoutElement>();
                    le.preferredWidth = Plugin.SelectedResolution.height * Plugin.NativeAspect;

                    var csf = addAspectFitterTo.gameObject.TryAddComponent<ContentSizeFitter>();
                    csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

                    ChangeTheseFitters.Add(csf);
                    ChangeTheseLayoutElements.Add(le);
                }

                var imgMask = __instance.transform.Find("ImgMask/ImgBackground/ImgKeyArt");
                if (imgMask)
                {
                    imgMask.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1.1f);
                    ChangeTheseTransforms.Add(imgMask);
                }
            }
            else
            {
                var aspectFitter = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
                if (aspectFitter)
                {
                    aspectFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
                    aspectFitter.aspectRatio = 16f / 9f;
                }
            }

            var bg = __instance.transform.Find("Background");
            if (bg)
            {
                bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1.1f);
                ChangeTheseTransforms.Add(bg);
            }
        }

        if (AddBlackBarsTo.Contains(__instance.name))
        {
            AddBlackBars(__instance.transform);
        }

        foreach (var tr in ScaleTheseTransforms)
        {
            var transform = __instance.transform.Find(tr);
            if (transform)
            {
                transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1.1f);
                ChangeTheseTransforms.Add(transform);
            }
        }
    }

    private static readonly List<ContentSizeFitter> ChangeTheseFitters = [];
    private static readonly List<LayoutElement> ChangeTheseLayoutElements = [];
    private static readonly List<Transform> ChangeTheseTransforms = [];

    internal static void ChangeThese()
    {
        foreach (var le in ChangeTheseLayoutElements.Where(a => a))
        {
            le.preferredWidth = Plugin.SelectedResolution.height * Plugin.NativeAspect;
        }

        foreach (var csf in ChangeTheseFitters.Where(a => a))
        {
            csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }

        foreach (var tr in ChangeTheseTransforms.Where(a => a))
        {
            tr.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1.1f);
        }
    }


    private static void AddBlackBars(Transform tr)
    {
        var blackScreenExists = tr.Find("BlackScreen");

        if (blackScreenExists) return;

        // Add a full-screen black image as the first sibling in the Canvas hierarchy
        var blackScreen = new GameObject("BlackScreen");
        blackScreen.transform.SetParent(tr, false);

        // Add an Image component and set its color to black
        var image = blackScreen.TryAddComponent<Image>();
        image.color = Color.black;

        // Set the RectTransform anchors and offsets to make the image fill the entire canvas
        var rectTransform = blackScreen.GetComponent<RectTransform>();
        rectTransform.anchorMin = Vector2.zero; // Bottom-left corner
        rectTransform.anchorMax = Vector2.one; // Top-right corner
        rectTransform.offsetMin = Vector2.zero; // No offset from bottom-left
        rectTransform.offsetMax = Vector2.zero; // No offset from top-right

        // Move the black screen GameObject to the first sibling position in the hierarchy
        blackScreen.transform.SetAsFirstSibling();

        //scale to offset aspect ratio fitters restricting to 16:9
        blackScreen.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        // Skip processing if the CanvasScaler's name contains "sinai"
        if (__instance.name.Contains("sinai")) return;

        // Ensure the CanvasScaler uses the "Expand" match mode if it is set to ScaleWithScreenSize
        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
}