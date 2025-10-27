namespace ScarletMaiden.UI.Components;

/// <summary>
/// Factory for creating and updating aspect ratio fitters with consistent configuration.
/// Centralizes fitter creation for fullscreen, HUD, and custom aspect ratios.
/// </summary>
public static class AspectRatioFitterFactory
{
    /// <summary>
    /// List of aspect ratio fitters for main HUD elements that scale to user's preferred HUD aspect ratio.
    /// </summary>
    internal static readonly List<AspectRatioFitter> MainHudFitters = [];

    /// <summary>
    /// List of aspect ratio fitters for dialog elements that scale to user's preferred dialog aspect ratio.
    /// </summary>
    internal static readonly List<AspectRatioFitter> DialogFitters = [];

    /// <summary>
    /// List of custom layout width aspect fitters that dynamically adjust width based on user preferences.
    /// </summary>
    internal static readonly List<LayoutWidthAspectFitter> LayoutElementAspectFitters = [];

    /// <summary>
    /// List of aspect ratio fitters for fullscreen elements that scale to the current display aspect ratio.
    /// </summary>
    internal static readonly List<AspectRatioFitter> FullScreenFitters = [];

    /// <summary>
    /// List of aspect ratio fitters restricted to native 16:9 aspect ratio regardless of display configuration.
    /// </summary>
    internal static readonly List<AspectRatioFitter> RestrictedFitters = [];

    /// <summary>
    /// Updates all registered aspect ratio fitters to match the current display configuration.
    /// Cleans up destroyed objects to prevent memory leaks.
    /// </summary>
    internal static void UpdateFitters()
    {
        // Clean up destroyed fitters to prevent memory leaks
        MainHudFitters.RemoveAll(fitter => fitter == null);
        DialogFitters.RemoveAll(fitter => fitter == null);
        LayoutElementAspectFitters.RemoveAll(fitter => fitter == null);
        FullScreenFitters.RemoveAll(fitter => fitter == null);
        RestrictedFitters.RemoveAll(fitter => fitter == null);

        // Update HUD fitters to use preferred aspect ratio
        foreach (var fitter in MainHudFitters)
        {
            UpdateFitter(fitter, false,false);
        }

        // Update fullscreen fitters to use current display aspect ratio
        foreach (var fitter in FullScreenFitters)
        {
            UpdateFitter(fitter, true, false);
        }

        // Update custom fitters with new width calculations
        foreach (var fitter in LayoutElementAspectFitters)
        {
            fitter.UpdateWidth();
        }

        // Update dialog fitters to use preferred aspect ratio
        foreach (var fitter in DialogFitters)
        {
            UpdateFitter(fitter, false, true);
        }
        
        // Update restricted fitters (keep them at native aspect ratio)
        foreach (var fitter in RestrictedFitters)
        {
            if (fitter)
            {
                fitter.aspectRatio = ResolutionManager.NativeAspect;
                fitter.enabled = true;
            }
        }
    }

    /// <summary>
    /// Creates and configures an aspect ratio fitter restricted to native 16:9 aspect ratio.
    /// Used for UI elements that should maintain their original aspect ratio on all displays.
    /// </summary>
    /// <param name="obj">The GameObject to add the fitter to.</param>
    /// <returns>The configured AspectRatioFitter component.</returns>
    public static AspectRatioFitter AddRestrictedFitter(GameObject obj)
    {
        var fitter = obj.TryAddComponent<AspectRatioFitter>();
        fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        fitter.aspectRatio = ResolutionManager.NativeAspect;
        fitter.enabled = true;
        return fitter;
    }

    /// <summary>
    /// Creates and configures an aspect ratio fitter using user's preferred aspect ratio.
    /// Automatically adjusts to either HUD or dialog aspect ratio based on the dialog parameter.
    /// </summary>
    /// <param name="obj">The GameObject to add the fitter to.</param>
    /// <param name="dialog">True to use dialog aspect ratio, false for HUD aspect ratio.</param>
    /// <returns>The configured AspectRatioFitter component.</returns>
    public static AspectRatioFitter AddPreferredAspectFitter(GameObject obj, bool dialog)
    {
        var fitter = obj.TryAddComponent<AspectRatioFitter>();
        fitter.aspectRatio = ResolutionManager.GetPreferredAspect(dialog);
        fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        fitter.enabled = true;

        return fitter;
    }

    /// <summary>
    /// Creates and configures a custom layout width aspect fitter.
    /// Uses LayoutElement to dynamically adjust width based on user's preferred aspect ratio.
    /// </summary>
    /// <param name="obj">The GameObject to add the fitter to.</param>
    /// <returns>The configured LayoutWidthAspectFitter component.</returns>
    public static LayoutWidthAspectFitter AddCustomAspectFitter(GameObject obj)
    {
        return obj.TryAddComponent<LayoutWidthAspectFitter>();
    }

    /// <summary>
    /// Updates an existing aspect ratio fitter to match current configuration.
    /// Adjusts aspect ratio based on whether the element is fullscreen or uses preferred settings.
    /// </summary>
    /// <param name="fitter">The AspectRatioFitter to update.</param>
    /// <param name="isFullScreen">True to use current display aspect ratio, false for preferred aspect ratio.</param>
    /// <param name="dialog">True to use dialog aspect ratio, false for HUD aspect ratio (only relevant when isFullScreen is false).</param>
    public static void UpdateFitter(AspectRatioFitter fitter, bool isFullScreen, bool dialog)
    {
        if (!fitter) return;

        fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        fitter.aspectRatio = isFullScreen ? ResolutionManager.CurrentAspect : ResolutionManager.GetPreferredAspect(dialog);
        fitter.enabled = true;
    }
}