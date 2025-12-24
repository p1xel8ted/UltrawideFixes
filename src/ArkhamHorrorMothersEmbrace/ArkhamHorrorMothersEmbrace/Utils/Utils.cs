namespace ArkhamHorrorMothersEmbrace.Utils;

public static class Utils
{


    internal static int FindLowestFrameRateDivisorAboveFifty(int originalRate)
    {
        for (var rate = 51; rate <= originalRate / 2; rate++)
        {
            if (originalRate % rate == 0)
                return rate;
        }
        return originalRate;
    }

}