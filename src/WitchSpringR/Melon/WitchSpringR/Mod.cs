[assembly: MelonInfo(typeof(WitchSpringR.Mod), "WitchSpring R Ultra-Wide", "0.1.5", "p1xel8ted")]

namespace WitchSpringR;

public class Mod : MelonMod
{
    private const string Logo = "#Logo";
    private const string TitleSceneName = "#Title";

    public enum TargetFrameRateOption
    {
        Sixty = 60,
        OneTwenty = 120,
        OneEighty = 180,
        TwoForty = 240,
        ThreeSixty = 360,
        MaxRefresh = -1
    }


    public enum VsyncOption
    {
        Disabled,
        EveryRefresh,
        EverySecondRefresh
    }

    internal static readonly int NativeDisplayWidth = Display.main.systemWidth; //3440
    internal static readonly int NativeDisplayHeight = Display.main.systemHeight; //1440
    internal static readonly int MaxRefresh = Screen.resolutions.Max(a => a.refreshRate); //144
    internal static float MainAspect => NativeDisplayWidth / (float)NativeDisplayHeight; //2.3888
    internal static Rect CameraRect => new(0, 0, NativeDisplayWidth, NativeDisplayHeight); //(0,0,3440,1440)
    private static float NormalWidth => NativeDisplayHeight * 16f / 9f; //2560
    internal static float PositiveScaleFactor => NativeDisplayWidth / NormalWidth; //1.34375
    internal static MelonPreferences_Entry<bool> Bloom { get; private set; }
    internal static MelonPreferences_Entry<bool> ToneMapping { get; private set; }
    internal static MelonPreferences_Entry<bool> Vignette { get; private set; }
    internal static MelonPreferences_Entry<bool> SpanHud { get; private set; }
    internal static MelonPreferences_Entry<bool> ShowSkirt { get; private set; }
    internal static MelonPreferences_Entry<bool> ShowHat { get; private set; }
    internal static MelonPreferences_Entry<bool> ShowRobe { get; private set; }
    internal static MelonPreferences_Entry<bool> ShowStaff { get; private set; }
    internal static MelonPreferences_Entry<bool> DepthOfField { get; private set; }
    internal static MelonPreferences_Entry<int> FieldOfView { get; private set; }

    private static MelonPreferences_Entry<bool> RunInBackground { get; set; }
    private static MelonPreferences_Entry<bool> MuteInBackground { get; set; }

    internal static MelonPreferences_Entry<FullScreenMode> FullScreenModeConfig { get; private set; }

    private static MelonPreferences_Entry<bool> CorrectFixedUpdateRate { get; set; }

    private static WriteOnceInt OriginalFixedDeltaTime { get; } = new();

    private static MelonPreferences_Entry<TargetFrameRateOption> TargetFramerate { get; set; }
    internal static float NativeAspectRatio => 16f / 9f; //1.7777
    private static float CameraWidth => NativeDisplayHeight * NativeAspectRatio; //2560
    internal static float BlackBarSize => (NativeDisplayWidth - CameraWidth) / 2f; //440

    private static MelonPreferences_Entry<VsyncOption> VSyncSetting { get; set; }
    private static bool RequiresUpdate { get; set; }

    public static MelonPreferences_Entry<bool> FieldMenu { get; private set; }

