using System.Diagnostics;

namespace DrovaForsakenKin;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.drovaforsakenkin.ultrawide";
    private const string PluginName = "Drova Forsaken Kin Ultra-Wide";
    private const string PluginVersion = "0.1.1";

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

    private static float _previousFixedDeltaTime = -1f;
    private static int _previousTargetRefresh = -1;

    private static Transform Fog { get; set; }
    private static ActivateByPlatform Sp { get; set; }

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    internal static float MainAspect => MainWidth / (float)MainHeight; //2.388888888888889

    // internal static float PositiveScaleFactor => MainAspect / NativeAspectRatio; //1.338888888888889
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

    // internal static ConfigEntry<bool> ExpandUI { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static float NativeAspectRatio => 16f / 9f; //1.777777777777778

    public static float NegativeScaleFactor => NativeAspectRatio / MainAspect; //0.7454545454545455
    public static ConfigEntry<float> UIScale { get; private set; }
    public static ConfigEntry<bool> ConstrainMainMenu { get; private set; }
    private static ConfigEntry<bool> FogLayer { get; set; }
    private static ConfigEntry<bool> MainMenuSocials { get; set; }
    private static ConfigEntry<bool> FeedbackInfo { get; set; }

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
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix, may not be applicable to this particular game.", null, new ConfigurationManagerAttributes { Order = 94 }));
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

        ConstrainMainMenu = Config.Bind("03. UI", "Constrain Main Menu", true, new ConfigDescription("Keeps the main menu in the 16:9 view.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ConstrainMainMenu.SettingChanged += (_, _) => { UpdateMainMenu(); };

        UIScale = Config.Bind("03. UI", "UI Scale", 4f, new ConfigDescription("Set the UI scale.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes { Order = 92 }));
        UIScale.SettingChanged += (_, _) =>
        {
            UIScale.Value = Mathf.Round(UIScale.Value * 4f) / 4f;
            UpdateScalers();
        };

        MainMenuSocials = Config.Bind("03. UI", "Main Menu Socials", true, new ConfigDescription("Togle the socials from the main menu.", null, new ConfigurationManagerAttributes { Order = 84 }));
        MainMenuSocials.SettingChanged += (_, _) => { UpdateSocial(); };

        FeedbackInfo = Config.Bind("03. UI", "Feedback Info", true, new ConfigDescription("Togle the feedback info from the main menu.", null, new ConfigurationManagerAttributes { Order = 85 }));
        FeedbackInfo.SettingChanged += (_, _) => { UpdateFeedback(); };

        FogLayer = Config.Bind("04. Misc", "Remove Fog Layer", false, new ConfigDescription("Remove the lower fog layer sometimes present. Doesn't scale with ultra-wide well.", null, new ConfigurationManagerAttributes { Order = 83 }));
        FogLayer.SettingChanged += (_, _) => { UpdateFogLayer(); };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void UpdateFogLayer()
    {
        Fog ??= Utils.FindIl2CppType<Transform>().FirstOrDefault(a => a.name == "Floor Fog");
        if (Fog)
        {
            Fog.gameObject.SetActive(!FogLayer.Value);
        }
    }

    private static void UpdateSocial()
    {
        Sp ??= Utils.FindIl2CppType<ActivateByPlatform>().FirstOrDefault(a => a.name == "SocialPanel");
        if (Sp)
        {
            Sp.gameObject.SetActive(MainMenuSocials.Value);
        }
    }

    private static void UpdateFeedback()
    {
        var f1 = Utils.FindIl2CppType<GUI_UserReportBhvr>();
        foreach (var f in f1)
        {
            f.gameObject.SetActive(FeedbackInfo.Value);
        }

        var f2 = Utils.FindIl2CppType<TMP_GameVersionString>();
        foreach (var f in f2)
        {
            f.gameObject.SetActive(FeedbackInfo.Value);
        }
    }

    private static void UpdateMainMenu()
    {
        if (!Patches.Patches.MainMenuCamera) return;

        Patches.Patches.MainMenuCamera.cropFrame = ConstrainMainMenu.Value ? PixelPerfectCamera.CropFrame.Pillarbox : PixelPerfectCamera.CropFrame.None;
    }

    private static void UpdateScalers()
    {
        var gui = Utils.FindIl2CppType<GUI_HUD>().FirstOrDefault();
        if (!gui) return;

        var scalers = gui.GetComponentsInChildren<CanvasScaler>();
        foreach (var scaler in scalers)
        {
            scaler.scaleFactor = UIScale.Value;
        }
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
            Logger.LogInfo("Game's physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
            return;
        }

        if (Mathf.Approximately(Time.fixedDeltaTime, _previousFixedDeltaTime) && targetRefresh == _previousTargetRefresh) return;

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

        _previousFixedDeltaTime = Time.fixedDeltaTime;
        _previousTargetRefresh = targetRefresh;

        Logger.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
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
        if (mode == LoadSceneMode.Single)
        {
            UpdateMainMenu();
            UpdateScalers();
            UpdateDisplay();
            UpdateFixedDeltaTime();
            UpdateFogLayer();
            UpdateSocial();
            UpdateFeedback();
        }

        if (scene.name.Contains("floor", StringComparison.OrdinalIgnoreCase))
        {
            UpdateFogLayer();
        }
    }

    // private static void RunWithTimer(Action action, string message)
    // {
    //     var timer = new Stopwatch();
    //     timer.Start();
    //     action();
    //     timer.Stop();
    //     Logger.LogWarning($"{message} in {timer.ElapsedMilliseconds}ms");
    // }
}