using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
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
    private const int UiReferenceResolutionHeight = 2160;
    private const int DeathReferenceResolutionHeight = 1080;
    private static ManualLogSource Log { get; set; }
    private static ConfigEntry<float> ConfigScale { get; set; }
    private static List<CanvasScaler> UiCanvasScalers { get; } = new();
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static float GetNewScale(float reference)
    {
        var displayHeight = Display.main.systemHeight;
        var scale = 1f / (reference / displayHeight);
        return scale;
    }
    
    private static void UpdateCanvasScaler(CanvasScaler scaler, float referenceResolutionHeight)
    {
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
        scaler.scaleFactor = GetNewScale(referenceResolutionHeight);
    }

    private void Awake()
    {
        ConfigScale = Config.Bind("General", "Scale", GetNewScale(UiReferenceResolutionHeight),
            new ConfigDescription("Scale of the UI. Adjust as necessary to fit. The default value should OK.",
                new AcceptableValueRange<float>(0.1f, 2f), new ConfigurationManagerAttributes {Order = 1}));
        ConfigScale.SettingChanged += (_, _) =>
        {
            foreach (var scaler in UiCanvasScalers)
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
        
        string[] metaPaths =
        {
            "[LoadingCurtainsManager]/Canvas/CinematicBlackBars/BottomBar",
            "[LoadingCurtainsManager]/Canvas/CinematicBlackBars/TopBar",
            "FeedbackFrom/MetadataCollectors",
            "FeedbackFrom/MetadataCollectors/GraphicsInfoCollector",
            "FeedbackFrom/MetadataCollectors/PlayerInfoCollector",
            "FeedbackFrom/MetadataCollectors/SystemInfoCollector",
            "FeedbackFrom/MetadataCollectors/DebugLogCollector",
            "MainCanvas/OptionsMenuVIew/Panel/LegalLines",
            "MainCanvas/OptionsMenuVIew/Panel/version"
        };

        foreach (var path in metaPaths)
        {
            var meta = GameObject.Find(path);
            if (meta != null)
            {
                meta.SetActive(false);
            }
        }


        var canvasScalers = Resources.FindObjectsOfTypeAll<CanvasScaler>();
        foreach (var scaler in canvasScalers)
        {
            var refHeight = scaler.referenceResolution.y;
            if (Mathf.Approximately(refHeight, UiReferenceResolutionHeight))
            {
                UpdateCanvasScaler(scaler, UiReferenceResolutionHeight);
                UiCanvasScalers.Add(scaler);
            }
            else if (Mathf.Approximately(refHeight, DeathReferenceResolutionHeight))
            {
                UpdateCanvasScaler(scaler, DeathReferenceResolutionHeight);
            }
        }

        var videoPlayers = Resources.FindObjectsOfTypeAll<VideoPlayer>();
        foreach (var vp in videoPlayers)
        {
            vp.aspectRatio = VideoAspectRatio.FitVertically;
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