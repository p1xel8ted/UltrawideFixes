namespace CatQuest1;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.catquest1.ultrawide";
    private const string PluginName = "Cat Quest Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private readonly static int[] CustomRefreshRates =
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

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> UseCustomRefreshRate { get; private set; }
    internal static ConfigEntry<int> CustomRefreshRate { get; private set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource Log { get; private set; }
    private static WindowPositioner WindowPositioner { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();

    private readonly static int[] RefreshRates = MergeUnityRefreshRates();
    internal readonly static int MaxRefreshRate = GetMaxRefreshRate();
    private static ConfigEntry<bool> CorrectMenuBackground { get; set; }

    public static ConfigEntry<bool> GoStraightToTitle { get; set; }

    private static int GetMaxRefreshRate()
    {
        var maxRefreshRate = int.MinValue;

        foreach (var resolution in Screen.resolutions)
        {
            if (resolution.refreshRate > maxRefreshRate)
            {
                maxRefreshRate = resolution.refreshRate;
            }
        }

        return maxRefreshRate;
    }

    private void Awake()
    {
        Debug.unityLogger.logEnabled = true;

        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(GetDisplays())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, "Set the full screen mode");
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        UseCustomRefreshRate = Config.Bind("02. Refresh Rate", "Custom Refresh Rate", false, "Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.");
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        CustomRefreshRate = Config.Bind("02. Refresh Rate", "Custom Refresh Rate Value", MaxRefreshRate, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(RefreshRates)));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        TargetFramerate = Config.Bind("02. Refresh Rate", "Target Framerate", MaxRefreshRate, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(RefreshRates)));
        TargetFramerate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        CorrectFixedUpdateRate = Config.Bind("03. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all."));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("03. Performance", "Use Refresh Rate For Physics Rate", true, "Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.");
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
            UpdateFixedDeltaTime();
        };


        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, "Allows the game to run even when not in focus.");
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, "Mutes the game's audio when it is not in focus.");
        CorrectMenuBackground = Config.Bind("04. Misc", "Correct Menu Background", true, "(Attempts) to correct the menu background to fit.");
        CorrectMenuBackground.SettingChanged += (_, _) =>
        {
             UpdateMainMenu();
        };
        GoStraightToTitle = Config.Bind("04. Misc", "Go Straight To Title", false, "Skip the splash & prologue and go straight to the title screen.");

        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static int[] GetDisplays()
    {
        var displays = new int[Display.displays.Length];
        for (var i = 0; i < Display.displays.Length; i++)
        {
            displays[i] = i;
        }

        return displays;
    }

    private static int[] MergeUnityRefreshRates()
    {
        // Step 1: Extract refresh rates from Screen.resolutions without using LINQ.
        var unityRates = new List<int>();
        foreach (var resolution in Screen.resolutions)
        {
            if (!unityRates.Contains(resolution.refreshRate))
            {
                unityRates.Add(resolution.refreshRate);
            }
        }

        // Step 2: Combine unityRates with CustomRefreshRates.
        var customRates = new List<int>();
        foreach (var rate in unityRates)
        {
            customRates.Add(rate);
        }
        foreach (var rate in CustomRefreshRates)
        {
            if (!customRates.Contains(rate))
            {
                customRates.Add(rate);
            }
        }

        // Step 3: Sort the combined list.
        customRates.Sort();

        // Step 4: Convert the list to an array.
        return customRates.ToArray();
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
        UpdateFixedDeltaTime();
        UpdateMainMenu();
    }
    
    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefreshRate;
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


        if (UseRefreshRateForFixedUpdateRate.Value)
        {
            Time.fixedDeltaTime = 1f / targetRefresh;
        }
        else
        {
            Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
        }


        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }


    private static WriteOnce<Vector2> OriginalMenuSize { get; } = new();

    private static void UpdateMainMenu()
    {
        var bg = GameObject.Find("Scene/Canvas(MatchHeight)/BG");
        if (bg)
        {
            var rect = bg.GetComponent<RectTransform>();
            var currentSize = rect.sizeDelta;
            OriginalMenuSize.Value = currentSize;
            var newWidth = OriginalMenuSize.Value.x * 1.1035f;
            const float newHeight = 110.35f;

            rect.sizeDelta = CorrectMenuBackground.Value ? new Vector2(newWidth, newHeight) : OriginalMenuSize.Value;
        }
    }


    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = true;

        Display.displays[DisplayToUse.Value].Activate();

        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefreshRate);

        Application.targetFrameRate = TargetFramerate.Value;
    }
}