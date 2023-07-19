using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace TrainValleyOne
{
    [HarmonyPatch]
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private static ManualLogSource _log;

        private void Awake()
        {
            _log = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(_log);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "p1xel8ted.WonderBoyReturnsRemix.fixes");
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        private void Update()
        {
            var leftBar = GameObject.Find("UI Root/leftBlackBar");
            if (leftBar != null)
            {
                leftBar.SetActive(false);
            }

            var rightBar = GameObject.Find("UI Root/rightBlackBar");
            if (rightBar != null)
            {
                rightBar.SetActive(false);
            }

            var leftToolbar = GameObject.Find("UI Root/Toolbar/Left");
            if (leftToolbar != null)
            {
                leftToolbar.transform.position = new Vector3(0, Display.main.systemHeight, 0);
            }

            var rightToolbar = GameObject.Find("UI Root/Toolbar/Right");
            if (rightToolbar != null)
            {
                rightToolbar.transform.position = new Vector3(Display.main.systemWidth, Display.main.systemHeight, 0);
            }

            var gauge = GameObject.Find("UI Root/Gauge/pcGauge");
            if (gauge != null)
            {
                var position = gauge.transform.position;
                position = new Vector3(Display.main.systemWidth - 50, position.y, position.z);
                gauge.transform.position = position;
            }
        }
    }
}