namespace HerosAdventureRoadToPassion;

[Harmony]
public static class Patches
{


    private static bool ClickedSpeedButton { get; set; }
    private static GameObject BlurBgGo { get; set; }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution(ref int width, ref int height)
    {
        width = Plugin.SelectedWidth;
        height = Plugin.SelectedHeight;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleUI), nameof(BattleUI.Start))]
    public static void BattleUI_Start(BattleUI __instance)
    {
        // var background = __instance.ActorSelectNode.transform.FindChild(Const.BeforeBattleBottomBg);
        // background.localScale = background.localScale with {x = 20f};
        //
        // var beforeBattle = __instance.BeforeBattleGameObject.transform;
        // beforeBattle.position = beforeBattle.position with {y = -0.75f};

        var speedButton = GameObject.Find(Const.SpeedButtonPath);
        var button = speedButton.GetComponent<Button>();
        button.onClick.AddListener(() => ClickedSpeedButton = true);

        // __instance.autoInfoText.gameObject.transform.position = new Vector3(0, -2, 10);

        Plugin.UpdateScales();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Button), nameof(Button.OnPointerClick))]
    public static void Button_OnPointerClick(Button __instance, PointerEventData eventData)
    {
        if (__instance.name.Equals(Const.SpeedButton, StringComparison.OrdinalIgnoreCase) && eventData.button == PointerEventData.InputButton.Right)
        {
            ClickedSpeedButton = false;
            BattleUI.Instance.SwitchSpeed(1);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIModMain), nameof(UIModMain.Show))]
    public static void UIModMain_Show(UIModMain __instance)
    {
        var blurBg = __instance.transform.FindFirstChildByName(Const.BlurBgBgPath);
        blurBg.localScale = blurBg.localScale with {x = Plugin.PositiveScaleFactor};
        blurBg.gameObject.SetActive(true);

        var modHelp = __instance.transform.FindFirstChildByName("btnModHelp");
        modHelp.position = modHelp.position with {x = -2.3f};
        Plugin.UpdateScales();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerCreateUI), nameof(PlayerCreateUI.Show))]
    public static void PlayerCreateUI_Show(PlayerCreateUI __instance)
    {
        if (__instance.transform.FindChild(Const.BlurBgClone) == null)
        {
            var BlurBg = Object.Instantiate(BlurBgGo, __instance.transform, true);
            BlurBg.transform.SetAsFirstSibling();
            BlurBg.transform.position = new Vector3(0, 0, 10);
            BlurBg.transform.localScale = BlurBg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }

        var bg1 = __instance.transform.FindChild(Const.BlurBgBgPath);
        bg1.gameObject.SetActive(false);
        Plugin.UpdateScales();
    }
