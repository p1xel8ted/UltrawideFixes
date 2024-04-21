using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace TalesOfTheNeonSea;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[HarmonyPatch]
public partial class Plugin : BaseUnityPlugin
{
    private static ManualLogSource? _log;

    private const string PluginGuid = "p1xel8ted.talesoftheneonsea.ultrawidefix";
    private const string PluginName = "Tales of the Neon Sea Ultra-Wide Fix";
    private const string PluginVersion = "0.0.1";

    public void Awake()
    {
        _log = new ManualLogSource("Log");
        BepInEx.Logging.Logger.Sources.Add(_log);
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        _log.LogInfo($"Plugin {PluginName} is loaded!");
    }
}