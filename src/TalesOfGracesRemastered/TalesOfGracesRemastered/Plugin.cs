﻿using System.Runtime.Versioning;
using Noble;

namespace TalesOfGracesRemastered;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.talesofgracesremastered.ultrawide";
    private const string PluginName = "Tales of Graces F Remastered Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal const float NativeAspect = 16.0f / 9.0f;


    private static readonly int[] CustomRefreshRates =
    [
        30, // Uncommon
        50, // Uncommon
        60, // Common
        72, // Uncommon
        75, // Common
        90, // Uncommon
        100, // Uncommon
        120, // Common
        144, // Common
        165, // Common
        180, // Common
        200, // Uncommon
        240, // Common
        300, // Uncommon
        360, // Uncommon
        480 // Uncommon
    ];

    private static readonly int NativeDisplayWidth = Display.main.systemWidth;
    private static readonly int NativeDisplayHeight = Display.main.systemHeight;

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };

    internal static RefreshRate RefreshRateNew = new()
    {
        denominator = 1,
        numerator = (uint)RefreshRate
    };

    private static readonly Dictionary<int, Camera.GateFitMode> OriginalGateFitModes = new();

    private static ConfigEntry<bool> SixteenTenTesting { get; set; }
    private static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    private static ConfigEntry<bool> FourtyEightNineTesting { get; set; }

    internal static ManualLogSource Log { get; set; }
    private static int MaxRefresh => (int)Screen.resolutions.Max(a => a.refreshRateRatio.value);

    internal static int RefreshRate
    {
        get
        {
            if (UseCustomRefreshRate != null && CustomRefreshRate != null)
            {
                return UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh;
            }

            return MaxRefresh;
        }
    }


    private static ConfigEntry<int> CustomRefreshRate { get; set; }

    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static int MainWidth => SelectedResolution.width;
    private static int MainHeight => SelectedResolution.height;

    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }

    internal static ConfigEntry<int> TargetFramerate { get; private set; }
    private static ConfigEntry<string> Resolution { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
            if (SixteenTenTesting.Value)
            {
                const int height = 1200;
                var width = Mathf.RoundToInt(height * 1.6f); // 1200 * 1.6f = 1920
                return new Resolution { width = width, height = height };
            }

            if (ThirtyTwoNineTesting.Value)
            {
                const int height = 900;
                var width = Mathf.RoundToInt(height * 3.555555555555556f); // 900 * 3.555555555555556f = 3200
                return new Resolution { width = width, height = height };
            }

            if (FourtyEightNineTesting.Value)
            {
                const int height = 600;
                var width = Mathf.RoundToInt(height * 5.333333333333333f); // 600 * 5.333333333333333f = 3200
                return new Resolution { width = width, height = height };
            }

            if (Resolution == null) return new Resolution { width = NativeDisplayWidth, height = NativeDisplayHeight };

            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    private static bool RequiresUpdate { get; set; }

    internal static float CurrentAspect => (float)SelectedResolution.width / SelectedResolution.height;

    internal static ConfigEntry<string> HUDAspect { get; private set; }

    private static List<string> HUDAspects { get; } =
    [
        "16:10",
        "16:9",
        "21:9",
        "21.5:9",
        "32:9",
        "32:10",
        "48:9",
        "Auto"
    ];

    private void Awake()
    {
        Log = Logger;


        var customRates = MergeUnityRefreshRates();

        SixteenTenTesting = Config.Bind("00. Testing", "16:10 Testing", false,
            new ConfigDescription(
                "Enable this option to test 16:10 aspect ratio.",
                null,
                new ConfigurationManagerAttributes { Order = 102 }));
        SixteenTenTesting.SettingChanged += (_, _) =>
        {
            if (SixteenTenTesting.Value)
            {
                ThirtyTwoNineTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };

        ThirtyTwoNineTesting = Config.Bind("00. Testing", "32:9 Testing", false,
            new ConfigDescription(
                "Enable this option to test 32:9 aspect ratio.",
                null,
                new ConfigurationManagerAttributes { Order = 101 }));
        ThirtyTwoNineTesting.SettingChanged += (_, _) =>
        {
            if (ThirtyTwoNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                FourtyEightNineTesting.Value = false;
            }

            UpdateAll(true);
        };

        FourtyEightNineTesting = Config.Bind("00. Testing", "48:9 Testing", false,
            new ConfigDescription(
                "Enable this option to test 48:9 aspect ratio.",
                null,
                new ConfigurationManagerAttributes { Order = 100 }));
        FourtyEightNineTesting.SettingChanged += (_, _) =>
        {
            if (FourtyEightNineTesting.Value)
            {
                SixteenTenTesting.Value = false;
                ThirtyTwoNineTesting.Value = false;
            }

            UpdateAll(true);
        };


        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) => UpdateAll(true);

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow,
            new ConfigDescription(
                "Select how the game displays on your screen:\n" +
                "- FullScreenWindow (Recommended): Runs the game in a borderless window that covers the entire screen. " +
                "This mode offers seamless alt-tabbing and behaves like Exclusive Fullscreen on most modern Windows versions.\n" +
                "- Exclusive Fullscreen: Attempts to take direct control of the display for scenarios like legacy compatibility or HDR management. " +
                "On modern systems, its behavior is nearly identical to FullScreenWindow, so this mode is generally not needed.\n" +
                "- Windowed: Runs the game in a resizable window.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        FullScreenModeConfig.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll(true);

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll(true);

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) => UpdateAll(true);

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll(true);

        HUDAspect = Config.Bind("02. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio.",
                new AcceptableValueList<string>(HUDAspects.ToArray()),
                new ConfigurationManagerAttributes { Order = 94 }));
        HUDAspect.SettingChanged += (_, _) => UpdateAll();

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        RequiresUpdate = true;

        UpdateAll(true);

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = NativeDisplayWidth,
            height = NativeDisplayHeight,
            refreshRateRatio = RefreshRateNew
        };

        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => Mathf.RoundToInt((float)a.refreshRateRatio.value)).Distinct().ToArray();
        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static void UpdateDisplay(bool force = false)
    {
        // Apply VSync setting using the mapped value
        if (VSyncOptions.TryGetValue(VSyncSetting.Value, out var vSyncCount))
        {
            QualitySettings.vSyncCount = vSyncCount;
        }
        else
        {
            Log.LogWarning($"Invalid VSync setting: {VSyncSetting.Value}");
            QualitySettings.vSyncCount = 1; // Default to "Every VBlank"
        }

        // Apply target frame rate only if VSync is off
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? TargetFramerate.Value : -1;

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRateNew);
        Log.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        RequiresUpdate = false;
    }

    private static void UpdateLayoutControllers()
    {
        var layoutControllers = Resources.FindObjectsOfTypeAll<LayoutController>();
        foreach (var lc in layoutControllers.Where(lc => lc))
        {
            lc.UpdateAspect();
        }
    }

    private static void UpdateAll(bool force = false)
    {
        UpdateDisplay(force);
        UpdateLayoutControllers();
        UpdateFrameRate();
    }

    private static void UpdateFrameRate()
    {
        var frm = Resources.FindObjectsOfTypeAll<FrameRateParam>();
        foreach (var f in frm)
        {
            f.QualitySettingFrameRate = TargetFramerate.Value;
            f.TargetFrameRate = TargetFramerate.Value;
            f.SetTargetFrameRate(TargetFramerate.Value, true);
        }
    }


    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();

        var frameRateManager = SingletonBase<FrameRateManager>.GetSingletonInstance();
        frameRateManager?.SetTargetFrameRate(TargetFramerate.Value);
        frameRateManager?.SetQualitySettingFrameRate(TargetFramerate.Value);

        var cameraInstance = SingletonBase<CameraManager>.GetSingletonInstance();
        cameraInstance?.SetCameraAspect(1);
        cameraInstance?.SetCameraViewportRect(new Rect(0, 0, 1, 1));
        SingletonBase<PrimitiveManager>.GetSingletonInstance().CalcUIOrthoMatrix(true);
    }
}