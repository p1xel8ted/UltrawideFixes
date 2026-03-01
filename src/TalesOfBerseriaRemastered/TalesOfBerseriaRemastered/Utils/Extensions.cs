namespace TalesOfBerseriaRemastered.Utils;

public static class Extensions
{
    /// <summary>
    /// Returns all unique refresh rates reported by Unity, sorted ascending.
    /// Used to populate the framerate config dropdown with valid monitor refresh rates.
    /// </summary>
    internal static int[] MergeUnityRefreshRates()
    {
        return Screen.resolutions
            .Select(r => Mathf.RoundToInt((float)r.refreshRateRatio.value))
            .Distinct()
            .OrderBy(r => r)
            .ToArray();
    }
}
