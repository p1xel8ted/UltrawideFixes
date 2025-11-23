namespace NeonInferno;

/// <summary>
/// Main BepInEx plugin class that coordinates ultra-wide monitor support for Winter Burrows.
/// Manages resolution, UI scaling, camera field of view, and post-processing effects.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.neoninferno.ultrawide";
    private const string PluginName = "Neon Inferno Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal const float NativeAspect = 16f / 9f;

    private static readonly HashSet<RenderTexture> ModifiedTextures = [];

    // Cached display properties for performance
    private static int _cachedWidth = -1;
    private static int _cachedHeight = -1;
    private static float _cachedAspectRatio = -1f;
    private static float _cachedScaleFactor = -1f;
    private static int _cachedMaxRefresh = -1;
    
    private static readonly WriteOnce<float> DarkenFilterOriginalWidth = new();
    private static readonly WriteOnce<float> FarBackgroundOriginalWidth = new();
    private static readonly WriteOnce<float> BlackoutOriginalWidth = new();

    internal static ManualLogSource Log { get; private set; }
    
    internal static int MainWidth
    {
        get
        {
            if (_cachedWidth <= 0)
            {
                RefreshDisplayCache();
            }

            return _cachedWidth;
        }
    }

    internal static int MainHeight
    {
        get
        {
            if (_cachedHeight <= 0)
            {
                RefreshDisplayCache();
            }

            return _cachedHeight;
        }
    }


    internal static float PositiveScaleFactor
    {
        get
        {
            if (_cachedScaleFactor <= 0f)
            {
                RefreshDisplayCache();
            }

            return _cachedScaleFactor;
        }
    }


    internal static float MainAspectRatio
    {
        get
        {
            if (_cachedAspectRatio <= 0f)
            {
                RefreshDisplayCache();
            }

            return _cachedAspectRatio;
        }
    }
    
    internal static int MaxRefresh
    {
        get
        {
            if (_cachedMaxRefresh <= 0)
            {
                var resolutions = Screen.resolutions;
                if (resolutions == null || resolutions.Length == 0)
                {
                    _cachedMaxRefresh = 60; // Fallback to 60Hz
                }
                else
                {
                    _cachedMaxRefresh = resolutions.Max(a => Mathf.RoundToInt((float)a.refreshRateRatio.value));
                }
            }

            return _cachedMaxRefresh;
        }
    }


    public static ConfigEntry<FullScreenMode> FullScreenMode { get; private set; }

    public static RefreshRate MaxRefreshStruct => new()
    {
        denominator = 1,
        numerator = (uint)MaxRefresh
    };

    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    
    private void Awake()
    {
        Log = Logger;


        FullScreenMode = Config.Bind("01. Display", "Full Screen Mode", UnityEngine.FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenMode.SettingChanged += (_, _) => UpdateDisplay();


        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;

   
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void OnSceneUnloaded(Scene scene)
    {
        ModifiedTextures.Clear();
    }


    private static void RefreshDisplayCache()
    {
        _cachedWidth = Display.main.systemWidth;
        _cachedHeight = Display.main.systemHeight;
        
        if (_cachedWidth <= 0 || _cachedHeight <= 0)
        {
            Log.LogWarning($"Invalid display dimensions detected ({_cachedWidth}x{_cachedHeight}), using fallback 1920x1080");
            _cachedWidth = 1920;
            _cachedHeight = 1080;
        }

        _cachedAspectRatio = _cachedWidth / (float)_cachedHeight;
        _cachedScaleFactor = _cachedAspectRatio / NativeAspect;
    }


    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RefreshDisplayCache();
        Patches.Patches.CleanupDestroyedScalers();
        UpdateDisplay();

        var aspectRatio = MainAspectRatio;
        UpdateCameraRenderTextures(aspectRatio);
        UpdateRawImageTextures(aspectRatio);

        var bgFilter = GameObject.Find("Background/DarkenFilter");
        if (bgFilter.transform)
        {
            DarkenFilterOriginalWidth.Value = bgFilter.transform.localScale.x;
            bgFilter.transform.localScale = bgFilter.transform.localScale with { x = DarkenFilterOriginalWidth.Value * Plugin.PositiveScaleFactor };
        }

        var bgBlackout = GameObject.Find("Background/Black");
        if (bgBlackout.transform)
        {
            BlackoutOriginalWidth.Value = bgBlackout.transform.localScale.x;
            bgBlackout.transform.localScale = bgBlackout.transform.localScale with { x = BlackoutOriginalWidth.Value * Plugin.PositiveScaleFactor };
        }

        var farBackground = GameObject.Find("Background/FarBackground");
        if (farBackground.transform)
        {
            FarBackgroundOriginalWidth.Value = farBackground.transform.localScale.x;
            farBackground.transform.localScale = farBackground.transform.localScale with { x = FarBackgroundOriginalWidth.Value * Plugin.PositiveScaleFactor };
        }
        
    }

    private static void UpdateCameraRenderTextures(float aspectRatio)
    {
        var cameras = Camera.allCameras;

        foreach (var cam in cameras)
        {
            if (!cam) continue;

            Log.LogInfo($"Camera found: {cam.name}: Aspect={cam.aspect}, Rect={cam.rect}, PixelRect={cam.pixelRect}, TargetTex={(cam.targetTexture != null ? $"{cam.targetTexture.width}x{cam.targetTexture.height}" : "null")}");

            if (cam.targetTexture)
            {
                ResizeRenderTexture(cam.targetTexture, aspectRatio);
                ModifiedTextures.Add(cam.targetTexture);
                Log.LogInfo($"-- Updated TargetTex to {cam.targetTexture.width}x{cam.targetTexture.height}");
            }
        }
    }

    private static void UpdateRawImageTextures(float aspectRatio)
    {
        var rawImages = Resources.FindObjectsOfTypeAll<RawImage>();

        foreach (var img in rawImages)
        {
            if (!img) continue;

            Log.LogInfo($"RawImage found: {img.name}: Rect={img.rectTransform.rect}, Texture={(img.texture ? $"{img.texture.width}x{img.texture.height}" : "null")}");

            if (img.name == "WhiteFade")
            {
                var newWidth = Mathf.RoundToInt(img.rectTransform.rect.height * aspectRatio);
                img.rectTransform.sizeDelta = new Vector2(newWidth, img.rectTransform.sizeDelta.y);
                Log.LogInfo($"-- Updated WhiteFade to {newWidth}x{img.rectTransform.rect.height}");
                continue;
            }

            if (img.texture is RenderTexture rt && ModifiedTextures.Contains(rt))
            {
                var newWidth = ResizeRenderTexture(rt, aspectRatio);
                img.rectTransform.sizeDelta = new Vector2(newWidth, rt.height);
                Log.LogInfo($"-- Updated Texture to {rt.width}x{rt.height}");
            }
        }
    }
    
    private static int ResizeRenderTexture(RenderTexture texture, float aspectRatio)
    {
        if (!texture || texture.height <= 0) return 0;

        var currentHeight = texture.height;
        var newWidth = Mathf.RoundToInt(currentHeight * aspectRatio);

        if (newWidth <= 0) return 0;

        texture.Release();
        texture.width = newWidth;
        texture.height = currentHeight;
        texture.Create();

        return newWidth;
    }

    private static void UpdateDisplay()
    {
        Patches.Patches.UpdateScalers(MainAspectRatio);
        
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.Value, MaxRefreshStruct);
        
        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }
    }
}