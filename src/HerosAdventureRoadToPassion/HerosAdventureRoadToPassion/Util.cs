namespace HerosAdventureRoadToPassion;

public static class Util
{
   
    public static List<Transform> FindChildrenByName(this Transform parent, string name)
    {
        List<Transform> foundChildren = [];
        FindChildrenByNameRecursive(parent, name, ref foundChildren);
        return foundChildren;
    }
    // Extension method to find the first child transform with the given name.
    public static Transform FindFirstChildByName(this Transform parent, string name)
    {
        return FindFirstChildByNameRecursive(parent, name);
    }

    // Recursive helper function to search for the first child with the given name.
    private static Transform FindFirstChildByNameRecursive(Transform current, string name)
    {
        foreach (var o in current)
        {

            var child = o.TryCast<Transform>();

            if (child && child.name == name)
            {
                return child;
            }

            var foundChild = FindFirstChildByNameRecursive(child, name);
            if (foundChild)
            {
                return foundChild;
            }
        }

        // Return null if no child with the given name is found.
        return null;
    }

    // Recursive helper function to search for children with the given name.
    private static void FindChildrenByNameRecursive(Transform current, string name, ref List<Transform> foundChildren)
    {
        foreach (var o in current)
        {

            var child = o.TryCast<Transform>();

            if (child && child.name == name)
            {
                foundChildren.Add(child);
            }
            // Recurse into each child.
            FindChildrenByNameRecursive(child, name, ref foundChildren);
        }
    }
    
    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
    }

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

    public static List<T> FindIl2CppType<T>() where T : Object
    {
        // Use a HashSet to store unique objects based on their instance ID.
        var uniqueObjects = new HashSet<int>();
        var result = new List<T>();

        // Find all objects using Resources.FindObjectsOfTypeAll and add them if unique.
        foreach (var obj in Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()))
        {
            var castedObj = obj.TryCast<T>();
            if (castedObj && uniqueObjects.Add(castedObj.GetInstanceID()))
            {
                result.Add(castedObj);
            }
        }

        // Find all objects using Object.FindObjectsOfType and add them if unique.
        foreach (var obj in Object.FindObjectsOfType<T>())
        {
            if (obj && uniqueObjects.Add(obj.GetInstanceID()))
            {
                result.Add(obj);
            }
        }

        return result;
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

    // internal static (int simplifiedWidth, int simplifiedHeight) GetGcd(int width, int height)
    // {
    //     while (height != 0)
    //     {
    //         var temp = height;
    //         height = width % height;
    //         width = temp;
    //     }
    //
    //     var simplifiedWidth = Display.main.systemWidth / width;
    //     var simplifiedHeight = Display.main.systemHeight / width;
    //     return (simplifiedWidth, simplifiedHeight);
    // }

    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }
}