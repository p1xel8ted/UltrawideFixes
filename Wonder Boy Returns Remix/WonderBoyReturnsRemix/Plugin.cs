using System;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace WonderBoyReturnsRemix
{
    [HarmonyPatch]
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private static ManualLogSource _log;
        internal static ConfigEntry<float> CameraZoom = null!;
        private static ConfigEntry<bool> _enableGoingBackwards = null!;

        private void Awake()
        {
            CameraZoom = Config.Bind("General", "CameraZoom", 8f, "Changes the cameras orthographic size. 8 is the default. The games default is 6.5.");
            _enableGoingBackwards = Config.Bind("General", "EnableGoingBackwards", true, "By default, the player can't go backwards. This allows the player to go backwards.");
            _log = new ManualLogSource("Log");
            BepInEx.Logging.Logger.Sources.Add(_log);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "p1xel8ted.WonderBoyReturnsRemix.fixes");
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        private void LateUpdate()
        {
            foreach (var camera in Camera.allCameras)
            {
                camera.aspect = (float) Display.main.systemWidth / (float) Display.main.systemHeight;
                camera.rect = new Rect(0, 0, Display.main.systemWidth, Display.main.systemHeight);
                camera.pixelRect = new Rect(0, 0, Display.main.systemWidth, Display.main.systemHeight);
                camera.orthographicSize = Plugin.CameraZoom.Value;
                var platformerCamera = camera.GetComponentInChildren<PlatformerCamera>();
                if (platformerCamera != null)
                {
                    platformerCamera.bCanGoBack = _enableGoingBackwards.Value;
                }
            }

            var blockLeft = GameObject.Find("Main_Camera/block_left");
            if (blockLeft != null)
            {
                blockLeft.SetActive(false);
            }

            var blockRight = GameObject.Find("Main_Camera/block_right");
            if (blockRight != null)
            {
                blockRight.SetActive(false);
            }
        }
    }
}