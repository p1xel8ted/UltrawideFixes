// ScreenEffects.cs — Configurable toggles for the game's custom ScreenEffectsUber shader effects.
// Creates BepInEx config entries for Paper Texture, Color Bleed, and Distortion.
// Sets both IL2CPP properties and backing fields, plus shader keywords directly on the material,
// to ensure effects are properly toggled regardless of how the game reads the state.
// Caches original PaperHighQuality per instance to preserve the game's quality setting when re-enabling.

namespace TheEternalLifeOfGoldman;

internal static class ScreenEffects
{
    private static int _startOrder = 80;
    private static bool _initialized;
    private static readonly Dictionary<int, bool> OriginalPaperHighQuality = new();

    private static ConfigEntry<bool> _paperToggle;
    private static ConfigEntry<bool> _colorBleedToggle;
    private static ConfigEntry<bool> _distortionToggle;

    private static void EnsureConfigInitialized()
    {
        if (_initialized) return;
        _initialized = true;

        _paperToggle = Plugin.ConfigFile.Bind("Graphics", "Paper Texture", true,
            new ConfigDescription("Adds a grainy paper/film texture overlay to the image. Disable for a cleaner look.", null,
                new ConfigurationManagerAttributes { Order = _startOrder-- }));

        _colorBleedToggle = Plugin.ConfigFile.Bind("Graphics", "Color Bleed", true,
            new ConfigDescription("Adds chromatic aberration (color fringing) at edges. Disable for a sharper image.", null,
                new ConfigurationManagerAttributes { Order = _startOrder-- }));

        _distortionToggle = Plugin.ConfigFile.Bind("Graphics", "Distortion", true,
            new ConfigDescription("Applies screen distortion effects.", null,
                new ConfigurationManagerAttributes { Order = _startOrder-- }));

        Plugin.Logger.LogInfo("ScreenEffects config entries initialized.");
    }

    internal static void ApplyToInstance(ScreenEffectsUber instance)
    {
        if (instance == null) return;

        EnsureConfigInitialized();

        var instanceId = instance.GetInstanceID();
        if (!OriginalPaperHighQuality.ContainsKey(instanceId))
        {
            OriginalPaperHighQuality[instanceId] = instance.PaperHighQuality;
        }

        instance.PaperEnabled = instance.paperEnabled = _paperToggle.Value;
        var originalPaperHighQuality = OriginalPaperHighQuality[instanceId];
        var paperHigh = _paperToggle.Value && originalPaperHighQuality;
        instance.PaperHighQuality = instance.paperHighQuality = paperHigh;
        instance.ColorBleedEnabled = instance.colorBleedEnabled = _colorBleedToggle.Value;
        instance.DistortionEnabled = instance.distortionEnabled = _distortionToggle.Value;

        if (instance.material != null)
        {
            instance.SetKeyword(ScreenEffectsUber.paperKeyword, _paperToggle.Value);
            instance.SetKeyword(ScreenEffectsUber.paperHighKeyword, paperHigh);
            instance.SetKeyword(ScreenEffectsUber.colorBleedKeyword, _colorBleedToggle.Value);
            instance.SetKeyword(ScreenEffectsUber.distortionKeyword, _distortionToggle.Value);
        }
    }
}
