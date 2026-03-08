using UnityEngine.Rendering;

namespace AllHandsOnDeck;

public static class Volumes
{
    private static int _startOrder = 80;

    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntries = new();
    private static readonly Dictionary<string, List<VolumeComponent>> TrackedComponents = new();

    internal static void ProcessVolumeRegistration(Volume volume, int layer)
    {
        if (!volume || !volume.profile)
        {
            return;
        }

        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetType().Name;

            if (!TrackedComponents.TryGetValue(name, out var list))
            {
                list = [];
                TrackedComponents[name] = list;
            }

            if (!list.Contains(vol))
            {
                list.Add(vol);
            }

            if (!ConfigEntries.ContainsKey(name))
            {
                var configEntry = Plugin.ConfigFile.Bind("02. Post-Processing", name, vol.active,
                    new ConfigDescription(
                        "Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).",
                        null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
                configEntry.SettingChanged += (_, _) => UpdateVolumeComponent(name);
                ConfigEntries[name] = configEntry;
                Plugin.Log.LogInfo($"Registered '{name}' post-processing configuration entry (layer: {LayerMask.LayerToName(layer)}).");

                if (Plugin.Notifications.Value)
                {
                    MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 12, Color.white);
                }
            }
        }
    }

    internal static void ProcessVolumeUnregister(Volume volume, int layer)
    {
        if (!volume || !volume.profile)
        {
            return;
        }

        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetType().Name;
            if (TrackedComponents.TryGetValue(name, out var list))
            {
                list.Remove(vol);
            }
        }
    }

    internal static void UpdateSingleVolume(Volume volume)
    {
        if (!volume || !volume.profile)
        {
            return;
        }

        foreach (var volComp in volume.profile.components)
        {
            var name = volComp.GetType().Name;
            if (ConfigEntries.TryGetValue(name, out var configEntry))
            {
                volComp.active = configEntry.Value;
            }
        }
    }

    private static void UpdateVolumeComponent(string componentName)
    {
        if (!ConfigEntries.TryGetValue(componentName, out var configEntry)) return;
        if (!TrackedComponents.TryGetValue(componentName, out var components)) return;

        for (var i = components.Count - 1; i >= 0; i--)
        {
            var volComp = components[i];
            if (!volComp)
            {
                components.RemoveAt(i);
                continue;
            }

            volComp.active = configEntry.Value;
        }
    }
}
