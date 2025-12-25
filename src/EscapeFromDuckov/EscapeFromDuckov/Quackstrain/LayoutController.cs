namespace Quackstrain;

/// <summary>
/// MonoBehaviour component that manages aspect ratio corrections for UI elements on ultrawide monitors.
/// Provides two modes: AspectRatioFitter (Unity's built-in) or LayoutElement (manual width control).
/// Automatically tracks all instances for potential batch updates (e.g., resolution changes).
/// </summary>
public class LayoutController : MonoBehaviour
{
    // Unity Layout Components (only one set is active based on _useAspectRatioFitter)
    private AspectRatioFitter _aspectRatioFitter; // Unity's built-in aspect ratio constraint component
    private ContentSizeFitter _contentSizeFitter; // Works with LayoutElement to size content
    private LayoutElement _layoutElement;         // Manual width/height control component

    // Configuration
    private float _customSize;             // Custom aspect ratio or width value (when LayoutSize.Custom)
    private LayoutSize _size;              // Which sizing mode to use (FullScreen, SixteenNine, or Custom)
    private bool _useAspectRatioFitter;    // true = AspectRatioFitter mode, false = LayoutElement mode

    /// <summary>
    /// Tracks all active LayoutController instances in the scene.
    /// Used for batch operations like updating all UIs when screen resolution changes.
    /// HashSet ensures O(1) add/remove operations and prevents duplicates.
    /// </summary>
    private static readonly HashSet<LayoutController> Instances = [];

    /// <summary>
    /// Gets a read-only collection of all active LayoutController instances.
    /// Used by ModBehaviour for cleanup during mod disable/unload.
    /// </summary>
    /// <returns>Read-only collection of all tracked instances</returns>
    internal static IReadOnlyCollection<LayoutController> GetAllInstances() => Instances;

    /// <summary>
    /// Unity lifecycle: Called when this component is being destroyed.
    /// Cleans up all Unity layout components and removes from instance tracking.
    /// Note: Manual component destruction may be redundant as Unity auto-destroys components
    /// when GameObject is destroyed, but ensures proper cleanup if controller is removed independently.
    /// </summary>
    internal void OnDestroy()
    {
        // Clean up LayoutElement mode components
        if (_layoutElement)
        {
            Destroy(_layoutElement);
        }

        if (_contentSizeFitter)
        {
            Destroy(_contentSizeFitter);
        }

        // Clean up AspectRatioFitter mode component
        if (_aspectRatioFitter)
        {
            Destroy(_aspectRatioFitter);
        }

        // Remove from instance tracking (O(1) HashSet operation)
        Instances.Remove(this);
    }

    /// <summary>
    /// Gets the calculated preferred width when using LayoutElement mode.
    /// Used by AimMarker patches to calculate pillarbox offset for cursor positioning.
    /// </summary>
    /// <returns>The preferred width in pixels, or 0 if not using LayoutElement mode</returns>
    internal float GetLayoutElementWidth()
    {
        return _layoutElement ? _layoutElement.preferredWidth : 0f;
    }

    /// <summary>
    /// Gets the configured layout size mode for this controller.
    /// Includes Unity null check to return default if component is destroyed.
    /// </summary>
    /// <returns>The LayoutSize enum value, or ForceFullScreen if destroyed</returns>
    internal LayoutSize GetLayoutSize()
    {
        return this ? _size : LayoutSize.ForceFullScreen;
    }

    /// <summary>
    /// Updates all LayoutController instances. Useful for handling screen resolution changes.
    /// NOTE: Currently not wired up to any resolution change detection. Call manually if needed.
    /// </summary>
    internal static void UpdateAllInstances()
    {
        foreach (var instance in Instances)
        {
            if (instance) // Unity null check for destroyed objects
            {
                instance.UpdateAspect();
            }
        }
    }

    /// <summary>
    /// Adds a LayoutController to a child Transform found by path and configures its layout.
    /// Convenience method that combines Transform.Find with AddLayoutControllerRoot.
    /// Common use case: Applying layout to nested UI elements like "BG" or "Content/ScrollView".
    /// </summary>
    /// <param name="transform">The parent Transform to search from</param>
    /// <param name="findPath">The path to the child Transform (e.g., "BG" or "Content/Viewport")</param>
    /// <param name="size">The layout size mode to apply</param>
    /// <param name="customSize">Custom value when using LayoutSize.Custom</param>
    /// <param name="useAspectRatioFitter">true for AspectRatioFitter mode, false for LayoutElement mode</param>
    /// <returns>The LayoutController component, or null if path not found</returns>
    internal static LayoutController AddLayoutControllerPath(
        Transform transform,
        string findPath,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter)
    {
        var foundTransform = transform.Find(findPath);
        if (foundTransform)
        {
            var lc = AddLayoutControllerRoot(foundTransform, size, customSize, useAspectRatioFitter);
            return lc;
        }

        return null; // Path not found
    }


    /// <summary>
    /// Adds a LayoutController to the specified Transform and configures its layout.
    /// Uses GetOrAddComponent to safely handle existing controllers (idempotent operation).
    /// </summary>
    /// <param name="transform">The Transform to add the LayoutController to</param>
    /// <param name="size">The layout size mode (FullScreen, SixteenNine, or Custom)</param>
    /// <param name="customSize">Custom aspect ratio or width when using LayoutSize.Custom</param>
    /// <param name="useAspectRatioFitter">true for AspectRatioFitter mode (most UI), false for LayoutElement mode (HUD)</param>
    /// <returns>The LayoutController component (new or existing)</returns>
    internal static LayoutController AddLayoutControllerRoot(Transform transform,
        LayoutSize size,
        float customSize,
        bool useAspectRatioFitter)
    {
        // GetOrAddComponent returns existing component if present, preventing duplicates
        var lc = transform.gameObject.GetOrAddComponent<LayoutController>();
        lc.Init(size, customSize, useAspectRatioFitter);
        lc.UpdateAspect();
        return lc;
    }

