namespace WildWoods;

[Harmony]
public static class Patches
{
    internal static bool Online { get; private set; }

    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    private static int _startOrder = 93;

    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();
    
    /// <summary>
    /// Registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    /// <param name="volume">The volume being registered.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.name.Replace("(Clone)", "");
            var configEntryGlobal = Plugin.ConfigFile.Bind("04. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;

                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 5, Color.white);
            }
        }
    }

    /// <summary>
    /// Updates all volume components to reflect the current state of their associated configuration entries.
    /// </summary>
    internal static void UpdateVolumes()
    {
        var volumes = Resources.FindObjectsOfTypeAll<Volume>();
        foreach (var vol in volumes)
        {
            foreach (var volComp in vol.profile.components)
            {
                var name = volComp.name.Replace("(Clone)", "");
                if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
                {
                    volComp.active = configEntryGlobal.Value;
                }
            }
        }
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    /// <param name="__instance">The volume that was enabled.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        UpdateVolumes();
    }

    //skip dev logos
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SceneLoader), nameof(SceneLoader.Start))]
    public static void SceneLoader_Start(SceneLoader __instance)
    {
        __instance.isDelayActive = false;
        __instance.useClip = false;
        __instance.delay = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIPolicyPopupController), nameof(UIPolicyPopupController.ShowPolicy))]
    public static void UIPolicyPopupController_ShowPolicy(UIPolicyPopupController __instance)
    {
        PlayerPrefs.SetInt(__instance.SaveKey, 1);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Matrix4x4), nameof(Matrix4x4.Ortho))]
    public static void Matrix4x4_Ortho(ref float zFar)
    {
        zFar = Mathf.Max(10000f, zFar);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIResolutionDropdown), nameof(UIResolutionDropdown.SetScreenValue))]
    public static void UIResolutionDropdown_SetScreenValue()
    {
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DisableHudByMessage), nameof(DisableHudByMessage.Awake))]
    public static void DisableHudByMessage_Awake(DisableHudByMessage __instance)
    {
        if (__instance.name == "p_ui_game_hud")
        {
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ConfigBased);

            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "p_ui_tutorial_currentTaskOverlay/Content/background", Size.ForceFullScreen);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIIntro), nameof(UIIntro.Awake))]
    [HarmonyPatch(typeof(TinyView), nameof(TinyView.Start))]
    public static void TinyView_Show(TinyView __instance)
    {
        AddLayoutElementAndContentSizeFitterPath(__instance.transform, "p_ui_menu_background_view", Size.ConfigBased);
        AddLayoutElementAndContentSizeFitterPath(__instance.transform, "p_ui_menu_footer_container/Content", Size.ConfigBased);
        AddLayoutElementAndContentSizeFitterPath(__instance.transform, "p_ui_menu_footer_container/Background", Size.ForceFullScreen);
        AddLayoutElementAndContentSizeFitterPath(__instance.transform, "p_ui_menu_background_view/Background/Flat", Size.ForceFullScreen);

        var path = __instance.transform.GetTransformPath();
        if (path.Contains("p_ui_game_menu") && __instance.name == "RootView")
        {
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "Background", Size.ForceFullScreen);
            AddLayoutElementAndContentSizeFitterRoot(__instance.transform, Size.ForceFullScreen);
        }

        if (__instance.name.StartsWith("p_ui_tutorial_fullscreenOverlay"))
        {
            AddLayoutElementAndContentSizeFitterPath(__instance.transform, "Content", Size.ForceSixteenNine);
        }
    }

    private static void AddLayoutElementAndContentSizeFitterRoot(Transform transform, Size size)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
        lc.Size = size;

        lc.UpdateAspect();
    }

    private static void AddLayoutElementAndContentSizeFitterPath(Transform transform, string findPath, Size size)
    {
        var found = transform.Find(findPath);

        if (!found) return;

        AddLayoutElementAndContentSizeFitterRoot(found, size);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel(ref bool applyExpensiveChanges)
    {
        applyExpensiveChanges = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.SetOnline))]
    public static void LobbyManager_SetOnline(LobbyManager __instance)
    {
        Online = true;
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NetworkSceneLoader), nameof(NetworkSceneLoader.OnShutdown))]
    public static void LobbyManager_SetSetOffline(ShutdownReason shutdownReason)
    {
        if (shutdownReason != ShutdownReason.Ok) return;

        Online = false;
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int))]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel()
    {
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UniversalRenderPipelineAsset), nameof(UniversalRenderPipelineAsset.CreatePipeline))]
    [HarmonyPatch(typeof(UniversalRenderPipelineAsset), nameof(UniversalRenderPipelineAsset.CreateRenderers))]
    public static void UniversalRenderPipelineAsset_OnEnable(UniversalRenderPipelineAsset __instance)
    {
        Plugin.UpdateAll();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioCameraFitter), nameof(AspectRatioCameraFitter.CalculateCameraRect))]
    public static void AspectRatioCameraFitter_CalculateCameraRect(AspectRatioCameraFitter __instance)
    {
        __instance.cam.farClipPlane = Mathf.Max(10000f, __instance.cam.farClipPlane);

        var extraData = __instance.cam.GetUniversalAdditionalCameraData();
        if (extraData)
        {
            extraData.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
            extraData.dithering = true;
            extraData.antialiasingQuality = AntialiasingQuality.High;
        }

        if (Plugin.ShouldApplyUltrawideFix())
        {
            __instance.cam.aspect = Plugin.MainAspect;
            __instance.cam.rect = new Rect(0, 0, 1, 1);
            __instance.cam.pixelRect = new Rect(0, 0, Screen.width, Screen.height);

            // Adjust UI resolution for ultra-wide screens
            UIRootCanvas.referenceResolution = new Vector2(Mathf.RoundToInt(1080 * Plugin.MainAspect), 1080);
        }
        else
        {
            // Force 16:9 aspect ratio to disable ultra-wide fix
            __instance.cam.aspect = Plugin.NativeAspect; // 16/9
            UIRootCanvas.referenceResolution = new Vector2(1920, 1080);
        }

        __instance.cam.useOcclusionCulling = false;

        __instance.cam.ResetProjectionMatrix();
        __instance.cam.projectionMatrix = Matrix4x4.Perspective(
            __instance.cam.fieldOfView,
            __instance.cam.aspect,
            __instance.cam.nearClipPlane,
            __instance.cam.farClipPlane
        );
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Matrix4x4), nameof(Matrix4x4.Perspective))]
    public static void Matrix4x4_Perspective(ref float zFar)
    {
        zFar = Mathf.Max(10000f, zFar);
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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(CinemachineVirtualCamera __instance)
    {
        var lens = __instance.m_Lens;
        lens.FarClipPlane = Mathf.Max(10000f, __instance.m_Lens.FarClipPlane);
        __instance.m_Lens = lens;
    }

    internal enum Size
    {
        ConfigBased,
        ForceFullScreen,
        ForceSixteenNine
    }
}