namespace GIJoeWrathOfCobra;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.gijoewrathofcobra.ultrawide";
    private const string PluginName = "GI Joe: Wrath of Cobra Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static readonly int MainHeight = Display._mainDisplay.systemHeight;

    private static readonly int NativeWidth = Mathf.RoundToInt(MainHeight * NativeAspect);
    internal static readonly float WidthDifference = MainWidth - NativeWidth;
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display._mainDisplay.systemWidth;
    private static float MainDisplayAspectRatio => Display._mainDisplay.systemWidth / (float)Display._mainDisplay.systemHeight;
    private const float NativeAspectRatio = 16f / 9f;
    internal static float PositiveScaleFactor => MainDisplayAspectRatio / NativeAspectRatio;
    internal static float NegativeScaleFactor => NativeAspectRatio / MainDisplayAspectRatio;
    private static float NativeAspect => 16f / 9f;
    internal static ConfigEntry<bool> TransparentHUD { get; private set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> SkipIntroCinematic { get; private set; }
    internal static ConfigEntry<bool> MenuMetalDoors { get; private set; }
    internal static ConfigEntry<bool> ScaleMenuBackgrounds { get; private set; }
    internal static ManualLogSource Log { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription("Set the full screen mode", null,
                new ConfigurationManagerAttributes { Order = 103 }));
        FullScreenModeConfig.SettingChanged += (_, _) => { UpdateDisplay(); };


        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        MenuMetalDoors = Config.Bind("02. Menu", "Metal Doors", false, new ConfigDescription("Disables the metal doors in the main menu.", null, new ConfigurationManagerAttributes { Order = 102 }));
        MenuMetalDoors.SettingChanged += (_, _) => { Patches.UpdateMetalDoors(); };

        ScaleMenuBackgrounds = Config.Bind("02. Menu", "Scale Backgrounds", true, new ConfigDescription("Scales the backgrounds in the main menu.", null, new ConfigurationManagerAttributes { Order = 101 }));
        ScaleMenuBackgrounds.SettingChanged += (_, _) => { Patches.UpdateMenuBackgrounds(); };

        TransparentHUD = Config.Bind("03. HUD", "Transparent HUD", true, new ConfigDescription("Makes the HUD transparent.", null, new ConfigurationManagerAttributes { Order = 100 }));
        TransparentHUD.SettingChanged += (_, _) => { Patches.UpdateHUD(); };

        SkipIntroCinematic = Config.Bind("04. Startup", "Skip Intro Cinematic", true, new ConfigDescription("Skips the intro cinematic.", null, new ConfigurationManagerAttributes { Order = 99 }));
        
        CorrectFixedUpdateRate = Config.Bind("05. Performance", "Modify Physics Rate", true,
            new ConfigDescription(
                "Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways. It may do nothing at all.",
                null, new ConfigurationManagerAttributes { Order = 92 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("05. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription(
                "Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.",
                null, new ConfigurationManagerAttributes { Order = 91 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        RunInBackground = Config.Bind("06. Misc", "Run In Background", true,
            new ConfigDescription("Allows the game to run even when not in focus.", null,
                new ConfigurationManagerAttributes { Order = 90 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };


        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false,
            new ConfigDescription("Mutes the game's audio when it is not in focus.", null,
                new ConfigurationManagerAttributes { Order = 89 }));


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

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;
        Display._mainDisplay.Activate();
        var refreshRate = Screen.currentResolution.refreshRateRatio;
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, refreshRate);
        Application.targetFrameRate = (int)refreshRate.value;
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateFixedDeltaTime();
        UpdateDisplay();
    }


    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        if (Mathf.Approximately((float)Screen.currentResolution.refreshRateRatio.value, OriginalFixedDeltaTime.Value) ||
            OriginalFixedDeltaTime.Value > Screen.currentResolution.refreshRateRatio.value)
        {
            Log.LogInfo(
                "Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = (float)(1f / Screen.currentResolution.refreshRateRatio.value);
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(Screen.currentResolution.refreshRateRatio.value);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }
}