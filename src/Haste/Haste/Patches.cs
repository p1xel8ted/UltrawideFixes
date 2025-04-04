namespace Haste;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        if (Volumes.ValidateVolume(volume))
        {
            Volumes.ProcessVolumeRegistration(volume);
        }
    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void PostProcessVolume_OnEnable(PostProcessVolume __instance)
    {
        if (Volumes.ValidateVolume(__instance))
        {
            Volumes.UpdateVolume(__instance);
        }
    }

    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Plugin.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CutsceneBorderPost), nameof(CutsceneBorderPost.OnRenderImage))]
    public static void CutsceneBorderPost_OnRenderImage(CutsceneBorderPost __instance)
    {
        __instance.enabled = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostGameScreen), nameof(PostGameScreen.Start))]
    public static void PostGameScreen_Start(PostGameScreen __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AlltimeStatsScreen), nameof(AlltimeStatsScreen.Start))]
    public static void AlltimeStatsScreen_Start(AlltimeStatsScreen __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "StatScreen", LayoutController.LayoutSize.Custom, 10000f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuMainPage), nameof(MainMenuMainPage.Start))]
    public static void MainMenuMainPage_Start(MainMenuMainPage __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TutorialPopUpHandler), nameof(TutorialPopUpHandler.OpenNewPopup))]
    [HarmonyPatch(typeof(TutorialPopUpHandler), nameof(TutorialPopUpHandler.TriggerPopUp))]
    public static void TutorialPopUpHandler_Start(TutorialPopUpHandler __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EscapeMenuMainPage), nameof(EscapeMenuMainPage.Start))]
    public static void EscapeMenuMainPage_Start(EscapeMenuMainPage __instance)
    {
        DisableButtons(__instance.transform);
    }

    private static void DisableButtons(Transform tr)
    {
        var buttons = tr.Find("ExtraButtons");
        if (buttons)
        {
            buttons.gameObject.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.Start))]
    public static void MainMenu_Start(MainMenu __instance)
    {
        DisableButtons(__instance.transform);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_UnlockedItemsScreen), nameof(UI_UnlockedItemsScreen.Start))]
    public static void UI_UnlockedItemsScreen_Start(UI_UnlockedItemsScreen __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.itemsScreen.transform, LayoutController.LayoutSize.ConfigBased, 0, false);
        LayoutController.AddLayoutControllerPath(__instance.itemsScreen.transform, "Background", LayoutController.LayoutSize.ForceFullScreen, 0, false);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_Stop), nameof(UI_Stop.Start))]
    public static void UI_Stop_Start(UI_Stop __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "StopUI/Fog_1", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "StopUI/Background", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "StopUI/Fog", LayoutController.LayoutSize.ForceFullScreen, 0, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WinShardEffect), nameof(WinShardEffect.Awake))]
    [HarmonyPatch(typeof(WinShardEffect), nameof(WinShardEffect.PlayEffect))]
    public static void WinShardEffect_Awake(WinShardEffect __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(EscapeMenu), nameof(EscapeMenu.Start))]
    public static void EscapeMenu_Start(EscapeMenu __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "Enabled", LayoutController.LayoutSize.ConfigBased, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Enabled/Background", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Enabled/Stripes", LayoutController.LayoutSize.ForceFullScreen, 0, false);
    }

    [HarmonyFinalizer]
    [HarmonyPatch(typeof(JiggleBone), nameof(JiggleBone.LateLateUpdate))]
    [HarmonyPatch(typeof(LateLateUpdateCaller), nameof(LateLateUpdateCaller.LateUpdate))]
    [HarmonyPatch(typeof(LookAtPlayer), nameof(LookAtPlayer.LateUpdate))]
    [HarmonyPatch(typeof(LevelSelectionNode), nameof(LevelSelectionNode.UpdateMaterialProperties))]
    [HarmonyPatch(typeof(LevelSelectionNode), nameof(LevelSelectionNode.Update))]
    [HarmonyPatch(typeof(Portal), nameof(Portal.Update))]
    [HarmonyPatch(typeof(SlowStep), nameof(SlowStep.OnEnable))]
    [HarmonyPatch(typeof(MaterialPropertyBlock), nameof(MaterialPropertyBlock.SetTexture), typeof(string), typeof(Texture))]
    [HarmonyPatch(typeof(SpeedPPSRenderer), nameof(SpeedPPSRenderer.Render))]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.OnPreCull))]
    [HarmonyPatch(typeof(PostProcessEffectRendererExtensions), nameof(PostProcessEffectRendererExtensions.RenderOrLog))]
    public static Exception ExceptionSpamSuppress()
    {
        return null;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuSettingsPage), nameof(MainMenuSettingsPage.Start))]
    public static void MainMenuSettingsPage_Start(MainMenuSettingsPage __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.settinsPage.transform.parent, LayoutController.LayoutSize.ConfigBased, 0, false);
        LayoutController.AddLayoutControllerPath(__instance.settinsPage.transform.parent, "Background", LayoutController.LayoutSize.ForceFullScreen, 0, false);
        LayoutController.AddLayoutControllerPath(__instance.settinsPage.transform.parent, "Stripes", LayoutController.LayoutSize.ForceFullScreen, 0, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;
        if (__instance.name.Contains("MessageCanvas")) return;


        if (__instance.name == "UI_Gameplay_Minimal")
        {
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
        }

        CanvasScalers.Add(__instance);

        UpdateScalers(Plugin.CurrentAspect);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameplayUIManager), nameof(GameplayUIManager.Start))]
    public static void GameplayUIManager_Start(GameplayUIManager __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraMovement), nameof(CameraMovement.Update))]
    public static void CameraMovement_Update(CameraMovement __instance)
    {
        if (Plugin.CameraFieldOfView.Value == 0)
        {
            Plugin.CameraFieldOfView.Value = 1f;
        }

        __instance.cam.cam.fieldOfView *= Plugin.CameraFieldOfView.Value;
    }
}