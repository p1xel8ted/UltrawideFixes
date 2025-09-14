namespace LoreleiLaserEyes;

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

    private static readonly HashSet<PostProcessLayer> Layers = [];

    internal static void UpdateAntialiasing()
    {
        foreach (var layer in Layers.Where(layer => layer))
        {
            layer.antialiasingMode = Plugin.Antialiasing.Value;
            if (layer.antialiasingMode == PostProcessLayer.Antialiasing.TemporalAntialiasing)
            {
                layer.temporalAntialiasing.sharpness = Plugin.TaaSharpness.Value;
            }
        }
    }

    internal static void ProcessVolumeRegistration(PostProcessVolume volume)
    {
        var layer = volume.GetComponent<PostProcessLayer>();
        if (layer)
        {
            Layers.Add(layer);
            layer.antialiasingMode = Plugin.Antialiasing.Value;
        }

        foreach (var vol in volume.profile.settings)
        {
            var name = vol.GetType().Name;
            var configEntryGlobal = Plugin.ConfigFile.Bind("04. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 3, MessageDisplayer.Corner.TopRight, 10, Color.white);
            }
        }
    }

    public static void UpdateSingleVolume(PostProcessEffectSettings volume)
    {
        var name = volume.GetType().Name;
        if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
        {
            volume.active = configEntryGlobal.Value;
        }
    }

    /// <summary>
    /// Updates all volume components to reflect the current state of their associated configuration entries.
    /// </summary>
    private static void UpdateVolumes()
    {
        var volumes = Resources.FindObjectsOfTypeAll<PostProcessEffectSettings>();
        foreach (var vol in volumes)
        {
            var name = vol.GetType().Name;
            if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
            {
                vol.active = configEntryGlobal.Value;
            }
        }
    }
}