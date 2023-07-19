using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace GoldenLight;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.goldenlight.ultrawide";
    private const string PluginName = "Golden Light Ultra-Wide!";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }
    private void Awake()
    {
        Log = Logger;
        Logger.LogInfo($"Plugin {PluginGuid} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
}