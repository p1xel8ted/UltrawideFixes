using WinterBurrow.Resolutions;

namespace WinterBurrow.UI.Components;

/// <summary>
/// Factory for creating and updating aspect ratio fitters with consistent configuration.
/// Centralizes fitter creation for fullscreen, HUD, and custom aspect ratios.
/// </summary>
public static class AspectRatioFitterFactory
{
    public static AspectRatioFitter AddFullScreenFitter(GameObject obj)
    {
        var fitter = obj.TryAddComponent<AspectRatioFitter>();
        fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        fitter.aspectRatio = ResolutionManager.CurrentAspect;
        return fitter;
    }

    public static AspectRatioFitter AddPreferredAspectFitter(GameObject obj)
    {
        var fitter = obj.TryAddComponent<AspectRatioFitter>();
        fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        fitter.aspectRatio = ResolutionManager.GetPreferredAspect();
        return fitter;
    }

    public static CustomAspectFitter AddCustomAspectFitter(GameObject obj)
    {
        return obj.TryAddComponent<CustomAspectFitter>();
    }

    public static void UpdateFitter(AspectRatioFitter fitter, bool isFullScreen)
    {
        if (!fitter) return;
        
        fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        fitter.aspectRatio = isFullScreen ? ResolutionManager.CurrentAspect : ResolutionManager.GetPreferredAspect();
    }
}