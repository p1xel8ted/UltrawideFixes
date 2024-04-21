using UnityEngine;

namespace AlwasLegacy.AspectRatio;

public class RightHudMover : MonoBehaviour
{
    private void Start()
    {
        Plugin.LOG.LogInfo($"HUD Mover (Right Side) started on {gameObject.name}");
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.SpannedHUD.Value)
        {
            transform.position = transform.position with {x = Plugin.BlackBarSize};
        }
        else
        {
            transform.position = transform.position with {x = 0};
        }
    }
    
}