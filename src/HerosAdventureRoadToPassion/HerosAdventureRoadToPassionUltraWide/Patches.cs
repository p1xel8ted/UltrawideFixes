using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HerosAdventureRoadToPassionUltraWide;

[Harmony]
public static class Patches
{
    private static bool ClickedSpeedButton { get; set; }
    private static GameObject BlurBgGo { get; set; }
    private static IEnumerable<string> TextToSkip { get; } = ["NpcBigTalk", "NpcSmallTalk", "headchat", Const.StoryLogName];
    private static Dictionary<int, float> FontSizeDictionary { get; } = new();
    private static SafeAreaHelper SafeAreaHelperInstance { get; set; }
    private static Transform TxtEnergyLine { get; set; }
    private static Transform TxtPrizeLine { get; set; }
    private static Vector2 CloseButtonPosition => new(Plugin.WidthDifference, 485);
    
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

        __instance.autoInfoText.transform.position = new Vector3(0, -2, 10);
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
        var backgrounds = __instance.transform.FindChildrenByName(Const.BgPath);
        foreach (var bg in backgrounds)
        {
            bg.localScale = bg.localScale with {x = Plugin.PositiveScaleFactor};
            bg.gameObject.SetActive(true);
        }

        var blurBg = __instance.transform.FindFirstChildByName(Const.BlurBgName);
        if (blurBg != null)
        {
            Object.Destroy(blurBg.gameObject);
        }

