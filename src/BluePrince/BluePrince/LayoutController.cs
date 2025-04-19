namespace BluePrince;

internal class LayoutController : MonoBehaviour
{
    private AspectRatioFitter _aspectRatioFitter;
    private ContentSizeFitter _contentSizeFitter;
    private float _customSize;
    private LayoutElement _layoutElement;
    private LayoutSize _size;

    private bool _useAspectRatioFitter;

    internal static void AddLayoutControllerPath(Transform transform, string findPath, LayoutController.LayoutSize size, float customSize, bool useAspectRatioFitter)
    {
        var foundTransform = transform.Find(findPath);

        if (!foundTransform) return;

        AddLayoutControllerRoot(foundTransform, size, customSize, useAspectRatioFitter);
    }


    internal static void AddLayoutControllerRoot(Transform transform, LayoutSize size, float customSize, bool useAspectRatioFitter)
    {
        var lc = transform.gameObject.TryAddComponent<LayoutController>();
        lc.Init(size, customSize, useAspectRatioFitter);
        lc.UpdateAspect();
    }
    
    internal void Init(LayoutSize size, float customSize, bool useArf)
    {
        _size = size;
        _useAspectRatioFitter = useArf;
        _customSize = customSize;

        AddUpdateFitters();
    }

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
                _ => throw new ArgumentOutOfRangeException()
            };

            _layoutElement.preferredWidth = width;
        }

        if (_contentSizeFitter)
        {
            _contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }

        if (_aspectRatioFitter)
        {
            var aspect = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ForceFullScreen => Plugin.CurrentAspect,
                LayoutSize.ForceSixteenNine => Plugin.NativeAspect,
                _ => Plugin.CurrentAspect
            };
            _aspectRatioFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            _aspectRatioFitter.aspectRatio = aspect;
        }
    }

    internal enum LayoutSize
    {
        ForceFullScreen,
        ForceSixteenNine,
        Custom,
    }
}