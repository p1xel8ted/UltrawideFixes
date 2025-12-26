namespace KatsTrigger.Utils;

/// <summary>
/// Extension methods for Unity types used throughout the plugin.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Gets an existing component of type T, or adds one if it doesn't exist.
    /// </summary>
    /// <typeparam name="T">The component type to get or add.</typeparam>
    /// <param name="gameObject">The GameObject to get/add the component on.</param>
    /// <returns>The existing or newly added component.</returns>
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        return component ? component : gameObject.AddComponent<T>();
    }

    /// <summary>
    /// Gets an existing component of type T, or adds one if it doesn't exist.
    /// Convenience overload for Transform that delegates to the GameObject version.
    /// </summary>
    /// <typeparam name="T">The component type to get or add.</typeparam>
    /// <param name="transform">The Transform whose GameObject to get/add the component on.</param>
    /// <returns>The existing or newly added component.</returns>
    public static T TryAddComponent<T>(this Transform transform) where T : Component
    {
        return transform.gameObject.TryAddComponent<T>();
    }

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