namespace AnodeHeart;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.anodeheart.ultrawide";
    private const string PluginName = "Anode Heart Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    private const string Logo = "Logo";
    private const string Title = "Title";
    internal static ManualLogSource Log { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    private static float NativeAspect => 16f / 9f;
    internal static float MainAspect => (float) MainWidth / MainHeight;
    internal static float PositiveScaleFactor => MainAspect / NativeAspect;
    internal static float NegativeScaleFactor => NativeAspect / MainAspect;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<float> ConfigZoom { get; private set; }


    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        ConfigZoom = Config.Bind("02. Camera", "Zoom", 1.25f,
            new ConfigDescription("Zoom of the game. Adjust as necessary.",
                new AcceptableValueRange<float>(0.1f, 2f), new ConfigurationManagerAttributes {Order = 1}));

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        CorrectFixedUpdateRate = Config.Bind("04. Performance", "Correct Physics Update Rate", true,
            new ConfigDescription("Adjusts the physics update rate to minimum amount to reduce camera judder based on your refresh rate. Not all games like this setting being adjusted.", null, new ConfigurationManagerAttributes {Order = 106}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedRate();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("04. Performance", "Use Refresh Rate For Physics Update Rate", true,
            new ConfigDescription("Sets the physics update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 105}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedRate();
        };
        
        Application.focusChanged += FocusChanged;
        Application.runInBackground = RunInBackground.Value;
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += OnSceneLoaded;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }
    private static void UpdateFixedRate()
    {
        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / MaxRefresh;
                Log.LogInfo($"Physics update rate set to {MaxRefresh}Hz");
            }
            else
            {
                var denominator = FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
                Time.fixedDeltaTime = 1f / denominator;
                Log.LogInfo($"Physics update rate set to {denominator}Hz");
            }
        }
        else
        {
            Time.fixedDeltaTime = 0.02f; //Game default  
        }
        Log.LogInfo($"Current update rate: {1f / Time.fixedDeltaTime}");
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.name.Equals(Logo))
        {
            SceneManager.LoadScene(Title);
        }
        UpdateDisplay();
        UpdateFixedRate();
    }
}