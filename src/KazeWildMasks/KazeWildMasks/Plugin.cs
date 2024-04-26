using System;
using System.Linq;
using System.Net;
using System.Net.Mime;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime;
using Il2CppSystem.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KazeWildMasks;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.kazewildmasks.ultrawide";
    private const string PluginName = "Kaze and the Wild Masks Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;

    internal const float BaseAspectRatio = 16f / 9f;
    internal const float SuperWideAspectRatio = 32f / 9f;

    internal static float BaseAspect => 16f / 9f;

    internal static float PositiveScalerFactor => MainAspectRatio / BaseAspect;

    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Logger { get; set; }

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

        FieldOfView = Config.Bind("02. Camera", "Field of View", 50, new ConfigDescription("Increase or decrease the field of view of the camera. Default is 50% increases", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 100}));

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateBackgrounds();

        UpdateDisplay();
    }

    internal static void UpdateBackgrounds()
    {
        foreach (var r in Utils.FindIl2CppType<RectTransform>())
        {
            if (r.name.Equals("KazeLogo") || r.name.Equals("Splash")) continue;
            
            var rectAspect = r.sizeDelta.x / r.sizeDelta.y;

            if (!Mathf.Approximately(rectAspect, BaseAspect)) continue;

            var y = r.sizeDelta.y;
            var x = y * MainAspectRatio;
            r.sizeDelta = new Vector2(x, y);
        }

    }
    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

}