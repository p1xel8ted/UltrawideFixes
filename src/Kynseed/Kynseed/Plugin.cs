using System.Net.Mime;
using BepInEx.NET.Common;
using Microsoft.Xna.Framework.Audio;
using PeaksOfYore;

namespace Kynseed;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.peaksofyore.ultrawide";
    private const string PluginName = "Peaks of Yore Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    // internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    // internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    // internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    // internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Logger { get; set; }

   


    // private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    // {
    //     UpdateDisplay();
    // }

    internal static void UpdateDisplay()
    {
        // Display.displays[DisplayToUse.Value].Activate();
        // Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        // MediaTypeNames.Application.targetFrameRate = MaxRefresh;
    }

    public override void Load()
    {
        Logger = Log;
        // FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        // FullScreenModeConfig.SettingChanged += (_, _) =>
        // {
        //     UpdateDisplay();
        // };
        //
        //
        // DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        // DisplayToUse.SettingChanged += (_, _) =>
        // {
        //     UpdateDisplay();
        // };
        //
        // FieldOfView = Config.Bind("02. Camera", "Field of View", 50, new ConfigDescription("Increase or decrease the field of view of the camera. Default is 50% increases", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 100}));

        // RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        // RunInBackground.SettingChanged += (_, _) =>
        // {
        //     Application.runInBackground = RunInBackground.Value;
        // };
        //
        // MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));
        //
        // Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;
        //
        // SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }
}