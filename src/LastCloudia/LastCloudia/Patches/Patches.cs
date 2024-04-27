using World.UI.Home;

namespace LastCloudia.Patches;

[Harmony]
public static class Patches
{

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
    [HarmonyPatch(typeof(BattleCameraManager), nameof(BattleCameraManager.Init))]
    public static void BattleCameraManager_Init(ref BattleCameraManager __instance)
    {
        var bgMask = GameObject.Find("Shake/BgMask");
        if (bgMask)
        {
            var newVector = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            __instance.transform.localScale = newVector;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICanvasScalerSimulator), nameof(UICanvasScalerSimulator.Start))]
    public static void UICanvasScalerSimulator_Start(ref UICanvasScalerSimulator __instance)
    {
        var bgMask = GameObject.Find("CameraRoot/Shake/BgMask");
        if (bgMask)
        {
            var newVector = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            __instance.transform.localScale = newVector;
        }

        if (__instance.name.Equals("mask", StringComparison.OrdinalIgnoreCase))
        {
            var newVector = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            __instance.transform.localScale = newVector;
        }

        //Disables the jewellery curtain. 
        if (__instance.name.Equals("curtain"))
        {
            __instance.gameObject.SetActive(false);
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
            var ubRect = UnitButtons.GetComponent<RectTransform>();
            ubRect.anchorMax = Vector2.one;
            ubRect.anchorMin = Vector2.one;
            ubRect.pivot = new Vector2(1, 1);
            ubRect.localScale = new Vector3(0.8f, 0.8f, 1f);

            UnitButtons.position = new Vector3(143f, -43f, 99f);
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
            var sbRect = SkillButtons.GetComponent<RectTransform>();
            sbRect.anchorMin = new Vector2(0.5f, 0);
            sbRect.anchorMax = new Vector2(0.5f, 0);
            sbRect.pivot = new Vector2(0.5f, 0);
            sbRect.localScale = new Vector3(0.8f, 0.8f, 1f);

            SkillButtons.position = new Vector3(0f, -51f, 99);

            var magic = SkillButtons.transform.Find("mgc");
            if (magic)
            {
                magic.position = new Vector3(0f, -64.5f, 99f);
            }

            var attack = SkillButtons.transform.Find("Attack");
            if (attack)
            {
                attack.position = new Vector3(0f, -58f, 99);
            }

            var skillButtons = SkillButtons.transform.Find("Skill");
            if (skillButtons)
            {
                var skill1 = skillButtons.Find("Skill1");
                skill1.transform.position = new Vector3(-39f, -63.5f, 99);

                var skill2 = skillButtons.Find("Skill2");
                skill2.transform.position = new Vector3(40f, -63.5f, 99);

                var skill3 = skillButtons.Find("Skill3");
                skill3.transform.position = skill3.transform.position with {y = -64};

                var special = skillButtons.Find("Special");
                special.transform.position = new Vector3(17f, -64f, 99f);
            }
        }
    }

    private static Transform TargetSwitchButtons { get; set; }
    private static Transform SkillButtons { get; set; }
    private static Transform UnitButtons { get; set; }

    private static void MoveAttackButtonsToBottomSquare()
    {
        if (SkillButtons && Plugin.HudLayoutOption.Value == Plugin.HudLayout.Mix)
        {
            var sbRect = SkillButtons.GetComponent<RectTransform>();
            sbRect.anchorMin = new Vector2(0.5f, 0);
            sbRect.anchorMax = new Vector2(0.5f, 0);
            sbRect.pivot = new Vector2(0.5f, 0);
            sbRect.localScale = new Vector3(0.8f, 0.8f, 1f);

            SkillButtons.localPosition = new Vector3(0f, Plugin.MainHeight / 2f, 0f);

            var allButtons = SkillButtons.transform.Find("Skill");
            allButtons.position = new Vector3(0f, -34f, 99);

            var atkButtons = SkillButtons.transform.Find("Attack");
            atkButtons.position = new Vector3(0f, -58f, 99);

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
            var tsRect = TargetSwitchButtons.GetComponent<RectTransform>();

            tsRect.anchorMax = Vector2.zero;
            tsRect.anchorMin = Vector2.zero;
            tsRect.pivot = new Vector2(0, 0);
            tsRect.localScale = new Vector3(0.8f, 0.8f, 1f);

            TargetSwitchButtons.localPosition = new Vector3(Plugin.MainWidth / 2f, (Plugin.MainHeight / 2f) - 80, 0f);

            var swtch = TargetSwitchButtons.transform.Find("unit_chg_bt");
            if (swtch)
            {
                swtch.position = new Vector3(-131f, -65.5f, 99f);
            }
            var stamp = TargetSwitchButtons.transform.Find("stamp_bt");
            if (stamp)
            {
                stamp.position = new Vector3(-131f, -65.5f, 99f);
            }
            var targetLock = TargetSwitchButtons.transform.Find("tgt_lock_bt");
            if (stamp)
            {
                targetLock.position = new Vector3(-131f, -65.5f, 99);
            }

            var tgtCharge = TargetSwitchButtons.transform.Find("tgt_chg_bt");
            if (tgtCharge)
            {
                tgtCharge.position = new Vector3(-155f, -65.5f, 99f);
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

    internal static void MoveHud()
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
        var mask = GameObject.Find("CameraRoot/Shake/BgMask");
        if (mask)
        {
            mask.transform.localScale = new Vector3(Plugin.PositiveScaleFactor * 2f, Plugin.PositiveScaleFactor);
        }
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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        var cinematicBars = __instance.transform.Find("Faders/CineSco");
        if (cinematicBars)
        {
            cinematicBars.gameObject.SetActive(false);
        }
        
        var resultBottomBg = __instance.transform.FindDeepChild("btm_eff");
        if (resultBottomBg)
        {
            resultBottomBg.localPosition = resultBottomBg.localPosition with {x = -(Plugin.MainWidth / 2f)};
            resultBottomBg.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }

        var resultTopBg = __instance.transform.FindDeepChild("top_eff");
        if (resultTopBg)
        {
            resultTopBg.localPosition = resultTopBg.localPosition with {x = -(Plugin.MainWidth / 2f)};
            resultTopBg.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }
        var menuBackground = __instance.transform.Find("BgGroup/Bg");
        if (menuBackground != null)
        {
            menuBackground.localScale = new Vector3(Plugin.NegativeScaleFactor, Plugin.NegativeScaleFactor, 1f);
        }

        if (!Plugin.UseNewMainMenu.Value) return;

        var titleOne = __instance.transform.Find("TitlePanel/TitleName");
        if (titleOne)
        {
            titleOne.gameObject.SetActive(false);
        }

        var titleTwo = __instance.transform.Find("TitlePanel/TitleName_part2");
        if (titleTwo)
        {
            titleTwo.gameObject.SetActive(false);
        }


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
            var texture = new Texture2D(2, 2); // Temporary small size for initialization.

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
}