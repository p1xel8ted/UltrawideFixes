using System.Collections.Generic;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Cinemachine;
using MSL.GameEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AgathaChristieMOE;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.agathachristiemoe.ultrawidefix";
    private const string PluginName = "Agatha Christie - MoE Cutscene Fix";
    private const string PluginVersion = "0.0.1";
    private const string BlackBorders = "BlackBorders";
    private const string Shoulder = "shoulder";
    private static ManualLogSource LOG { get; set; }
    private static List<AspectRatioFitter> AspectRatioFitters { get; } = new();
    private static List<AspectRatioFitterMax> AspectRatioFitterMaxs { get; } = new();
    private static CinemachineVirtualCamera ShoulderCam { get; set; } = new();
    private static ConfigEntry<AspectRatioFitter.AspectMode> AspectModeConfig { get; set; }
    private static ConfigEntry<Camera.GateFitMode> GateFitConfig { get; set; }

    private void Awake()
    {
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        AspectModeConfig = Config.Bind("Video", "Aspect Mode", AspectRatioFitter.AspectMode.None, new ConfigDescription("Suggest leaving this on None, but you can try other modes if you want to. You will need to restart the game to go back to None."));
        AspectModeConfig.SettingChanged += (_, _) => { UpdateAr(); };
        GateFitConfig = Config.Bind("Video", "Gate Fit", Camera.GateFitMode.Vertical, new ConfigDescription("Switch between Hor+ etc. Vertical = Hor+ (default), Horizontal = Vert+, Overscan = Hor-, None = Vert-."));
        GateFitConfig.SettingChanged += (_, _) => { UpdateGateFit(); };
        LOG = new ManualLogSource("Agatha Christie - MoE Cutscene Fix");
        BepInEx.Logging.Logger.Sources.Add(LOG);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateGateFit()
    {
        ShoulderCam ??= Resources.FindObjectsOfTypeAll<CinemachineVirtualCamera>().FirstOrDefault(a => a.name.ToLowerInvariant().Contains(Shoulder));
        if (ShoulderCam == null) return;
        var lens = ShoulderCam.m_Lens;
        lens.GateFit = GateFitConfig.Value;
        ShoulderCam.m_Lens = lens;
    }

    private static void UpdateAr()
    {
        AspectRatioFitters.RemoveAll(a => a is null);
        AspectRatioFitterMaxs.RemoveAll(a => a is null);
        foreach (var arf in AspectRatioFitters.Where(a => a is not null))
        {
            if (arf.isActiveAndEnabled)
            {
                arf.aspectMode = AspectModeConfig.Value;
            }
        }

        foreach (var arf in AspectRatioFitterMaxs.Where(a => a is not null))
        {
            if (arf.isActiveAndEnabled)
            {
                arf.aspectMode = AspectModeConfig.Value;
            }
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, Screen.resolutions.Max(a => a.refreshRate));
        AspectRatioFitters.Clear();
        AspectRatioFitterMaxs.Clear();
        ShoulderCam = null;
        UpdateGateFit();
      

        var aspectRatioFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
        foreach (var arf in aspectRatioFitters)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.None;
            AspectRatioFitters.Add(arf);
        }

        var aspectRatioFitterMaxes = Resources.FindObjectsOfTypeAll<AspectRatioFitterMax>();
        foreach (var arf in aspectRatioFitterMaxes)
        {
            arf.aspectMode = AspectRatioFitter.AspectMode.None;
            AspectRatioFitterMaxs.Add(arf);
        }

        var rectTransform = Resources.FindObjectsOfTypeAll<RectTransform>();
        foreach (var rect in rectTransform)
        {
            if (rect.name.Equals(BlackBorders))
            {
                rect.gameObject.SetActive(false);
            }
        }
    }
}