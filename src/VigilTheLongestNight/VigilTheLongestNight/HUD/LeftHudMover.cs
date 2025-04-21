namespace VigilTheLongestNight.HUD;

public class LeftHudMover : MonoBehaviour
{
    private static float _innerPosition;
    private static float _outerPosition;
    
    private void Start()
    {
        Plugin.Log.LogInfo($"HUD Mover (Left Side) started on {gameObject.name}");
        _innerPosition = Plugin.WidthDifference / 100f;
        _outerPosition = 0;
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.SpanHUD.Value)
        {
            transform.position = transform.position with {x = _outerPosition};
        }
        else
        {
            transform.position = transform.position with {x = _innerPosition};
        }
    }
    
}