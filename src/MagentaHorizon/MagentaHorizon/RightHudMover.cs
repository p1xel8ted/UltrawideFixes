namespace MagentaHorizon;

public class RightHudMover : MonoBehaviour
{
    private void Start()
    {
        Plugin.Log.LogInfo($"HUD Mover (Right Side) started on {gameObject.name}");
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.KeepUICentered.Value)
        {
            transform.position = transform.position with {x = Plugin.BlackBarSize};
        }
        else
        {
            transform.position = transform.position with {x = Plugin.WidthDifference};
        }
    }
    
}