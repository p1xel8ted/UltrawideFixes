namespace KlonoaSeries;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.klonoaseries.ultrawide";
    private const string PluginName = "Klonoa Phantasy Reverie Series Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }

    internal static float MainAspect => MainWidth / (float) MainHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource Log { get; private set; }
    private static WindowPositioner WindowPositioner { get; set; }

    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 103}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        
        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        CorrectFixedUpdateRate = Config.Bind("05. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("05. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 91}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 90}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));

        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
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
        UpdateDisplay();
        UpdateCameras();
        UpdateAspectFitters();
        UpdateBackgrounds();
    }

    private static void UpdateAspectFitters()
    {
        var aspectFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
        foreach (var aspectFitter in aspectFitters)
        {
            aspectFitter.aspectRatio = MainAspect;
            aspectFitter.aspectMode = AspectRatioFitter.AspectMode.None;
            Log.LogWarning($"Updated aspect fitter {aspectFitter.name}");
        }
    }

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
            cam.aspect = MainWidth / (float) MainHeight;
            cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            cam.rect = new Rect(0, 0, 1, 1);
        }
    }


    private static void UpdateBackgrounds()
    {
        var images = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in images)
        {
            var path = image.gameObject.GetFullPath();
            if (path.Contains("Eula", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("sinai", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("universelib", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("unityexplorer", StringComparison.OrdinalIgnoreCase)) continue;
            if (image.color == Color.black && Mathf.Approximately(image.rectTransform.sizeDelta.x, 1920))
            {
                image.rectTransform.sizeDelta = new Vector2(MainWidth, MainHeight);
            }
            if(image.rectTransform.sizeDelta == new Vector2(1920, 72))
            {
                image.rectTransform.sizeDelta = new Vector2(MainWidth, 72);
            }
        }
    }


    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately(MaxRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > MaxRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
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
        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    internal static void UpdateDisplay()
    {
        // Check if WindowPositioner is not null and start it if necessary
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        // Set the application to run in the background based on the configuration value
        Application.runInBackground = RunInBackground.Value;

        // Check if the specified display index is within the range of available displays
        if (DisplayToUse.Value >= 0 && DisplayToUse.Value < Display.displays.Length)
        {
            // Activate the specified display
            Display.displays[DisplayToUse.Value].Activate();

            // Set the screen resolution based on the configuration
            Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        }
        else
        {
            Log.LogWarning($"Invalid display index: {DisplayToUse.Value}. Available displays: {Display.displays.Length}");
        }
    }
}