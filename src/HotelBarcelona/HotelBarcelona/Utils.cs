namespace HotelBarcelona;

/// <summary>
/// Shared utility methods for applying ultrawide corrections to cameras, UI images,
/// and fade transitions.
/// </summary>
internal static class Utils
{
    /// <summary>Full-screen viewport rectangle (0,0,1,1) used to override letterboxed camera rects.</summary>
    internal static readonly Rect FullViewportRect = new(0, 0, 1, 1);

    /// <summary>
    /// Overrides resolution parameters to the native display resolution.
    /// Called from <see cref="Screen.SetResolution"/> prefix patches.
    /// </summary>
    /// <param name="width">Width parameter to override.</param>
    /// <param name="height">Height parameter to override.</param>
    internal static void ApplyMainResolution(ref int width, ref int height)
    {
        width = DisplayMetrics.MainWidth;
        height = DisplayMetrics.MainHeight;
    }

    /// <summary>
    /// Overrides resolution and fullscreen mode parameters to native display resolution
    /// with borderless fullscreen. Called from <see cref="Screen.SetResolution"/> prefix patches
    /// that include a <see cref="FullScreenMode"/> parameter.
    /// </summary>
    /// <param name="width">Width parameter to override.</param>
    /// <param name="height">Height parameter to override.</param>
    /// <param name="fullscreenMode">Fullscreen mode parameter to override.</param>
    internal static void ApplyMainResolutionAndFullscreen(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        ApplyMainResolution(ref width, ref height);
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    /// <summary>
    /// Parent transform names whose descendant black 1920x1080 images should be scaled
    /// to fill the ultrawide display. Images outside these hierarchies are left untouched.
    /// </summary>
    private static readonly HashSet<string> ScaleWhitelistParents =
    [
        "TransitionManager",
        "boot_menus",
        "GalleryPlayer",
        "ScreenTrueBlood",
        "result_bg"
    ];

    /// <summary>
    /// Walks up the transform hierarchy to check if any ancestor's name is in
    /// <see cref="ScaleWhitelistParents"/>.
    /// </summary>
    /// <param name="t">The transform to check.</param>
    /// <returns><c>true</c> if a whitelisted ancestor was found; otherwise <c>false</c>.</returns>
    private static bool HasWhitelistedAncestor(Transform t)
    {
        var current = t.parent;
        while (current != null)
        {
            if (ScaleWhitelistParents.Contains(current.name))
                return true;
            current = current.parent;
        }
        return false;
    }

    /// <summary>
    /// Runs all global fixups: sets camera backgrounds to black, scales whitelisted
    /// black background images, forces all camera viewports to fullscreen, and applies
    /// the configured anti-aliasing mode. Called on plugin load, scene changes, and
    /// boot timer setup.
    /// </summary>
    internal static void ApplyGlobalFixups()
    {
        SetAllCamerasBlackBackground();
        ResizeAllBlackImages();
        UpdateCameraBehaviors();
        UpdateAntiAliasing();
    }

    /// <summary>
    /// Finds all black 1920x1080 UI images under whitelisted parent transforms and scales
    /// them horizontally by <see cref="DisplayMetrics.PositiveScaleFactor"/> to fill the
    /// ultrawide display. Skips images already at the correct scale.
    /// </summary>
    private static void ResizeAllBlackImages()
    {
        foreach (var img in Resources.FindObjectsOfTypeAll<Image>())
        {
            if (img.color != Color.black) continue;

            var size = img.rectTransform.sizeDelta;
            if (!Mathf.Approximately(size.x, 1920) || !Mathf.Approximately(size.y, 1080)) continue;
            if (!HasWhitelistedAncestor(img.transform)) continue;
            if (Mathf.Approximately(img.transform.localScale.x, DisplayMetrics.PositiveScaleFactor)) continue;

            img.transform.localScale = img.transform.localScale with { x = DisplayMetrics.PositiveScaleFactor };
        }
    }

    /// <summary>
    /// Sets the background color of every camera to black, preventing colored bars
    /// from appearing in the expanded viewport areas.
    /// </summary>
    private static void SetAllCamerasBlackBackground()
    {
        foreach (var cam in Resources.FindObjectsOfTypeAll<UnityEngine.Camera>())
        {
            if (cam.backgroundColor != Color.black)
            {
                cam.backgroundColor = Color.black;
            }
        }
    }

    /// <summary>
    /// Forces all <see cref="CameraBehavior"/> viewport rects to <see cref="FullViewportRect"/>,
    /// removing any letterboxing applied by the game's camera management system.
    /// </summary>
    private static void UpdateCameraBehaviors()
    {
        foreach (var cb in Resources.FindObjectsOfTypeAll<CameraBehavior>())
        {
            if (cb.rect != FullViewportRect)
            {
                cb.rect = FullViewportRect;
            }
        }
    }

    /// <summary>
    /// Horizontally stretches a fade controller's image to cover the full ultrawide display.
    /// Skips the operation if the scale is already correct.
    /// </summary>
    /// <param name="instance">The fade controller entity whose transform will be scaled.</param>
    internal static void StretchFadeImage(FadeControllerEntity instance)
    {
        if (Mathf.Approximately(instance.transform.localScale.x, DisplayMetrics.PositiveScaleFactor)) return;
        instance.transform.localScale = instance.transform.localScale with { x = DisplayMetrics.PositiveScaleFactor };
    }

    // --- Anti-Aliasing ---

    /// <summary>
    /// Applies the configured <see cref="AntialiasingMode"/> to all cameras that have a
    /// <see cref="UniversalAdditionalCameraData"/> component. Sets quality to
    /// <see cref="AntialiasingQuality.High"/> for best results. Called on plugin load,
    /// scene changes, and config value changes.
    /// </summary>
    internal static void UpdateAntiAliasing()
    {
        var mode = Plugin.AntiAliasing.Value;
        foreach (var data in Resources.FindObjectsOfTypeAll<UniversalAdditionalCameraData>())
        {
            data.antialiasing = mode;
            data.antialiasingQuality = AntialiasingQuality.High;
        }
    }
}
