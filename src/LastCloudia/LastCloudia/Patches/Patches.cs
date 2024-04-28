namespace LastCloudia.Patches;

[Harmony]
public static class Patches
{

    private static Transform TargetSwitchButtons { get; set; }
    private static Transform SkillButtons { get; set; }
    private static Transform UnitButtons { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIFirstGetPage), nameof(UIFirstGetPage.Show))]
    [HarmonyPatch(typeof(UIFirstGetPage), nameof(UIFirstGetPage.FrontShow))]
    public static void UIFirstGetPage_Show(ref UIFirstGetPage __instance)
    {
        var bottomEffect = __instance.transform.Find("btm_eff");
        if (bottomEffect)
        {
            bottomEffect.localPosition = bottomEffect.localPosition with {x = -(Plugin.MainWidth / 2f)};
            bottomEffect.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraSetting), nameof(CameraSetting.GetSetting))]
    public static void CameraSetting_GetSetting(ref CameraSetting __instance)
    {
        var screenHeight = Plugin.MainHeight;
        const float k = 648f;
        __instance.screenY = k / screenHeight;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICanvasScalerSimulator), nameof(UICanvasScalerSimulator.Start))]
    public static void UICanvasScalerSimulator_Start(ref UICanvasScalerSimulator __instance)
    {
        //Disables the jewellery curtain. 
        if (__instance.name.Equals("curtain"))
        {
            __instance.gameObject.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICanvasAlphaFader), nameof(UICanvasAlphaFader.OnEnable))]
    public static void UICanvasAlphaFader_OnEnable(ref UICanvasAlphaFader __instance)
    {
        
        var brown = __instance.transform.Find("overlay");
        if (brown)
        {
            brown.gameObject.SetActive(false);
        }
        
        var transform = __instance.transform.FindChild("bottom/screen_footer");
        if (transform)
        {
            transform.gameObject.SetActive(false);
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIEventDungeonPage), nameof(UIEventDungeonPage.EnterModal))]
    [HarmonyPatch(typeof(UIEventDungeonPage2), nameof(UIEventDungeonPage2.EnterModal))]
    public static void UIEventDungeonPage_OnEnable(ref UISingletonPageBase<UIEventDungeonPage> __instance)
    {
        var backFrame = __instance.transform.FindChild("Panel/backFrame");
        if (backFrame)
        {
            var rectTransform = backFrame.transform.GetComponent<RectTransform>();
            var width = -Plugin.NativeWidth;
            rectTransform.sizeDelta = rectTransform.sizeDelta with {x = width};
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UINewsList), nameof(UINewsList.Setup))]
    [HarmonyPatch(typeof(UINewsList), nameof(UINewsList.OnContentLayoutGroup))]
    public static void UINewsList_OnEnable(ref UINewsList __instance)
    {
        var backFrame = __instance.transform.FindChild("backFrame");
        if (backFrame)
        {
            var rectTransform = backFrame.transform.GetComponent<RectTransform>();
            var width = -Plugin.NativeWidth;
            rectTransform.sizeDelta = rectTransform.sizeDelta with {x = width};
        }
        var frontFrame = __instance.transform.FindChild("frontFrame");
        if (frontFrame)
        {
            frontFrame.gameObject.SetActive(false);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeaderRenderer), nameof(HeaderRenderer.Start))]
    [HarmonyPatch(typeof(HeaderRenderer), nameof(HeaderRenderer.UpdateUI))]
    public static void HeaderRenderer_UpdateUI(ref HeaderRenderer __instance)
    {
        var transform = __instance.transform.Find("shadow_effect");
        if (transform)
        {
            var rectTransform = transform.GetComponent<RectTransform>();
            rectTransform.sizeDelta = rectTransform.sizeDelta with {x = Plugin.MainWidth};
        }
    }


    private static void MoveUnitsToBottomRight()
    {
        if (UnitButtons && Plugin.HudLayoutOption.Value != Plugin.HudLayout.Default)
        {
            UnitButtons.position = new Vector3(132f, -41.5f, 99);
        }
    }

    private static void RemoveMobileBackground(Transform tf)
    {
        var bg = tf.Find("Interactable/Bottom/bg");
        if (bg)
        {
            bg.gameObject.SetActive(false);
        }
    }

    private static void MoveAttackButtonsToBottomHorizontally()
    {
        if (SkillButtons && Plugin.HudLayoutOption.Value == Plugin.HudLayout.New)
        {
            SkillButtons.position = new Vector3(0f, -60f, 99f);

            var magic = SkillButtons.transform.Find("mgc");
            if (magic)
            {
                magic.position = new Vector3(0f, -64.5f, 99f);
            }

            var skillButtons = SkillButtons.transform.Find("Skill");
            if (skillButtons)
            {
                var skill1 = skillButtons.Find("Skill1");
                skill1.transform.position = new Vector3(-50f, -62f, 99);

                var skill2 = skillButtons.Find("Skill2");
                skill2.transform.position = new Vector3(50f, -62f, 99);

                var skill3 = skillButtons.Find("Skill3");
                skill3.transform.position = skill3.transform.position with {y = -62f};

                var special = skillButtons.Find("Special");
                special.transform.position = special.transform.position with {y = -62f};
            }
        }
    }

    private static void MoveAttackButtonsToBottomSquare()
    {
        if (SkillButtons && Plugin.HudLayoutOption.Value == Plugin.HudLayout.Mix)
        {
            SkillButtons.position = new Vector3(0f, -60f, 99f);

            var magic = SkillButtons.transform.Find("mgc");
            if (magic)
            {
                magic.position = new Vector3(0f, -64.5f, 99f);
            }
        }
    }

    private static void MoveTargetSwitchToBottomLeft()
    {
        if (TargetSwitchButtons && Plugin.HudLayoutOption.Value != Plugin.HudLayout.Default)
        {
            TargetSwitchButtons.position = new Vector3(-132f, -64.5f, 99);

            var swtch = TargetSwitchButtons.transform.Find("unit_chg_bt");
            if (swtch)
            {
                swtch.position = new Vector3(-122f, -64.5f, 99f);
            }
            var stamp = TargetSwitchButtons.transform.Find("stamp_bt");
            if (stamp)
            {
                stamp.position = new Vector3(-122f, -64.5f, 99f);
            }
            var targetLock = TargetSwitchButtons.transform.Find("tgt_lock_bt");
            if (stamp)
            {
                targetLock.position = new Vector3(-122f, -64.5f, 99f);
            }

            var tgtCharge = TargetSwitchButtons.transform.Find("tgt_chg_bt");
            if (tgtCharge)
            {
                tgtCharge.position = new Vector3(-151.5f, -64.5f, 99f);
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleUiPanelMain), nameof(BattleUiPanelMain.OnLoaded))]
    public static void BattleUiPanelMain_OnLoaded(ref BattleUiPanelMain __instance)
    {
        TargetSwitchButtons = __instance.transform.Find("Interactable/Bottom/footer");

        UnitButtons = __instance.transform.Find("Interactable/Bottom/unit");

        SkillButtons = __instance.transform.Find("Interactable/Bottom/action");

        RemoveMobileBackground(__instance.transform);

        MoveHud();
    }

    private static void MoveHud()
    {
        MoveTargetSwitchToBottomLeft();
        MoveUnitsToBottomRight();
        MoveAttackButtonsToBottomHorizontally();
        MoveAttackButtonsToBottomSquare();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BattleUIManager), nameof(BattleUIManager.ShowCinesco))]
    public static bool BattleUIManager_ShowCinesco()
    {
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BtlUnitSelect), nameof(BtlUnitSelect.MoveCamera))]
    public static void BtlUnitSelect_MoveCamera(ref BtlUnitSelect __instance)
    {
        BtlUnitSelect.BaseCameraScreenOfs = new Vector2(-0.105f, -0.105f);
        BtlUnitSelect.CameraScreenOfsAll = new Vector2(-0.105f, -0.105f);
        __instance.CameraScreenOfs = new Vector2(-0.105f, -0.105f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashScene), nameof(SplashScene.Awake))]
    public static void SplashScene_Awake(ref SplashScene __instance)
    {
        __instance.DispTime = 0f;
        __instance.FadeOutTime = 0f;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIBattleResultTop), nameof(UIBattleResultTop.Setup))]
    public static void UIBattleResultTop_Setup(ref UIBattleResultTop __instance)
    {
        var mask = __instance.transform.FindChild("body1/Mission/MissionContents/Mask");
        if (mask)
        {
            var actualMask = mask.GetComponent<Image>();
            actualMask.enabled = false;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TiledBg), nameof(TiledBg.OnPopulateMesh))]
    [HarmonyPatch(typeof(TiledBg), nameof(TiledBg.GetModifiedMaterial))]
    [HarmonyPatch(typeof(TiledBg), nameof(TiledBg.ChangeBg))]
    public static void TiledBg_OnEnable(ref TiledBg __instance)
    {
        var newVector = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
        __instance.transform.localScale = newVector;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISubMenuNotice), nameof(UISubMenuNotice.Update))]
    public static void UISubMenuNotice_Update(ref UISubMenuNotice __instance)
    {
        var buttons = __instance.transform.FindChild("sub_menu/sub_fields");
        if (buttons)
        {
            buttons.transform.localPosition = buttons.transform.localPosition with {x = 106f};
        }
    }

    private static void DisableCinematicBars(Component canvasScaler)
    {
        var cinematicBars = canvasScaler.transform.Find("Faders/CineSco");
        if (cinematicBars)
        {
            cinematicBars.gameObject.SetActive(false);
        }
    }

    private static void ScaleTopBottomEffects(Component canvasScaler)
    {
        var resultBottomBg = canvasScaler.transform.FindDeepChild("btm_eff");
        if (resultBottomBg)
        {
            resultBottomBg.localPosition = resultBottomBg.localPosition with {x = -(Plugin.MainWidth / 2f)};
            resultBottomBg.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }

        var resultTopBg = canvasScaler.transform.FindDeepChild("top_eff");
        if (resultTopBg)
        {
            resultTopBg.localPosition = resultTopBg.localPosition with {x = -(Plugin.MainWidth / 2f)};
            resultTopBg.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }
    }

    private static void ScaleMenuBackground(Component canvasScaler)
    {
        var menuBackground = canvasScaler.transform.Find("BgGroup/Bg");
        if (menuBackground)
        {
            menuBackground.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1f);
        }
    }

    private static void DisableTitleMenuText(Component canvasScaler)
    {
        var titleOne = canvasScaler.transform.Find("TitlePanel/TitleName");
        if (titleOne)
        {
            titleOne.gameObject.SetActive(false);
        }

        var titleTwo = canvasScaler.transform.Find("TitlePanel/TitleName_part2");
        if (titleTwo)
        {
            titleTwo.gameObject.SetActive(false);
        }
    }

    private static void ReplaceMenuBackground(Component canvasScaler)
    {
        var menuBackground = canvasScaler.transform.Find("BgGroup/Bg");
        if (menuBackground)
        {
            var image = menuBackground.GetComponent<Image>();
            image.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
            var pivot = image.rectTransform.pivot;

            var resourceName = Plugin.MainAspectRatio switch
            {
                >= Plugin.SuperWideAspectRatio => "LastCloudia.assets.32-9.jpg",
                > Plugin.BaseAspectRatio => "LastCloudia.assets.21-9.jpg",
                _ => "LastCloudia.assets.21-9.jpg"
            };

            var assembly = Assembly.GetExecutingAssembly();
            var texture = new Texture2D(2, 2);

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    Plugin.Logger.LogError($"Embedded image resource not found: {resourceName}");
                    return;
                }

                var imageData = new byte[stream.Length];
                _ = stream.Read(imageData, 0, imageData.Length);
                texture.LoadImage(imageData);


                if (texture.width != Plugin.MainWidth || texture.height != Plugin.MainHeight)
                {
                    var rt = new RenderTexture(Plugin.MainWidth, Plugin.MainHeight, 0);

                    Graphics.Blit(texture, rt);

                    RenderTexture.active = rt;
                    var resizedTexture = new Texture2D(Plugin.MainWidth, Plugin.MainHeight);
                    resizedTexture.ReadPixels(new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight), 0, 0);
                    resizedTexture.Apply();

                    RenderTexture.active = null;
                    rt.Release();

                    texture = resizedTexture;
                }
            }

            image.sprite = Sprite.Create(texture, new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight), pivot);
            image.transform.localScale = Vector3.one;
        }
    }

    private static void AdjustCanvasScaler(CanvasScaler canvasScaler)
    {
        canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        AdjustCanvasScaler(__instance);

        DisableCinematicBars(__instance);

        ScaleTopBottomEffects(__instance);

        ScaleMenuBackground(__instance);

        if (!Plugin.UseNewMainMenu.Value) return;

        DisableTitleMenuText(__instance);

        ReplaceMenuBackground(__instance);
    }
}