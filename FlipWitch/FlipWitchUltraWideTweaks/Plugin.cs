namespace FlipWitchUltraWideTweaks;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.flipwitch.tweaks";
    private const string PluginName = "Flip Witch Ultra-Wide Tweaks";
    private const string PluginVersion = "0.1.0";

    private static bool FirstTimeMainMenu = true;
    private static float BaseAspect => 16f / 9f;
    internal static int MainWidth => Display.displays[0].systemWidth;
    internal static int MainHeight => Display.displays[0].systemHeight;
    internal static float CurrentAspect => MainWidth / (float) MainHeight;
    internal static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ManualLogSource LOG { get; set; }

    private void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        var mainMenuBackground = GameObject.Find("Switch Database/Main Camera Holder/Main Camera/Background Manager");
        if (mainMenuBackground != null)
        {
            mainMenuBackground.transform.localScale = mainMenuBackground.transform.localScale with {x = PositiveScaleFactor, y = PositiveScaleFactor};
        }
        
        if (!__arg0.name.Equals("MainMenu")) return;

        var grid = GameObject.Find("MainMenu/Grid");
        if (grid == null) return;

        Display.displays[0].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;

        grid.TryGetComponent<RectTransform>(out var rect);
        if (rect == null)
        {
            rect = grid.AddComponent<RectTransform>();
        }
        rect.anchorMin = new Vector2(0, 0);
        rect.anchorMax = new Vector2(1, 0);
        rect.pivot = new Vector2(0.5f, 0);


        grid.transform.localScale = grid.transform.localScale with {x = PositiveScaleFactor, y = PositiveScaleFactor};
        
        // no idea why this changes on menu reload, hacky fix, but meh
        if (FirstTimeMainMenu)
        {
            FirstTimeMainMenu = false;
            rect.anchoredPosition = new Vector2(51.776f, 101f);
        }
        else
        {
            rect.anchoredPosition = new Vector2(51.776f, 95.6551f);
        }
    }
}