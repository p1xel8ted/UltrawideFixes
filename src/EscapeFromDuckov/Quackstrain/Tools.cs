namespace Quackstrain;

/// <summary>
/// Utility class providing helper methods for UI manipulation, logging, and component management.
/// </summary>
public static class Tools
{
    /// <summary>
    /// Finds the Canvas containing the main menu UI hierarchy.
    /// Searches all active and inactive Canvas components for one with a "MainMenuContainer" child.
    /// </summary>
    /// <returns>The Canvas containing MainMenuContainer, or null if not found.</returns>
    private static Canvas FindMainMenuCanvas()
    {
        // Search all canvases including inactive ones (true parameter)
        var canvases = Object.FindObjectsOfType<Canvas>(true);
        return canvases.FirstOrDefault(canvas => canvas.transform.Find("MainMenuContainer"));
    }

    /// <summary>
    /// Log severity levels for categorizing debug messages.
    /// </summary>
    internal enum LogLevel
    {
        /// <summary>Informational message for normal operation</summary>
        Info,
        /// <summary>Warning message for non-critical issues</summary>
        Warning,
        /// <summary>Error message for critical failures</summary>
        Error
    }

    /// <summary>
    /// Logs a message to Unity's console with the [Quackstrain] prefix.
    /// </summary>
    /// <param name="message">The message to log</param>
    /// <param name="level">The severity level (defaults to Info)</param>
    internal static void Log(string message, LogLevel level = LogLevel.Info)
    {
        var baseMessage = "[Quackstrain]: " + message;
        switch (level)
        {
            case LogLevel.Info:
                Debug.Log(baseMessage);
                break;
            case LogLevel.Warning:
                Debug.LogWarning(baseMessage);
                break;
            case LogLevel.Error:
                Debug.LogError(baseMessage);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(level), level, null);
        }
    }

    /// <summary>
    /// Finds the main menu container Transform in the scene.
    /// Used by MainMenu patches to locate the correct UI hierarchy for aspect ratio fixes.
    /// </summary>
    /// <returns>The MainMenuContainer Transform, or null if not found.</returns>
    public static Transform FindMainMenuContainer()
    {
        var c = FindMainMenuCanvas();
        return c ? c.transform.Find("MainMenuContainer") : null;
    }

    /// <summary>
    /// Moves a standard Unity Image component to a dedicated holder GameObject with full-screen layout.
    /// This prevents the image from being constrained by 16:9 aspect ratio layout when it should cover the full screen.
    /// Common use case: Background images that should fill the entire ultrawide display.
    /// </summary>
    /// <param name="parent">The Transform containing the Image component to move</param>
    public static void MoveImageToHolder(Transform parent)
    {
        // Check if parent has an Image component to move
        var normalImage = parent.GetComponent<Image>();
        if (!normalImage) return;

        // Check if holder already exists to avoid duplicate work
        var existing = parent.Find("ImageHolder");
        if (existing)
        {
            // Validate existing holder has required components (Image + LayoutController)
            if (existing.GetComponent<Image>() && existing.GetComponent<LayoutController>())
            {
                return; // Already properly set up, nothing to do
            }

            // Existing holder is malformed, destroy and recreate
            Log("MoveImageToHolder: Found existing holder but missing components, recreating", LogLevel.Warning);
            Object.Destroy(existing.gameObject);
        }

        // Create new holder GameObject as child of parent
        var holder = new GameObject("ImageHolder");
        holder.transform.SetParent(parent, false);
        holder.transform.SetAsFirstSibling(); // Render behind other UI elements

        // Configure RectTransform to stretch to fill parent completely
        var holderRect = holder.AddComponent<RectTransform>();
        holderRect.anchorMin = Vector2.zero;     // Bottom-left corner
        holderRect.anchorMax = Vector2.one;      // Top-right corner
        holderRect.offsetMin = Vector2.zero;     // No offset from anchors
        holderRect.offsetMax = Vector2.zero;     // Perfect fill

        // Copy Image component to holder with all properties
        var newImage = holder.AddComponent<Image>();
        newImage.sprite = normalImage.sprite;
        newImage.color = normalImage.color;
        newImage.material = normalImage.material;
        newImage.raycastTarget = normalImage.raycastTarget;

        // Remove original Image from parent (no longer needed)
        Object.Destroy(normalImage);

        // Add LayoutController to force full-screen aspect ratio (not 16:9)
        var lc = LayoutController.AddLayoutControllerRoot(holder.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, true);
        Log($"MoveImageToHolder Applied LayoutController to ImageHolder with LayoutSize: {lc.GetLayoutSize()}");
    }
    
    /// <summary>
    /// Moves a TranslucentImage component (blur effect) to a dedicated holder GameObject with full-screen layout.
    /// TranslucentImage provides blur effects for backgrounds. Moving to a holder prevents the blur from being
    /// constrained by 16:9 layout, ensuring full-screen blur coverage on ultrawide monitors.
    /// Common use case: Blurred backgrounds in pause menus and map overlays.
    /// </summary>
    /// <param name="parent">The Transform containing the TranslucentImage component to move</param>
    public static void MoveTranslucentImageToHolder(Transform parent)
    {
        // Check if parent has a TranslucentImage component to move
        var translucentImage = parent.GetComponent<TranslucentImage>();
        if (!translucentImage) return;

        // Check if holder already exists to avoid duplicate work
        var existing = parent.Find("TranslucentImageHolder");
        if (existing)
        {
            // Validate existing holder has required components (TranslucentImage + LayoutController)
            if (existing.GetComponent<TranslucentImage>() && existing.GetComponent<LayoutController>())
            {
                return; // Already properly set up, nothing to do
            }

            // Existing holder is malformed, destroy and recreate
            Log("MoveTranslucentImageToHolder: Found existing holder but missing components, recreating", LogLevel.Warning);
            Object.Destroy(existing.gameObject);
        }

        // Create new holder GameObject as child of parent
        var holder = new GameObject("TranslucentImageHolder");
        holder.transform.SetParent(parent, false);
        holder.transform.SetAsFirstSibling(); // Render behind other UI elements (blur background)

        // Configure RectTransform to stretch to fill parent completely
        var holderRect = holder.AddComponent<RectTransform>();
        holderRect.anchorMin = Vector2.zero;     // Bottom-left corner
        holderRect.anchorMax = Vector2.one;      // Top-right corner
        holderRect.offsetMin = Vector2.zero;     // No offset from anchors
        holderRect.offsetMax = Vector2.zero;     // Perfect fill

        // Copy TranslucentImage component to holder with all properties
        var newImage = holder.AddComponent<TranslucentImage>();
        newImage.sprite = translucentImage.sprite;
        newImage.color = translucentImage.color;
        newImage.material = translucentImage.material;
        newImage.raycastTarget = translucentImage.raycastTarget;

        // Remove original TranslucentImage from parent (no longer needed)
        Object.Destroy(translucentImage);

        // Add LayoutController to force full-screen aspect ratio (blur should cover entire screen)
        var lc = LayoutController.AddLayoutControllerRoot(holder.transform, LayoutController.LayoutSize.ForceFullScreen, 0f, true);
        Log($"MoveTranslucentImageToHolder Applied LayoutController to TranslucentImageHolder with LayoutSize: {lc.GetLayoutSize()}");
    }
}