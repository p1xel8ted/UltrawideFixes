using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.Injection;
using UnityEngine.Events;


namespace CrowCountry;

[Harmony]
[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BasePlugin
{
    internal static RefreshRate RefreshRateRatio => new()
    {
        denominator = 1,
        numerator = (uint)RefreshRate
    };

    internal static ConfigEntry<bool> PsxEffect { get; private set; }
    internal static ConfigEntry<bool> CrtEffect { get; private set; }
    internal static ConfigEntry<float> CrtEffectBrightness { get; private set; }
    internal static ConfigEntry<float> CrtEffectContrast { get; private set; }
    internal static ConfigEntry<float> CrtEffectSaturation { get; private set; }
    internal static ConfigEntry<bool> FlashbackEffect { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static float MainAspectRatio => (float)MainWidth / MainHeight;
    private static float NativeWidth => MainHeight * Const.NativeAspectRatio;
    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2f;
    internal static float PositiveScaleFactor => MainAspectRatio / Const.NativeAspectRatio;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<bool> PoisonOverlay { get; private set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }

    public static ConfigEntry<int> PixelationAmount { get; private set; }

    internal static ManualLogSource Logger { get; set; }

    private static string[] IntroSkipScenes { get; } = ["Logos", "Title", "5b080084b058b87468e9f07d1aef5b74"];
    private static string[] EndingSkipScenes { get; } = ["Results", "Ending Sequence", "8163db32a6ba9fa46bf7b9a1b510fd40"];


    private static WriteOnceFloat OriginalCameraFov { get; } = new();

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

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static ConfigEntry<string> Resolution { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    internal static ConfigEntry<int> TargetFramerate { get; set; }


    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    // private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

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

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = MainWidth,
            height = MainHeight,
            refreshRate = MaxRefresh
        };
        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private static ConfigEntry<string> VSyncSetting { get; set; }

    private static ConfigEntry<int> CustomRefreshRate { get; set; }

    public override void Load()
    {
        Logger = Log;
        
        foreach (var res in Screen.resolutions)
        {
            Plugin.Logger.LogWarning($"Resolution: {res.width}x{res.height} @ {res.refreshRate}Hz");
        }

        ClassInjector.RegisterTypeInIl2Cpp<FovAdjuster>();
        ClassInjector.RegisterTypeInIl2Cpp<LetterboxDisabler>();
        ClassInjector.RegisterTypeInIl2Cpp<ResultsScreen>();
        ClassInjector.RegisterTypeInIl2Cpp<ResultsScreenSecondary>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector3>();

        var customRates = MergeUnityRefreshRates();


        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => UpdateAll();

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
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll();

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll();

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll();

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll();

        FieldOfView = Config.Bind("02. Camera", "Field of View", 25, new ConfigDescription("Increase or decrease the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 100), new ConfigurationManagerAttributes { Order = 103 }));
        FieldOfView.SettingChanged += (_, _) =>
        {
            if (Patches.Patches.FovAdjusterEnabled()) return;
            UpdateCamera(SceneManager.GetActiveScene().path, 1f);
            ScalingCorrections.UpdatePoison();
        };

        PoisonOverlay = Config.Bind("03. Post-Processing", "Poison Overlay", true, new ConfigDescription("Enables the poison overlay in the game.", null, new ConfigurationManagerAttributes { Order = 102 }));
        PoisonOverlay.SettingChanged += (_, _) => { ScalingCorrections.UpdatePoison(); };

        PsxEffect = Config.Bind("03. Post-Processing", "PSX Effect", true, new ConfigDescription("Enables the PSX effect in the game.", null, new ConfigurationManagerAttributes { Order = 101 }));
        FlashbackEffect = Config.Bind("03. Post-Processing", "Flashback Effect", false, new ConfigDescription("Enables the flashback effect in the game.", null, new ConfigurationManagerAttributes { Order = 100 }));

        CrtEffect = Config.Bind("03. Post-Processing", "CRT Effect", false, new ConfigDescription("Enables the CRT effect in the game.", null, new ConfigurationManagerAttributes { Order = 99 }));

        CrtEffectBrightness = Config.Bind("03. Post-Processing", "CRT Effect Brightness", -0.5f, new ConfigDescription("Adjust the brightness of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = 98 }));
        CrtEffectBrightness.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CrtEffectBrightness.Value * 20f) / 20f;
            CrtEffectBrightness.Value = snappedValue;
            UpdateCrt();
        };

        CrtEffectContrast = Config.Bind("03. Post-Processing", "CRT Effect Contrast", 0.4f, new ConfigDescription("Adjust the contrast of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = 97 }));
        CrtEffectContrast.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CrtEffectContrast.Value * 20f) / 20f;
            CrtEffectContrast.Value = snappedValue;
            UpdateCrt();
        };

        CrtEffectSaturation = Config.Bind("03. Post-Processing", "CRT Effect Saturation", 0f, new ConfigDescription("Adjust the saturation of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes { Order = 96 }));
        CrtEffectSaturation.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CrtEffectSaturation.Value * 20f) / 20f;
            CrtEffectSaturation.Value = snappedValue;
            UpdateCrt();
        };

        PixelationAmount = Config.Bind("03. Post-Processing", "Pixelation Amount", 4, new ConfigDescription("Lessens the pixelation effect in the game. 0 is off, 4 is game default.", new AcceptableValueRange<int>(0, 4), new ConfigurationManagerAttributes { Order = 93 }));
        PixelationAmount.SettingChanged += (_, _) => { Renderer.PixelationAdjust(Instances.CrowCountryCamEffectInstance); };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 87 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 86 }));

        AddComponent<MonoBehaviours>();

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;

        UpdateAll();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        Log.LogInfo($"Plugin {Const.PluginName} is loaded!");
    }


    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    internal static void UpdateAll()
    {
        UpdateDisplay();
    }

    public class MonoBehaviours : MonoBehaviour
    {
        private void LateUpdate()
        {
            var scene = SceneManager.GetActiveScene().path;
            if (EndingSkipScenes.Contains(scene))
            {
                if (Camera.main)
                {
                    Camera.main.fieldOfView = GetDefaultCameraFov();
                }
            }
        }
    }


    private static void UpdateCrt()
    {
        Instances.CrowCountryCamEffectInstance.UpdateColorMatrices();
    }

    internal static void UpdateCamera(string scene, float duration)
    {
        if (!Camera.main) return;

        Plugin.Logger.LogWarning($"Updating camera for scene: {scene} - current FOV: {Camera.main.fieldOfView}");

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
        UpdateDisplay();
        UpdateCamera(a.name, 1f);
        ForceCameraChanges();

        CorrectLetterboxing();
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

    private static void UpdateDisplay()
    {
        var res = SelectedResolution;

        Screen.SetResolution(res.width, res.height, FullScreenModeConfig.Value, RefreshRate);

        Application.targetFrameRate = Mathf.RoundToInt(TargetFramerate.Value);

        var refreshRate = RefreshRate;

        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Logger.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;

        // Apply refresh rate and resolution

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, refreshRate);

        if (Application.targetFrameRate == -1)
        {
            Logger.LogInfo($"Display updated: VSync={QualitySettings.vSyncCount}, Target FPS=Unlimited, Refresh Rate={refreshRate}Hz");
        }
        else
        {
            Logger.LogInfo($"Display updated: VSync={QualitySettings.vSyncCount}, Target FPS={Application.targetFrameRate}, Refresh Rate={refreshRate}Hz");
        }
    }
}