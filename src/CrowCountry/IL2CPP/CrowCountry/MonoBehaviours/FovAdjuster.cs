namespace CrowCountry.MonoBehaviours;

public class FovAdjuster : MonoBehaviour
{
    internal float DisableDuration;
    internal float EnableDuration;

    private void Start()
    {
        SetFoV(Plugin.GetDefaultCameraFov(), EnableDuration);
    }
    
    private void OnEnable()
    {
        SetFoV(Plugin.GetDefaultCameraFov(), EnableDuration);
    }

    private void OnDisable()
    {
        Plugin.UpdateCamera(SceneManager.GetActiveScene().path, DisableDuration);
    }

    private static void SetFoV(float newFoV, float duration)
    {
        if (Camera.main)
        {
            Camera.main.DOFieldOfView(newFoV, duration).SetEase(Ease.InOutQuad);
        }
    }
}