namespace CoreKeeper.Helpers;

public static class Resolutions
{
    /// <summary>
    /// The native aspect ratio (16:9).
    /// </summary>
    internal const float NativeAspect = 16f / 9f;

    /// <summary>
    /// Gets the width of the currently selected resolution.
    /// </summary>
    internal static int MainWidth => SelectedResolution.width;

    /// <summary>
    /// Gets the height of the currently selected resolution.
    /// </summary>
    internal static int MainHeight => SelectedResolution.height;
    
    /// <summary>
    /// Gets the maximum refresh rate among all available screen resolutions.
    /// </summary>
    // internal static int MaxRefresh =>Screen.resolutions.Max(a =>a.refreshRate);

    private static int MaxRefresh => Screen.resolutions.Max(a => Mathf.RoundToInt((float)a.refreshRateRatio.value));

    private static RefreshRate RefreshRateRatio
    {
        get
        {
            var rr = new RefreshRate
            {
                numerator = (uint)MaxRefresh,
                denominator = 1
            };
            return rr;
        }
    }
    
    /// <summary>
    /// Gets the currently selected resolution based on plugin settings or falls back to the native resolution.
    /// </summary>
    internal static Resolution SelectedResolution
    {
        get
        {
#if DEBUG
            if (Plugin.SixteenTenTesting.Value)
            {
                const int height = 1200;
                var width = Mathf.RoundToInt(height * 1.6f);
                return new Resolution { width = width, height = height };
            }

            if (Plugin.ThirtyTwoNineTesting.Value)
            {
                const int height = 900;
                var width = Mathf.RoundToInt(height * 3.555555555555556f);
                return new Resolution { width = width, height = height };
            }

            if (Plugin.FourtyEightNineTesting.Value)
            {
                const int height = 600;
                var width = Mathf.RoundToInt(height * 5.333333333333333f);
                return new Resolution { width = width, height = height };
            }
#endif

            if (Plugin.Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Plugin.Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    /// <summary>
    /// Calculates the current aspect ratio based on the selected resolution.
    /// </summary>
    internal static float CurrentAspect => (float)SelectedResolution.width / SelectedResolution.height;
    
    /// <summary>
    /// Gets the native display width of the main display.
    /// </summary>
    private static readonly int NativeDisplayWidth = Display.main.systemWidth;

    /// <summary>
    /// Gets the native display height of the main display.
    /// </summary>
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;

    /// <summary>
    /// Retrieves a list of unique resolutions available, sorted by pixel count, and includes the main resolution.
    /// </summary>
    internal static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = NativeDisplayWidth,
            height = NativeDisplayHeight,
            refreshRateRatio = RefreshRateRatio
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }
}