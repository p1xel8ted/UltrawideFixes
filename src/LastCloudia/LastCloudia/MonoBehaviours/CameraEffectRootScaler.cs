namespace LastCloudia.MonoBehaviours;

public class CameraEffectRootScaler : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = new Vector3(Plugin.PositiveScaleFactor * 2f, 1f, 1);
    }
    private void OnEnable()
    {
        transform.localScale = new Vector3(Plugin.PositiveScaleFactor * 2f, 1f, 1);
    }
    
}