using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace AlwasLegacy;

[BepInPlugin("p1xel8ted.alwaslegacy.fixes", "Alwa's Legacy Fixes", "0.1.1")]
[HarmonyPatch]
public partial class Plugin : BaseUnityPlugin
{
    private static Harmony _hi;
    private static ManualLogSource _log;
    private static ConfigEntry<float> _dialogScale = null!;
    
    public void Awake()
    {
        _dialogScale = Config.Bind("General", "DialogScale", 0.75f, "Scale of the NPC dialogues and item pickup dialogues. 0.75 is the default (makes it a littler smaller).");
        _log = new ManualLogSource("Log");
        BepInEx.Logging.Logger.Sources.Add(_log);
        _hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "p1xel8ted.alwaslegacy.fixes");
        _log.LogInfo($"Plugin Alwa's Legacy Fixes is loaded!");
    }

    public void OnDestroy()
    {
        _hi?.UnpatchSelf();
    }
    

}