//
//
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(RoamingUI), nameof(RoamingUI.OnEnable))]
//     public static void RoamingUI_OnEnable(RoamingUI __instance)
//     {
//         var controllerTips = __instance.transform.FindChild(Const.AllControllerIconTipsGroupPath);
//         controllerTips.position = new Vector3(3, 0, 10);
//         if (!Plugin.ExpandUI.Value)
//         {
//             var localPosition = controllerTips.localPosition;
//             var x = localPosition.x - Plugin.AspectWidthDifference;
//             localPosition = localPosition with {x = x};
//             controllerTips.localPosition = localPosition;
//         }
//
//         Plugin.UpdateScales();
//     }
//
    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleUI), nameof(BattleUI.SwitchSpeed))]
    public static void BattleUI_SwitchSpeed(ref int speedLv)
    {
        if (!ClickedSpeedButton) return;
        ClickedSpeedButton = false;
        //means it was 3 (4x), and its being setting back to 1 as this a prefix
        if (speedLv == 1)
        {
            speedLv = 6;
            return;
        }

        speedLv = speedLv switch
        {
            6 => 8,
            8 => 10,
            10 => 12,
            12 => 14,
            14 => 16,
            16 => 18,
            18 => 20,
            >= 20 => 1,
            _ => speedLv
        };

        if (speedLv != 1 && speedLv % 2 != 0)
        {
            speedLv++;
        }

        if (speedLv >= 22)
        {
            speedLv = 1;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuUI), nameof(MainMenuUI.Show))]
    public static void MainMenuUI_Show(MainMenuUI __instance)
    {
        Plugin.ConfigInstance.Reload();
        if (!Plugin.CorrectMenu.Value) return;

        Plugin.OnSceneLoaded(SceneManager.GetActiveScene(), default);

        var tree = GameObject.Find(Const.Tree1Path);
        tree.transform.position = new Vector3(-6f, 6.2f, 0f);

        var hideTree = GameObject.Find(Const.Tree2Path);
        hideTree.SetActive(false);

        var ribbon = GameObject.Find(Const.RibbonPath);
        ribbon.transform.position = new Vector3(0.1f, 0f, 0f);

        var grass = GameObject.Find(Const.GrassPath);
        grass.SetActive(true);

        var bg = GameObject.Find(Const.MainMenuBgPath);
        bg.transform.localScale = bg.transform.localScale with {x = Plugin.PositiveScaleFactor};

        Plugin.UpdateScales();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIWorldMapManager), nameof(UIWorldMapManager.Show))]
    public static void UIWorldMapManager_Show(UIWorldMapManager __instance)
    {
        UpdateMapPosition();
        Plugin.UpdateScales();
    }

    private static void UpdateMapPosition()
    {
        foreach (var transform in UIWorldMapManager.Instance.transform)
        {
            var t = transform.TryCast<Transform>();
            if (t != null && t.name.StartsWith(Const.MapTransforms))
            {
                t.localPosition = t.localPosition with {x = 330};
            }
        }
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.Show))]
    public static void UISetting_Show(UISetting __instance)
    {
        var controllerTips = GameObject.Find(Const.ControllerTripsPath);
        controllerTips.transform.localPosition = new Vector3(415f, 45f, 0f);

        var close = __instance.CloseButton.GetComponent<RectTransform>();
        close.anchoredPosition = new Vector2(Mathf.RoundToInt(Plugin.SelectedWidth / 2f) - Plugin.AspectWidthDifference, 525f);

        var bg1 = GameObject.Find(Const.Blur1Path);
        var bg2 = GameObject.Find(Const.Blur2Path);

        bg1.SetActive(false);
        bg2.SetActive(false);

        Plugin.UpdateScales();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameEventManager), nameof(GameEventManager.LateUpdate))]
    [HarmonyPatch(typeof(UIIllustratedHandbook), nameof(UIIllustratedHandbook.Show))]
    public static void UIIllustratedHandbook_Show()
    {
        if (!UIIllustratedHandbook.Instance.gameObject.activeSelf) return;

        var controllerTips = GameObject.Find(Const.UiIllustratedHandbookControllerButtonsPath);
        var rectTransform = controllerTips.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(440f, 45f);

        var close = UIIllustratedHandbook.Instance.CloseButton.GetComponent<RectTransform>();
        close.anchoredPosition = new Vector2(Mathf.RoundToInt(Plugin.SelectedWidth / 2f) - Plugin.AspectWidthDifference, 525f);

        Plugin.UpdateScales();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.Update))]
    public static void UISetting_Update(UISetting __instance)
    {
        var close = __instance.CloseButton.GetComponent<RectTransform>();
        close.anchoredPosition = new Vector2(Mathf.RoundToInt(Plugin.SelectedWidth / 2f) - Plugin.AspectWidthDifference, 525f);

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            __instance.CloseButton.onClick.Invoke();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIRoot), nameof(UIRoot.Init))]
    public static void UIRoot_Init(UIRoot __instance)
    {
        var sa = __instance.transform.FindChild(Const.SafeArea);
        SafeAreaHelperInstance ??= sa.AddComponent<SafeAreaHelper>();
        SafeAreaHelperInstance.Start();
        SafeAreaHelperInstance.canvasSize = new Vector2(Plugin.SelectedWidth, Plugin.SelectedHeight);
        if (!Plugin.ExpandUI.Value)
        {
            SafeAreaHelperInstance.wideScreen = Plugin.AspectWidthDifference;
        }
        else
        {
            SafeAreaHelperInstance.wideScreen = 0;
        }
        SafeAreaHelperInstance.SetupArea();

        Plugin.UpdateScales();
    }

    private static SafeAreaHelper SafeAreaHelperInstance { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioBlackSide), nameof(ScenarioBlackSide.Show))]
    public static void ScenarioBlackSide_Show(ScenarioBlackSide __instance)
    {
        __instance.transform.FindChild(Const.UpSideBlackBar).gameObject.SetActive(false);
        __instance.transform.FindChild(Const.DownSideBlackBar).gameObject.SetActive(false);
    }
  
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioSkipButton), nameof(ScenarioSkipButton.Show))]
    [HarmonyPatch(typeof(UIWorldMapManager), nameof(UIWorldMapManager.Update))]
    public static void ScenarioSkipButton_Show()
    {
        UpdateMapPosition();
        
        var icon = GameObject.Find("GameSingletonRoot/WuLin.UIRoot(Clone)/SafeArea/ScenarioSkipButton/ScenarioSkipButton(Clone)/ControllerIconTipsGroup/Free/ButtonStartNoBg");
        if (icon != null)
        {
            var rectTransform = icon.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(1065.094f, 485.8047f);
        }
    }
