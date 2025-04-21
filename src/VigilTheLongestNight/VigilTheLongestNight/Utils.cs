namespace VigilTheLongestNight;

public static class Utils
{
    // public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
    // {
    //     if (dictionary == null)
    //     {
    //         throw new ArgumentNullException(nameof(dictionary));
    //     }
    //
    //     if (dictionary.ContainsKey(key)) return false;
    //     dictionary.Add(key, value);
    //     return true;
    // }
    
    public static string GetPath(this Transform transform)
    {
        if (!transform)
        {
            throw new ArgumentNullException(nameof(transform));
        }
        
        var path = transform.name;
        while (transform.parent)
        {
            transform = transform.parent;
            path = $"{transform.name}/{path}";
        }

        return path;
    }

    /// <summary>
    /// Tries to get a component of the specified type from a GameObject. If it doesn't exist, adds it.
    /// </summary>
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }
}