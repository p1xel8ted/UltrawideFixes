using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AnodeHeart;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.anodeheart.ultrawide";
    private const string PluginName = "Anode Heart Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const string Logo = "Logo";
    private const string Title = "Title";
    internal static ManualLogSource Log { get; private set; }
  
    internal static ConfigEntry<float> ConfigZoom { get; private set; }
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    private void Awake()
    {
        Log = Logger;
        ConfigZoom = Config.Bind("01. General", "Zoom", 1.25f,
            new ConfigDescription("Zoom of the game. Adjust as necessary.",
                new AcceptableValueRange<float>(0.1f, 2f), new ConfigurationManagerAttributes {Order = 1}));

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        SceneManager.sceneLoaded += OnSceneLoaded;
        Logger.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Log.LogInfo($"Scene loaded: {arg0.name}");
        if (arg0.name.Equals(Logo))
        {
            SceneManager.LoadScene(Title);
        }

        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Time.fixedDeltaTime = 1f / MaxRefresh;
        Application.targetFrameRate = MaxRefresh;
    }
}