namespace Constance.Utils;

public class PositionEnforcer : MonoBehaviour
{
    private float newPos;

    private void OnEnable()
    {
        newPos = 1080 * Plugin.CurrentAspect; //1080 * 2.38889 = 2580
    }

    private void LateUpdate()
    {
        if (Mathf.Approximately(transform.localPosition.x, -newPos)) return;
        transform.localPosition = transform.localPosition with { x = -newPos };
        Plugin.Log.LogInfo($"Enforced journal background position.x to {-newPos}");
    }
}
