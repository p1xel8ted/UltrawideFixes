﻿namespace Astronomics.Helpers;

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

    internal static void ProcessVolumeRegistration(PostProcessVolume volume)
    {
        foreach (var vol in volume.profile.settings)
        {
            var name = vol.name.Replace("(Clone)", "");
            var configEntryGlobal = Plugin.ConfigFile.Bind("01. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };
            if (Volumes.ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 5, Color.white);
            }
        }
    }

    public static void UpdateSingleVolume(PostProcessVolume volume)
    {
        foreach (var volComp in volume.profile.settings)
        {
            var name = volComp.name.Replace("(Clone)", "");
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
        var volumes = Resources.FindObjectsOfTypeAll<PostProcessVolume>();
        foreach (var vol in volumes)
        {
            foreach (var volComp in vol.profile.settings)
            {
                var name = volComp.name.Replace("(Clone)", "");
                if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
                {
                    volComp.active = configEntryGlobal.Value;
                }
            }
        }
    }
}