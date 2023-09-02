using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TormentedSouls;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.tormentedsouls.ultrawide";
    private const string PluginName = "Tormented Souls Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    private const string LogosInit = "LogosInit";
    private const string MenuInit = "MenuInit";
    private const string Background = "Background";
    private static ManualLogSource Log { get; set; }

    private void Awake()
    {
        Log = Logger;
        SceneManager.sceneLoaded += OnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        Log.LogInfo($"Plugin {PluginGuid} is loaded!");
    }

    private static GameObject CinematicBlackBarsTop { get; set; }
    private static GameObject CinematicBlackBarsBottom { get; set; }

    private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        CinematicBlackBarsTop ??= GameObject.Find("[LoadingCurtainsManager]/Canvas/CinematicBlackBars/TopBar");
        if (CinematicBlackBarsTop != null)
        {
            CinematicBlackBarsTop.gameObject.SetActive(false);
        }

        CinematicBlackBarsBottom ??= GameObject.Find("[LoadingCurtainsManager]/Canvas/CinematicBlackBars/BottomBar");
        if (CinematicBlackBarsBottom != null)
        {
            CinematicBlackBarsBottom.gameObject.SetActive(false);
        }

        var backgrounds = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var background in backgrounds)
        {
            if (background.name.Equals(Background) && Mathf.Approximately(background.color.a, 0.949f) &&
                background.color is {r: 0, g: 0, b: 0})
            {
                background.transform.localScale = new Vector3(10, 1, 1);
            }
        }

        if (arg0.name.Equals(LogosInit))
        {
            SceneManager.LoadScene(MenuInit);
        }
    }
}