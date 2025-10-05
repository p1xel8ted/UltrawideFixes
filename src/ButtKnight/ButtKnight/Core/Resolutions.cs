namespace ButtKnight.Core;

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
    /// Calculates the positive scale factor for adjusting resolutions to the native aspect ratio.
    /// </summary>
    internal static float PositiveScaleFactor => MainAspectRatio / NativeAspect;

    /// <summary>
    /// Calculates the aspect ratio of the main resolution.
    /// </summary>
    private static float MainAspectRatio => MainWidth / (float)MainHeight;

    /// <summary>
    /// Gets the maximum refresh rate among all available screen resolutions.
    /// </summary>
    internal static int MaxRefresh => Screen.resolutions.Max(a => Mathf.RoundToInt((float)a.refreshRateRatio.value));

    internal static RefreshRate MaxRefreshRate => new()
    {
        denominator = 1,
        numerator = (uint)RefreshRate
    };

    /// <summary>
    /// Retrieves the preferred aspect ratio based on configuration or defaults to the current screen aspect ratio.
    /// </summary>
    internal static float GetPreferredAspect()
    {
        var width = ConfigManager.HUDAspect.Value switch
        {
            "4:3" => 1.333333333333333f,
            "16:10" => 1.6f,
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "27:9" => 3.0f,
            "32:10" => 3.2f,
            "32:9" => 3.555555555555556f,
            "48:9" => 5.333333333333333f,
            "Auto" => CurrentAspect,
            _ => throw new ArgumentOutOfRangeException()
        };
        return width;
    }

    internal static List<string> HUDAspects { get; } =
    [
        "4:3",      // Classic (1.333)
        "16:10",    // Common monitors (1.6)
        "16:9",     // Standard HD (1.778)
        "21:9",     // 2560x1080 ultrawide (2.333)
        "21.5:9",   // 3440x1440 ultrawide (2.389)
        "24:10",    // Ultrawide variant (2.4)
        "27:9",     // Triple 16:9 (3.0)
        "32:10",    // Dual 16:10 (3.2)
        "32:9",     // Super ultrawide (3.556)
        "48:9",     // Triple ultrawide (5.333)
        "Auto"
    ];

    // var rr = new RefreshRate
    // {
    //     denominator = 1,
    //     numerator = (uint)Resolutions.RefreshRate
    // };
    //
    /// <summary>
    /// Gets the current refresh rate, using a custom rate if enabled; otherwise, uses the maximum refresh rate.
    /// </summary>
    internal static int RefreshRate
    {
        get
        {
            if (ConfigManager.UseCustomRefreshRate != null && ConfigManager.CustomRefreshRate != null)
            {
                return ConfigManager.UseCustomRefreshRate.Value ? ConfigManager.CustomRefreshRate.Value : MaxRefresh;
            }

            return MaxRefresh;
        }
    }

    /// <summary>
    /// Gets the currently selected resolution based on plugin settings or falls back to the native resolution.
    /// </summary>
    internal static Resolution SelectedResolution
    {
        get
        {
            if (ConfigManager.Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = ConfigManager.Resolution.Value.Split('x');
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
            refreshRateRatio = MaxRefreshRate
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

    internal static float GetGradientBuffer(float aspectRatio)
    {
        // No buffer for 16:9 and below
        if (aspectRatio < 2.0f) return -1f; // -1 means skip
    
        // More aggressive scaling to eliminate gaps
        // 21:9 (2.333) -> 0.5
        // 32:9 (3.556) -> ~1.7 (to eliminate the 5cm gap)
        // 48:9 (5.333) -> ~2.8 (to eliminate the 20cm gap)
    
        if (aspectRatio <= 2.4f) // 21:9 range
        {
            return 0.5f;
        }

        if (aspectRatio <= 3.6f)
        {
            return Mathf.Lerp(0.5f, 1.7f, (aspectRatio - 2.4f) / 1.2f);
        }

        return Mathf.Lerp(1.7f, 2.8f, (aspectRatio - 3.6f) / 1.8f);
    }
 

    /// <summary>
    /// Merges Unity's available refresh rates with custom refresh rates, ensuring uniqueness and sorted order.
    /// </summary>
    internal static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => Mathf.RoundToInt((float)a.refreshRateRatio.value)).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }
}