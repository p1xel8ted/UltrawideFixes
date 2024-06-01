namespace RoguePrinceOfPersia;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
internal class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.rogueprinceofpersia.ultrawide";
    private const string PluginName = "The Rogue Prince of Persia Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
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

    public override void Load()
    {
        ScaleAdjustment = Config.Bind("01. Scaling", "Scale Adjustment", -10f, new ConfigDescription("Adjusts the scale of the UI elements by a percentage.", new AcceptableValueRange<float>(-95f, 200f), new ConfigurationManagerAttributes {Order = 23}));
        ScaleAdjustment.SettingChanged += (_, _) =>
        {
            Patches.UpdateScalers();
        };


        Bloom = Config.Bind("02. Post-Processing", "Bloom", false, new ConfigDescription("Toggles the bloom effect.", null, new ConfigurationManagerAttributes {Order = 11}));
        Bloom.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        ChromaticAberration = Config.Bind("02. Post-Processing", "Chromatic Aberration", false, new ConfigDescription("Toggles the chromatic aberration effect.", null, new ConfigurationManagerAttributes {Order = 10}));
        ChromaticAberration.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        ColorAdjustments = Config.Bind("02. Post-Processing", "Color Adjustments", false, new ConfigDescription("Toggles the color adjustments effect.", null, new ConfigurationManagerAttributes {Order = 9}));
        ColorAdjustments.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        DepthOfField = Config.Bind("02. Post-Processing", "Depth of Field", false, new ConfigDescription("Toggles the depth of field effect.", null, new ConfigurationManagerAttributes {Order = 8}));
        DepthOfField.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        DepthOfFieldAperture = Config.Bind("02. Post-Processing", "Depth of Field Aperture", 7.5f, new ConfigDescription("Adjusts the depth of field aperture.", new AcceptableValueRange<float>(5.4f, 50), new ConfigurationManagerAttributes {Order = 7}));
        DepthOfFieldAperture.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        DepthOfFieldFocusDistance = Config.Bind("02. Post-Processing", "Depth of Field Focus Distance", 40f, new ConfigDescription("Adjusts the depth of field focus distance.", new AcceptableValueRange<float>(40f, 50f), new ConfigurationManagerAttributes {Order = 6}));
        DepthOfFieldFocusDistance.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        FilmGrain = Config.Bind("02. Post-Processing", "Film Grain", false, new ConfigDescription("Toggles the film grain effect.", null, new ConfigurationManagerAttributes {Order = 5}));
        FilmGrain.SettingChanged += (_, _) =>
        {
            Patches.VolumeUpdateRequired = true;
        };

        Fog = Config.Bind("02. Post-Processing", "Fog", true, new ConfigDescription("Toggles the fog effect.", null, new ConfigurationManagerAttributes {Order = 4}));
        Fog.SettingChanged += (_, _) =>
        {
            ToggleEffects();
        };
        LightShafts = Config.Bind("02. Post-Processing", "Light Shafts", true, new ConfigDescription("Toggles the light shafts effect.", null, new ConfigurationManagerAttributes {Order = 3}));
        LightShafts.SettingChanged += (_, _) =>
        {
            ToggleEffects();
        };
        Outlines = Config.Bind("02. Post-Processing", "Outlines", true, new ConfigDescription("Toggles the outlines effect.", null, new ConfigurationManagerAttributes {Order = 2}));
        Outlines.SettingChanged += (_, _) =>
        {
            ToggleEffects();
        };
        SmokyColor = Config.Bind("02. Post-Processing", "Smoky Color", true, new ConfigDescription("Toggles the smoky color effect.", null, new ConfigurationManagerAttributes {Order = 1}));
        SmokyColor.SettingChanged += (_, _) =>
        {
            ToggleEffects();
        };
        Vignette = Config.Bind("02. Post-Processing", "Vignette", false, new ConfigDescription("Toggles the vignette effect.", null, new ConfigurationManagerAttributes {Order = 0}));

        RunInBackground = Config.Bind("02. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = -1}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
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
        ToggleEffects();
        Patches.UpdateScalers();
    }

}