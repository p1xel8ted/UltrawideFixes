using BepInEx;
using BepInEx_IL2CPP;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ShopTitans;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.shoptitans.ultrawide";
    private const string PluginName = "Shop Titans UltraWide";
    private const string PluginVersion = "0.1.0";
    internal static ManualLogSource LOG { get; private set; }

    public override void Load()
    {
        LOG = Log;
        LOG.LogInfo($"Plugin {PluginGuid} is loaded!");
        Utils.AttachToSceneOnLoaded(SceneManager_sceneLoaded);
    }

    private static void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        LOG.LogWarning($"Scene loaded: {arg0.name} {arg1}");
        Screen.SetResolution(3440, 1440, FullScreenMode.FullScreenWindow, 120);
        Application.targetFrameRate = 120;
        Time.fixedDeltaTime = 1f / 120f;
        foreach (var cam in Utils.FindIl2CppType<Camera>())
        {
            LOG.LogWarning($"Camera: {cam.name}");
            cam.aspect = 21f / 9f;
            cam.rect = new Rect(0f, 0f, 1f, 1f);
            cam.pixelRect = new Rect(0f, 0f, 3440f, 1440f);
        }
    }
}