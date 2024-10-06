namespace TheyAlwaysRun;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.theyalwaysrun.ultrawide";
    private const string PluginName = "They Always Run Ultra-Wide";
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

    internal static ManualLogSource Log { get; private set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    internal static float NativeAspectRatio => 16f / 9f; // 1.77777777778
    private static float CameraWidth => MainHeight * NativeAspectRatio; // 1440 * 16/9 = 2560
    internal static float BlackBarSize => (MainWidth - CameraWidth) / 2f; // (3440 - 2560) / 2 = 440
    internal static float MainAspectRatio => MainWidth / (float)MainHeight; // 3440 / 1440 = 2.38889
    internal static ConfigEntry<bool> RestrictHUD { get; private set; }
    internal static float PositiveScaleFactor => MainAspectRatio / NativeAspectRatio;

    private void Awake()
    {
        SplashController.Shown = true;
        
        var customRates = MergeUnityRefreshRates();
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
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

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        RestrictHUD = Config.Bind("03. UI", "Restrict HUD", false, new ConfigDescription("Restrict the HUD to 16:9.", null, new ConfigurationManagerAttributes { Order = 84 }));
        RestrictHUD.SettingChanged += (_, _) => { Utils.UpdateHUD(); };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 83 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        Application.runInBackground = RunInBackground.Value;

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", true, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));

        SceneManager.sceneLoaded += OnSceneLoaded;
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

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }


    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Log.LogInfo($"Scene loaded: {arg0.name}");
        UpdateDisplay();
        Utils.UpdateHUD();
        UpdateFixedDeltaTime();
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

        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);

        Application.targetFrameRate = TargetFramerate.Value;
    }
}