using Shared;

namespace UnsightedUltrawide;

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
        Plugin.LOG.LogInfo($"HUD Mover started on {gameObject.name}");
    }
    
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
}