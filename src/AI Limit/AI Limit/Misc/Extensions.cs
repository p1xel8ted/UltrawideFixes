namespace AI_Limit.Misc;

public static class TransformExtensions
{
    public static string GetPath(this Transform transform)
    {
        var path = transform.name;
        while (transform.parent != null)
        {
            transform = transform.parent;
            path = transform.name + "/" + path;
        }

        return path;
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

    // Recursive method to find all children with a specific name
    public static void FindAllChildrenByName(Transform parent, string name, List<Transform> results)
    {
        foreach (var obj in parent)
        {
            var child = obj.TryCast<Transform>();
            if (!child) continue;
            
            if (child.name == name)
            {
                results.Add(child);
            }

            // Recursively check the child’s children
            FindAllChildrenByName(child, name, results);
        }
    }
    
    // Extension method to find a child by name recursively
    public static Transform FindChildRecursive(this Transform parent, string childName)
    {
        // First, check if the parent is the child we are looking for
        if (parent.name == childName)
        {
            return parent;
        }

        // Loop through all children of the current parent
        foreach (var o in parent)
        {
            var child = o.TryCast<Transform>();
            if (!child) continue;
            // Recursively call this method for each child
            var result = child.FindChildRecursive(childName);
            if (result)
            {
                return result; // If the child is found, return it
            }
        }

        // If no child with the given name is found, return null
        return null;
    }
}