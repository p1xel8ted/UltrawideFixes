using OnceUponKatamari.Core.Configuration;
using OnceUponKatamari.Utils;

namespace OnceUponKatamari.Resolutions;

/// <summary>
/// Manages resolution calculations, aspect ratio handling, and refresh rate management for ultra-wide displays.
/// Provides utilities for converting between resolutions, aspect ratios, and HUD scaling preferences.
/// </summary>
public static class ResolutionManager
{
    /// <summary>
    /// The native aspect ratio (16:9).
    /// </summary>
    internal const float NativeAspect = 16f / 9f;

    /// <summary>
    /// Gets the maximum refresh rate among all available screen resolutions.
    /// </summary>
    internal static int MaxRefresh => Screen.resolutions.Max(a => (int)a.refreshRateRatio.value);

    /// <summary>
    /// Maps aspect ratio strings to their float values for HUD scaling calculations.
    /// </summary>
    private static readonly Dictionary<string, float> HUDAspectValues = new()
    {
        { "4:3", 1.333333333333333f },
        { "16:10", 1.6f },
        { "16:9", 1.777777777777778f },
        { "21:9", 2.333333333333333f },
        { "21.5:9", 2.388888888888889f },
        { "24:10", 2.4f },
        { "27:9", 3.0f },
        { "32:10", 3.2f },
        { "32:9", 3.555555555555556f },
        { "48:9", 5.333333333333333f }
    };

    /// <summary>
    /// Retrieves the preferred aspect ratio based on configuration or defaults to the current screen aspect ratio.
    /// </summary>
    internal static float GetPreferredAspect()
    {
        var hudAspect = UIConfig.HUDAspect.Value;


        if (hudAspect == "Auto")
        {
            return CurrentAspect;
        }

        // Return value from dictionary if valid, otherwise fallback to CurrentAspect
        return HUDAspectValues.TryGetValue(hudAspect, out var aspectValue) ? aspectValue : CurrentAspect;
    }

    /// <summary>
    /// Calculates the preferred width in pixels for HUD elements based on the configured aspect ratio.
    /// Assumes a fixed height of 600 pixels.
    /// </summary>
    /// <returns>The calculated width in pixels (aspect ratio * 600).</returns>
    internal static float GetPreferredAspectWidth()
    {
        return GetPreferredAspect() * 1080;
    }

    /// <summary>
    /// Gets the list of available HUD aspect ratios that are less than or equal to the current display aspect ratio.
    /// Includes "Auto" option for automatic aspect ratio matching.
    /// </summary>
    internal static string[] GetAvailableHUDAspects()
    {
        var currentAspect = CurrentAspect;
        var availableAspects = HUDAspectValues
            .Where(kvp => kvp.Value <= currentAspect + 0.01f) // Small tolerance for floating point comparison
            .OrderBy(kvp => kvp.Value)
            .Select(kvp => kvp.Key)
            .ToList();

        availableAspects.Add("Auto");
        return availableAspects.ToArray();
    }

    /// <summary>
    /// Gets the current refresh rate as a RefreshRate struct.
    /// Uses custom rate if enabled; otherwise, uses the maximum refresh rate.
    /// </summary>
    internal static RefreshRate RefreshRate => new() { numerator = (uint)MaxRefresh, denominator = 1 };



    /// <summary>
    /// Calculates the current aspect ratio based on the selected resolution.
    /// </summary>
    internal static float CurrentAspect => (float)NativeDisplayWidth / NativeDisplayHeight;


    /// <summary>
    /// Gets the native display width of the main display.
    /// </summary>
    public static readonly int NativeDisplayWidth = Display.main.systemWidth;

    /// <summary>
    /// Gets the native display height of the main display.
    /// </summary>
    public static readonly int NativeDisplayHeight = Display.main.systemHeight;
}