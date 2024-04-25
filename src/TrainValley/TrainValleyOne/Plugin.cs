using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Experimental.PlayerLoop;

namespace TrainValleyOne;

[HarmonyPatch]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.trainvalleyone.ultrawide";
    private const string PluginName = "Train Valley Ultra-Wide";
    private const string PluginVersion = "0.1.3";
    private const string UIRootLeftBlackBar = "UI Root/leftBlackBar";
    private const string UIRootRightBlackBar = "UI Root/rightBlackBar";

    private static ConfigEntry<bool> RunInBackground { get; set; }
    internal static float MainAspectRatio => (float) MainWidth / MainHeight;
    internal const float BaseAspectRatio = 16f / 9f;
    internal static float PositiveScaleFactor => MainAspectRatio / BaseAspectRatio;
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static int MainWidth => Display.displays[0].systemWidth;
    internal static int MainHeight => Display.displays[0].systemHeight;
    private static int MaxRefresh = 60;
    internal static ManualLogSource Log { get; set; }
    internal static ConfigEntry<bool> ExpandUI { get; private set; }
    internal static ConfigEntry<int> GaugeAdjustment { get; private set; }
    private static GameObject LeftBar { get; set; }
    private static GameObject RightBar { get; set; }

    private static ConfigEntry<bool> MuteInBackground { get; set; }
    //cant use linq
    private static void CalculateMaxRefreshRate()
    {
        MaxRefresh = 0;
        foreach (var res in Screen.resolutions)
        {
            if (res.refreshRate > MaxRefresh)
            {
                MaxRefresh = res.refreshRate;
            }
        }
    }
    
    private void Awake()
    {
        
        CalculateMaxRefreshRate();
        
        var numberOfDisplays = Display.displays.Length;
        var displayIndices = new int[numberOfDisplays];
        
        for (var i = 0; i < numberOfDisplays; i++)
        {
            displayIndices[i] = i;
        }

        DisplayToUse = Config.Bind("01. Display Settings", "Display To Use", 0,
            new ConfigDescription("The display to use for the game. 0 is generally the main.",
                new AcceptableValueList<int>(displayIndices)));
        DisplayToUse.SettingChanged += (_, _) => UpdateDisplay();


        ExpandUI = Config.Bind("02. UI", "Expand UI", true, new ConfigDescription("Expand UI to fill the screen."));
        GaugeAdjustment = Config.Bind("02. UI", "Gauge Adjustment", 5, new ConfigDescription("Fine-tune the gauge position if needed. Default of 5 should be fine however.", new AcceptableValueRange<int>(-50, 50)));

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus."));
        RunInBackground.SettingChanged += (_, _) =>
        {
            UpdateMisc();
        };
        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus."));
        Application.focusChanged += _ =>
        {
            UpdateMisc();
        };
        
        Log = Logger;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateMisc()
    {
        foreach (var source in Resources.FindObjectsOfTypeAll<AudioSource>().ToList())
        {
            source.mute = !Application.isFocused && MuteInBackground.Value;
        }

        Application.runInBackground = RunInBackground.Value;
    }
    private static void UpdateDisplay()
    {
        Display.displays[0].Activate();
        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;
    }

    private static void UpdateLetterboxing()
    {
        LeftBar = GameObject.Find(UIRootLeftBlackBar);
        RightBar = GameObject.Find(UIRootRightBlackBar);

        if (LeftBar)
        {
            LeftBar.SetActive(false);
        }

        if (RightBar)
        {
            RightBar.SetActive(false);
        }  
    }


    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateMisc();
        UpdateDisplay();
        UpdateLetterboxing();
    }

}