using BepInEx.Unity.IL2CPP;
using CrowCountry.WindowsAPI;
using Il2CppInterop.Runtime.Injection;
using UnityEngine.Events;


namespace CrowCountry;

[Harmony]
[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BasePlugin
{
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }

    internal static RefreshRate RefreshRate => new()
    {
        denominator = 1,
        numerator = (uint) MaxRefresh
    };

    internal static ConfigEntry<bool> PsxEffect { get; private set; }
    internal static ConfigEntry<bool> CrtEffect { get; private set; }
    internal static ConfigEntry<float> CrtEffectBrightness { get; private set; }
    internal static ConfigEntry<float> CrtEffectContrast { get; private set; }
    internal static ConfigEntry<float> CrtEffectSaturation { get; private set; }
    internal static ConfigEntry<bool> FlashbackEffect { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => (int) Screen.resolutions.Max(a => a.refreshRateRatio.value);
    private static float MainAspectRatio => (float) MainWidth / MainHeight;
    private static float NativeWidth => MainHeight * Const.NativeAspectRatio;
    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2f;
    internal static float PositiveScaleFactor => MainAspectRatio / Const.NativeAspectRatio;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<bool> PoisonOverlay { get; private set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }

    internal static ConfigEntry<CanvasScaler.ScreenMatchMode> ScreenMatchMode { get; private set; }
    internal static ConfigEntry<CanvasScaler.ScaleMode> ScaleMode { get; private set; }
    internal static ConfigEntry<float> ScaleFactor { get; private set; }
    public static ConfigEntry<int> PixelationAmount { get; private set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource Logger { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static string[] IntroSkipScenes { get; } = ["Logos", "Title"];
    private static string[] EndingSkipScenes { get; } = ["Results", "Ending Sequence", "Driving Intro"];


    private static WriteOnceFloat OriginalCameraFov { get; } = new();

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<FovAdjuster>();
        ClassInjector.RegisterTypeInIl2Cpp<LetterboxDisabler>();
        ClassInjector.RegisterTypeInIl2Cpp<ResultsScreen>();
        ClassInjector.RegisterTypeInIl2Cpp<ResultsScreenSecondary>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector3>();
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();

       
        
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 105}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        FieldOfView = Config.Bind("02. Camera", "Field of View", 25, new ConfigDescription("Increase or decrease the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 100), new ConfigurationManagerAttributes {Order = 103}));
        FieldOfView.SettingChanged += (_, _) =>
        {
            if (Patches.Patches.FovAdjusterEnabled()) return;
            UpdateCamera(SceneManager.GetActiveScene().name, 1f);
            ScalingCorrections.UpdatePoison();
        };

        PoisonOverlay = Config.Bind("03. Post-Processing", "Poison Overlay", true, new ConfigDescription("Enables the poison overlay in the game.", null, new ConfigurationManagerAttributes {Order = 102}));
        PoisonOverlay.SettingChanged += (_, _) =>
        {
            ScalingCorrections.UpdatePoison();
        };

        PsxEffect = Config.Bind("03. Post-Processing", "PSX Effect", true, new ConfigDescription("Enables the PSX effect in the game.", null, new ConfigurationManagerAttributes {Order = 101}));
        FlashbackEffect = Config.Bind("03. Post-Processing", "Flashback Effect", false, new ConfigDescription("Enables the flashback effect in the game.", null, new ConfigurationManagerAttributes {Order = 100}));

        CrtEffect = Config.Bind("03. Post-Processing", "CRT Effect", false, new ConfigDescription("Enables the CRT effect in the game.", null, new ConfigurationManagerAttributes {Order = 99}));

        CrtEffectBrightness = Config.Bind("03. Post-Processing", "CRT Effect Brightness", -0.5f, new ConfigDescription("Adjust the brightness of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes {Order = 98}));
        CrtEffectBrightness.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CrtEffectBrightness.Value * 20f) / 20f;
            CrtEffectBrightness.Value = snappedValue;
            UpdateCrt();
        };

        CrtEffectContrast = Config.Bind("03. Post-Processing", "CRT Effect Contrast", 0.4f, new ConfigDescription("Adjust the contrast of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes {Order = 97}));
        CrtEffectContrast.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CrtEffectContrast.Value * 20f) / 20f;
            CrtEffectContrast.Value = snappedValue;
            UpdateCrt();
        };

        CrtEffectSaturation = Config.Bind("03. Post-Processing", "CRT Effect Saturation", 0f, new ConfigDescription("Adjust the saturation of the CRT effect in the game.", new AcceptableValueRange<float>(-1f, 1f), new ConfigurationManagerAttributes {Order = 96}));
        CrtEffectSaturation.SettingChanged += (_, _) =>
        {
            var snappedValue = Mathf.Round(CrtEffectSaturation.Value * 20f) / 20f;
            CrtEffectSaturation.Value = snappedValue;
            UpdateCrt();
        };

        PixelationAmount = Config.Bind("03. Post-Processing", "Pixelation Amount", 4, new ConfigDescription("Lessens the pixelation effect in the game. 0 is off, 4 is game default.", new AcceptableValueRange<int>(0, 4), new ConfigurationManagerAttributes {Order = 93}));
        PixelationAmount.SettingChanged += (_, _) =>
        {
            Renderer.PixelationAdjust(Instances.CrowCountryCamEffectInstance);
        };

        CorrectFixedUpdateRate = Config.Bind("04. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.", null, new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 91}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        ScaleMode = Config.Bind("05. Scalers", "Canvas Scaler Scale Mode", CanvasScaler.ScaleMode.ScaleWithScreenSize, new ConfigDescription("The scaling mode to use for the CanvasScaler component.", null, new ConfigurationManagerAttributes {Order = 90}));
        ScreenMatchMode = Config.Bind("05. Scalers", "Canvas Scaler Screen Match Mode", CanvasScaler.ScreenMatchMode.Expand, new ConfigDescription("The screen match mode to use for the CanvasScaler component. Has no effect unless Scale Mode is set to ScaleWithScreenSize.", null, new ConfigurationManagerAttributes {Order = 89}));
        ScaleFactor = Config.Bind("05. Scalers", "Canvas Scaler Scale Factor", 1f, new ConfigDescription("The scaling factor to use for the CanvasScaler component. Has no effect when Scale Mode is set to ScaleWithScreenSize.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 88}));
        ScaleFactor.SettingChanged += (_, _) =>
        {
            ScaleFactor.Value = Mathf.Round(ScaleFactor.Value * 4) / 4;
        };

        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 87}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 86}));
        
        AddComponent<MonoBehaviours>();
        
        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;
        
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

    
    public class MonoBehaviours : MonoBehaviour
    {
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
    }
    


    private static void UpdateCrt()
    {
        Instances.CrowCountryCamEffectInstance.UpdateColorMatrices();
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / MaxRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }
        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

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
        Plugin.Logger.LogWarning($"Scene loaded: {a.name}");
        // if (a.name.Equals("Logos"))
        // {
        //     SceneManager.LoadScene("Title");
        // }

        UpdateDisplay();
        UpdateFixedDeltaTime();
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
            camera.aspect = MainWidth / (float) MainHeight;
        }
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }
        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, RefreshRate);
        Application.targetFrameRate = MaxRefresh;
    }
}