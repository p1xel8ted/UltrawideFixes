using System;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WonderBoyReturnsRemix;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.wonderboyreturnsremix.ultrawide";
    private const string PluginName = "Wonder Boy Returns Remix Ultra-Wide!";
    private const string PluginVersion = "0.1.1";

    private static float MainAspectRatio => MainWidth / (float) MainHeight;
    
    internal static ConfigEntry<float> CameraZoom { get; private set; }
    internal static ConfigEntry<bool> EnableGoingBackwards { get; private set; }
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static ManualLogSource Log { get; set; }

    private void Awake()
    {
     
        PlayerPrefs.SetInt("ScreenHeight", MainWidth);
        PlayerPrefs.SetInt("ScreenWidth", MainHeight);
        PlayerPrefs.SetInt("Screenmanager Is Fullscreen mode", 1);
        PlayerPrefs.SetInt("Screenmanager Resolution Height", MainHeight);
        PlayerPrefs.SetInt("Screenmanager Resolution Width", MainWidth);
        PlayerPrefs.SetInt("Is Fullscreen mode", 1);
        PlayerPrefs.SetInt("Resolution Height", MainHeight);
        PlayerPrefs.SetInt("Resolution Width", MainWidth);

        CameraZoom = Config.Bind("01. General", "Camera Zoom", 8f, "Changes the cameras orthographic size. 8 is the default. The games default is 6.5.");
        EnableGoingBackwards = Config.Bind("01. General", "Enable Going Backwards", true, "By default, the player can't go backwards. This allows the player to go backwards.");

        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManager_SceneLoaded;
    }

    private void Update()
    {
        if (Camera.main != null)
        {
            Camera.main.orthographicSize = CameraZoom.Value;
        }
    }

    private static void SceneManager_SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Time.fixedDeltaTime = 1f / MaxRefresh;
        ScreenOption.IsFullScreen = true;
        Screen.SetResolution(MainWidth, MainHeight, true, MaxRefresh);
        
        foreach (var camera in Camera.allCameras)
        {
            camera.aspect = MainAspectRatio;
            camera.rect = new Rect(0, 0, MainWidth, MainHeight);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
        }
        
        var blockLeft = GameObject.Find("Main_Camera/block_left");
        if (blockLeft)
        {
            blockLeft.SetActive(false);
        }
        
        var blockRight = GameObject.Find("Main_Camera/block_right");
        if (blockRight)
        {
            blockRight.SetActive(false);
        }
    }
}