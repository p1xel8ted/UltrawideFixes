namespace LastCloudia.MonoBehaviours;

public class BattleCameraFieldOfViewEnforcer : MonoBehaviour
{
    private Camera _camera;
    private void Start()
    {
        _camera = GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        _camera.fieldOfView = Plugin.BattleFieldOfView.Value;
    }
}