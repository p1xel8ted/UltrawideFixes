[assembly: MelonInfo(typeof(Mod), Mod.PluginName, Mod.PluginVersion, "p1xel8ted")]
namespace xRESIST;

public class Mod : MelonMod
{
    internal const string PluginName = "1000xRESIST Ultra-Wide";
    internal const string PluginVersion = "0.1.1";

    internal const float NativeAspect = 16.0f / 9.0f;

    public override void OnInitializeMelon()
    {
        // Register Il2Cpp types for custom MonoBehaviours
        try
        {
            ClassInjector.RegisterTypeInIl2Cpp<LayoutController>();
            ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
           // ClassInjector.RegisterTypeInIl2Cpp<Patches.Forcer>();
            MelonLogger.Msg("Il2Cpp types registered successfully");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"Failed to register Il2Cpp types: {ex.Message}");
        }

        // Create preferences category
        var category = MelonPreferences.CreateCategory("UltrawideFix");
        category.SetFilePath($"{PluginName}.cfg");

        // Initialize resolution settings
        var availableResolutions = Screen.resolutions;
        var defaultResolution = availableResolutions != null && availableResolutions.Length > 0
            ? availableResolutions[^1]
            : new Resolution { width = Screen.width, height = Screen.height };

        Resolution = category.CreateEntry("Resolution",
            $"{defaultResolution.width}x{defaultResolution.height}",
            "Resolution",
            "Set the resolution. Format: WIDTHxHEIGHT (e.g., 3440x1440)");

        FullScreenModeConfig = category.CreateEntry("FullScreenMode",
            FullScreenMode.FullScreenWindow,
            "Full Screen Mode",
            "Set the full screen mode: Windowed, FullScreenWindow, or ExclusiveFullScreen");

        // Initialize refresh rate settings
        UseCustomRefreshRate = category.CreateEntry("UseCustomRefreshRate",
            false,
            "Use Custom Refresh Rate",
            "Enable to set a custom refresh rate instead of using the maximum available");

        CustomRefreshRate = category.CreateEntry("CustomRefreshRate",
            60,
            "Custom Refresh Rate",
            "Set the custom refresh rate in Hz (only used if UseCustomRefreshRate is enabled)");

        // Initialize VSync settings
        VSyncSetting = category.CreateEntry("VSync",
            "Enabled (Every Refresh)",
            "VSync Setting",
            "Set VSync mode: Disabled (Higher Performance), Enabled (Every Refresh), or Enabled (Every 2nd Refresh)");

        TargetFramerate = category.CreateEntry("TargetFramerate",
            MaxRefresh,
            "Target Framerate",
            "Set the target framerate when VSync is disabled");

        // Initialize camera offset settings
        OffsetX = category.CreateEntry("CameraOffsetX",
            0f,
            "Camera Offset X",
            "Horizontal camera offset for Cinemachine cameras");

        OffsetY = category.CreateEntry("CameraOffsetY",
            0f,
            "Camera Offset Y",
            "Vertical camera offset for Cinemachine cameras");

        OffsetZ = category.CreateEntry("CameraOffsetZ",
            0f,
            "Camera Offset Z",
            "Depth camera offset for Cinemachine cameras");

#if DEBUG
        // Debug testing resolutions
        SixteenTenTesting = category.CreateEntry("Test16:10",
            false,
            "Test 16:10 Aspect Ratio",
            "Enable to test 16:10 aspect ratio (1920x1200)");

        ThirtyTwoNineTesting = category.CreateEntry("Test32:9",
            false,
            "Test 32:9 Aspect Ratio",
            "Enable to test 32:9 aspect ratio (3200x900)");

        FourtyEightNineTesting = category.CreateEntry("Test48:9",
            false,
            "Test 48:9 Aspect Ratio",
            "Enable to test 48:9 aspect ratio (3200x600)");
#endif

