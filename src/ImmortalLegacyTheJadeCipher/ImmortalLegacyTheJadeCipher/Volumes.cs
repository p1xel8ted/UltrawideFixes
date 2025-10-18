namespace ImmortalLegacyTheJadeCipher;

public static class Volumes
{
    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    private static int _startOrder = 80;

    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();

    internal static void UpdateSingleAntialiasing(PostProcessLayer layer)
    {
        layer.antialiasingMode = ConfigManager.Antialiasing.Value;
        if (layer.antialiasingMode == PostProcessLayer.Antialiasing.TemporalAntialiasing)
        {
            layer.temporalAntialiasing.sharpness = ConfigManager.TaaSharpness.Value;
        }
    }

    private static readonly string[] SkipThese = ["CommonSettings", "Streak", "Bleedandheal", "Parameters"];

    internal static void UpdateAntialiasing()
    {
        foreach (var layer in Resources.FindObjectsOfTypeAll<PostProcessLayer>())
        {
            UpdateSingleAntialiasing(layer);
        }
    }

    private static bool ShouldSkip(string name)
    {
        var wholeContains = SkipThese.Any(name.ContainsIgnoreCase);
        var partialContains = SkipThese.Any(s => s.ContainsIgnoreCase(name) && name.Length > 3);
        return wholeContains || partialContains;
    }

    internal static void ProcessVolumeRegistration(PostProcessVolume volume)
    {
        foreach (var vol in volume.profile.settings)
        {
            var name = vol.GetType().Name;

            if (ShouldSkip(name)) continue;

            var configEntryGlobal = ConfigManager.ConfigFileInstance.Bind("05. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!ConfigManager.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 3, MessageDisplayer.Corner.TopLeft, 10, Color.white);
            }
        }
    }

    public static void UpdateSingleVolume(PostProcessEffectSettings volume)
    {
        var name = volume.GetType().Name;
        if (ShouldSkip(name)) return;
        if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
        {
            volume.active = configEntryGlobal.Value;
        }
    }


    internal static void UpdateVolumes()
    {
        var volumes = Resources.FindObjectsOfTypeAll<PostProcessEffectSettings>();
        foreach (var vol in volumes)
        {
            UpdateSingleVolume(vol);
        }

        var volumeComponents = Resources.FindObjectsOfTypeAll<Volume>();
        foreach (var vol in volumeComponents)
        {
            UpdateSingleVolume(vol);
        }
    }

    public static void ProcessVolumeRegistration(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetType().Name;
            if (ShouldSkip(name)) continue;
            var configEntryGlobal = ConfigManager.ConfigFileInstance.Bind("05. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!ConfigManager.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 3, MessageDisplayer.Corner.TopLeft, 10, Color.white);
            }
        }
    }

    public static void UpdateSingleVolume(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetType().Name;
            if (ShouldSkip(name)) continue;
            if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
            {
                vol.active = configEntryGlobal.Value;
            }
        }
    }
}