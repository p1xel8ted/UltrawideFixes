namespace KazeWildMasks;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.kazewildmasks.ultrawide";
    private const string PluginName = "Kaze and the Wild Masks Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    internal const float BaseAspectRatio = 16f / 9f;
    internal const float SuperWideAspectRatio = 32f / 9f;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => BaseAspectRatio / MainAspectRatio;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Logger { get; private set; }

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<BonusCompleteScaler>();
        ClassInjector.RegisterTypeInIl2Cpp<LoadingScreenScaler>();
        ClassInjector.RegisterTypeInIl2Cpp<GenericScaler>();
        
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode", null,new ConfigurationManagerAttributes {Order = 101}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 100}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        
        RunInBackground = Config.Bind("02. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("02. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Utils.FindIl2CppType<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
        
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateBackgrounds();

        UpdateDisplay();
    }

    internal static void UpdateBackgrounds()
    {
        foreach (var r in Utils.FindIl2CppType<RectTransform>())
        {
            if (r.name.Equals("KazeLogo") || r.name.Equals("Splash")) continue;

            if (r.name.Equals("NegativeImage") || r.name.Equals("BKG") || r.name.Equals("BKG_100%"))
            {
                r.gameObject.TryAddComponent<GenericScaler>();
            }
            
            var rectAspect = r.sizeDelta.x / r.sizeDelta.y;

            if (!Mathf.Approximately(rectAspect, BaseAspectRatio)) continue;

            var y = r.sizeDelta.y;
            var x = y * MainAspectRatio;
            r.sizeDelta = new Vector2(x, y);
        }

    }
    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

}