using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.Mono;
using HarmonyLib;
using PugRP;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.corekeeper.ultrawide";
    private const string PluginName = "CoreKeeper UltraWide (BepInEx 6)";
    private const string PluginVersion = "0.0.3";

    private const string LeftPillarBoxName = "Left";
    private const string RightPillarBoxName = "Right";
    
    private static float AspectRatio => Display.main.systemWidth / (float) Display.main.systemHeight;
    private static float DisplayWidth => Display.main.systemWidth;
    private static float DisplayHeight => Display.main.systemHeight;
    private static ConfigEntry<bool> UseCustomMaxWidth { get; set; }
    private static ConfigEntry<int> CustomMaxWidth { get; set; }

    internal static Harmony HarmonyInstance { get; set; }
    internal static ManualLogSource Log { get; private set; }
    private static Options Options { get; set; }
    

    private static int CalculateMaxWidth()
    {

        // Define your reference points (16:9 and 3440x1440)
        const float minAspect = 16f / 9f;  
        const float refAspect = 3440f / 1440f; // Actual aspect ratio for 3440x1440

        const float minWidth = 480;
        const float refWidth = 648; // Corresponding width value for the reference aspect

        float maxWidth;

        // If the aspect is less than or equal to the reference aspect (3440x1440)
        if (AspectRatio <= refAspect)
        {
            // Interpolate between minWidth (480) and refWidth (648) based on the aspect ratio
            var t = (AspectRatio - minAspect) / (refAspect - minAspect);
            maxWidth = minWidth + (refWidth - minWidth) * t;
        }
        else
        {
            // If the aspect is larger than the reference aspect, scale proportionally
            maxWidth = refWidth * (AspectRatio / refAspect);
        }

        // Increase by 2% and round
        var roundedMaxWidth = Mathf.RoundToInt(maxWidth * 1.02f);

        return roundedMaxWidth;
    }

    private void Awake()
    {
        HarmonyInstance = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log = Logger;
        
        Options = gameObject.AddComponent<Options>();
        Options.enabled = true;
        
        var maxWidth = CalculateMaxWidth();
        Options.SliderValueMax = maxWidth;
        UseCustomMaxWidth = Config.Bind("General", "UseCustomMaxWidth", false, "At auto, you will see the world spawning/de-spawning. It's not so bad at 21:9, but will be worse at wider resolutions. Adjust this value to your liking.");
        Options.ToggleState = UseCustomMaxWidth.Value;
        Options.OnToggleValueChanged += delegate(bool value) { UseCustomMaxWidth.Value = value; };
        UseCustomMaxWidth.SettingChanged += (_, _) =>
        {
           
                UpdatePugCameras();
            
        };
        CustomMaxWidth = Config.Bind("General", "MaxWidth", maxWidth, new ConfigDescription("This is not the width in screen pixels. For example at 3440x1440 (21:9), a value of 648 expands the viewport entirely.", new AcceptableValueRange<int>(480, maxWidth)));
        Options.SliderValue = CustomMaxWidth.Value;
        Options.OnSliderValueChanged += delegate(float value) { CustomMaxWidth.Value = Mathf.CeilToInt(value); };
        CustomMaxWidth.SettingChanged += (_, _) =>
        {
            Logger.LogWarning($"CustomMaxWidth: {CustomMaxWidth.Value}");
            
                UpdatePugCameras();
            
        };
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Screen.SetResolution((int) DisplayWidth, (int) DisplayHeight, true, 120);
        Time.fixedDeltaTime = 1f / 120f;

    }

    
    private static void UpdatePugCameras()
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
                cam.camera.aspect = AspectRatio;
            }

            cam.outputSmoothing = true;
        }
        
    }

    private static void RemovePillars()
    {
        
        var ppb = Resources.FindObjectsOfTypeAll<PP_BlackBorders>();
        foreach (var pp in ppb)
        {
            pp.aspectRatio = AspectRatio;
            pp.letterboxHeight = DisplayHeight;
            pp.letterboxWidth = DisplayWidth;
        }
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

    // private static void UpdateRenderers()
    // {
    //     var renderers = Resources.FindObjectsOfTypeAll<Renderer>();
    //     foreach (var renderer in renderers)
    //     {
    //         if (renderer != null)
    //         {
    //             // Set bounds to infinity
    //             renderer.bounds.SetMinMax(-Vector3.one * float.MaxValue, Vector3.one * float.MaxValue);
    //         }
    //     }
    //
    //     var spriteRenderers = Resources.FindObjectsOfTypeAll<SpriteRenderer>(); 
    //     foreach (var renderer in spriteRenderers)
    //     {
    //         if (renderer != null)
    //         {
    //             // Set bounds to infinity
    //             renderer.bounds.SetMinMax(-Vector3.one * float.MaxValue, Vector3.one * float.MaxValue);
    //         }
    //     }
    // }

    private static void UpdateCameras()
    {
        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
            cam.aspect = AspectRatio;
            cam.pixelRect = new Rect(0, 0, DisplayWidth, DisplayHeight);
            cam.rect = new Rect(0, 0, DisplayWidth, DisplayHeight);
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Screen.SetResolution((int) DisplayWidth, (int) DisplayHeight, true, 120);
        UpdateCameras();
        UpdatePugCameras();
        RemovePillars();
       // UpdateRenderers();
    }
}