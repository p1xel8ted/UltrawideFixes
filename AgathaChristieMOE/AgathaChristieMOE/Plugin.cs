using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using MSL.GameEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AgathaChristieMOE;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.agathachristiemoe.displaytweaks";
    private const string PluginName = "Agatha Christie - Murder on the Orient Express";
    private const string PluginVersion = "0.1.0";
    private const string BlackBorders = "BlackBorders";
    
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    internal static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ManualLogSource LOG { get; set; }
    internal static ConfigEntry<FullScreenMode> FullScreenModeConfig { get; private set; }
    private static ConfigEntry<AspectRatioFitter.AspectMode> AspectModeConfig { get; set; }
    private static ConfigEntry<string> GateFitConfig { get; set; }
    internal static ConfigEntry<int> FoVMultiplierPercent { get; private set; }

    private void Awake()
    {
        LOG = Logger;
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
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

        FoVMultiplierPercent = Config.Bind("2. Field of View", "FOV Multiplier Percent", 75, new ConfigDescription("Set the FOV multiplier percent. Default is a 75% increase.", new AcceptableValueRange<int>(0, 200), new {ShowAsPercent = true}));
        GateFitConfig = Config.Bind("2. Field of View", "Screen Fitting Strategy", "Hor+", new ConfigDescription("Switch between Hor+ etc. Games default is Hor+.", new AcceptableValueList<string>(GateFitEnumMappings.StringToEnum.Keys.ToArray())));
        GateFitConfig.SettingChanged += (_, _) =>
        {
            UpdateGateFit();
        };
        AspectModeConfig = Config.Bind("3. Cutscene Cropping", "Aspect Mode", AspectRatioFitter.AspectMode.None, new ConfigDescription("Suggest leaving this on None, but you can try other modes if you want to. You will need to restart the game to go back to None."));
        AspectModeConfig.SettingChanged += (_, _) =>
        {
            UpdateAr();
        };

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateGateFit()
    {
        if (!GateFitEnumMappings.StringToEnum.TryGetValue(GateFitConfig.Value, out var gateFitMode)) return;

        if (Patches.ShoulderCam is not null)
        {
            Patches.ShoulderCam.m_Lens = Patches.ShoulderCam.m_Lens with {GateFit = gateFitMode};
        }
    }

    private static void UpdateAr()
    {
        foreach (var arf in Resources.FindObjectsOfTypeAll<AspectRatioFitter>())
        {
            if (arf.isActiveAndEnabled)
            {
                arf.aspectMode = AspectModeConfig.Value;
            }
        }
    
        foreach (var arf in Resources.FindObjectsOfTypeAll<AspectRatioFitterMax>())
        {
            if (arf.isActiveAndEnabled)
            {
                arf.aspectMode = AspectModeConfig.Value;
            }
        }
    }

    private static void UpdateDisplay()
    {
        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);
        Screen.SetResolution(MainWidth, MainHeight, FullScreenModeConfig.Value, MaxRefresh);
    }

    private static void RemoveBlackBorders()
    {
        foreach (var rect in Resources.FindObjectsOfTypeAll<RectTransform>())
        {
            if (rect.name.Equals(BlackBorders))
            {
                rect.gameObject.SetActive(false);
            }
        }   
    }

    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateDisplay();
        UpdateGateFit();
        UpdateAr();
        RemoveBlackBorders();
    }
}