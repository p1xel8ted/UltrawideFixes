namespace NEOTheWorldEndsWithYouUltraWide;

public static class Utils
{
/*
    public static List<T> FindIl2CppType<T>() where T : Object
    {
        var list = new List<T>();
        list.AddRange(Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }
*/
    
    public static bool IsChatter(string name)
    {
        return name.Contains("wtc", StringComparison.OrdinalIgnoreCase);
    }
    
    public static bool IsMission(string name)
    {
        // Check if the name ends with "_<any character>", and if so, trim the last two characters
        if (name.Length > 2 && name[^2] == '_')
        {
            name = name[..^2];
        }

        // Check if the modified name ends with "mission"
        return name.EndsWith("mission", StringComparison.OrdinalIgnoreCase);
    }

    public static bool IsMain(string name)
    {
        return name.EndsWith("main", StringComparison.OrdinalIgnoreCase);
    }
    
    public static bool IsChoice(string name)
    {
        return name.StartsWith("choice", StringComparison.OrdinalIgnoreCase);
    }
    
    public static bool IsBefore(string name)
    {
        return name.EndsWith("before", StringComparison.OrdinalIgnoreCase);
    }
}