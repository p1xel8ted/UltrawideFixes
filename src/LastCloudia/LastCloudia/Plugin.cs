using System;
using System.Linq;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace LastCloudia;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.lastcloudia.ultrawide";
    private const string PluginName = "Last Cloudia Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;


    internal const float SuperWideAspectRatio = 32f / 9f;
    internal const float BaseAspectRatio = 16f / 9f;

    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    internal static float NegativeScaleFactor => BaseAspectRatio / MainAspectRatio;
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<int> FieldOfView { get; set; }
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ManualLogSource Logger { get; set; }

    
    public class MonoBehaviours : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                ConfigInstance.Reload();   
            }
        }
    }

    private static ConfigFile ConfigInstance;
    public override void Load()
    {
        ConfigInstance = Config;
        Config.ConfigReloaded += (_, _) =>
        {
            Logger.LogInfo("Config reloaded!");
            UpdateDisplay();
        };
        
        AddComponent<MonoBehaviours>();
        ClassInjector.RegisterTypeInIl2Cpp<CameraFieldOfViewForcer>();
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

        FieldOfView = Config.Bind("02. Camera", "Field of View", 75, new ConfigDescription("Increase or decrease the field of view of the camera. Default is 50% increases", new AcceptableValueRange<int>(0, 300), new ConfigurationManagerAttributes {Order = 100}));

        RunInBackground = Config.Bind("04. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes {Order = 99}));
        RunInBackground.SettingChanged += (_, _) =>
        {
            Application.runInBackground = RunInBackground.Value;
        };

        MuteInBackground = Config.Bind("04. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes {Order = 98}));

        Application.focusChanged += (Il2CppSystem.Action<bool>) FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void FocusChanged(bool focus)
    {
        AudioListener.pause = !focus && MuteInBackground.Value;
    }

    private readonly static string[] CutsceneCameras = ["AdapsBgCamera", "AdapsDollsCamera", "AdapsEnvCamera"];
    private readonly static string[] RectsToAdjust = ["shadow_effect"];
    
    private static void SceneManagerOnSceneLoaded(Scene a, LoadSceneMode l)
    {
        UpdateDisplay();

        var rects = Utils.FindIl2CppType<RectTransform>();
        foreach (var rect in rects.Where(rect => RectsToAdjust.Contains(rect.name)))
        {
            rect.sizeDelta = rect.sizeDelta with {x = MainWidth};
        }

        var cameras = Utils.FindIl2CppType<Camera>();
        foreach (var camera in cameras)
        {
            
            var path = camera.transform.GetFullPath();
            if (path.Contains("CameraRoot/Shake"))
            {
                camera.pixelRect = new Rect(0, 150f, MainWidth, MainHeight - 150f);  
            }
            
            
            if (CutsceneCameras.Contains(camera.name))
            {
                if (!camera.gameObject.GetComponent<CameraFieldOfViewForcer>())
                {
                    camera.gameObject.AddComponent<CameraFieldOfViewForcer>();
                }
            }
        }
    }

    private class CameraFieldOfViewForcer : MonoBehaviour
    {
        private Camera _camera;
        private void Start()
        {
            _camera = GetComponent<Camera>();
        }

        private void LateUpdate()
        {
            _camera.fieldOfView = FieldOfView.Value;
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