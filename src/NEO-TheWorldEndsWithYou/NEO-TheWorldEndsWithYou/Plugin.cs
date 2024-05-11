using System;
using Il2CppInterop.Runtime.Injection;

namespace NEOTheWorldEndsWithYouUltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.neotheworldendswithyou.ultrawide";
    private const string PluginName = "NEO - The World Ends With You Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float CameraWidth => MainHeight * BaseAspectRatio;
    internal static float CameraHeight => MainHeight;
    internal static float BlackBarSize => (MainWidth - CameraWidth) / 2f;

    internal const float BaseAspectRatio = 16f / 9f;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    internal static ConfigEntry<bool> CenterComicStripDialog { get; private set; }
    internal static ConfigEntry<bool> PillarBoxComicStripDialog { get; private set; }
    
    internal static ConfigEntry<bool> CenterNpcChatter { get; private set; }
    internal static ConfigEntry<bool> PillarBoxNpcChatter { get; private set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Logger { get; private set; }

    public override void Load()
    {
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 103}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 102}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        CenterComicStripDialog = Config.Bind("02. Comic Strip Dialog", "Center Comic Strip Dialog", true, new ConfigDescription("Centers the comic strip dialog on the screen.", null, new ConfigurationManagerAttributes {Order = 101}));
        PillarBoxComicStripDialog = Config.Bind("02. Comic Strip Dialog", "Use Black Bars When Centering Comic Strip Dialog", true, new ConfigDescription("Use black bars when centering the comic strip dialog.", null, new ConfigurationManagerAttributes {Order = 100}));
        
        CenterNpcChatter = Config.Bind("02. Comic Strip Dialog", "Center Npc Chatter", true, new ConfigDescription("Centers the NPC chatter dialog on the screen.", null, new ConfigurationManagerAttributes {Order = 100}));
        PillarBoxNpcChatter = Config.Bind("02. Comic Strip Dialog", "Use Black Bars When Centering Comic Strip Dialog", true, new ConfigDescription("Use black bars when centering the comic strip dialog.", null, new ConfigurationManagerAttributes {Order = 100}));

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));


        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }
    
    

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        if (a.name.Equals("Logo"))
        {
            SceneManager.LoadScene("Title");
        }
        UpdateDisplay();
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }
}