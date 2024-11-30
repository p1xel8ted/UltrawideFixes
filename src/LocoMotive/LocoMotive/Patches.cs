namespace LocoMotive;

[Harmony]
public static class Patches
{
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

   
    private static readonly string[] AddAspectFitters = ["GuiMainMenu(Clone)", "GuiSettings(Clone)", "GuiNavigation(Clone)", "GuiSave(Clone)"];
    private static readonly string[] AddBlackBarsTo = ["GuiMainMenu(Clone)"];
    
    [HarmonyPostfix]
    // [HarmonyPatch(typeof(GuiComponent), nameof(GuiComponent.Awake))]
    [HarmonyPatch(typeof(GuiComponent), nameof(GuiComponent.Start))]
    public static void GuiComponent_Start(GuiComponent __instance)
    {
        Plugin.Log.LogInfo($"Checking for AspectRatioFitter on {__instance.name}");
        if (AddAspectFitters.Contains(__instance.name))
        {
            var aspectFitter = __instance.gameObject.TryAddComponent<AspectRatioFitter>();
            if (aspectFitter)
            {
                aspectFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
                aspectFitter.aspectRatio = 16f / 9f;
            }

            var bg = __instance.transform.Find("Background");
            if (bg)
            {
                bg.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1.1f);
            }
        }
        
        if (AddBlackBarsTo.Contains(__instance.name))
        {
            AddBlackBars(__instance.transform);
        }
    }
    
    
    private static void AddBlackBars(Transform tr){
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