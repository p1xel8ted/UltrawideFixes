using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using WitchSpringR.MonoBehaviours;

namespace WitchSpringR;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{

    private const string PluginGuid = "p1xel8ted.witchspringr.ultrawide";
    private const string PluginName = "WitchSpring R Ultra-Wide";
    private const string PluginVersion = "0.1.2";

    internal static int MainWidth => Display.displays[0].systemWidth; //3440
    internal static int MainHeight => Display.displays[0].systemHeight; //1440
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    internal static float MainAspect => MainWidth / (float) MainHeight;
    internal static Rect CameraRect => new(0, 0, MainWidth, MainHeight);
    private static float NormalWidth => MainHeight * 16f / 9f; //2560
    private static float WidthDifference => MainWidth - NormalWidth; //880
    internal static float BlackBarSize => WidthDifference / 2f; //440
    internal static float PositiveScaleFactor => MainWidth / NormalWidth; //1.34375
    internal static ConfigEntry<bool> Bloom { get; private set; }
    internal static ConfigEntry<bool> ToneMapping { get; private set; }
    internal static ConfigEntry<bool> Vignette { get; private set; }
    internal static ConfigEntry<bool> SpanHud { get; private set; }
    internal static ConfigEntry<bool> ShowSkirt { get; private set; }
    internal static ConfigEntry<bool> ShowHat { get; private set; }
    internal static ConfigEntry<bool> ShowRobe { get; private set; }
    internal static ConfigEntry<bool> ShowStaff { get; private set; }
    internal static ConfigEntry<bool> DepthOfField { get; private set; }
    internal static ConfigEntry<int> FieldOfView { get; private set; }
    internal static ManualLogSource Logger { get; private set; }
    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<LeftHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<RightHudMover>();
        ClassInjector.RegisterTypeInIl2Cpp<MiniMapMover>();
        ClassInjector.RegisterTypeInIl2Cpp<ClothsToggler>();
        
        Logger = Log;
        ShowStaff = Config.Bind("01. Equipment", "Show Staff", true, "Show Staff");
        ShowSkirt = Config.Bind("01. Equipment", "Show Skirt", true, "Show Skirt");
        ShowHat = Config.Bind("01. Equipment", "Show Hat", true, "Show Hat");
        ShowRobe = Config.Bind("01. Equipment", "Show Robe", true, "Show Robe");
        
        Bloom = Config.Bind("02. Post-Processing", "Bloom", true, "Enable Bloom");
        ToneMapping = Config.Bind("02. Post-Processing", "Tone Mapping", true, "Enable Tone Mapping");
        Vignette = Config.Bind("02. Post-Processing", "Vignette", true, "Enable Vignette");
        DepthOfField = Config.Bind("02. Post-Processing", "Depth of Field", true, "Enable Depth of Field");
        
        SpanHud = Config.Bind("03. UI", "Span HUD", true, "Span HUD to the edges of the screen");
        
        FieldOfView = Config.Bind("04. Camera", "Field of View", Mathf.RoundToInt(24 * PositiveScaleFactor), new ConfigDescription("Increase or decrease the field of view of the camera.", new AcceptableValueRange<int>(0, 300)));
        
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;
        Display.displays[0].Activate(MainWidth, MainHeight, MaxRefresh);
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals("#Logo"))
        {
            SceneManager.LoadScene("#Title");
        }
        Application.targetFrameRate = MaxRefresh;
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }


}