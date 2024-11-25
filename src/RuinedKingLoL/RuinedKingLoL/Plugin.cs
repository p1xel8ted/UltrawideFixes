namespace RuinedKingLoL;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.ruinedking.ultrawide";
    private const string PluginName = "Ruined King Ultra-Wide";
    private const string PluginVersion = "0.1.0";

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


    private static readonly string[] UpdateExtendingRectsBlacklist = ["Loading", "UI_Casper_PauseMenu", "UI_Casper_MainMenu", "WideScreenProtection"];

    private static readonly string[] EnablePillarboxing = ["Loading", "UI_Casper_MainMenu", "Empty utility stub (see CasperApplication.cs)"];

    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static int RefreshRate
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
    private static ManualLogSource Logger { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }

    internal static ConfigEntry<bool> CinematicLetterboxing { get; private set; }
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth; //3440
    private static ConfigEntry<bool> RemoveAllPillarboxes { get; set; }

    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight; //1440
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static WindowPositioner WindowPositioner { get; set; }


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

    internal static ConfigEntry<string> HUDAspect { get; private set; }

    private static GameObject PillarBoxes => GameObject.Find("GlobalCommonUI/Canvas_priority/WideScreenProtection");

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

        ClassInjector.RegisterTypeInIl2Cpp<Patches.Patches.AspectEnforcer>();
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();

        Logger = Log;

        var customRates = MergeUnityRefreshRates();
      
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
        
        CinematicLetterboxing = Config.Bind("02. Cinematics", "Enable Letterboxing", true, new ConfigDescription("Enable letterboxing during cinematic sequences. This will take effect on the next cutscene.", null, new ConfigurationManagerAttributes { Order = 85 }));
       
        HUDAspect = Config.Bind("03. UI", "UI Aspect", "Auto", new ConfigDescription("Select the aspect ratio of the HUD/UI.", new AcceptableValueList<string>(HUDAspects.ToArray()), new ConfigurationManagerAttributes { Order = 100 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAll();

        RemoveAllPillarboxes = Config.Bind("03. UI", "Remove All Pillarboxes", false, new ConfigDescription("Remove all pillarboxes. This will exposes things that shouldn't be. Setting does not apply to in-game.", null, new ConfigurationManagerAttributes { Order = 84 }));
        RemoveAllPillarboxes.SettingChanged += (_, _) => UpdatePillars();
        
        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void UpdateQuality()
    {
        QualitySettings.masterTextureLimit = 0; // Use full-resolution textures - needed otherwise some UI text is garbage
        Patches.Patches.QualitySettings_Postfix();
        var renderPipelines = Resources.FindObjectsOfTypeAll<UniversalRenderPipelineAsset>();
        foreach (var renderPipeline in renderPipelines)
        {
            Patches.Patches.UniversalRenderPipelineAsset_OnEnable(renderPipeline);
        }
    }

    private static void UpdateAll()
    {
        UpdateQuality();
        UpdateDisplay();
        UpdateExtendingRects();
        UpdatePillars();
        UpdateCameras();
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
        UpdateAll();
    }

    private static void UpdateCameras()
    {
        foreach (var camera in Camera.allCameras)
        {
            camera.aspect = MainAspect;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
        }
    }

    private static void UpdateExtendingRects()
    {
        var rects = Resources.FindObjectsOfTypeAll<ExpandingRectTransform>();
        foreach (var rect in rects)
        {
            var path = rect.gameObject.GetPath();
      
            if (UpdateExtendingRectsBlacklist.Any(a => path.Contains(a))) continue;

            rect.enabled = true;
            rect.m_maxW = Patches.Patches.GetHudRes(rect.m_maxH);
     
            rect.OnRectTransformDimensionsChange();
            rect.Refresh();
            rect.enabled = true;
        }
    }

    private static void UpdatePillars()
    {
        if (!PillarBoxes) return;
        
        if (RemoveAllPillarboxes.Value)
        {
            PillarBoxes.SetActive(false);
            return;
        }
        
        var activeScene = SceneManager.GetActiveScene().name;
        PillarBoxes.SetActive(EnablePillarboxing.Contains(activeScene));
    }
}