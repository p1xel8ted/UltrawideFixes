namespace CrowCountry.MonoBehaviours;


public class LetterboxDisabler : MonoBehaviour
{
    private void Start()
    {
        foreach (Transform t in gameObject.transform)
        {
            t.gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        foreach (Transform t in gameObject.transform)
        {
            t.gameObject.SetActive(false);
        }
    }
}