﻿namespace BAKERU.Misc;

public static class Utils
{
    
    internal static float FindLowestFrameRateMultipleAboveFifty(float originalRate)
    {
        var intRate = Mathf.RoundToInt(originalRate);
        for (var rate = intRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }
    
    /// <summary>
    /// Sorts a list of resolutions by pixel count in ascending order.
    /// </summary>
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }

    
    public static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        if (go.TryGetComponent<T>(out var comp))
        {
            return comp;
        }

        return go.AddComponent<T>();
    }

    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
    }

    private static float GetPreferredAspect()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => Plugin.CurrentAspect,
            _ => Plugin.CurrentAspect
        };
        return width;
    }

    /// <summary>
    /// Get the full Transform hierarchy path for this provided Transform.
    /// </summary>
    public static string GetTransformPath(this Transform transform, bool includeSelf = false)
    {
        StringBuilder sb = new();
        if (includeSelf)
            sb.Append(transform.name);
    
        while (transform.parent)
        {
            transform = transform.parent;
            sb.Insert(0, '/');
            sb.Insert(0, transform.name);
        }
    
        return sb.ToString();
    }
}