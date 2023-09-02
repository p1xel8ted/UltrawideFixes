using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

namespace TormentedSouls;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.tormentedsouls.ultrawide";
    private const string PluginName = "Tormented Souls Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    private const string LogosInit = "LogosInit";
    private const string MenuInit = "MenuInit";
    private const string Background = "Background";
    private const int ReferenceResolutionHeight = 2160;
    private static ManualLogSource Log { get; set; }
    private static ConfigEntry<float> ConfigScale { get; set; }
    private static GameObject CinematicBlackBarsTop { get; set; }
    private static GameObject CinematicBlackBarsBottom { get; set; }
    private static List<CanvasScaler> CanvasScalers { get; } = new();
    
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static float GetNewScale()
    {
        const float referenceHeight = 2160f;
        var displayHeight = Display.main.systemHeight;
        var scale = 1f / (referenceHeight / displayHeight);
        return scale;
    }

    private void Awake()
    {
        ConfigScale = Config.Bind("General", "Scale", GetNewScale(),
            new ConfigDescription("Scale of the UI. Adjust as necessary to fit. The default value should OK.",
                new AcceptableValueRange<float>(0.1f, 2f), new ConfigurationManagerAttributes {Order = 1}));
        ConfigScale.SettingChanged += (_, _) =>
        {
            foreach (var scaler in CanvasScalers)
            {
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
                scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
                scaler.scaleFactor = ConfigScale.Value;
            }
        };
        Log = Logger;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginGuid} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, MaxRefresh);
        Time.fixedDeltaTime = 1f / 120f;
        Application.targetFrameRate = MaxRefresh;
        
        var canvasScalers = Resources.FindObjectsOfTypeAll<CanvasScaler>();
        foreach (var scaler in canvasScalers)
        {
            if (!Mathf.Approximately(scaler.referenceResolution.y, ReferenceResolutionHeight)) continue;

            scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
            scaler.scaleFactor = GetNewScale();
            CanvasScalers.Add(scaler);
        }

        var videoPlayers = Resources.FindObjectsOfTypeAll<VideoPlayer>();
        foreach (var vp in videoPlayers)
        {
            vp.aspectRatio = VideoAspectRatio.FitVertically;
        }

        CinematicBlackBarsTop ??= GameObject.Find("[LoadingCurtainsManager]/Canvas/CinematicBlackBars/TopBar");
        if (CinematicBlackBarsTop != null)
        {
            CinematicBlackBarsTop.gameObject.SetActive(false);
        }

        CinematicBlackBarsBottom ??= GameObject.Find("[LoadingCurtainsManager]/Canvas/CinematicBlackBars/BottomBar");
        if (CinematicBlackBarsBottom != null)
        {
            CinematicBlackBarsBottom.gameObject.SetActive(false);
        }

        var backgrounds = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var background in backgrounds)
        {
            if (background.name.Equals(Background) && Mathf.Approximately(background.color.a, 0.949f) &&
                background.color is {r: 0, g: 0, b: 0})
            {
                background.transform.localScale = new Vector3(10, 1, 1);
            }
        }

        if (arg0.name.Equals(LogosInit))
        {
            SceneManager.LoadScene(MenuInit);
        }
    }
}