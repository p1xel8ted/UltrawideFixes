namespace TheyAlwaysRun;

public static class Utils
{
    private static GameObject BlackBarCanvas { get; set; }
    private static GameObject LeftBlackBar { get; set; }
    private static GameObject RightBlackBar { get; set; }

    private const float SuperWideAspectRatio = 32f / 9f;
    private const float BaseAspectRatio = 16f / 9f;

    public static void UpdateAnchoredXPosition(Transform transform, float x)
    {
        var rect = transform.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(x, 0);
    }

    internal static void AddFixedContentSizeFitter(GameObject gameObject, float width)
    {
        var csf = AddContentSizeFitter(gameObject, false);
        csf.LE.layoutPriority = 9999;
        csf.LE.preferredWidth = width;
        csf.CSF.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
    }
    
    public static void UpdateMenuBackground(Image image)
    {
        var texture = new Texture2D(1, 1);
        var resourceName = Plugin.MainAspectRatio switch
        {
            >= SuperWideAspectRatio => "TheyAlwaysRun.assets.32-9.jpg",
            > BaseAspectRatio => "TheyAlwaysRun.assets.21-9.jpg",
            _ => null
        };

        if (string.IsNullOrEmpty(resourceName)) return;

        // Load the image from the embedded resources
        var assembly = Assembly.GetExecutingAssembly();
        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                Plugin.Log.LogError("Resource '{resourceName}' not found in the assembly.");
                return;
            }

            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                var imageData = memoryStream.ToArray();
                texture.LoadImage(imageData);
            }
        }

        // Create the sprite and assign it to the image component
        image.sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f)
        );
    }

    internal static void CreateBlackBars()
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
    }

    internal static void UpdateHUD()
    {
        foreach (var fitter in ContentSizeFitters.Where(fitter => fitter))
        {
            fitter.horizontalFit = Plugin.RestrictHUD.Value ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
        }
    }

    public static void EnablePillarBoxing()
    {
        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(true);
            BlackBarCanvas.transform.SetAsLastSibling();
        }
    }


    internal static void DisablePillarBoxing()
    {
        if (!BlackBarCanvas) return;

        CreateBlackBars();
        if (BlackBarCanvas)
        {
            BlackBarCanvas.SetActive(false);
        }
    }
    
    internal static readonly List<ContentSizeFitter> ContentSizeFitters = [];

    public static (ContentSizeFitter CSF, LayoutElement LE) AddContentSizeFitter(GameObject gameObject, bool add = true)
    {
        var le = gameObject.TryAddComponent<LayoutElement>();
        le.preferredWidth = 1920;
        le.layoutPriority = 99;
        le.enabled = true;

        var csf = gameObject.TryAddComponent<ContentSizeFitter>();
        csf.horizontalFit = Plugin.RestrictHUD.Value ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;

        csf.enabled = true;
        if (add)
        {
            ContentSizeFitters.Add(csf);
        }

        return (csf, le);
    }


    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (!component)
            component = gameObject.AddComponent<T>();
        return component;
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
}