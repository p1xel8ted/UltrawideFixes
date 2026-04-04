namespace LegacyOfKainAscendance;

public static class Utils
{
    internal static void ApplyMainResolution(ref int width, ref int height)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }

    internal static void ApplyMainResolutionAndFullscreen(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        ApplyMainResolution(ref width, ref height);
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }
}