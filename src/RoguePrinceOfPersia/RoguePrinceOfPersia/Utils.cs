namespace RoguePrinceOfPersia;

public static class Utils
{
    /// <summary>
    /// Recursively finds all children with the specified name.
    /// </summary>
    /// <param name="parent">The parent transform to search in.</param>
    /// <param name="name">The name of the children to find.</param>
    /// <returns>A list of transforms that match the specified name.</returns>
    public static List<Transform> FindChildrenByName(this Transform parent, string name)
    {
        var matchingChildren = new List<Transform>();

        foreach (var o in parent)
        {
            var child = o.TryCast<Transform>();
            if (child == null)
            {
                continue;
            }
            if (child.name.Equals(name))
            {
                matchingChildren.Add(child);
            }

            // Recursively search in the child's children
            matchingChildren.AddRange(child.FindChildrenByName(name));
        }

        return matchingChildren;
    }
    
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }
    
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }
    
    public static List<T> FindIl2CppType<T>() where T : Il2CppSystem.Object
    {
        var list = new List<T>();
        list.AddRange(Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }
    /// <summary>
    /// Calculates the horizontal resolution for HUD elements based on the provided vertical resolution and preferred aspect ratio.
    /// </summary>
    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
    }

    /// <summary>
    /// Retrieves the preferred aspect ratio based on configuration or defaults to the current screen aspect ratio.
    /// </summary>
    internal static float GetPreferredAspect()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:10" => 1.6f,
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => Plugin.CurrentAspect,
            _ => Plugin.CurrentAspect
        };
        return width;
    }
    public static string GetPath(this Transform tr)
    {
        var path = tr.name;
        while (tr.parent != null)
        {
            tr = tr.parent;
            path = tr.name + "/" + path;
        }

        return path;
    }
}