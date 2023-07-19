using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace ScarletMaiden
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]    
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.scarletmaiden.uwfixes";
        private const string PluginName = "Scarlet Maiden UltraWide Fixes";
        private const string PluginVersion = "0.0.2";
        public static ManualLogSource LOG { get; private set; }
        internal static ConfigEntry<bool> EnableCustomOrthographicSize { get; set; }
        internal static ConfigEntry<float> CustomOrthographicSize { get; set; }
        internal static ConfigEntry<KeyboardShortcut> IncreaseZoom { get; set; }
        internal static ConfigEntry<KeyboardShortcut> DecreaseZoom { get; set; }
        
        internal static ConfigEntry<KeyboardShortcut> Reset { get; set; }
        public static float OriginalZoom { get; set; }

        private void Awake()
        {
            LOG = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(LOG);
            EnableCustomOrthographicSize = Config.Bind("Camera", "Enable Custom Camera Zoom", false, new ConfigDescription("Enable this if you are using an ultra-wide monitor and the camera is too close/far away for your liking.", null, new ConfigurationManagerAttributes {Order = 6}));
            CustomOrthographicSize = Config.Bind("Camera", "Custom Custom Camera Zoom", 5f, new ConfigDescription("Adjust this number to your personal preference. Use Num+, Num- to control in game.", null, new ConfigurationManagerAttributes {Order = 5}));
            IncreaseZoom = Config.Bind("Camera", "Increase Zoom Shortcut", new KeyboardShortcut(KeyCode.KeypadPlus), new ConfigDescription("Increase the camera zoom.", null, new ConfigurationManagerAttributes {Order = 4}));
            DecreaseZoom = Config.Bind("Camera", "Decrease Zoom Shortcut", new KeyboardShortcut(KeyCode.KeypadMinus), new ConfigDescription("Decrease the camera zoom.", null, new ConfigurationManagerAttributes {Order = 3}));
            Reset = Config.Bind("Camera", "Reset Camera Zoom Shortcut", new KeyboardShortcut(KeyCode.KeypadMultiply), new ConfigDescription("Reset to original zoom level.", null, new ConfigurationManagerAttributes {Order = 2}));
            Config.Bind("Camera", "Reset Camera Zoom", true, new ConfigDescription("Reset to original zoom level and disable custom zoom.", null, new ConfigurationManagerAttributes {CustomDrawer = ResetToDefault, Order = 1}));
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            LOG.LogWarning($"Plugin {PluginName} is loaded!");
        }

        private static void ResetToDefault(ConfigEntryBase entry)
        {
            var button = GUILayout.Button("Reset Zoom", GUILayout.ExpandWidth(true));
            if (!button) return;
            ResetZoom(true);

        }

        internal static void ResetZoom(bool disable = false)
        {
            EnableCustomOrthographicSize.Value = !disable;
            CustomOrthographicSize.Value = OriginalZoom;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFix>().UpdateOrthographicSize();
        }

        private void OnDestroy()
        {
            LOG.LogError("I've been destroyed!");
        }
        
        private void OnDisable()
        {
            LOG.LogError("I've been disabled!");
        }
    }
}