namespace UnsightedUltrawide;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.unsighted.ultrawide";
    private const string PluginName = "UNSIGHTED Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private static float BaseAspect => 16f / 9f;
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int SixteenNineWidth => MainHeight * 16 / 9;
    private static float CurrentAspect => MainWidth / (float) MainHeight;
    internal static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static CanvasScaler GlobalCanvasScaler => GameObject.Find("GlobalGameManager/GlobalCanvas").GetComponent<CanvasScaler>();
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static ManualLogSource LOG { get; private set; }

    private void Awake()
    {
        LOG = Logger;

        DisplayToUse = Config.Bind("General", "Display To Use", 0, new ConfigDescription("The display to use for the game. 0 is generally the main.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) => Patches.ChangeResolution();
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        Patches.ChangeResolution();

        // main menu

        var topBackground = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/HeadAnimation/Degrade1");
        if (topBackground != null) topBackground.transform.localScale = topBackground.transform.localScale with {x = PositiveScaleFactor};

        var middleBackground = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/HeadAnimation/Degrade2");
        if (middleBackground != null) middleBackground.transform.localPosition = middleBackground.transform.position with {x = -330f};

        var menuButtons = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/PopupManager/TitleScreenPopup(Clone)/Menu");
        if (menuButtons != null) menuButtons.transform.localPosition = menuButtons.transform.localPosition with {x = -215f};


        // letterbox

        var letterbox = PseudoSingleton<PopupManager>.instance.popupLetterbox.transform;
        if (letterbox != null) letterbox.localScale = letterbox.localScale with {x = PositiveScaleFactor};

        // save menu

        var saves = GameObject.Find("GlobalGameManager/GlobalCanvas/GeneralPopups/PopupManager/SaveSlotPopup(Clone)/SlotsParent");
        if (saves != null) saves.transform.localPosition = saves.transform.localPosition with {x = -30f};
    }


}