using BepInEx.Configuration;
using TheWildAtHeart.Misc;

namespace TheWildAtHeart;

[Harmony]
[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    internal static float CurrentAspectRatio => MainWidth / (float)MainHeight;
    internal static ManualLogSource Log { get; private set; }

    private static int MainWidth => Screen.width;
    private static int MainHeight => Screen.height;

    internal static float NativeDisplayAspectRatio => Display.main.systemWidth / (float)Display.main.systemHeight;

    private static List<string> HUDAspects { get; } =
    [
        "16:10",
        "16:9",
        "21:9",
        "21.5:9",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    internal static ConfigEntry<string> HUDAspect { get; set; }
    internal static ConfigEntry<bool> Vignette { get; set; }

    private void Awake()
    {
        Log = Logger;
        Vignette = Config.Bind("01. UI", "Vignette", true,
            new ConfigDescription(
                "Enable or disable the vignette effect around the screen edges.",
                null,
                new ConfigurationManagerAttributes { Order = 92 }));
        Vignette.SettingChanged += (_, _) => UpdateVignette();
        HUDAspect = Config.Bind("01. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 93 }));
        HUDAspect.SettingChanged += (_, _) => LayoutController.UpdateLayoutControllers();

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);

        Log.LogInfo($"Plugin {Const.PluginName} is loaded!");
    }

    private static void UpdateVignette()
    {
        BHUDManager.Instance?.mainVignette?.SetActive(Vignette.Value);
    }

    private static void UpdateCanvasScalers()
    {
        var scalers = Patches.Patches.Scalers.ToList();
        foreach (var scaler in scalers)
        {
            Patches.Patches.ProcessScaler(scaler);
        }
    }


    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        if (a.name == "Bootup")
        {
            SceneManager.LoadScene("Title");
        }

        // Log.LogWarning($"Scene loaded: {a.name}, updating CanvasScalers.");
        LayoutController.UpdateLayoutControllers();
        UpdateCanvasScalers();
        UpdateVignette();
    }
}