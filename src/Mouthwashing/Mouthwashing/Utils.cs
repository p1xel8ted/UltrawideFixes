namespace Mouthwashing;

public static class Utils
{
    
    internal static float FindLowestFrameRateMultipleAboveFifty(double originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return (float)rate;
            }
        }

        return (float)originalRate;
    }
    
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        var component = go.GetComponent<T>();
        if (!component)
        {
            component = go.AddComponent<T>();
        }

        return component;
        
    }
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }

    public static string GetPath(this GameObject go)
    {
        var path = go.name;
        while (go.transform.parent != null)
        {
            go = go.transform.parent.gameObject;
            path = $"{go.name}/{path}";
        }

        return path;
    }

}