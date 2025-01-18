namespace HerosAdventureRoadToPassion;

internal class LayoutController : MonoBehaviour
{
    private AspectRatioFitter _aspectRatioFitter;
    private ContentSizeFitter _contentSizeFitter;
    private float _customSize;
    private LayoutElement _layoutElement;
    private LayoutSize _size;

    private bool _useAspectRatioFitter;

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
            var height = Screen.currentResolution.height;
            var width = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ConfigBased => Util.GetHudRes(height),
                LayoutSize.ForceFullScreen => Mathf.RoundToInt(height * Plugin.CurrentAspect),
                LayoutSize.ForceSixteenNine => Mathf.RoundToInt(height * Plugin.CurrentAspect),
                _ => Util.GetHudRes(height)
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
                LayoutSize.ConfigBased => Util.GetPreferredAspect(),
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
        ConfigBased,
        ForceFullScreen,
        ForceSixteenNine,
        Custom,
    }
}