using ShadowOfTheNinjaReborn;
using UnityStandardAssets.ImageEffects;

namespace TheNinjaSaviors;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.theninjasaviors.ultrawide";
    private const string PluginName = "The Ninja Saviors: Return of the Warriors Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    internal static int MainWidth => Display._mainDisplay.systemWidth;
    internal static int MainHeight => Display._mainDisplay.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    internal static float ScaleFactor => CurrentAspect / (16f / 9f);
    internal static float CurrentAspect => MainWidth / (float)MainHeight;
    internal static ConfigEntry<bool> RunInBackground { get; private set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ManualLogSource Logger { get; set; }
    public static float NativeAspect => 16f / 9f;

    public override void Load()
    {
        Logger = Log;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) => { Patches.UpdateDisplay(); };

        RunInBackground = Config.Bind("02. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 99 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("02. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 98 }));
        
        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        Patches.RunFixes();
    }
}