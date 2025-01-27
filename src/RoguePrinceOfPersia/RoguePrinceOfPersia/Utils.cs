namespace RoguePrinceOfPersia;

public static class Utils
{
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