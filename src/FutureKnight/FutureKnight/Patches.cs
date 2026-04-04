namespace FutureKnight;

[Harmony]
public static class Patches
{
    private static int _startOrder = 94;

    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();

    // --- Ultrawide Core Fixes ---

    /// <summary>
    /// Prevent the game from pillarboxing cameras to 16:9.
    /// Forces all cameras to use the full viewport.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ViewportAspectRatioAdapter), nameof(ViewportAspectRatioAdapter.ApplyViewport))]
    public static void ViewportAspectRatioAdapter_ApplyViewport(ViewportAspectRatioAdapter __instance)
    {
        __instance._camera.rect = new Rect(0, 0, 1, 1);
    }

    /// <summary>
    /// Remove the decorative Game & Watch console frame on HUD init.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUDFrame), nameof(HUDFrame.Awake))]
    public static void HUDFrame_Awake(HUDFrame __instance)
    {
        if (!Plugin.RemoveConsoleFrame.Value) return;

        if (__instance.Frame)
        {
            __instance.Frame.SetActive(false);
        }

        if (__instance.Top)
        {
            __instance.Top.enabled = false;
        }

        if (__instance.Bottom)
        {
            __instance.Bottom.enabled = false;
        }
    }

    /// <summary>
    /// Override the game's hardcoded 16:9 resolution setter to use native display resolution instead.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GlobalShared), nameof(GlobalShared.ApplyVideoSettings))]
    public static bool GlobalShared_ApplyVideoSettings()
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow);
        return false;
    }

    // --- CanvasScaler Fix ---

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

    // --- Cinemachine ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(CinemachineVirtualCamera __instance)
    {
        var lens = __instance.m_Lens;
        lens.FarClipPlane = Mathf.Max(10000f, __instance.m_Lens.FarClipPlane);
        __instance.m_Lens = lens;
    }

    // --- Quality Settings ---

    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel_Prefix(ref bool applyExpensiveChanges)
    {
        applyExpensiveChanges = true;
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

    // --- Post-Processing Volume Management ---

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register), typeof(Volume), typeof(int))]
    public static void VolumeManager_Register(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.name.Replace("(Clone)", "");
            var configEntryGlobal = Plugin.ConfigFile.Bind("03. Post-Processing", name, vol.active,
                new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).",
                    null,
                    new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;

                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 5, Color.white);
            }
        }
    }

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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        UpdateVolumes();
    }
}
