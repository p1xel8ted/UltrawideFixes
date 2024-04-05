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

namespace WonhonSpiritUltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.wonhonspirit.ultrawide";
    private const string PluginName = "Wonhon Spirit Ultra-Wide";
    private const string PluginVersion = "0.1.5";

    private static float MainAspectRatio => MainWidth / (float) MainHeight;
    private static float BaseAspectRatio => 16f / 9f;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => 1f / PositiveScaleFactor;
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static ManualLogSource Logger { get; set; }
    

    public override void Load()
    {
       
        Logger = Log;
        
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

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    internal static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1 / (float) MaxRefresh;
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var camera in cameras)
        {
            camera.aspect = MainAspectRatio;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
        }
    }
    
}