namespace AllHandsOnDeck;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.allhandsondeck.ultrawide";
    private const string PluginName = "All Hands On Deck Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }

    internal static readonly int MainWidth = Display.main.systemWidth; //3440
    internal static readonly int MainHeight = Display.main.systemHeight; //1440

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    private static WriteOnce<float> OriginalFixedUpdateRate { get; } = new();
    public static ConfigFile ConfigFile { get; private set; }

    private void Awake()
    {
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow);

        Log = Logger;
        ConfigFile = Config;
        OriginalFixedUpdateRate.Value = Time.fixedDeltaTime;

        CorrectFixedUpdateRate = Config.Bind("01. Performance", "CorrectFixedUpdateRate", true,
            new ConfigDescription("Adjusts the physics update rate to reduce camera judder based on your refresh rate.",
                null, new ConfigurationManagerAttributes { Order = 92, DispName = "Correct Physics Rate" }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => UpdateFixedDeltaTime();

        UseRefreshRateForFixedUpdateRate = Config.Bind("01. Performance", "UseRefreshRateForFixedUpdateRate", true,
            new ConfigDescription("Uses your monitor's refresh rate directly for the physics update rate. When disabled, a calculated optimal rate is used instead.",
                null, new ConfigurationManagerAttributes { Order = 91, DispName = "Use Monitor Refresh Rate" }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => UpdateFixedDeltaTime();

        Notifications = Config.Bind("02. Post-Processing", "Notifications", true,
            new ConfigDescription("Show on-screen notifications when post-processing effects are registered for configuration.",
                null, new ConfigurationManagerAttributes { Order = 99, DispName = "Registration Notifications" }));

        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateFixedDeltaTime();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow);
    }

    private static void UpdateFixedDeltaTime()
    {
        var refreshRate = Screen.currentResolution.refreshRate;

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / refreshRate;
                Log.LogInfo($"Set fixed update rate to {refreshRate}Hz (monitor refresh rate).");
            }
            else
            {
                var newRate = Utils.Utils.FindLowestFrameRateMultipleAboveFifty(refreshRate);
                Time.fixedDeltaTime = 1f / newRate;
                Log.LogInfo($"Set fixed update rate to {newRate}Hz (lowest divisor of {refreshRate}Hz above 50).");
            }
        }
        else
        {
            Time.fixedDeltaTime = OriginalFixedUpdateRate.Value;
            Log.LogInfo($"Restored original fixed update rate to {Mathf.RoundToInt(1f / OriginalFixedUpdateRate.Value)}Hz.");
        }
    }
}
