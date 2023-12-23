using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Com.LuisPedroFonseca.ProCamera2D;
using HarmonyLib;
using LGTS.Initialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;


namespace LittleGoodyTwoShoes;

[BepInPlugin(Const.PluginGuid, Const.PluginName, Const.PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log { get; set; }
    internal static LightingLoader LightingLoaderInstance { get; set; }
    internal static ConfigEntry<float> ScaleConfig { get; private set; }
    internal static ConfigEntry<float> CameraZoomConfigValue { get; private set; }
    internal static ConfigEntry<bool> CameraZoomConfig { get; private set; }
    private static ConfigEntry<float> PostProcessingStrength { get; set; }
    internal static ConfigEntry<bool> DialogueFrameConfig { get; private set; }
    private static ConfigEntry<bool> PauseFrameConfig { get; set; }
    internal static ConfigEntry<bool> TitleMenuVoiceOver { get; set; }
    internal static ConfigEntry<bool> AutoAdvanceConfig { get; private set; }
    internal static ConfigEntry<bool> GoStraightToTitleMenu { get; private set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static GameObject PauseFrame { get; set; }
    private static GameObject DialogueFrame { get; set; }
    private static List<CanvasScaler> Scalers { get; set; } = [];
    internal static ProCamera2D ProCamera2DInstance { get; set; }

    private void Awake()
    {
        UpdateVideoPlayers();
        Log = Logger;

        // Category: Display Settings
        CameraZoomConfig = Config.Bind("Display Settings", "Enable Camera Zoom", true,
            new ConfigDescription("Enables or disables the camera zoom feature.",
                null, new ConfigurationManagerAttributes {Order = 20}));
        CameraZoomConfigValue = Config.Bind("Display Settings", "Camera Zoom Level", 1f,
            new ConfigDescription("Adjusts the zoom level of the camera. Range: -5 to 5.",
                new AcceptableValueRange<float>(-5f, 5f), new ConfigurationManagerAttributes {Order = 19}));
        CameraZoomConfigValue.SettingChanged += (_, _) =>
        {
            if (!CameraZoomConfig.Value) return;
            if (Camera.main != null)
            {
                Camera.main.orthographicSize = 5f; // Trigger event
            }
        };
        PostProcessingStrength = Config.Bind("Display Settings", "Post-Processing Intensity", 1f,
            new ConfigDescription("Controls the intensity of post-processing effects. 0% (off) to 100% (full strength).",
                new AcceptableValueRange<float>(0f, 1f), new ConfigurationManagerAttributes {Order = 18}));
        PostProcessingStrength.SettingChanged += (_, _) => UpdateLightingWeight();

        // Category: UI Customization
        ScaleConfig = Config.Bind("UI Customization", "UI/Dialogue Scale", 1.25f,
            new ConfigDescription("Adjusts the scale of the UI and dialogue boxes. Range: -2 to 2.",
                new AcceptableValueRange<float>(-2f, 2f), new ConfigurationManagerAttributes {Order = 20}));
        ScaleConfig.SettingChanged += (_, _) => UpdateScalers();
        PauseFrameConfig = Config.Bind("UI Customization", "Pause Menu Frame", true,
            new ConfigDescription("Enables or disables the decorative frame in the pause menu.",
                null, new ConfigurationManagerAttributes {Order = 19}));
        PauseFrameConfig.SettingChanged += (_, _) => UpdatePauseFrame();
        DialogueFrameConfig = Config.Bind("UI Customization", "Dialogue Window Frame", true,
            new ConfigDescription("Enables or disables the decorative frame in dialogue windows.",
                null, new ConfigurationManagerAttributes {Order = 18}));
        DialogueFrameConfig.SettingChanged += (_, _) => UpdateDialogueFrame();

        // Category: Gameplay Settings
        AutoAdvanceConfig = Config.Bind("Gameplay Settings", "Auto-Advance Dialogue", true,
            new ConfigDescription("Automatically advances dialogue in new conversations.",
                null, new ConfigurationManagerAttributes {Order = 20}));

        // Category: Startup Settings
        GoStraightToTitleMenu = Config.Bind("Startup Settings", "Skip Intro Anime", false,
            new ConfigDescription("Skips the intro anime and goes straight to the title menu on startup.",
                null, new ConfigurationManagerAttributes {Order = 20}));
        TitleMenuVoiceOver = Config.Bind("Startup Settings", "Title Menu Voiceover", false,
            new ConfigDescription("Enables or disables the voiceover on the title menu.",
                null, new ConfigurationManagerAttributes {Order = 19}));

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), Const.PluginGuid);
        SceneManager.sceneLoaded += OnSceneLoaded;
        Logger.LogInfo($"Plugin {Const.PluginName} is loaded!");
    }

    internal static void UpdateScalers()
    {
        // if (!ScaleCorrections.Value) return;
        foreach (var scaler in Scalers.Where(a => a != null && !a.name.ToLowerInvariant().Contains(Const.Sinai)))
        {
            Utils.UpdateScaler(scaler);
        }
    }


    internal static void UpdateDialogueFrame()
    {
        DialogueFrame = GameObject.Find(Const.DialogueWindowFramePath);
        if (DialogueFrame != null)
        {
            DialogueFrame.SetActive(DialogueFrameConfig.Value);
        }
    }

    internal static void UpdatePauseFrame()
    {
        PauseFrame = GameObject.Find(Const.PauseMenuFramePath);
        if (PauseFrame != null)
        {
            PauseFrame.SetActive(PauseFrameConfig.Value);
        }
    }


    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Scalers = Resources.FindObjectsOfTypeAll<CanvasScaler>().ToList();
        Scalers.RemoveAll(a => a.name.Equals(Const.ToastManager));
        Scalers.RemoveAll(a => a.name.Equals(Const.TutorialCanvas));
        Scalers.RemoveAll(a => a.gameObject.GetGameObjectPath().Contains(Const.TitleUI));
        UpdateScalers();

        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;

        UpdatePauseFrame();
        UpdateDialogueFrame();
        UpdateVideoPlayers();
    }


    private static void UpdateVideoPlayers()
    {
        var videoPlayers = Resources.FindObjectsOfTypeAll<VideoPlayer>();
        foreach (var videoPlayer in videoPlayers)
        {
            videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
        }
    }

    public static void UpdateLightingWeight()
    {
        if (LightingLoaderInstance != null)
        {
            LightingLoaderInstance._currentVolume.weight = PostProcessingStrength.Value;
        }
    }
}