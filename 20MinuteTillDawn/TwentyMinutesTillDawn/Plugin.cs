using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TwentyMinutesTillDawn;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.20minutestilldawn.ultrawide";
    private const string PluginName = "Ultra-Wide!";
    private const string PluginVersion = "0.1.1";
    private static ManualLogSource Log { get; set; }
    internal static List<Vector2Int> NewSupportedResolutions { get; private set; }

    private void Awake()
    {
        NewSupportedResolutions = new List<Vector2Int>();
        NewSupportedResolutions = Screen.resolutions.Select(res => new Vector2Int(res.width, res.height)).Distinct().ToList();
        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true);
        
        Cameras.UpdateCameras();

        var fog = GameObject.Find("PlayerController/FogOfWarCanvas/FogOfWarImage");
        if (fog != null)
        {
            fog.transform.localScale = new Vector3(1.1f, 1.1f, 1);
        }
    }
}