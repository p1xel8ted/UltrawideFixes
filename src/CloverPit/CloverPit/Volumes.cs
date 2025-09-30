namespace CloverPit;

public static class Volumes
{
    internal enum AntialiasingMode
    {
        None = 0,
        SubpixelMorphologicalAntialiasing = 2,
        TemporalAntialiasing = 4
    }

    
    private static PostProcessLayer.Antialiasing ToPostProcessLayerAntialiasing(this AntialiasingMode mode) => mode switch
    {
        AntialiasingMode.None => PostProcessLayer.Antialiasing.None,
        AntialiasingMode.SubpixelMorphologicalAntialiasing => PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing,
        AntialiasingMode.TemporalAntialiasing => PostProcessLayer.Antialiasing.TemporalAntialiasing,
        _ => PostProcessLayer.Antialiasing.None
    };
    
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
            layer.antialiasingMode = ToPostProcessLayerAntialiasing(Plugin.Antialiasing.Value);
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
            layer.antialiasingMode = ToPostProcessLayerAntialiasing(Plugin.Antialiasing.Value);
        }

        foreach (var vol in volume.profile.settings)
        {
            var name = vol.GetType().Name;
            var configEntryGlobal = Plugin.ConfigFile.Bind("03. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 3, MessageDisplayer.Corner.TopLeft, 10, Color.white);
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