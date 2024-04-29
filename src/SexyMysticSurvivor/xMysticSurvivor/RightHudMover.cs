using UnityEngine;

namespace xMysticSurvivor;

public class RightHudMover : MonoBehaviour
{
    private void Start()
    {
        Plugin.LOG.LogInfo($"Left HUD Mover started on {gameObject.name}");
    }


    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.SpanHUD.Value)
        {
            transform.position = transform.position with {x = 440};
        }
        else
        {
            transform.position = transform.position with {x = 0};
        }
    }
    

}