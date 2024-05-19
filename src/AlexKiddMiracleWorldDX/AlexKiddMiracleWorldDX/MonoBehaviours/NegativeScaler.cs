namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class NegativeScaler : MonoBehaviour
{
    private float xBuffer;

    public bool UpdateEnabled { get; set; }

    private WriteOnce<float> OriginalXScale { get; } = new();
    private WriteOnce<float> OriginalYScale { get; } = new();
    private WriteOnce<float> OriginalZScale { get; } = new();

    private void Start()
    {
        Plugin.LOG.LogInfo($"Negative Scaler started on {gameObject.name}");

        OriginalXScale.Value = transform.localScale.x;
        OriginalYScale.Value = transform.localScale.y;
        OriginalZScale.Value = transform.localScale.z;

        PerformScaling();
    }

    private void PerformScaling()
    {
        if (!transform) return;


        var x = OriginalXScale.Value * Plugin.NegativeScaleFactor + xBuffer;
        var y = OriginalYScale.Value;
        var z = OriginalZScale.Value;
        transform.localScale = new Vector3(x, y, z);
    }


    private void LateUpdate()
    {
        if (UpdateEnabled)
        {
            PerformScaling();
        }
    }

    public void SetBuffer(float x)
    {
        xBuffer = x;
    }

    public void ClearBuffers()
    {
        xBuffer = 0;
    }

}