namespace RoguePrinceOfPersia;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";
    private const string Raycast = "raycast";
    internal static bool VolumeUpdateRequired;

    private static readonly List<ContentSizeFitter> NormalUIContentSizeFitters = [];

    private static readonly List<ContentSizeFitter> HUDContentSizeFitters = [];

    private static readonly List<GameObject> CleanMenuItems = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.Update))]
    private static void Volume_Update_Vignette(Volume __instance)
    {
        var ap = __instance.profile;
        if (ap.TryGet(out Vignette vignetteComponent))
        {
            vignetteComponent.active = Plugin.Vignette.Value;
        }
    }

    internal static void UpdateSpanHUD()
    {
        NormalUIContentSizeFitters.RemoveAll(a => !a);
        HUDContentSizeFitters.RemoveAll(a => !a);

        foreach (var fitter in NormalUIContentSizeFitters)
        {
            try
            {
                var le = fitter.GetComponent<LayoutElement>();
                if (le)
                {
                    le.preferredWidth = 1920;
                    le.layoutPriority = 9999;
                }

                if (Plugin.RestrictHUD.Value && Plugin.IncludeUI.Value)
                {
                    fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
                }
                else
                {
                    fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                }

                fitter.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
            }
            catch (Exception e)
            {
                Plugin.Logger.LogWarning($"Error updating ContentSizeFitter: {e.Message}");
            }
        }

        foreach (var fitter in HUDContentSizeFitters)
        {
            try
            {
                var le = fitter.GetComponent<LayoutElement>();
                if (le)
                {
                    le.preferredWidth = 1920;
                    le.layoutPriority = 9999;
                }

                fitter.horizontalFit = Plugin.RestrictHUD.Value ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
                fitter.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
            }
            catch (Exception e)
            {
                Plugin.Logger.LogWarning($"Error updating ContentSizeFitter: {e.Message}");
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.Update))]
    private static void Volume_Update(Volume __instance)
    {
        if (!VolumeUpdateRequired) return;
        VolumeUpdateRequired = false;
        var ap = __instance.profile;

        if (ap.TryGet(out Bloom bloomComponent))
        {
            bloomComponent.active = Plugin.Bloom.Value;
        }

        if (ap.TryGet(out FilmGrain filmGrainComponent))
        {
            filmGrainComponent.active = Plugin.FilmGrain.Value;
        }

        if (ap.TryGet(out ChromaticAberration chromaticAberrationComponent))
        {
            chromaticAberrationComponent.active = Plugin.ChromaticAberration.Value;
        }

        if (ap.TryGet(out DepthOfField depthOfFieldComponent))
        {
            depthOfFieldComponent.active = Plugin.DepthOfField.Value;
            depthOfFieldComponent.aperture.value = Plugin.DepthOfFieldAperture.Value;
            depthOfFieldComponent.focusDistance.value = Plugin.DepthOfFieldFocusDistance.Value;
            depthOfFieldComponent.highQualitySampling.value = true;
        }

        if (ap.TryGet(out ColorAdjustments colorAdjustmentsComponent))
        {
            colorAdjustmentsComponent.active = Plugin.ColorAdjustments.Value;
        }
    }

    private static float GetNewScale(float reference)
    {
        var scale = 1f / (reference / Plugin.MainHeight);
        return scale;
    }

    private static void AddContentSizeFitter(GameObject go, string hudName = null)
    {
        var le = go.GetComponent<LayoutElement>() ?? go.AddComponent<LayoutElement>();

        var csf = go.GetComponent<ContentSizeFitter>() ?? go.AddComponent<ContentSizeFitter>();

        if (le)
        {
            le.preferredWidth = 1920;
            le.layoutPriority = 9999;
            le.enabled = true;
        }

        if (csf)
        {
            //     Plugin.Logger.LogInfo($"Adding ContentSizeFitter to {go.name}");
            csf.horizontalFit = Plugin.RestrictHUD.Value ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
            csf.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
            csf.enabled = true;

            if (string.IsNullOrWhiteSpace(hudName))
            {
                if (!Plugin.IncludeUI.Value)
                {
                    csf.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                }

                //normal UI component
                NormalUIContentSizeFitters.Add(csf);
            }
            else
            {
                //hud component
                HUDContentSizeFitters.Add(csf);
            }
        }
    }

    private static void UpdateBottomBar(Transform tr)
    {
        var bottomBar = tr.FindChild("InputFrame/Hrz Layout Group/Image");
        if (bottomBar)
        {
            var rect = bottomBar.GetComponent<RectTransform>();
            if (rect)
            {
                rect.sizeDelta = new Vector2(Plugin.MainWidth, 0);
            }
        }
    }

    private static void UpdateRectWidth(Transform tr, string find)
    {
        var parent = tr.FindChild(find);
        if (parent)
        {
            var rect = parent.GetComponent<RectTransform>();
            if (rect)
            {
                rect.sizeDelta = new Vector2(Plugin.MainWidth, 0);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ConfirmationPopup), nameof(ConfirmationPopup.Show))]
    private static void ConfirmationPopup_Show(ConfirmationPopup __instance)
    {
        var rect = __instance.GetComponent<RectTransform>();
        if (rect)
        {
            rect.sizeDelta = new Vector2(Plugin.MainWidth, 0);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BackgroundBlurred), nameof(BackgroundBlurred.OnEnable))]
    private static void BackgroundBlurred_OnEnable(BackgroundBlurred __instance)
    {
        var rect = __instance.GetComponent<RectTransform>();
        if (rect)
        {
            rect.sizeDelta = new Vector2(1080 * Plugin.MainAspectRatio, 1080);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ImageColorTarget), nameof(ImageColorTarget.SetColor))]
    private static void ImageColorTarget_SetColor(ImageColorTarget __instance, Color value)
    {
        if (__instance.Target.name.Equals("Background") && value.a < 0.5f)
        {
            var rect = __instance.GetComponent<RectTransform>();
            if (rect)
            {
                rect.sizeDelta = new Vector2(Plugin.MainWidth, 0);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PauseStackController), nameof(PauseStackController.Pause))]
    private static void PauseStackController_Pause(PauseStackController __instance)
    {
        //Pause Menu
        var pauseMenu = __instance.GetComponent<PauseUIView>();
        if (pauseMenu)
        {
            AddContentSizeFitter(__instance.gameObject);
            var bottomBar = __instance.transform.FindChild("Foreground");
            if (bottomBar)
            {
                UpdateBottomBar(bottomBar.transform);
            }

            UpdateRectWidth(__instance.transform, "Background");
        }
    }

    internal static void UpdateCleanMenu()
    {
        foreach (var go in CleanMenuItems.Where(go => go))
        {
            go.SetActive(!Plugin.CleanMenu.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BuildInfoWatermark), nameof(BuildInfoWatermark.Start))]
    private static void BuildInfoWatermark_Start(BuildInfoWatermark __instance)
    {
        CleanMenuItems.Add(__instance.gameObject);
        UpdateCleanMenu();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIBehaviourHandler), nameof(UIBehaviourHandler.OnEnable))]
    private static void UIBehaviourHandler_OnEnable(UIBehaviourHandler __instance)
    {
        var patchNotesButton = __instance.transform.FindChild("Button Patch Notes");
        if (patchNotesButton)
        {
            CleanMenuItems.Add(patchNotesButton.gameObject);
            UpdateCleanMenu();
        }

        var creditsButton = __instance.transform.FindChild("Button Credits");
        if (creditsButton)
        {
            CleanMenuItems.Add(creditsButton.gameObject);
            UpdateCleanMenu();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForgeMenuController), nameof(ForgeMenuController.Start))]
    private static void ForgeMenuController_Start(ForgeMenuController __instance)
    {
        AddContentSizeFitter(__instance.gameObject);
        var forgeView = __instance.transform.FindChild("ForgeView");
        if (forgeView)
        {
            UpdateRectWidth(forgeView, "Background_black");
            UpdateBottomBar(forgeView.transform);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //Map/Skills
        var tabbedView = __instance.transform.FindChild("TabbedView");
        if (tabbedView)
        {
            var mask = tabbedView.GetComponentsInChildren<Mask>();
            foreach (var m in mask)
            {
                m.enabled = false;
            }

            AddContentSizeFitter(tabbedView.gameObject);
            var bottomBar1 = tabbedView.transform.FindChild("Tab Layout/Content/TrinketTabView/trinket_inventory/trinket_inventory_ui");
            if (bottomBar1)
            {
                var rect1 = bottomBar1.GetComponent<RectTransform>();
                if (rect1)
                {
                    rect1.sizeDelta = new Vector2(Plugin.MainWidth, 0);
                }

                UpdateRectWidth(bottomBar1, "BackgroundPattern");

                var content = bottomBar1.FindChild("Content");
                
                UpdateBottomBar(content.transform);
            }

            var bottomBar2 = tabbedView.transform.FindChild("Tab Layout/Content/Minimap View/MinimapPanel");
            if (bottomBar2)
            {
                UpdateBottomBar(bottomBar2.transform);
            }

            var bottomBar3 = tabbedView.transform.FindChild("Tab Layout/Content/WorldMapTabView/Content");
            if (bottomBar3)
            {
                UpdateBottomBar(bottomBar3.transform);
            }

            var bottomBar4 = tabbedView.transform.FindChild("Tab Layout/Content/MindMapTabView/Content/MindMapPanel");
            if (bottomBar4)
            {
                UpdateBottomBar(bottomBar4.transform);
            }

            UpdateRectWidth(tabbedView, "Background");
        }


        var trinketView = __instance.transform.FindChild("TrinketCollectionView");
        if (trinketView)
        {
            AddContentSizeFitter(trinketView.gameObject);
            UpdateBottomBar(trinketView.transform);
            UpdateRectWidth(trinketView, "Background_black");
        }

        var wepCraftingView = __instance.transform.FindChild("WeaponCollectionViewVariant");
        if (wepCraftingView)
        {
            AddContentSizeFitter(wepCraftingView.gameObject);
            UpdateBottomBar(wepCraftingView.transform);
            UpdateRectWidth(wepCraftingView, "Background_black");
        }

        //Skill Tree
        var skillMenu = __instance.transform.FindChild("SkillTreeView");
        if (skillMenu)
        {
            AddContentSizeFitter(__instance.gameObject);
            var bottomBar = skillMenu.transform.FindChild("Content/MapPanel");
            if (bottomBar)
            {
                UpdateBottomBar(bottomBar.transform);
            }
        
            UpdateRectWidth(skillMenu, "Background");
        }


        //Main Menu
        var mainMenu = __instance.transform.FindChild("View_MainMenu");
        if (mainMenu)
        {
            AddContentSizeFitter(__instance.gameObject);
            UpdateBottomBar(mainMenu.transform);
        }


        //Map
        var map = __instance.transform.FindChild("Teleport View");
        if (map)
        {
            AddContentSizeFitter(map.gameObject);
            var bottomBar = map.transform.FindChild("MinimapPanel");
            if (bottomBar)
            {
                UpdateBottomBar(bottomBar.transform);
            }

            UpdateRectWidth(map, "Background");
        }

        //Left HUD
        var mainHUD = __instance.transform.FindChild("MainHUD");
        if (mainHUD)
        {
            AddContentSizeFitter(__instance.gameObject, "Left HUD");
        }

        //Right HUD
        var currencyView = __instance.transform.FindChild("CurrencyUIPrefab");
        if (currencyView)
        {
            AddContentSizeFitter(__instance.gameObject, "Right HUD");
        }

        //Options Menu
        var optionsMenu = __instance.transform.FindChild("Options View");
        if (optionsMenu)
        {
            AddContentSizeFitter(__instance.gameObject);
            var bottomBar = optionsMenu.transform.FindChild("MainContainer");
            if (bottomBar)
            {
                UpdateBottomBar(bottomBar.transform);
                UpdateRectWidth(bottomBar, "Dark Overlay");
            }
        }

        UpdateScaler(__instance);
    }

    private static void UpdateScaler(CanvasScaler scaler)
    {
        if (scaler.name.Contains(Sinai, StringComparison.OrdinalIgnoreCase)) return;
        if (scaler.name.Contains(Raycast, StringComparison.OrdinalIgnoreCase)) return;
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        var newScale = GetNewScale(scaler.referenceResolution.y);
        var pctFactor = Plugin.ScaleAdjustment.Value / 100f;
        var adjustedScale = newScale + newScale * pctFactor;
        scaler.scaleFactor = adjustedScale;
    }

    internal static void UpdateScalers()
    {
        foreach (var scaler in Utils.FindIl2CppType<CanvasScaler>())
        {
            UpdateScaler(scaler);
        }
    }
}