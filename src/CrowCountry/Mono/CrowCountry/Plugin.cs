using CrowCountry.Generics;

namespace CrowCountry;

[Harmony]
[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private static readonly int[] CustomRefreshRates =
    [
        30, // Uncommon
        50, // Uncommon
        60, // Common
        72, // Uncommon
        75, // Common
        90, // Uncommon
        100, // Uncommon
        120, // Common
        144, // Common
        165, // Common
        180, // Common
        200, // Uncommon
        240, // Common
        300, // Uncommon
        360, // Uncommon
        480 // Uncommon
    ];

    internal const float NativeAspectRatio = 16.0f / 9.0f;

    internal static float MainAspectRatio => MainWidth / (float)MainHeight;
    internal static ManualLogSource Log { get; set; }
    internal static float PositiveScaleFactor => MainAspectRatio / NativeAspectRatio;
    private static int MaxRefresh => (int)Screen.resolutions.Max(a => a.refreshRateRatio.value);

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

    internal static RefreshRate RefreshRateNew = new()
    {
        denominator = 1,
        numerator = (uint)RefreshRate
    };

    private static ConfigEntry<int> CustomRefreshRate { get; set; }

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => SelectedResolution.width;
    internal static int MainHeight => SelectedResolution.height;
    
    private static readonly int NativeDisplayWidth = Display.main.systemWidth;
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }

    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static ConfigEntry<string> Resolution { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }

    // private static ConfigEntry<bool> SixteenTenTesting { get; set; }
    // private static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    // private static ConfigEntry<bool> FourtyEightNineTesting { get; set; }

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static Resolution SelectedResolution
    {
        get
        {
            // if (SixteenTenTesting.Value)
            // {
            //     const int height = 1200;
            //     var width = Mathf.RoundToInt(height * 1.6f); // 1200 * 1.6f = 1920
            //     return new Resolution { width = width, height = height };
            // }
            //
            // if (ThirtyTwoNineTesting.Value)
            // {
            //     const int height = 900;
            //     var width = Mathf.RoundToInt(height * 3.555555555555556f); // 900 * 3.555555555555556f = 3200
            //     return new Resolution { width = width, height = height };
            // }
            //
            // if (FourtyEightNineTesting.Value)
            // {
            //     const int height = 600;
            //     var width = Mathf.RoundToInt(height * 5.333333333333333f); // 600 * 5.333333333333333f = 3200
            //     return new Resolution { width = width, height = height };
            // }

            if (Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

   // private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
   // private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }

    // internal static RefreshRate RefreshRate => new()
    // {
    //     denominator = 1,
    //     numerator = (uint) MaxRefresh
    // };

    internal static ConfigEntry<bool> PSXEffect { get; private set; }
    internal static ConfigEntry<bool> CRTEffect { get; private set; }
    internal static ConfigEntry<float> CRTEffectBrightness { get; private set; }
    internal static ConfigEntry<float> CRTEffectContrast { get; private set; }
    internal static ConfigEntry<float> CRTEffectSaturation { get; private set; }

    internal static ConfigEntry<bool> FlashbackEffect { get; private set; }

    //internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    // internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    // internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    // private static int MaxRefresh => (int) Screen.resolutions.Max(a => a.refreshRateRatio.value);
    // private static float MainAspectRatio => (float) MainWidth / MainHeight;
    private static float NativeWidth => MainHeight * Const.NativeAspectRatio;

    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2f;

    //  internal static float PositiveScaleFactor => MainAspectRatio / Const.NativeAspectRatio;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<bool> PoisonOverlay { get; private set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    
    public static ConfigEntry<int> PixelationAmount { get; private set; }

   // private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static string[] IntroSkipScenes { get; } = ["Logos", "Title"];
    private static string[] EndingSkipScenes { get; } = ["Results", "Ending Sequence", "Driving Intro"];

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = NativeDisplayWidth,
            height = NativeDisplayHeight,
            refreshRateRatio = RefreshRateNew
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => (int)a.refreshRateRatio.value).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static void UpdateCanvasScalers()
    {
        var scalers = Patches.Patches.Scalers;
        foreach (var scaler in scalers)
        {
            Patches.Patches.ProcessScaler(scaler);
        }
    }


    private static WriteOnce<float> OriginalCameraFov { get; } = new();

    private void Awake()
    {
        Log = Logger;
        var customRates = MergeUnityRefreshRates();

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>
        {
            UpdateAll(true);
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll(true);
        
        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll(true);
        
        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();
        
        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);
        
        FieldOfView = Config.Bind("02. Camera", "Field of View", 0, new ConfigDescription("Increase or decrease the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 100), new ConfigurationManagerAttributes { Order = 103 }));
        FieldOfView.SettingChanged += (_, _) =>
        {
            if (Patches.Patches.FovAdjusterEnabled()) return;
            UpdateCamera(SceneManager.GetActiveScene().name, 1f);
            ScalingCorrections.UpdatePoison();
        };

        PoisonOverlay = Config.Bind("03. Post-Processing", "Poison Overlay", true, new ConfigDescription("Enables the poison overlay in the game.", null, new ConfigurationManagerAttributes { Order = 102 }));
        PoisonOverlay.SettingChanged += (_, _) => { ScalingCorrections.UpdatePoison(); };

        PSXEffect = Config.Bind("03. Post-Processing", "PSX Effect", true, new ConfigDescription("Enables the PSX effect in the game.", null, new ConfigurationManagerAttributes { Order = 101 }));
        FlashbackEffect = Config.Bind("03. Post-Processing", "Flashback Effect", false, new ConfigDescription("Enables the flashback effect in the game.", null, new ConfigurationManagerAttributes { Order = 100 }));

        CRTEffect = Config.Bind("03. Post-Processing", "CRT Effect", false, new ConfigDescription("Enables the CRT effect in the game.", null, new ConfigurationManagerAttributes { Order = 99 }));

        CRTEffectBrightness = Config.Bind("03. Post-Processing", "CRT Effect Brightness", -0.5f, new ConfigDescription("Adjust the brightness of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = 98 }));
        CRTEffectBrightness.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CRTEffectBrightness.Value * 20f) / 20f;
            CRTEffectBrightness.Value = snappedValue;
            UpdateCrt();
        };

        CRTEffectContrast = Config.Bind("03. Post-Processing", "CRT Effect Contrast", 0.4f, new ConfigDescription("Adjust the contrast of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = 97 }));
        CRTEffectContrast.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CRTEffectContrast.Value * 20f) / 20f;
            CRTEffectContrast.Value = snappedValue;
            UpdateCrt();
        };

        CRTEffectSaturation = Config.Bind("03. Post-Processing", "CRT Effect Saturation", 0f, new ConfigDescription("Adjust the saturation of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = 96 }));
        CRTEffectSaturation.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CRTEffectSaturation.Value * 20f) / 20f;
            CRTEffectSaturation.Value = snappedValue;
            UpdateCrt();
        };

        PixelationAmount = Config.Bind("03. Post-Processing", "Pixelation Amount", 4, new ConfigDescription("Lessens the pixelation effect in the game. 0 is off, 4 is game default.", new AcceptableValueRange<int>(0, 4), new ConfigurationManagerAttributes { Order = 93 }));
        PixelationAmount.SettingChanged += (_, _) => { Renderer.PixelationAdjust(Instances.CrowCountryCamEffectInstance); };

        // CorrectFixedUpdateRate = Config.Bind("04. Performance", "Modify Physics Rate", false,
        //     new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.", null, new ConfigurationManagerAttributes { Order = 92 }));
        // CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };
        //
        // UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Rate", false,
        //     new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 91 }));
        // UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 87 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 86 }));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        Log.LogInfo($"Plugin {Const.PluginName} is loaded!");
    }
    
    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
    }

    private void LateUpdate()
    {
        var scene = SceneManager.GetActiveScene().name;
        if (EndingSkipScenes.Contains(scene))
        {
            if (Camera.main)
            {
                Camera.main.fieldOfView = GetDefaultCameraFov();
            }
        }
    }

    private static void UpdateCrt()
    {
        Instances.CrowCountryCamEffectInstance.UpdateColorMatrices();
    }

    // private static void UpdateFixedDeltaTime()
    // {
    //     OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
    //     if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
    //     {
    //         Log.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
    //         return;
    //     }
    //
    //     if (CorrectFixedUpdateRate.Value)
    //     {
    //         if (UseRefreshRateForFixedUpdateRate.Value)
    //         {
    //             Time.fixedDeltaTime = 1f / MaxRefresh;
    //         }
    //         else
    //         {
    //             Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
    //         }
    //     }
    //     else
    //     {
    //         Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
    //     }
    //
    //     Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    // }

    internal static void UpdateCamera(string scene, float duration)
    {
        if (!Camera.main) return;
        if (IntroSkipScenes.Contains(scene))
        {
            Camera.main.fieldOfView = 4.6f;
            return;
        }

        if (EndingSkipScenes.Contains(scene))
        {
            Camera.main.fieldOfView = 10.1f;
            return;
        }

        OriginalCameraFov.Value = Camera.main.fieldOfView;
        var baseFov = GetDefaultCameraFov();
        var pct = FieldOfView.Value / 100f;
        Camera.main.DOFieldOfView(baseFov + baseFov * pct, duration).SetEase(Ease.InOutQuad);
    }

    internal static float GetDefaultCameraFov()
    {
        return OriginalCameraFov.HasValue ? OriginalCameraFov.Value : 10.1f;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        if (a.name.Equals("Logos"))
        {
            SceneManager.LoadScene("Title");
        }

        UpdateDisplay();
       // UpdateFixedDeltaTime();
        UpdateCamera(a.name, 1f);
        ForceCameraChanges();
        CorrectLetterboxing();
        UpdateCanvasScalers();

        ScalingCorrections.UpdatePoison();
        ScalingCorrections.CorrectCreditsSky();
        ScalingCorrections.CorrectMapBackground();
        ScalingCorrections.CorrectDrivingIntroRoad();
    }

    private static void CorrectLetterboxing()
    {
        var letterboxTransforms = Resources.FindObjectsOfTypeAll<Transform>().Where(t => t.name.Equals("letterbox", StringComparison.InvariantCultureIgnoreCase)).ToList();
        foreach (var lb in letterboxTransforms)
        {
            lb.gameObject.TryAddComponent<LetterboxDisabler>();
        }
    }


    private static void ForceCameraChanges()
    {
        foreach (var camera in Camera.allCameras)
        {
            camera.rect = new Rect(0, 0, MainWidth, MainHeight);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            camera.aspect = MainWidth / (float)MainHeight;
        }
    }

    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Log.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;


        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRateNew);
        Log.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        RequiresUpdate = false;
    }

    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    private static bool RequiresUpdate { get; set; }
}