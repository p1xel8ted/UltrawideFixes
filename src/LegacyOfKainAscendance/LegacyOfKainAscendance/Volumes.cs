namespace LegacyOfKainAscendance;

/// <summary>
/// Manages URP post-processing volume effects by dynamically registering configuration entries for each volume component.
/// Allows users to enable/disable individual post-processing effects at runtime.
/// </summary>
public static class Volumes
{
    private static int _startOrder = 98;

    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntries = new();

    internal static void ScanAndApply()
    {
        foreach (var vol in Resources.FindObjectsOfTypeAll<Volume>())
        {
            if (!vol || !vol.profile) continue;

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
                    Plugin.Log.LogInfo($"Registered '{name}' post-processing config entry.");
                    if (Plugin.Notifications.Value)
                    {
                        MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 12, Color.white);
                    }
                }
            }
        }

        UpdateVolumes();
    }

    private static void UpdateVolumes()
    {
        foreach (var vol in Resources.FindObjectsOfTypeAll<Volume>())
        {
            if (!vol || !vol.profile) continue;

            foreach (var comp in vol.profile.components)
            {
                var name = comp.GetType().Name;
                if (ConfigEntries.TryGetValue(name, out var entry))
                {
                    comp.active = entry.Value;
                }
            }
        }
    }
}
