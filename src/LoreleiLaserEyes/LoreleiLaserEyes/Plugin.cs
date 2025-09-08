namespace LoreleiLaserEyes;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.loreleilasereyes.ultrawide";
    private const string PluginName = "Lorelei and the Laser Eyes Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    public const float NativeAspect = 16f / 9f;
    private static ManualLogSource Log { get; set; }

#if DEBUG
    public static float CurrentAspect => 3200f / 600f;
#else
    public static float CurrentAspect => Screen.width / (float)Screen.height;
#endif
    
    /// <summary>
    /// Retrieves the preferred aspect ratio based on configuration or defaults to the current screen aspect ratio.
    /// </summary>
    internal static float GetPreferredAspect()
    {
        var width = HUDAspect.Value switch
        {
            "16:10" => 1.6f,
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => CurrentAspect,
            _ => throw new ArgumentOutOfRangeException()
        };
        return width;
    }

    private static List<string> HUDAspects { get; } =
    [
        "16:10",
        "16:9",
        "21:9",
        "21.5:9",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    internal static ConfigFile ConfigFile { get; private set; }
    private static ConfigEntry<string> HUDAspect { get; set; }
    internal static ConfigEntry<bool> ShowMainResolutionOnly { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<PostProcessLayer.Antialiasing> Antialiasing { get; private set; }
    internal static ConfigEntry<float> TaaSharpness { get; private set; }

    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;
        ShowMainResolutionOnly = Config.Bind("01. Resolution", "Show Main Resolution Only", true, new ConfigDescription("Show only your displays native resolution in the settings menu, otherwise the 5 largest resolutions will be displayed.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ShowMainResolutionOnly.SettingChanged += (_, _) => { UIElement_MenuSystem_AutoFillOptions.ReInitResolutions(); };
        HUDAspect = Config.Bind("02. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 93 }));
        HUDAspect.SettingChanged += (_, _) => { Patches.UpdateSGDeviceSpecifics(); };

        Antialiasing = Config.Bind("03. Antialiasing", "Antialiasing Mode", PostProcessLayer.Antialiasing.TemporalAntialiasing,
            new ConfigDescription("Set the antialiasing mode for post-processing effects. Options include None, Fast Approximate Antialiasing (FXAA), Subpixel Morphological Antialiasing (SMAA), and Temporal Antialiasing (TAA).", null, new ConfigurationManagerAttributes { Order = 85 }));
        Antialiasing.SettingChanged += (_, _) => Volumes.UpdateAntialiasing();

        TaaSharpness = Config.Bind("03. Antialiasing", "Temporal AA Sharpness", 0.25f,
            new ConfigDescription("Set the sharpness for Temporal Antialiasing (TAA). A value of 0 is the softest, while 1 is the sharpest.", new AcceptableValueRange<float>(-5f, 5f), new ConfigurationManagerAttributes { Order = 84 }));
        TaaSharpness.SettingChanged += (_, _) =>
        {
            //0.25 steps
            TaaSharpness.Value = Mathf.Round(TaaSharpness.Value * 4) / 4f;
            Volumes.UpdateAntialiasing();
        };

        Notifications = Config.Bind("04. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.", null, new ConfigurationManagerAttributes { Order = 86 }));

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }
}