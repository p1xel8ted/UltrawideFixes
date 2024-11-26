namespace RuinedKingLoL.Misc;

public static class Utils
{
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        var component = go.GetComponent<T>();
        if (!component)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }

    private static float GetPreferredAspect()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => Plugin.MainAspect,
            _ => Plugin.MainAspect
        };
        return width;
    }
    
    /// <summary>
    /// Recursively searches the hierarchy of a given Transform for a child with a specific name.
    /// </summary>
    /// <param name="parent">The parent Transform to search within.</param>
    /// <param name="name">The name of the child Transform to find.</param>
    /// <returns>The Transform of the child if found, otherwise null.</returns>
    public static Transform DeepSearchByName(Transform parent, string name)
    {
        if (parent == null) return null;

        // Check the current transform
        if (parent.name == name) return parent;

        // Recursively search children
        foreach (var o in parent)
        {
            var child = o.TryCast<Transform>();
            if (child == null) continue;
            var result = DeepSearchByName(child, name);
            if (result != null) return result;
        }

        return null; // Return null if no matching child is found
    }


    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
    }
    
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }
}