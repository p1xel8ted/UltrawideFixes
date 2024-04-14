namespace VigilTheLongestNight;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.vigilthelongestnight.ultrawide";
    private const string PluginName = "Vigil The Longest Night Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static float WidthDifference => MainWidth - NormalWidth; //3440 - 2560 = 880
    private static float NormalWidth => MainHeight * BaseAspectRatio; //1440 * 16/9 = 2560
    private static float MainAspectRatio => (float) MainWidth / MainHeight;
    private const float BaseAspectRatio = 16f / 9f;
    internal static ConfigEntry<bool> SpannedHUD { get; private set; }
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<KeyCode> ToggleHudSpanning { get; private set; }
    private static ConfigEntry<bool> DisplayMapFog { get; set; }
    internal static ConfigEntry<KeyCode> ReloadConfigKeybind { get; private set; }
    internal static ManualLogSource Logger { get; private set; }
    internal static ConfigFile ConfigInstance { get; private set; }

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<LeftHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<RightHudMover>();
        
        ConfigInstance = Config;
        Logger = Log;

        AddComponent<MonoBehaviours>();

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode"));

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));

        RunInBackground = Config.Bind("02. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));

        MuteInBackground = Config.Bind("02. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        ReloadConfigKeybind = Config.Bind("03. Config", "Reload Config", KeyCode.F5, new ConfigDescription("Reloads the config file", null, new ConfigurationManagerAttributes {Order = 97}));

        DisplayMapFog = Config.Bind("04. Map", "Display Map Fog", true, new ConfigDescription("Display the fog on the map", null, new ConfigurationManagerAttributes {Order = 96}));
        
        SpannedHUD = Config.Bind("05. HUD", "Span HUD", true, new ConfigDescription("Extend HUD to edges of screen", null, new ConfigurationManagerAttributes {Order = 95}));
       
        ToggleHudSpanning  = Config.Bind("05. HUD", "Toggle HUD Spanning", KeyCode.F4, new ConfigDescription("Toggle HUD spanning", null, new ConfigurationManagerAttributes {Order = 97}));
        
        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;

        Config.ConfigReloaded += (_, _) =>
        {
            ConfigChanges();
            Logger.LogInfo("Config reloaded!");
        };

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
    internal static void ConfigChanges()
    {
        Application.runInBackground = RunInBackground.Value;
        if (Camera.main)
        {
            var mc = Camera.main.GetComponent<MainCom>();
            if (mc)
            {
                mc.bForceRunInBackGround = RunInBackground.Value;
            }
        }
        UpdateDisplay();
        UpdateComponents();
        ToggleMapFog();
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        ConfigChanges();
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

    private static void ToggleMapFog()
    {
        var fog = GameObject.Find("GameUI/Map/UI_MAP_TELEPORT(Clone)/LAYER");
        if (!fog) return;

        var fogRects = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Transform>()).Select(x => x.Cast<Transform>()).Where(x => x.name == "RECT_PARENT").ToArray();

        foreach (var rect in fogRects)
        {
            rect.localScale = new Vector3(1f, PositiveScaleFactor, 1f);
            rect.gameObject.SetActive(DisplayMapFog.Value);
        }
    }

    internal static void UpdateComponents()
    {
        //dialog backgrounds
        var bg1 = GameObject.Find("GameUI/MovieText/UI_MOVIE_TEXT(Clone)/BG/BG (1)");
        if (bg1) bg1.transform.localScale = new Vector3(1000f, 1, 1);
        var bg2 = GameObject.Find("GameUI/MovieText/UI_MOVIE_TEXT(Clone)/BG/BG (2)");
        if (bg2) bg2.transform.localScale = new Vector3(1000f, 1, 1);

        //map borders
        var gradient = GameObject.Find("GameUI/Map/UI_MAP_TELEPORT(Clone)/Gradient");
        if (gradient)
        {
            gradient.SetActive(false);
        }
    }

}