        MelonLogger.Msg($"{PluginName} v{PluginVersion} initialized");
        MelonLogger.Msg($"Current Resolution: {SelectedResolution.width}x{SelectedResolution.height}");
        MelonLogger.Msg($"Aspect Ratio: {MainAspectRatio:F3} (Native: {NativeAspect:F3})");
    }

    public override void OnLateUpdate()
    {
        UpdateAll();
    }

    // Lazy-initialized to avoid accessing Display.main during static initialization
    private static int? _nativeDisplayWidth;
    private static int? _nativeDisplayHeight;

    private static int NativeDisplayWidth
    {
        get
        {
            if (_nativeDisplayWidth == null)
            {
                _nativeDisplayWidth = Display.main != null ? Display.main.systemWidth : Screen.width;
            }
            return _nativeDisplayWidth.Value;
        }
    }

    private static int NativeDisplayHeight
    {
        get
        {
            if (_nativeDisplayHeight == null)
            {
                _nativeDisplayHeight = Display.main != null ? Display.main.systemHeight : Screen.height;
            }
            return _nativeDisplayHeight.Value;
        }
    }
#if DEBUG
    private static MelonPreferences_Entry<bool> SixteenTenTesting { get; set; }
    private static MelonPreferences_Entry<bool> ThirtyTwoNineTesting { get; set; }
    private static MelonPreferences_Entry<bool> FourtyEightNineTesting { get; set; }
