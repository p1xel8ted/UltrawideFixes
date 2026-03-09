namespace HotelBarcelona;

/// <summary>
/// Caches the primary display's native resolution and aspect ratio at startup.
/// </summary>
public static class DisplayMetrics
{
    /// <summary>Native width of the primary display in pixels.</summary>
    public static int MainWidth { get; private set; }

    /// <summary>Native height of the primary display in pixels.</summary>
    public static int MainHeight { get; private set; }

    /// <summary>Native aspect ratio (width / height) of the primary display.</summary>
    public static float MainAspect { get; private set; }

    /// <summary>Scale factor of the current aspect ratio relative to 16:9.</summary>
    public static float PositiveScaleFactor { get; private set; }

    /// <summary>The baseline 16:9 aspect ratio that the game was designed for.</summary>
    public static float NativeAspect => 16f / 9f;

    /// <summary>Whether the display is wider than 16:9.</summary>
    public static bool IsWiderThanNative => MainAspect > NativeAspect;

    /// <summary>
    /// Reads and caches the primary display's resolution and aspect ratio.
    /// </summary>
    public static void Initialize()
    {
        MainWidth = Display.main.systemWidth;
        MainHeight = Display.main.systemHeight;
        MainAspect = MainWidth / (float)MainHeight;
        PositiveScaleFactor = MainAspect / NativeAspect;
    }
}
