using AlexKiddMiracleWorldDX.Misc;
using UnityEngine;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class PositiveScaler : MonoBehaviour
{
    private float xBuffer;
    private float yBuffer;
    public bool UpdateEnabled { get; set; }
    public bool ForceYScaling { get; set; }
    
    private WriteOnce<float> OriginalXScale { get; } = new();
    private WriteOnce<float> OriginalYScale { get; } = new();
    private WriteOnce<float> OriginalZScale { get; } = new();
    
    private void Start()
    {
        Plugin.LOG.LogInfo($"Positive Scaler started on {gameObject.name}");
        
        OriginalXScale.Value = transform.localScale.x;
        OriginalYScale.Value = transform.localScale.y;
        OriginalZScale.Value = transform.localScale.z;

        PerformScaling();
    }

    private void PerformScaling()
    {
        if(!transform) return;
        
        if (Plugin.SuperWide || ForceYScaling)
        {
            var x = OriginalXScale.Value * Plugin.PositiveScaleFactor + xBuffer;
            var y = OriginalYScale.Value * Plugin.PositiveScaleFactor + yBuffer;
            var z = OriginalZScale.Value;
            transform.localScale = new Vector3(x, y, z);
        }
        else
        {
            var x = OriginalXScale.Value + xBuffer * Plugin.PositiveScaleFactor;
            var y = OriginalYScale.Value;
            var z = OriginalZScale.Value;
            transform.localScale = new Vector3(x, y, z);
        }  
    }
    
    private void LateUpdate()
    {
        if (UpdateEnabled)
        {
            PerformScaling();
        }
    }

    public void SetBuffers(float x, float y = 0f)
    {
        xBuffer = x;
        yBuffer = y;
    }

    public void ClearBuffers()
    {
        xBuffer = 0;
        yBuffer = 0;
    }
    
}