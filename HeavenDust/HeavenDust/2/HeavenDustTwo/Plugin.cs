using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace HeavenDustTwo
{
    [BepInPlugin(PluginGuid, PluginName, PluginVer)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.heavendust.two";
        private const string PluginName = "HeavenDust 2 UltraWide Fix";
        private const string PluginVer = "0.1.2";
        private static readonly Harmony Harmony = new(PluginGuid);

        internal static ConfigEntry<bool> HideOverlay = null!;
        internal static ConfigEntry<int> Width = null!;
        internal static ConfigEntry<int> Height = null!;

        internal static ConfigEntry<bool> DisableVignette = null!;
        internal static ConfigEntry<bool> DisableChromaticAberration = null!;
        internal static ConfigEntry<bool> DisableFogOfWar = null!;
        internal static ConfigEntry<bool> AlternateUiScaleMode = null!;

        internal static ManualLogSource LOG;

        private void Awake()
        {
            HideOverlay = Config.Bind("General", "Hide Overlay", true, "Hide the camera overlay.");
            Width = Config.Bind("Resolution", "Width", Display.main.systemWidth);
            Height = Config.Bind("Resolution", "Height", Display.main.systemHeight);
            AlternateUiScaleMode = Config.Bind("Resolution", "Alternate UI Scale Mode", false, "Use the alternate UI scale mode.");

            DisableVignette = Config.Bind("Effects", "Disable Vignette", true, "Disable the vignette effect.");
            DisableChromaticAberration = Config.Bind("Effects", "Disable Chromatic Aberration", true, "Disable the chromatic aberration effect.");
            DisableFogOfWar = Config.Bind("Effects", "Disable Fog of War", true, "Disable the fog of war effect.");
           
            
            LOG = Logger;
            LOG.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private void OnEnable()
        {
            Harmony.PatchAll();
        }

        private void OnDisable()
        {
            Harmony.UnpatchSelf();
        }
    }
}