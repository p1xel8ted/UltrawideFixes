using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using MoonlighterUltrawide;
using UltraWide.Utilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace UltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{

    private const string PluginGuid = "p1xel8ted.moonlighter.ultrawide";
    private const string PluginName = "Moonlighter Ultra-Wide";
    private const string PluginVersion = "0.1.3";

    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;

    internal static int MaxRefresh => Enumerable.Max(Screen.resolutions, r => r.refreshRate);
    private static ConfigEntry<int> DisplayToUse { get; set; }

    /// <summary>
    /// Logger used to log messages to the BepInEx log.
    /// </summary>
    public static ManualLogSource LOG { get; private set; }

    /// <summary>
    /// Final left door position for ultrawide resolution.
    /// </summary>
    internal readonly static WriteOnce<float> FinalLeftDoorPosition = new();

    /// <summary>
    /// Final right door position for ultrawide resolution.
    /// </summary>
    internal readonly static WriteOnce<float> FinalRightDoorPosition = new();

    /// <summary>
    /// Final left door entry position for ultrawide resolution.
    /// </summary>
    internal readonly static WriteOnce<float> FinalLeftDoorEntryPosition = new();

    /// <summary>
    /// Final right door entry position for ultrawide resolution.
    /// </summary>
    internal readonly static WriteOnce<float> FinalRightDoorEntryPosition = new();

    /// <summary>
    /// Configuration entry for enabling or disabling ultrawide resolution fixes.
    /// </summary>
    internal static ConfigEntry<bool> UltrawideFixes { get; private set; }

    /// <summary>
    /// Configuration entry for enabling or disabling dungeon corrections for ultrawide resolutions.
    /// </summary>
    internal static ConfigEntry<bool> CorrectDungeons { get; private set; }

    /// <summary>
    /// The Awake method is called when the plugin is loaded. It initializes the configuration and applies Harmony patches.
    /// </summary>
    public void Awake()
    {
        LOG = Logger;
        // Configuration initialization and patching
        UltrawideFixes = Config.Bind("01. General", "Correct Resolution Options", true, new ConfigDescription("Corrects the resolution options to include the current desktop resolution.", null, new ConfigurationManagerAttributes {Order = 100}));
        CorrectDungeons = Config.Bind("01. General", "Correct Dungeons", true, new ConfigDescription("Corrects the dungeons (mostly) to the match the screen resolution. Only way to achieve this is using scaling which stretches, so it will look average above 21:9.", null, new ConfigurationManagerAttributes {Order = 99}));
        DisplayToUse = Config.Bind("01. General", "Display To Use", 0, new ConfigDescription("The display to use for the game. 0 is generally the main.", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 98}));
        DisplayToUse.SettingChanged += (sender, args) => ChangeResolution();
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogWarning($"Plugin {PluginName} is loaded!");
    }

    private static void ChangeResolution()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        ChangeResolution();
    }
}