#endif
    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static float NegativeScaleFactor => MainHeight > 0 ? NativeAspect / MainAspectRatio : 1f;
    internal static float PositiveScaleFactor => MainHeight > 0 ? MainAspectRatio / NativeAspect : 1f;
    internal static float MainAspectRatio => MainHeight > 0 ? MainWidth / (float)MainHeight : NativeAspect;

    private static int MaxRefresh
    {
        get
        {
            var resolutions = Screen.resolutions;
            if (resolutions == null || resolutions.Length == 0)
            {
                return 60; // Default fallback
            }
            return resolutions.Max(a => a.refreshRate);
        }
    }

    internal static int RefreshRate
    {
        get
        {
            if (UseCustomRefreshRate != null && CustomRefreshRate != null)
            {
                return UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
            }

            return MaxRefresh;
        }
    }


    private static MelonPreferences_Entry<int> CustomRefreshRate { get; set; }

    internal static MelonPreferences_Entry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static int MainWidth => SelectedResolution.width;
    private static int MainHeight => SelectedResolution.height;

    private static MelonPreferences_Entry<bool> UseCustomRefreshRate { get; set; }

    internal static MelonPreferences_Entry<float> OffsetX { get; set; }
    internal static MelonPreferences_Entry<float> OffsetY { get; set; }
    internal static MelonPreferences_Entry<float> OffsetZ { get; set; }
    private static MelonPreferences_Entry<int> TargetFramerate { get; set; }
    private static MelonPreferences_Entry<string> Resolution { get; set; }
    private static MelonPreferences_Entry<string> VSyncSetting { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
#if DEBUG
            if (SixteenTenTesting.Value)
            {
                const int height = 1200;
                var width = Mathf.RoundToInt(height * 1.6f); // 1200 * 1.6f = 1920
                return new Resolution { width = width, height = height };
            }

            if (ThirtyTwoNineTesting.Value)
            {
                const int height = 900;
                var width = Mathf.RoundToInt(height * 3.555555555555556f); // 900 * 3.555555555555556f = 3200
                return new Resolution { width = width, height = height };
            }

            if (FourtyEightNineTesting.Value)
            {
                const int height = 600;
                var width = Mathf.RoundToInt(height * 5.333333333333333f); // 600 * 5.333333333333333f = 3200
                return new Resolution { width = width, height = height };
            }
#endif

            if (Resolution == null)
            {
                return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
            }

            try
            {
                var res = Resolution.Value.Split('x');
                if (res.Length != 2)
                {
                    MelonLogger.Warning($"Invalid resolution format: {Resolution.Value}. Using native resolution.");
                    return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
                }

                if (int.TryParse(res[0], out var width) && int.TryParse(res[1], out var height))
                {
                    if (width <= 0 || height <= 0)
                    {
                        MelonLogger.Warning($"Invalid resolution dimensions: {width}x{height}. Using native resolution.");
                        return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
                    }
                    return new Resolution { width = width, height = height };
                }
                else
                {
                    MelonLogger.Warning($"Failed to parse resolution: {Resolution.Value}. Using native resolution.");
                    return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Error parsing resolution: {ex.Message}. Using native resolution.");
                return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };
            }
        }
    }

    private static bool RequiresUpdate { get; set; }

    internal static float CurrentAspect => (float)SelectedResolution.width / SelectedResolution.height;


    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            MelonLogger.Warning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;


        var nativeDisplayWidth = NativeDisplayHeight * NativeAspect;
        var uiCamera = Resources.FindObjectsOfTypeAll<Camera>().FirstOrDefault(a => a.name == "UICamera");
        if (uiCamera)
        {
            if (!Mathf.Approximately(uiCamera.pixelRect.width, nativeDisplayWidth))
            {
                RequiresUpdate = true;
            }
        }

        var mainCamera = Resources.FindObjectsOfTypeAll<Camera>().FirstOrDefault(a => a.name == "Main Camera");
        if (mainCamera)
        {
            if (!Mathf.Approximately(mainCamera.aspect, MainAspectRatio))
            {
                RequiresUpdate = true;
            }
        }

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;

        // if (Patches.ConfigCanvasScaler != null)
        // {
        //     try
        //     {
        //         Patches.ConfigCanvasScaler.OnEnable();
        //     }
        //     catch (Exception ex)
        //     {
        //         MelonLogger.Warning($"Failed to update ConfigCanvasScaler: {ex.Message}");
        //     }
        // }

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRate);
        MelonLogger.Msg($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        RequiresUpdate = false;
    }


    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
        UpdateCameras();
    }

    private static readonly Dictionary<int, Camera.GateFitMode> OriginalGateFitModes = new();
    private const int MaxCachedCameras = 100; // Prevent unbounded growth

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();

        // Clean up destroyed cameras from dictionary to prevent memory leak
        if (OriginalGateFitModes.Count > MaxCachedCameras)
        {
            var validIds = new HashSet<int>(cameras.Where(c => c != null).Select(c => c.GetInstanceID()));
            var keysToRemove = OriginalGateFitModes.Keys.Where(id => !validIds.Contains(id)).ToList();
            foreach (var key in keysToRemove)
            {
                OriginalGateFitModes.Remove(key);
            }
        }

        foreach (var camera in cameras)
        {
            if (!camera) continue;

            if (!OriginalGateFitModes.TryGetValue(camera.GetInstanceID(), out var gf))
            {
                OriginalGateFitModes.Add(camera.GetInstanceID(), camera.gateFit);
                gf = camera.gateFit;
            }

            camera.gateFit = CurrentAspect > NativeAspect ? Camera.GateFitMode.Vertical : gf;

            if (camera.name != "UICamera") continue;

            camera.aspect = NativeAspect;

            if (CurrentAspect > NativeAspect)
            {
                var widthDiff = MainWidth - MainHeight * NativeAspect; //3440 - (1440 * 1.7777778) = 3440 - 2560 = 880
                var blackBarSize = widthDiff / 2; // 880 / 2 = 440
                camera.rect = new Rect(0, 0, NativeAspect / CurrentAspect, 1);
                camera.pixelRect = new Rect(blackBarSize, 0, SelectedResolution.height * NativeAspect, SelectedResolution.height);
            }
            else
            {
                camera.rect = new Rect(0, 0, 1, 1);
                camera.pixelRect = new Rect(0, 0, SelectedResolution.width, SelectedResolution.height);
            }
        }
    }
}
