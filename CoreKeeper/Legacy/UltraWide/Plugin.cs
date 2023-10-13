using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using PugRP;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace UltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.corekeeper.ultrawide";
    private const string PluginName = "CoreKeeper UltraWide";
    private const string PluginVersion = "0.0.2";

    private const string LeftPillarBoxName = "Left";
    private const string RightPillarBoxName = "Right";
    private static ConfigEntry<bool> UseCustomMaxWidth { get; set; }
    private static ConfigEntry<int> CustomMaxWidth { get; set; }

    private static ManualLogSource Logger { get; set; }
    private static Options Options { get; set; }
    

    private static int CalculateMaxWidth()
    {
        var aspect = Display.main.systemWidth / (float) Display.main.systemHeight;

        // Define your reference points (16:9 and 3440x1440)
        const float minAspect = 16f / 9f;  
        const float refAspect = 3440f / 1440f; // Actual aspect ratio for 3440x1440

        const float minWidth = 480;
        const float refWidth = 648; // Corresponding width value for the reference aspect

        float maxWidth;

        // If the aspect is less than or equal to the reference aspect (3440x1440)
        if (aspect <= refAspect)
        {
            // Interpolate between minWidth (480) and refWidth (648) based on the aspect ratio
            var t = (aspect - minAspect) / (refAspect - minAspect);
            maxWidth = minWidth + (refWidth - minWidth) * t;
        }
        else
        {
            // If the aspect is larger than the reference aspect, scale proportionally
            maxWidth = refWidth * (aspect / refAspect);
        }

        // Increase by 2% and round
        var roundedMaxWidth = Mathf.RoundToInt(maxWidth * 1.02f);

        return roundedMaxWidth;
    }



    public override void Load()
    {
        Logger = Log;
        Options = AddComponent<Options>();
        var maxWidth = CalculateMaxWidth();
        Options.SliderValueMax = maxWidth;
        UseCustomMaxWidth = Config.Bind("General", "UseCustomMaxWidth", false, "At auto, you will see the world spawning/de-spawning. It's not so bad at 21:9, but will be worse at wider resolutions. Adjust this value to your liking.");
        Options.ToggleState = UseCustomMaxWidth.Value;
        Options.OnToggleValueChanged += delegate(bool value) { UseCustomMaxWidth.Value = value; };
        UseCustomMaxWidth.SettingChanged += (_, _) =>
        {
            if (UseCustomMaxWidth.Value)
            {
                UpdatePugCameras(true);
            }
            else
            {
                UpdatePugCameras();
            }
        };
        CustomMaxWidth = Config.Bind("General", "MaxWidth", maxWidth, new ConfigDescription("This is not the width in screen pixels. For example at 3440x1440 (21:9), a value of 648 expands the viewport entirely.", new AcceptableValueRange<int>(480, maxWidth)));
        Options.SliderValue = CustomMaxWidth.Value;
        Options.OnSliderValueChanged += delegate(float value) { CustomMaxWidth.Value = Mathf.CeilToInt(value); };
        CustomMaxWidth.SettingChanged += (_, _) =>
        {
            Logger.LogWarning($"CustomMaxWidth: {CustomMaxWidth.Value}");
            if (UseCustomMaxWidth.Value)
            {
                UpdatePugCameras(true);
            }
        };
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
    }

    public override bool Unload()
    {
        SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>) SceneManagerOnSceneLoaded;
        return base.Unload();
    }
    
    private static void UpdatePugCameras(bool custom = false)
    {
        var pugCameras = Resources.FindObjectsOfTypeAll<PugCamera>();
        foreach (var cam in pugCameras)
        {
            if (UseCustomMaxWidth.Value)
            {
                cam.m_outputMode = OutputMode.Fixed;
                cam.m_outputWidth = CustomMaxWidth.Value;
            }
            else
            {
                cam.m_outputMode = OutputMode.MatchAspect;
            }
            if (cam.camera != null)
            {
                cam.camera.aspect = Display.main.systemWidth / (float) Display.main.systemHeight;
            }
        }
        
    }

    private static void RemovePillars()
    {
        var spr = Resources.FindObjectsOfTypeAll<SpriteRenderer>();
        foreach (var s in spr)
        {
            if (s.name == LeftPillarBoxName)
            {
                s.gameObject.SetActive(false);
            }

            if (s.name == RightPillarBoxName)
            {
                s.gameObject.SetActive(false);
            }
        }
    }

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
            cam.aspect = Display.main.systemWidth / (float) Display.main.systemHeight;
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        UpdateCameras();
        UpdatePugCameras();
        RemovePillars();
    }
}