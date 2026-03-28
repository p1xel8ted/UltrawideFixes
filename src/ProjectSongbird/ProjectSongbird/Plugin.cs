using Il2CppInterop.Runtime.Injection;

namespace ProjectSongbird;

/// <summary>
/// BepInEx 6 IL2CPP entry point for the Project Songbird ultrawide fix.
/// Initializes display metrics, binds configuration entries, applies Harmony patches,
/// forces native ultrawide resolution, and enforces Hor+ gate fit on all cameras per scene load.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.projectsongbird.ultrawide";
    private const string PluginName = "Project Songbird Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    /// <summary>Shared logger instance used by all plugin classes.</summary>
    internal static ManualLogSource Logger { get; private set; }

    /// <summary>Overrides the game's FOV setting. Range 35-150. Default is the game's base FOV (35) scaled for the display aspect ratio.</summary>
    internal static ConfigEntry<int> FieldOfView { get; private set; }

    /// <summary>
    /// Plugin entry point. Initializes display metrics, binds config entries, applies all Harmony patches,
    /// registers the scene load handler, and forces the initial resolution.
    /// </summary>
    public override void Load()
    {
        Logger = Log;
        
        ClassInjector.RegisterTypeInIl2Cpp<ScaleEnforcer>();
        
        DisplayMetrics.Initialize();

        var scaledDefault = Mathf.RoundToInt(35 * DisplayMetrics.ScaleFactor);
        FieldOfView = Config.Bind("01. General", "Field of View", scaledDefault,
            new ConfigDescription($"Overrides the game's FOV setting. Default ({scaledDefault}) is the game's base FOV (35) scaled for your display aspect ratio. The game's range is 35-90, but this allows up to 150. Zoom/aim/run transitions are unaffected.",
                new AcceptableValueRange<int>(35, 150),
                new ConfigurationManagerAttributes { Order = 100 }));
        // ReSharper disable once RedundantLambdaParameterType - explicit types required for IL2CPP delegate resolution
        FieldOfView.SettingChanged += (object _, EventArgs _) => Patches.FovChanged = true;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}");

#if DEBUG
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.Windowed);
#else
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow, DisplayMetrics.MaxRefresh);
#endif
    }

    /// <summary>
    /// Runs on every scene load. Re-enforces the native ultrawide resolution, forces Hor+ gate fit on
    /// all active cameras, enforces aspect ratio on all video players, and scales video background
    /// Image parents to fill the ultrawide viewport.
    /// </summary>
    private static void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Logger.LogInfo($"Scene loaded: {scene.name}.");
        
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow, DisplayMetrics.MaxRefresh);

        foreach (var cam in Camera.allCameras)
        {
            if (!cam) continue;
            cam.EnforceGateFit();
        }

        foreach (var vp in Resources.FindObjectsOfTypeAll<VideoPlayer>())
        {
            if (!vp) continue;
            vp.EnforceAspectRatio();

            // Scale the video player's parent Image to fill ultrawide (guarded against double-scaling)
            var parent = vp.transform.parent;
            if (!parent) continue;
            if (!Utils.ScaledTransforms.Add(parent.GetInstanceID())) continue;
            var image = parent.GetComponent<Image>();
            if (image)
            {
                var newX = parent.localScale.x * DisplayMetrics.ScaleFactor;
                parent.localScale = new Vector3(newX, parent.localScale.y, parent.localScale.z);
                image.LogInfo($"Scaled video background '{vp.name}'");
            }
        }
    }
}