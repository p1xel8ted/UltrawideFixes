namespace CrowCountry.MonoBehaviours;

public class FovAdjuster : MonoBehaviour
{
    internal float disableDuration;
    internal float enableDuration;

    private void Start()
    {
        SetFoV(Plugin.GetDefaultCameraFov(), enableDuration);
    }
    
    private void OnEnable()
    {
        SetFoV(Plugin.GetDefaultCameraFov(), enableDuration);
    }

    private void OnDisable()
    {
        Plugin.UpdateCamera(SceneManager.GetActiveScene().name, disableDuration);
    }

    private static void SetFoV(float newFoV, float duration)
    {
        if (Camera.main)
        {
            Camera.main.DOFieldOfView(newFoV, duration).SetEase(Ease.InOutQuad);
        }
    }
}