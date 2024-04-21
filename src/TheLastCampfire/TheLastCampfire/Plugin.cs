using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace TheLastCampfire;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.thelastcampfire.ultrawide";
    private const string PluginName = "Ultra-Wide!";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }
    private void Awake()
    {
        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
    }
}