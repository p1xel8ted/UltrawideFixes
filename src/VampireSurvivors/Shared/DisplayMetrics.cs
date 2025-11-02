namespace Shared;

using static Shared.Logger;

/// <summary>
/// Framework-agnostic display metrics and ultra-wide scaling calculations.
/// </summary>
public static class DisplayMetrics
{
    /// <summary>
    /// Native aspect ratio of Vampire Survivors (16:10 = 1.6).
    /// </summary>
    private const float NativeAspectRatio = 1.6f;

    /// <summary>
    /// Current display width in pixels.
    /// </summary>
    public static int MainWidth => Display.main.systemWidth;

    /// <summary>
    /// Current display height in pixels.
    /// </summary>
    public static int MainHeight => Display.main.systemHeight;

    /// <summary>
    /// Current display aspect ratio (width / height).
    /// </summary>
    public static float MainAspect => MainWidth / (float)MainHeight;

    /// <summary>
    /// Scaling factor for ultra-wide displays relative to native 16:10 aspect ratio.
    /// Values > 1.0 indicate ultra-wide displays, values &lt; 1.0 indicate narrower displays.
    /// </summary>
    public static float PositiveScaleFactor => MainAspect / NativeAspectRatio;

    /// <summary>
    /// Logs initialization details including resolution, aspect ratio, and scale factor.
    /// </summary>
    public static void LogInitialization()
    {
#if Melon
        Info("Vampire Survivors Ultra-Wide (Melon) has been initialized.");
#else
        Info("Vampire Survivors Ultra-Wide (BepInEx) has been initialized.");
#endif
        Info($"Display Resolution: {MainWidth}x{MainHeight}");
        Info($"Aspect Ratio: {MainAspect:F4} (Native: {NativeAspectRatio:F4})");
        Info($"Scale Factor: {PositiveScaleFactor:F4}");
    }

    /// <summary>
    /// Validates the calculated scale factor and logs a warning if display is not ultra-wide.
    /// </summary>
    public static void ValidateScaleFactor()
    {
        if (PositiveScaleFactor < 1.0f)
        {
            Warning($"Scale factor is less than 1.0 ({PositiveScaleFactor:F4}). This may indicate a non-ultrawide display.");
        }
    }
}
