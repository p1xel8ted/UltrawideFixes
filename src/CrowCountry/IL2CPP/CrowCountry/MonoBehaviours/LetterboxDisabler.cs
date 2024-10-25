namespace CrowCountry.MonoBehaviours;


public class LetterboxDisabler : MonoBehaviour
{
    private void Start()
    {
        foreach (var o in gameObject.transform)
        {
            var t = o.TryCast<Transform>();
            if (t)
            {
                t.gameObject.SetActive(false);
            }
        }
    }

    private void OnEnable()
    {
        foreach (var o in gameObject.transform)
        {
            var t = o.TryCast<Transform>();
            if (t)
            {
                t.gameObject.SetActive(false);
            }
        }
    }
}