namespace ArkhamHorrorMothersEmbrace.Utils;

public static class Extensions
{
    public static T TryAddComponent<T>(this GameObject obj) where T : Component
    {
        var component = obj.GetComponent<T>();
        if (!component)
        {
            component = obj.AddComponent<T>();
        }

        return component;
    }

    //dictionary extension to add a key only if it doesn't exist
    public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (dict.ContainsKey(key))
        {
            return false;
        }

        dict.Add(key, value);
        return true;
    }

    // Returns the full path of a GameObject in the hierarchy
    public static string Path(this GameObject obj)
    {
        var path = obj.name;
        var current = obj.transform;
        while (current.parent)
        {
            current = current.parent;
            path = current.name + "/" + path;
        }

        return path;
    }
}