        var modHelp = __instance.transform.FindFirstChildByName(Const.ButtonModHelpPath);
        modHelp.position = modHelp.position with {x = -2.5f};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerCreateUI), nameof(PlayerCreateUI.Show))]
    public static void PlayerCreateUI_Show(PlayerCreateUI __instance)
    {
        if (__instance.transform.FindChild(Const.BlurBgClone) == null)
        {
            var BlurBg = Object.Instantiate(BlurBgGo, __instance.transform, true);
            BlurBg.transform.SetAsFirstSibling();
            BlurBg.transform.SetAnchoredPosition(new Vector2(0, 0));
            BlurBg.transform.localScale = BlurBg.transform.localScale with {x = Plugin.PositiveScaleFactor};
        }

        var bg1 = __instance.transform.FindChild(Const.BgPath);
        bg1.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(RoamingUI), nameof(RoamingUI.OnEnable))]
    [HarmonyPatch(typeof(RoamingUI), nameof(RoamingUI.Show))]
    public static void RoamingUI_OnEnable(RoamingUI __instance)
    {
        Plugin.SetSafeArea(!Plugin.SixteenByNineHud.Value);

        var controllerTips = __instance.transform.FindFirstChildByName(Const.RoamingControllerIconTipsGroupName);
        controllerTips.localPosition = controllerTips.localPosition with {x = Plugin.AspectWidthDifference - 100f};

        if (!Plugin.SixteenByNineHud.Value) return;
        
        var localPosition = controllerTips.localPosition;
        var x = localPosition.x - Plugin.AspectWidthDifference;
        var y = localPosition.y;
        var location = new Vector2(x, y);
        controllerTips.SetAnchoredPosition(location);
    }

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
        tree.transform.SetAnchoredPosition(new Vector2(-6f, 6.2f));

        var hideTree = GameObject.Find(Const.Tree2Path);
        hideTree.SetActive(false);

        var ribbon = GameObject.Find(Const.RibbonPath);
        ribbon.transform.SetAnchoredPosition(new Vector2(0.1f, 0f));

        var grass = GameObject.Find(Const.GrassPath);
        grass.SetActive(true);

        var bg = GameObject.Find(Const.MainMenuBgPath);
        bg.transform.localScale = bg.transform.localScale with {x = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIWorldMapManager), nameof(UIWorldMapManager.Show))]
    public static void UIWorldMapManager_Show()
    {
        Plugin.SetSafeArea(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TradingWithNpcUI), nameof(TradingWithNpcUI.Show))]
    public static void TradingWithNpcUI_Show(TradingWithNpcUI __instance)
    {
        var closeButton = __instance.transform.FindFirstChildByName(Const.TradingNpcCloseName);
        closeButton.localPosition = closeButton.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIWorldMapManager), nameof(UIWorldMapManager.Hide))]
    public static void UIWorldMapManager_Hide()
    {
        Plugin.SetSafeArea(!Plugin.SixteenByNineHud.Value);
    }

    private static void IncreaseStoryLogWidth()
    {
        var textMeshProUGUIs = Utils.FindIl2CppType<TextMeshProUGUI>();
        foreach (var text in textMeshProUGUIs)
        {
            var path = text.transform.GetAbsolutePathInHierarchy();

            if (TextToSkip.Any(path.Contains))
            {
                if (path.Contains(Const.StoryLogName))
                {
                    //expand the width of the textbox
                    text.rectTransform.sizeDelta = text.rectTransform.sizeDelta with {x = 500};
                }
                continue;
            }

            text.enableWordWrapping = true;
            FontSizeDictionary.TryAdd(text.GetInstanceID(), text.fontSize);

            if (FontSizeDictionary.TryGetValue(text.GetInstanceID(), out var fontSize))
            {
                text.fontSize = fontSize - 4;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.Show))]
    public static void UISetting_Show(UISetting __instance)
    {
        var closeButton = __instance.CloseButton.transform;
        closeButton.localPosition = closeButton.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};

        var tabGroup = __instance.transform.FindFirstChildByName(Const.TabsGroupName);
        tabGroup.localPosition = tabGroup.localPosition with {x = Plugin.WidthDifference + 30f};

        var bg1 = GameObject.Find(Const.Blur1Path);
        var bg2 = GameObject.Find(Const.Blur2Path);

        bg1.SetActive(false);
        bg2.SetActive(false);
    }

    private static Transform AchievementCloseButton { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameEventManager), nameof(GameEventManager.LateUpdate))]
    public static void GameEventManager_LateUpdate()
    {
        if (AchievementUI.HasInstance() && AchievementUI.Instance.gameObject.activeSelf)
        {
            AchievementCloseButton ??= AchievementUI.Instance.transform.FindFirstChildByName(Const.BtnCloseName);
            AchievementCloseButton.localPosition = AchievementCloseButton.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIIllustratedHandbook), nameof(UIIllustratedHandbook.Show))]
    public static void UIIllustratedHandbook_Show(UIIllustratedHandbook __instance)
    {
        var closeButton = __instance.CloseButton.transform;
        closeButton.localPosition = closeButton.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};

        var tabGroup = __instance.transform.FindFirstChildByName(Const.TabsGroupName);
        tabGroup.localPosition = tabGroup.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.Update))]
    public static void UISetting_Update(UISetting __instance)
    {
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
        if (Plugin.SixteenByNineHud.Value)
        {
            SafeAreaHelperInstance.wideScreen = 0;
        }
        else
        {
            SafeAreaHelperInstance.wideScreen = Plugin.AspectWidthDifference;
        }
        SafeAreaHelperInstance.SetupArea();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(TradingWithFactionUI), nameof(TradingWithFactionUI.Show))]
    public static void TradingWithFactionUI_Show(TradingWithFactionUI __instance)
    {
        var sellClose = __instance.transform.FindFirstChildByName(Const.CloseButtonName);
        sellClose.localPosition = sellClose.localPosition with {x = Plugin.WidthDifference - 130f, y = CloseButtonPosition.y};

        var buyClose = __instance.transform.FindFirstChildByName(Const.TradeFactionCloseName);
        buyClose.localPosition = buyClose.localPosition with {x = 585f, y = 880f}; //no idea why this is so different from the other close button

        var idz = __instance.transform.FindFirstChildByName(Const.TradeFactionItemDisplayZoneOneName);
        idz.localPosition = idz.localPosition with {x = -415};

        var idzs = __instance.transform.FindFirstChildByName(Const.TradeFactionSellItemName);
        idzs.localPosition = idzs.localPosition with {x = -415};

        var idz2 = __instance.transform.FindFirstChildByName(Const.TradeFactionItemDisplayZoneTwoName);
        idz2.localPosition = idz2.localPosition with {x = -415};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIBattleActorInfo), nameof(UIBattleActorInfo.Show), typeof(bool))]
    [HarmonyPatch(typeof(UIBattleActorInfo), nameof(UIBattleActorInfo.Show), typeof(BattleActor))]
    public static void UIBattleActorInfo_Show(UIBattleActorInfo __instance)
    {
        var statOne = __instance.transform.FindFirstChildByName(Const.StatOneName);
        statOne.localPosition = statOne.localPosition with {x = -277};

        var statTwo = __instance.transform.FindFirstChildByName(Const.StatTwoName);
        statTwo.localPosition = statTwo.localPosition with {x = -126};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISundriesPanel), nameof(UISundriesPanel.OnEnable))]
    [HarmonyPatch(typeof(UISundriesPanel), nameof(UISundriesPanel.InitGoodsPanel))]
    public static void UISundriesPanel_Show(UISundriesPanel __instance)
    {
        var close = __instance.transform.FindFirstChildByName(Const.CloseButtonName);
        close.localPosition = close.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioBlackSide), nameof(ScenarioBlackSide.Show))]
    public static void ScenarioBlackSide_Show(ScenarioBlackSide __instance)
    {
        __instance.transform.FindChild(Const.UpSideBlackBar).gameObject.SetActive(false);
        __instance.transform.FindChild(Const.DownSideBlackBar).gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICabMapManager), nameof(UICabMapManager.Show), typeof(int))]
    [HarmonyPatch(typeof(UICabMapManager), nameof(UICabMapManager.Show), typeof(bool))]
    public static void UICabMapManager_Show(UICabMapManager __instance)
    {
        var bg = __instance.transform.FindFirstChildByName(Const.BgPath);
        bg.localPosition = bg.localPosition with {x = -Plugin.MiddleOfScreenX};
        bg.localScale = bg.localScale with {x = Plugin.PositiveScaleFactor};


        var parent = __instance.transform.FindFirstChildByName(Const.CabManagerBottomControlName);
        foreach (var transform in parent)
        {
            var t = transform.TryCast<Transform>();
            if (t == null) continue;

            if (t.name.Equals(Const.CabManagerGoName) || t.name.Equals(Const.CabManagerTxtCostName)) continue;

            if (t.name.Equals(Const.CabManagerTxtToName))
            {
                t.localPosition = t.localPosition with {x = -(Plugin.MiddleOfScreenX - 10f)};
            }
            var textMeshPro = t.GetComponentsInChildren<TextMeshProUGUI>();
            foreach (var text in textMeshPro)
            {
                text.enableAutoSizing = true;
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioSkipButton), nameof(ScenarioSkipButton.Show))]
    [HarmonyPatch(typeof(UIWorldMapManager), nameof(UIWorldMapManager.Update))]
    public static void ScenarioSkipButton_Show()
    {
        var icon = GameObject.Find(Const.ScenarioSkipControllerButtonPath);
        if (icon == null) return;
        icon.transform.SetAnchoredPosition(new Vector2(1065.094f, 485.8047f));
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIThankList), nameof(UIThankList.Show))]
    public static void UIThankList_Show(UIThankList __instance)
    {
        var background = __instance.transform.FindFirstChildByName(Const.BgPath);
        if (background == null) return;
        var transform = background.transform;
        transform.localScale = transform.localScale with {x = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MiningBatchUI), nameof(MiningBatchUI.Update))]
    [HarmonyPatch(typeof(MiningBatchUI), nameof(MiningBatchUI.GetDifficultyString))]
    [HarmonyPatch(typeof(MiningBatchUI), nameof(MiningBatchUI.GetBrokenString))]
    public static void MiningBatchUI_Show(MiningBatchUI __instance)
    {
        TxtEnergyLine ??= __instance.transform.FindChild(Const.TxtEnergyLineName);
        TxtPrizeLine ??= __instance.transform.FindChild(Const.TxtPrizeLineName);

        __instance.txtPrizeLessNum.transform.SetAnchoredPosition(new Vector2(-185, 333));
        TxtPrizeLine.transform.SetAnchoredPosition(new Vector2(-165, 333));
        __instance.txtPrizeTotalNum.transform.SetAnchoredPosition(new Vector2(-17, 333));

        AdjustPosition(__instance.txtPrizeLessNum.transform.position.x, __instance.txtEnergyLessNum.transform, -0.04f);
        AdjustPosition(TxtPrizeLine.position.x, TxtEnergyLine, -0.04f);
        AdjustPosition(__instance.txtPrizeTotalNum.transform.position.x, __instance.txtEnergyTotalNum.transform, -0.04f);

        var id = __instance.txtDiffcult.GetInstanceID();

        FontSizeDictionary.TryAdd(id, __instance.txtDiffcult.fontSize);
        if (!FontSizeDictionary.TryGetValue(id, out var size)) return;

        var fontSize = size - 8f;
        __instance.txtDiffcult.fontSize = fontSize;
        __instance.txtDiffcultNum.fontSize = fontSize;
        __instance.txtBrokenRatio.fontSize = fontSize;
        __instance.txtBrokenRatioNum.fontSize = fontSize;

        __instance.txtDiffcult.transform.position = __instance.txtDiffcult.transform.position with {x = -0.7874f};
        __instance.txtDiffcultNum.transform.position = __instance.txtDiffcultNum.transform.position with {x = -0.0925f};
        __instance.txtBrokenRatio.transform.position = __instance.txtBrokenRatio.transform.position with {x = 0.7506f};
        __instance.txtBrokenRatioNum.transform.position = __instance.txtBrokenRatioNum.transform.position with {x = 1.3587f};
    }

    private static void AdjustPosition(float referenceX, Transform target, float offsetX)
    {
        var position = target.position;
        position = new Vector3(referenceX + offsetX, position.y, position.z);
        target.position = position;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMenuPanel), nameof(UIMenuPanel.Show))]
    [HarmonyPatch(typeof(UIMenuPanel), nameof(UIMenuPanel.OnEnable))]
    public static void UIMenuPanel_Show_(UIMenuPanel __instance)
    {
        var closeButton = UIMenuPanel.Instance.transform.FindFirstChildByName(Const.CloseButtonName);
        closeButton.localPosition = closeButton.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};
        closeButton.localScale = closeButton.localScale with {x = Plugin.NegativeScaleFactor, y = Plugin.NegativeScaleFactor};

        var bottom = __instance.transform.FindFirstChildByName(Const.BottomName);
        if (bottom == null) return;
        bottom.localScale = bottom.localScale with {x = Plugin.PositiveScaleFactor};
        bottom.GetChild(0).localScale = bottom.GetChild(0).localScale with {x = Plugin.NegativeScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AchievementUI), nameof(AchievementUI.Show))]
    public static void AchievementUI_Show(AchievementUI __instance)
    {
        AchievementCloseButton = __instance.transform.FindFirstChildByName(Const.BtnCloseName);
        AchievementCloseButton.localPosition = AchievementCloseButton.localPosition with {x = Plugin.WidthDifference, y = CloseButtonPosition.y};

        var boxBg = __instance.transform.FindFirstChildByName(Const.AchievementBoxName);
        boxBg.GetChild(0).gameObject.SetActive(false);

        var blurBg = __instance.transform.FindFirstChildByName(Const.BlurBgClone);

        var bg1 = __instance.transform.FindFirstChildByName(Const.AchievementBgOneName);

        bg1.gameObject.SetActive(blurBg == null);

        if (blurBg == null && BlurBgGo != null)
        {
            var BlurBg = Object.Instantiate(BlurBgGo, __instance.transform, true);
            BlurBg.transform.SetAsFirstSibling();
            BlurBg.transform.SetAnchoredPosition(Vector2.zero);
        }
        else
        {
            blurBg.SetAnchoredPosition(Vector2.zero);
        }

        var scrollView = __instance.transform.FindFirstChildByName(Const.AchievementScrollViewName);
        scrollView.localPosition = scrollView.localPosition with {y = 400f};

        var tip = __instance.transform.FindFirstChildByName(Const.AchievementTipName);
        tip.localPosition = tip.localPosition with {y = -420f};
    }
    
    private static Transform QuitToDesktopButton { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(bool))]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(EscUI.SubUI))]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(EscUI.SubUI), typeof(bool))]
    public static void EscUI_Show(EscUI __instance)
    {
        Plugin.ConfigInstance.Reload();
        if (QuitToDesktopButton == null)
        {
            var quitButton = __instance.transform.FindFirstChildByName("Quit");
            var parent = __instance.transform.FindFirstChildByName("EscUI_Main");
            parent.localScale = new Vector3(0.75f, 0.75f, 1);
            QuitToDesktopButton = Object.Instantiate(quitButton, parent, true);
 
            var button = QuitToDesktopButton.GetComponent<Button>();
            var text = QuitToDesktopButton.GetComponentInChildren<TextMeshProUGUI>();
            text.text = "Quit to Desktop";
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() =>
            {
                GC.Collect();
                Application.Quit();
            });
        }

        if (__instance.transform.FindChild(Const.BlurBgClone) == null && BlurBgGo != null)
        {
            var BlurBg = Object.Instantiate(BlurBgGo, __instance.transform, true);
            BlurBg.transform.SetAsFirstSibling();
            BlurBg.transform.SetAnchoredPosition(Vector2.zero);
        }

        var tips = GameObject.Find(Const.HotTipBoxPath);
        if (tips != null)
        {
            tips.SetActive(!Plugin.DisableTips.Value);
        }
        IncreaseStoryLogWidth();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BlurBg), nameof(BlurBg.OnEnable))]
    public static void BlurBg_OnEnable(BlurBg __instance)
    {
        if (!__instance.transform.GetAbsolutePathInHierarchy().Contains(Const.ModObjectPath, StringComparison.OrdinalIgnoreCase))
        {
            BlurBgGo = __instance.gameObject;
            if (BlurBgGo != null)
            {
                if (BlurBgGo.gameObject != null)
                {
                    BlurBgGo.transform.localScale = BlurBgGo.transform.localScale with {x = 200f, y = 200f};
                    var background = BlurBgGo.gameObject.transform.FindChild(Const.BgPath);
                    background.gameObject.SetActive(false);
                }
            }
        }
        var transform = __instance.transform;
        transform.localScale = transform.localScale with {x = 200f, y = 200f};

        var center = __instance.gameObject.transform.parent.FindChild(Const.CenterPath);
        if (center == null) return;
        var bg = center.FindChild(Const.BgPath);
        if (bg != null)
        {
            bg.gameObject.SetActive(false);
        }
    }
}