namespace ButtKnight;

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
    
    /// <summary>
    /// Sorts a list of resolutions by pixel count in ascending order.
    /// </summary>
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }
}