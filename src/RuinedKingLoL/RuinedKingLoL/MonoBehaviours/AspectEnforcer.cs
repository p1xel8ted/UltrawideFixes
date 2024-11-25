namespace RuinedKingLoL.MonoBehaviours;

public class AspectEnforcer : MonoBehaviour
{
    private CameraResRetarget _cameraResRetarget;

    private void Awake()
    {
        _cameraResRetarget = gameObject.GetComponent<CameraResRetarget>();
    }

    private void OnEnable()
    {
        _cameraResRetarget = gameObject.GetComponent<CameraResRetarget>();
    }

    private void LateUpdate()
    {
        if (_cameraResRetarget)
        {
            if (_cameraResRetarget.bCameraResRetargetEnabled)
            {
                _cameraResRetarget.selfCamera.pixelRect = new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight);
            }
        }
    }
}