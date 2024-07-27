namespace GestaltSteamCinder;

[Harmony]
public static class Ext
{
   
    //recursive find child game
    public static Transform FindChildRecursive(this Transform transform, string name)
    {
        if (transform.name == name)
        {
            return transform;
        }

        foreach (var o in transform)
        {
            var child = o.TryCast<Transform>();
            var result = FindChildRecursive(child, name);
            if (result != null)
            {
                return result;
            }
        }

        return null;
    }
    
    //get gameobject path   
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
}