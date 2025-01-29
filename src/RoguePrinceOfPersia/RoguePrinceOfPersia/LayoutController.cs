namespace RoguePrinceOfPersia;

public class LayoutController : MonoBehaviour
{
    private static readonly List<LayoutController> LayoutControllers = [];
    
    /// <summary>
    /// Updates the aspect ratios of all HUD elements in the list of HUD controllers.
    /// </summary>
    internal static void UpdateLayoutControllers()
    {
        foreach (var lc in LayoutControllers.Where(lc => lc))
        {
            lc.UpdateAspect();
        }
    }
    
    private AspectRatioFitter _aspectRatioFitter; // Manages aspect ratio adjustments for UI elements
    private ContentSizeFitter _contentSizeFitter; // Ensures the UI element's size fits its content
    private float _customSize; // Custom size for specific layout configurations
    private LayoutElement _layoutElement; // Allows manual size control of UI elements
    private LayoutSize _size; // Enum representing different layout size options
    private bool _useAspectRatioFitter; // Determines whether to use aspect ratio fitting or size fitting

    /// <summary>
    /// Adds a LayoutController to a child Transform found by path and configures its layout.
    /// </summary>
    internal static void AddLayoutControllerPath(
        Transform transform,
        string findPath,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter)
    {
        var foundTransform = transform.Find(findPath);
        if (foundTransform)
        {
            AddLayoutControllerRoot(foundTransform, size, customSize, useAspectRatioFitter);
        }
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
    internal static void AddLayoutControllerRoot(
        Transform transform,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
     
        lc.Init(size, customSize, useAspectRatioFitter);
        lc.UpdateAspect();
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
        LayoutControllers.Add(this);
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
            const int height = 1080;
            var width = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ForceFullScreen => Mathf.RoundToInt(height * Plugin.CurrentAspect),
                LayoutSize.ForceSixteenNine => Mathf.RoundToInt(height * Plugin.NativeAspect),
                LayoutSize.ConfigBased => Utils.GetHudRes(height),
                LayoutSize.ConfigBasedWithOffset => Utils.GetHudRes(height) + _customSize,
                _ => throw new ArgumentOutOfRangeException()
            };

            _layoutElement.preferredWidth = width;
            _layoutElement.layoutPriority = 9999;
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
                LayoutSize.ForceFullScreen => Plugin.CurrentAspect,
                LayoutSize.ForceSixteenNine => Plugin.NativeAspect,
                LayoutSize.ConfigBased => Utils.GetPreferredAspect(),
                LayoutSize.ConfigBasedWithOffset => Utils.GetPreferredAspect() + _customSize,
                _ => Plugin.CurrentAspect
            };
            _aspectRatioFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            _aspectRatioFitter.aspectRatio = aspect;
            _aspectRatioFitter.enabled = _useAspectRatioFitter;
        }
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