namespace Ufouria2;

[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BasePlugin
{
    private const float NativeAspect = 16f / 9f;
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ConfigEntry<bool> KeepHeadVisibleWhenInactive { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static bool SuperWide => MainAspect > 2.5f;
    internal static float MainAspectRatio => (float)MainWidth / MainHeight;
    private static WindowPositioner WindowPositioner { get; set; }
    private static float MainAspect => (float)MainWidth / MainHeight;
    internal static float PositiveScaleFactor => MainAspect / NativeAspect;
    internal static float NegativeScaleFactor => NativeAspect / MainAspect;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<bool> MaskUIBeads { get; private set; }
    internal static ConfigEntry<bool> SpanUI { get; private set; }
    private static ManualLogSource Logger { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    public static ConfigEntry<int> FieldOfView { get; private set; }

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
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
        
        SpanUI = Config.Bind("03. UI", "Span UI", false, new ConfigDescription("Force the UI to the outer edges of the screen.", null, new ConfigurationManagerAttributes { Order = 13 }));
        SpanUI.SettingChanged += (_, _) => ValidateAndCorrectSettings();

        MaskUIBeads = Config.Bind("03. UI", "Mask UI Beads", false, new ConfigDescription("Mask the UI beads that are near the HUD items. At 21:9 with the UI constrained, they extend off the screen and look strange.", null, new ConfigurationManagerAttributes { Order = 12 }));
        MaskUIBeads.SettingChanged += (_, _) => ValidateAndCorrectSettings();

        KeepHeadVisibleWhenInactive = Config.Bind("03. UI", "Keep Talking Head Visible", false, new ConfigDescription("SuperWide only. Keep talking head visible when not actively talking.", null, new ConfigurationManagerAttributes { Order = 3 }));
        KeepHeadVisibleWhenInactive.SettingChanged += (_, _) => ValidateAndCorrectSettings();

        RunInBackground = Config.Bind("04. Miscellaneous", "Run in Background", true, new ConfigDescription("Allow the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 2 }));
        RunInBackground.SettingChanged += (_, _) => Application.runInBackground = RunInBackground.Value;

        MuteInBackground = Config.Bind("04. Miscellaneous", "Mute in Background", false, new ConfigDescription("Mute the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 1 }));

        ValidateAndCorrectSettings();

        Application.focusChanged += new Action<bool>(_ => AudioListener.pause = MuteInBackground.Value && !Application.isFocused);

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        Logger.LogInfo($"Plugin {Const.PluginGuid} is loaded!");
    }

    private static void ValidateAndCorrectSettings()
    {
        if (SpanUI.Value)
        {
            MaskUIBeads.Value = false;
            KeepHeadVisibleWhenInactive.Value = false;
        }

        if (MaskUIBeads.Value && SpanUI.Value)
        {
            MaskUIBeads.Value = false;
        }

        if (!SuperWide || SpanUI.Value)
        {
            KeepHeadVisibleWhenInactive.Value = false;
        }

        Patches.UpdateSpanHUD();
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
        ValidateAndCorrectSettings();
        UpdateDisplay();
        Patches.UpdateSpanHUD();
        Patches.UpdateMasks();
        Patches.UpdateCameras();
    }
}