using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace DarkestDungeon2UltrawideFix
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "p1xel8ted.darkestdungeon2.ultrawide";
        private const string PluginName = "Darkest Dungeon 2 Ultra-Wide Fix";
        private const string PluginVersion = "0.0.1";
        internal static ManualLogSource? LOG { get; private set; }

        private void Awake()
        {
            LOG = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(LOG);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
            LOG.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private void OnDestroy()
        {
            LOG?.LogError("I've been destroyed! Make sure HideManagerGameObject = true in BepInEx.cfg! ");
        }

        private void OnDisable()
        {
            LOG?.LogError("I've been disabled! Make sure HideManagerGameObject = true in BepInEx.cfg! ");
        }
    }
}