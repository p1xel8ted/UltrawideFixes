using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MiniShoot;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.minishootadventures.ultrawide";
    private const string PluginName = "MiniShoot Adventures Ultra-Wide!";
    private const string PluginVersion = "0.1.0";

    private static float MainAspectRatio => MainWidth / (float) MainHeight;
    private static int MainWidth => Display.main.systemWidth;
    private static int MainHeight => Display.main.systemHeight;

    private static ManualLogSource Log { get; set; }

    private void Awake()
    {
        Log = Logger;
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }
    
    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AspectUtility.wantedAspectRatio = MainAspectRatio;
        AspectUtility.cam.rect = new Rect(0, 0, 1, 1);
        AspectUtility.cam.pixelRect= new Rect(0, 0, MainWidth, MainHeight);
        AspectUtility.cam.aspect = MainAspectRatio;
    }
}