//

//
//     private static Transform TxtEnergyLine { get; set; }
//     private static Transform TxtPrizeLine { get; set; }
//
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(MiningBatchUI), nameof(MiningBatchUI.Update))]
//     [HarmonyPatch(typeof(MiningBatchUI), nameof(MiningBatchUI.GetDifficultyString))]
//     [HarmonyPatch(typeof(MiningBatchUI), nameof(MiningBatchUI.GetBrokenString))]
//     public static void MiningBatchUI_Show(MiningBatchUI __instance)
//     {
//         TxtEnergyLine ??= __instance.transform.FindChild(Const.TxtEnergyLineName);
//         TxtPrizeLine ??= __instance.transform.FindChild(Const.TxtPrizeLineName);
//
//         AdjustPosition(__instance.txtPrizeLessNum.transform.position.x, __instance.txtEnergyLessNum.transform, -0.04f);
//         AdjustPosition(TxtPrizeLine.position.x, TxtEnergyLine, -0.04f);
//         AdjustPosition(__instance.txtPrizeTotalNum.transform.position.x, __instance.txtEnergyTotalNum.transform, -0.04f);
//
//         var id = __instance.txtDiffcult.GetInstanceID();
//
//         Plugin.FontSizeDictionary.TryAdd(id, __instance.txtDiffcult.fontSize);
//         if (!Plugin.FontSizeDictionary.TryGetValue(id, out var size)) return;
//
//         var fontSize = size - 8f;
//         __instance.txtDiffcult.fontSize = fontSize;
//         __instance.txtDiffcultNum.fontSize = fontSize;
//         __instance.txtBrokenRatio.fontSize = fontSize;
//         __instance.txtBrokenRatioNum.fontSize = fontSize;
//
//         __instance.txtDiffcult.transform.position = new Vector3(-0.59f, -1.3f, 10f);
//         __instance.txtDiffcultNum.transform.position = new Vector3(-0.065f, -1.3f, 10f);
//         __instance.txtBrokenRatio.transform.position = new Vector3(0.52f, -1.3f, 10f);
//         __instance.txtBrokenRatioNum.transform.position = new Vector3(0.98f, -1.3f, 10f);
//     }
//
//     private static void AdjustPosition(float referenceX, Transform target, float offsetX)
//     {
//         var position = target.position;
//         position = new Vector3(referenceX + offsetX, position.y, position.z);
//         target.position = position;
//     }
//
//
//     [HarmonyPostfix]
//     [HarmonyPatch(typeof(UIMenuPanel), nameof(UIMenuPanel.Show))]
//     [HarmonyPatch(typeof(UIMenuPanel), nameof(UIMenuPanel.OnEnable))]
//     public static void UIMenuPanel_Show_(UIMenuPanel __instance)
//     {
//         ChangeToConstantPixelSize();
//
//         var transform = __instance.transform;
//         transform.localScale = transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
//         Plugin.UpdateScales();
//
//         if (!Plugin.ExpandUI.Value) return;
//
//         var b1 = GameObject.Find(Const.UIRoleMenuPanelBottomPath);
//         var b2 = GameObject.Find(Const.UIPackBottomPath);
//         var b3 = GameObject.Find(Const.UIMartialArtsPath); //the white space is intentional....
//         var b4 = GameObject.Find(Const.NewAcupointBottomPath);
//         var b5 = GameObject.Find(Const.UIAbilityBottomPath);
//         var b6 = GameObject.Find(Const.UIRelationBottomPath);
//         var b7 = GameObject.Find(Const.UIStoryNoteBottomPath);
//         var objects = new[] {b1, b2, b3, b4, b5, b6, b7};
//         foreach (var obj in objects)
//         {
//             if (obj == null) continue;
//             obj.transform.localScale = obj.transform.localScale with {x = Plugin.PositiveScaleFactor};
//             obj.transform.GetChild(0).localScale = obj.transform.GetChild(0).localScale with {x = Plugin.NegativeScaleFactor};
//         }
//
//         var closeButton = GameObject.Find(Const.MenuPanelClosePath);
//         closeButton.transform.position = new Vector3(6.3f, 2.5f, 10f);
//         closeButton.transform.SetAsLastSibling();
//         closeButton.transform.localScale = closeButton.transform.localScale with {x = Plugin.NegativeScaleFactor, y = Plugin.NegativeScaleFactor};
//     }
//
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AchievementUI), nameof(AchievementUI.Show))]
    public static void AchievementUI_Show_Postfix(AchievementUI __instance)
    {
        var bg1 = GameObject.Find(Const.AchievementUiBg1Path);
        var bg2 = GameObject.Find(Const.AchievementUiBg2Path);
        var bg3 = GameObject.Find(Const.AchievementUiBg3Path);
        var objects = new[] {bg1, bg2, bg3};
        foreach (var obj in objects)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }

        var blurBg = __instance.transform.FindFirstChildByName(Const.BlurBgClone);
        if (blurBg == null)
        {
            var BlurBg = Object.Instantiate(BlurBgGo, __instance.transform, true);
            BlurBg.transform.SetAsFirstSibling();
            var rectTransform = BlurBg.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, 0);
            // BlurBg.transform.localScale = BlurBg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }
        else
        {
            var rectTransform = blurBg.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, 0);
        }

        Plugin.UpdateScales();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(bool))]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(EscUI.SubUI))]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(EscUI.SubUI), typeof(bool))]
    public static void EscUI_Show(EscUI __instance)
    {
        Plugin.ConfigInstance.Reload();

        if (__instance.transform.FindChild(Const.BlurBgClone) == null)
        {
            var BlurBg = Object.Instantiate(BlurBgGo, __instance.transform, true);
            BlurBg.transform.SetAsFirstSibling();
            BlurBg.transform.position = new Vector3(0, 0, 10);
            BlurBg.transform.localScale = BlurBg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }


        var tips = GameObject.Find(Const.HotTipBoxPath);
        if (tips != null)
        {
            tips.SetActive(!Plugin.DisableTips.Value);
        }

        Plugin.UpdateScales();
        Plugin.UpdateTextMesh();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BlurBg), nameof(BlurBg.OnEnable))]
    public static void BlurBg_OnEnable(BlurBg __instance)
    {
        BlurBgGo = __instance.gameObject;
        if (BlurBgGo != null)
        {
            if (BlurBgGo.gameObject != null)
            {
                BlurBgGo.transform.localScale = BlurBgGo.transform.localScale with {y = Plugin.PositiveScaleFactor};
                var background = BlurBgGo.gameObject.transform.FindChild("Bg");
                background.gameObject.SetActive(false);
            }
        }
        var transform = __instance.transform;
        transform.localScale = transform.localScale with {x = Plugin.PositiveScaleFactor};
        if (!__instance.gameObject.GetGameObjectPath().Equals(Const.UiMenuPanelCloneName, StringComparison.OrdinalIgnoreCase))
        {
            Plugin.UpdateScales();
        }

        var center = __instance.gameObject.transform.parent.FindChild(Const.BlurBgCenterPath);
        if (center == null) return;
        var bg = center.FindChild(Const.BlurBgBgPath);
        if (bg != null)
        {
            bg.gameObject.SetActive(false);
        }
    }
}