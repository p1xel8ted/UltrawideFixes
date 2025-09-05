namespace YouWillDieTonight.Misc;

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

    private static readonly Type[] ToBeProcessed =
    [
        typeof(DepthOfField),
        typeof(Bloom),
        typeof(ColorAdjustments),
        typeof(Vignette),
        typeof(FilmGrain),
        typeof(LensDistortion),
        typeof(MotionBlur),
        typeof(ChromaticAberration),
        typeof(ChannelMixer),
        typeof(LiftGammaGain),
        typeof(ShadowsMidtonesHighlights)
    ];

    internal static void ProcessVolumeRegistration(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            if (!ToBeProcessed.Contains(vol.GetType()))
            {
                Plugin.Log.LogInfo($"Skipping volume component '{vol.GetType().Name}' as it is not in the list of post-processing effects to be processed.");
                continue;
            }

            var name = vol.GetType().Name;
            var configEntryGlobal = Plugin.ConfigFile.Bind("04. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 10, Color.white);
            }
        }
    }

    public static void UpdateSingleVolume(Volume volume)
    {
        foreach (var volComp in volume.profile.components)
        {
            var name = volComp.GetType().Name;
            if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
            {
                volComp.active = configEntryGlobal.Value;
            }
        }
    }

    /// <summary>
    /// Updates all volume components to reflect the current state of their associated configuration entries.
    /// </summary>
    private static void UpdateVolumes()
    {
        var volumes = Resources.FindObjectsOfTypeAll<Volume>();
        foreach (var vol in volumes)
        {
            foreach (var volComp in vol.profile.components)
            {
                var name = volComp.GetType().Name;
                if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
                {
                    volComp.active = configEntryGlobal.Value;
                }
            }
        }
    }
}