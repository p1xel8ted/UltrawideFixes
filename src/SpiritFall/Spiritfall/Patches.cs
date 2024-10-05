namespace Spiritfall;

[HarmonyPatch]
public class Patches
{
    private static readonly List<GameObject> CleanMenuObjects = [];
    private static readonly List<GameObject> InGameCleanMenuObjects = [];
    private static readonly List<GameObject> InGameMenuQuitToDesktop = [];

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsModel), nameof(SettingsModel.SupportedWindowedResolutions), MethodType.Getter)]
    [HarmonyPatch(typeof(SettingsModel), nameof(SettingsModel.SupportedFullscreenResolutions), MethodType.Getter)]
    public static void SettingsModel_SupportedResolutions(ref SettingsModel __instance, ref List<Vector2Int> __result)
    {
        var resolutions = new List<Vector2Int>();
        var res = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
        resolutions.Add(res);
        __instance.supportedResolutions = resolutions;

        var refreshRates = new List<int> { Plugin.MaxRefresh };
        __instance.supportedFPS = refreshRates;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CompanyLogo), nameof(CompanyLogo.Update))]
    private static void CompanyLogo_Update(ref CompanyLogo __instance)
    {
        __instance.logo.gameObject.SetActive(false);
        __instance.loadingAnimation.SetActive(true);
        __instance.enabled = false;
    }

    private static void CleanMainMenu()
    {
        foreach (var obj in CleanMenuObjects.Where(obj => obj).Where(obj => obj))
        {
            obj.SetActive(!Plugin.CleanMainMenu.Value);
        }
    }

    private static void CleanInGameMenu()
    {
        foreach (var obj in InGameCleanMenuObjects.Where(obj => obj).Where(obj => obj))
        {
            obj.SetActive(!Plugin.CleanInGameMenu.Value);
        }
        
        foreach (var obj in InGameMenuQuitToDesktop.Where(obj => obj).Where(obj => obj))
        {
            obj.SetActive(Plugin.QuitToDesktop.Value);
        }
    }

    internal static void RunCleanMenu()
    {
        CleanMainMenu();
        CleanInGameMenu();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ExtendedUIPanel), nameof(ExtendedUIPanel.OnEnable))]
    private static void ExtendedUIPanel_Start(ref ExtendedUIPanel __instance)
    {
        var inGameMenuMarketingButtons = __instance.transform.Find("Content/MarketingButtons");
        if (inGameMenuMarketingButtons)
        {
            InGameCleanMenuObjects.Add(inGameMenuMarketingButtons.gameObject);
        }
        
        var inGameMenuFeedbackButton = __instance.transform.Find("Content/Feedback");
        if (inGameMenuFeedbackButton)
        {
            InGameCleanMenuObjects.Add(inGameMenuFeedbackButton.gameObject);
        }
        
        var inGameMenuQuitToDesktop = __instance.transform.Find("Content/Quit");
        if (inGameMenuQuitToDesktop)
        {
            InGameMenuQuitToDesktop.Add(inGameMenuQuitToDesktop.gameObject);
        }
        
        var banner = __instance.transform.Find("Banner");
        if (banner)
        {
            CleanMenuObjects.Add(banner.gameObject);
        }

        var discordButton = __instance.transform.Find("SideMenu/DiscordButton");
        if (discordButton)
        {
            CleanMenuObjects.Add(discordButton.gameObject);
        }

        var twitterButton = __instance.transform.Find("SideMenu/TwitterButton");
        if (twitterButton)
        {
            CleanMenuObjects.Add(twitterButton.gameObject);
        }

        var feedbackButton = __instance.transform.Find("SideMenu/FeedbackButton");
        if (feedbackButton)
        {
            CleanMenuObjects.Add(feedbackButton.gameObject);
        }

        var roadMapButton = __instance.transform.Find("SideMenu/Content/Roadmap");
        if (roadMapButton)
        {
            CleanMenuObjects.Add(roadMapButton.gameObject);
        }

        var creditsButton = __instance.transform.Find("SideMenu/Content/Credits");
        if (creditsButton)
        {
            CleanMenuObjects.Add(creditsButton.gameObject);
        }

        RunCleanMenu();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsInitializer), nameof(SettingsInitializer.Start))]
    private static void SettingsInitializer_Start(ref SettingsInitializer __instance)
    {
        var feedbackForm = __instance.transform.Find("FeedbackForm");
        if (feedbackForm)
        {
            CleanMenuObjects.Add(feedbackForm.gameObject);
        }

        var versionText = __instance.transform.Find("VersionUI");
        if (versionText)
        {
            CleanMenuObjects.Add(versionText.gameObject);
        }

        RunCleanMenu();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsMenuController), nameof(SettingsMenuController.OnWindowedModeChanged))]
    [HarmonyPatch(typeof(SettingsMenuController), nameof(SettingsMenuController.OnBorderlessChanged))]
    private static void SettingsMenuController_OnWindowedModeChanged(ref SettingsMenuController __instance, ref bool value) => value = true;
}