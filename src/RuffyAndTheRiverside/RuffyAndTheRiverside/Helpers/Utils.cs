﻿namespace RuffyAndTheRiverside.Helpers;

public static class Utils
{
    // /// <summary>
    // /// Attempts to add a key-value pair to a dictionary. Returns false if the key already exists.
    // /// </summary>
    // internal static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    // {
    //     if (dict.ContainsKey(key)) return false;
    //     dict.Add(key, value);
    //     return true;
    // }

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
    
    // /// <summary>
    // /// Sorts a list of resolutions by pixel count in ascending order.
    // /// </summary>
    // internal static void SortByPixelCount(this List<Vector2Int> resolutions)
    // {
    //     resolutions.Sort((a, b) => a.x * a.y - b.x * b.y);
    // }
    
    /// <summary>
    /// Clones an Image component and applies it to a new GameObject.
    /// </summary>
    /// <param name="originalImage">The original Image component to clone.</param>
    /// <param name="parent">The parent Transform to attach the cloned image to.</param>
    /// <param name="newName">The name of the new GameObject.</param>
    /// <param name="setAsFirstSibling">If true, moves the new image to be the first child.</param>
    /// <returns>The newly created Image component.</returns>
    public static Image CloneImage(Image originalImage, Transform parent, string newName, bool setAsFirstSibling = false)
    {
        if (!originalImage || !parent) return null;

        // Create a new GameObject for the cloned image
        var newBackground = new GameObject(newName);
        newBackground.TryAddComponent<RectTransform>();
        newBackground.TryAddComponent<Image>();
        
        newBackground.transform.SetParent(parent, false);

        if (setAsFirstSibling)
        {
            newBackground.transform.SetAsFirstSibling();
        }

        // Copy Image properties
        var newImage = newBackground.GetComponent<Image>();
        newImage.sprite = originalImage.sprite;
        newImage.color = originalImage.color;
        newImage.material = originalImage.material;
        newImage.raycastTarget = originalImage.raycastTarget;
        newImage.type = originalImage.type;
        newImage.preserveAspect = originalImage.preserveAspect;
        newImage.fillCenter = originalImage.fillCenter;

        // Copy RectTransform properties
        var newRect = newBackground.GetComponent<RectTransform>();
        var originalRect = originalImage.GetComponent<RectTransform>();
        newRect.anchorMin = originalRect.anchorMin;
        newRect.anchorMax = originalRect.anchorMax;
        newRect.pivot = originalRect.pivot;
        newRect.anchoredPosition = originalRect.anchoredPosition;
        newRect.sizeDelta = originalRect.sizeDelta;
        newRect.rotation = originalRect.rotation;
        newRect.localScale = originalRect.localScale;
        
        return newImage;
    }


    /// <summary>
    /// Tries to get a component of the specified type from a GameObject. If it doesn't exist, adds it.
    /// </summary>
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }

    /// <summary>
    /// Calculates the horizontal resolution for HUD elements based on the provided vertical resolution and preferred aspect ratio.
    /// </summary>
    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
    }

    /// <summary>
    /// Retrieves the preferred aspect ratio based on configuration or defaults to the current screen aspect ratio.
    /// </summary>
    internal static float GetPreferredAspect()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:10" => 1.6f,
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => Resolutions.CurrentAspect,
            _ => Resolutions.CurrentAspect
        };
        return width;
    }
    
    // /// <summary>
    // /// Constructs the full path of a Transform in the hierarchy, starting from the root.
    // /// </summary>
    // public static string GetPath(this Transform tr)
    // {
    //     var path = tr.name;
    //     while (tr.parent != null)
    //     {
    //         tr = tr.parent;
    //         path = tr.name + "/" + path;
    //     }
    //
    //     return path;
    // }
}