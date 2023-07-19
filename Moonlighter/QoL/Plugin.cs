using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace QoL
{
    /// <summary>
    /// This is the main class for the QoL plugin. It initializes the configuration for the plugin and applies Harmony patches.
    /// </summary>
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.moonlighter.qol";
        private const string PluginName = "QoL";
        private const string PluginVersion = "0.1.0";

        /// <summary>
        /// Logger used to log messages to the BepInEx log.
        /// </summary>
        public static ManualLogSource LOG;

        /// <summary>
        /// Configuration entry for enabling or disabling intro skipping.
        /// </summary>
        internal static ConfigEntry<bool> SkipIntros { get; private set; }

        /// <summary>
        /// Configuration entry for enabling or disabling direct loading into the game.
        /// </summary>
        internal static ConfigEntry<bool> LoadStraightIntoGame { get; private set; }

        /// <summary>
        /// The Awake method is called when the plugin is loaded. It initializes the configuration and applies Harmony patches.
        /// </summary>
        private void Awake()
        {
            // Configuration initialization and patching

            SkipIntros = Config.Bind("1. General", "Skip Intros", true, new ConfigDescription("Skips the intros and the gamepad recommended screen.", null,new ConfigurationManagerAttributes{Order = 98}));
            LoadStraightIntoGame = Config.Bind("1. General", "Load Straight Into Game", true, new ConfigDescription("Loads straight into the game upon menu load.", null, new ConfigurationManagerAttributes{Order = 97}));
            LOG = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(LOG);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            LOG.LogWarning($"Plugin {PluginName} is loaded!");
        }

        /// <summary>
        /// This method is called when the plugin is destroyed.
        /// </summary>
        private void OnDestroy()
        {
            LOG.LogError("I've been destroyed!");
        }

        /// <summary>
        /// This method is called when the plugin is disabled.
        /// </summary>
        private void OnDisable()
        {
            LOG.LogError("I've been disabled!");
        }
    }
}