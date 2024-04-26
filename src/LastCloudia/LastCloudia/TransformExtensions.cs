using UnityEngine;

namespace LastCloudia;

public static class TransformExtensions
{
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