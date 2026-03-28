// DisplayMetrics.cs — Caches the primary display's native resolution and aspect ratio at startup.
// Called once from Plugin.Load(). Provides a single source of truth for the native display dimensions
// used throughout the plugin for resolution enforcement and aspect ratio calculations.

namespace ProjectSongbird;

internal static class DisplayMetrics
{
    /// <summary>Native width of the primary display in pixels.</summary>
    internal static int MainWidth { get; private set; }

    /// <summary>Native height of the primary display in pixels.</summary>
    internal static int MainHeight { get; private set; }

    /// <summary>Native aspect ratio (width / height) of the primary display.</summary>
    internal static float MainAspect { get; private set; }

    /// <summary>The game's native design aspect ratio (16:9).</summary>
    private static float NativeAspect => 16f / 9f;

    /// <summary>Width at 16:9 baseline for the native height (used for video render textures).</summary>
    internal static int BaselineWidth { get; private set; }
    
    /// <summary>Ratio of the native display aspect to 16:9. Used to scale UI elements horizontally to fill ultrawide.</summary>
    internal static float ScaleFactor => MainAspect / NativeAspect;

    /// <summary>
    ///  Maximum refresh rate supported by any of the display's available resolutions. Used to ensure the plugin doesn't accidentally set an unsupported refresh rate,
    /// </summary>
    internal static readonly int MaxRefresh = Screen.resolutions.ToList().Max(a => a.refreshRate);

    /// <summary>
    /// Reads and caches the primary display's resolution and aspect ratio.
    /// </summary>
    internal static void Initialize()
    {
#if DEBUG
        MainWidth = 3440;
        MainHeight = 1440;
#else
        MainWidth = Display.main.systemWidth;
        MainHeight = Display.main.systemHeight;
#endif
        MainAspect = MainWidth / (float)MainHeight;
        BaselineWidth = Mathf.RoundToInt(MainHeight * (16f / 9f));
    }
}