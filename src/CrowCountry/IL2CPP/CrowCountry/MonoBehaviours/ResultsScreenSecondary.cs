namespace CrowCountry.MonoBehaviours;

public class ResultsScreenSecondary : MonoBehaviour
{
    private Transform cover;
    private string sceneName;

    private void Start()
    {
        Setup();
    }

    private void LateUpdate()
    {
        if (sceneName.Equals(Const.Results) && cover)
        {
            cover.gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        Setup();
    }

    private void Setup()
    {
        sceneName = SceneManager.GetActiveScene().path;
        cover = transform.Find(Const.ResultsScreenBlackOverlays);
        if (cover)
        {
            cover.gameObject.SetActive(false);
        }
    }
}