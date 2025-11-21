[assembly: MelonInfo(typeof(Mod), "Blue Prince Ultra-Wide", "0.1.0", "p1xel8ted")]

namespace BluePrince;

public class Mod : MelonMod
{
#if DEBUG
    internal const int NativeDisplayWidth = 3200;
    internal const int NativeDisplayHeight = 900;
#else
    internal static readonly int NativeDisplayWidth = Display.main.systemWidth; //3440
    internal static readonly int NativeDisplayHeight = Display.main.systemHeight; //1440
#endif


    internal static readonly int MaxRefresh = Screen.resolutions.Max(a => a.refreshRate); //144
    internal static float MainAspect => NativeDisplayWidth / (float)NativeDisplayHeight; //2.3888


    internal static MelonPreferences_Entry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static MelonPreferences_Entry<bool> Vignette { get; private set; }
    internal static MelonPreferences_Entry<bool> ChromaticAberration { get; private set; }
    internal static MelonPreferences_Entry<bool> LensDistortion { get; private set; }
    internal static MelonPreferences_Entry<bool> AmbientOcclusion { get; private set; }
    internal static MelonPreferences_Entry<bool> Bloom { get; private set; }
    internal static MelonPreferences_Entry<bool> ColorGrading { get; private set; }
    internal static MelonPreferences_Entry<bool> MotionBlur { get; private set; }
    internal static MelonPreferences_Entry<bool> Grain { get; private set; }
    internal static float NativeAspectRatio => 16f / 9f; //1.7777

    private static void UpdateCanvasScalers()
    {
        foreach (var scaler in Patches.Patches.Scalers.Where(scaler => scaler))
        {
            Patches.Patches.ProcessScaler(scaler);
        }
    }


    public override void OnInitializeMelon()
    {
        var category = MelonPreferences.CreateCategory("BluePrinceUltraWideFix", "Blue Prince Ultra-Wide Settings");
        category.SetFilePath(Path.Combine("UserData", "Blue Prince Ultra-Wide Settings.cfg"), true, true);

        // Display Entries
        FullScreenModeConfig = category.CreateEntry("FullScreenMode", FullScreenMode.FullScreenWindow,
            "Full Screen Mode",
            "Select how the game displays on your screen:\n" +
            "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
            "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
            "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
            "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
            "- Windowed: Runs the game in a resizable window.");
        FullScreenModeConfig.OnEntryValueChanged.Subscribe((_, _) => { UpdateDisplay(); });

        Vignette = category.CreateEntry("Vignette", false,
            "Vignette Effect",
            "Enable or disable the vignette post-processing effect.");
        Vignette.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        ChromaticAberration = category.CreateEntry("ChromaticAberration", false,
            "Chromatic Aberration Effect",
            "Enable or disable the chromatic aberration post-processing effect.");
        ChromaticAberration.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        LensDistortion = category.CreateEntry("LensDistortion", false,
            "Lens Distortion Effect",
            "Enable or disable the lens distortion post-processing effect.");
        LensDistortion.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        AmbientOcclusion = category.CreateEntry("AmbientOcclusion", true,
            "Ambient Occlusion Effect",
            "Enable or disable the ambient occlusion post-processing effect.");
        AmbientOcclusion.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        Bloom = category.CreateEntry("Bloom", true,
            "Bloom Effect",
            "Enable or disable the bloom post-processing effect.");
        Bloom.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        ColorGrading = category.CreateEntry("ColorGrading", true,
            "Color Grading Effect",
            "Enable or disable the color grading post-processing effect.");
        ColorGrading.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        MotionBlur = category.CreateEntry("MotionBlur", true,
            "Motion Blur Effect",
            "Enable or disable the motion blur post-processing effect.");
        MotionBlur.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        Grain = category.CreateEntry("Grain", true,
            "Grain Effect",
            "Enable or disable the grain post-processing effect.");
        Grain.OnEntryValueChanged.Subscribe((_, _) => { Patches.Patches.UpdatePostProcessing(); });

        MelonLogger.Msg($"Plugin Blue Prince R Ultra-Wide is loaded!");

        category.SaveToFile(false);
        MelonPreferences.Save();
    }


    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);

        UpdateCanvasScalers();
        UpdateDisplay();
        DisableAllMaskingPlanes();
        Patches.Patches.UpdatePostProcessing();
    }

    private static void DisableAllMaskingPlanes()
    {
        var maskingPlanes = Resources.FindObjectsOfTypeAll<GameObject>().Where(go => go.name.Contains("MaskingPlane", StringComparison.InvariantCultureIgnoreCase));
        foreach (var plane in maskingPlanes)
        {
            if (plane.name.EndsWith("1") || plane.name.EndsWith("2"))
            {
                plane.SetActive(false);
            }
        }
    }

    private static void UpdateDisplay()
    {
#if DEBUG
        Screen.SetResolution(NativeDisplayWidth, NativeDisplayHeight, FullScreenMode.Windowed, MaxRefresh);
#else
        Screen.SetResolution(NativeDisplayWidth, NativeDisplayHeight, FullScreenModeConfig.Value, MaxRefresh);
#endif
        MelonLogger.Msg($"Resolution updated: {NativeDisplayWidth}x{NativeDisplayHeight}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={MaxRefresh}Hz");
    }
}