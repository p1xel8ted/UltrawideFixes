using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MiniShoot;

/// <summary>
/// A BepInEx plugin for MiniShoot Adventures that introduces ultra-wide screen support,
/// adjusting game display settings for an improved gaming experience on ultra-wide monitors.
/// </summary>
[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.minishootadventures.ultrawide";
    private const string PluginName = "Minishoot` Adventures Ultra-Wide!";
    private const string PluginVersion = "0.1.0";

    // Dynamic properties to calculate aspect ratios and screen dimensions based on the current display.
    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    private static float BaseAspectRatio => 16f / 9f;
    internal static float BlackBarSize => (MainWidth - NormalWidth) / 2f;
    private static float NormalWidth => MainHeight * BaseAspectRatio;
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;

    // Configuration options for running the game in background and muting it when out of focus.
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ManualLogSource Log { get; set; }

    // Configuration options for post-processing effects, including vignette and lens distortion, as well as adjustments for contrast and saturation.
    private static ConfigEntry<bool> Vignette { get; set; }
    internal static ConfigEntry<bool> LensDistortion { get; private set; }
    private static ConfigEntry<int> Contrast { get; set; }
    private static ConfigEntry<int> Saturation { get; set; }

/// <summary>
/// Configures post-processing effect settings upon plugin initialization. It binds configuration options to user preferences and sets up event handlers to adjust these effects dynamically based on user input.
/// </summary>
private void Awake()
{
    Log = Logger;
    
    // Other initializations for running in background and muting in background.
    RunInBackground = Config.Bind("01. General", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.",null, new ConfigurationManagerAttributes {Order = 99}));
    MuteInBackground = Config.Bind("01. General", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.",null, new ConfigurationManagerAttributes {Order = 98}));
    
    // Setup and bind post-processing effect configuration options.
    Contrast = Config.Bind("02. Post-Processing", "Contrast", 0, new ConfigDescription("Adjusts the contrast level of the game's post-processing effects.", new AcceptableValueRange<int>(-100, 100), new ConfigurationManagerAttributes {Order = 97}));
    Saturation = Config.Bind("02. Post-Processing", "Saturation", 0, new ConfigDescription("Adjusts the saturation level of the game's post-processing effects.", new AcceptableValueRange<int>(-100, 100), new ConfigurationManagerAttributes {Order = 96}));
    LensDistortion = Config.Bind("02. Post-Processing", "Lens Distortion", true, new ConfigDescription("Toggles lens distortion in the game's post-processing effects.",null, new ConfigurationManagerAttributes {Order = 95}));
    Vignette = Config.Bind("02. Post-Processing", "Vignette", true, new ConfigDescription("Toggles vignette in the game's post-processing effects.",null, new ConfigurationManagerAttributes {Order = 94}));

    // Event handlers to update post-processing settings when configuration changes.
    LensDistortion.SettingChanged += (_, _) => RunEffectFixes();
    Contrast.SettingChanged += (_, _) => RunEffectFixes();
    Saturation.SettingChanged += (_, _) => RunEffectFixes();
    Vignette.SettingChanged += (_, _) => RunEffectFixes();
    
    Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;
    
    Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    Log.LogInfo($"Plugin {PluginName} is loaded!");
}

    /// <summary>
    /// Called when a scene is loaded to adjust display settings according to the user's configuration.
    /// </summary>
    /// <param name="scene">The loaded scene.</param>
    /// <param name="mode">The mode in which the scene was loaded.</param>
    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RunDisplayFixes();
        RunEffectFixes();
    }

    /// <summary>
    /// Adjusts the game's post-processing settings dynamically based on the current configuration options. This method is called whenever a scene is loaded and when the relevant configuration options change.
    /// </summary>
    private static void RunEffectFixes()
    {
        // Adjust post-processing settings based on user configuration.
        if (PostProcessManager.vignette)
        {
            PostProcessManager.vignette.active = Vignette.Value;   
        }
        if (PostProcessManager.colorAdjust)
        {
            PostProcessManager.colorAdjust.contrast.value = Contrast.Value;
            PostProcessManager.colorAdjust.saturation.value = Saturation.Value;
        }
        if (PostProcessManager.lensDist)
        {
            PostProcessManager.SetSettingLensDist(LensDistortion.Value);
        }
    }

    /// <summary>
    /// Applies display setting fixes based on user settings and plugin calculations,
    /// such as adjusting screen resolution and frame rate.
    /// </summary>
    private static void RunDisplayFixes()
    {
        // Determine fullscreen mode based on user settings.
        var fs = UserSettingsData.Fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
        // Set screen resolution, fullscreen mode, and refresh rate.
        Screen.SetResolution(MainWidth, MainWidth, fs, MaxRefresh);
        // Apply target frame rate and background run setting.
        Application.targetFrameRate = UserSettingsData.FPSLimit;
        Application.runInBackground = RunInBackground.Value;
    }
}