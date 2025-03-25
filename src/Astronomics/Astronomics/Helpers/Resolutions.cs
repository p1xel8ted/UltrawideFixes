namespace Astronomics.Helpers;

public static class Resolutions
{
    /// <summary>
    /// The native aspect ratio (16:9).
    /// </summary>
    internal const float NativeAspect = 16f / 9f;

    /// <summary>
    /// Gets the width of the currently selected resolution.
    /// </summary>
    private static int MainWidth => Screen.width;

    internal static Resolution MainResolution = new()
    {
        height = Display.main.systemHeight,
        width = Display.main.systemWidth
    };
    
    /// <summary>
    /// Gets the height of the currently selected resolution.
    /// </summary>
    private static int MainHeight => Screen.height;

    private static int SixteenNineWidth => Mathf.RoundToInt(MainHeight * 1.777777777777778f);

    private static int WidthDifference => Mathf.Abs(MainWidth - SixteenNineWidth);
    
    internal static int BlackBarSize => Mathf.RoundToInt(WidthDifference / 2f);
    
#if DEBUG    
    internal static Resolution SixteenTenRes = new()
    {
        height = 1200,
        width = Mathf.RoundToInt(1200 * 1.6f)
    };
    
    internal static Resolution ThirtyTwoNineRes = new()
    {
        height = 900,
        width = Mathf.RoundToInt(900 * 3.555555555555556f)
    };    
    
    internal static Resolution FourtyEightNineRes = new()
    {
        height = 600,
        width = Mathf.RoundToInt(600 * 5.333333333333333f)
    }; 
#endif

    internal static float CurrentAspect => (float)Screen.width / Screen.height;

    public static float ScaleFactor => CurrentAspect / NativeAspect;
}