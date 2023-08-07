using System;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BlueOakBridge.Core;
using BlueOakBridge.Core.Camera;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Screen = UnityEngine.Device.Screen;

namespace DisplayTweaks;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.blueoakbridge.displaytweaks";
    private const string PluginName = "Blue Oak Bridge Display Tweaks";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource Log { get; private set; }
    internal static CanvasScaler CanvasScaler { get; set; }
    private static ConfigEntry<bool> ChangeScale { get; set; }
    private static ConfigEntry<float> ScaleFactor { get; set; }
    private static ConfigEntry<int> RefreshRate { get; set; }
    private static ConfigEntry<int> ScreenWidth { get; set; }
    private static ConfigEntry<int> ScreenHeight { get; set; }
    private static ConfigEntry<string> FullScreenModeConfig { get; set; }
    private static ConfigEntry<bool> Vsync { get; set; }

    internal static ConfigEntry<int> MaxZoom { get; private set; }
    internal static ConfigEntry<float> CurrentZoom { get; private set; }
    internal static ConfigEntry<int> ZoomSpeed { get; private set; }

    private static ConfigEntry<float> FixedUpdateInterval { get; set; }

    private static FullScreenMode FullScreenMode =>
        (FullScreenMode) Enum.Parse(typeof(FullScreenMode), FullScreenModeConfig.Value);

    private void Awake()
    {
        Log = Logger;
        var refreshRates = Screen.resolutions.Select(r => r.refreshRateRatio).Select(a => (float)a.value).Distinct().ToArray();
        ChangeScale = Config.Bind("1. UI", "Change Scale", true,
            new ConfigDescription("Change the scale of the UI", null, new ConfigurationManagerAttributes {Order = 12}));
        ChangeScale.SettingChanged += (_, _) => { ChangeScaler(); };
        ScaleFactor = Config.Bind("1. UI", "Scale Factor", 1.0f,
            new ConfigDescription("Scale factor for the UI", new AcceptableValueRange<float>(0.5f, 2f),
                new ConfigurationManagerAttributes {Order = 11}));
        ScaleFactor.SettingChanged += (_, _) => { ChangeScaler(); };
        ScreenWidth = Config.Bind("2. Display", "Screen Width", Display.main.systemWidth,
            new ConfigDescription("Screen width", null, new ConfigurationManagerAttributes {Order = 10}));
        ScreenHeight = Config.Bind("2. Display", "Screen Height", Display.main.systemHeight,
            new ConfigDescription("Screen height", null, new ConfigurationManagerAttributes {Order = 9}));
        RefreshRate = Config.Bind("2. Display", "Refresh Rate", 120,
            new ConfigDescription("Refresh rate for the game", null, new ConfigurationManagerAttributes {Order = 8}));
        FixedUpdateInterval = Config.Bind("2. Display", "Fixed Update Interval", 60f,
            new ConfigDescription("Fixed Update Interval", new AcceptableValueList<float>(refreshRates),
                new ConfigurationManagerAttributes {Order = 7}));
        FixedUpdateInterval.SettingChanged += (_, _) =>
        {
            UpdateFixedUpdate();
        };
        FullScreenModeConfig = Config.Bind("2. Display", "Full Screen Mode",
            FullScreenMode.ExclusiveFullScreen.ToString(),
            new ConfigDescription("Full Screen Mode",
                new AcceptableValueList<string>(Enum.GetNames(typeof(FullScreenMode))),
                new ConfigurationManagerAttributes {Order = 6}));
        Vsync = Config.Bind("2. Display", "Vsync", false,
            new ConfigDescription("Toggle VSync (game setting doesn't always appear to work)", null,
                new ConfigurationManagerAttributes {Order = 5}));
        Config.Bind("2. Display", "Apply", true,
            new ConfigDescription("Apply Display Settings", null,
                new ConfigurationManagerAttributes
                    {Order = 4, HideDefaultButton = true, CustomDrawer = ApplyDisplaySettings}));
        CurrentZoom = Config.Bind("3. Camera", "Current Zoom", 12f,
            new ConfigDescription("Current zoom level", null, new ConfigurationManagerAttributes {Order = 3}));
        CurrentZoom.SettingChanged += (_, _) => { Log.LogWarning("Current Zoom: " + CurrentZoom.Value); };
        MaxZoom = Config.Bind("3. Camera", "Max Zoom", 16,
            new ConfigDescription("Minimum zoom level", new AcceptableValueRange<int>(10, 32),
                new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 2}));
        MaxZoom.SettingChanged += (_, _) =>
        {
            MainCamera.MaxZoom = MaxZoom.Value;
            MainCamera.OutsideMaxZoom = MaxZoom.Value;
        };
        ZoomSpeed = Config.Bind("3. Camera", "Zoom Speed", 5,
            new ConfigDescription("Zoom speed", new AcceptableValueRange<int>(1, 10),
                new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 1}));
        ZoomSpeed.SettingChanged += (_, _) => { MainCamera.ZoomSpeed = ZoomSpeed.Value; };
        
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginGuid} is loaded!");
    }

    private static void ApplyDisplaySettings(ConfigEntryBase entry)
    {
        var button = GUILayout.Button("Apply Display Settings", GUILayout.ExpandWidth(true));
        if (button)
        {
            UpdateDisplaySettings();
        }
    }

    private static void ChangeScaler()
    {
        if (CanvasScaler == null) return;
        if (!ChangeScale.Value)
        {
            CanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        }
        else
        {
            CanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            CanvasScaler.scaleFactor = ScaleFactor.Value;
        }
    }

    private static void UpdateDisplaySettings()
    {
        var refreshRate = new RefreshRate
        {
            denominator = 1,
            numerator = (uint) RefreshRate.Value
        };
        Screen.SetResolution(ScreenWidth.Value, ScreenHeight.Value, FullScreenMode, refreshRate);
        Application.targetFrameRate = (int) refreshRate.value;
        QualitySettings.vSyncCount = Vsync.Value ? 1 : 0;
        ChangeScaler();
        UpdateFixedUpdate();
        Log.LogWarning("Set resolution to " + ScreenWidth.Value + "x" + ScreenHeight.Value +
                       $" @ {refreshRate.value}Hz - {FullScreenMode} - Vsync: {QualitySettings.vSyncCount}");
    }

    private static void UpdateFixedUpdate()
    {
        var fixedUpdateValue = 1.0f / FixedUpdateInterval.Value;
        Log.LogWarning($"New FixedUpdateValue: {fixedUpdateValue} ");
        Time.fixedDeltaTime = fixedUpdateValue;   
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        UpdateDisplaySettings();
        if (!Patches.SafeToZoom()) return;
        if (Game.CurrentRoom.IsInside) return;
        MainCamera._instance.OrthographicSize = CurrentZoom.Value;
    }
}