using UnityEngine;

namespace Elderand.MonoBehaviours;

public class RightHudMover : MonoBehaviour
{
    private void LateUpdate()
    {
        if (!transform) return;

        if (!Plugin.KeepUICentered.Value)
        {
            transform.position = transform.position with {x = Plugin.BlackBarSize};
        }
        else
        {
            transform.position = transform.position with {x = 0};
        }
    }

}