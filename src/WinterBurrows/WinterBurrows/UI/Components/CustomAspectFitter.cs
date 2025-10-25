namespace WinterBurrows.UI.Components;

public class CustomAspectFitter : MonoBehaviour
{
    private ContentSizeFitter _contentSizeFitter;
    private LayoutElement _layoutElement;

    private void Awake()
    {
        Initialize();
    }

    private void OnEnable()
    {
        Initialize();
    }

    private void Initialize()
    {
        _layoutElement = gameObject.GetComponent<LayoutElement>() ?? gameObject.AddComponent<LayoutElement>();
        _contentSizeFitter = gameObject.GetComponent<ContentSizeFitter>() ?? gameObject.AddComponent<ContentSizeFitter>();
        
        _layoutElement.preferredWidth = ResolutionManager.GetPreferredAspectWidth();
        _contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
    }

    public void UpdateWidth()
    {
        if (_layoutElement != null)
        {
            _layoutElement.preferredWidth = ResolutionManager.GetPreferredAspectWidth();
        }
    }
}