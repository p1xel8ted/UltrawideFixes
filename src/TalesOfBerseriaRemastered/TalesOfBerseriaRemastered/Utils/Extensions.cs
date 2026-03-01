namespace TalesOfBerseriaRemastered.Utils;

public static class Extensions
{
    /// <summary>
    /// Returns all unique refresh rates reported by Unity, sorted ascending.
    /// </summary>
    internal static int[] MergeUnityRefreshRates()
    {
        return Screen.resolutions
            .Select(r => Mathf.RoundToInt((float)r.refreshRateRatio.value))
            .Distinct()
            .OrderBy(r => r)
            .ToArray();
    }

    /// <summary>
    /// Finds the lowest even divisor of <paramref name="refreshRate"/> that is above 50.
    /// This gives an optimal physics tick rate that divides evenly into the display rate,
    /// preventing judder from uneven FixedUpdate distribution across frames.
    /// </summary>
    internal static float FindLowestFrameRateMultipleAboveFifty(float refreshRate)
    {
        var intRate = Mathf.RoundToInt(refreshRate);
        for (var rate = intRate / 2; rate > 50; rate--)
        {
            if (refreshRate % rate == 0)
            {
                return rate;
            }
        }

        return refreshRate;
    }
}
