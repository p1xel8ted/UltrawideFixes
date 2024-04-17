using System.Linq;
using System.Reflection;
using Assets.Code.Platform;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace DarkestDungeon2UltrawideFix
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.darkestdungeon2.ultrawide";
        private const string PluginName = "Darkest Dungeon 2 Ultra-Wide";
        private const string PluginVersion = "0.1.1";
        internal static float MainAspectRatio => (float) MainWidth / MainHeight;
        
        internal const float BaseAspectRatio = 16f / 9f;
        internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
        private static ConfigEntry<int> DisplayToUse { get; set; }
        internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
        internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
        internal static RefreshRate MaxRefresh => Screen.resolutions.Max(a => a.refreshRateRatio);
        private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
        internal static ManualLogSource LOG { get; private set; }

        private void Awake()
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

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            LOG.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private static void RunDisplayFixes()
        {
            Display.displays[DisplayToUse.Value].Activate();
        }

        private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Time.fixedDeltaTime = (float) (1f / MaxRefresh.value);
        }
    }
}