    /// <summary>
    /// Initializes the LayoutController with specified size and aspect ratio settings.
    /// Private method called by AddLayoutControllerRoot after GetOrAddComponent.
    /// </summary>
    /// <param name="size">Layout size mode (FullScreen, SixteenNine, or Custom)</param>
    /// <param name="customSize">Custom aspect ratio/width value when using LayoutSize.Custom</param>
    /// <param name="useArf">true for AspectRatioFitter mode, false for LayoutElement+ContentSizeFitter mode</param>
    private void Init(LayoutSize size, float customSize, bool useArf)
    {
        _size = size;
        _useAspectRatioFitter = useArf;
        _customSize = customSize;
        AddUpdateFitters();  // Add the appropriate Unity layout components
        Instances.Add(this); // Track this instance (HashSet.Add is idempotent, safe to call multiple times)
    }

    /// <summary>
    /// Adds and configures the appropriate Unity layout components based on the mode.
    /// AspectRatioFitter mode (most UI): Uses Unity's built-in aspect ratio constraint.
    /// LayoutElement mode (HUD): Manual width control with ContentSizeFitter for dynamic sizing.
    /// </summary>
    private void AddUpdateFitters()
    {
        if (_useAspectRatioFitter)
        {
            // AspectRatioFitter mode: Add Unity's aspect ratio constraint component
            // Used for most UI elements (menus, panels, etc.)
            _aspectRatioFitter = gameObject.GetOrAddComponent<AspectRatioFitter>();
        }
        else
        {
            // LayoutElement mode: Manual width control
            // Used for HUD elements that need precise width calculations for pillarbox offset
            _layoutElement = gameObject.GetOrAddComponent<LayoutElement>();
            _contentSizeFitter = gameObject.GetOrAddComponent<ContentSizeFitter>();
        }

        UpdateAspect(); // Apply the initial layout configuration
    }

    /// <summary>
    /// Updates the layout properties (width, aspect ratio) based on the current configuration.
    /// Called during initialization and potentially when screen resolution changes.
    /// Handles both LayoutElement mode (manual width) and AspectRatioFitter mode (aspect ratio constraint).
    /// </summary>
    private void UpdateAspect()
    {
        // ===== LAYOUT ELEMENT MODE =====
        // Manual width calculation for precise control (used by HUD for pillarbox offset)
        if (_layoutElement)
        {
            const int height = 1080; // Reference height for width calculations
            var width = _size switch
            {
                LayoutSize.Custom => _customSize,
                LayoutSize.ForceFullScreen => Screen.width, // Full ultrawide width (e.g., 3440)
                // NOTE: This calculation appears wrong (uses FullScreenAspect instead of SixteenNineAspect)
                // but has been verified to produce correct 16:9 layout in-game. Likely due to how Unity's
                // ContentSizeFitter or the game's layout system interprets LayoutElement.preferredWidth.
                // Math: 1080 * 2.38889 = 2560 (ultrawide width) somehow produces 16:9 result in practice.
                LayoutSize.ForceSixteenNine => Mathf.RoundToInt(height * Patches.FullScreenAspect),
                _ => throw new ArgumentOutOfRangeException()
            };

            _layoutElement.preferredWidth = width;
            // Enable only when in LayoutElement mode (defensive null check)
            if (_layoutElement)
            {
                _layoutElement.enabled = !_useAspectRatioFitter;
            }
        }

        // Configure ContentSizeFitter to use the LayoutElement's preferred width
        if (_contentSizeFitter)
        {
            _contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            // Enable only when in LayoutElement mode (defensive null check)
            if (_contentSizeFitter)
            {
                _contentSizeFitter.enabled = !_useAspectRatioFitter;
            }
        }

        // ===== ASPECT RATIO FITTER MODE =====
        // Unity's built-in aspect ratio constraint (used by most UI elements)
        if (_aspectRatioFitter)
        {
            // Calculate the target aspect ratio based on size mode
            var aspect = _size switch
            {
                LayoutSize.Custom => _customSize,                   // User-defined aspect ratio
                LayoutSize.ForceFullScreen => Patches.FullScreenAspect, // Ultrawide aspect (e.g., 21:9)
                LayoutSize.ForceSixteenNine => Patches.SixteenNineAspect, // Standard 16:9 aspect
                _ => Patches.FullScreenAspect                      // Default to full screen
            };

            // Configure AspectRatioFitter to constrain width based on height
            _aspectRatioFitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            _aspectRatioFitter.aspectRatio = aspect;
            // Enable only when in AspectRatioFitter mode (defensive null check)
            if (_aspectRatioFitter)
            {
                _aspectRatioFitter.enabled = _useAspectRatioFitter;
            }
        }
    }

    /// <summary>
    /// Defines the layout sizing modes for UI elements on ultrawide monitors.
    /// </summary>
    internal enum LayoutSize
    {
        /// <summary>
        /// Use the full screen aspect ratio (e.g., 21:9, 32:9).
        /// Used for backgrounds and full-screen elements that should fill the entire display.
        /// </summary>
        ForceFullScreen,

        /// <summary>
        /// Force standard 16:9 aspect ratio with pillarboxing on ultrawide displays.
        /// Used for most game UI to prevent stretching and maintain intended proportions.
        /// </summary>
        ForceSixteenNine,

        /// <summary>
        /// Use a custom aspect ratio or width value specified by the user.
        /// Allows for special case handling of specific UI elements.
        /// </summary>
        Custom,
    }
}