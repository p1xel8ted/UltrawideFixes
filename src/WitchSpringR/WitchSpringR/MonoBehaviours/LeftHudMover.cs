namespace WitchSpringR.MonoBehaviours;

public class LeftHudMover : MonoBehaviour
{
    private void Start()
    {
        Plugin.Logger.LogInfo($"HUD Mover (Left Side) started on {gameObject.name}");
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.SpanHud.Value)
        {
            transform.position = transform.position with {x = -Plugin.BlackBarSize};
        }
        else
        {
            transform.position = transform.position with {x = 0};
        }
    }
    
}