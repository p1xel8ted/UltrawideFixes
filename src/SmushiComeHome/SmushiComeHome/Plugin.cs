using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SmushiComeHome;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.smushicomehome.ultrawidefix";
    private const string PluginName = "Smushi Come Home Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    private const string IntroVideo = "IntroVideo";
    private const string TestMainMenu = "TestMainMenu";

    internal static int MainWidth => Display.displays[0].systemWidth;
    internal static int MainHeight => Display.displays[0].systemHeight;
    internal static int MaxRefreshRate => Screen.resolutions.Max(a => a.refreshRate);
    internal static ConfigEntry<bool> CustomScale { get; private set; }
    internal static ConfigEntry<float> CustomScaleValue { get; private set; }
    internal static ConfigEntry<bool> CustomFieldOfView { get; private set; }
    internal static ConfigEntry<int> CustomFieldOfViewValue { get; private set; }
    internal static ManualLogSource LOG { get; set; }

    private void Awake()
    {
        LOG = Logger;
        CustomScale = Config.Bind("01. UI Scaling", "Use Custom Scale", false, "Use custom scale");
        CustomScaleValue = Config.Bind("01. UI Scaling", "Custom Scale", 1f, new ConfigDescription("Custom scale value", new AcceptableValueRange<float>(0.1f, 10f)));
        CustomFieldOfView = Config.Bind("02. Field of View", "Use Custom Field of View", false, "Use custom field of view");
        CustomFieldOfViewValue = Config.Bind("02. Field of View", "Field of View", 65, new ConfigDescription("Custom field of view", new AcceptableValueRange<int>(30, 120)));
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
    }

    private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.name.Equals(IntroVideo))
        {
            SceneManager.LoadScene(TestMainMenu);
        }
        
        Application.targetFrameRate = MaxRefreshRate;
        Time.fixedDeltaTime = 1f / MaxRefreshRate;
    }
}