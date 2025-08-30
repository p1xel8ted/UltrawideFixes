namespace TheWildAtHeart.Misc;

public class LayoutController : MonoBehaviour
{
    private AspectRatioFitter _aspectRatioFitter; // Manages aspect ratio adjustments for UI elements
    private ContentSizeFitter _contentSizeFitter; // Ensures the UI element's size fits its content
    private float _customSize; // Custom size for specific layout configurations
    private LayoutElement _layoutElement; // Allows manual size control of UI elements
    private LayoutSize _size; // Enum representing different layout size options
    private bool _useAspectRatioFitter; // Determines whether to use aspect ratio fitting or size fitting
    private static readonly List<LayoutController> LayoutControllers = [];


    internal static void UpdateLayoutControllers()
    {
        foreach (var lc in LayoutControllers)
        {
            lc.UpdateAspect();
        }
    }

    /// <summary>
    /// Adds a LayoutController to a child Transform found by path and configures its layout.
    /// </summary>
    internal static LayoutController AddLayoutControllerPath(
        Transform transform,
        string findPath,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter)
    {
        var foundTransform = transform.Find(findPath);
        return !foundTransform ? null : AddLayoutControllerRoot(foundTransform, size, customSize, useAspectRatioFitter);
    }

    /// <summary>
    /// Changes the layout size and custom dimensions, and updates the aspect ratio or size fitting.
    /// </summary>
    internal void ChangeSize(LayoutSize size, float customSize)
    {
        _size = size;
        _customSize = customSize;
        UpdateAspect();
    }

    /// <summary>
    /// Adds a LayoutController to the root Transform and configures its layout.
    /// </summary>
    internal static LayoutController AddLayoutControllerRoot(
        Transform transform,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
        lc.Init(size, customSize, useAspectRatioFitter);
        lc.UpdateAspect();
        LayoutControllers.Add(lc);
        return lc;
    }

    /// <summary>
    /// Initializes the LayoutController with specified size and aspect ratio settings.
    /// </summary>
    private void Init(LayoutSize size, float customSize, bool useArf)
    {
        _size = size;
        _useAspectRatioFitter = useArf;
        _customSize = customSize;
        AddUpdateFitters();
    }

    /// <summary>
    /// Adds and configures the appropriate fitters for layout adjustment.
    /// </summary>
    private void AddUpdateFitters()
    {
        if (_useAspectRatioFitter)
        {
            _aspectRatioFitter = gameObject.TryAddComponent<AspectRatioFitter>();
        }
        else
        {
            _layoutElement = gameObject.TryAddComponent<LayoutElement>();
            _contentSizeFitter = gameObject.TryAddComponent<ContentSizeFitter>();
        }

        UpdateAspect();
    }

    /// <summary>
    /// Updates the layout properties (e.g., width, aspect ratio) based on the current configuration.
    /// </summary>
    internal void UpdateAspect()
    {
        if (_layoutElement)
        {
            var height = Screen.height;
            var width = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ForceFullScreen => Mathf.RoundToInt(height * Plugin.CurrentAspectRatio),
                LayoutSize.ForceSixteenNine => Mathf.RoundToInt(height * Plugin.NativeDisplayAspectRatio),
                LayoutSize.ConfigBased => GetHudRes(height),
                LayoutSize.ConfigBasedWithOffset => GetHudRes(height) + _customSize,
                _ => throw new ArgumentOutOfRangeException()
            };

            _layoutElement.preferredWidth = width;
            _layoutElement.enabled = !_useAspectRatioFitter;
        }

        if (_contentSizeFitter)
        {
            _contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            _contentSizeFitter.enabled = !_useAspectRatioFitter;
        }

        if (_aspectRatioFitter)
        {
            var aspect = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ForceFullScreen => Plugin.CurrentAspectRatio,
                LayoutSize.ForceSixteenNine => Plugin.NativeDisplayAspectRatio,
                LayoutSize.ConfigBased => GetPreferredAspect(),
                LayoutSize.ConfigBasedWithOffset => GetPreferredAspect() + _customSize,
                _ => Plugin.CurrentAspectRatio
            };
            _aspectRatioFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            _aspectRatioFitter.aspectRatio = aspect;
            _aspectRatioFitter.enabled = _useAspectRatioFitter;
        }
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
            "Auto" => Plugin.CurrentAspectRatio,
            _ => Plugin.CurrentAspectRatio
        };
        return width;
    }

    /// <summary>
    /// Enum defining layout size options.
    /// </summary>
    internal enum LayoutSize
    {
        ForceFullScreen,
        ForceSixteenNine,
        Custom,
        ConfigBased,
        ConfigBasedWithOffset
    }
}