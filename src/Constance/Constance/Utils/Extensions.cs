namespace Constance.Utils;

public static class Extensions
{
    public static T TryAddComponent<T>(this GameObject obj) where T : Component
    {
        var component = obj.GetComponent<T>();
        if (!component)
        {
            component = obj.AddComponent<T>();
        }
        return component;
    }
}