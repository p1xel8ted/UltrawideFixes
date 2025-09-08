namespace TheWildAtHeart.Misc;

public static class Utils
{
    private static GameObject BlackBarCanvas { get; set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }
    
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
    
    internal static void EnablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(true);
        }
    }

    internal static void DisablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(false);
        }
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
        
    private static void CreateBlackBars()
    {
        if (!BlackBarCanvas)
        {
            BlackBarCanvas = new GameObject("BlackBarCanvas");
            var canvas = BlackBarCanvas.TryAddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            if (!LeftBlackBar)
            {
                LeftBlackBar = new GameObject("LeftBlackBar");
                LeftBlackBar.transform.SetParent(canvas.transform, false);
                var leftImage = LeftBlackBar.TryAddComponent<Image>();
                leftImage.color = Color.black;
                var leftRect = leftImage.GetComponent<RectTransform>();
                leftRect.anchorMin = new Vector2(0, 0);
                leftRect.anchorMax = new Vector2(0, 1);
                leftRect.offsetMin = new Vector2(0, 0);
                leftRect.offsetMax = new Vector2(Plugin.BlackBarSize, 0);
            }

            if (!RightBlackBar)
            {
                RightBlackBar = new GameObject("RightBlackBar");
                RightBlackBar.transform.SetParent(canvas.transform, false);
                var rightImage = RightBlackBar.TryAddComponent<Image>();
                rightImage.color = Color.black;
                var rightRect = rightImage.GetComponent<RectTransform>();
                rightRect.anchorMin = new Vector2(1, 0);
                rightRect.anchorMax = new Vector2(1, 1);
                rightRect.offsetMin = new Vector2(-Plugin.BlackBarSize, 0);
                rightRect.offsetMax = new Vector2(0, 0);
            }
        }
        
        BlackBarCanvas.SetActive(false);
    }
    
}