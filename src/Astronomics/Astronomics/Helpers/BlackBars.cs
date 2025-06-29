namespace Astronomics.Helpers;

public static class BlackBars
{
    private static GameObject BlackBarCanvas { get; set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }
    
    internal static void EnablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            // Resize();
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
                leftRect.offsetMax = new Vector2(Resolutions.BlackBarSize, 0);
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
                rightRect.offsetMin = new Vector2(-Resolutions.BlackBarSize, 0);
                rightRect.offsetMax = new Vector2(0, 0);
            }
        }
        
        BlackBarCanvas.SetActive(false);
    }

    public static void DisablePillarBoxing(VideoPlayer source)
    {
        DisablePillarBoxing();
    }

    // public static void Resize()
    // {
    //     // Check if the BlackBarCanvas exists; if not, there's nothing to resize
    //     if (!BlackBarCanvas) return;
    //
    //     // Ensure both black bars exist
    //     if (!LeftBlackBar || !RightBlackBar) return;
    //
    //     // Define your target aspect ratio, for example, 16:9
    //     var currentAspect = (float)Screen.width / Screen.height;
    //
    //     // Calculate pillarboxing size based on current and target aspect ratios
    //     var currentBlackBarSize = 0f;
    //     if (currentAspect > Resolutions.NativeAspect)
    //     {
    //         var targetWidth = Screen.height * Resolutions.NativeAspect;
    //         currentBlackBarSize = (Screen.width - targetWidth) / 2f;
    //     }
    //
    //     // Update the left black bar
    //     var leftRect = LeftBlackBar.GetComponent<RectTransform>();
    //     leftRect.offsetMax = new Vector2(currentBlackBarSize, 0);
    //
    //     // Update the right black bar
    //     var rightRect = RightBlackBar.GetComponent<RectTransform>();
    //     rightRect.offsetMin = new Vector2(-currentBlackBarSize, 0);
    // }
}