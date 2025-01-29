using Doozy.Runtime.UIManager.Containers;

namespace RoguePrinceOfPersia;

[Harmony]
public static class Patches
{
    internal static bool VolumeUpdateRequired;

    private static readonly List<GameObject> CleanMenuItems = [];

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    private static readonly List<CanvasScaler> Scalers = [];
    internal static CanvasScaler ConfigCanvasScaler { get; private set; }

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


    [HarmonyPrefix]
    [HarmonyPatch(typeof(ConfirmationPopup), nameof(ConfirmationPopup.Show))]
    private static void ConfirmationPopup_Show(ConfirmationPopup __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BackgroundBlurred), nameof(BackgroundBlurred.OnEnable))]
    private static void BackgroundBlurred_OnEnable(BackgroundBlurred __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SaveSlotsViewUI), nameof(SaveSlotsViewUI.OnEnable))]
    private static void SaveSlotsViewUI_OnEnable(SaveSlotsViewUI __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "MainContainer/Content", LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "MainContainer/InputHints/Separator", LayoutController.LayoutSize.ForceFullScreen, 0, false);
    }

    // private static Transform VideoIntroPanel { get; set; }
    //
    // internal static void UpdateVideoPanelScale()
    // {
    //     var newScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
    //     if (VideoIntroPanel)
    //     {
    //         VideoIntroPanel.localScale = newScale;
    //     }
    // }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlayableDirector), nameof(PlayableDirector.Play), [])]
    private static void PlayableDirector_Play(PlayableDirector __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, false);

        // var videoPanel = __instance.transform.FindChild("Canvas/VideoPanel");
        // if (videoPanel)
        // {
        //     LayoutController.AddLayoutControllerRoot(videoPanel, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        //     VideoIntroPanel = videoPanel;
        //     UpdateVideoPanelScale();
        // }
        LayoutController.AddLayoutControllerPath(__instance.transform, "Canvas/VideoPanel", LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Canvas/EE", LayoutController.LayoutSize.ForceSixteenNine, 0, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Canvas/Ubisoft", LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseStackController), nameof(PauseStackController.Pause))]
    private static void PauseStackController_Pause(PauseStackController __instance)
    {
        //the footers when the user presses Esc in game to bring up the menu
        if (__instance.name == "Canvas")
        {
            //footer background
            LayoutController.AddLayoutControllerPath(__instance.transform, "Foreground/InputFrame/Hrz Layout Group/Image", LayoutController.LayoutSize.ForceFullScreen, 0, false);
            
            //footer buttons
            LayoutController.AddLayoutControllerPath(__instance.transform, "Foreground/InputFrame/Hrz Layout Group", LayoutController.LayoutSize.ConfigBased, 0, false);
        }

        //Pause Screen
        var pauseView = __instance.transform.FindChild("Pause View");
        if (pauseView)
        {
            //main pause menu
            LayoutController.AddLayoutControllerRoot(pauseView, LayoutController.LayoutSize.ConfigBased, 0, true);
            
            //backgrounds
            var bgs = __instance.transform.FindChildrenByName("Background");
            foreach (var bg in bgs)
            {
                LayoutController.AddLayoutControllerRoot(bg, LayoutController.LayoutSize.ForceFullScreen, 0, true);
            }
        }

        //Options Screen
        if (__instance.name == "Options View")
        {
            //main view
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);

            //background
            LayoutController.AddLayoutControllerPath(__instance.transform, "MainContainer/Dark Overlay", LayoutController.LayoutSize.ForceFullScreen, 0, true);

            //footer background
            LayoutController.AddLayoutControllerPath(__instance.transform, "MainContainer/InputFrame/Hrz Layout Group/Image", LayoutController.LayoutSize.ForceFullScreen, 0, false);
            
            //footer buttons
            LayoutController.AddLayoutControllerPath(__instance.transform, "MainContainer/InputFrame/Hrz Layout Group", LayoutController.LayoutSize.ConfigBased, 0, false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuUIView), nameof(MainMenuUIView.OnMainMenuEnter))]
    private static void MainMenuUIView_OnMainMenuEnter(MainMenuUIView __instance)
    {
        ProcessMainMenu(__instance.transform);
    }

    private static void ProcessMainMenu(Transform transform)
    {
        //main menu
        LayoutController.AddLayoutControllerRoot(transform, LayoutController.LayoutSize.ConfigBased, 0, true);
       
        //footer background
        LayoutController.AddLayoutControllerPath(transform, "InputFrame/Hrz Layout Group/Image", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        
        //footer buttons
        LayoutController.AddLayoutControllerPath(transform, "InputFrame/Hrz Layout Group", LayoutController.LayoutSize.ConfigBased, 0, false);
        
        var socials = transform.FindChild("Socials");
        var newsPanel = transform.FindChild("NewsPanel");
        var patchNotes = transform.FindChild("Menu_Right/Selection_Buttons/Button Patch Notes");
        var creditsButton = transform.FindChild("Menu_Right/Selection_Buttons/Button Credits");
        var transforms = new List<Transform>{socials, newsPanel, patchNotes, creditsButton};
        foreach (var t in transforms.Where(t => t))
        {
            CleanMenuItems.Add(t.gameObject);
            UpdateCleanMenu();
        }
    }
    
    internal static void UpdateCleanMenu()
    {
        foreach (var go in CleanMenuItems.Where(go => go))
        {
            go.SetActive(!Plugin.CleanMenu.Value);
        }
    }
    //NotificationBehavior

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NotificationBehavior), nameof(NotificationBehavior.ShowNotification))]
    private static void NotificationBehavior_ShowNotification(NotificationBehavior __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform,LayoutController.LayoutSize.ConfigBased, 0, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Background",LayoutController.LayoutSize.ForceFullScreen, 0, true);
    }
        
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(NotificationManager), nameof(NotificationManager.Awake))]
    // [HarmonyPatch(typeof(NotificationManager), nameof(NotificationManager.ShowNotification))]
    // private static void NotificationManager_Awake(NotificationManager __instance)
    // {
    //     LayoutController.AddLayoutControllerPath(__instance.transform, "NotificationBiomeUnlockPrefab(Clone)",LayoutController.LayoutSize.ConfigBased, 0, true);
    //     LayoutController.AddLayoutControllerPath(__instance.transform, "NotificationBiomeUnlockPrefab(Clone)/Background",LayoutController.LayoutSize.ForceFullScreen, 0, true);
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIView), nameof(UIView.Awake))]
    [HarmonyPatch(typeof(UIView), nameof(UIView.Execute))]
    private static void UIView_Awake(UIView __instance)
    {
        var name = __instance.name;

        if (name is "ForgeView" or "WeaponCollectionViewVariant" or "TrinketCollectionView")
        {
            //main ui
           // LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
            
            //container
            LayoutController.AddLayoutControllerPath(__instance.transform, "Container", LayoutController.LayoutSize.ForceSixteenNine, 0, true);
            
            //background
            LayoutController.AddLayoutControllerPath(__instance.transform, "Background_black", LayoutController.LayoutSize.ForceFullScreen, 0, true);
            
            //frame
            LayoutController.AddLayoutControllerPath(__instance.transform, "Window", LayoutController.LayoutSize.ForceFullScreen, 0, false);
            // LayoutController.AddLayoutControllerPath(__instance.transform, "Container/Window", LayoutController.LayoutSize.ForceFullScreen, 0, false);
            
            //footer background
            LayoutController.AddLayoutControllerPath(__instance.transform, "InputFrame/Hrz Layout Group/Image", LayoutController.LayoutSize.ForceFullScreen, 0, false);
            
            //buttons
            LayoutController.AddLayoutControllerPath(__instance.transform, "InputFrame/Hrz Layout Group", LayoutController.LayoutSize.ConfigBased, 0, false);
            
        }
        
        if (name == "Teleport View")
        {
            //main ui
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);  
            
            //background
            LayoutController.AddLayoutControllerPath(__instance.transform, "Image", LayoutController.LayoutSize.ForceFullScreen, 0, true);  
            
            //footer background
            LayoutController.AddLayoutControllerPath(__instance.transform, "MinimapPanel/InputFrame/Hrz Layout Group/Image", LayoutController.LayoutSize.ForceFullScreen, 0, false);
            
            //buttons
            LayoutController.AddLayoutControllerPath(__instance.transform, "MinimapPanel/InputFrame/Hrz Layout Group", LayoutController.LayoutSize.ConfigBased, 0, false);
        }
        
        if (name == "View_MainMenu")
        {
            ProcessMainMenu(__instance.transform);
        }
        
        if (name == "SkillTreeView")
        {
            //main skill ui
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
           
            //footer background
            LayoutController.AddLayoutControllerPath(__instance.transform, "Content/MapPanel/InputFrame/Hrz Layout Group/Image", LayoutController.LayoutSize.ForceFullScreen, 0, false);
           
            //footer buttons
            LayoutController.AddLayoutControllerPath(__instance.transform, "Content/MapPanel/InputFrame/Hrz Layout Group", LayoutController.LayoutSize.ConfigBased, 0, false);

            //backgrounds 
            var bgOne = __instance.transform.FindChild("Content/MapPanel/MainMapUICanvas/MapMask/MapParent/BackgroundPattern");
            var bgTwo =     __instance.transform.FindChild("Content/MapPanel/MainMapUICanvas/MapMask/MapParent/FakeMask");
            var backgrounds = new List<Transform> {bgOne, bgTwo};
            foreach (var bg in backgrounds)
            {
                var image = bg.GetComponent<Image>();
                image.maskable = false;
                image.m_IncludeForMasking = false;
                image.MarkDirty();
                LayoutController.AddLayoutControllerRoot(bg, LayoutController.LayoutSize.ForceFullScreen, 0, true);
            }
        }
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BuildInfoWatermark), nameof(BuildInfoWatermark.Start))]
    private static void BuildInfoWatermark_Start(BuildInfoWatermark __instance)
    {
        var parent = __instance.transform.parent;
        LayoutController.AddLayoutControllerRoot(parent, LayoutController.LayoutSize.ConfigBased, 0, false);
        
        CleanMenuItems.Add(parent.gameObject);
        UpdateCleanMenu();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ForgeMenuController), nameof(ForgeMenuController.Start))]
    private static void ForgeMenuController_Start(ForgeMenuController __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }

    private static void ProcessScaler(CanvasScaler scaler)
    {
        // var checkForHud = scaler.transform.FindChild("MainHUD");
        // if (checkForHud)
        // {
        //     scaler.enabled = false;
        //     return;
        // }
        //
        // var checkForCoin = scaler.transform.FindChild("CurrencyUIPrefab");
        // if (checkForCoin)
        // {
        //     scaler.enabled = false;
        //     return;
        // }
        
        if (scaler.name.Contains("sinai", StringComparison.OrdinalIgnoreCase) && !scaler.name.Contains("BepInExConfigManager", StringComparison.OrdinalIgnoreCase)) return;

        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        if (scaler.name.Contains("BepInExConfigManager", StringComparison.OrdinalIgnoreCase))
        {
            ConfigCanvasScaler = scaler;
            scaler.uiScaleMode = Plugin.CurrentAspect >= 3.7f ? CanvasScaler.ScaleMode.ScaleWithScreenSize : CanvasScaler.ScaleMode.ConstantPixelSize;
        }

        scaler.screenMatchMode = Plugin.MainAspectRatio > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CutsceneDirector), nameof(CutsceneDirector.Init))]
    private static void CutsceneDirector_Init(CutsceneDirector __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NarratorDialogueView), nameof(NarratorDialogueView.Awake))]
    private static void NarratorDialogueView_Awake(NarratorDialogueView __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
    }

    internal static void UpdateCanvasScalers()
    {
        var scalers = Scalers;
        foreach (var scaler in scalers.Where(scaler => scaler))
        {
            ProcessScaler(scaler);
        }
    }
}