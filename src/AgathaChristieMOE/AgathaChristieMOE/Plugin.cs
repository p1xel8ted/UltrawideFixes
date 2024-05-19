namespace AgathaChristieMOE;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.agathachristiemoe.displaytweaks";
    private const string PluginName = "Agatha Christie - Murder on the Orient Express";
    private const string PluginVersion = "0.1.3";
    private const string BlackBorders = "BlackBorders";
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> MoveSpeed { get; private set; }
    internal static ConfigEntry<bool> AlwaysAllowedToRun { get; private set; }
    private static ManualLogSource LOG { get; set; }
    internal static ConfigEntry<int> FoVMultiplierPercent { get; private set; }


    private void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        FoVMultiplierPercent = Config.Bind("01. Field of View", "FOV Increase", 50, new ConfigDescription("Set the FOV multiplier percent. Default is a 50% increase on default.", new AcceptableValueRange<int>(0, 200), new {Order = 102, ShowAsPercent = true}));
        MoveSpeed = Config.Bind("02. Movement", "Move Speed", 50, new ConfigDescription("Set the walk speed multiplier. Default is 50% faster.", new AcceptableValueRange<int>(0, 100), new {Order = 99, ShowAsPercent = true}));

        AlwaysAllowedToRun = Config.Bind("02. Movement", "Always Allowed To Run", true, new ConfigDescription("Always allowed to run.", null, new ConfigurationManagerAttributes {Order = 98}));

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 90}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 89}));

        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }


    private static void RemoveBlackBorders()
    {
        foreach (var rect in Resources.FindObjectsOfTypeAll<RectTransform>())
        {
            if (rect.name.Equals(BlackBorders))
            {
                rect.gameObject.SetActive(false);
            }
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RemoveBlackBorders();
    }
}