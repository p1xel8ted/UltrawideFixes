using UnityEngine;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class PositiveScaler : MonoBehaviour
{
    private float xBuffer;
    private float yBuffer;

    private void Start()
    {
        Plugin.LOG.LogInfo($"Positive Scaler started on {gameObject.name}");
    }

    private void Update()
    {
        if(!transform) return;
        
        if (Plugin.SuperWide)
        {
            transform.localScale = new Vector3(Plugin.PositiveScaleFactor + xBuffer, Plugin.PositiveScaleFactor + yBuffer, 1);
        }
        else
        {
            transform.localScale = new Vector3(Plugin.PositiveScaleFactor + xBuffer, 1, 1);
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