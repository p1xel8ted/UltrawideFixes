namespace PlatypusReclayed.Gameplay;

/// <summary>
/// Game-specific constants used for ultrawide calculations and adjustments.
/// These values are based on the game's native resolution and coordinate system.
/// </summary>
internal static class GameConstants
{
    /// <summary>
    /// The center X coordinate of the native screen (640x480).
    /// Used as reference point for position calculations.
    /// </summary>
    internal const float NativeScreenCenterX = 320f;

    /// <summary>
    /// The native screen width (640 pixels).
    /// Used for offset calculations in ultrawide mode.
    /// </summary>
    internal const float NativeScreenWidth = 640f;

    /// <summary>
    /// The native screen height (480 pixels).
    /// Used for background scaling calculations.
    /// </summary>
    internal const float NativeScreenHeight = 480f;

    /// <summary>
    /// The width of background clear color element.
    /// </summary>
    internal const float BackgroundClearColorWidth = 860f;

    /// <summary>
    /// Additional offset adjustment applied to player weapon positioning.
    /// </summary>
    internal const float PlayerWeaponOffsetAdjustment = 5f;
}
