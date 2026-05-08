namespace MousePiForHire.Infrastructure;

// Post-processing controls. Adds a config toggle for each effect found in the current scene
// (under "02. Post-Processing") and turns those effects on or off based on the config value.
public static class Volumes
{
    private static int _startOrder = 98;

    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntries = new();

    // Looks at every Volume in the scene, adds a config toggle for any effect we haven't seen
    // before, then applies the current values.
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

    // Applies the current config values to every matching effect in the scene. Runs whenever a
    // config toggle is changed, so changes take effect right away.
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
