namespace CrowCountry.MonoBehaviours;

public class CameraFoV : MonoBehaviour
{

    private void Start()
    {
        SetFoV(10f, 0.5f);
    }

    private static void SetFoV(float newFoV, float duration)
    {
        if (Camera.main)
        {
            Camera.main.DOFieldOfView(newFoV, duration).SetEase(Ease.InOutQuad);
        }
    }

    private void OnEnable()
    {
        SetFoV(10f, 0.5f);
    }
    
    private void OnDisable()
    {
        Plugin.UpdateCamera(SceneManager.GetActiveScene().name);
    }

}