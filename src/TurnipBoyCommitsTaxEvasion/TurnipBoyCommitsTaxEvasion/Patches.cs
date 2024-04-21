namespace TurnipBoyCommitsTaxEvasion;

[HarmonyPatch]
public static class Patches
{

    private static MenuButtonController GitHubButton { get; set; }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LifeBase), nameof(LifeBase.Move))]
    public static void LifeBase_Move(ref LifeBase __instance, ref float _multiplier)
    {
        if (__instance is PlayerController)
        {
            _multiplier = 1f * Plugin.MoveSpeed.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsManager), nameof(OptionsManager.SetLanguage))]
    public static void OptionsManager_SetLanguage()
    {
        if (GitHubButton != null)
        {
            GitHubButton.text.text = GetText();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuController), nameof(MenuController.Start))]
    public static void MenuController_Start(ref MenuController __instance)
    {
        var gitHubButton = Object.Instantiate(__instance.creditsButton, __instance.creditsButton.transform.parent);
        gitHubButton.transform.SetAsLastSibling();
        gitHubButton.transform.SetSiblingIndex(gitHubButton.transform.GetSiblingIndex() - 1);
        gitHubButton.name = "GitHubButton";
        GitHubButton = gitHubButton.GetComponent<MenuButtonController>();
        var localize = gitHubButton.GetComponentsInChildren<Localize>();
        foreach (var local in localize)
        {
            Object.DestroyImmediate(local);
        }
        GitHubButton.text.text = GetText();
        gitHubButton.SetActive(true);

        var ue = new UnityEvent();
        ue.AddListener(OnPressed);

        GitHubButton.OnPressed = ue;
    }

    private static string GetText()
    {
        return LocalizationManager.GetLanguageCode(LocalizationManager.CurrentLanguage) switch
        {
            "en" => "github" // English
            ,
            "fr" => "github" // French
            ,
            "de" => "github" // German
            ,
            "it" => "github" // Italian
            ,
            "pt-BR" => "github" // Brazilian Portuguese
            ,
            "es-US" => "github" // US Spanish
            ,
            "ru" => "гитхаб" // Transliterated in Russian
            ,
            "zh" => "github" // Simplified Chinese, usually not translated
            ,
            "ko" => "깃허브" // Transliterated in Korean
            ,
            "zh-TW" => "github" // Traditional Chinese, usually not translated
            ,
            "ja" => "ぎっとはぶ" // Transliterated in Japanese
            ,
            _ => "github"
        };
    }
    
    private static void OnPressed()
    {
        Application.OpenURL("https://github.com/p1xel8ted/UltrawideFixes");
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(DialoguePopupController), nameof(DialoguePopupController.Update))]
    public static void DialoguePopupController_Update(ref DialoguePopupController __instance)
    {
        var newScale = new Vector3(Plugin.NpcChatDialogScale.Value, Plugin.NpcChatDialogScale.Value, 1f);
        __instance.rootRectTransform.localScale = newScale;

        __instance.rootRectTransform.localPosition = Plugin.NpcChatDialogPosition.Value > 0
            ? new Vector3(0, -Plugin.NpcChatDialogPosition.Value, 0)
            : new Vector3(0, Plugin.NpcChatDialogPosition.Value, 0);
    }
}