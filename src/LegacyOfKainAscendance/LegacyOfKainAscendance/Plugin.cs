namespace LegacyOfKainAscendance;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.legacyofkainascendance.ultrawide";
    private const string PluginName = "Legacy of Kain Ascendance Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }
    public static ConfigFile ConfigFile { get; private set; }
    internal static ConfigEntry<bool> SkipIntros { get; private set; }
    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    internal static ConfigEntry<bool> Notifications { get; private set; }

    private void Awake()
    {
        Log = Logger;
        ConfigFile = Config;

        SkipIntros = Config.Bind("01. General", "Skip Intros", true,
            new ConfigDescription("Skip startup logos, videos, and warning screens.", null,
                new ConfigurationManagerAttributes { Order = 10 }));

        RunInBackground = Config.Bind("01. General", "Run In Background", true,
            new ConfigDescription("Keep the game running when alt-tabbed or unfocused.", null,
                new ConfigurationManagerAttributes { Order = 9 }));

        Notifications = Config.Bind("01. General", "Notifications", true,
            new ConfigDescription("Show on-screen notifications when new post-processing effects are registered.", null,
                new ConfigurationManagerAttributes { Order = 8 }));

        Application.runInBackground = RunInBackground.Value;
        RunInBackground.SettingChanged += (_, _) => Application.runInBackground = RunInBackground.Value;

        DisplayMetrics.Initialize();

        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Logger.LogInfo($"Plugin {PluginName} initialized. Resolution: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, Aspect: {DisplayMetrics.MainAspect:F4}, IsWider: {DisplayMetrics.IsWiderThanNative}");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Log.LogInfo($"Scene loaded: {scene.name} (mode={mode})");
        Log.LogInfo($"  Screen: {Screen.width}x{Screen.height}, fullScreenMode={Screen.fullScreenMode}");
        Log.LogInfo($"  Display: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, aspect={DisplayMetrics.MainAspect:F4}, isWider={DisplayMetrics.IsWiderThanNative}");

        // Log all cameras in the scene for diagnostics
        foreach (var cam in Resources.FindObjectsOfTypeAll<Camera>())
        {
            var rt = cam.targetTexture;
            Log.LogInfo($"  Camera '{cam.name}' | active={cam.gameObject.activeInHierarchy} enabled={cam.enabled} | ortho={cam.orthographic} orthoSize={cam.orthographicSize:F2} | aspect={cam.aspect:F4} | pixelRect={cam.pixelRect} | targetTexture={(rt != null ? $"{rt.name} ({rt.width}x{rt.height})" : "null")} | rect={cam.rect}");
        }

        if (DisplayMetrics.IsWiderThanNative)
        {
            // Disable border/letterbox overlays
            foreach (var go in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                if (go.name is not ("Border Canvas" or "Letterbox")) continue;
                Log.LogInfo($"  Disabling '{go.name}' (was active={go.activeSelf})");
                go.SetActive(false);
            }

            // Widen ~16:9 camera render textures to ultrawide
            foreach (var cam in Resources.FindObjectsOfTypeAll<Camera>())
            {
                var rt = cam.targetTexture;
                if (!rt) continue;

                var rtAspect = (float)rt.width / rt.height;
                if (rtAspect is > 1.9f or < 1.5f)
                {
                    Log.LogInfo($"  Camera '{cam.name}': RT {rt.width}x{rt.height} (aspect={rtAspect:F4}) - skipped (not ~16:9)");
                    continue;
                }

                var newWidth = Mathf.RoundToInt(rt.height * DisplayMetrics.MainAspect);
                if (rt.width == newWidth)
                {
                    Log.LogInfo($"  Camera '{cam.name}': RT {rt.width}x{rt.height} - already ultrawide");
                    continue;
                }

                Log.LogInfo($"  Camera '{cam.name}': resizing RT {rt.width}x{rt.height} -> {newWidth}x{rt.height}");
                rt.Release();
                rt.width = newWidth;
                rt.Create();

                var aspectBefore = cam.aspect;
                cam.ResetAspect();
                Log.LogInfo($"  Camera '{cam.name}': aspect {aspectBefore:F4} -> {cam.aspect:F4} (after ResetAspect)");
            }

            // Stretch RawImages that display camera RTs to fill the screen
            foreach (var ri in Resources.FindObjectsOfTypeAll<RawImage>())
            {
                if (ri.texture is not RenderTexture riRt) continue;

                var rect = ri.rectTransform;
                var anchorsBefore = $"min={rect.anchorMin} max={rect.anchorMax}";
                var offsetsBefore = $"oMin={rect.offsetMin} oMax={rect.offsetMax}";
                rect.anchorMin = Vector2.zero;
                rect.anchorMax = Vector2.one;
                rect.offsetMin = Vector2.zero;
                rect.offsetMax = Vector2.zero;
                Log.LogInfo($"  Stretched RawImage '{ri.name}' on '{ri.gameObject.name}' | RT={riRt.width}x{riRt.height} | was: {anchorsBefore} {offsetsBefore}");
            }
        }

        Volumes.ScanAndApply();
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, FullScreenMode.FullScreenWindow);
    }
}
