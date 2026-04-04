// Volumes.cs — Dynamic PPv2 post-processing volume management with runtime effect discovery.
// Hooks PostProcessVolume.OnEnable to inspect each volume's profile settings and create
// per-effect-type BepInEx config toggles on first encounter. Tracks all effect instances
// so toggling a config entry updates every volume containing that effect type.
// Prunes destroyed IL2CPP object references during both discovery and config change callbacks.

namespace TheEternalLifeOfGoldman;

internal static class Volumes
{
    private static int _startOrder = 60;
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntries = new();
    private static readonly Dictionary<string, List<PostProcessEffectSettings>> TrackedSettings = new();

    private static readonly Dictionary<string, string> Descriptions = new()
    {
        { "Bloom", "Adds a glow effect around bright lights and objects." },
        { "ColorGrading", "Controls overall color balance, contrast, and tone mapping." },
        { "DepthOfField", "Blurs the background and foreground to create a focused camera look." },
        { "ChromaticAberration", "Adds color fringing at the edges of the screen." },
        { "Vignette", "Darkens the edges of the screen for a cinematic feel." },
        { "MotionBlur", "Adds blur during fast camera movement." },
        { "AmbientOcclusion", "Adds subtle shadows in corners and crevices." },
        { "AutoExposure", "Automatically adjusts brightness based on scene lighting." },
        { "LensDistortion", "Adds barrel or pincushion lens distortion." },
        { "Grain", "Adds subtle film noise over the image. Disable for a cleaner look." }
    };

    internal static void ProcessVolume(PostProcessVolume volume)
    {
        if (volume == null || volume.profile == null) return;

        foreach (var setting in volume.profile.settings)
        {
            var name = setting.GetIl2CppType().Name;

            if (!TrackedSettings.TryGetValue(name, out var list))
            {
                list = [];
                TrackedSettings[name] = list;
            }

            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == null)
                {
                    list.RemoveAt(i);
                }
            }

            if (!list.Contains(setting))
            {
                list.Add(setting);
            }

            if (ConfigEntries.TryGetValue(name, out var existingEntry))
            {
                setting.active = existingEntry.Value;
                continue;
            }

            var description = Descriptions.TryGetValue(name, out var desc)
                ? desc
                : $"Toggle the {name} post-processing effect.";

            var configEntry = Plugin.ConfigFile.Bind("Graphics", name, setting.active,
                new ConfigDescription(description, null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntry.SettingChanged += (object sender, EventArgs e) => UpdateEffect(name);
            ConfigEntries[name] = configEntry;
            Plugin.Logger.LogInfo($"Registered '{name}' post-processing config entry.");
        }
    }

    private static void UpdateEffect(string effectName)
    {
        if (!ConfigEntries.TryGetValue(effectName, out var configEntry)) return;
        if (!TrackedSettings.TryGetValue(effectName, out var settings)) return;

        for (var i = settings.Count - 1; i >= 0; i--)
        {
            var setting = settings[i];
            if (setting == null)
            {
                settings.RemoveAt(i);
                continue;
            }

            setting.active = configEntry.Value;
        }
    }
}
