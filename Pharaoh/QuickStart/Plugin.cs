using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace QuickStart;

[BepInPlugin("p1xel8ted.pharaoh.quickstart", "QuickStart!", "0.1.0")]
[HarmonyPatch]
public class Plugin : BaseUnityPlugin
{
    private static Harmony _hi;
    private static ManualLogSource _log;
    internal static ConfigEntry<bool> LoadLastModified;

    public void Awake()
    {
        _log = new ManualLogSource("Log");
        BepInEx.Logging.Logger.Sources.Add(_log);
        _log.LogWarning($"Plugin QuickStart! is loaded!");
        LoadLastModified = Config.Bind("General", "LoadLastModified", false, "Load last modified save on startup instead of last campaign save.");
        _hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
    }

    public void OnDestroy()
    {
        _hi?.UnpatchSelf();
    }
}