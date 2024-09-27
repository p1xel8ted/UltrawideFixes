namespace GIJoeWrathOfCobra;

public static class Utils
{
    
    internal static float FindLowestFrameRateMultipleAboveFifty(double originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return (float)rate;
            }
        }

        return (float)originalRate;
    }

}