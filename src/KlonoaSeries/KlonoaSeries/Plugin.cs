namespace KlonoaSeries;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.klonoaseries.ultrawide";
    private const string PluginName = "Klonoa Phantasy Reverie Series Ultra-Wide";
    private const string PluginVersion = "0.1.2";

    private const float NativeAspect = 16f / 9f;
    public static ConfigEntry<BEAUTIFY_PRESET> Preset;
    public static ConfigEntry<float> Sharpen;

    public static ConfigEntry<bool> Bloom;

    public static ConfigEntry<float> BloomIntensity;
    public static ConfigEntry<BEAUTIFY_QUALITY> Quality;

    public static ConfigEntry<BEAUTIFY_TMO> Tonemap;
    public static ConfigEntry<bool> LensDirt;
    public static ConfigEntry<float> LensDirtIntensity;

    public static ConfigEntry<float> Dither;
    public static ConfigEntry<float> DitherDepth;

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }

    internal static float ScaleFactor => MainAspect / NativeAspect;

    internal static float MainAspect => MainWidth / (float) MainHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource Log { get; private set; }
    private static WindowPositioner WindowPositioner { get; set; }

    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();

    internal static bool AtTitleMenu { get; set; }


    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        SceneManager.sceneUnloaded += SceneManagerOnSceneUnLoaded;

        DisplayToUse = Config.Bind("01. Display - Both", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        FullScreenModeConfig = Config.Bind("01. Display - Both", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 103}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        CorrectFixedUpdateRate = Config.Bind("05. Performance - Both", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.", null, new ConfigurationManagerAttributes {Order = 92}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("05. Performance - Both", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 91}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedDeltaTime();
        };

        RunInBackground = Config.Bind("06. Misc - Both", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 90}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc - Both", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));

        FieldOfView = Config.Bind("06. Misc - K1", "Field Of View", 25, new ConfigDescription("Increase (or decrease) field of view by a percentage. Default is 25%.", new AcceptableValueRange<int>(-99, 100), new ConfigurationManagerAttributes {ShowRangeAsPercent = true, Order = 88}));

        Preset = Config.Bind("07. Effects - K1", "Preset", BEAUTIFY_PRESET.Custom, new ConfigDescription("Preset configuration", null, new ConfigurationManagerAttributes {Order = 11}));
        Preset.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        Sharpen = Config.Bind("07. Effects - K1", "Sharpen", 0f, new ConfigDescription("Enable or disable sharpen effect", new AcceptableValueRange<float>(0f, 5f), new ConfigurationManagerAttributes {Order = 10}));
        Sharpen.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        Bloom = Config.Bind("07. Effects - K1", "Bloom", true, "Enable or disable bloom effect");
        Bloom.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        BloomIntensity = Config.Bind("07. Effects - K1", "BloomIntensity", 0.08f, new ConfigDescription("Intensity of the bloom effect", new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes {Order = 9}));
        BloomIntensity.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        Quality = Config.Bind("07. Effects - K1", "Quality", BEAUTIFY_QUALITY.BestQuality, new ConfigDescription("Quality setting", null, new ConfigurationManagerAttributes {Order = 8}));
        Quality.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };

        Tonemap = Config.Bind("07. Effects - K1", "Tonemap", BEAUTIFY_TMO.Linear, new ConfigDescription("Enable or disable tonemap effect", null, new ConfigurationManagerAttributes {Order = 7}));
        Tonemap.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        LensDirt = Config.Bind("07. Effects - K1", "LensDirt", true, new ConfigDescription("Enable or disable lens dirt effect", null, new ConfigurationManagerAttributes {Order = 6}));
        LensDirt.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        LensDirtIntensity = Config.Bind("07. Effects - K1", "LensDirtIntensity", 0.32f, new ConfigDescription("Intensity of lens dirt effect", new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes {Order = 5}));
        LensDirtIntensity.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        Dither = Config.Bind("07. Effects - K1", "Dither", 0f, new ConfigDescription("Enable or disable dithering", new AcceptableValueRange<float>(0f, 12f), new ConfigurationManagerAttributes {Order = 4}));
        Dither.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };
        DitherDepth = Config.Bind("07. Effects - K1", "DitherDepth", 0f, new ConfigDescription("Depth of dithering", new AcceptableValueRange<float>(0f, 12f), new ConfigurationManagerAttributes {Order = 3}));
        DitherDepth.SettingChanged += (_, _) =>
        {
            Patches.UpdateBeautify();
        };

        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
    private static void SceneManagerOnSceneUnLoaded(Scene a)
    {
        Log.LogInfo($"Scene unloaded: {a.name}");
        if (a.name.Equals("Title", StringComparison.OrdinalIgnoreCase))
        {
            AtTitleMenu = false;
        }
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
        Log.LogInfo($"Scene loaded: {a.name}");
        if (a.name.Equals("Title", StringComparison.OrdinalIgnoreCase))
        {
            AtTitleMenu = true;
        }
        UpdateDisplay();
        UpdateCameras();
        UpdateAspectFitters();
        UpdateK1Backgrounds();
        UpdateK2Backgrounds();
        UpdateFixedDeltaTime();
    }

    private static void UpdateAspectFitters()
    {
        var aspectFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
        foreach (var aspectFitter in aspectFitters)
        {
            aspectFitter.aspectRatio = MainAspect;
            aspectFitter.aspectMode = AspectRatioFitter.AspectMode.None;
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

    internal static void LogMessage(string message, Game game = Game.K1)
    {
        if (game is Game.K1)
        {
            Log.LogInfo($"(K1) {message}");
        }
        else
        {
            Log.LogInfo($"(K2) {message}");
        }
    }

    private static void UpdateK2Backgrounds()
    {
        var rawImages = Resources.FindObjectsOfTypeAll<RawImage>();
        foreach (var image in rawImages)
        {
            if (image.color == Color.black && Mathf.Approximately(image.rectTransform.sizeDelta.x, 1920))
            {
                LogMessage($"Updating raw background {image.name}", Game.K2);
                image.rectTransform.sizeDelta = new Vector2(MainWidth, MainHeight);
            }
        }
    }

    private static void UpdateK1Backgrounds()
    {
        var rawImages = Resources.FindObjectsOfTypeAll<RawImage>();
        foreach (var image in rawImages)
        {
            var path = image.gameObject.GetFullPath();
            if (path.Contains("Eula", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("sinai", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("universelib", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("unityexplorer", StringComparison.OrdinalIgnoreCase)) continue;

            if (image.name.Equals("Kurobeta", StringComparison.OrdinalIgnoreCase))
            {
                LogMessage($"Updating raw background {image.name} : {path}");
                var newX = image.transform.localScale.x * ScaleFactor;
                image.transform.localScale = image.transform.localScale with {x = newX};
            }
        }

        var images = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in images)
        {
            var path = image.gameObject.GetFullPath();
            if (path.Contains("Eula", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("sinai", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("universelib", StringComparison.OrdinalIgnoreCase)) continue;
            if (path.Contains("unityexplorer", StringComparison.OrdinalIgnoreCase)) continue;

            if (image.name.Equals("back") || image.name.Equals("Kurobeta"))
            {
                LogMessage($"Updating background {image.name} : {path}");
                var newX = image.transform.localScale.x * ScaleFactor;
                image.transform.localScale = image.transform.localScale with {x = newX};
            }

            if (image.color == Color.black && Mathf.Approximately(image.rectTransform.sizeDelta.x, 1920))
            {
                image.rectTransform.sizeDelta = new Vector2(MainWidth, MainHeight);
            }
            if (image.rectTransform.sizeDelta == new Vector2(1920, 72))
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

    internal enum Game
    {
       K1,
       K2
    }
}