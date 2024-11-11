using Il2CppVampireSurvivors.Objects;
using MelonLoader;
using MelonLoader.Preferences;
using VampireSurvivors.WindowsAPI;

[assembly: MelonInfo(typeof(VampireSurvivors.Plugin), "Vampire Survivors Ultra-Wide (Melon)", "0.2.0", "p1xel8ted")]

namespace VampireSurvivors;

public class Plugin : MelonMod
{
    // private const string PluginGuid = "p1xel8ted.vampiresurvivors.ultrawide";
    private const string PluginName = "Vampire Survivors Ultra-Wide (Melon)";
    // private const string PluginVersion = "0.2.0";

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

    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspect => MainWidth / (float)MainHeight; //2.388888888888889

    internal static float PositiveScaleFactor => MainAspect / NativeAspectRatio; //1.493827160493827

    // private static ManualLogSource Logger { get; set; }
    private static MelonPreferences_Entry<bool> RunInBackground { get; set; }
    public static MelonPreferences_Entry<bool> ExpandSpawnZone { get; set; }
    private static MelonPreferences_Entry<bool> MuteInBackground { get; set; }
    private static MelonPreferences_Entry<int> CustomRefreshRate { get; set; }
    private static MelonPreferences_Entry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static MelonPreferences_Entry<int> DisplayToUse { get; private set; }
    internal static MelonPreferences_Entry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.main.systemHeight; //1440
    private static MelonPreferences_Entry<bool> CorrectFixedUpdateRate { get; set; }
    private static MelonPreferences_Entry<bool> UseCustomRefreshRate { get; set; }

    private static MelonPreferences_Entry<int> TargetFramerate { get; set; }


    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static WindowPositioner WindowPositioner { get; set; }

    private static float NativeAspectRatio => 1.6f;

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = true;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static MelonPreferences_Category ConfigCategory { get; set; }

    public override void OnInitializeMelon()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WindowPositioner>();

        base.OnInitializeMelon();


        ConfigCategory = MelonPreferences.CreateCategory("UW", "Ultra-Wide Settings");
        FullScreenModeConfig = ConfigCategory.CreateEntry("FullScreenMode", FullScreenMode.FullScreenWindow, FullScreenMode.FullScreenWindow.ToString(), "Select the full screen mode.");
        FullScreenModeConfig.OnEntryValueChanged.Subscribe(UpdateDisplay);

        DisplayToUse = ConfigCategory.CreateEntry("DisplayToUse", 0, "Select the display to use.");
        DisplayToUse.OnEntryValueChanged.Subscribe(UpdateDisplay);

        var customRates = MergeUnityRefreshRates();

        // Create validators for entries that need to have acceptable values
        var customRateValidator = new ValueRange<int>(customRates.Min(), customRates.Max());

        UseCustomRefreshRate = ConfigCategory.CreateEntry("UseCustomRefreshRate", false, "Use a custom refresh rate.");
        UseCustomRefreshRate.OnEntryValueChanged.Subscribe(UpdateSettings);

        CustomRefreshRate = ConfigCategory.CreateEntry("CustomRefreshRate", MaxRefresh, "Set a custom refresh rate.", validator: customRateValidator);
        CustomRefreshRate.OnEntryValueChanged.Subscribe(UpdateSettings);

        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Windows))
        {
            WindowPositioner = new WindowPositioner();
            WindowPositioner.Start();
        }

        TargetFramerate = ConfigCategory.CreateEntry("TargetFramerate", MaxRefresh, "Set the target framerate", validator: customRateValidator);
        TargetFramerate.OnEntryValueChanged.Subscribe(UpdateSettings);

        CorrectFixedUpdateRate = ConfigCategory.CreateEntry("CorrectFixedUpdateRate", true, "Adjusts the fixed update rate to reduce camera judder.");
        CorrectFixedUpdateRate.OnEntryValueChanged.Subscribe(UpdateSettings);

        UseRefreshRateForFixedUpdateRate = ConfigCategory.CreateEntry("UseRefreshRateForFixedUpdateRate", true, "Sets the fixed update rate based on the monitor's refresh rate.");
        UseRefreshRateForFixedUpdateRate.OnEntryValueChanged.Subscribe(UpdateSettings);


        ExpandSpawnZone = ConfigCategory.CreateEntry("ExpandSpawnZone", true, "Expands the spawn zone to fit the new resolution.");
        ExpandSpawnZone.OnEntryValueChanged.Subscribe(UpdateStageRects);


        RunInBackground = ConfigCategory.CreateEntry("RunInBackground", true, "Allows the game to run even when not in focus.");
        RunInBackground.OnEntryValueChanged.Subscribe(UpdateSettings);

        MuteInBackground = ConfigCategory.CreateEntry("MuteInBackground", false, "Mutes the game's audio when it is not in focus.");

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        ConfigCategory.SaveToFile(false);

        MelonLogger.Msg("Vampire Survivors Ultra-Wide (Melon) has been initialized.");
    }

    private static void UpdateDisplay(int arg1, int arg2)
    {
        UpdateAll();
    }

    private static void UpdateAll()
    {
        UpdateDisplay();
        UpdateFixedDeltaTime();
        Application.runInBackground = RunInBackground.Value;
        MelonPreferences.Save();
    }

    private static void UpdateDisplay(FullScreenMode arg1, FullScreenMode arg2)
    {
        UpdateAll();
    }

    private static void UpdateSettings(int arg1, int arg2)
    {
        UpdateAll();
    }

    private static void UpdateSettings(bool b, bool b1)
    {
        UpdateAll();
    }

    private static void UpdateStageRects(bool arg1, bool arg2)
    {
        UpdateStageRects();
    }


    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);
        MelonLogger.Msg($"Scene loaded: {sceneName}");
    }


    private static void UpdateStageRects()
    {
        var stage = Resources.FindObjectsOfTypeAll<Stage>().FirstOrDefault();
        if (stage)
        {
            MelonLogger.Msg($"Updating stage {stage.name} spawn zone.");
            stage.InitRects();
        }
    }

    private static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
        var targetRefresh = UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
        if (targetRefresh <= 0)
        {
            MelonLogger.Warning("Custom refresh rate is set to 0 or less. Skipping update.");
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
            MelonLogger.Msg("Games physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / targetRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Misc.Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }

        MelonLogger.Msg($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
    }

    private static void UpdateDisplay()
    {
        WindowPositioner?.Start();

        Application.runInBackground = RunInBackground.Value;

        Display.displays[DisplayToUse.Value].Activate();

        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);

        Application.targetFrameRate = TargetFramerate.Value;
    }
}