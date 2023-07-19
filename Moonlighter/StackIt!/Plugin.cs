using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace StackIt
{
    /// <summary>
    /// This is the main class for the Stack It plugin. It initializes the configuration for the plugin and applies Harmony patches.
    /// </summary>
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.moonlighter.stackit";
        private const string PluginName = "StackIt!";
        private const string PluginVersion = "0.1.0";

        /// <summary>
        /// Logger used to log messages to the BepInEx log.
        /// </summary>
        public static ManualLogSource LOG;

        /// <summary>
        /// Configuration entry for enabling or disabling the Stack It feature.
        /// </summary>
        internal static ConfigEntry<bool> StackIt { get; private set; }

        /// <summary>
        /// Configuration entry for enabling or disabling custom stack sizes.
        /// </summary>
        internal static ConfigEntry<bool> CustomStackSizes { get; private set; }
        
        /// <summary>
        /// Configuration entry for setting the maximum stack size.
        /// </summary>
        internal static ConfigEntry<int> MaxStackSize { get; private set; }


        /// <summary>
        /// The Awake method is called when the plugin is loaded. It initializes the configuration and applies Harmony patches.
        /// </summary>
        private void Awake()
        {
            // Initialize configuration entries
            StackIt = Config.Bind("1. Stack It!", "Stack It!", true, new ConfigDescription("Doubles the max stack size of eligible items.", null, new ConfigurationManagerAttributes {Order = 99}));
            // Event handler for the StackIt configuration entry. When the setting is changed,
            // if it's set to true, it disables the CustomStackSizes setting and applies item modifications.
            // It also logs a warning message if the StackIt setting is enabled.
            StackIt.SettingChanged += (_, _) =>
            {
                switch (StackIt.Value)
                {
                    case true:
                        CustomStackSizes.Value = false;
                        break;
                    case false:
                        return;
                }

                if (ItemPatches.ApplyModifications())
                {
                    LOG.LogWarning("Double stack sizes enabled.");
                }
            };

            CustomStackSizes = Config.Bind("2. Custom", "Custom Stack Size", false, new ConfigDescription("Allows you to set custom stack sizes for eligible items.", null, new ConfigurationManagerAttributes {Order = 98}));
            // Event handler for the CustomStackSizes configuration entry. When the setting is changed,
            // if it's set to true, it disables the StackIt setting and applies item modifications.
            // It also logs a warning message if the CustomStackSizes setting is enabled.
            CustomStackSizes.SettingChanged += (_, _) =>
            {
                switch (CustomStackSizes.Value)
                {
                    case true:
                        StackIt.Value = false;
                        break;
                    case false:
                        return;
                }

                if (ItemPatches.ApplyModifications())
                {
                    LOG.LogWarning("Custom stack sizes enabled.");
                }
            };

            MaxStackSize = Config.Bind("2. Custom", "Max Stack Size", 999, new ConfigDescription("The maximum stack size for eligible items.", new AcceptableValueRange<int>(1, 999), new ConfigurationManagerAttributes {Order = 97}));

            
            // Initialize logger
            LOG = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(LOG);

            // Check if the Wanderer DLC is installed and apply Harmony patches if it is
            var assembly = AccessTools.GetTypesFromAssembly(Assembly.GetAssembly(typeof(MainMenuPanel)));
            var wandererTypeExists = assembly.Any(type => type.Name == "WandererDLCController");
            if (wandererTypeExists)
            {
                enabled = true;
                Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
                LOG.LogWarning($"Plugin {PluginName} is loaded!");
            }
            else
            {
                LOG.LogError($"You must have the Wanderer DLC to use this mod.");
                enabled = false;
            }
        }

        /// <summary>
        /// Called when the plugin is disabled.
        /// </summary>
        private void OnDisable()
        {
            LOG.LogError("I've been disabled! Do you have the necessary DLC?");
        }

        /// <summary>
        /// Called when the plugin is destroyed.
        /// </summary>
        private void OnDestroy()
        {
            LOG.LogError("I've been destroyed!");
        }
    }
}