namespace TheMessenger;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.themessenger.uwfixes";
    private const string PluginName = "The Messenger Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const float BaseAspectRatio = 16f / 9f;

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


    private static ManualLogSource Log { get; set; }

    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static float MainAspectRatio => Display.main.systemWidth / (float)Display.main.systemHeight;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    private static int MainWidth => Display.main.systemWidth;
    private static int MainHeight => Display.main.systemHeight;
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static int NativeWidth => Mathf.RoundToInt(MainHeight * BaseAspectRatio);

    private static ConfigEntry<bool> ExpandHUD { get; set; }
    private static bool IsGameplay { get; set; }
    private static string LastLoadedScene { get; set; }

    private void Awake()
    {
        var customRates = MergeUnityRefreshRates();
        Log = Logger;
        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong."));
        UseCustomRefreshRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", MaxRefresh, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates)));
        CustomRefreshRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate", new AcceptableValueList<int>(customRates)));
        TargetFramerate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Modify Physics Rate", false,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix, may not be applicable to this particular game. May even cause unintended behaviour."));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment."));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus."));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus."));

        ExpandHUD = Config.Bind("04. HUD", "Expand HUD", false, new ConfigDescription("Expands the HUD to fill the screen. This may cause issues with the game's UI."));
        ExpandHUD.SettingChanged += (_, _) => { UpdateCameras(); };
        
        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private void Update()
    {
        if (!Application.isFocused)
        {
            AudioListener.volume = MuteInBackground.Value ? 0 : 1;
        }
        else
        {
            AudioListener.volume = 1;
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

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Application.runInBackground = RunInBackground.Value;
        Application.targetFrameRate = TargetFramerate.Value;

        UpdateFixedDeltaTime();

        Log.LogInfo($"Scene loaded: {arg0.name}");
        LastLoadedScene = arg0.name;
        IsGameplay = LastLoadedScene is not ("Loader" or "Intro" or "Empty" or "");
        UpdateCameras();
    }

    internal static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
           
            //game play
            if (cam.name == "Main Camera")
            {
                cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
            }

            //hud
            if (cam.name == "Camera")
            {
                cam.aspect = MainAspectRatio;
                if (ExpandHUD.Value)
                {
                    cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
                }
                else
                {
                    cam.pixelRect = new Rect((MainWidth - NativeWidth) / 2f, 0, NativeWidth, MainHeight); 
                }
              
            }

            // blackbars/dialogue
            if (cam.name == "Camera(Clone)")
            {
                if (!IsGameplay)
                {
                    cam.aspect = BaseAspectRatio;
                    cam.pixelRect = new Rect((MainWidth - NativeWidth) / 2f, 0, NativeWidth, MainHeight);
                }
                else
                {
                    cam.aspect = MainAspectRatio * PositiveScaleFactor;
                    cam.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
                }
            }
        }
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0) return;

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh) return;

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
    }
}