namespace FutureKnight;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.futureknight.uwfixes";
    private const string PluginName = "Future Knight Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    public const float NativeAspect = 16f / 9f;
    internal static float MainAspect => Screen.width / (float)Screen.height;
    internal static ConfigFile ConfigFile { get; private set; }
    private static ManualLogSource Log { get; set; }
    internal static ConfigEntry<int> MSAA { get; private set; }
    internal static ConfigEntry<float> RenderScale { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }
    internal static ConfigEntry<bool> RemoveConsoleFrame { get; private set; }
    public static ConfigEntry<bool> MaximumQuality { get; private set; }

    private void Awake()
    {
        ConfigFile = Config;
        Log = Logger;

        RemoveConsoleFrame = Config.Bind("01. General", "Remove Console Frame", true,
            new ConfigDescription(
                "Remove the decorative Game & Watch console frame overlay. Recommended for ultrawide displays.",
                null,
                new ConfigurationManagerAttributes { Order = 100 }));
        RemoveConsoleFrame.SettingChanged += (_, _) => UpdateAll();

        MaximumQuality = Config.Bind("02. Graphics", "Maximum Quality", false,
            new ConfigDescription(
                "Enable this to use the highest quality settings for the game. This may reduce performance. If you disable this, you will need to restart the game to undo the changes.",
                null,
                new ConfigurationManagerAttributes { Order = 99 }));
        MaximumQuality.SettingChanged += (_, _) => UpdateAll();

        MSAA = Config.Bind("02. Graphics", "MSAA", 0,
            new ConfigDescription(
                "Set the level of Multi-Sample Anti-Aliasing (MSAA) to use. Higher values result in better quality but lower performance.",
                new AcceptableValueList<int>(0, 2, 4, 8),
                new ConfigurationManagerAttributes { Order = 98 }));
        MSAA.SettingChanged += (_, _) => UpdateAll();

        RenderScale = Config.Bind("02. Graphics", "Render Scale", 1f,
            new ConfigDescription(
                "Set the render scale for the game. Higher values result in better quality but lower performance.",
                new AcceptableValueRange<float>(0.25f, 4f),
                new ConfigurationManagerAttributes { Order = 97 }));
        RenderScale.SettingChanged += (_, _) =>
        {
            RenderScale.Value = Mathf.Round(RenderScale.Value * 4) / 4;
            UpdateAll();
        };

        Notifications = Config.Bind("03. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription("Enable or disable notifications for post-processing effects being registered for configuration.",
                null,
                new ConfigurationManagerAttributes { Order = 96 }));

        SceneManager.sceneLoaded += (_, _) => UpdateAll();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static void UpdateAll()
    {
        UpdateViewportAdapters();
        UpdateConsoleFrame();
        QualSettings.UpdateSettings();
        Patches.UpdateVolumes();
    }

    private static void UpdateViewportAdapters()
    {
        foreach (var adapter in ViewportAspectRatioAdapter.Cameras)
        {
            if (!adapter || !adapter._camera) continue;

            adapter._camera.rect = new Rect(0, 0, 1, 1);
        }
    }

    private static void UpdateConsoleFrame()
    {
        if (!HUDFrame.Instance) return;

        var remove = RemoveConsoleFrame.Value;

        if (HUDFrame.Instance.Frame)
        {
            HUDFrame.Instance.Frame.SetActive(!remove);
        }

        if (HUDFrame.Instance.Top)
        {
            HUDFrame.Instance.Top.enabled = !remove;
        }

        if (HUDFrame.Instance.Bottom)
        {
            HUDFrame.Instance.Bottom.enabled = !remove;
        }
    }
}
