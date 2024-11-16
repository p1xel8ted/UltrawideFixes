using Cursor = UnityEngine.Cursor;

namespace RogueFlight;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.rogueflight.ultrawide";
    private const string PluginName = "Rogue Flight Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    private static readonly int[] CustomRefreshRates =
    [
        30, // Uncommon
        50, // Uncommon
        60, // Common
        72, // Uncommon
        75, // Common
        90, // Uncommon
        100, // Uncommon
        120, // Common
        144, // Common
        165, // Common
        180, // Common
        200, // Uncommon
        240, // Common
        300, // Uncommon
        360, // Uncommon
        480 // Uncommon
    ];

    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    internal static int RefreshRate
    {
        get
        {
            if (UseCustomRefreshRate != null && CustomRefreshRate != null)
            {
                return UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
            }

            return MaxRefresh;
        }
    }

    internal static float MainAspect => MainWidth / (float)MainHeight; //2.388888888888889
    internal static ManualLogSource Logger { get; private set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    public static ConfigEntry<bool> ChromaticAberration { get; private set; }
    public static ConfigEntry<bool> FilmGrain { get; private set; }
    public static ConfigEntry<bool> ColorAdjustments { get; private set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth; //3440
    internal static ConfigEntry<bool> Lut { get; private set; }
    internal static ConfigEntry<bool> Blur { get; private set; }
    internal static ConfigEntry<bool> Overlay { get; private set; }
    internal static ConfigEntry<bool> Scanlines { get; private set; }
    internal static ConfigEntry<bool> SpeedLines { get; private set; }
    internal static ConfigEntry<bool> ColorSplit { get; private set; }
    internal static ConfigEntry<AntialiasingMode> AntiAliasing { get; private set; }
    internal static ConfigEntry<bool> Sharpen { get; private set; }
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> LensDistortion { get; private set; }
    private static ConfigEntry<bool> SkipIntro { get; set; }
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight; //1440
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }
    internal static float NativeAspectRatio => 16f / 9f; //1.777777777777778
    private static Resolution MainRes => new()
    {
        height = MainHeight,
        width = MainWidth,
        refreshRate = RefreshRate
    };

    private static List<string> HUDAspects { get; } =
    [
        "16:9",
        "21:9",
        "21.5:9",
        "24:10",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];


    internal enum AntialiasingMode
    {
        None,
        FastApproximateAntialiasing,
        SubpixelMorphologicalAntiAliasing,
    }
    
    internal static ConfigEntry<string> HUDAspect { get; private set; }
    public static ConfigEntry<int> MSAA { get; private set; }
    public static ConfigEntry<float> RenderScale { get; private set; }
    public static ConfigEntry<bool> UseCustomQualitySettings { get; set; }

    internal static Resolution GetCustomRes()
    {
        //return ThirtyTwoNine;
        // return FortyEightNine;
        return MainRes;
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    public override void Load()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();

        Logger = Log;

        var customRates = MergeUnityRefreshRates();

        HUDAspect = Config.Bind("01. Display", "HUD Aspect", "Auto", new ConfigDescription("Select the aspect ratio of the HUD.", new AcceptableValueList<string>(HUDAspects.ToArray()), new ConfigurationManagerAttributes { Order = 100 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAll();

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode.", null, new ConfigurationManagerAttributes { Order = 99 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll();

        DisplayToUse = Config.Bind("01. Display", "Display to Use", 0, new ConfigDescription("Select the display to use.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes { Order = 98 }));
        DisplayToUse.SettingChanged += (_, _) => UpdateAll();

        if (PlatformHelper.Current == MonoMod.Utils.Platform.Windows || PlatformHelper.Current == MonoMod.Utils.Platform.Wine)
        {
            WindowPositioner = AddComponent<WindowPositioner>();
        }

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false, new ConfigDescription("Use a custom refresh rate instead of the maximum available in case Unity is reporting it wrong.", null, new ConfigurationManagerAttributes { Order = 97 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll();

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate, new ConfigDescription("Set a custom refresh rate to use instead of the maximum available.", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 96 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll();

        UseCustomQualitySettings = Config.Bind("02. Quality", "Use Custom Quality Settings", false, new ConfigDescription("Use custom quality settings instead of the in-game ones. You will need to restart if you disable this.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseCustomQualitySettings.SettingChanged += (_, _) => { UpdateQuality(); };
        
        AnisotropicFiltering = Config.Bind("02. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering."));
        AnisotropicFiltering.SettingChanged += (_, _) => { UpdateQuality(); };

        MSAA = Config.Bind("02. Quality", "MSAA", 4, new ConfigDescription("Set the MSAA level. Can't be used with Post-Process Anti-Aliasing", new AcceptableValueList<int>(0, 2, 4, 8, 16), new ConfigurationManagerAttributes { Order = 95 }));
        MSAA.SettingChanged += (_, _) =>
        {
            if (MSAA.Value != 0)
            {
                AntiAliasing.Value = AntialiasingMode.None;
            }

            UpdateQuality();
        };

        RenderScale = Config.Bind("02. Quality", "Render Scale", 1f, new ConfigDescription("Set the render scale.", new AcceptableValueRange<float>(0.5f, 5f), new ConfigurationManagerAttributes { Order = 94 }));
        RenderScale.SettingChanged += (_, _) =>
        {
            //0.25 increments
            RenderScale.Value = Mathf.Round(RenderScale.Value * 4) / 4;

            UpdateQuality();
        };

        AntiAliasing = Config.Bind("02. Quality", "Post-Process Anti-Aliasing", AntialiasingMode.SubpixelMorphologicalAntiAliasing, new ConfigDescription("Set the anti-aliasing mode. Can't be used with MSAA. TAA is absent on purpose due to games camera system.", null, new ConfigurationManagerAttributes { Order = 90 }));
        AntiAliasing.SettingChanged += (_, _) =>
        {
            if (AntiAliasing.Value != AntialiasingMode.None)
            {
                MSAA.Value = 0;
            }

            UpdateQuality();
        };

        Lut = Config.Bind("03. Post-Processing", "LUT", true, new ConfigDescription("Toggle LUT effectif it's present in the current scene. This will override in-game settings."));
        Lut.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        Blur = Config.Bind("03. Post-Processing", "Blur", true, new ConfigDescription("Toggle Blur effect if it's present in the current scene. This will override in-game settings."));
        Blur.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        Overlay = Config.Bind("03. Post-Processing", "Overlay", true, new ConfigDescription("Toggle Overlay effect if it's present in the current scene. This will override in-game settings."));
        Overlay.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        Scanlines = Config.Bind("03. Post-Processing", "Scanlines", true, new ConfigDescription("Toggle Scanlines effect if it's present in the current scene. This will override in-game settings."));
        Scanlines.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        SpeedLines = Config.Bind("03. Post-Processing", "Speed Lines", true, new ConfigDescription("Toggle Speed Lines effect if it's present in the current scene. This will override in-game settings."));
        SpeedLines.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        ColorSplit = Config.Bind("03. Post-Processing", "Color Split", true, new ConfigDescription("Toggle Color Split effect if it's present in the current scene. This will override in-game settings."));
        ColorSplit.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        Sharpen = Config.Bind("03. Post-Processing", "Sharpen", true, new ConfigDescription("Toggle Sharpen effect if it's present in the current scene. This will override in-game settings."));
        Sharpen.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        Bloom = Config.Bind("03. Post-Processing", "Bloom", true, new ConfigDescription("Toggle Bloom effect if it's present in the current scene. This will override in-game settings."));
        Bloom.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        LensDistortion = Config.Bind("03. Post-Processing", "Lens Distortion", true, new ConfigDescription("Toggle Lens Distortion effect if it's present in the current scene. This will override in-game settings."));
        LensDistortion.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        Vignette = Config.Bind("03. Post-Processing", "Vignette", true, new ConfigDescription("Toggle Vignette effect if it's present in the current scene. This will override in-game settings."));
        Vignette.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        ChromaticAberration = Config.Bind("03. Post-Processing", "Chromatic Aberration", true, new ConfigDescription("Toggle Chromatic Aberration effect if it's present in the current scene. This will override in-game settings."));
        ChromaticAberration.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        FilmGrain = Config.Bind("03. Post-Processing", "Film Grain", true, new ConfigDescription("Toggle Film Grain effect if it's present in the current scene. This will override in-game settings."));
        FilmGrain.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        ColorAdjustments = Config.Bind("03. Post-Processing", "Color Adjustments", true, new ConfigDescription("Toggle Color Adjustments effect if it's present in the current scene. This will override in-game settings."));
        ColorAdjustments.SettingChanged += (_, _) => { Patches.Patches.UpdateVolumes(); };

        SkipIntro = Config.Bind("04. Misc", "Skip Intro", true, new ConfigDescription("Skip the intro and go straight to the main menu.", null, new ConfigurationManagerAttributes { Order = 83 }));

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        if (MSAA.Value > 0)
        {
            AntiAliasing.Value = AntialiasingMode.None;
        }

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void UpdateQuality()
    {
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures - needed otherwise some UI text is garbage
        
        if (!UseCustomQualitySettings.Value) return;
        
        Patches.Patches.QualitySettings_Postfix();
        var renderPipelines = Resources.FindObjectsOfTypeAll<UniversalRenderPipelineAsset>();
        foreach (var renderPipeline in renderPipelines)
        {
            Patches.Patches.UniversalRenderPipelineAsset_OnEnable(renderPipeline);
        }

        if (MSAA.Value > 0) return;
        
        var cameraData = Resources.FindObjectsOfTypeAll<UniversalAdditionalCameraData>();
        foreach (var data in cameraData)
        {
            data.antialiasing = (UnityEngine.Rendering.Universal.AntialiasingMode)AntiAliasing.Value;
            data.antialiasingQuality = AntialiasingQuality.High;
        }
    }

    private static void UpdateAll()
    {
        UpdateDisplay();
        Patches.Patches.UpdateAspectRatioFitters();
    }


    private static void UpdateDisplay()
    {
        if (WindowPositioner)
        {
            WindowPositioner.Start();
        }

        Application.runInBackground = RunInBackground.Value;

        Display.displays[DisplayToUse.Value].Activate();
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        
        Logger.LogInfo($"Scene {scene.name} loaded with mode {mode}");

        switch (scene.name)
        {
            case "LoadGame":
                SceneManager.LoadScene(SkipIntro.Value ? "MainMenu" : "Intro");
                break;
            case "TitleScreen":
                SceneManager.LoadScene("MainMenu");
                break;
        }

        UpdateAll();
    }
}