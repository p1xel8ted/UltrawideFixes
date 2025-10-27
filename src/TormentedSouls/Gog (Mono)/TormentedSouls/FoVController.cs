namespace TormentedSouls;

public class FoVController : MonoBehaviour
{
    private CinemachineVirtualCamera _virtualCamera;
    private readonly WriteOnceFloat _fov = new();
        
    private void Start()
    {
        _virtualCamera = GetComponent<CinemachineVirtualCamera>();
        _fov.Value = _virtualCamera.m_Lens.FieldOfView;
        Plugin.Log.LogInfo($"FoVController (Start) - { _virtualCamera.name}. Cams Initial FoV: { _fov.Value}");
    }
    private void OnEnable()
    {
        _virtualCamera = GetComponent<CinemachineVirtualCamera>();
        _fov.Value = _virtualCamera.m_Lens.FieldOfView;
        Plugin.Log.LogInfo($"FoVController (OnEnable) - { _virtualCamera.name}. Cams Initial FoV: { _fov.Value}");
    }
    private void LateUpdate()
    {
        _virtualCamera.m_Lens = _virtualCamera.m_Lens with {FieldOfView =  _fov.Value + 20};
        var baseFov = _fov.Value;
        var pct = Plugin.FieldOfView.Value / 100f;
        _virtualCamera.m_Lens = _virtualCamera.m_Lens with {FieldOfView =  baseFov + baseFov * pct};
    }
}