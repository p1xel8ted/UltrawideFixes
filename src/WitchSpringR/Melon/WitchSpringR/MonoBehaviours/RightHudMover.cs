namespace WitchSpringR.MonoBehaviours;

public class RightHudMover : MonoBehaviour
{
    private void Start()
    {
        MelonLogger.Msg($"HUD Mover (Right Side) started on {gameObject.name}");
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Mod.SpanHud.Value)
        {
            transform.position = transform.position with {x = Mod.BlackBarSize};
        }
        else
        {
            transform.position = transform.position with {x = 0};
        }
    }
    
}