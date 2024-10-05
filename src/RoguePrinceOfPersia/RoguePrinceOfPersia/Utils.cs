namespace RoguePrinceOfPersia;

public static class Utils
{
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