namespace TornAway;

[Harmony]
public static class Patches
{
    private static int _startOrder = 96;
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        if (__instance.name == "Background")
        {
            Plugin.AspectRatioFitters.Add(__instance);
            __instance.aspectRatio = Plugin.MainAspect;
        }

        if (__instance.name == "Scene Overlay")
        {
            var everythingOverlayView = __instance.transform.Find("EverythingOverlayView(Clone)");
            if (everythingOverlayView)
            {
                Plugin.AspectRatioTransforms.Add(everythingOverlayView);
                everythingOverlayView.localScale = everythingOverlayView.localScale with { x = Plugin.PositiveScaleFactor };
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        foreach (var vol in volume.profile.settings)
        {
            var name = vol.name.Replace("(Clone)", "");
            var configEntryGlobal = Plugin.ConfigFile.Bind("02. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;

                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 5, Color.white);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(TMPAppearanceAnimationComponent), nameof(TMPAppearanceAnimationComponent.OnUpdate))]
    public static void TMPAppearanceAnimationComponent_SetupTimings(TMPAppearanceAnimationComponent __instance)
    {
        if (!Plugin.FasterDialog.Value || __instance._textLength == 0)
        {
            return;
        }

        __instance.Speedup();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Dialog.Data), nameof(Dialog.Data.Create))]
    public static void Dialog_Data_Create(ref bool skippable, ref bool autopass, ref DialogManager.DialogTimeoutType timeout)
    {
        if (Plugin.FasterDialog.Value && timeout == DialogManager.DialogTimeoutType.Short)
        {
            timeout = DialogManager.DialogTimeoutType.Medium;
        }

        if (!skippable && Plugin.AllDialogSkippable.Value)
        {
            skippable = true;
        }

        if (!autopass && Plugin.AutoPassDialog.Value)
        {
            autopass = true;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void PostProcessManager_OnEnable(PostProcessVolume __instance)
    {
        foreach (var volComp in __instance.profile.settings)
        {
            var name = volComp.name.Replace("(Clone)", "");
            if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
            {
                if (configEntryGlobal != null)
                {
                    volComp.active = configEntryGlobal.Value;
                }
            }
        }
    }

    internal static void UpdateVolumes()
    {
        var viewByDemand = Resources.FindObjectsOfTypeAll<ViewByDemand>().FirstOrDefault(a => a.name == "EverythingOverlayView(Clone)");
        if (viewByDemand)
        {
            viewByDemand!.gameObject.SetActive(Plugin.AnimatedScreenOverlay.Value);
        }

        var volumes = Resources.FindObjectsOfTypeAll<PostProcessVolume>();
        foreach (var vol in volumes)
        {
            foreach (var volComp in vol.profile.settings)
            {
                var name = volComp.name.Replace("(Clone)", "");
                if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
                {
                    if (configEntryGlobal != null)
                    {
                        volComp.active = configEntryGlobal.Value;
                    }
                }
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(View), nameof(View.Show))]
    [HarmonyPatch(typeof(View), nameof(View.OnCreate))]
    public static void View_OnEnable(View __instance)
    {
        var background = __instance.transform.Find("Background");
        if (background)
        {
            background.localScale = background.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.AspectRatioTransforms.Add(background);
        }

        if (__instance.name == "EverythingOverlayView(Clone)")
        {
            Plugin.AspectRatioTransforms.Add(__instance.transform);
            __instance.transform.localScale = __instance.transform.localScale with { x = Plugin.PositiveScaleFactor };
        }

        if (__instance.name == "EverythingOverlayView(Clone)")
        {
            UpdateVolumes();
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DisplayManager), nameof(DisplayManager.SetResolution))]
    public static void DisplayManager_SetResolution()
    {
        Plugin.UpdateAspects();
        Plugin.UpdateCameras();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneBase), nameof(SceneBase.InitScene))]
    public static void SceneBase_InitScene(SceneBase __instance)
    {
        Plugin.UpdateAspects();
        Plugin.UpdateCameras();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(FadeInOutCanvasScreen), nameof(FadeInOutCanvasScreen.OnShow))]
    public static void FadeInOutCanvasScreen_OnShow(FadeInOutCanvasScreen __instance)
    {
        SingletonFromResourcesBase<ViewManager>.Instance.Hide<ScreenConstrains>();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneBase), nameof(SceneBase.SwitchCamera))]
    public static void SceneBase_SwitchCamera(Camera value)
    {
        if (value)
        {
            value.gateFit = value.aspect > Plugin.NativeAspect ? Camera.GateFitMode.Vertical : Camera.GateFitMode.Horizontal;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ScreenWithNativeCursor), nameof(ScreenWithNativeCursor.OnShow))]
    public static void ScreenWithNativeCursor_OnShow(ScreenWithNativeCursor __instance)
    {
        var background = __instance.transform.Find("Background");
        if (background)
        {
            background.localScale = background.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.AspectRatioTransforms.Add(background);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ColorOverlayScreen), nameof(ColorOverlayScreen.OnCreate))]
    public static void ColorOverlayScreen_OnCreate(ColorOverlayScreen __instance)
    {
        __instance.transform.localScale = __instance.transform.localScale with { x = Plugin.PositiveScaleFactor };
        Plugin.AspectRatioTransforms.Add(__instance.transform);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DemoStartCloseup), nameof(DemoStartCloseup.OnStart))]
    public static void DemoStartCloseup_OnStart(DemoStartCloseup __instance)
    {
        var background = __instance.transform.Find("Back");
        if (background)
        {
            background.localScale = background.localScale with { x = Plugin.PositiveScaleFactor };
            Plugin.AspectRatioTransforms.Add(background);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuScreen), nameof(MainMenuScreen.OnShow))]
    public static void MainMenuScreen_OnShow()
    {
        SingletonFromResourcesBase<ViewManager>.Instance.Show<ScreenConstrains>();
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SceneBase), nameof(SceneBase.InitUI))]
    public static void SceneBase_InitUI(SceneBase __instance)
    {
        SingletonFromResourcesBase<ViewManager>.Instance.Hide<ScreenConstrains>();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
}