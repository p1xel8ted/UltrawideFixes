namespace MindOverMagnet;

public static class Utils
{
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        var component = go.GetComponent<T>();
        if (!component)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }
    
    internal static float FindLowestFrameRateMultipleAboveFifty(float originalRate)
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
    
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }

}