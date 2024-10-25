namespace CrowCountry.Misc;

public static class Extensions
{

    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (!component)
            component = gameObject.AddComponent<T>();
        return component;
    }
    
    public static List<Transform> FindAllDeepChildren(this Transform parent, string name)
    {
        var children = new List<Transform>();
        FindAllDeepChildrenHelper(parent, name, children);
        return children;
    }

    private static void FindAllDeepChildrenHelper(Transform parent, string name, List<Transform> children)
    {
        foreach (Transform child in parent)
        {
            if (child && child.name == name)
                children.Add(child);
        
            FindAllDeepChildrenHelper(child, name, children);
        }
    }
}