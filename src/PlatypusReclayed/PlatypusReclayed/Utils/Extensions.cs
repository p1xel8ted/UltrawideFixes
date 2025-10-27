namespace PlatypusReclayed.Utils;

/// <summary>
/// Extension methods for Unity components and resolution management.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Gets an existing component or adds it if it doesn't exist on the GameObject.
    /// </summary>
    /// <typeparam name="T">The component type to get or add.</typeparam>
    /// <param name="obj">The GameObject to operate on.</param>
    /// <returns>The existing or newly added component.</returns>
    public static T TryAddComponent<T>(this GameObject obj) where T : Component
    {
        var component = obj.GetComponent<T>();
        if (!component)
        {
            component = obj.AddComponent<T>();
        }
        return component;
    }

    /// <summary>
    /// Sorts a list of resolutions by pixel count in ascending order.
    /// Uses overflow-safe comparison to handle very large resolutions.
    /// </summary>
    /// <param name="resolutions">The list of resolutions to sort.</param>
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => (a.width * a.height).CompareTo(b.width * b.height));
    }
}