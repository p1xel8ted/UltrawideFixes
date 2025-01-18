namespace HerosAdventureRoadToPassion;

[Harmony]
public static class Patches
{
  
    [HarmonyPostfix]
    [HarmonyPatch(typeof(TargetFrameRate), nameof(TargetFrameRate.Awake))]
    public static void TargetFrameRate_Awake(ref TargetFrameRate __instance)
    {
        __instance.targetFrameRate = QualitySettings.vSyncCount == 0 ? Plugin.TargetFramerate.Value : -1;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISlgMain), nameof(UISlgMain.Start))]
    public static void UISlgMain_Start(ref UISlgMain __instance)
    {
        AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
        var size = Plugin.SelectedResolution.height * Plugin.NativeAspect * 1.10f;
        AddLayoutControllerPath(__instance.transform, "Common/State/StateBg", LayoutController.LayoutSize.Custom, size, false);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScenarioSkipButton), nameof(ScenarioSkipButton.Awake))]
    public static void ScenarioSkipButton_Awake(ref ScenarioSkipButton __instance)
    {
        AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(RoamingUI), nameof(RoamingUI.Start))]
    public static void RoamingUI_Start(ref RoamingUI __instance)
    {
        AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISetting), nameof(UISetting.Awake))]
    public static void UISetting_Awake(ref UISetting __instance)
    {
        var center = __instance.transform.FindChild("Center");
        if (center)
        {
            //force settings UI to config setting
            AddLayoutControllerRoot(center, LayoutController.LayoutSize.ConfigBased, 0, true);

            //force background back to fullscreen
            AddLayoutControllerPath(center, "Bg", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        }
    }

    private static void AddLayoutControllerPath(Transform transform, string findPath, LayoutController.LayoutSize size, float customSize, bool useAspectRatioFitter)
    {
        var foundTransform = transform.Find(findPath);

        if (!foundTransform) return;

        AddLayoutControllerRoot(foundTransform, size, customSize, useAspectRatioFitter);
    }


    private static void AddLayoutControllerRoot(Transform transform, LayoutController.LayoutSize size, float customSize, bool useAspectRatioFitter)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
        lc.Init(size, customSize, useAspectRatioFitter);
        lc.UpdateAspect();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleUI), nameof(BattleUI.Start))]
    public static void BattleUI_Start(ref BattleUI __instance)
    {
        AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BlurBg), nameof(BlurBg.OnEnable))]
    public static void BlurBg_OnEnable(ref BlurBg __instance)
    {
        AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleUI), nameof(BattleUI.Start))]

    public static void BattleUI_Start(BattleUI __instance)
    {
        var speedButton = __instance.transform.FindChild("NormalBattle/BattleControlGroup/SpeedButton");
        var button = speedButton.GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener((UnityAction)ClickSpeed);
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

    private static void ClickSpeed()
    {
        var currentSpeed = Time.timeScale;
        BattleUI.Instance.SwitchSpeed(Mathf.RoundToInt(currentSpeed));
    }
    
    private static Transform QuitToDesktopButton { get; set; }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(bool))]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(EscUI.SubUI))]
    [HarmonyPatch(typeof(EscUI), nameof(EscUI.Show), typeof(EscUI.SubUI), typeof(bool))]
    public static void EscUI_Show(EscUI __instance)
    {
      
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
            button.onClick.AddListener((UnityAction)Quit);
        }
    }

    private static void Quit()
    {
        GC.Collect();
        Application.Quit();
    }



    [HarmonyPostfix]
    [HarmonyPatch(typeof(Button), nameof(Button.OnPointerClick))]
    public static void Button_OnPointerClick(Button __instance, PointerEventData eventData)
    {
        if (__instance.name.Equals("SpeedButton", StringComparison.OrdinalIgnoreCase) && eventData.button == PointerEventData.InputButton.Right)
        {
            BattleUI.Instance.SwitchSpeed(1);
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static bool PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        __instance.m_Camera.aspect = Plugin.CurrentAspect;
        __instance.m_Camera.pixelRect = new Rect(0, 0, Plugin.SelectedResolution.width, Plugin.SelectedResolution.height);
        __instance.m_Camera.rect = new Rect(0, 0, 1, 1);
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
}