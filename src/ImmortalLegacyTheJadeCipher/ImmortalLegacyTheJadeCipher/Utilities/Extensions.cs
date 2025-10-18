namespace ImmortalLegacyTheJadeCipher.Utilities;

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

    /// <summary>
    /// Sorts a list of resolutions by pixel count in ascending order.
    /// </summary>
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }

    //dict tryadd
    public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (dict.ContainsKey(key)) return false;
        dict.Add(key, value);
        return true;
    }

    internal static bool ContainsIgnoreCase(this string source, string value)
    {
        return source.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    //gameobject trygetcomponent
    // if (!groupObject.TryGetComponent(out VerticalLayoutGroup layoutGroup))
    // {
    //     layoutGroup = groupObject.AddComponent<VerticalLayoutGroup>();
    // }
    public static bool TryGetComponent<T>(this GameObject obj, out T component) where T : Component
    {
        component = obj.GetComponent<T>();
        return component != null;
    }
}