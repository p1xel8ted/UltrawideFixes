namespace MousePiForHire;

// Cached display info read once at type-load. Used by patches that need the player's actual ultrawide
// dimensions (e.g. AspectRatioFitter aspect, injected resolution row).
internal static class DisplayMetrics
{
    internal static readonly int NativeSystemWidth = Display.main.systemWidth;
    internal static readonly int NativeSystemHeight = Display.main.systemHeight;
    internal static readonly float NativeSystemAspect = NativeSystemWidth / (float)NativeSystemHeight;

    // Reference 16:9 aspect for "constrain to native" decisions (main menu fitter).
    internal const float NativeAspect = 16f / 9f;

    internal static float PositiveScaleFactor = NativeSystemAspect / NativeAspect;
    internal static bool IsWiderThanNative => NativeSystemAspect > NativeAspect;

    // Highest refresh rate Unity reports for the active display - used as the synthetic refresh
    // for the injected native-resolution row in ScreenResolutionsTranspiler.
    public static readonly RefreshRate MaxRefreshRate = Screen.resolutions.OrderByDescending(r => r.refreshRateRatio.value).First().refreshRateRatio;
}