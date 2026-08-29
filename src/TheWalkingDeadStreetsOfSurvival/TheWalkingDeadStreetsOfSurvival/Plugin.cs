namespace TheWalkingDeadStreetsOfSurvival;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.theWalkingdeadstreetsofsurvival.ultrawide";
    private const string PluginName = "The Walking Dead: Streets of Survival Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }

    internal static readonly int MainWidth = Display.main.systemWidth; //3440
    internal static readonly int MainHeight = Display.main.systemHeight; //1440

    // internal static ConfigEntry<bool> Notifications { get; private set; }
    private static ConfigEntry<float> FieldOfViewMultiplier { get; set; }
    internal static float FovMultiplier { get; private set; } = 1f;
    public static ConfigFile ConfigFile { get; private set; }

    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;

        FieldOfViewMultiplier = Config.Bind("01. Camera", "FieldOfViewMultiplier", 1f,
            new ConfigDescription("Scales the camera's field of view. Values below 1 zoom in, values above 1 zoom out.",
                new AcceptableValueRange<float>(0.5f, 2f), new ConfigurationManagerAttributes { Order = 90, DispName = "Field of View Multiplier" }));
        FovMultiplier = FieldOfViewMultiplier.Value;
        FieldOfViewMultiplier.SettingChanged += (_, _) => FovMultiplier = FieldOfViewMultiplier.Value;

        //Notifications = Config.Bind("02. Post-Processing", "Notifications", true,
        //    new ConfigDescription("Show on-screen notifications when post-processing effects are registered for configuration.",
        //        null, new ConfigurationManagerAttributes { Order = 99, DispName = "Registration Notifications" }));

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
}
