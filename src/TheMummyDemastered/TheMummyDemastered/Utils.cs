namespace TheMummyDemastered;

public static class Utils
{
    internal static void ApplyMainResolution(ref int width, ref int height)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }
    
    //tryaddcomponent ext method
    internal static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }
        return component;
    }
}