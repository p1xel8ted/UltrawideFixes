namespace Spiritfall;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.spiritfall.ultrawide";
    private const string PluginName = "Spiritfall Ultra-Wide Fixes & Tweaks";
    private const string PluginVersion = "0.1.0";

    private static WindowPositioner WindowPositioner { get; set; }
    internal static ConfigEntry<bool> QuitToDesktop { get; private set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MaxRefresh => (int)Screen.resolutions.Max(a => a.refreshRateRatio.value);
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static ConfigEntry<bool> CleanMainMenu { get; private set; }
    internal static ConfigEntry<bool> CleanInGameMenu { get; private set; }
    
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.activeSceneChanged += OnActiveSceneChanged;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 17 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 16 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = gameObject.AddComponent<WindowPositioner>();
        }

        CleanMainMenu = Config.Bind("02. Menus", "Clean Main Menu", true, new ConfigDescription("Remove unnecessary options from the menu.", null, new ConfigurationManagerAttributes { Order = 21 }));
        CleanMainMenu.SettingChanged += (_, _) => { Patches.RunCleanMenu(); };

        CleanInGameMenu = Config.Bind("02. Menus", "Clean In-Game Menu", true, new ConfigDescription("Remove unnecessary options from the in-game menu.", null, new ConfigurationManagerAttributes { Order = 20 }));
        CleanInGameMenu.SettingChanged += (_, _) => { Patches.RunCleanMenu(); };
        
        QuitToDesktop = Config.Bind("02. Menus", "Quit To Desktop", true,
            "Re-enables the Quit to Desktop button in the pause menu. (It's hidden by default)");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void OnActiveSceneChanged(Scene arg0, Scene arg1)
    {
        RunFixes();
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        RunFixes();
    }


    private static void RunFixes()
    {
        Patches.RunCleanMenu();
        UpdateDisplay();
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Display.displays[DisplayToUse.Value].Activate();
        var rr = new RefreshRate
        {
            denominator = 1,
            numerator = (uint)MaxRefresh
        };
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, rr);
        Application.targetFrameRate = MaxRefresh;
    }
}