using UnityEngine;

namespace Elderland.MonoBehaviours;

public class MiddleHudMover : MonoBehaviour
{
    private void LateUpdate()
    {
        if (!transform) return;

        if (!Plugin.KeepUICentered.Value)
        {
            transform.position = transform.position with {x = 0};
        }
        else
        {
            transform.position = transform.position with {x = Plugin.BlackBarSize};
        }
    }

}