using System;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using SaonaStudios.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

namespace DeathOrTreatUltrawideFix;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.deathortreat.ultrawide";
    private const string PluginName = "Death or Treat Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const float BaseAspectRatio = 16f / 9f;

    internal static float BlackBarSize => WidthDifference / 2f;
    internal static float WidthDifference => MainWidth - NormalWidth;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    internal static float TwentiesAspectRatio => 21.5f / 9f;
    internal static float NormalWidth => MainHeight * BaseAspectRatio;
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }

    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<PostProcessLayer.Antialiasing> AntiAliasing { get; private set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }

    internal static ConfigEntry<bool> ScreenConfiner { get; set; }

    internal const float SuperWideAspectRatio = 32f / 9f;
    private static ConfigEntry<int> DisplayToUse { get; set; }

    internal static ManualLogSource Log { get; set; }

    // internal static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    internal static ConfigEntry<float> CustomScale { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static ConfigEntry<bool> MenuCarriage { get; private set; }
    internal static ConfigEntry<int> CameraZoom { get; private set; }

    private readonly static int Fade = Animator.StringToHash("Fade");

    private void Awake()
    {
        Log = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 108}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 107}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        CorrectFixedUpdateRate = Config.Bind("02. Performance", "Correct Physics Update Rate", true,
            new ConfigDescription("Adjusts the physics update rate to minimum amount to reduce camera judder based on your refresh rate. Not all games like this setting being adjusted.", null, new ConfigurationManagerAttributes {Order = 106}));
        CorrectFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedRate();
        };

        UseRefreshRateForFixedUpdateRate = Config.Bind("02. Performance", "Use Refresh Rate For Physics Update Rate", true,
            new ConfigDescription("Sets the physics update rate based on the monitor's refresh rate for smoother gameplay. If you're playing on a potato, this may have performance impacts.", null, new ConfigurationManagerAttributes {Order = 105}));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) =>
        {
            UpdateFixedRate();
        };

        CustomScale = Config.Bind("03. UI", "Custom UI Scale", PositiveScaleFactor, new ConfigDescription("Custom scale for the game's UI.", new AcceptableValueRange<float>(0.5f, 2f), new ConfigurationManagerAttributes {Order = 104}));
        MenuCarriage = Config.Bind("03. UI", "Menu Carriage", true, new ConfigDescription("Toggle visibility of the carriage in the main menu.", null, new ConfigurationManagerAttributes {Order = 103}));
        MenuCarriage.SettingChanged += (_, _) =>
        {
            if (Patches.Carro)
            {
                Patches.Carro.gameObject.SetActive(MenuCarriage.Value);
            }
        };
        CameraZoom = Config.Bind("04. Camera", "Camera Zoom", 5, new ConfigDescription("Camera Zoom", new AcceptableValueRange<int>(-19, 20), new ConfigurationManagerAttributes {Order = 1022}));
        ScreenConfiner = Config.Bind("04. Camera", "Screen Confiner", true, new ConfigDescription("Constrains the camera to the screen size.", null, new ConfigurationManagerAttributes {Order = 102}));

        Vignette = Config.Bind("05. Post-Processing", "Vignette", true, new ConfigDescription("Enable Vignette effect on the game screen.", null, new ConfigurationManagerAttributes {Order = 101}));

        AntiAliasing = Config.Bind("05. Post-Processing", "Anti-Aliasing", PostProcessLayer.Antialiasing.TemporalAntialiasing, new ConfigDescription("Enable Anti-Aliasing effect on the game screen. May have little (or no) effect being a 2D game.", null, new ConfigurationManagerAttributes {Order = 100}));

        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += SceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }

    private static void UpdateDisplay()
    {
        Application.runInBackground = RunInBackground.Value;
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        UpdateFixedRate();
    }

    private static void UpdateFixedRate()
    {
        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / MaxRefresh;
                Log.LogInfo($"Physics update rate set to {MaxRefresh}Hz");
            }
            else
            {
                var denominator = FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
                Time.fixedDeltaTime = 1f / denominator;
                Log.LogInfo($"Physics update rate set to {denominator}Hz");
            }
        }
        else
        {
            Time.fixedDeltaTime = 0.02f; //Game default  
        }
    }

    private static void SceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        UpdateDisplay();

        if (!arg0.name.Contains("Logo")) return;

        Resources.UnloadUnusedAssets();
        GC.Collect();
        SceneHandler.instance._anim.SetTrigger(Fade);
        SceneHandler.instance.loadingGO.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}