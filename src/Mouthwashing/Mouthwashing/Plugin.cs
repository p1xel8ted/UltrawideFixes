﻿using UnityEngine.Experimental.Rendering.Universal;
using Object = UnityEngine.Object;

namespace Mouthwashing;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.mouthwashing.ultrawide";
    private const string PluginName = "Mouthwashing Ultra-Wide";
    private const string PluginVersion = "0.1.0";

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

    internal static RefreshRate RefreshRateRatio => new()
    {
        denominator = 1,
        numerator = (uint)RefreshRate
    };

    internal static int RefreshRate
    {
        get
        {
            if (UseCustomRefreshRate != null && CustomRefreshRate != null)
            {
                return Mathf.RoundToInt(UseCustomRefreshRate.Value ? CustomRefreshRate.Value : MaxRefresh);
            }

            return Mathf.RoundToInt(MaxRefresh);
        }
    }

    internal static ManualLogSource Log { get; set; }

    private static int MaxRefresh => Screen.resolutions.Max(a => Mathf.RoundToInt((float)a.refreshRateRatio.value));
    internal static float PositiveScaleFactor => MainAspect / NativeAspect;
    private const float NativeAspect = 16f / 9f;
    private static ConfigEntry<int> CustomRefreshRate { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static int MainWidth => Display.main.systemWidth; //3440
    private static int MainHeight => Display.main.systemHeight; //1440
    internal static float MainAspect => (float)MainWidth / MainHeight;
    private static ConfigEntry<bool> UseCustomRefreshRate { get; set; }
    private static ConfigEntry<int> TargetFramerate { get; set; }
    private static ConfigEntry<string> VSyncSetting { get; set; }

    private static readonly Dictionary<string, int> VSyncOptions = new()
    {
        { "Disabled (Higher Performance)", 0 },
        { "Enabled (Every Refresh)", 1 },
        { "Enabled (Every 2nd Refresh)", 2 }
    };


    private static ConfigEntry<string> Resolution { get; set; }

    internal static Resolution SelectedResolution
    {
        get
        {
            var res = Resolution.Value.Split('x');
            return new Resolution
            {
                width = int.Parse(res[0]),
                height = int.Parse(res[1])
            };
        }
    }

    private static string[] GetResolutions()
    {
        var mainRes = new Resolution
        {
            width = MainWidth,
            height = MainHeight,
            refreshRate = RefreshRate
        };
        var resList = new List<Resolution> { mainRes };
        resList.AddRange(Screen.resolutions);
        resList.SortByPixelCount();

        var finalList = resList.Select(a => $"{a.width}x{a.height}").Distinct().ToArray();
        return finalList;
    }

    private void Awake()
    {
        Debug.unityLogger.logEnabled = true;

        var customRates = MergeUnityRefreshRates();

        Log = Logger;

        Resolution = Config.Bind("01. Display", "Resolution", $"{MainWidth}x{MainHeight}",
            new ConfigDescription(
                "Choose the screen resolution for the game. Options are based on your monitor's supported resolutions.",
                new AcceptableValueList<string>(GetResolutions()),
                new ConfigurationManagerAttributes { Order = 99 }));
        Resolution.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

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
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh,
            new ConfigDescription(
                "Set the maximum frame rate the game will target. This works only when VSync is turned off.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 97 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

        VSyncSetting = Config.Bind("01. Display", "VSync Setting", "Disabled (Higher Performance)",
            new ConfigDescription(
                "Control how VSync synchronizes the game’s frame rate with your monitor's refresh rate to prevent screen tearing:\n" +
                "- Disabled (Higher Performance): Turns off synchronization, potentially improving performance but may cause screen tearing.\n" +
                "- Enabled (Every Refresh): Synchronizes with every monitor refresh, ensuring smooth visuals but might slightly reduce performance.\n" +
                "- Enabled (Every 2nd Refresh): Synchronizes with every second monitor refresh, effectively halving the refresh rate for weaker hardware or demanding setups.",
                new AcceptableValueList<string>(VSyncOptions.Keys.ToArray()),
                new ConfigurationManagerAttributes { Order = 96 }));
        VSyncSetting.SettingChanged += (_, _) => UpdateAll();

        UseCustomRefreshRate = Config.Bind("01. Display", "Use Custom Refresh Rate", false,
            new ConfigDescription(
                "Enable this option if Unity reports the wrong maximum refresh rate for your display. Allows setting a custom refresh rate.",
                null,
                new ConfigurationManagerAttributes { Order = 95 }));
        UseCustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        CustomRefreshRate = Config.Bind("01. Display", "Custom Refresh Rate", RefreshRate,
            new ConfigDescription(
                "Manually define a refresh rate to use if 'Use Custom Refresh Rate' is enabled.",
                new AcceptableValueList<int>(customRates),
                new ConfigurationManagerAttributes { Order = 94 }));
        CustomRefreshRate.SettingChanged += (_, _) =>
        {
            RequiresUpdate = true;
            UpdateAll();
        };

        TargetFramerate = Config.Bind("01. Display", "Target Framerate", MaxRefresh, new ConfigDescription("Set the target framerate - this will only function when VSYNC is OFF (0)", new AcceptableValueList<int>(customRates), new ConfigurationManagerAttributes { Order = 95 }));
        TargetFramerate.SettingChanged += (_, _) => UpdateAll();

        SceneManager.sceneLoaded += OnSceneLoaded;
        // Application.focusChanged += FocusChanged;

        RequiresUpdate = true;

        UpdateAll();

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    internal static Dictionary<string, float> MeshRenderers = new();

    private static void UpdateAll()
    {
        UpdateDisplay();
        UpdateCameras();

        var meshRenderers = Object.FindObjectsOfType<MeshRenderer>();
        foreach (var meshRenderer in meshRenderers)
        {
            // Get the unique path for this GameObject
            var path = meshRenderer.gameObject.GetPath();

            // Get the current X scale of the MeshRenderer's transform
            var currentScaleX = meshRenderer.transform.localScale.x;

            // Check if this path is already in the dictionary
            if (!MeshRenderers.TryGetValue(path, out var originalScaleX))
            {
                // Backup the original scale if not already backed up
                MeshRenderers.Add(path, currentScaleX);
                originalScaleX = currentScaleX; // Use the current scale as the original
            }

            // Adjust the scale using the original X value
            var newX = originalScaleX * PositiveScaleFactor;
            meshRenderer.transform.localScale = new Vector3(newX, meshRenderer.transform.localScale.y, meshRenderer.transform.localScale.z);

            // Log the updated scale for debugging
            Plugin.Log.LogWarning($"MeshRenderer: {meshRenderer.gameObject.GetPath()} - Updated Scale: {meshRenderer.transform.localScale}");
        }
    }

    private static void CamFix(Camera cam)
    {
        if (cam.targetTexture != null)
        {
            RenderTexture targetTexture = cam.targetTexture;
            RenderTextureDescriptor descriptor = targetTexture.descriptor;
            if (descriptor.width != Display.main.systemWidth)
            {
                descriptor.width = Display.main.systemWidth;
                descriptor.height = Display.main.systemHeight;
                RenderTexture renderTexture = new RenderTexture(descriptor)
                {
                    filterMode = targetTexture.filterMode,
                    name = targetTexture.name
                };
                cam.targetTexture = renderTexture;
                if (cam.targetTexture == renderTexture)
                {
                    targetTexture.Release();
                }
            }
        }
    }

    private static void UpdateCameras()
    {
        var cameras = Camera.allCameras;
        foreach (var camera in cameras)
        {
            CamFix(camera);
            var ppc = camera.gameObject.TryAddComponent<PixelPerfectCamera>();

            if (ppc)
            {
                // ppc.assetsPPU = 26;
                ppc.refResolutionX = 860;
                ppc.refResolutionY = 360;
                ppc.enabled = true;
                ppc.cropFrame = PixelPerfectCamera.CropFrame.None;
            }

            camera.aspect = MainAspect;
            camera.rect = new Rect(0, 0, 1, 1);
            camera.pixelRect = new Rect(0, 0, 860, 360);
        }
    }

   

    private static void UpdateDisplay()
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


        if (!RequiresUpdate) return;

        Screen.SetResolution(SelectedResolution.width, SelectedResolution.height, FullScreenModeConfig.Value, RefreshRateRatio);
        Log.LogInfo($"Resolution updated: {SelectedResolution.width}x{SelectedResolution.height}, Full Screen Mode={FullScreenModeConfig.Value}, Refresh Rate={RefreshRate}Hz");

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        RequiresUpdate = false;
    }

    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    private static bool RequiresUpdate { get; set; }

    private static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions
            .Select(a => Mathf.RoundToInt((float)a.refreshRateRatio.value))
            .Distinct()
            .ToArray();


        var customRates = new List<int>();
        customRates.AddRange(unityRates);
        customRates.AddRange(CustomRefreshRates);
        return customRates.Distinct().OrderBy(a => a).ToArray();
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }

// private static void FocusChanged(bool focus)
// {
//     Application.runInBackground = RunInBackground.Value;
//     var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
//     foreach (var audioSource in audioSources)
//     {
//         audioSource.mute = !focus && MuteInBackground.Value;
//     }
// }
//

// private static void UpdateFixedDeltaTime()
// {
//     OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);
//     if (Mathf.Approximately((float)Screen.currentResolution.refreshRateRatio.value, OriginalFixedDeltaTime.Value) ||
//         OriginalFixedDeltaTime.Value > Screen.currentResolution.refreshRateRatio.value)
//     {
//         Log.LogInfo(
//             "Games physics update rate is already equal to (or greater than) your monitors refresh rate. Skipping update.");
//         return;
//     }
//
//     if (CorrectFixedUpdateRate.Value)
//     {
//         if (UseRefreshRateForFixedUpdateRate.Value)
//         {
//             Time.fixedDeltaTime = (float)(1f / Screen.currentResolution.refreshRateRatio.value);
//         }
//         else
//         {
//             Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(Screen.currentResolution.refreshRateRatio.value);
//         }
//     }
//     else
//     {
//         Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
//     }
//
//     Log.LogInfo($"Physics update rate set to {1f / Time.fixedDeltaTime}Hz");
// }
}