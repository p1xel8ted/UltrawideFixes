

namespace Farlands;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.farlands.ultrawide";
    private const string PluginName = "Farlands Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    private const string LogoScene = "JanduSoftLogoScene";
    private const string MainMenu = "MainMenu";

    internal const float NativeAspectRatio = 16f / 9f;

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

    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    
    internal static float MainAspectRatio => MainWidth / (float) MainHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CameraZoom { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<CanvasScaler.ScreenMatchMode> ScreenMatchMode { get; private set; }
    internal static ConfigEntry<CanvasScaler.ScaleMode> ScaleMode { get; private set; }
    internal static ConfigEntry<float> ScaleFactor { get; private set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource Log { get; private set; }
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static ConfigEntry<float> BaseCanvasScalerScaleFactor { get; set; }
    private static ConfigEntry<bool> UseCustomBaseScale { get; set; }
    private static ConfigEntry<float> DialogueCanvasScalerScaleFactor { get; set; }
    private static ConfigEntry<bool> UseCustomDialogueScale { get; set; }
    internal static ConfigEntry<bool> ExpandHUD { get; private set; }

    internal static ConfigEntry<int> PickupRangeMultiplier { get; private set; }
    internal static ConfigEntry<int> PickupSpeedMultiplier { get; private set; }
    public static ConfigEntry<int> MoveSpeedMultiplier { get; private set; }
    public static ConfigEntry<int> EnergyReductionMultiplier { get; private set; }
    private void Awake()
    {
        Debug.unityLogger.logEnabled = false;
        
        var customRates = MergeUnityRefreshRates();

        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 103}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes {Order = 102}));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes {Order = 101}));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes {Order = 100}));
        TargetFramerate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        ScaleMode = Config.Bind("04. Global Scaling", "Canvas Scaler Scale Mode", CanvasScaler.ScaleMode.ScaleWithScreenSize, new ConfigDescription("The scaling mode to use for the CanvasScaler component.", null, new ConfigurationManagerAttributes {Order = 99}));
        ScaleMode.SettingChanged += (_, _) =>
        {
            UpdateScalers();
        };

        ScreenMatchMode = Config.Bind("04. Global Scaling", "Canvas Scaler Screen Match Mode", CanvasScaler.ScreenMatchMode.Expand, new ConfigDescription("The screen match mode to use for the CanvasScaler component. Has no effect unless Scale Mode is set to ScaleWithScreenSize.", null, new ConfigurationManagerAttributes {Order = 98}));
        ScreenMatchMode.SettingChanged += (_, _) =>
        {
            UpdateScalers();
        };

        ScaleFactor = Config.Bind("04. Global Scaling", "Canvas Scaler Scale Factor", 3f, new ConfigDescription("The scaling factor to use for the CanvasScaler component. Has no effect when Scale Mode is set to ScaleWithScreenSize.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 97}));
        ScaleFactor.SettingChanged += (_, _) =>
        {
            ScaleFactor.Value = Mathf.Round(ScaleFactor.Value * 4) / 4;
            UpdateScalers();
        };

        CorrectFixedUpdateRate = Config.Bind("05. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("05. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 91}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 90}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));

        ExpandHUD = Config.Bind("07. HUD", "Expand HUD", true, new ConfigDescription("Expands the HUD to fill the screen.", null, new ConfigurationManagerAttributes {Order = 88}));
        ExpandHUD.SettingChanged += (_, _) =>
        {
            UpdateAspectFitters();
        };

        UseCustomBaseScale = Config.Bind("07. HUD", "Use Custom HUD Scale", true, new ConfigDescription("Use a custom scale for the HUD/Toolbar.", null, new ConfigurationManagerAttributes {Order = 87}));
        UseCustomBaseScale.SettingChanged += (_, _) =>
        {
            UpdateExtraCanvasScalers();
        };
        BaseCanvasScalerScaleFactor = Config.Bind("07. HUD", "HUD Scale", 3f, new ConfigDescription("The scale of the HUD/Toolbar - overwrites the global scaling setting.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 86}));
        BaseCanvasScalerScaleFactor.SettingChanged += (_, _) =>
        {
            BaseCanvasScalerScaleFactor.Value = Mathf.Round(BaseCanvasScalerScaleFactor.Value * 4) / 4;
            UpdateExtraCanvasScalers();
        };

        UseCustomDialogueScale = Config.Bind("08. Dialogue", "Use Custom Dialogue Scale", true, new ConfigDescription("Use a custom scale for the talking dialogue.", null, new ConfigurationManagerAttributes {Order = 85}));
        UseCustomDialogueScale.SettingChanged += (_, _) =>
        {
            UpdateExtraCanvasScalers();
        };
        DialogueCanvasScalerScaleFactor = Config.Bind("08. Dialogue", "Dialogue Scale", 2f, new ConfigDescription("The scale of the talking dialogue - overwrites the global scaling setting.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes {Order = 84}));
        DialogueCanvasScalerScaleFactor.SettingChanged += (_, _) =>
        {
            DialogueCanvasScalerScaleFactor.Value = Mathf.Round(DialogueCanvasScalerScaleFactor.Value * 4) / 4;
            UpdateExtraCanvasScalers();
        };

        CameraZoom = Config.Bind("09. Camera", "Camera Zoom", 25, new ConfigDescription("The camera zoom level increase in percent. This will break mouse position when using tools. Best used with controller.", new AcceptableValueRange<int>(0, 100), new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 83}));
        CameraZoom.SettingChanged += (_, _) =>
        {
            UpdateAllCameras();
        };

        PickupRangeMultiplier = Config.Bind("10. Gameplay", "Item Pickup Range Multiplier", 25, new ConfigDescription("Increase the pickup range of items. Default is 25% further.", new AcceptableValueRange<int>(0, 100), new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 82}));
        PickupRangeMultiplier.SettingChanged += (_, _) =>
        {
            UpdateItems();
        };
        PickupSpeedMultiplier = Config.Bind("10. Gameplay", "Item Pickup Speed Multiplier", 25, new ConfigDescription("Increase the pickup speed of items. Default is 25% faster.", new AcceptableValueRange<int>(0, 100), new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 81}));
        PickupSpeedMultiplier.SettingChanged += (_, _) =>
        {
            UpdateItems();
        };
        
        MoveSpeedMultiplier = Config.Bind("10. Gameplay", "Move Speed Multiplier", 25, new ConfigDescription("Increase the player move speed by a percentage. Default is 25% faster.", new AcceptableValueRange<int>(0, 100), new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 80}));
       
        EnergyReductionMultiplier = Config.Bind("10. Gameplay", "Energy Reduction Multiplier", 25, new ConfigDescription("Reduce the energy cost of actions by a percentage. Default is 25% less.", new AcceptableValueRange<int>(0, 75), new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 79}));
        
        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static void UpdateItems()
    {
        var resources = Resources.FindObjectsOfTypeAll<WorldItem>();
        foreach (var resource in resources)
        {
            resource.detectionRange = Patches.GetPickupRange(50f);
            resource.pickupRange = Patches.GetPickupRange(15f);
            resource.moveSpeed = Patches.GetPickupSpeed(200f);
        }
    }

    internal static void UpdateCamera(CinemachineVirtualCamera cam, float value)
    {
        var pctIncrease = CameraZoom.Value / 100f;
        cam.m_Lens.OrthographicSize = value * (1 + pctIncrease);
    }

    private static void UpdateAllCameras()
    {
        foreach (var cam in Patches.CameraOrthographicSize)
        {
            UpdateCamera(cam.Key, cam.Value);
        }
    }

    private static void UpdateAspectFitters()
    {
        var aspectFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
        foreach (var aspectFitter in aspectFitters)
        {
            aspectFitter.OnEnable(); //will re-trigger the postfix
        }
    }

    internal static void UpdateExtraCanvasScalers()
    {
        if (Patches.BaseCanvasCanvasScaler)
        {
            if (UseCustomBaseScale.Value)
            {
                Patches.BaseCanvasCanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
                Patches.BaseCanvasCanvasScaler.scaleFactor = BaseCanvasScalerScaleFactor.Value;
            }
            else
            {
                Patches.BaseCanvasCanvasScaler.uiScaleMode = ScaleMode.Value;
                Patches.BaseCanvasCanvasScaler.screenMatchMode = ScreenMatchMode.Value;
                Patches.BaseCanvasCanvasScaler.scaleFactor = ScaleFactor.Value;
            }
        }

        if (Patches.DialogScaler)
        {
            if (UseCustomDialogueScale.Value)
            {
                Patches.DialogScaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
                Patches.DialogScaler.scaleFactor = DialogueCanvasScalerScaleFactor.Value;
            }
            else
            {
                Patches.DialogScaler.uiScaleMode = ScaleMode.Value;
                Patches.DialogScaler.screenMatchMode = ScreenMatchMode.Value;
                Patches.DialogScaler.scaleFactor = ScaleFactor.Value;
            }
        }
    }

    private static void UpdateScalers()
    {
        var scalers = Resources.FindObjectsOfTypeAll<CanvasScaler>();
        foreach (var scaler in scalers)
        {
            if (scaler.name.Contains("sinai")) return;
            scaler.uiScaleMode = ScaleMode.Value;
            scaler.screenMatchMode = ScreenMatchMode.Value;
            scaler.scaleFactor = ScaleFactor.Value;
        }

        UpdateExtraCanvasScalers();
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

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        if (a.name.Equals(LogoScene))
        {
            SceneManager.LoadScene(MainMenu);
        }
        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateScalers();
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0)
        {
            Log.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }
        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / targetRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;

        Display.displays[DisplayToUse.Value].Activate();

        if (UseCustomRefreshRate.Value)
        {
            Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, CustomRefreshRate.Value);
            Application.targetFrameRate = TargetFramerate.Value;
        }
        else
        {
            Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
            Application.targetFrameRate = TargetFramerate.Value;
        }
    }
}