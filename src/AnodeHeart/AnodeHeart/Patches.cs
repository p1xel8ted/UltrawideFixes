namespace AnodeHeart;

[Harmony]
public static class Patches
{
    private static CameraController CameraControllerInstance => SceneSingleton<CameraController>.m_Instance;
 
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleController), nameof(TitleController.Start))]
    public static void TitleController_Start(ref TitleController __instance)
    {
        var discord = __instance.transform.parent.Find("Discord");
        var faq = __instance.transform.parent.Find("GameFAQ");

        if (discord)
        {
            discord.gameObject.SetActive(false);
        }
        if (faq)
        {
            faq.gameObject.SetActive(false);
        }
        __instance.Buttons[3].gameObject.SetActive(false);
        __instance.Buttons[4].gameObject.SetActive(false);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        
        var questBg = __instance.transform.Find("Below Overlay/Quests");
        if (questBg)
        {
            questBg.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
            
            var rect = questBg.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(RecorderHUD), nameof(RecorderHUD.load))]
    [HarmonyPatch(typeof(RecorderHUD), nameof(RecorderHUD.loadEntry))]
    [HarmonyPatch(typeof(RecorderHUD), nameof(RecorderHUD.NextEntry))]
    [HarmonyPatch(typeof(RecorderHUD), nameof(RecorderHUD.loadPage))]
    [HarmonyPatch(typeof(RecorderHUD), nameof(RecorderHUD.PreviousEntry))]
    public static void RecorderHUD_Load(RecorderHUD __instance)
    {
        __instance.ArrowLeft.transform.localPosition = __instance.ArrowLeft.transform.localPosition with {x = -110};
        __instance.ArrowRight.transform.localPosition = __instance.ArrowRight.transform.localPosition with {x = 110};
        __instance.Contents.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
        __instance.Contents.transform.position = __instance.Contents.transform.position with {x = 7f};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DialogueController), nameof(DialogueController.Start))]
    [HarmonyPatch(typeof(DialogueController), nameof(DialogueController.StartDialogue))]
    public static void DialogueController_StartDialogue(DialogueController __instance)
    {
        __instance.transform.parent.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
        __instance.transform.parent.gameObject.TryAddComponent<DialogueMover>();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LevelUpScreen), nameof(LevelUpScreen.Load))]
    public static void LevelUpScreen_Load(LevelUpScreen __instance)
    {
        var rect = __instance.transform.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
    }

    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GadgetsHUD), nameof(GadgetsHUD.Load))]
    public static void GadgetsHUD_Load(GadgetsHUD __instance)
    {
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PartySelectorHUD), nameof(PartySelectorHUD.Load))]
    public static void QuestList_Load(PartySelectorHUD __instance)
    {
        var rect = __instance.TamaSelectMenu.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TamaSelectorHUD), nameof(TamaSelectorHUD.Load))]
    public static void TamaSelectorHUD_Load(TamaSelectorHUD __instance)
    {
        __instance.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConfirmationBox), nameof(ConfirmationBox.Load), typeof(ConfirmationBox), typeof(string), typeof(OnSelect), typeof(Transform))]
    [HarmonyPatch(typeof(ConfirmationBox), nameof(ConfirmationBox.Load), typeof(string), typeof(OnSelect))]
    public static void ConfirmationBox_Load(ConfirmationBox __instance, string title)
    {
        if (__instance.transform.GetFullPath().Contains("Inventory(Clone)"))
        {
            if (title.StartsWith("Sort"))
            {
                __instance.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
            }

            if (title.StartsWith("Discard"))
            {
                var rect = __instance.GetComponent<RectTransform>();
                rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.Load), typeof(Action<ItemType>), typeof(IsItemInteractable))]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.Load), typeof(ItemMenuResult))]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.Load), typeof(IsItemInteractable), typeof(bool), typeof(Monster))]
    [HarmonyPatch(typeof(InventoryHUD), nameof(InventoryHUD.LoadInBattle))]
    public static void InventoryHUD_LoadData(ref InventoryHUD __instance)
    {
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1);
        //make 25% smaller scale from existing
        var x = __instance.transform.localScale.x - __instance.transform.localScale.x * 0.25f;
        var y = __instance.transform.localScale.y - __instance.transform.localScale.y * 0.25f;
        __instance.transform.localScale = new Vector3(x, y, 1);


        __instance.ItemSlotsContainer.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
        __instance.XButton.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
        __instance.DescriptionText.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, 1, 1);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsController), nameof(OptionsController.Load))]
    public static void OptionsController_Load(OptionsController __instance)
    {
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionResolution), nameof(OptionResolution.isResolutionSupported))]
    public static void OptionResolution_isResolutionSupported(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuHUD), nameof(MainMenuHUD.show))]
    public static void MainMenuHUD_show(MainMenuHUD __instance)
    {
        __instance.Group.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
        var gradient = __instance.transform.Find("Hub/Gradient");
        gradient.localScale = gradient.localScale with {y = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveGameScreen), nameof(SaveGameScreen.LoadData))]
    [HarmonyPatch(typeof(SaveGameScreen), nameof(SaveGameScreen.Load))]
    public static void SaveGameScreen_Load(SaveGameScreen __instance)
    {
        __instance.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1);
        var rect = __instance.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
    }


    /// <summary>
    /// Adjusts the given rectangle to fit a new aspect ratio while maintaining the center and the original height.
    /// </summary>
    /// <param name="originalRect">The original Rect object.</param>
    /// <param name="targetAspectRatio">The desired aspect ratio (width to height).</param>
    /// <returns>A new Rect object with the adjusted width to match the target aspect ratio.</returns>
    private static Rect AdjustToAspectRatio(Rect originalRect, float targetAspectRatio)
    {
        // Calculate the new width based on the target aspect ratio and the height of the original rectangle
        var newWidth = originalRect.height * targetAspectRatio;

        // Calculate the difference in width to adjust the x position to keep the rectangle centered
        var widthDifference = newWidth - originalRect.width;

        // Return a new rect with adjusted x position and width
        return new Rect(originalRect.x - widthDifference / 2, originalRect.y, newWidth, originalRect.height);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.getBounds))]
    public static void CameraController_getBounds(ref CameraController __instance, ref Vector2 pos, ref Rect __result)
    {
        __result = AdjustToAspectRatio(__result, Plugin.MainAspect);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Getter)]
    public static void Camera_orthographicSize(ref Camera __instance, ref float __result)
    {
        if (!CameraControllerInstance) return;
        __result = CameraControllerInstance.targetOrthographicSize;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.NormalOrthographicSize), MethodType.Getter)]
    public static void CameraController_NormalOrthographicSize(ref CameraController __instance, ref float __result)
    {
        __result *= Plugin.ConfigZoom.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraController), nameof(CameraController.targetOrthographicSize), MethodType.Getter)]
    public static void CameraController_targetOrthographicSize(ref CameraController __instance, ref float __result)
    {
        __result *= Plugin.ConfigZoom.Value;
    }
}