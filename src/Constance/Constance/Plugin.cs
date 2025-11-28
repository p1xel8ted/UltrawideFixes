namespace Constance;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.constance.ultrawide";
    private const string PluginName = "Constance Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    
    internal static ManualLogSource Log { get; private set; }
    internal static int CurrentWidth => Screen.currentResolution.width;
    internal static int CurrentHeight => Screen.currentResolution.height;
    internal static float CurrentAspect => (float)CurrentWidth / CurrentHeight;
    internal static float NativeAspect => 16f / 9f;
    internal static float PositiveScaleFactor => CurrentAspect / NativeAspect;

    private void Awake()
    {
        Log = Logger;

        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        var blockers = Resources.FindObjectsOfTypeAll<CConSelectionLayer_Blocker>();
        foreach (var blocker in blockers)
        {
            var image = blocker.GetComponent<Image>();
            if (image && image.name == "Overlay Black")
            {
                image.transform.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
            }
        }
    }
}