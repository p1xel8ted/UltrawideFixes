namespace OrbosOdyssey;

/// <summary>
/// A collection of Harmony patches to modify and extend the behavior of the game's systems.
/// </summary>
[Harmony]
public static class Patches
{
    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    private static int _startOrder = 91;
    
    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    private static readonly Dictionary<int, ConfigEntry<bool>> ConfigEntries = new();

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
            var configEntry = Plugin.ConfigFile.Bind("03. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect. The default value will be the games default. Enabling it may not have an effect.", null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntry.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntries.TryAdd(vol.GetHashCode(), configEntry))
            {
                if (!Plugin.Notifications.Value) return;
                
                MessageDisplayer.Instance.ShowMessage($"Registered {name} configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 5, Color.white);
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
            foreach (var volumeComponent in vol.profile.components)
            {
                if (ConfigEntries.TryGetValue(volumeComponent.GetHashCode(), out var configEntry))
                {
                    volumeComponent.active = configEntry.Value;
                }
            }
        }
    }

    /// <summary>
    /// Updates volume components whenever post-processing handlers are started or updated.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessUpdateHandler), nameof(PostProcessUpdateHandler.Start))]
    [HarmonyPatch(typeof(PostProcessUpdateHandler), nameof(PostProcessUpdateHandler.UpdatePostProcessVolumes))]
    [HarmonyPatch(typeof(PostProcessUpdateHandler), nameof(PostProcessUpdateHandler.OnPostProcessingUpdate))]
    public static void PostProcessUpdateHandler_Start()
    {
        UpdateVolumes();
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

    /// <summary>
    /// Skips the splash screen and directly loads the main menu scene, applying settings beforehand.
    /// </summary>
    /// <param name="__instance">The SplashScreenManager instance being patched.</param>
    /// <returns>Always returns false to prevent the original method from executing.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreenManager), nameof(SplashScreenManager.Start))]
    public static bool SplashScreenManager_Start(SplashScreenManager __instance)
    {
        OptionsMenu.settings.Load();
        OptionsMenu.settings.Apply();

        SceneFader.Fade(__instance.sceneToLoad, Color.black);

        return false;
    }

    /// <summary>
    /// Prevents the splash screen from updating, effectively skipping it entirely.
    /// </summary>
    /// <returns>Always returns false to prevent the original method from executing.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreenManager), nameof(SplashScreenManager.Update))]
    public static bool SplashScreenManager_Update()
    {
        return false;
    }

    /// <summary>
    /// Ensures that canvas scalers use the "Expand" match mode when using "Scale With Screen Size", unless they contain "sinai" in their name.
    /// </summary>
    /// <param name="__instance">The CanvasScaler instance being enabled.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        // Skip processing if the CanvasScaler's name contains "sinai"
        if (__instance.name.Contains("sinai")) return;

        // Ensure the CanvasScaler uses the "Expand" match mode if it is set to ScaleWithScreenSize
        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            if (__instance.name == "PlayerCanvas")
            {
                __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            }
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
}