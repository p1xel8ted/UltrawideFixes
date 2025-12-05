namespace LegoParty.MonoBehaviours;

/// <summary>
/// MonoBehaviour that continuously enforces ultrawide aspect ratio on cameras.
/// Required because the game constantly overrides camera properties.
/// </summary>
public class CameraAspectEnforcer : MonoBehaviour
{
    private Camera _camera;
    private int _mainWidth;
    private int _mainHeight;
    private float _mainAspectRatio;
    private bool _missingCameraLogged;

    private void Awake()
    {
        FindCamera();
    }

    private void OnEnable()
    {
        FindCamera();
    }

    /// <summary>
    /// Caches camera reference and display dimensions.
    /// Values are cached to avoid recalculating each frame.
    /// </summary>
    private void FindCamera()
    {
        _camera = GetComponent<Camera>();
        _mainWidth = Plugin.MainWidth;
        _mainHeight = Plugin.MainHeight;
        _mainAspectRatio = Plugin.MainAspectRatio;
        _missingCameraLogged = false;
    }

    /// <summary>
    /// Enforces aspect ratio, pixel rect, and viewport rect every frame.
    /// Runs in LateUpdate to override any game modifications.
    /// </summary>
    private void LateUpdate()
    {
        if (!_camera)
        {
            FindCamera();
            if (!_camera)
            {
                if (!_missingCameraLogged)
                {
                    Plugin.Logger.LogWarning("[CameraAspectEnforcer] No Camera component found on GameObject " + gameObject.name);
                    _missingCameraLogged = true;
                }
                return;
            }
        }

        // Force correct aspect ratio
        if (!Mathf.Approximately(_camera.aspect, _mainAspectRatio))
        {
            _camera.aspect = _mainAspectRatio;
        }

        // Force full resolution pixel rect
        if ((int)_camera.pixelRect.width != _mainWidth || (int)_camera.pixelRect.height != _mainHeight)
        {
            _camera.pixelRect = new Rect(0, 0, _mainWidth, _mainHeight);
        }

        // Force full viewport (no letterboxing)
        if (!Mathf.Approximately(_camera.rect.width, 1f) || !Mathf.Approximately(_camera.rect.height, 1f))
        {
            _camera.rect = new Rect(0, 0, 1, 1);
        }
    }

    private void OnDestroy()
    {
        Plugin.Logger.LogInfo("[CameraAspectEnforcer] CameraAspectEnforcer destroyed on camera " + gameObject.name);
    }
}