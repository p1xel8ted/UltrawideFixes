using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace AlexKiddMiracleWorldDX;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.alexkiddmiracleworlddx.ultrawidefix";
    private const string PluginName = "Alex Kidd in Miracle World DX Ultra-Wide Fix";
    private const string PluginVersion = "0.0.1";
    private static ConfigEntry<bool> _disableColorOverlay;
    internal static ConfigEntry<bool> SkipDevLogos;
    internal static ConfigEntry<bool> KeepUICentered;
    internal static int SimplifiedWidth;
    internal static int SimplifiedHeight;
    private static ManualLogSource _log;
    internal static GameObject GlobalVolumeObj;

    private void Awake()
    {
        var gcd = Helpers.GetGcd(Display.main.systemWidth, Display.main.systemHeight);
        SimplifiedWidth = gcd.simplifiedWidth;
        SimplifiedHeight = gcd.simplifiedHeight;
        _disableColorOverlay = Config.Bind("General", "Disable Color Overlay", true, "Disables the color overlay/illumination in game.");
        SkipDevLogos = Config.Bind("General", "Skip Dev Logos", true, "Skips the developer logos at the start of the game.");
        KeepUICentered = Config.Bind("General", "Keep UI Centered", true, "Keeps the UI (and other screens) at the original 16:9 ratio.");
        _log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        _log.LogInfo($"Plugin {PluginGuid} is loaded!");
        _log.LogWarning($"simplifiedWidth: {SimplifiedWidth}, simplifiedHeight: {SimplifiedHeight}");
    }

    private void LateUpdate()
    {
        if (GlobalVolumeObj != null)
        {
            GlobalVolumeObj.SetActive(!_disableColorOverlay.Value);
        }
    }
    
    private void OnDestroy()
    {
        _log.LogInfo($"Plugin {PluginGuid} is destroyed!");
    }

    private void OnApplicationQuit()
    {
        _log.LogInfo($"Plugin {PluginGuid} is quitting!");
    }

    private void OnDisable()
    {
        _log.LogInfo($"Plugin {PluginGuid} is disabled!");
    }
}