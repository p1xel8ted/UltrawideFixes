namespace KatsTrigger.MonoBehaviours;

/// <summary>
/// MonoBehaviour component that restores the user's configured framerate settings when disabled.
/// Attached to thunder effect GameObjects in the special FPS scene to restore normal framerate
/// when the effect ends (object is disabled).
/// </summary>
public class FramerateRestorer : MonoBehaviour
{
    /// <summary>
    /// Called when the GameObject is disabled. Restores the user's configured framerate settings.
    /// </summary>
    /// <remarks>
    /// Pragma warning disable CA1822 is required because making this static would prevent
    /// Unity from calling it as a MonoBehaviour event function.
    /// </remarks>
#pragma warning disable CA1822
    private void OnDisable()
#pragma warning restore CA1822
    {
        Plugin.UpdateFramerateSettings();
    }
}
