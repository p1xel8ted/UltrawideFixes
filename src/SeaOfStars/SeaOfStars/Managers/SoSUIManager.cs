// SoSuiManager.cs

namespace SeaOfStars.Managers;

public static class SoSuiManager
{
    internal static readonly List<Vector2> PixelPerfectRefRes = [];
    private static readonly List<CanvasUpscaleViewport> CanvasUpscaleViewports = [];
    private static readonly List<PixelPerfectCamera> PixelPerfectCameras = [];

    internal static List<LayoutController> LayoutControllers { get; } = [];
    internal static bool IsFishing { get; set; }
    private static EventSystemSwitcher _eventSystemSwitcher;
    private static Vector2 _cachedPixelPerfectVector;
    private static bool _hasCachedPixelPerfectVector;

    internal static void RefreshCaches()
    {
        CanvasUpscaleViewports.Clear();
        CanvasUpscaleViewports.AddRange(Utilities.Utilities.FindIl2CppType<CanvasUpscaleViewport>());

        PixelPerfectCameras.Clear();
        PixelPerfectCameras.AddRange(Utilities.Utilities.FindIl2CppType<PixelPerfectCamera>());

        _hasCachedPixelPerfectVector = false;
    }

    internal static void RegisterPixelPerfectCamera(PixelPerfectCamera camera)
    {
        if (!PixelPerfectCameras.Contains(camera))
        {
            PixelPerfectCameras.Add(camera);
        }
    }

    internal static void RegisterCanvasUpscaleViewport(CanvasUpscaleViewport viewport)
    {
        if (!CanvasUpscaleViewports.Contains(viewport))
        {
            CanvasUpscaleViewports.Add(viewport);
        }
    }

    internal static void ToggleContentFitter(bool active)
    {
        for (var i = LayoutControllers.Count - 1; i >= 0; i--)
        {
            var lc = LayoutControllers[i];
            if (!lc)
            {
                LayoutControllers.RemoveAt(i);
                continue;
            }

            lc.ContentSizeFitter.horizontalFit = active ? ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
        }
    }

    internal static Vector2 GetPixelPerfectVector()
    {
        if (_hasCachedPixelPerfectVector)
        {
            return _cachedPixelPerfectVector;
        }

        PixelPerfectRefRes.RemoveAll(a => a.x < 10f || a.y < 10f);
        var first = PixelPerfectRefRes.Count > 0 ? PixelPerfectRefRes[^1] : new Vector2(DisplayManager.MainWidth, DisplayManager.MainHeight);
        var x = first.y * DisplayManager.MainAspectRatio;
        var vector = new Vector2(x, first.y);
        _cachedPixelPerfectVector = vector;
        _hasCachedPixelPerfectVector = true;
        return _cachedPixelPerfectVector;
    }

    internal static void InvalidatePixelPerfectCache()
    {
        _hasCachedPixelPerfectVector = false;
    }

    public static void ProcessSceneElements()
    {
        AdjustOceanScale();
    }
    
    public static void HandleOverlayUI(bool isVisible)
    {
        // EventSystem focus-based switching
        if (isVisible)
        {
            if (!_eventSystemSwitcher)
            {
                var go = new GameObject();
                go.name = "EventSystemSwitcher";
                Object.DontDestroyOnLoad(go);
                _eventSystemSwitcher = go.AddComponent<EventSystemSwitcher>();
            }

            _eventSystemSwitcher.enabled = true;
        }
        else if (_eventSystemSwitcher)
        {
            _eventSystemSwitcher.enabled = false;
        }

        if (!DisplayManager.IsUltrawide) return;

        // Skip PPC/viewport toggle during fishing -- the fishing scene needs original camera setup
        if (IsFishing)
        {
            Plugin.Logger.LogInfo("HandleOverlayUI: Skipping PPC/viewport toggle - fishing active");
            return;
        }

        for (var i = CanvasUpscaleViewports.Count - 1; i >= 0; i--)
        {
            var vp = CanvasUpscaleViewports[i];
            if (!vp)
            {
                CanvasUpscaleViewports.RemoveAt(i);
                continue;
            }

            vp.enabled = !isVisible;
        }

        var vector = GetPixelPerfectVector();
        var pixelPerfectX = Mathf.RoundToInt(vector.x);
        var pixelPerfectY = Mathf.RoundToInt(vector.y);
        for (var i = PixelPerfectCameras.Count - 1; i >= 0; i--)
        {
            var pp = PixelPerfectCameras[i];
            if (!pp)
            {
                PixelPerfectCameras.RemoveAt(i);
                continue;
            }

            pp.refResolutionX = isVisible ? DisplayManager.MainWidth : pixelPerfectX;
            pp.refResolutionY = isVisible ? DisplayManager.MainHeight : pixelPerfectY;
        }
    }


    private static void AdjustOceanScale()
    {
        if (!DisplayManager.IsUltrawide) return;

        var ocean = GameObject.Find(Core.Constants.SosOcean);
        if (ocean)
        {
            ocean.transform.localScale = new Vector3(DisplayManager.PositiveScaleFactor, 1f, 1f);
        }
    }


}
