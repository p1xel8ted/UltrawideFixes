namespace MousePiForHire;

// URP post-processing controller. Registers a `ConfigEntry<bool>` per distinct VolumeComponent type
// found in the scene under `02. Post-Processing`, then applies the config-driven active state to
// every matching component on the loaded Volumes.
public static class Volumes
{
    private static int _startOrder = 98;

    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntries = new();

    // Walks every active Volume's profile, registers any new component type as a config entry,
    // then calls UpdateVolumes to push current values to scene components.
    internal static void ScanAndApply()
    {
        var newEntries = 0;
        var volumesScanned = 0;
        foreach (var vol in Resources.FindObjectsOfTypeAll<Volume>())
        {
            if (!vol || !vol.profile) continue;
            volumesScanned++;

            foreach (var comp in vol.profile.components)
            {
                var name = comp.GetType().Name;

                if (!ConfigEntries.ContainsKey(name))
                {
                    var entry = Plugin.ConfigFile.Bind("02. Post-Processing", name, comp.active,
                        new ConfigDescription("Enable or disable this post-processing effect. The default value may not be accurate. Enabling it may not have an effect in the current scene.",
                            null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
                    entry.SettingChanged += (_, _) => UpdateVolumes();
                    ConfigEntries[name] = entry;
                    newEntries++;
                    Plugin.Log.LogInfo($"[Volumes] Registered '{name}' post-processing config entry (default {comp.active}).");
                    if (Plugin.Notifications.Value)
                    {
                        MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 12, Color.white);
                    }
                }
            }
        }

        Plugin.Log.LogInfo($"[Volumes] ScanAndApply: scanned {volumesScanned} Volume(s), registered {newEntries} new config entry(s), total tracked {ConfigEntries.Count}.");
        UpdateVolumes();
    }

    // Pushes config values onto every matching VolumeComponent.active in the scene. Fires from
    // SettingChanged so config toggles take effect live.
    private static void UpdateVolumes()
    {
        var changed = 0;
        foreach (var vol in Resources.FindObjectsOfTypeAll<Volume>())
        {
            if (!vol || !vol.profile) continue;

            foreach (var comp in vol.profile.components)
            {
                var name = comp.GetType().Name;
                if (ConfigEntries.TryGetValue(name, out var entry) && comp.active != entry.Value)
                {
                    comp.active = entry.Value;
                    changed++;
                }
            }
        }
        if (changed > 0) Plugin.Log.LogInfo($"[Volumes] UpdateVolumes: applied {changed} component active-state change(s).");
    }
}
