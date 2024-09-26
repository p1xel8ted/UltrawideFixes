namespace Ufouria2;

[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BasePlugin
{
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static WindowPositioner WindowPositioner { get; set; }

    private const float NativeAspect = 16f / 9f;
    private static float MainAspect => (float)MainWidth / MainHeight;
    internal static float ScaleFactor => MainAspect / NativeAspect;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ManualLogSource Logger { get; set; }

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    public static ConfigEntry<bool> Letterbox { get; private set; }
    public static ConfigEntry<int> FieldOfView { get; private set; }


    public override void Load()
    {
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 17 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 16 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        FieldOfView = Config.Bind("02. Camera", "Field of View", 0, new ConfigDescription("Adjust the field of view of the camera by a percentage.", new AcceptableValueRange<int>(-75, 200), new ConfigurationManagerAttributes { Order = 15 }));
        FieldOfView.SettingChanged += (_, _) => Patches.UpdateCameras();
        
        Letterbox = Config.Bind("02. Camera", "Letterbox", true, new ConfigDescription("Enable letterboxing.", null, new ConfigurationManagerAttributes { Order = 14 }));
        Letterbox.SettingChanged += (_, _) => Patches.UpdateLetterbox();
        
        RunInBackground = Config.Bind("03. Miscellaneous", "Run in Background", true, new ConfigDescription("Allow the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 2 }));
        RunInBackground.SettingChanged += (_, _) => Application.runInBackground = RunInBackground.Value;

        MuteInBackground = Config.Bind("03. Miscellaneous", "Mute in Background", false, new ConfigDescription("Mute the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 1 }));

        Application.focusChanged += new Action<bool>(_ => AudioListener.pause = MuteInBackground.Value && !Application.isFocused);

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        Logger.LogInfo($"Plugin {Const.PluginGuid} is loaded!");
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        CheckIntroSkip(arg0);
        UpdateDisplay();
    }

    private static void CheckIntroSkip(Scene arg0)
    {
        Logger.LogInfo($"Loaded scene {arg0.name}");
    }
}