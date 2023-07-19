using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

namespace TurnipBoyCommitsTaxEvasion;

[HarmonyPatch]
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private static Harmony _hi;
    private static ConfigEntry<float> _npcChatDialogScale = null!;
    private static ConfigEntry<float> _cameraZoom = null!;
    private static ConfigEntry<float> _moveSpeed = null!;
    private void Awake()
    {
        _npcChatDialogScale = Config.Bind("General", "NPCDialogScale", 0.75f, "Scale of the dialogues when talking to an NPC.");
        _cameraZoom = Config.Bind("General", "CameraZoom", 7f, "Zoom of the camera. Default feels a little close.");
        _moveSpeed = Config.Bind("General", "MoveSpeed", 1.5f, "Base move speed multiplier of the player. 1.5 = 50% increase in speed. Default feels a little slow.");
        _hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }
    
    public void OnDestroy()
    {
        _hi?.UnpatchSelf();
    }

    private void Update()
    {
        var pc = FindObjectsOfType<PlayerController>();
        foreach (var p in pc)
        {
            p.speed = 32 * _moveSpeed.Value;
        }
    }

    private void LateUpdate()
    {
        foreach (var pixelPerfectCamera in FindObjectsOfType<PixelPerfectCamera>())
        {
            pixelPerfectCamera.enabled = false;
        }

        foreach (var allCamera in Camera.allCameras)
        {
            allCamera.orthographicSize = _cameraZoom.Value;
        }

        var dialog = GameObject.Find("Canvas/Popup Spawner/Dialogue Popup(Clone)/Root");
        if (dialog != null)
        {
            dialog.transform.localScale = new Vector3(_npcChatDialogScale.Value, _npcChatDialogScale.Value, 1);
        }

        var selectResolution = Screen.currentResolution;
        const float minAspectRatio = 16f / 9f;
        var aspectRatio = (float) selectResolution.width / selectResolution.height;
        if (aspectRatio > minAspectRatio)
        {
            foreach (var canvasScaler in FindObjectsOfType<CanvasScaler>())
            {
                canvasScaler.referenceResolution = new Vector2(selectResolution.width, selectResolution.height);
            }
        }
    }
}