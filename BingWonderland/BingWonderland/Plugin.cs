namespace BingWonderland;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.bingwonderlang.ultrawide";
    private const string PluginName = "Bing in Wonderland Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    private const float BaseAspectRatio = 16f / 9f;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal const float SuperWideAspectRatio = 32f / 9f;

    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static ManualLogSource Log { get; set; }

    private void Awake()
    {
        HySteamHelper.WhileListFile = HySteamHelper.WhileListFile.Append("doorstop_config.ini").ToArray();
        HySteamHelper.WhileListFile = HySteamHelper.WhileListFile.Append("winhttp.dll").ToArray();
        HySteamHelper.WhiteListDirectory = HySteamHelper.WhiteListDirectory.Append("BepInEx").ToArray();

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
        
        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

}