    private static void UpdateCanvasScalers()
    {
        foreach (var scaler in Patches.Patches.Scalers.Where(scaler => scaler))
        {
            Patches.Patches.ProcessScaler(scaler);
        }
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

    public override void OnInitializeMelon()
    {
        ClassInjector.RegisterTypeInIl2Cpp<LeftHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<RightHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<MiniMapMover>();
        ClassInjector.RegisterTypeInIl2Cpp<ClothsToggler>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceInt>();
        ClassInjector.RegisterTypeInIl2Cpp<FieldMenuToggler>();

        var category = MelonPreferences.CreateCategory("WitchSpringUltrawideFix", "WitchSpring R Ultra-Wide Settings");
        category.SetFilePath(Path.Combine("UserData", "WitchSpring R Ultra-Wide Settings.cfg"), true, true);

        // Display Entries
        FullScreenModeConfig = category.CreateEntry("FullScreenMode", FullScreenMode.FullScreenWindow,
            "Full Screen Mode",
            "Select how the game displays on your screen:\n" +
            "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
            "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
            "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
            "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
            "- Windowed: Runs the game in a resizable window.");
        FullScreenModeConfig.OnEntryValueChanged.Subscribe((_, _) => { UpdateAll(true); });

        VSyncSetting = category.CreateEntry("VSyncSetting", VsyncOption.Disabled,
            "VSync Setting",
            "Control how VSync synchronizes the game's frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
            "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
            "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
            "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.");
        VSyncSetting.OnEntryValueChanged.Subscribe((_, _) => { UpdateAll(true); });

        TargetFramerate = category.CreateEntry("TargetFramerate", TargetFrameRateOption.MaxRefresh,
            "Target Framerate",
            "Set the target framerate - this will only function when VSYNC is OFF (0)");
        TargetFramerate.OnEntryValueChanged.Subscribe((_, _) => { UpdateAll(true); });

        CorrectFixedUpdateRate = category.CreateEntry("CorrectFixedUpdateRate", true,
            "Modify Physics Rate",
            "Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This may effect the game in unexpected ways.");
        CorrectFixedUpdateRate.OnEntryValueChanged.Subscribe((_, _) => { UpdateFixedDeltaTime(); });

        // Post Processing Entries
        Bloom = category.CreateEntry("Bloom", true,
            "Bloom",
            "Enable Bloom");
        Bloom.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.VolumeUpdateRequired = true; });

        ToneMapping = category.CreateEntry("ToneMapping", true,
            "Tone Mapping",
            "Enable Tone Mapping");
        ToneMapping.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.VolumeUpdateRequired = true; });

        Vignette = category.CreateEntry("Vignette", true,
            "Vignette",
            "Enable Vignette");
        Vignette.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.VolumeUpdateRequired = true; });

        DepthOfField = category.CreateEntry("DepthOfField", true,
            "Depth of Field",
            "Enable Depth of Field");
        DepthOfField.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.VolumeUpdateRequired = true; });

        // HUD Entries
        SpanHud = category.CreateEntry("SpanHud", true,
            "Span HUD",
            "Spans the HUD across the entire screen.");

        // Camera Entries
        FieldOfView = category.CreateEntry("FieldOfView", Mathf.RoundToInt(24 * PositiveScaleFactor),
            "Field of View",
            "Increase or decrease the field of view of the camera.");
        FieldOfView.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdateCamera(); });

        // Cloths Entries
        ShowStaff = category.CreateEntry("ShowStaff", true,
            "Show Staff",
            "Show Staff");

        ShowSkirt = category.CreateEntry("ShowSkirt", true,
            "Show Skirt",
            "Show Skirt");

        ShowHat = category.CreateEntry("ShowHat", true,
            "Show Hat",
            "Show Hat");

        ShowRobe = category.CreateEntry("ShowRobe", true,
            "Show Robe",
            "Show Robe");

        // Background Entries
        RunInBackground = category.CreateEntry("RunInBackground", true,
            "Run In Background",
            "Allows the game to run even when not in focus.");

        MuteInBackground = category.CreateEntry("MuteInBackground", false,
            "Mute In Background",
            "Mutes the game's audio when it is not in focus.");

        // Field Menu Entry
        FieldMenu = category.CreateEntry("FieldMenu", true,
            "Field Menu",
            "Toggles visibility of the field menu");

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        MelonLogger.Msg($"Plugin WitchSpring R Ultra-Wide is loaded!");

        category.SaveToFile(false);
        MelonPreferences.Save();
    }


    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);

        if (CorrectFixedUpdateRate.Value)
        {
            Time.fixedDeltaTime = 1f / MaxRefresh;
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        MelonLogger.Msg($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);
        if (sceneName == Logo)
        {
            SceneManager.LoadScene(TitleSceneName);
        }

        Patches.Patches.VolumeUpdateRequired = true;

        UpdateFixedDeltaTime();
        UpdateCanvasScalers();
        UpdateAll(true);
    }

    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value

        QualitySettings.vSyncCount = (int)VSyncSetting.Value;


        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? (int)TargetFramerate.Value : -1;

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;


        Screen.SetResolution(NativeDisplayWidth, NativeDisplayHeight, FullScreenModeConfig.Value, MaxRefresh);

        MelonLogger.Msg($"Resolution updated: {NativeDisplayWidth}x{NativeDisplayHeight}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={MaxRefresh}Hz");

        RequiresUpdate = false;
    }
}