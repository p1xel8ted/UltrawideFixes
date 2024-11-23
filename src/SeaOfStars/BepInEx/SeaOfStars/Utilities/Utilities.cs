// Utilities.cs

using AsmResolver.DotNet;

namespace SeaOfStars.Utilities;

public static class Utilities
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

    internal static void SortByPixelCount(this Il2CppSystem.Collections.Generic.List<Resolution> resolutions)
    {
        var tList = resolutions.ToArray().ToList();
        tList.Sort((a, b) => a.width * a.height - b.width * b.height);
        resolutions.Clear();
        foreach (var res in tList)
        {
            resolutions.Add(res);
        }
    }

    internal static void UpdateScreenTransform(Transform parent, bool cloneBackground, string name)
    {
        var screen = parent.FindChild(name);
        if (!screen)
        {
            Plugin.Logger.LogError($"Screen {name} not found in {parent.name}");
            return;
        }

        if (cloneBackground)
        {
            ReplaceWithBackgroundImage(screen);
        }
        else
        {
            screen.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }
    }

    internal static void AddContentSizeFitter(GameObject parent, bool ignore = false)
    {
        var width = SoSuiManager.GetPixelPerfectVector();
        var le = parent.TryAddComponent<LayoutElement>();
        le.preferredWidth = width.x;

        var csf = parent.TryAddComponent<ContentSizeFitter>();
        csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

        var lc = parent.TryAddComponent<LayoutController>();
        lc.LayoutElement = le;
        lc.ContentSizeFitter = csf;
        lc.OriginalPreferredWidth = width.x;
        lc.Ignore = ignore;

        SoSuiManager.LayoutControllers.Add(lc);

        SoSuiManager.UpdateUiWidth();

        //Plugin.Logger.LogInfo($"Added ContentSizeFitter to {parent.name} with preferredWidth {width.x}");
    }

    /// <summary>
    /// Replaces an existing image component within a child object with a new background image.
    /// </summary>
    public static void ReplaceWithBackgroundImage(Transform parentTransform)
    {
        // Check if the background image already exists.
        if (parentTransform.Find("BackgroundImage") != null) return;

        // Get the existing Image component.
        var existingImage = parentTransform.GetComponent<Image>();
        if (existingImage == null)
        {
            Plugin.Logger.LogWarning($"No Image component found on '{parentTransform}'.");
            return;
        }

        // Create a new GameObject for the background image.
        var backgroundImage = new GameObject("BackgroundImage");

        // Add an Image component and copy properties from the existing image.
        var newImage = backgroundImage.AddComponent<Image>();
        newImage.color = existingImage.color;
        newImage.sprite = existingImage.sprite;

        // Set the new background image as a child of the target child.
        backgroundImage.transform.SetParent(parentTransform);

        // Configure RectTransform.
        var rect = backgroundImage.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(DisplayManager.MainWidth, DisplayManager.MainWidth);
        rect.anchoredPosition = Vector2.zero;
        rect.SetAsFirstSibling();

        // Remove the old Image component.
        Object.Destroy(existingImage);
    }


    // internal static void CreateBlackBackground(Transform parent)
    // {
    //     if (parent.FindChild("BlackImage")) return;
    //
    //     var blackImage = new GameObject("BlackImage");
    //     blackImage.transform.SetParent(parent);
    //     blackImage.TryAddComponent<Image>().color = Color.black;
    //     var rect = blackImage.GetComponent<RectTransform>();
    //     rect.sizeDelta = new Vector2(DisplayManager.MainWidth, DisplayManager.MainHeight);
    //     rect.anchoredPosition = new Vector2(0, 0);
    //     rect.SetAsFirstSibling();
    // }

    public static List<T> FindIl2CppType<T>() where T : Object
    {
        var list = new List<T>();
        list.AddRange(Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }

    public static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        return unityRates.Concat(Core.Constants.CustomRefreshRates).Distinct().OrderBy(a => a).ToArray();
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