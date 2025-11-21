namespace BluePrince.Misc;

public static class Extensions
{
    public static string GetFullPath(this Transform current)
    {
        var path = current.name;
        while (current.parent)
        {
            current = current.parent;
            path = current.name + "/" + path;
        }

        return path;
    }

    // Attempts to add a component of type T to the GameObject if it doesn't already have one.
    // Returns the existing component if found, or the newly added component otherwise.
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        if (!gameObject)
        {
            throw new ArgumentNullException(nameof(gameObject));
        }

        // Check if the GameObject already has the component - only call GetComponent once
        var component = gameObject.GetComponent<T>();

        return component ? component : gameObject.AddComponent<T>();
    }
}