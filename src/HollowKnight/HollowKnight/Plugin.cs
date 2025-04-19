namespace HollowKnight;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.hollowknight.ultrawide";
    private const string PluginName = "Hollow Knight Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    public const float NativeAspect = 16f / 9f;
    internal static ManualLogSource Log { get; set; }
    public static ConfigEntry<float> CameraFieldOfView { get; private set; }
    public static ConfigEntry<bool> HeroLightDonut { get; private set; }
    public static ConfigEntry<bool> HeroLight { get; private set; }

#if DEBUG
    public static float CurrentAspect => 3200f / 900f;
#else
    public static float CurrentAspect => Screen.width / (float)Screen.height;
    public static ConfigEntry<bool> ShowMainResolutionOnly { get; set; }
#endif

    private void Awake()
    {
        Log = Logger;

        Log.LogInfo($"Plugin {PluginName} is loaded!");

        ShowMainResolutionOnly = Config.Bind("01. Resolution", "Show Main Resolution Only", true, new ConfigDescription("Show only your displays native resolution in the settings menu.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ShowMainResolutionOnly.SettingChanged += (_, _) =>
        {
            var mrs = Resources.FindObjectsOfTypeAll<MenuResolutionSetting>().ToList();
            foreach (var setting in mrs)
            {
                setting.RefreshAvailableResolutions();
            }
        };
        
        CameraFieldOfView = Config.Bind("02. Camera", "Field of View", 1f, new ConfigDescription("Adjust the camera's field of view multiplier.", new AcceptableValueRange<float>(0.75f, 3f), new ConfigurationManagerAttributes { Order = 90 }));
        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            if (CameraFieldOfView.Value == 0)
            {
                CameraFieldOfView.Value = 1f;
            }

            CameraFieldOfView.Value = Mathf.Round(CameraFieldOfView.Value * 10) / 10f;
        };

        HeroLight = Config.Bind("03. Hero", "Hero Light", true, new ConfigDescription("Toggle the fake light that surrounds the player character.", null, new ConfigurationManagerAttributes { Order = 89 }));
        HeroLightDonut = Config.Bind("03. Hero", "Hero Light Donut", true, new ConfigDescription("Toggle the donut light that surrounds the player character.", null, new ConfigurationManagerAttributes { Order = 88 }));

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
#if DEBUG
        UnityEngine.SceneManagement.SceneManager.sceneLoaded += (_, _) => { Screen.SetResolution(3200, 900, FullScreenMode.Windowed, 0); };
#endif
    }
}