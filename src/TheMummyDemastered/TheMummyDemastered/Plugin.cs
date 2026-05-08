namespace TheMummyDemastered;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.themummydemastered.ultrawide";
    private const string PluginName = "The Mummy Demastered Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }


    private void Awake()
    {
        Log = Logger;


        DisplayMetrics.Initialize();

        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        // The first splash scene (index 0) loads before our Harmony patches are installed, so its
        // SplashScreen.Start prefix doesn't fire. If a SplashScreen instance is already alive at Plugin.Awake
        // time, jump-start the next scene manually.
        foreach (var ss in Resources.FindObjectsOfTypeAll<SplashScreen>())
        {
            if (!ss.gameObject.scene.IsValid() || !ss.gameObject.activeInHierarchy) continue;
            Log.LogInfo($"Plugin.Awake: found early SplashScreen '{ss.name}' (NextScene='{ss.NextScene}'), skipping.");
            DynamicAssets.PreloadBundle("startup");
            SceneLoader.GotoScene(ss.NextScene, string.Empty, Vector2.zero, 1f, 0f);
            Transition.Snap();
        }

        Log.LogInfo($"Forcing native resolution {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight} fullscreen at startup.");
        Screen.SetResolution(DisplayMetrics.MainWidth, DisplayMetrics.MainHeight, true);

        Logger.LogInfo($"Plugin {PluginName} initialized. Native display: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}, aspect={DisplayMetrics.MainAspect:F4}, isWider={DisplayMetrics.IsWiderThanNative}");
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Log.LogInfo($"Scene loaded: {scene.name} (mode={mode}) | Screen: {Screen.width}x{Screen.height} fullScreen={Screen.fullScreen} | Native: {DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}");
    }
}