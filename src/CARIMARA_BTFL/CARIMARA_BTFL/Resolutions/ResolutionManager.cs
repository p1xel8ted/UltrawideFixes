namespace CARIMARA_BTFL.Resolutions;

/// <summary>
/// Manages resolution calculations, aspect ratio handling, and refresh rate management for ultra-wide displays.
/// Provides utilities for converting between resolutions, aspect ratios, and HUD scaling preferences.
/// </summary>
public static class ResolutionManager
{

    /// <summary>
    /// Gets the width of the currently selected resolution.
    /// </summary>
    internal static int MainWidth => SelectedResolution.width;

    /// <summary>
    /// Gets the height of the currently selected resolution.
    /// </summary>
    internal static int MainHeight => SelectedResolution.height;

    /// <summary>
    /// Calculates the positive scale factor for adjusting resolutions to the native aspect ratio.
    /// </summary>
    internal static float PositiveScaleFactor => MainAspectRatio / Constants.NativeAspect;

    /// <summary>
    /// Calculates the aspect ratio of the main resolution.
    /// </summary>
    private static float MainAspectRatio => MainWidth / (float)MainHeight;

    /// <summary>
    /// Gets the maximum refresh rate among all available screen resolutions.
    /// </summary>
    internal static int MaxRefresh => Screen.resolutions.Max(a => (int)a.refreshRateRatio.value);

    /// <summary>
    /// Gets the current refresh rate value as an integer.
    /// Uses custom rate if enabled; otherwise, uses the maximum refresh rate.
    /// </summary>
    internal static int RefreshRateValue => DisplayConfig.UseCustomRefreshRate.Value ? DisplayConfig.CustomRefreshRate.Value : MaxRefresh;


    /// <summary>
    /// Gets the current refresh rate as a RefreshRate struct.
    /// Uses custom rate if enabled; otherwise, uses the maximum refresh rate.
    /// </summary>
    internal static RefreshRate RefreshRate => new() { numerator = (uint)RefreshRateValue, denominator = 1 };

    /// <summary>
    /// Gets the currently selected resolution based on plugin settings or falls back to the native resolution.
    /// </summary>
    internal static Resolution SelectedResolution
    {
        get
        {
            try
            {
                var res = DisplayConfig.Resolution.Value.Split('x');
                if (res.Length != 2)
                {
                    Plugin.Log.LogError($"Invalid resolution format: {DisplayConfig.Resolution.Value}. Expected 'WIDTHxHEIGHT'. Using native resolution {NativeDisplayWidth}x{NativeDisplayHeight}.");
                    return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
                }

                if (!int.TryParse(res[0], out var width) || !int.TryParse(res[1], out var height) || width <= 0 || height <= 0)
                {
                    Plugin.Log.LogError($"Invalid resolution values: {DisplayConfig.Resolution.Value}. Width and height must be positive integers. Using native resolution {NativeDisplayWidth}x{NativeDisplayHeight}.");
                    return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
                }

                return new Resolution { width = width, height = height };
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"Error parsing resolution {DisplayConfig.Resolution.Value}: {ex.Message}. Using native resolution.");
                return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
            }
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
            refreshRateRatio = new RefreshRate { numerator = (uint)MaxRefresh, denominator = 1 }
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);

#if DEBUG
        //16:10
        var height = 1200;
        var width = Mathf.RoundToInt(height * 1.6f);
        var res1 = new Resolution { width = width, height = height };


        //32:9
        height = 900;
        width = Mathf.RoundToInt(height * 3.555555555555556f);
        var res2 = new Resolution { width = width, height = height };


        //48:9
        height = 600;
        width = Mathf.RoundToInt(height * 5.333333333333333f);
        var res3 = new Resolution { width = width, height = height };
        
        //24:10
        height = 800;
        width = Mathf.RoundToInt(height * 2.4f);
        var res4 = new Resolution { width = width, height = height };
        
        //32:10
        height = 1000;
        width = Mathf.RoundToInt(height * 3.2f);
        var res5 = new Resolution { width = width, height = height };

        resList.Add(res1);
        resList.Add(res2);
        resList.Add(res3);
        resList.Add(res4);
        resList.Add(res5);
#endif


        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }


    /// <summary>
    /// Merges Unity's available refresh rates with custom refresh rates, ensuring uniqueness and sorted order.
    /// </summary>
    internal static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => (int)a.refreshRateRatio.value).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }
}