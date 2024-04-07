using System.Reflection;
using Il2CppInterop.Runtime.Injection;
using Snufkin.AspectRatio;
using Snufkin.Misc;
using UnityEngine.Events;

namespace Snufkin;

/// <summary>
/// Game is extremely sensitive to Harmony Patches. If you get random CTD's with no error, remove the Harmony patch you just added.
/// Need to ensure Unity Log Listening is set to False in BepInEx.
/// Custom build is also required to enable support for Ubisoft+ version. See GitHub repo. https://github.com/p1xel8ted/UltrawideFixes/tree/main/PrinceOfPersiaTheLostCrown/Custom%20BepInEx
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.snufkin.ultrawide";
    private const string PluginName = "Snufkin: Melody of Moominvalley Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static float TwentyOneNineAspect => 21.5f / 9f; //21:9 is actually 43:18
    internal static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    internal static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;

    internal static float MainAspectRatio => (float) MainWidth / MainHeight;

    internal static float BaseAspectRatio => 16f / 9f;
    internal static Vector2 SimplifiedBaseAspect => new(16f, 9f);
    internal static Vector2 SimplifiedMainAspect => new(SimplifiedWidth, SimplifiedHeight);

    internal static bool SuperWide => MainAspectRatio > TwentyOneNineAspect;

    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ManualLogSource LOG { get; private set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }

    public override void Load()
    {
        LOG = Log;
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;


        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            AspectRatioFixes.RunDisplayFixes();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            AspectRatioFixes.RunDisplayFixes();
        };
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
    
    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AspectRatioFixes.RunDisplayFixes();
        AspectRatioFixes.RunCameraFixes();
        AspectRatioFixes.RunVideoPlayerFixes();
        AspectRatioFixes.CameraRatioRestrictorFixes();
        AspectRatioFixes.RunMeshFixes();
        
        var mountains = GameObject.Find("Level/Statics/Vista/Backdrop ViewPoint/Backdrop Ending Vertical Slice");
        if (mountains)
        {
            var x = mountains.transform.localScale.x * PositiveScaleFactor;
            mountains.transform.localScale = mountains.transform.localScale with {x = x};
            Plugin.LOG.LogMessage($"Mountains Scale: {mountains.transform.localScale.x}");
        }

        var copyRight = GameObject.Find("Canvas - UI Controller/Safe Area/Main menu/Main Menu/Content/Menu/Copyright line");
        if (copyRight)
        {
            copyRight.SetActive(false);
        }

        var streamer = GameObject.Find("Canvas - UI Controller/Safe Area/Main menu/Main Menu/Content/Menu/Streamer Info");
        if (streamer)
        {
            streamer.SetActive(false);
        }
    }
}