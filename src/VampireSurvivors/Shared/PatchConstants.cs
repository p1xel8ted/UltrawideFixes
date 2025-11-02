namespace Shared;

/// <summary>
/// Configuration constants for Harmony patches and ultra-wide adjustments.
/// </summary>
internal static class PatchConstants
{
    /// <summary>
    /// UI elements that need horizontal scaling to prevent stretching on ultra-wide displays.
    /// These elements are typically full-screen overlays or transitions.
    /// </summary>
    internal static readonly string[] ScaleTheseUIElements =
    [
        "YellowBackground",
        "Fade",
        "Image - SceneTransition",
        "YellowBackground_ADD"
    ];

    /// <summary>
    /// Additional padding multiplier to ensure proper coverage on ultra-wide displays.
    /// 10% padding (5% on each side) prevents edge artifacts.
    /// </summary>
    internal const float PaddingMultiplier = 0.1f;

    /// <summary>
    /// Minimum time in seconds between toggle key presses to prevent accidental double-toggles.
    /// </summary>
    internal const float ToggleDebounceTime = 0.5f;
}
