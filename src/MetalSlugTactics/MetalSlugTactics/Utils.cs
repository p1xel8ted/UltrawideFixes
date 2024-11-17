namespace MetalSlugTactics;

public static class Utils
{
    internal static float FindLowestFrameRateMultipleAboveFifty(float originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }

}