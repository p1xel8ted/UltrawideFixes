namespace BAKERU.MonoBehaviours;

internal class ScreenFitterOverride : MonoBehaviour
{
    private ScreenFitter _fitter;

    private void Awake()
    {
        _fitter = GetComponent<ScreenFitter>();
    }

    private void Start()
    {
        _fitter = GetComponent<ScreenFitter>();
    }

    private void OnEnable()
    {
        _fitter = GetComponent<ScreenFitter>();
    }

    private void Update()
    {
        if (_fitter)
        {
            _fitter.m_IgnoreViewportOverride = true;
            _fitter.m_AspectRatio = Plugin.CurrentAspect;
        }

        ScreenManager.FixedAspectRatio = false;
    }
}