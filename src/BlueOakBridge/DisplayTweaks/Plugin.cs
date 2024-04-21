using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BlueOakBridge.Core;
using BlueOakBridge.Core.Camera;
using HarmonyLib;
#if WIN
using MonoMod.Utils;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using Screen = UnityEngine.Device.Screen;

namespace DisplayTweaks;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.blueoakbridge.displaytweaks";
#if WIN
    private const string PluginName = "Blue Oak Bridge Display Tweaks (Windows)";
#else
    private const string PluginName = "Blue Oak Bridge Display Tweaks (Other)";

#endif
    private const string PluginVersion = "0.1.1";
    private static ManualLogSource Log { get; set; }
    internal static CanvasScaler CanvasScaler { get; set; }
    private static ConfigEntry<float> ScaleFactor { get; set; }
    private static ConfigEntry<bool> Vsync { get; set; }
    internal static ConfigEntry<int> MaxZoom { get; private set; }
    internal static ConfigEntry<float> CurrentZoom { get; private set; }
    internal static ConfigEntry<int> ZoomSpeed { get; private set; }
    private static ConfigEntry<float> FixedUpdateInterval { get; set; }
    private static int SimplifiedWidth => Helpers.GetGcd(MainWidth, MainHeight).simplifiedWidth;
    private static int SimplifiedHeight => Helpers.GetGcd(MainWidth, MainHeight).simplifiedHeight;
    internal static float MainAspectRatio => (float) SimplifiedWidth / SimplifiedHeight;
    private const float BaseAspectRatio = 16f / 9f;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }

    private const float SuperWideAspectRatio = 32f / 9f;
    internal static ConfigEntry<int> DisplayToUse { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => (int) Screen.resolutions.Max(a => a.refreshRateRatio.value);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }

    internal static RefreshRate refreshRate => new()
    {
        denominator = 1,
        numerator = (uint) MaxRefresh
    };

    internal static void SwitchDisplay()
    {
        PlayerPrefs.SetInt("UnitySelectMonitor", DisplayToUse.Value);
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, refreshRate);
    }
    private void Awake()
    {
        var refreshRates = Screen.resolutions.Select(r => r.refreshRateRatio).Select(a => (float) a.value).Distinct().ToArray();
        Log = Logger;

        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 20}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplaySettings();
        };

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.Windowed, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 19}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplaySettings();
        };

        FixedUpdateInterval = Config.Bind("01. Display", "Fixed Update Interval", 60f,
            new ConfigDescription("Fixed Update Interval", new AcceptableValueList<float>(refreshRates),
                new ConfigurationManagerAttributes {Order = 18}));
        FixedUpdateInterval.SettingChanged += (_, _) =>
        {
            UpdateFixedUpdate();
        };

        Vsync = Config.Bind("01. Display", "Vsync", false,
            new ConfigDescription("Toggle VSync (game setting doesn't always appear to work)", null,
                new ConfigurationManagerAttributes {Order = 17}));

        Config.Bind("01. Display", "Apply", true,
            new ConfigDescription("Apply Display Settings", null,
                new ConfigurationManagerAttributes
                    {Order = 16, HideDefaultButton = true, CustomDrawer = ApplyDisplaySettings}));


        ScaleFactor = Config.Bind("02. UI", "Scale Factor", 1.0f,
            new ConfigDescription("Scale factor for the UI", new AcceptableValueRange<float>(0.5f, 2f),
                new ConfigurationManagerAttributes {Order = 14}));
        ScaleFactor.SettingChanged += (_, _) =>
        {
            ChangeScaler();
        };


        CurrentZoom = Config.Bind("03. Camera", "Current Zoom", 12f,
            new ConfigDescription("Current zoom level", new AcceptableValueRange<float>(5, 32), new ConfigurationManagerAttributes {Order = 13}));

        MaxZoom = Config.Bind("03. Camera", "Max Zoom", 16,
            new ConfigDescription("Minimum zoom level", new AcceptableValueRange<int>(5, 32),
                new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 12}));
        MaxZoom.SettingChanged += (_, _) =>
        {
            UpdateZoomValues();
        };


        ZoomSpeed = Config.Bind("03. Camera", "Zoom Speed", 5,
            new ConfigDescription("Zoom speed", new AcceptableValueRange<int>(1, 10),
                new ConfigurationManagerAttributes {ShowRangeAsPercent = false, Order = 11}));
        ZoomSpeed.SettingChanged += (_, _) =>
        {
            MainCamera.ZoomSpeed = ZoomSpeed.Value;
        };

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 10}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 9}));

        Application.focusChanged += focus => AudioListener.pause = !focus && MuteInBackground.Value;

        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginGuid} is loaded!");

#if WIN
        if (PlatformHelper.Is(Platform.Windows) || PlatformHelper.Is(Platform.Wine))
        {
            gameObject.AddComponent<WindowPositioner>();
        }
#endif
    }

    private static void UpdateZoomValues()
    {
        if (!Patches.SafeToZoom()) return;
        if (Game.CurrentRoom.IsInside) return;
        if (MainCamera.Instance)
        {
            MainCamera.Instance.OrthographicSize = CurrentZoom.Value;
        }
        MainCamera.MaxZoom = MaxZoom.Value;
        MainCamera.OutsideMaxZoom = MaxZoom.Value;
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
        if (!CanvasScaler) return;
        CanvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        CanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        CanvasScaler.scaleFactor = ScaleFactor.Value;
    }

    private static void UpdateDisplaySettings()
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, refreshRate);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, refreshRate);
        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;
        QualitySettings.vSyncCount = Vsync.Value ? 1 : 0;
        ChangeScaler();
        UpdateFixedUpdate();
    }

    private static void UpdateFixedUpdate()
    {
        var fixedUpdateValue = 1.0f / FixedUpdateInterval.Value;
        Time.fixedDeltaTime = fixedUpdateValue;
    }


    private static void UpdateOpaqueBackgrounds()
    {
        var rectTransforms = Resources.FindObjectsOfTypeAll<RectTransform>();
        foreach (var rect in rectTransforms)
        {
            if (Mathf.Approximately(rect.sizeDelta.x, 1920) && Mathf.Approximately(rect.sizeDelta.y, 1080))
            {
                rect.sizeDelta = new Vector2(MainWidth, MainHeight);
            }
        }
    }

    private static void UpdateMenuBackground()
    {
        var menuBackground = GameObject.Find("Canvas/BG");
        if (!menuBackground) return;
        
        var image = menuBackground.GetComponent<Image>();
        if (!image) return;
        
        var texture = new Texture2D(1, 1);
        
        var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        var file = MainAspectRatio switch
        {
            >= SuperWideAspectRatio => "assets/32-9.jpg",
            > BaseAspectRatio => "assets/21-9.jpg",
            _ => string.Empty
        };

        if (string.IsNullOrEmpty(file)) return;
        var imagePath = System.IO.Path.Combine(path!, file);
        texture.LoadImage(System.IO.File.ReadAllBytes(imagePath));
        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateZoomValues();
        UpdateOpaqueBackgrounds();
        UpdateMenuBackground();
        UpdateDisplaySettings();
    }
}