namespace LastCloudia.MonoBehaviours;

public class BgMaskScaler : MonoBehaviour
{
    
    private void Start()
    {
        transform.localScale = new Vector3(Plugin.PositiveScaleFactor * 2f, Plugin.PositiveScaleFactor * 2f, 1f);
    }
    
    private void OnEnable()
    {
        transform.localScale = new Vector3(Plugin.PositiveScaleFactor * 2f, Plugin.PositiveScaleFactor * 2f, 1f);
    }

}