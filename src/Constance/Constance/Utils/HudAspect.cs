namespace Constance.Utils;

public class HudAspect : MonoBehaviour
{
    private float originalPosX;
    public bool rightSideHud;

    private void Awake()
    {
        originalPosX = transform.localPosition.x;
        Plugin.Log.LogInfo($"HudAspect Awake on {name}: originalPosX = {originalPosX}");
    }

    private void LateUpdate()
    {
        var hudValue = Plugin.GetHudValue();

        if (rightSideHud)
        {
            // Right-aligned HUD element
            var targetX = originalPosX - hudValue;
            if (Mathf.Approximately(transform.localPosition.x, targetX)) return;
            transform.localPosition = transform.localPosition with { x = targetX };
            Plugin.Log.LogInfo($"Adjusted HUD position.x on {name} to {targetX} for current aspect");
            return;
        }

        if (Mathf.Approximately(transform.localPosition.x, hudValue)) return;
        transform.localPosition = transform.localPosition with { x = hudValue };
        Plugin.Log.LogInfo($"Adjusted HUD position.x {name} to {hudValue} for current aspect");
    }
}
