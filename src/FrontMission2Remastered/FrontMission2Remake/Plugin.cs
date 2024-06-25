using MonoMod.Utils;
using PeaksOfYore;

namespace FrontMission2Remake;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.frontmission2.ultrawide";
    private const string PluginName = "Front Mission 2 Remake Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    
    internal static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Log { get; private set; }

    internal static WindowPositioner WindowPositioner { get; set; }

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 104}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 103}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }
        
        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 90}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));

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

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();
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

}