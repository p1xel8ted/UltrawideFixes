using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
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
    private const string PluginName = "20 Minutes Till Dawn Ultra-Wide!";
    private const string PluginVersion = "0.1.3";
    private const string FogOfWarCanvas = "PlayerController/FogOfWarCanvas/FogOfWarImage";

    internal static float MainAspectRatio => MainWidth / (float) MainHeight;
    internal static float PositiveScaleFactor => MainWidth / NormalWidth;
    private static float BaseAspect => 16f / 9f;
    private static float NormalWidth => MainHeight * BaseAspect;
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ManualLogSource Log { get; set; }

    private void Awake()
    {
        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode"));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };
        
        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
    }
    
    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Cameras.UpdateCameras();

        var fog = GameObject.Find(FogOfWarCanvas);
        if (fog is not null)
        {
            fog.transform.localScale = new Vector3(PositiveScaleFactor, PositiveScaleFactor, 1);
        }
    }
}