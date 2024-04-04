using AlexKiddMiracleWorldDX.Misc;
using UnityEngine;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class HudMover : MonoBehaviour
{
   private WriteOnce<float> OriginalXPosition { get; } = new();
    private WriteOnce<float> OriginalYPosition { get; } = new();
    private WriteOnce<float> OriginalZPosition { get; } = new();
    private void Start()
    {
        OriginalXPosition.Value = transform.localPosition.x;
        OriginalYPosition.Value = transform.localPosition.y;
        OriginalZPosition.Value = transform.localPosition.z;
        animator = GetComponent<Animator>();
        Plugin.LOG.LogInfo($"HUD Mover started on {gameObject.name}");
    }
    
    private Animator animator;

    private void LateUpdate()
    {
        if (!transform) return;

        if (!Plugin.KeepUICentered.Value)
        {
            var x = OriginalXPosition.Value * Plugin.PositiveScaleFactor;
            transform.localPosition = transform.localPosition with {x = x};
        }
        else
        {
            transform.localPosition = transform.localPosition with {x = OriginalXPosition.Value};
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (!animator) return;
        
        var y = OriginalYPosition.Value;
        var z = OriginalZPosition.Value;
        var x = OriginalXPosition.Value;
        
        animator.SetLookAtWeight(1);
        
        if (!Plugin.KeepUICentered.Value)
        {
            x = OriginalXPosition.Value * Plugin.PositiveScaleFactor;
            
            animator.SetLookAtPosition(new Vector3(x, y, z));
        }
        else
        {
            animator.SetLookAtPosition(new Vector3(x, y, z));
        }
        
        
    }

}