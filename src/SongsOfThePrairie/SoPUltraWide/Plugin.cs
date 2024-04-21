using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace SoPUltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.sop.ultrawide";
    private const string PluginName = "Songs of the Prairie UltraWide";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource LOG { get; private set; }

    public override void Load()
    {
        AddComponent<CameraFixes>();
        LOG = Log;
        LOG.LogInfo($"Plugin {PluginGuid} is loaded!");
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManager_sceneLoaded;
    }

    private static void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Application.targetFrameRate = CameraFixes.MaxRefresh;
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, CameraFixes.MaxRefresh);
        LOG.LogWarning($"Scene loaded: {arg0.name} {arg1}");
        LOG.LogWarning($"Screen: {Screen.width}x{Screen.height} {Screen.currentResolution}");
    }
}