using System;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TheyAlwaysRun;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.theyalwaysrun.ultrawide";
    private const string PluginName = "They Always Run Ultra-Wide!";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }
    internal static GameObject TopLeftHud { get; set; }
    internal static GameObject TopRightHud { get; set; }
    internal static GameObject BottomLeftHud { get; set; }
    internal static CanvasScaler HudScaler { get; set; }
    private static ConfigEntry<bool> SkipSplashScreens { get; set; }
    private static ConfigEntry<bool> ExpandUI { get; set; }
    internal static ConfigEntry<bool> StretchBackGround { get; private set; }
    internal static ConfigEntry<float> UIScale { get; private set; }
    public static GameObject BackImage { get; set; }

    private static bool DoUpdates { get; set; }

    private void Awake()
    {
        Log = Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogWarning($"Plugin {PluginName} is loaded!");
        SkipSplashScreens = ConfigureSetting("Skip Splash Screens", true, "Skip the splash screens.", (_, _) => { SplashController.Shown = SkipSplashScreens.Value; });

        UIScale = ConfigureSetting("UI Scale", 1f, new ConfigDescription("Scale the UI.", new AcceptableValueRange<float>(0.1f, 10f), null), (_, _) =>
        {
            UpdateResolution();
            if (HudScaler != null) HudScaler.scaleFactor = UIScale.Value;
        });

        ExpandUI = ConfigureSetting("Expand UI", true, "Expand UI to fill the screen.", (_, _) =>
        {
            UpdateResolution();
            DoUpdates = !ExpandUI.Value;

            if (DoUpdates) return;

            foreach (var obj in Patches.OriginalPositions)
            {
                //Log.LogWarning($"Resetting {obj.Key} to {obj.Value}");
                GameObject.Find(obj.Key).transform.position = obj.Value;
            }
        });

        StretchBackGround = ConfigureSetting("Stretch Background", true, "Stretch the background to fill the screen.", (_, _) =>
        {
            UpdateResolution();
            if (BackImage != null)
            {
                BackImage.transform.localScale = StretchBackGround.Value
                    ? new Vector3(Util.GetScaleRatio(), 1, 1)
                    : new Vector3(1, 1, 1);
            }
        });

        if (SkipSplashScreens.Value)
        {
            SplashController.Shown = true;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Update()
    {
        if (DoUpdates)
        {
            UpdateAll();
        }
    }

    private ConfigEntry<T> ConfigureSetting<T>(string key, T defaultValue, object description, EventHandler args)
    {
        var setting = description is string s
            ? Config.Bind("General", key, defaultValue, s)
            : Config.Bind("General", key, defaultValue, description as ConfigDescription);

        setting.SettingChanged += args;
        return setting;
    }


    private static void UpdateAll()
    {
        const float aspectRatio = 16 / 9f;
        var aspectWidth = Mathf.RoundToInt(Display.main.systemHeight * aspectRatio);
        var halfAspectWidth = aspectWidth / 2f;
        var leftPositionAdjusted = Display.main.systemWidth / 2f + (Display.main.systemWidth / 2f - halfAspectWidth);

        var topLeftPositionAdjusted = (Display.main.systemWidth - aspectWidth) / 2f;
        var topLeftHudCurrentPosition = TopLeftHud.transform.position;
        var topLeftHudNewPosition = new Vector3(topLeftPositionAdjusted + 30f, topLeftHudCurrentPosition.y, topLeftHudCurrentPosition.z);
        TopLeftHud.transform.position = topLeftHudNewPosition;

        var topRightPositionAdjusted = aspectWidth + (Display.main.systemWidth - aspectWidth) / 2f;
        var topRightHudCurrentPosition = TopRightHud.transform.position;
        var topRightHudNewPosition = new Vector3(topRightPositionAdjusted, topRightHudCurrentPosition.y, topRightHudCurrentPosition.z);
        TopRightHud.transform.position = topRightHudNewPosition;

        var bottomLeftHudCurrentPosition = BottomLeftHud.transform.position;
        var bottomLeftHudNewPosition = new Vector3(leftPositionAdjusted, bottomLeftHudCurrentPosition.y, bottomLeftHudCurrentPosition.z);
        BottomLeftHud.transform.position = bottomLeftHudNewPosition;
    }

    private static void UpdateResolution(bool menu = false)
    {
        const float ar = 16 / 9f;
        var width = Mathf.RoundToInt(Display.main.systemHeight * ar);
        Screen.SetResolution(menu ? width : Display.main.systemWidth, Display.main.systemHeight, Screen.fullScreenMode, 120);
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (SkipSplashScreens.Value)
        {
            if (arg0.name.Equals("Start"))
            {
                SceneLoader.Load("Menu");
            }
        }

        UpdateResolution(arg0.name.Equals("Menu"));
    }
}