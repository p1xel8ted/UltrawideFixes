using System.Reflection;
using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Logger = BepInEx.Logging.Logger;

namespace KazeUW;

[HarmonyPatch]
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    internal static Harmony Hi;
    private static ManualLogSource _log;

    public override void Load()
    {
        AddComponent<UnityEvents>();
        _log = new ManualLogSource("Log");
        Logger.Sources.Add(_log);
        _log.LogWarning($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        Hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
    }
}