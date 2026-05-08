using MousePiForHire.Infrastructure;

namespace MousePiForHire;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.mousepiforhire.ultrawide";
    private const string PluginName = "MOUSE P.I. For Hire Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }
    public static ConfigFile ConfigFile { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<int> FovMin { get; private set; }
    internal static ConfigEntry<int> FovMax { get; private set; }

    private void Awake()
    {
        Log = Logger;
     
        ConfigFile = Config;

        Notifications = Config.Bind("01. General", "Notifications", true,
            new ConfigDescription("Show on-screen messages when post-processing effects are registered.", null,
                new ConfigurationManagerAttributes { Order = 8 }));

        FovMin = Config.Bind("01. General", "FOV Slider Min", 60,
            new ConfigDescription("Lowest FOV the in-game slider can reach.",
                new AcceptableValueRange<int>(30, 120),
                new ConfigurationManagerAttributes { Order = 6 }));
        FovMin.SettingChanged += (_, _) => Patches.Patches.ApplyFovBounds();

        FovMax = Config.Bind("01. General", "FOV Slider Max", 120,
            new ConfigDescription("Highest FOV the in-game slider can reach.",
                new AcceptableValueRange<int>(60, 150),
                new ConfigurationManagerAttributes { Order = 5 }));
        FovMax.SettingChanged += (_, _) => Patches.Patches.ApplyFovBounds();

        // Clear any resolution list the game may have already cached before our patch was attached,
        // since that cached list would have ultrawide entries filtered out.
        DisplayUtility._lastRawResolutions = null;
        DisplayUtility._cachedUnique = null;

        LogFilter.Install();

        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Logger.LogInfo($"Plugin {PluginName} initialized. Native display: {DisplayMetrics.NativeSystemWidth}x{DisplayMetrics.NativeSystemHeight}, aspect={DisplayMetrics.NativeSystemAspect:F4}, isWider={DisplayMetrics.IsWiderThanNative}");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Log.LogInfo($"Scene loaded: {scene.name} (mode={mode}) | Screen: {Screen.width}x{Screen.height} {Screen.fullScreenMode} | Native: {DisplayMetrics.NativeSystemWidth}x{DisplayMetrics.NativeSystemHeight}");
        Volumes.ScanAndApply();
    }
}
