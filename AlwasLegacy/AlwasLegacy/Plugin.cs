using System;
using System.Linq;
using System.Reflection;
using AlwasLegacy.AspectRatio;
using AlwasLegacy.Misc;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlwasLegacy;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{

    private const string PluginGuid = "p1xel8ted.alwaslegacy.ultrawidefix";
    private const string PluginName = "Alwa's Legacy Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    internal static float TwentyOneNineAspect => 21.5f / 9f; //21:9 is actually 43:18
    // internal static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    // internal static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;

    internal static float WidthDifference => MainWidth - NormalWidth; //3440 - 2560 = 880
    internal static float BlackBarSize => WidthDifference / 2f; //880 / 2 = 440
    private static float NormalWidth => MainHeight * BaseAspectRatio; //1440 * 16/9 = 2560

    internal static float MainAspectRatio => (float) MainWidth / MainHeight;

    internal const float BaseAspectRatio = 16f / 9f;
    // internal static Vector2 SimplifiedBaseAspect => new(16f, 9f);
    // internal static Vector2 SimplifiedMainAspect => new(SimplifiedWidth, SimplifiedHeight);
    internal const float SuperWideAspectRatio = 32f / 9f;
    internal static bool SuperWide => MainAspectRatio > TwentyOneNineAspect;

    internal static ConfigEntry<bool> SpannedHUD { get; private set; }

    internal static ConfigEntry<int> EdgeDetectionBuffer { get; private set; }
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    // internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ManualLogSource LOG { get; private set; }
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }

    public void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            RunDisplayFixes();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            RunDisplayFixes();
        };

        EdgeDetectionBuffer = Config.Bind("02. Edge Detection", "Buffer", 3, new ConfigDescription("Setting this value controls how early/late the camera will move when it detects the player near the edge of the screen.", new AcceptableValueRange<int>(1, 50)));
        SpannedHUD = Config.Bind("03. HUD", "Spanned HUD", true, new ConfigDescription("Span the HUD across the entire screen"));
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }
    
    internal static void RunDisplayFixes()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }
    
    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        var fadeImage = GameObject.Find("Canvas/FadeImage");
        if (fadeImage)
        {
            fadeImage.gameObject.SetActive(false);
        }

        var sceneParallax = GameObject.Find("Scene/Parallax");
        if (sceneParallax)
        {
            if (SuperWide)
            {
                sceneParallax.transform.localScale = sceneParallax.transform.localScale with {x = PositiveScaleFactor, y = PositiveScaleFactor};
            }
            else
            {
                sceneParallax.transform.localScale = sceneParallax.transform.localScale with {x = PositiveScaleFactor};
            }
        }

        var images = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in images)
        {
            if (image.name.Equals("BottomRightBG"))
            {
                image.gameObject.SetActive(false);
            }
        }
    }
}