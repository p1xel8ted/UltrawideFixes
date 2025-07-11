﻿namespace YouWillDieTonight.Misc;

public static class Extensions
{
    //dict tryadd
    public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (dict.ContainsKey(key)) return false;
        dict.Add(key, value);
        return true;
    }

    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }

    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (!component)
            component = gameObject.AddComponent<T>();
        return component;
    }

    public static List<Transform> FindAllDeepChildren(this Transform parent, string name)
    {
        var children = new List<Transform>();
        FindAllDeepChildrenHelper(parent, name, children);
        return children;
    }

    private static void FindAllDeepChildrenHelper(Transform parent, string name, List<Transform> children)
    {
        foreach (Transform child in parent)
        {
            if (child && child.name == name)
                children.Add(child);

            FindAllDeepChildrenHelper(child, name, children);
        }
    }
}