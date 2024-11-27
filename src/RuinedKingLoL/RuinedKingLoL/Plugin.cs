namespace RuinedKingLoL;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.ruinedking.ultrawide";
    private const string PluginName = "Ruined King Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    private const float NativeAspect = 16f / 9f; //16:9)

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


    private static readonly string[] UpdateExtendingRectsBlacklist = ["Loading", "UI_Casper_PauseMenu", "UI_Casper_MainMenu", "WideScreenProtection", "UI_Casper_CharacterScreen", "UI_Casper_Crafting"];

    private static readonly string[] EnablePillarboxing = ["Loading", "UI_Casper_MainMenu", "Empty utility stub (see CasperApplication.cs)"];

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };


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

    internal static float PositiveScaleFactor => MainAspect / NativeAspect; //0.6944444444444444
    internal static float MainAspect => MainWidth / (float)MainHeight; //2.388888888888889
    internal static ManualLogSource Logger { get; private set; }
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    internal static ConfigEntry<bool> CinematicLetterboxing { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.main.systemWidth; //3440
    private static ConfigEntry<bool> RemoveAllPillarboxes { get; set; }
    internal static int MainHeight => Display.main.systemHeight; //1440
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }

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

    internal static ConfigEntry<Misc.PlatformHelper.Platform> ConfigPlatform { get; private set; }

    private static ConfigEntry<string> VSyncSetting { get; set; }

    private static ConfigEntry<string> Resolution { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    private static ConfigEntry<int> TargetFramerate { get; set; }

    internal static ConfigEntry<bool> SkipIntroCinematic { get; private set; }

    private static bool RequiresUpdate { get; set; }


    internal static void EnablePillarboxes()
    {
        if (RemoveAllPillarboxes.Value) return;
        PillarBoxes.SetActive(true);
        Canvas.ForceUpdateCanvases();
    }

    internal static void DisablePillarboxes()
    {
        PillarBoxes.SetActive(false);
        Canvas.ForceUpdateCanvases();
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = MainWidth,
            height = MainHeight,
            refreshRate = MaxRefresh
        };
        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    public override void Load()
    {
        Logger = Log;
        var customRates = MergeUnityRefreshRates();

        ClassInjector.RegisterTypeInIl2Cpp<AspectEnforcer>();
        ClassInjector.RegisterTypeInIl2Cpp<ScaleForcer>();

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll();

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        SkipIntroCinematic = Config.Bind("02. In-game Cinematics", "Skip Intro Cinematic", false,
            new ConfigDescription(
                "Enable to automatically skip the intro cinematic when starting the game.",
                null,
                new ConfigurationManagerAttributes { Order = 93 }));

        CinematicLetterboxing = Config.Bind("02. In-game Cinematics", "Enable Letterboxing", true,
            new ConfigDescription(
                "Controls the black bar artwork displayed during in-game (not pre-rendered) cinematic sequences. " +
                "When enabled, the game's built-in cinematic black bars are shown. When disabled, these bars are removed for an unobstructed view.",
                null,
                new ConfigurationManagerAttributes { Order = 92 }));

        HUDAspect = Config.Bind("03. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 91 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAll();

        RemoveAllPillarboxes = Config.Bind("03. UI", "Remove All Pillarboxes", false,
            new ConfigDescription(
                "Removes the decorative artwork that frames certain menus (pillarboxes). This does not affect in-game content or cinematics, " +
                "as they are already displayed without these frames. Enabling this may reveal unintended visual elements in menus.",
                null,
                new ConfigurationManagerAttributes { Order = 90 }));
        RemoveAllPillarboxes.SettingChanged += (_, _) => UpdateAll();

        ConfigPlatform = Config.Bind("03. UI", "Platform", Misc.PlatformHelper.Platform.Xbox,
            new ConfigDescription(
                "Force the game to display button prompts for a specific platform:\n" +
                "- Xbox: Displays Xbox-style button prompts (e.g., A, B, X, Y). Leave it set to Xbox to disable forced prompts and allow automatic detection.\n" +
                "- PlayStation: Displays PlayStation-style button prompts (e.g., Square, Circle, X, Triangle).\n" +
                "- Switch: Displays Nintendo Switch-style button prompts (e.g., A, B, X, Y, matching Switch layout).\n" +
                "Use this setting to override automatic detection or match your controller preference.",
                null,
                new ConfigurationManagerAttributes { Order = 89 }));

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        RequiresUpdate = true;
        
        UpdateAll();

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

    internal static void UpdateAll()
    {
        UpdateQuality();
        UpdateDisplay();
        UpdateExtendingRects();
        UpdatePillars();
        UpdateCameras();
    }

    private static void UpdateDisplay()
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Logger.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;


        if (!RequiresUpdate) return;
        
        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRate);
        Logger.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");
        RequiresUpdate = false;
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
            rect.m_maxW = Utils.GetHudRes(rect.m_maxH);

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