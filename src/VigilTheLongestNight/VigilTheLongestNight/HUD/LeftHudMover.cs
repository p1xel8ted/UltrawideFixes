using UnityEngine;

namespace VigilTheLongestNight.HUD;

public class LeftHudMover : MonoBehaviour
{
    private static float innerPosition;
    private static float outerPosition;
    
    private void Start()
    {
        Plugin.Logger.LogInfo($"HUD Mover (Left Side) started on {gameObject.name}");
        innerPosition = Plugin.WidthDifference / 100f;
        outerPosition = 0;
    }
    
    private void LateUpdate()
    {
        if (!transform) return;

        if (Plugin.SpannedHUD.Value)
        {
            transform.position = transform.position with {x = outerPosition};
        }
        else
        {
            transform.position = transform.position with {x = innerPosition};
        }
    }
    
}