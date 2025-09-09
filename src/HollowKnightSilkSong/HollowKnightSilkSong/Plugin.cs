namespace HollowKnightSilkSong;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.silksonghollowknight.ultrawide";
    private const string PluginName = "Hollow Knight Silksong Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    public const float NativeAspect = 16f / 9f;
    internal static ManualLogSource Log { get; private set; }
    public static ConfigEntry<float> CameraFieldOfView { get; private set; }
    public static ConfigEntry<bool> ReduceHeroLight { get; private set; }
    public static ConfigEntry<bool> HeroLight { get; private set; }

#if DEBUG
    public static float CurrentAspect => 3200f / 600f;
#else
    public static float CurrentAspect => Screen.width / (float)Screen.height;
#endif

    public static ConfigEntry<bool> ShowMainResolutionOnly { get; private set; }
    public static ConfigEntry<bool> SplashScreens { get; private set; }
    public static ConfigEntry<bool> Vignette { get; private set; }
    public static ConfigEntry<bool> MenuClutter { get; private set; }
    public static ConfigEntry<float> HudOffset { get; private set; }
    public static ConfigEntry<float> VignetteAlpha { get; private set; }
    public static ConfigEntry<bool> FeatheredEdgeInDoorways { get; private set; }
    public static ConfigEntry<bool> ScaleBlackEdges { get; private set; }

    private void Awake()
    {
        Log = Logger;
#if DEBUG
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
#endif
        ShowMainResolutionOnly = Config.Bind("01. Resolution", "Show Main Resolution Only", true, new ConfigDescription("Show only your displays native resolution in the settings menu.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ShowMainResolutionOnly.SettingChanged += (_, _) =>
        {
            var mrs = Resources.FindObjectsOfTypeAll<MenuResolutionSetting>().ToList();
            foreach (var setting in mrs)
            {
                setting.RefreshAvailableResolutions();
            }
        };

        CameraFieldOfView = Config.Bind("02. Camera", "Field of View", 0f, new ConfigDescription("Adjust the camera's field of view in degrees.", new AcceptableValueRange<float>(-5f, 25f), new ConfigurationManagerAttributes { Order = 90 }));
        CameraFieldOfView.SettingChanged += (_, _) =>
        {
            //0.1 increments
            CameraFieldOfView.Value = (float)Math.Round(CameraFieldOfView.Value * 10f) / 10f;
            Patches.UpdateConfigCache();
        };
  

        HeroLight = Config.Bind("03. Hero", "Hero Light", true, new ConfigDescription("Toggle the fake light that surrounds the player character.", null, new ConfigurationManagerAttributes { Order = 89 }));
        HeroLight.SettingChanged += (_, _) => Patches.UpdateConfigCache();

        ReduceHeroLight = Config.Bind("03. Hero", "Reduce Hero Light", false, new ConfigDescription("Reduce the light instead of outright disabling.", null, new ConfigurationManagerAttributes { Order = 88 }));
        ReduceHeroLight.SettingChanged += (_, _) => Patches.UpdateConfigCache();

        Vignette = Config.Bind("04. Screen", "Vignette", true, new ConfigDescription("Toggle the vignette effect that darkens the edges of the screen.", null, new ConfigurationManagerAttributes { Order = 87 }));
        Vignette.SettingChanged += (_, _) => Patches.UpdateConfigCache();

        VignetteAlpha = Config.Bind("04. Screen", "Vignette Alpha",1f, new ConfigDescription("Adjust the vignette alpha to your liking.", new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes { Order = 83 }));
        VignetteAlpha .SettingChanged += (_, _) =>
        {
            //steps of 0.05
            VignetteAlpha.Value = (float)Math.Round(VignetteAlpha.Value * 20f) / 20f;
            Patches.UpdateConfigCache();
      
        };
        
        SplashScreens = Config.Bind("05. Misc", "Splash Screens", true, new ConfigDescription("Control splash screen appearance prior to main-menu.", null, new ConfigurationManagerAttributes { Order = 86 }));
        MenuClutter = Config.Bind("05. Misc", "Menu Clutter", true, new ConfigDescription("Control menu clutter on the main menu i.e. logos, version numbers, credits etc", null, new ConfigurationManagerAttributes { Order = 85 }));
        MenuClutter.SettingChanged += (_, _) => UpdateMenuClutter();
        
        HudOffset = Config.Bind("06. HUD", "HUD Offset", 0f, new ConfigDescription("Adjust the HUD offset to your liking.", new AcceptableValueRange<float>(-50f, 50f), new ConfigurationManagerAttributes { Order = 84 }));
        HudOffset.SettingChanged += (_, _) =>
        {
            //steps of 0.5
            HudOffset.Value = (float)Math.Round(HudOffset.Value * 2f) / 2f;
             
            Patches.UpdateConfigCache(); 
            Patches.UpdateHudOffset();
        };
        
        ScaleBlackEdges = Config.Bind("07. Map Edges", "Scale Black Edges", true, new ConfigDescription("Scale black texture on the other side of doorways/map edges when at aspects greater than 21:9 OR at a FOV value above 0. Side effect is a feathered edge in the doorways. Will need to change zones to take effect.", null, new ConfigurationManagerAttributes { Order = 81 }));

        FeatheredEdgeInDoorways = Config.Bind("07. Map Edges", "Feathered Edge In Doorways", true, new ConfigDescription("Control the feathered edge in the doorways caused by the above. Will need to change zones to take effect.", null, new ConfigurationManagerAttributes { Order = 80 }));
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Patches.UpdateConfigCache(); // Initialize cache

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private void OnDestroy()
    {
#if DEBUG
        SceneManager.sceneLoaded -= SceneManagerOnSceneLoaded;
#endif
        Patches.Cleanup();
    }
#if DEBUG
    private static void SceneManagerOnSceneLoaded(Scene name, LoadSceneMode mode)
    {
        Screen.SetResolution(3200, 600, FullScreenMode.Windowed, 0);
    }
#endif
    
    private static void UpdateMenuClutter()
    {
        var logoLanguages = Resources.FindObjectsOfTypeAll<LogoLanguage>().ToList();
        foreach (var logo in logoLanguages)
        {
            logo.OnEnable();
        }
            
        var versionNumbers = Resources.FindObjectsOfTypeAll<SetVersionNumber>().ToList();
        foreach (var version in versionNumbers)
        {
            version.Start(); 
        }
            
        var mainMenu = Resources.FindObjectsOfTypeAll<MenuButtonList>().ToList();
        foreach (var menu in mainMenu)
        {
            menu.SetupActive();
        }  
    }
}