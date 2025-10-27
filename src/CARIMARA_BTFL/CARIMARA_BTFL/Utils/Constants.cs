namespace CARIMARA_BTFL.Utils;

/// <summary>
/// Centralized constants used throughout the plugin.
/// </summary>
public static class Constants
{
    /// <summary>
    /// The game's native aspect ratio (16:9).
    /// </summary>
    public const float NativeAspect = 16f / 9f;

    /// <summary>
    /// Maximum supported aspect ratio (48:9 or 5.333...).
    /// Used for ultrawide background images and UI elements that support triple-monitor setups.
    /// </summary>
    public const float MaxAspect = 48f / 9f;

    /// <summary>
    /// Minimum physics update rate threshold.
    /// </summary>
    public const int MinimumPhysicsRate = 50;

    /// <summary>
    /// Default TAA sharpness value.
    /// </summary>
    public const float DefaultTaaSharpness = 0.50f;

    /// <summary>
    /// Message UI positioning constants.
    /// </summary>
    public static class MessageUI
    {
        public const float PositionOffset = 10f;
        public const float LayoutSpacing = 4f;
        public const float MaxWidthPercentage = 0.4f;
    }
}
