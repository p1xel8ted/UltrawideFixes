namespace AI_Limit.MonoBehaviours;

internal class CameraGateFitEnforcer : MonoBehaviour
{
    private Camera _camera;
    private readonly WriteOnceGateFit _originalGateFit = new();

    private void Awake()
    {
        _camera = GetComponent<Camera>();
        _originalGateFit.Value = _camera.gateFit;
    }

    private void Update()
    {
        if (_camera)
        {
            _camera.gateFit = Plugin.CurrentAspect >Plugin.NativeAspect ? Camera.GateFitMode.Vertical : _originalGateFit.Value;
        }
    }
}