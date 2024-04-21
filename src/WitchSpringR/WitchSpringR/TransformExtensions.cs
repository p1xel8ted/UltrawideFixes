using UnityEngine;

namespace WitchSpringR;

public static class TransformExtensions
{
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
}