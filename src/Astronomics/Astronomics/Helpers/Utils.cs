namespace Astronomics.Helpers;

public static class Utils
{
    /// <summary>
    /// Attempts to add a key-value pair to a dictionary. Returns false if the key already exists.
    /// </summary>
    internal static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (dict.ContainsKey(key)) return false;
        dict.Add(key, value);
        return true;
    }
    
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

        if (parent.Find("newName")) return null;
        
        // Create a new GameObject for the cloned image
        var newBackground = new GameObject(newName, typeof(RectTransform), typeof(Image));
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
    /// Constructs the full path of a Transform in the hierarchy, starting from the root.
    /// </summary>
    public static string GetPath(this Transform tr)
    {
        var path = tr.name;
        while (tr.parent != null)
        {
            tr = tr.parent;
            path = tr.name + "/" + path;
        }
    
        return path;
    }
    
    /// <summary>
    /// Sorts a list of resolutions by pixel count in ascending order.
    /// </summary>
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }
}