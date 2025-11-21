namespace TinyTerrysTurboTrip.Misc;

public static class Extensions
{
    
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }
    
    public static string GetFullPath(this Transform current)
    {
        var path = current.name;
        while (current.parent != null)
        {
            current = current.parent;
            path = current.name + "/" + path;
        }

        return path;
    }

    // Attempts to add a component of type T to the GameObject if it doesn't already have one.
    // Returns true if the component was added, false otherwise.
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        if (!gameObject)
        {
            throw new ArgumentNullException(nameof(gameObject));
        }

        // Check if the GameObject already has the component
        var component = gameObject.GetComponent<T>();
        
        return gameObject.GetComponent<T>() ? component : gameObject.AddComponent<T>();
    }
}