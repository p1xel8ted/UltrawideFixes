namespace LaikaAgedThroughBlood;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.laika.ultrawide";
    private const string PluginName = "Laika: Aged Through Blood Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal const float SuperWideAspectRatio = 32f / 9f;
    internal const float BaseAspectRatio = 16f / 9f;
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspect => (float) MainWidth / MainHeight;
    
    internal static float NativeAspect => 16f / 9f;
    
    internal static float NativeWidth => MainHeight * NativeAspect;
    
    internal static float PositiveScaleFactor => MainWidth / NativeWidth;
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> SkipWarning { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Log { get; private set; }

    private void Awake()
    {
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

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));
        
        SkipWarning = Config.Bind("04. Misc", "Skip Warning", true, new ConfigDescription("Skip autosave message and graphic warning.", null, new ConfigurationManagerAttributes {Order = 97}));
        
        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        if (SkipWarning.Value)
        {
            if (a.name.Equals("AutoSave", StringComparison.OrdinalIgnoreCase))
            {
                SceneManager.LoadScene("TitleScreen");
            }  
        }
        UpdateDisplay();
    }
    
    public class LeftBarToggler : MonoBehaviour
    {
        private void OnEnable()
        {
            Patches.LeftBar.SetActive(true);
        }
        
        private void OnDisable()
        {
            Patches.LeftBar.SetActive(false);
        }
    }
    
    public class BothBarToggler : MonoBehaviour
    {
        private void OnEnable()
        {
            Patches.LeftBar.SetActive(true);
            Patches.RightBar.SetActive(true);
        }
        
        private void OnDisable()
        {
            Patches.LeftBar.SetActive(false);
            Patches.RightBar.SetActive(false);
        }
        
    }
    
    // public class RightBarToggler : MonoBehaviour
    // {
    //     private void OnEnable()
    //     {
    //         Patches.RightBar.SetActive(true);
    //     }
    //     
    //     private void OnDisable()
    //     {
    //         Patches.RightBar.SetActive(false);
    //     }
    // }


    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Log.LogInfo($"Display: {DisplayToUse.Value} {MainWidth}x{MainHeight} @ {MaxRefresh} Hz");
        Log.LogInfo($"Aspect: {MainAspect}. Physics Update Rate: {1f / Time.fixedDeltaTime} Hz");
    }
    
}