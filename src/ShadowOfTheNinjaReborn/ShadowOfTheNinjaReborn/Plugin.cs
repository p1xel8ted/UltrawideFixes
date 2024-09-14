namespace ShadowOfTheNinjaReborn;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.shadowoftheninjareborn.ultrawide";
    private const string PluginName = "Shadow of the Ninja Reborn Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    private const float TwentyOneNine = 21f / 9f; // 2560x1080

    // internal const float TwentyOneFiveNine = 21.5f / 9f; // 3440x1440
    internal static float CurrentScreenAspect => MainWidth / (float)MainHeight;
    // internal static bool UsingTwentyOneFiveNine => CurrentScreenAspect > TwentyOneNine;
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display._mainDisplay.systemWidth;
    internal static int MainHeight => Display._mainDisplay.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float ScaleFactor => CurrentScreenAspect / NativeAspect;
    internal static float CurrentAspect => UseTwentyOneNine.Value ? TwentyOneNine : CurrentScreenAspect;

    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    public static ConfigEntry<bool> ScaleBackgrounds { get; private set; }
    
    public static ConfigEntry<int> PlayerOneGaugePosition { get; private set; }
    public static ConfigEntry<int> PlayerTwoGaugePosition { get; private set; }
    internal static ConfigEntry<string> AntialiasingMode { get; private set; }
    public static ConfigEntry<bool> UseTwentyOneNine { get; private set; }

    public const float NativeAspect = 16f / 9f;
    
     internal static ManualLogSource Logger;

    public override void Load()
    {
       ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
       
         Logger = Log;
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) => { Patches.UpdateDisplay(); };

        UseTwentyOneNine = Config.Bind("01. Display", "Use Real 21:9", false, new ConfigDescription("For users that have a decimal in their aspect, i.e. 21.5:9 (3440x1440), if you're getting white lines, enable this.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseTwentyOneNine.SettingChanged += (_, _) =>
        {
            Patches.RunFixes();
        };
        
        AntialiasingMode = Config.Bind("02. Graphics", "Antialiasing Mode", UnityEngine.Rendering.Universal.AntialiasingMode.None.ToFriendlyString(), new ConfigDescription("Set the antialiasing mode", new AcceptableValueList<string>(EnumMapper.StringToAntialiasingModeMap.Keys.ToArray()), new ConfigurationManagerAttributes { Order = 96 }));

        AntialiasingMode.SettingChanged += (_, _) => { Patches.UpdateAA(); };

        ScaleBackgrounds = Config.Bind("02. Graphics", "Scale Backgrounds", false, new ConfigDescription("Scales the backgrounds to fit the screen. Has no effect on 21:9 or lower.", null, new ConfigurationManagerAttributes { Order = 95 }));
        
        PlayerOneGaugePosition = Config.Bind("03. UI", "Player One Gauge Position", 0, new ConfigDescription("Set the position of the Player One gauge.", new AcceptableValueRange<int>(-1000,1000), new ConfigurationManagerAttributes { Order = 94 }));
        PlayerOneGaugePosition.SettingChanged += (_, _) => { Patches.UpdateGaugePosition(); };
        
        PlayerTwoGaugePosition = Config.Bind("03. UI", "Player Two Gauge Position", 0, new ConfigDescription("Set the position of the Player Two gauge.", new AcceptableValueRange<int>(-1000,1000), new ConfigurationManagerAttributes { Order = 93 }));
        PlayerTwoGaugePosition.SettingChanged += (_, _) => { Patches.UpdateGaugePosition(); };
        
        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 99 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 98 }));
        
        
        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        Patches.RunFixes();
    }
}