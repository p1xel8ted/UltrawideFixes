namespace Constance;

/// <summary>
/// Manages post-processing volume effects by dynamically registering configuration entries for each volume component.
/// Allows users to enable/disable individual post-processing effects at runtime.
/// </summary>
public static class Volumes
{
    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    private static int _startOrder = 98;

    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();

    /// <summary>
    /// Processes a newly registered volume by creating configuration entries for each of its components.
    /// Displays an optional notification when new effects are registered.
    /// </summary>
    /// <param name="volume">The volume to process and register configuration for.</param>
    internal static void ProcessVolumeRegistration(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetType().Name;

            // Create a configuration entry for this post-processing effect
            var configEntryGlobal = Plugin.ConfigFile.Bind("03. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { UpdateVolumes(); };

            // Show notification if this is a newly registered effect
            if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                Plugin.Log.LogInfo($"Registered '{name}' configuration entry for post-processing effect.");
                if (!Plugin.Notifications.Value) continue;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 12, Color.white);
            }
        }
    }

    /// <summary>
    /// Updates a single volume's components to reflect their configured enabled/disabled states.
    /// </summary>
    /// <param name="volume">The volume to update.</param>
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