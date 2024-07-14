namespace KlonoaSeries.Misc;

public static class Utils
{
    private static float GetNewScale(float reference)
    {
        var displayHeight = Plugin.MainHeight;
        var scale = 1f / (reference / displayHeight);
        return scale;
    }
    
    public static string GetFullPath(this GameObject gameObject)
    {
        var path = gameObject.name;
        var parent = gameObject.transform.parent;
        while (parent != null)
        {
            path = parent.name + "/" + path;
            parent = parent.parent;
        }

        return path;
    }
    public static bool Contains(this string source, string toCheck, StringComparison comp = StringComparison.InvariantCultureIgnoreCase)
    {
        return source?.IndexOf(toCheck, comp) >= 0;
    }

    public static T TryAddComponent <T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }
    
    internal static void UpdateCanvasScaler(CanvasScaler scaler, float referenceResolutionHeight)
    {
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
        scaler.scaleFactor = GetNewScale(referenceResolutionHeight);
    }

    internal static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }
    
}