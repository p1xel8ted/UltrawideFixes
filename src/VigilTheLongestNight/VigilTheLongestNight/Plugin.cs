namespace VigilTheLongestNight;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.vigilthelongestnight.ultrawide";
    private const string PluginName = "Vigil The Longest Night Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    public const float NativeAspect = 16f / 9f;

    internal static float WidthDifference => MainWidth - NormalWidth; //3440 - 2560 = 880
    private static float NormalWidth => MainHeight * NativeAspect; //1440 * 16/9 = 2560
    private static float MainAspectRatio => (float)MainWidth / MainHeight;

    internal static float PositiveScaleFactor => MainAspectRatio / NativeAspect;
    private static int MainWidth => Screen.width;
    private static int MainHeight => Screen.height;
    private static ConfigEntry<bool> DisplayMapFog { get; set; }
    internal static ConfigEntry<bool> ShowMainResolutionOnly { get; set; }
    internal static ManualLogSource Log { get; private set; }
    internal static ConfigEntry<bool> SpanHUD { get; private set; }
    public static float CurrentAspect => Screen.width / (float)Screen.height;
    public static float NegativeScaleFactor => NativeAspect / MainAspectRatio;

    public void Awake()
    {
        Log = Logger;

        ShowMainResolutionOnly = Config.Bind("01. Resolution", "Show Main Resolution Only", true, new ConfigDescription("Show only your displays native resolution in the settings menu.", null, new ConfigurationManagerAttributes { Order = 91 }));

        SpanHUD = Config.Bind("02. UI", "Span HUD", true, new ConfigDescription("Span the HUD", null, new ConfigurationManagerAttributes { Order = 87 }));
        SpanHUD.SettingChanged += (_, _) => ConfigChanges();

        DisplayMapFog = Config.Bind("03. Map", "Display Map Fog", true, new ConfigDescription("Display the fog on the map", null, new ConfigurationManagerAttributes { Order = 96 }));
        DisplayMapFog.SettingChanged += (_, _) => ConfigChanges();

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static void ConfigChanges()
    {
        UpdateComponents();
        ToggleMapFog();
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        ConfigChanges();
    }
    
    private static void ToggleMapFog()
    {
        var fog = GameObject.Find("GameUI/Map/UI_MAP_TELEPORT(Clone)/LAYER");
        if (!fog) return;
        
        var fogRects = UnityUtility.findAllChildR_Force(fog, "RECT_PARENT");
        foreach (var rect in fogRects)
        {
            rect.transform.localScale = new Vector3(1f, PositiveScaleFactor, 1f);
            rect.SetActive(DisplayMapFog.Value);
        }
    }

    internal static void UpdateComponents()
    {
        //dialog backgrounds
        var bg1 = GameObject.Find("GameUI/MovieText/UI_MOVIE_TEXT(Clone)/BG/BG (1)");
        if (bg1) bg1.transform.localScale = new Vector3(1000f, 1, 1);
        var bg2 = GameObject.Find("GameUI/MovieText/UI_MOVIE_TEXT(Clone)/BG/BG (2)");
        if (bg2) bg2.transform.localScale = new Vector3(1000f, 1, 1);

        //map borders
        var gradient = GameObject.Find("GameUI/Map/UI_MAP_TELEPORT(Clone)/Gradient");
        if (gradient)
        {
            gradient.SetActive(false);
        }
    }
}