namespace HotelBarcelona;

/// <summary>
/// Tracks URP <see cref="Volume"/> components registered through <see cref="VolumeManager"/>
/// and dynamically creates BepInEx config entries for each unique post-processing effect type.
/// Allows users to toggle individual effects (atmospheric scattering, volumetric light, PCSS,
/// darkness, etc.) via the config file at runtime.
/// </summary>
internal static class Volumes
{
    /// <summary>Auto-decrementing order value for config entries to maintain registration order.</summary>
    private static int _startOrder = 80;

    /// <summary>Config entries keyed by volume component type name (e.g. "AtmosphericScatteringVolume").</summary>
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntries = new();

    /// <summary>All tracked component instances keyed by type name, for bulk state updates.</summary>
    private static readonly Dictionary<string, List<VolumeComponent>> TrackedComponents = new();

    /// <summary>Human-readable descriptions for known post-processing effect types.</summary>
    private static readonly Dictionary<string, string> Descriptions = new()
    {
        { "Bloom", "Adds a glow effect around bright lights and objects." },
        { "Tonemapping", "Balances bright and dark areas for a natural look. Disabling may wash out colors." },
        { "ColorAdjustments", "Controls overall brightness, contrast, and color intensity." },
        { "DepthOfField", "Blurs the background and foreground to create a focused camera look." },
        { "ChannelMixer", "Shifts color tones for the game's stylized color palette." },
        { "WhiteBalance", "Controls the warmth or coolness of the overall image." },
        { "Vignette", "Darkens the edges of the screen for a cinematic feel." },
        { "FilmGrain", "Adds subtle film noise over the image. Disable for a cleaner look." },
        { "LiftGammaGain", "Fine-tunes the color balance of dark, mid, and bright areas." },
        { "ShadowsMidtonesHighlights", "Adjusts colors separately in shadows, midtones, and highlights." },
        { "AtmosphericScatteringVolume", "Controls sky color, atmospheric haze, sun glow, and light shafts." },
        { "VolumetricLightVolume", "Adds visible fog and light beams. Disabling can improve performance." },
        { "DarknessVolume", "Creates areas of darkness that fade in around the player for atmosphere." },
        { "PCSSVolume", "Makes shadows look soft and natural. Disabling reverts to hard-edged shadows." },
        { "CommonVolume", "General rendering settings shared across visual effects." }
    };

    /// <summary>
    /// Processes a volume being registered with the <see cref="VolumeManager"/>. Iterates all
    /// <see cref="VolumeComponent"/> entries in the volume's profile, tracks them, and creates
    /// a config entry for each unique component type on first encounter.
    /// </summary>
    /// <param name="volume">The volume being registered.</param>
    /// <param name="layer">The layer the volume was registered on.</param>
    internal static void ProcessVolumeRegistration(Volume volume, int layer)
    {
        if (!volume || !volume.profile) return;

        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetIl2CppType().Name;

            if (!TrackedComponents.TryGetValue(name, out var list))
            {
                list = [];
                TrackedComponents[name] = list;
            }

            if (!list.Contains(vol))
            {
                list.Add(vol);
            }

            if (ConfigEntries.ContainsKey(name)) continue;

            var description = Descriptions.TryGetValue(name, out var desc)
                ? desc
                : $"Toggle the {name} post-processing effect.";

            var configEntry = Plugin.ConfigFile.Bind("02. Post-Processing", name, vol.active,
                new ConfigDescription(description, null, new ConfigurationManagerAttributes { Order = _startOrder-- }));
            configEntry.SettingChanged += (_, _) => UpdateVolumeComponent(name);
            ConfigEntries[name] = configEntry;
            Plugin.Logger.LogInfo($"Registered '{name}' post-processing config entry (layer: {LayerMask.LayerToName(layer)}).");
        }
    }

    /// <summary>
    /// Removes tracked component instances when a volume is unregistered from the
    /// <see cref="VolumeManager"/>, preventing stale references.
    /// </summary>
    /// <param name="volume">The volume being unregistered.</param>
    internal static void ProcessVolumeUnregister(Volume volume)
    {
        if (!volume || !volume.profile) return;

        foreach (var vol in volume.profile.components)
        {
            var name = vol.GetIl2CppType().Name;
            if (TrackedComponents.TryGetValue(name, out var list))
            {
                list.Remove(vol);
            }
        }
    }

    /// <summary>
    /// Applies the current config state to all components in a single volume.
    /// Called when a volume is enabled to ensure it reflects user preferences.
    /// </summary>
    /// <param name="volume">The volume whose components should be updated.</param>
    internal static void UpdateSingleVolume(Volume volume)
    {
        if (!volume || !volume.profile) return;

        foreach (var volComp in volume.profile.components)
        {
            var name = volComp.GetIl2CppType().Name;
            if (ConfigEntries.TryGetValue(name, out var configEntry))
            {
                volComp.active = configEntry.Value;
            }
        }
    }

    /// <summary>
    /// Updates the active state of all tracked instances of a specific component type
    /// to match its config entry value. Called when a config value changes.
    /// </summary>
    /// <param name="componentName">The type name of the component to update.</param>
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
