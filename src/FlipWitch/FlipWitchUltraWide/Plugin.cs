using TMPro;

namespace FlipWitchUltraWide;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.flipwitch.ultrawide";
    private const string PluginName = "Flip Witch Ultra-Wide";
    private const string PluginVersion = "0.1.2";

    private static bool FirstTimeMainMenu = true;

    private readonly static WriteOnce<float> OriginalHudPosition = new();
    private static float BaseAspect => 16f / 9f;
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int SixteenNineWidth => MainHeight * 16 / 9;
    private static float CurrentAspect => MainWidth / (float) MainHeight;
    internal static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    private static ConfigEntry<bool> LimitHudToSixteenByNine { get; set; }

    internal static ConfigEntry<bool> LimitInGameMenuToSixteenByNine { get; private set; }

    internal static ConfigEntry<bool> SkipIntros { get; private set; }
    internal static ManualLogSource LOG { get; private set; }
    private static Transform HUDTransform { get; set; }

    private void Awake()
    {
        LOG = Logger;

        DisplayToUse = Config.Bind("General", "Display To Use", 0, new ConfigDescription("The display to use for the game. 0 is generally the main.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        SkipIntros = Config.Bind("General", "Skip Intros", true, "Skip the intro stuff and go straight to the main menu.");
        LimitHudToSixteenByNine = Config.Bind("HUD", "Limit HUD to 16:9", false, "Limit the hud to 16:9 aspect ratio");
        LimitHudToSixteenByNine.SettingChanged += (_, _) =>
        {
            AdjustHUD();
        };

        LimitInGameMenuToSixteenByNine = Config.Bind("In Game Menu", "Limit In-Game Menu to 16:9", false, "Limit the in game menu to 16:9 aspect ratio");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void AdjustHUD()
    {
        HUDTransform = GameObject.Find("Switch Database/Main UI/Ingame HUD").transform;
        OriginalHudPosition.Value = HUDTransform.position.x;
        if (LimitHudToSixteenByNine.Value)
        {
            HUDTransform.position = HUDTransform.position with {x = OriginalHudPosition.Value + (MainWidth - SixteenNineWidth) / 2f};
        }
        else
        {
            HUDTransform.position = HUDTransform.position with {x = OriginalHudPosition.Value};
        }
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        UpdateDisplay();
        AdjustHUD();

        var mainMenuBackground = GameObject.Find("Switch Database/Main Camera Holder/Main Camera/Background Manager");
        if (mainMenuBackground)
        {
            mainMenuBackground.transform.localScale = mainMenuBackground.transform.localScale with {x = PositiveScaleFactor, y = PositiveScaleFactor};
        }

        if (!__arg0.name.Equals("MainMenu")) return;

        var grid = GameObject.Find("MainMenu/Grid");
        if (!grid) return;

        grid.TryGetComponent<RectTransform>(out var rect);
        if (!rect)
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