namespace ProjectSongbird;

/// <summary>
/// MonoBehaviour that enforces the ultrawide scale factor on its transform every LateUpdate.
/// Used for UI elements (e.g. damage vignette) that the game resets each frame.
/// Registered via <c>ClassInjector.RegisterTypeInIl2Cpp</c> in Plugin.Load.
/// </summary>
public class ScaleEnforcer : MonoBehaviour
{
    private void OnEnable()
    {
        this.LogInfo("ScaleEnforcer enabled.");
    }

    private void LateUpdate()
    {
        if (Mathf.Approximately(transform.localScale.x, DisplayMetrics.ScaleFactor)) return;

        transform.localScale = transform.localScale with { x = DisplayMetrics.ScaleFactor };

        this.LogInfo($"Enforced scale. New scale: {transform.localScale}");
    }
}