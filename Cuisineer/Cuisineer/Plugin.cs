using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Cuisineer;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.cuisineer.cuisineertweaks";
    private const string PluginName = "Cuisineer Tweaks (IL2CPP)";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Logger { get; private set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static int TimeScale => FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        // Start from half of the original rate and decrement by one to find the highest multiple above 50.
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        // Fallback, though this scenario is unlikely with standard monitor refresh rates
        return originalRate;
    }

    public override void Load()
    {
        Logger = Log;
        CorrectFixedUpdateRate = Config.Bind("General", "CorrectFixedUpdateRate", true,
            new ConfigDescription("Correct the fixed update rate to the lowest multiple of the refresh rate above 50.",
                null));
        UseRefreshRateForFixedUpdateRate = Config.Bind("General", "UseRefreshRateForFixedUpdateRate", true,
            new ConfigDescription("Use the refresh rate for the fixed update rate. If false, the fixed update rate will be lowest multiple of the refresh rate above 50.",
                null));

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginGuid} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Logger.LogInfo($"Scene loaded: {arg0.name}: Running Fixes");
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, MaxRefresh);
        Logger.LogInfo($"Set resolution to {Screen.currentResolution}");

        Application.targetFrameRate = MaxRefresh;
        Logger.LogInfo($"Set targetFrameRate to {Application.targetFrameRate}.");

        if (!CorrectFixedUpdateRate.Value) return;
        var scale = UseRefreshRateForFixedUpdateRate.Value ? MaxRefresh : TimeScale;
        Time.fixedDeltaTime = 1f / scale;
        Logger.LogInfo($"Set fixedDeltaTime to {Time.fixedDeltaTime} ({scale}).");
    }
}