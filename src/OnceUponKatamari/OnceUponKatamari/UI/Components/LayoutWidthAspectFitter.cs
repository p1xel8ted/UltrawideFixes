using OnceUponKatamari.Resolutions;

namespace OnceUponKatamari.UI.Components;

/// <summary>
/// Custom aspect ratio fitter that dynamically adjusts layout width based on user's preferred aspect ratio.
/// Uses LayoutElement and ContentSizeFitter to maintain proper HUD scaling across different display configurations.
/// </summary>
public class LayoutWidthAspectFitter : MonoBehaviour
{
    /// <summary>
    /// Manages how the GameObject's content determines its size based on the LayoutElement.
    /// </summary>
    private ContentSizeFitter _contentSizeFitter;

    /// <summary>
    /// Defines the preferred width for the layout based on the user's aspect ratio preference.
    /// </summary>
    private LayoutElement _layoutElement;

    /// <summary>
    /// Unity lifecycle method called when the component is first initialized.
    /// Ensures components are set up before the first frame.
    /// </summary>
    private void Awake()
    {
        Initialize();
    }

    /// <summary>
    /// Unity lifecycle method called when the component is enabled.
    /// Re-initializes to ensure settings are applied when the GameObject becomes active.
    /// </summary>
    private void OnEnable()
    {
        Initialize();
    }

    /// <summary>
    /// Initializes or retrieves LayoutElement and ContentSizeFitter components,
    /// then applies the preferred width based on the current aspect ratio configuration.
    /// </summary>
    private void Initialize()
    {
        _layoutElement = gameObject.GetComponent<LayoutElement>() ?? gameObject.AddComponent<LayoutElement>();
        _contentSizeFitter = gameObject.GetComponent<ContentSizeFitter>() ?? gameObject.AddComponent<ContentSizeFitter>();

        _layoutElement.preferredWidth = ResolutionManager.GetPreferredAspectWidth();
        _contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
    }

    /// <summary>
    /// Updates the layout width to match the current user-configured aspect ratio.
    /// Called when aspect ratio settings change to maintain proper HUD scaling.
    /// </summary>
    public void UpdateWidth()
    {
        if (_layoutElement)
        {
            _layoutElement.preferredWidth = ResolutionManager.GetPreferredAspectWidth();
        }
    }
}