using UnityEngine;

namespace WitchSpringR.MonoBehaviours;

public class RightHudMover : MonoBehaviour
{
    private void Start()
    {
        Plugin.Logger.LogInfo($"HUD Mover (Right Side) started on {gameObject.name}");
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.SpanHud.Value)
        {
            transform.position = transform.position with {x = Plugin.BlackBarSize};
        }
        else
        {
            transform.position = transform.position with {x = 0};
        }
    }
    
}