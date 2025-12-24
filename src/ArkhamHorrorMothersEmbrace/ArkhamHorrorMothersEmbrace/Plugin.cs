using SceneManager = UnityEngine.SceneManagement.SceneManager;

namespace ArkhamHorrorMothersEmbrace;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.arkhamhorrormothersembrace.ultrawide";
    private const string PluginName = "Arkham Horror Mothers Embrace Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }

    internal static int CurrentWidth => Screen.currentResolution.width; //3440
    internal static int CurrentHeight => Screen.currentResolution.height; //1440
    internal static float CurrentAspect => (float)CurrentWidth / CurrentHeight; //2.3888889
    internal const float NativeAspect = 16f / 9f; //1.777778

    public static float PositiveScaleFactor => CurrentAspect / NativeAspect; //2.3888889 / 1.777778 = 1.3444

    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    public static ConfigFile ConfigFile { get; private set; }
    public static ConfigEntry<bool> Notifications { get; private set; }
    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;
        CorrectFixedUpdateRate = Config.Bind("01. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.", null, new ConfigurationManagerAttributes { Order = 92 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("01. Performance", "Use Refresh Rate For Physics Rate", true,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes { Order = 91 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };
      
        Notifications = Config.Bind("02. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription(
                "Enable or disable notifications for post-processing effects being registered for configuration.",
                null,
                new ConfigurationManagerAttributes { Order = 99 }));
        
        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Log.LogInfo($"Scene loaded: {scene.name}");
        Patches.UpdateCameraGateFit();
        UpdateFixedDeltaTime();
        Volumes.UpdateVolumes();
    }
    private static WriteOnce<int> OriginalFixedDeltaTime { get; } = new();
    private static int CurrentRefresh => Screen.currentResolution.refreshRate;
    
    private static void UpdateFixedDeltaTime()
    {
        if (!OriginalFixedDeltaTime.HasValue)
        {
            OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
            Log.LogInfo($"Original physics update rate: {OriginalFixedDeltaTime.Value}Hz"); 
        }
        
        if (Mathf.Approximately(CurrentRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > CurrentRefresh)
        {
            Log.LogInfo("Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / CurrentRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.Utils.FindLowestFrameRateDivisorAboveFifty(CurrentRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

}