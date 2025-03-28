namespace AI_Limit.Misc;

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


    internal static float PositiveScaleFactor => CurrentAspect / NativeAspect;
    
    internal static float NegativeScaleFactor => NativeAspect / CurrentAspect;
    
    /// <summary>
    /// Gets the height of the currently selected resolution.
    /// </summary>
    internal static int MainHeight => SelectedResolution.height;
    
    /// <summary>
    /// Gets the currently selected resolution based on plugin settings or falls back to the native resolution.
    /// </summary>
    internal static Resolution SelectedResolution
    {
        get
        {
#if DEBUG
            if (Configuration.SixteenTenTesting.Value)
            {
                const int height = 1200;
                var width = Mathf.RoundToInt(height * 1.6f);
                return new Resolution { width = width, height = height };
            }

            if (Configuration.ThirtyTwoNineTesting.Value)
            {
                const int height = 900;
                var width = Mathf.RoundToInt(height * 3.555555555555556f);
                return new Resolution { width = width, height = height };
            }

            if (Configuration.FourtyEightNineTesting.Value)
            {
                const int height = 600;
                var width = Mathf.RoundToInt(height * 5.333333333333333f);
                return new Resolution { width = width, height = height };
            }
#endif

            if (Configuration.Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Configuration.Resolution.Value.Split('x');
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
    /// A predefined list of custom refresh rates for compatibility.
    /// </summary>
    private static readonly int[] CustomRefreshRates =
    [
        30, 50, 60, 72, 75, 90, 100, 120, 144, 165, 180, 200, 240, 300, 360, 480
    ];

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
            refreshRate = Screen.currentResolution.refreshRate
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }
    
    // internal static RefreshRate RefreshRateRatio
    // {
    //     get
    //     {
    //         var rr = new RefreshRate
    //         {
    //             numerator = (uint)Screen.currentResolution.refreshRate,
    //             denominator = 1
    //         };
    //         return rr;
    //     }
    // }
    
}