namespace REPLACED;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    internal const string PluginGuid = "p1xel8ted.replaced.ultrawide";
    internal const string PluginName = "REPLACED Ultra-Wide";

    private const string PluginVersion = "0.1.0";

    // Debug override: simulate a 32:9 super-ultrawide window on a smaller (e.g. 3440x1440) monitor so we can
    // reproduce user-reported bugs that only occur above the game's ~21:9 native support. Set to false for release.
    internal const bool ForceDebugResolution = false;
    internal const int DebugWidth = 5120;
    internal const int DebugHeight = 1440;

    internal static readonly int MainWidth = ForceDebugResolution ? DebugWidth : Display.main.systemWidth;
    internal static readonly int MainHeight = ForceDebugResolution ? DebugHeight : Display.main.systemHeight;

    internal const float NativeMaxAspect = 21f / 9f; // 3440x1440 (2.389) and below skip the plugin; fixes trigger strictly above 21.5:9
    internal const float SuperUltraWideThreshold = NativeMaxAspect + 0.5f; //tolerance above native max to start with the "constrain to 16:9" option enabled by default
    internal static readonly float CurrentAspect = MainWidth / (float)MainHeight;

    internal const float FovStep = 0.02f; // 2% per keypress

    internal static ConfigEntry<bool> ConstrainHud;
    internal static ConfigEntry<float> FovMultiplier;
    internal static ConfigEntry<KeyCode> FovIncreaseKey;
    internal static ConfigEntry<KeyCode> FovDecreaseKey;
    internal static ConfigEntry<KeyCode> FovResetKey;
    internal static ManualLogSource BLog;

    public override void Load()
    {
        BLog = Log;

        ConstrainHud = Config.Bind("01. UI", "Constrain HUD to 16:9", CurrentAspect >= SuperUltraWideThreshold,
            new ConfigDescription("Constrains the in-game HUD to 16:9. Only relevant at aspects wider than 21:9."));

        FovMultiplier = Config.Bind("02. Camera", "FOV Multiplier", 1.0f,
            new ConfigDescription("Multiplier applied to the camera's vertical FOV at all aspects. 1.0 = authored FOV, 0.7 = ~30% zoom in, 1.3 = ~30% zoom out. Use to tune field-of-view to taste; especially useful at super-ultrawide aspects where the default Hor+ scaling produces a very wide horizontal view. Adjustable live via the keybinds below.",
                new AcceptableValueRange<float>(0.3f, 1.5f)));

        FovIncreaseKey = Config.Bind("02. Camera", "FOV Increase Key", KeyCode.PageUp,
            "Keybind to increase FOV multiplier by one step. Each press moves the multiplier toward 1.5 (wider view).");

        FovDecreaseKey = Config.Bind("02. Camera", "FOV Decrease Key", KeyCode.PageDown,
            "Keybind to decrease FOV multiplier by one step. Each press moves the multiplier toward 0.3 (narrower view).");

        FovResetKey = Config.Bind("02. Camera", "FOV Reset Key", KeyCode.Home,
            "Keybind to reset FOV multiplier back to 1.0 (authored FOV).");

        BLog.LogInfo($"{PluginName} v{PluginVersion} loading. Resolution={MainWidth}x{MainHeight}, aspect={CurrentAspect:F3} (native max {NativeMaxAspect:F3}, super-UW threshold {SuperUltraWideThreshold:F3}). ConstrainHud={ConstrainHud.Value}, FovMultiplier={FovMultiplier.Value:F2}.");

        if (CurrentAspect <= NativeMaxAspect)
        {
            BLog.LogInfo($"Aspect {CurrentAspect:F3} is at or below the game's native 21:9 support - most plugin patches will skip and the game's own ultrawide handling will apply.");
        }

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

#pragma warning disable CS0162 // ForceDebugResolution is a compile-time const toggle
        if (ForceDebugResolution)
        {
            BLog.LogInfo($"ForceDebugResolution=true: forcing windowed {MainWidth}x{MainHeight} for super-ultrawide testing.");
            Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.Windowed);
        }
#pragma warning restore CS0162
    }
}
