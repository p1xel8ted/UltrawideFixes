namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class HudScaler : MonoBehaviour
{
    public bool UpdateEnabled { get; set; } = true;
    
    private WriteOnce<float> OriginalXScale { get; } = new();
    private WriteOnce<float> OriginalYScale { get; } = new();
    private WriteOnce<float> OriginalZScale { get; } = new();

    private void Start()
    {
        Plugin.LOG.LogInfo($"HUD Scaler started on {gameObject.name}");
        OriginalXScale.Value = transform.localScale.x;
        OriginalYScale.Value = transform.localScale.y;
        OriginalZScale.Value = transform.localScale.z;
        PerformingScaling();
    }

    private void PerformingScaling()
    {
        if (!transform) return;
        
        if (!Plugin.KeepUICentered.Value)
        {
            var x = OriginalXScale.Value * Plugin.NegativeScaleFactor;
            transform.localScale = transform.localScale with {x = x};
        }
        else
        {
            transform.localScale = transform.localScale with {x = OriginalXScale.Value};
        }  
    }
    
    private void LateUpdate()
    {
        if (UpdateEnabled)
        {
            PerformingScaling();
        }
    }

}