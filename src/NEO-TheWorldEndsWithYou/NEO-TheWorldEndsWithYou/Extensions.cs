using System;

namespace NEOTheWorldEndsWithYouUltraWide;

public static class Extensions
{

    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (!component)
            component = gameObject.AddComponent<T>();
        return component;
    }

    public static Transform FindDeepChild(this Transform parent, string name, StringComparison comparison = StringComparison.CurrentCulture)
    {
        foreach (var c in parent)
        {
            var child = c.TryCast<Transform>();
            if (child && child.name.Equals(name, comparison))
                return child;

            var result = child.FindDeepChild(name);
            if (result) return result;
        }
        return null;
    }

    public static string GetFullPath(this Transform transform)
    {
        var path = transform.name;
        while (transform.parent)
        {
            transform = transform.parent;
            path = transform.name + "/" + path;
        }
        return path;
    }
}