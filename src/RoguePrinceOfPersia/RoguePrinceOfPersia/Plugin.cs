namespace RoguePrinceOfPersia;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
internal class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.rogueprinceofpersia.ultrawide";
    private const string PluginName = "The Rogue Prince of Persia Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> Fog { get; set; }
    private static ConfigEntry<bool> LightShafts { get; set; }
    private static ConfigEntry<bool> SmokyColor { get; set; }
    private static ConfigEntry<bool> Outlines { get; set; }
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> FilmGrain { get; private set; }
    internal static ConfigEntry<bool> ChromaticAberration { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> DepthOfField { get; private set; }
    internal static ConfigEntry<bool> ColorAdjustments { get; private set; }
    internal static ConfigEntry<float> ScaleAdjustment { get; private set; }
    public static ConfigEntry<float> DepthOfFieldAperture { get; private set; }
    public static ConfigEntry<float> DepthOfFieldFocusDistance { get; private set; }
    private const float NativeAspect = 16f / 9f;
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ConfigEntry<bool> RestrictHUD { get; private set; }
    internal static ConfigEntry<bool> IncludeUI { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static WindowPositioner WindowPositioner { get; set; }
    internal static ManualLogSource Logger { get; private set; }
    public static float MainAspectRatio => MainWidth / (float)MainHeight;
    internal static ConfigEntry<bool> CleanMenu { get; private set; }
 
    public override void Load()
    {
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 17 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateDisplay();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 16 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();

        if (PlatformHelper.Is(MonoMod.Utils.Platform.Windows) || PlatformHelper.Is(MonoMod.Utils.Platform.Windows))
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }
  
        ScaleAdjustment = Config.Bind("03. Scaling", "Scale Adjustment", -10f, new ConfigDescription("Adjusts the scale of the UI elements by a percentage.", new AcceptableValueRange<float>(-95f, 200f), new ConfigurationManagerAttributes { Order = 23 }));
        ScaleAdjustment.SettingChanged += (_, _) => { Patches.UpdateScalers(); };
        
        Bloom = Config.Bind("04. Post-Processing", "Bloom", false, new ConfigDescription("Toggles the bloom effect.", null, new ConfigurationManagerAttributes { Order = 11 }));
        Bloom.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        ChromaticAberration = Config.Bind("04. Post-Processing", "Chromatic Aberration", false, new ConfigDescription("Toggles the chromatic aberration effect.", null, new ConfigurationManagerAttributes { Order = 10 }));
        ChromaticAberration.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        ColorAdjustments = Config.Bind("04. Post-Processing", "Color Adjustments", false, new ConfigDescription("Toggles the color adjustments effect.", null, new ConfigurationManagerAttributes { Order = 9 }));
        ColorAdjustments.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        DepthOfField = Config.Bind("04. Post-Processing", "Depth of Field", false, new ConfigDescription("Toggles the depth of field effect.", null, new ConfigurationManagerAttributes { Order = 8 }));
        DepthOfField.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        DepthOfFieldAperture = Config.Bind("04. Post-Processing", "Depth of Field Aperture", 7.5f, new ConfigDescription("Adjusts the depth of field aperture.", new AcceptableValueRange<float>(5.4f, 50), new ConfigurationManagerAttributes { Order = 7 }));
        DepthOfFieldAperture.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        DepthOfFieldFocusDistance = Config.Bind("04. Post-Processing", "Depth of Field Focus Distance", 40f, new ConfigDescription("Adjusts the depth of field focus distance.", new AcceptableValueRange<float>(40f, 50f), new ConfigurationManagerAttributes { Order = 6 }));
        DepthOfFieldFocusDistance.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        FilmGrain = Config.Bind("04. Post-Processing", "Film Grain", false, new ConfigDescription("Toggles the film grain effect.", null, new ConfigurationManagerAttributes { Order = 5 }));
        FilmGrain.SettingChanged += (_, _) => { Patches.VolumeUpdateRequired = true; };

        Fog = Config.Bind("04. Post-Processing", "Fog", true, new ConfigDescription("Toggles the fog effect.", null, new ConfigurationManagerAttributes { Order = 4 }));
        Fog.SettingChanged += (_, _) => { ToggleEffects(); };
        LightShafts = Config.Bind("04. Post-Processing", "Light Shafts", true, new ConfigDescription("Toggles the light shafts effect.", null, new ConfigurationManagerAttributes { Order = 3 }));
        LightShafts.SettingChanged += (_, _) => { ToggleEffects(); };
        Outlines = Config.Bind("04. Post-Processing", "Outlines", true, new ConfigDescription("Toggles the outlines effect.", null, new ConfigurationManagerAttributes { Order = 2 }));
        Outlines.SettingChanged += (_, _) => { ToggleEffects(); };
        SmokyColor = Config.Bind("04. Post-Processing", "Smoky Color", true, new ConfigDescription("Toggles the smoky color effect.", null, new ConfigurationManagerAttributes { Order = 1 }));
        SmokyColor.SettingChanged += (_, _) => { ToggleEffects(); };
        Vignette = Config.Bind("04. Post-Processing", "Vignette", false, new ConfigDescription("Toggles the vignette effect.", null, new ConfigurationManagerAttributes { Order = 0 }));

        RestrictHUD = Config.Bind("05. UI", "Restrict HUD", false, new ConfigDescription("Restrict the HUD to 16:9.", null, new ConfigurationManagerAttributes { Order = 22 }));
        RestrictHUD.SettingChanged += (_, _) => { Patches.UpdateSpanHUD(); };

        IncludeUI = Config.Bind("05. UI", "Include UI", false, new ConfigDescription("Also include other UI components in the restriction. May not work correctly.", null, new ConfigurationManagerAttributes { Order = 20 }));
        IncludeUI.SettingChanged += (_, _) => { Patches.UpdateSpanHUD(); };
        
        CleanMenu = Config.Bind("06. Misc", "Clean Menu", true, new ConfigDescription("Remove unnecessary options from the menu.", null, new ConfigurationManagerAttributes { Order = 21 }));
        CleanMenu.SettingChanged += (_, _) => { Patches.UpdateCleanMenu(); };
        
        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = -1 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

    private static void ToggleEffects()
    {
        Patches.VolumeUpdateRequired = true;
        var fog = Utils.FindIl2CppType<FogController>();
        foreach (var f in fog)
        {
            f.enabled = Fog.Value;
        }

        var lightShafts = Utils.FindIl2CppType<LightShaftController>();
        foreach (var l in lightShafts)
        {
            l.enabled = LightShafts.Value;
        }

        var smokyColor = Utils.FindIl2CppType<SmokyBiColorController>();
        foreach (var s in smokyColor)
        {
            s.enabled = SmokyColor.Value;
        }

        var outlines = Utils.FindIl2CppType<OutlinePostProcessController>();
        foreach (var o in outlines)
        {
            o.enabled = Outlines.Value;
        }

        Patches.UpdateScalers();
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        Logger.LogInfo($"Scene loaded: {a.name}");
        ToggleEffects();
        Patches.UpdateScalers();
        UpdateDisplay();
        Patches.UpdateSpanHUD();
        Patches.UpdateCleanMenu();
    }
}