// SoSuiManager.cs

namespace SeaOfStars.Managers;

public static class SoSuiManager
{
    internal static readonly List<Vector2> PixelPerfectRefRes = [];
    // internal static float CanvasPosition => DisplayManager.MainWidth / 2f;
    private static List<CanvasUpscaleViewport> CanvasUpscaleViewports => Utilities.Utilities.FindIl2CppType<CanvasUpscaleViewport>().ToList();
    private static List<PixelPerfectCamera> PixelPerfectCameras => Utilities.Utilities.FindIl2CppType<PixelPerfectCamera>().ToList();

    internal static List<LayoutController> LayoutControllers { get; } = [];
    
    internal static void ToggleContentFitter(bool active)
    {
        foreach (var lc in LayoutControllers.Where(lc => lc))
        {
            lc.ContentSizeFitter.horizontalFit = active ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
        }
    }
    internal static Vector2 GetPixelPerfectVector()
    {
        var first = PixelPerfectRefRes.LastOrDefault();
        var x = first.y * DisplayManager.NativeAspectRatio;
        var vector = new Vector2(x, first.y);
        return vector;
    }

    public static void ProcessSceneElements()
    {
        AdjustOceanScale();
    }
    
    public static void HandleConfigManager(bool isVisible)
    {
        foreach (var vp in CanvasUpscaleViewports.Where(vp => vp != null))
        {
            vp.enabled = !isVisible;
        }

        foreach (var pp in PixelPerfectCameras.Where(pp => pp != null))
        {
            var vector = GetPixelPerfectVector();
            pp.refResolutionX = isVisible ? DisplayManager.MainWidth : Mathf.RoundToInt(vector.x);
            pp.refResolutionY = isVisible ? DisplayManager.MainHeight : Mathf.RoundToInt(vector.y);
        }
    }


    private static void AdjustOceanScale()
    {
        var ocean = GameObject.Find(Core.Constants.SosOcean);
        if (ocean)
        {
            ocean.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }
    }


    public static void UpdateUiWidth()
    {
        foreach (var lc in LayoutControllers.Where(lc => lc))
        {
            if (lc.Ignore) continue;

            lc.LayoutElement.preferredWidth = Configuration.Configuration.AdjustUiPixelAlignment.Value ? Configuration.Configuration.UiPixelAlignment.Value : lc.OriginalPreferredWidth;
            lc.ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

            lc.LayoutElement.SetDirty();
            lc.ContentSizeFitter.SetDirty();

            Canvas.ForceUpdateCanvases();
        }
    }
}