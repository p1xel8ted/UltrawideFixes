namespace NewSuperLuckyTales;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.newsuperluckytales.ultrawide";
    private const string PluginName = "New Super Lucky Tales Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;

    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    internal const float BaseAspectRatio = 16f / 9f;
    internal const float SuperWideAspectRatio = 32f / 9f;

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static ManualLogSource Log { get; private set; }

    private void Awake()
    {
        Log = Logger;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        FieldOfView = Config.Bind("02. Camera", "Field of View", 0, new ConfigDescription("Increase the field of view by a percentage.", new AcceptableValueRange<int>(-50, 100), new ConfigurationManagerAttributes {Order = 100}));

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private void LateUpdate()
    {
        if (!Application.isFocused)
        {
            AudioListener.volume = MuteInBackground.Value ? 0 : 100;
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, true, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

}