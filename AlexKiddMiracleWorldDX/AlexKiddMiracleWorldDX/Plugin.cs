using System;
using System.Linq;
using System.Reflection;
using AlexKiddMiracleWorldDX.MonoBehaviours;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Epic.OnlineServices.Ecom;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

namespace AlexKiddMiracleWorldDX;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.alexkiddmiracleworlddx.ultrawidefix";
    private const string PluginName = "Alex Kidd in Miracle World DX Ultra-Wide Fix";
    private const string PluginVersion = "0.1.0";

    internal static ConfigEntry<bool> DisableColorOverlay { get; set; }
    internal static ConfigEntry<bool> SkipDevLogos { get; set; }
    internal static ConfigEntry<bool> KeepUICentered { get; set; }

    internal static float TwentyOneNineAspect => 21f / 9f;
    internal static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    internal static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;

    internal static float MainAspectRatio => (float) MainWidth / MainHeight;

    internal static float BaseAspectRatio => 16f / 9f;
    internal static Vector2 SimplifiedBaseAspect => new(16f, 9f);
    internal static Vector2 SimplifiedMainAspect => new(SimplifiedWidth, SimplifiedHeight);

    internal static bool SuperWide => MainAspectRatio > TwentyOneNineAspect;

    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ManualLogSource LOG { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }

    private void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        DisableColorOverlay = Config.Bind("03. Post Processing", "Disable Color Overlay", true, "Disables the color overlay/illumination in game.");
        SkipDevLogos = Config.Bind("00. General", "Skip Dev Logos", true, "Skips the developer logos at the start of the game.");
        KeepUICentered = Config.Bind("02. UI", "Keep UI Centered", true, "Keeps the UI (and other screens) at the original 16:9 ratio.");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");

        var introTransition = Resources.FindObjectsOfTypeAll<Transform>().FirstOrDefault(a => a.name == "Transition_remake");
        if (introTransition)
        {
            introTransition.transform.localScale = introTransition.transform.localScale with {y = PositiveScaleFactor};
        }
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }


    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Plugin.LOG.LogInfo($"Scene loaded: {scene.name}");
        UpdateDisplay();

        var introTransition = Resources.FindObjectsOfTypeAll<Transform>().FirstOrDefault(a => a.name == "Transition_remake");
        if (introTransition)
        {
            introTransition.transform.localScale = introTransition.transform.localScale with {y = PositiveScaleFactor};
        }

        if (scene.name.Equals("interstitial_map", StringComparison.OrdinalIgnoreCase))
        {
            if (Camera.main)
            {
                var ppc = Camera.main.gameObject.TryAddComponent<PixelPerfectCamera>();
                ppc.name= "InterstitialMapPixelPerfectCamera";
                ppc.assetsPPU = 35;
                ppc.stretchFill = true;
                ppc.refResolutionX = 640;
                ppc.refResolutionY = 360;
                ppc.cropFrameX = true;
                ppc.cropFrameY = true;
                ppc.pixelSnapping = true;
                ppc.m_Camera = Camera.main;
                ppc.offscreenRTSize.Set(0,0);
                ppc.gameObject.SetActive(true);
            }
        }

        if (scene.name.Equals("level_01"))
        {
            var floorRemake = Resources.FindObjectsOfTypeAll<Tilemap>().FirstOrDefault(a => a.name == "FloorRemake");
            if (floorRemake)
            {
                var floor = floorRemake.transform.parent.transform.FindFirstChildByName("Floor");
                if (floor)
                {
                    floor.localScale = floor.localScale with {x = PositiveScaleFactor};
                }

                var grass = floorRemake.transform.parent.transform.FindFirstChildByName("HierbaRemake");
                if (grass)
                {
                    grass.localScale = grass.localScale with {x = PositiveScaleFactor};
                }

                floorRemake.transform.localScale = floorRemake.transform.localScale with {x = PositiveScaleFactor};

                var destroyables = floorRemake.transform.parent.transform.FindFirstChildByName("Destroyable");
                foreach (var destroyable in destroyables.GetComponentsInChildren<Transform>())
                {
                    destroyable.localPosition = destroyable.localPosition with {x = destroyable.localPosition.x * PositiveScaleFactor};
                }
            }
        }
    }
}