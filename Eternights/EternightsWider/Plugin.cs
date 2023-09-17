using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EternightsWider;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.eternights.eternightswider";
    private const string PluginName = "Eternights Wider";
    private const string PluginVersion = "0.1.0";
    private static ManualLogSource Log { get; set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginGuid} is loaded!");
    }
    
    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        ForceResolution("OnSceneLoaded");
    }

    internal static void ForceResolution(string caller)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Log.LogWarning(
            $"{caller}: Set resolution to {Display.main.systemWidth}x{Display.main.systemHeight} @ {MaxRefresh}Hz, target frame rate to {MaxRefresh}.");  
    }
}