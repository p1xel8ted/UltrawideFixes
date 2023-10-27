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
using UnityEngine.UI;
using UnityEngine.Video;

namespace TormentedSouls;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.tormentedsouls.ultrawide";
    private const string PluginName = "Tormented Souls Ultra-Wide (IL2CPP)";
    private const string PluginVersion = "0.1.2";
    private const string LogosInit = "LogosInit";
    private const string MenuInit = "MenuInit";
    private const string Background = "Background";
    private const int UiReferenceResolutionHeight = 2160;
    private const int DeathReferenceResolutionHeight = 1080;
    private static ManualLogSource Logger { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private static readonly int TimeScale = FindLowestFrameRateMultipleAboveFifty(MaxRefresh);

    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        // Start from half of the original rate and decrement by one to find the highest multiple above 50.
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        // Fallback, though this scenario is unlikely with standard monitor refresh rates
        return originalRate;
    }

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
        Logger.LogInfo($"Updated {scaler.name} to {scaler.scaleFactor}");
    }

    public override void Load()
    {
        Logger = Log;
        CorrectFixedUpdateRate = Config.Bind("General", "CorrectFixedUpdateRate", true,
            new ConfigDescription("Correct the fixed update rate to the lowest multiple of the refresh rate above 50.",
                null));
        UseRefreshRateForFixedUpdateRate = Config.Bind("General", "UseRefreshRateForFixedUpdateRate", true,
            new ConfigDescription("Use the refresh rate for the fixed update rate. If false, the fixed update rate will be lowest multiple of the refresh rate above 50.",
                null));

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginGuid} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Logger.LogInfo($"Scene loaded: {arg0.name}: Running Fixes");
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, MaxRefresh);
        Logger.LogInfo($"Set resolution to {Screen.currentResolution}");

        Application.targetFrameRate = MaxRefresh;
        Logger.LogInfo($"Set targetFrameRate to {Application.targetFrameRate}.");

        if (CorrectFixedUpdateRate.Value)
        {
            var scale = UseRefreshRateForFixedUpdateRate.Value ? MaxRefresh : TimeScale;
            Time.fixedDeltaTime = 1f / scale;
            Logger.LogInfo($"Set fixedDeltaTime to {Time.fixedDeltaTime} ({scale}).");
        }


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
            if (meta == null) continue;
            meta.SetActive(false);
            Logger.LogInfo($"Disabled {meta.name}");
        }


        var canvasScalers = Resources.FindObjectsOfTypeAll<CanvasScaler>();
        foreach (var scaler in canvasScalers)
        {
            var refHeight = scaler.referenceResolution.y;
            if (Mathf.Approximately(refHeight, UiReferenceResolutionHeight))
            {
                UpdateCanvasScaler(scaler, UiReferenceResolutionHeight);
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
            Logger.LogInfo($"Updated {vp.name} to {vp.aspectRatio}");
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

        if (arg0.name.Equals(LogosInit) && (SteamManager.Initialized || SteamManager.Instance is null))
        {
            SceneManager.LoadScene(MenuInit);
        }
    }
}