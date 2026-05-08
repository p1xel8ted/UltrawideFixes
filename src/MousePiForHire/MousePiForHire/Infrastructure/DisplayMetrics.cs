namespace MousePiForHire.Infrastructure;

// Display info, read once on first use. Used wherever a patch needs the player's actual screen
// size or aspect (resolution list, aspect fitters, etc.).
internal static class DisplayMetrics
{
    internal static readonly int NativeSystemWidth = Display.main.systemWidth;
    internal static readonly int NativeSystemHeight = Display.main.systemHeight;
    internal static readonly float NativeSystemAspect = NativeSystemWidth / (float)NativeSystemHeight;

    // 16:9, used where we want to keep something at the game's intended aspect (e.g. main menu).
    internal const float NativeAspect = 16f / 9f;

    internal static float PositiveScaleFactor = NativeSystemAspect / NativeAspect;
    internal static bool IsWiderThanNative => NativeSystemAspect > NativeAspect;

    // Highest refresh rate the display reports. Used when we add the player's native resolution
    // to the in-game list.
    public static readonly RefreshRate MaxRefreshRate = Screen.resolutions.OrderByDescending(r => r.refreshRateRatio.value).First().refreshRateRatio;
}