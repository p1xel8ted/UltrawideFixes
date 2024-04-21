using System.Linq;
using System.Reflection;
using AlexKiddMiracleWorldDX.AspectRatio;
using AlexKiddMiracleWorldDX.Constants;
using AlexKiddMiracleWorldDX.LevelFixes;
using AlexKiddMiracleWorldDX.Misc;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlexKiddMiracleWorldDX;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.alexkiddmiracleworlddx.ultrawidefix";
    private const string PluginName = "Alex Kidd in Miracle World DX Ultra-Wide Fix";
    private const string PluginVersion = "0.1.0";

    internal static ConfigEntry<bool> ColorOverlay { get; private set; }
    internal static ConfigEntry<bool> WaterColour { get; private set; }

    internal static ConfigEntry<bool> SkipDevLogos { get; set; }
    internal static ConfigEntry<bool> KeepUICentered { get; private set; }

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

    private void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        
        
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
        WaterColour = Config.Bind("03. Post Processing", "Water Colour", true, "Toggle the water colour effect in game.");
        ColorOverlay = Config.Bind("03. Post Processing", "Color Overlay", true, "Toggle the color overlay/illumination in game.");
        SkipDevLogos = Config.Bind("00. General", "Skip Splash Screens", true, "Skips the developer logos at the start of the game.");
        KeepUICentered = Config.Bind("02. UI", "Keep UI Centered", true, "Keeps the UI (and other screens) at the original 16:9 ratio.");
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        LevelFixes.MainMenu.FixBackground();

        AspectRatioFixes.RunDisplayFixes();
        AspectRatioFixes.RunCameraFixes();
        AspectRatioFixes.RunVideoPlayerFixes();
        MiscAssetFixes.RunWaterFixes();
        MiscAssetFixes.RunThunderFixes();
        MiscAssetFixes.RunParallaxFixes();
        MiscAssetFixes.RunPauseMenuFixes();
        MiscAssetFixes.RunIlluminationFixes();
        
            
        if (scene.name.Equals(Levels.level_1))
        {
            Level_1.RunFixes();
        }
        
        if (scene.name.Equals(Levels.level_2))
        {
            Level_2.RunFixes();
        }
        
        if (scene.name.Equals(Levels.level_5))
        {
            Level_5.RunFixes();
        }
        
        if (scene.name.Equals(Levels.level_6))
        {
            Level_6.RunFixes();
        }
        
        if (scene.name.Equals(Levels.level_7))
        {
            Level_7.RunFixes();
        }
        
        if (scene.name.Equals(Levels.level_7_extra))
        {
            Level_7_Extra.RunFixes();
        }
        

        LOG.LogInfo($"Scene loaded: {scene.name}");
        
        // var shopParent = GameObject.Find("ShopRemake");
        // var background = new GameObject("ShopBackground");
        //
        // background.transform.SetParent(shopParent.transform);
        //
        // var image = background.AddComponent<Image>();
        // background.AddComponent<Canvas>();
        //
        // image.color = Color.black;
        // background.transform.SetAsFirstSibling();
    }




}