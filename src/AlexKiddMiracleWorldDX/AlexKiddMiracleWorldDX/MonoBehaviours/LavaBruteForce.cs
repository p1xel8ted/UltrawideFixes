namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class LavaBruteForce : MonoBehaviour
{
    private readonly Transform[] children = new Transform[7];

    private void Start()
    {
        Plugin.LOG.LogInfo($"LavaBruteForce Started on {gameObject.name}");
        var count = 0;
        foreach (var t in transform)
        {
            if (count == 7) break;
            count++;
            Destroy(t as Object);
        }
    }
    // private void LateUpdate()
    // {
    //     foreach (var child in children)
    //     {
    //         child.gameObject.SetActive(false);
    //     }
    // }
}