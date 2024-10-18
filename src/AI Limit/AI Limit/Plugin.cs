namespace AI_Limit;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.ailimit.ultrawide";
    private const string PluginName = "AI Limit Ultra-Wide";
    private const string PluginVersion = "0.1.0";

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

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspect => MainWidth / (float)MainHeight; //2.388888888888889
    internal static float PositiveScaleFactor => MainAspect / NativeAspectRatio; //1.338888888888889
    internal static ManualLogSource Logger { get; set; }

    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth; //3440
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight; //1440
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> ExpandUI { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static float NativeAspectRatio => 16f / 9f; //1.777777777777778

    // internal static float BlackBarSize => (MainWidth - MainHeight * NativeAspectRatio) / 2f; //3440 - 2560 = 880 / 2 = 440
    public static float NegativeScaleFactor => NativeAspectRatio / MainAspect; //0.7454545454545455
    public static ConfigEntry<bool> ScaleMenuBackground { get; private set; }
    public static ConfigEntry<float> CameraFieldOfView { get; private set; }

    public static ConfigEntry<ViewScalingMode> ViewScalingModeConfig { get; private set; }

    // Player-friendly View Scaling Mode enum
    public enum ViewScalingMode
    {
        None = 0, // No gate fit mode applied
        Vertical = 1, // Fit to vertical bounds of the screen
        Horizontal = 2, // Fit to horizontal bounds of the screen
        Fill = 3, // Fill the screen, potentially cropping
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

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }


    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceString>();
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();

        Logger = Log;

        var customRates = MergeUnityRefreshRates();

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. The games controls are tied to this, so you may have to reduce mouse/controller sensitivity.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        ScaleMenuBackground = Config.Bind("03. UI", "Scale Menu Background", true, new ConfigDescription("Scales the menu background to fit the screen.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ScaleMenuBackground.SettingChanged += (_, _) => Patches.Patches.UpdateMovieBgController();

        ExpandUI = Config.Bind("03. UI", "Expand UI", true, new ConfigDescription("Expands the UI to fit the screen. You may have to restart the game for some menus.", null, new ConfigurationManagerAttributes { Order = 92 }));

        ViewScalingModeConfig = Config.Bind("03. UI", "View Scaling Mode", ViewScalingMode.Horizontal, new ConfigDescription("Set the view scaling mode.", null, new ConfigurationManagerAttributes { Order = 89 }));
        ViewScalingModeConfig.SettingChanged += (_, _) =>
        {
            UpdateCameraGateFit();
            Patches.Patches.UpdateCamera();
        };
        
        CameraFieldOfView = Config.Bind("04. Camera", "Field of View", 25f, new ConfigDescription("Adjust the camera's field of view by a percentage.", new AcceptableValueRange<float>(-99f, 200f), new ConfigurationManagerAttributes { Order = 90 }));
        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            CameraFieldOfView.Value = Mathf.Round(CameraFieldOfView.Value * 4f) / 4f;
            Patches.Patches.UpdateCamera();
        };
        
        RunInBackground = Config.Bind("05. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("05. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }


    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0)
        {
            Logger.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            Logger.LogInfo("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
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

        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateCameraGateFit()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            camera.gateFit = ViewScalingModeConfig.Value.ToGateFitMode();
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

        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);

        Application.targetFrameRate = TargetFramerate.Value;
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
        UpdateCameraGateFit();
        Patches.Patches.UpdateCamera();
    }
}