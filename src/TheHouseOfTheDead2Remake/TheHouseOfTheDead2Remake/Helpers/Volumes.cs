namespace TheHouseOfTheDead2Remake.Helpers;

public static class Volumes
{
    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    internal static int _startOrder = 80;

    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();

    private static void SetAllHighQuality()
    {
        var volumeSetters = Resources.FindObjectsOfTypeAll<MP_HDRPVolumeSetter>().ToList();
        foreach (var setter in volumeSetters.Where(setter => setter))
        {
            setter.AmbientOcclusion?.SetQuality(ScalableSettingLevelParameter.Level.High);
            setter.Bloom?.SetQuality(ScalableSettingLevelParameter.Level.High);
            setter.ContactShadows?.SetQuality(ScalableSettingLevelParameter.Level.High);
            setter.DepthOfField?.SetQuality(ScalableSettingLevelParameter.Level.High);
            setter.MotionBlur?.SetQuality(ScalableSettingLevelParameter.Level.High);
        }
    }
    
    internal static void ProcessVolumeRegistration(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetType().Name;
            var configEntryGlobal = Plugin.ConfigFile.Bind("05. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                 if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 15, Color.white);
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
    public static void UpdateVolumes()
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

        SetAllHighQuality();
    }
}