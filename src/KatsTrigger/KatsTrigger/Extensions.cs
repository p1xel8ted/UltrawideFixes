namespace KatsTrigger;

/// <summary>
/// Extension methods for Unity types used throughout the plugin.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Sorts a list of resolutions by total pixel count in ascending order (lowest to highest).
    /// Uses long arithmetic to prevent integer overflow with high resolutions (e.g., 8K).
    /// </summary>
    /// <param name="resolutions">The list of resolutions to sort in-place.</param>
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => ((long)a.width * a.height).CompareTo((long)b.width * b.height));
    }
}
