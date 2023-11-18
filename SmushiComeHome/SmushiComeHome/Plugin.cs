using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Cinemachine;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SmushiComeHome;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.smushicomehome.ultrawidefix";
    private const string PluginName = "Smushi Come Home - Ultrawide Fix";
    private const string PluginVersion = "0.1.0";
    private const string IntroVideo = "IntroVideo";
    private const string TestMainMenu = "TestMainMenu";
    private const string CmVcamPlayer = "CM VCAM Player";
    private const string PixelCanvas = "Pixel Canvas";
    private const string ComSinai = "com.sinai";

    private static readonly WriteOnce<float> OriginalFoV = new();
    private static ConfigEntry<bool> CustomScale { get; set; }
    private static ConfigEntry<float> CustomScaleValue { get; set; }
    private static ConfigEntry<bool> CustomFieldOfView { get; set; }
    private static ConfigEntry<int> CustomFieldOfViewValue { get; set; }
    private static List<CanvasScaler> CanvasScalers { get; set; } = [];
    private static List<CinemachineVirtualCamera> CinemachineVirtualCameras { get; set; } = [];
    private static ManualLogSource LOG { get; set; }

    private void Awake()
    {
        LOG = Logger;
        CustomScale = Config.Bind("01. UI Scaling", "Use Custom Scale", false, "Use custom scale");
        CustomScale.SettingChanged += (_, _) => UpdateScalers();
        CustomScaleValue = Config.Bind("01. UI Scaling", "Custom Scale", 1f, new ConfigDescription("Custom scale value", new AcceptableValueRange<float>(0.1f, 10f)));
        CustomScaleValue.SettingChanged += (_, _) => UpdateScalers();
        CustomFieldOfView = Config.Bind("02. Field of View", "Use Custom Field of View", false, "Use custom field of view");
        CustomFieldOfView.SettingChanged += (_, _) => UpdateFoV();
        CustomFieldOfViewValue = Config.Bind("02. Field of View", "Field of View", 65, new ConfigDescription("Custom field of view", new AcceptableValueRange<int>(30, 120)));
        CustomFieldOfViewValue.SettingChanged += (_, _) => UpdateFoV();
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= SceneManagerOnSceneLoaded;
    }

    private static float GetNewScale(float reference)
    {
        var displayHeight = Display.main.systemHeight;
        var scale = 1f / (reference / displayHeight);
        return scale;
    }

    private static void UpdateFoV()
    {
        foreach (var vc in CinemachineVirtualCameras.Where(a => a != null && a.name.Equals(CmVcamPlayer)))
        {
            OriginalFoV.Value = vc.m_Lens.FieldOfView;
            vc.m_Lens.FieldOfView = CustomFieldOfView.Value ? CustomFieldOfViewValue.Value : OriginalFoV;
            LOG.LogInfo($"Updated {vc.name} to {vc.m_Lens.FieldOfView}");
        }
    }


    private static void UpdateCanvasScaler(CanvasScaler scaler, float referenceResolutionHeight)
    {
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        var newScale = GetNewScale(referenceResolutionHeight);
        scaler.scaleFactor = CustomScale.Value ? newScale * CustomScaleValue.Value : newScale;
    }

    private static void UpdateScalers()
    {
        foreach (var canvasScaler in CanvasScalers.Where(a => a != null))
        {
            if (canvasScaler.name.Equals(PixelCanvas) || canvasScaler.name.Contains(ComSinai)) continue;
            UpdateCanvasScaler(canvasScaler, canvasScaler.referenceResolution.y);
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.name.Equals(IntroVideo))
        {
            SceneManager.LoadScene(TestMainMenu);
        }

        CanvasScalers = Resources.FindObjectsOfTypeAll<CanvasScaler>().ToList();
        CinemachineVirtualCameras = Resources.FindObjectsOfTypeAll<CinemachineVirtualCamera>().ToList();
        UpdateScalers();
        UpdateFoV();
    }
}