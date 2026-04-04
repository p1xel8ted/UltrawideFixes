// PostProcessing.cs — Configurable anti-aliasing mode selection for PPv2 PostProcessLayers.
// Lazily initializes a BepInEx config entry on first PostProcessLayer encounter, using the game's
// current AA mode as the default. Maps between a simplified enum (None/FXAA/SMAA) and Unity's
// PostProcessLayer.Antialiasing values. Applied every frame via CameraPostProcess.LateUpdate postfix.

namespace TheEternalLifeOfGoldman;

internal enum AntiAliasingMode
{
    None,
    FXAA,
    SMAA
}

internal static class PostProcessing
{
    private static int _startOrder = 70;
    private static bool _initialized;

    private static ConfigEntry<AntiAliasingMode> _antialiasingMode;

    private static readonly Dictionary<AntiAliasingMode, PostProcessLayer.Antialiasing> AaModeMap = new()
    {
        { AntiAliasingMode.None, PostProcessLayer.Antialiasing.None },
        { AntiAliasingMode.FXAA, PostProcessLayer.Antialiasing.FastApproximateAntialiasing },
        { AntiAliasingMode.SMAA, PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing }
    };

    private static readonly Dictionary<PostProcessLayer.Antialiasing, AntiAliasingMode> ReverseAaModeMap = new()
    {
        { PostProcessLayer.Antialiasing.None, AntiAliasingMode.None },
        { PostProcessLayer.Antialiasing.FastApproximateAntialiasing, AntiAliasingMode.FXAA },
        { PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing, AntiAliasingMode.SMAA },
        { PostProcessLayer.Antialiasing.TemporalAntialiasing, AntiAliasingMode.SMAA }
    };

    private static void EnsureConfigInitialized(PostProcessLayer instance)
    {
        if (_initialized) return;
        _initialized = true;

        var defaultMode = ReverseAaModeMap.GetValueOrDefault(instance.antialiasingMode, AntiAliasingMode.SMAA);

        _antialiasingMode = Plugin.ConfigFile.Bind("Graphics", "Anti-Aliasing", defaultMode,
            new ConfigDescription("Controls the anti-aliasing method. FXAA is fast, SMAA is higher quality.", null,
                new ConfigurationManagerAttributes { Order = _startOrder-- }));

        Plugin.Logger.LogInfo("PostProcessing config entries initialized.");
    }

    internal static void ApplyToInstance(PostProcessLayer instance)
    {
        if (instance == null) return;

        EnsureConfigInitialized(instance);

        if (AaModeMap.TryGetValue(_antialiasingMode.Value, out var nativeMode))
        {
            instance.antialiasingMode = nativeMode;
        }
    }
}
