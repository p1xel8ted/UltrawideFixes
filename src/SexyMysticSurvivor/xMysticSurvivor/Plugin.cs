using System;
using System.Linq;
using System.Reflection;
using AMG;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace xMysticSurvivor;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.sexymysticsurvivor.xmysticsurvivor";
    private const string PluginName = "Beautiful/Sexy Mystic Survivors Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    internal const float SuperWideAspectRatio = 32f / 9f;
    internal const float BaseAspectRatio = 16f / 9f;

    internal static ManualLogSource LOG { get; private set; }
    internal static float NativeWidth => MainHeight * BaseAspectRatio;
    internal static float MainAspect => (float) MainWidth / MainHeight;
    internal static float NativeAspect => 16f / 9f;
    
    internal static float BlackBarSize => (MainWidth - NativeWidth) / 2;
    internal static float NegativeScaleFactor => BaseAspectRatio / MainAspect;
    internal static float PositiveScaleFactor => MainAspect / BaseAspectRatio;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    private static ConfigEntry<bool> ModifyUiScalingBehaviour { get; set; }
    private static ConfigEntry<bool> IncreaseCameraZoom { get; set; }
    private static ConfigEntry<int> MaxZoomOut { get; set; }
    internal static ConfigEntry<float> CurrentZoomLevel { get; private set; }
    internal static ConfigEntry<bool> StopTransparentTrees { get; private set; }
    internal static ConfigEntry<bool> AutoOpenChests { get; private set; }
    internal static CanvasScaler CanvasOverlay { get; set; }
    internal static CanvasScaler CanvasCamera { get; set; }
    internal static CameraZoomer CameraZoomer { get; set; }
    internal static ConfigEntry<bool> LevelUpVoice { get; private set; }
    internal static ConfigEntry<bool> CollectCrystalsSound { get; private set; }
    internal static ConfigEntry<float> LevelUpVoiceVolume { get; private set; }
    internal static ConfigEntry<float> CollectCrystalsVolume { get; private set; }
    internal static ConfigEntry<float> SunStoneVolume { get; private set; }
    internal static ConfigEntry<bool> SpanHUD { get; private set; }

    private void Awake()
    {
        LOG = Logger;

        FullScreenModeConfig = Config.Bind("01. Display", "Full Screen Mode", FullScreenMode.FullScreenWindow, new ConfigDescription("Set the full screen mode", null, new ConfigurationManagerAttributes {Order = 107}));
        FullScreenModeConfig.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray()), new ConfigurationManagerAttributes {Order = 106}));
        DisplayToUse.SettingChanged += (_, _) =>
        {
            UpdateDisplay();
        };

        CurrentZoomLevel = Config.Bind("0. Hidden", "CurrentZoomLevel", 0.0f,
            new ConfigDescription("Current Zoom Level", null,
                new ConfigurationManagerAttributes {Browsable = false, Order = 13}));
        
        IncreaseCameraZoom = Config.Bind("4. Camera Zoom", "Increase Camera Zoom", true,
            new ConfigDescription("Enable or disable increased camera zoom. When enabled, you can zoom out further than the default limit.", null,
                new ConfigurationManagerAttributes {Order = 7}));
        IncreaseCameraZoom.SettingChanged += (_, _) =>
        {
            SetZoom();
        };

        MaxZoomOut = Config.Bind("4. Camera Zoom", "Max Zoom Out", 10,
            new ConfigDescription("Set the maximum zoom-out level. This determines how far out you can zoom. The game's default level is 10. Zooming too far will expose un-rendered areas.", new AcceptableValueRange<int>(2, 20),
                new ConfigurationManagerAttributes {Order = 6}));
        MaxZoomOut.SettingChanged += (_, _) =>
        {
            SetZoom();
        };

        LevelUpVoice = Config.Bind("5. Sound", "Level Up Voice", true,
            new ConfigDescription("Enable or disable the level up voice sound. Check the box to enable the sound, uncheck to disable it.", null,
                new ConfigurationManagerAttributes {Order = 5}));
        LevelUpVoiceVolume = Config.Bind("5. Sound", "Level Up Voice Volume", 0f,
            new ConfigDescription("Adjust the level up voice volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                new ConfigurationManagerAttributes {Order = 4}));

        CollectCrystalsSound = Config.Bind("5. Sound", "Collect Crystals", true,
            new ConfigDescription("Enable or disable the crystal collection sound. Check the box to enable the sound, uncheck to disable it.", null,
                new ConfigurationManagerAttributes {Order = 3}));
        CollectCrystalsVolume = Config.Bind("5. Sound", "Collect Crystal Volume", 0f,
            new ConfigDescription("Adjust the collect crystal volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                new ConfigurationManagerAttributes {Order = 2}));

        SunStoneVolume = Config.Bind("5. Sound", "Sun Stone Volume", 0f,
            new ConfigDescription("Adjust the sun stone volume. Lower values for quieter volume, higher values for louder volume. A value of 0 means no change from the original volume.", new AcceptableValueRange<float>(-100f, 50f),
                new ConfigurationManagerAttributes {Order = 1}));

        StopTransparentTrees = Config.Bind("6. Misc", "Stop Transparent Trees", true,
            new ConfigDescription("Prevent trees from becoming transparent when the camera is close or zooming in.", null,
                new ConfigurationManagerAttributes {Order = 0}));
        AutoOpenChests = Config.Bind("6. Misc", "Auto Open Chests", true,
            new ConfigDescription("Automatically open chests when the dialog appears.", null,
                new ConfigurationManagerAttributes {Order = -1}));
        RunInBackground = Config.Bind("06. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));

        MuteInBackground = Config.Bind("06. Misc", "Mute In Background", true, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        SpanHUD = Config.Bind("06. Misc", "Span HUD", true, new ConfigDescription("Spans the HUD across the entire screen.", null, new ConfigurationManagerAttributes {Order = 97}));
        
        Application.focusChanged += FocusChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    internal static void SetZoom()
    {
        if (!CameraZoomer) return;
        if (IncreaseCameraZoom.Value)
        {
            CameraZoomer.MaxZoomValue = 1f;
            CameraZoomer.MinZoomValue = MaxZoomOut.Value;
        }
        else
        {
            CameraZoomer.MaxZoomValue = 6f;
            CameraZoomer.MinZoomValue = 10f;
        }
    }

    public class AdjustCamera : MonoBehaviour
    {
        private Camera camera;

        private void Start()
        {
            camera = GetComponent<Camera>();
            Adjust();
        }
        
        private void OnEnable()
        {
            camera = GetComponent<Camera>();
            Adjust();
        }

        private void Adjust()
        {
            // Set culling distances for all layers to a high value
            for (int i = 0; i < camera.layerCullDistances.Length; i++)
            {
                camera.layerCullDistances[i] = 1000f; // Extend culling distance
            }

            // Original game design aspect ratio
            float originalAspect = 16f / 9f;
            // Current window aspect ratio
            float windowAspect = (float)Screen.width / (float)Screen.height;

            // Determine scale factor based on the current and original aspect ratios
            float scaleFactor = windowAspect / originalAspect;

            
                // Adjust orthographic camera
                if (scaleFactor > 1.0f)
                {
                    camera.orthographicSize *= scaleFactor; // Adjust orthographic size to maintain vertical FOV
                    Plugin.LOG.LogInfo($"Adjusted orthographic size for camera {camera.name}");
                }
           
                // Adjust perspective camera
                var mat = camera.projectionMatrix;
                if (scaleFactor > 1.0f)
                {
                    mat = Matrix4x4.Scale(new Vector3(1f / scaleFactor, 1, 1)) * mat; // Scale matrix horizontally
                    Plugin.LOG.LogInfo($"Adjusted projection matrix for camera {camera.name}");
                }
                camera.projectionMatrix = mat;

                // Adjust culling matrix
                Matrix4x4 projectionMatrix = Matrix4x4.Perspective(camera.fieldOfView, windowAspect, camera.nearClipPlane, camera.farClipPlane);
                camera.cullingMatrix = camera.worldToCameraMatrix * projectionMatrix; // Update culling matrix to reflect new aspect ratio
            
        }
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

    private static void UpdateBlurImages()
    {
        var images = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in images)
        {
            if (image.sprite && image.sprite.name.Contains("blur", StringComparison.OrdinalIgnoreCase))
            {
                Plugin.LOG.LogInfo($"Found scalable(?) blur image: {image.name}");
                image.gameObject.ResizeRect();
            }

            if (Mathf.Approximately(image.color.a, 0.6f) || image.name.Equals("BackgroundImage2_BLURMORE"))
            {
                Plugin.LOG.LogInfo($"Found blur image we cant scale, disabling: {image.name}");
                image.enabled = false;
            }
        }
    }


    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        //UpdateBlurImages();
            
        var menuBackground = GameObject.Find("CanvasWorld/BackgroundComp/BackgroundImage2");
        if (menuBackground)
        {
            menuBackground.ResizeRect();
            menuBackground.transform.position = new Vector3(0, 0, -10f);
        }
        
        var disableMe = GameObject.Find("CanvasCamera/WrapperCC/holder");
        if (disableMe)
        {
            disableMe.SetActive(false);
        }

        //disable the left and right black bars
        var leftPane = GameObject.Find("CanvasOverlay/ScreenWrapper/OVERLAY_PLANE_LEFT");
        if (leftPane)
        {
            leftPane.SetActive(false);
        }

        var rightPane = GameObject.Find("CanvasOverlay/ScreenWrapper/OVERLAY_PLANE_RIGHT");
        if (rightPane)
        {
            rightPane.SetActive(false);
        }
        
    }

}