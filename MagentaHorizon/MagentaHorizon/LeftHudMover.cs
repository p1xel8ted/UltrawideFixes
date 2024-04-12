namespace MagentaHorizon;

public class LeftHudMover : MonoBehaviour
{
    private void Start()
    {
        Plugin.Log.LogInfo($"HUD Mover (Left Side) started on {gameObject.name}");
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
            transform.position = transform.position with {x = 50};
        }
    }
    
}