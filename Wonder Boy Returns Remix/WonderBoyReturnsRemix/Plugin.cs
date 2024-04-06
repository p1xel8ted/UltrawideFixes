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

    private static float MainAspectRatio => (float) MainWidth / MainHeight;
    private static float BaseAspectRatio => 16f / 9f;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static ConfigEntry<int> CameraZoom { get; private set; }
    internal static ConfigEntry<bool> EnableGoingBackwards { get; private set; }
    internal static int MainWidth => Display.main.systemWidth;
    internal static int MainHeight => Display.main.systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ManualLogSource Log { get; set; }

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

        CameraZoom = Config.Bind("01. General", "Camera Zoom", 8, new ConfigDescription("Changes the cameras orthographic size. 8 is the default. The games default is 6.5.", new AcceptableValueRange<int>(3, 10)));
        EnableGoingBackwards = Config.Bind("01. General", "Enable Going Backwards", true, "By default, the player can't go backwards. This allows the player to go backwards.");

        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManager_SceneLoaded;
    }

    private void LateUpdate()
    {
        if (Camera.main)
        {
            Camera.main.orthographicSize = CameraZoom.Value;
        }
    }

    private static void SceneManager_SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals("LogoSTEAM", StringComparison.OrdinalIgnoreCase))
        {
            Time.timeScale = 1000f;
            SceneManager.LoadScene("TitleSWITCH");
        }
        else
        {
            Time.timeScale = 1f;
        }
        
        Camera.main!.backgroundColor = scene.name.StartsWith("alpha") ? new Color(0.1922f, 0.302f, 0.4745f, 0.0196f) : new Color(1f, 0.8392f, 0.2863f, 1);
        
        Time.fixedDeltaTime = 1f / MaxRefresh;
        ScreenOption.IsFullScreen = true;
        Screen.SetResolution(MainWidth, MainHeight, true, MaxRefresh);
        
        foreach (var camera in Camera.allCameras)
        {
            camera.aspect = MainAspectRatio;
            camera.rect = new Rect(0, 0, MainWidth, MainHeight);
            camera.pixelRect = new Rect(0, 0, MainWidth, MainHeight);
        }
        
        var moveBackGround = GameObject.Find("MoveBackground");
        if (moveBackGround)
        {
            moveBackGround.SetActive(true);
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