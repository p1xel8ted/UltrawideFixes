namespace NEOTheWorldEndsWithYouUltraWide;

public static class Extensions
{

    public static void TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (!component)
            gameObject.AddComponent<T>();
    }

    public static Transform FindDeepChild(this Transform parent, string name)
    {
        foreach (var c in parent)
        {
            var child = c.TryCast<Transform>();
            if (child && child.name == name)
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