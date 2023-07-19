using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace Ultrawide;

[BepInPlugin("p1xel8ted.pharaoh.ultrawide", "Ultrawide", "0.1.1")]
[HarmonyPatch]
public class Ultrawide : BaseUnityPlugin
{
    private static Harmony _hi;
    private static ManualLogSource _log;

    public void Awake()
    {
        _hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        _log = new ManualLogSource("Log");
        BepInEx.Logging.Logger.Sources.Add(_log);
        _log.LogWarning($"Plugin Ultrawide is loaded!");
    }

    public void OnDestroy()
    {
        _hi?.UnpatchSelf();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.GetAvailableResolutions))]
    public static void OptionManager_GetAvailableResolutions(ref OptionManager __instance, ref IEnumerable<Resolution> __result)
    {
        var res = new Resolution
        {
            height = Display.main.systemHeight,
            width = Display.main.systemWidth,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };
        __result = __result.Prepend(res);
    }

    private void LateUpdate()
    {
        var graphics = GlobalAccessor.PlayerOptions.Graphics;
        var aspectRatioFitters = FindObjectsOfType<AspectRatioFitter>();
        foreach (var a in aspectRatioFitters)
        {
            a.aspectRatio = (float) graphics.Width / (float) graphics.Height;
        }
    }
}