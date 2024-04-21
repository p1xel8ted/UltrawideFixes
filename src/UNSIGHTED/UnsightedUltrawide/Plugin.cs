namespace UnsightedUltrawide;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.unsighted.ultrawide";
    private const string PluginName = "UNSIGHTED Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    
   

    internal static float TwentyOneNineAspect => 21.5f / 9f; //21:9 is actually 43:18
    internal static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    internal static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;

    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;

    internal static float BaseAspectRatio => 16f / 9f;


    internal static bool SuperWide => MainAspectRatio > TwentyOneNineAspect;

    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ManualLogSource LOG { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static float BaseAspect => 16f / 9f;
    internal static int SixteenNineWidth => MainHeight * 16 / 9;
    private static float CurrentAspect => MainWidth / (float) MainHeight;

    internal static CanvasScaler GlobalCanvasScaler => GameObject.Find("GlobalGameManager/GlobalCanvas").GetComponent<CanvasScaler>();
    internal static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<bool> SkipDevLogos { get; set; }
    internal static ConfigEntry<bool> KeepUICentered { get; private set; }
    private void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        
        
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            Patches.ChangeResolution();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            Patches.ChangeResolution();
        };

        RunInBackground = Config.Bind("01. General", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.",null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };
        
        MuteInBackground = Config.Bind("01. General", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.",null, new ConfigurationManagerAttributes {Order = 98}));

        SkipDevLogos = Config.Bind("00. General", "Skip Splash Screens", true, "Skips the developer logos at the start of the game.");
        KeepUICentered = Config.Bind("02. UI", "Keep UI Centered", true, "Keeps the UI (and other screens) at the original 16:9 ratio.");
        
        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        Patches.ChangeResolution();

        // main menu

        var topBackground = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/HeadAnimation/Degrade1");
        if (topBackground)
        {
            topBackground.transform.localScale = topBackground.transform.localScale with {x = PositiveScaleFactor};
        }
        
        var middleBackground = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/HeadAnimation/Degrade2");
        if (middleBackground)
        {
            middleBackground.transform.localPosition = middleBackground.transform.position with {x = -330f};
        }
    }


}