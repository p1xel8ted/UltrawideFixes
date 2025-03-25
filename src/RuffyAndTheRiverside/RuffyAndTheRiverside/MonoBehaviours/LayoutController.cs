using RuffyAndTheRiverside.Helpers;

namespace RuffyAndTheRiverside.MonoBehaviours;

public class LayoutController : MonoBehaviour
{
    private AspectRatioFitter _aspectRatioFitter; // Manages aspect ratio adjustments for UI elements
    private ContentSizeFitter _contentSizeFitter; // Ensures the UI element's size fits its content
    private float _customSize; // Custom size for specific layout configurations
    private LayoutElement _layoutElement; // Allows manual size control of UI elements
    private LayoutSize _size; // Enum representing different layout size options
    private bool _useAspectRatioFitter; // Determines whether to use aspect ratio fitting or size fitting
    private bool _blackBarPositionAdjustment;

    /// <summary>
    /// Adds a LayoutController to a child Transform found by path and configures its layout.
    /// </summary>
    internal static LayoutController AddLayoutControllerPath(
        Transform transform,
        string findPath,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter,
        bool blackBarPositionAdjustment)
    {
        var foundTransform = transform.Find(findPath);
        return !foundTransform ? null : AddLayoutControllerRoot(foundTransform, size, customSize, useAspectRatioFitter, blackBarPositionAdjustment);
    }

    /// <summary>
    /// Changes the layout size and custom dimensions, and updates the aspect ratio or size fitting.
    /// </summary>
    internal void ChangeSize(LayoutSize size, float customSize, bool blackBarPositionAdjustment)
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
        bool useAspectRatioFitter,
        bool blackBarPositionAdjustment)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
        lc.Init(size, customSize, useAspectRatioFitter, blackBarPositionAdjustment);
        lc.UpdateAspect();
        return lc;
    }

    private static readonly List<LayoutController> LayoutControllers = [];

    /// <summary>
    /// Initializes the LayoutController with specified size and aspect ratio settings.
    /// </summary>
    private void Init(LayoutSize size, float customSize, bool useArf, bool blackBarPositionAdjustment)
    {
        _size = size;
        _useAspectRatioFitter = useArf;
        _customSize = customSize;
        _blackBarPositionAdjustment = blackBarPositionAdjustment;
        LayoutControllers.Add(this);
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
            const int height = 1080;
            var width = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ForceFullScreen => Mathf.RoundToInt(height * Resolutions.CurrentAspect),
                LayoutSize.ForceSixteenNine => Mathf.RoundToInt(height * Resolutions.NativeAspect),
                LayoutSize.ConfigBased => Utils.GetHudRes(height),
                LayoutSize.ConfigBasedWithOffset => Utils.GetHudRes(height) + _customSize,
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
                LayoutSize.ForceFullScreen => Resolutions.CurrentAspect,
                LayoutSize.ForceSixteenNine => Resolutions.NativeAspect,
                LayoutSize.ConfigBased => Utils.GetPreferredAspect(),
                LayoutSize.ConfigBasedWithOffset => Utils.GetPreferredAspect() + _customSize,
                _ => Resolutions.CurrentAspect
            };
            _aspectRatioFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            _aspectRatioFitter.aspectRatio = aspect;
            _aspectRatioFitter.enabled = _useAspectRatioFitter;
        }

        if (_blackBarPositionAdjustment)
        {
            var currentScreenWidth = Screen.width; //3440
            var currentScreenHeight = Screen.height; //1440
            var sixteenNineWidth = currentScreenHeight * Resolutions.NativeAspect; //1440 * 16/9 = 2560
            var blackBarSize = (currentScreenWidth - sixteenNineWidth) / 2; //(3440 - 2560) / 2 = 440

            if (_size == LayoutSize.ForceSixteenNine || _size == LayoutSize.ConfigBased && (Plugin.HUDAspect.Value == "16:9" || Plugin.HUDAspect.Value == "16:10"))
            {
                transform.position = transform.position with { x = blackBarSize };  
            }
            else
            {
                transform.position = transform.position with { x = 0 };  
            }
            
           
        }
    }

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