// ViewportHandler.cs

namespace SeaOfStars.Handlers;

public static class ViewportHandler
{
    public static void HandleViewportShifts()
    {
        var isModifierPressed = Input.GetKey(Configuration.Configuration.ModifierKeybind.Value);

        if (isModifierPressed)
        {
            if (Input.GetKey(Configuration.Configuration.UiPixelAlignmentLeftKeybind.Value))
            {
                ResizeViewportSmaller();
            }

            if (Input.GetKey(Configuration.Configuration.UiPixelAlignmentRightKeybind.Value))
            {
                ResizeViewportLarger();
            }
        }
        else
        {
            if (Input.GetKeyDown(Configuration.Configuration.UiPixelAlignmentLeftKeybind.Value))
            {
                ResizeViewportSmaller();
            }

            if (Input.GetKeyDown(Configuration.Configuration.UiPixelAlignmentRightKeybind.Value))
            {
                ResizeViewportLarger();
            }
        }
    }
    
    public static void ResetViewportSizeKey()
    {
        if (Input.GetKeyDown(Configuration.Configuration.ResetPixelAlignmentKeybind.Value))
        {
            ResetViewports();
        }
    }

    private static void ResizeViewportSmaller()
    {
        if (!Configuration.Configuration.AdjustUiPixelAlignment.Value) return;

        var newWidth = 0f;
        foreach (var v in SoSuiManager.LayoutControllers.Where(v => v != null))
        {
            newWidth = v.LayoutElement.preferredWidth - 0.1f;
            v.LayoutElement.preferredWidth = newWidth;
            v.ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            v.LayoutElement.SetDirty();
            v.ContentSizeFitter.SetDirty();
            Canvas.ForceUpdateCanvases();
        }

        Configuration.Configuration.UiPixelAlignment.Value = newWidth;
    }

    private static void ResizeViewportLarger()
    {
        if (!Configuration.Configuration.AdjustUiPixelAlignment.Value) return;

        var newWidth = 0f;
        foreach (var v in SoSuiManager.LayoutControllers.Where(v => v != null))
        {
            newWidth = v.LayoutElement.preferredWidth + 0.1f;
            v.LayoutElement.preferredWidth = newWidth;
            v.ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            v.LayoutElement.SetDirty();
            v.ContentSizeFitter.SetDirty();
            Canvas.ForceUpdateCanvases();
        }

        Configuration.Configuration.UiPixelAlignment.Value = newWidth;
    }

    private static void ResetViewports()
    {
        foreach (var v in SoSuiManager.LayoutControllers.Where(v => v != null))
        {
            v.LayoutElement.preferredWidth = v.OriginalPreferredWidth;
            v.ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            v.LayoutElement.SetDirty();
            v.ContentSizeFitter.SetDirty();
            Canvas.ForceUpdateCanvases();
        }

        Configuration.Configuration.UiPixelAlignment.Value = 0;
    }
}