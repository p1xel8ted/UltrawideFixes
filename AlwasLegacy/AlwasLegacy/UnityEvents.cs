using System;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlwasLegacy;

[HarmonyPatch]
public partial class Plugin
{
    public void LateUpdate()
    {
        if (CameraScript.instance != null)
        {
            var cameraScript = CameraScript.instance;
            if (cameraScript != null && !SceneManager.GetActiveScene().name.Contains("Intro"))
            {
                //  _log.LogWarning("Found CameraScript!");
                var res = SettingsManager.instance.resolutionTexts[SystemSaveSettings.instance.resolutionIndex];
                var widthStr = res.Split('x')[0];
                var heightStr = res.Split('x')[1];
                var widthInt = int.Parse(widthStr);
                var heightInt = int.Parse(heightStr);
                const float ratio = 16f / 9f;
                var subValue = ratio * heightInt;
                var triggerValue = (widthInt - subValue) / 2f;
                if (Math.Abs(cameraScript.playerScreenPos.x - triggerValue) <= 3f)
                {
                    //player moving left
                    cameraScript.playerScreenPos.x = 0;
                }

                if (Math.Abs(cameraScript.playerScreenPos.x - (widthInt - triggerValue)) <= 3f)
                {
                    //player moving right
                    cameraScript.playerScreenPos.x = widthInt;
                }
            }
        }
        
        var dialogUiIntro = GameObject.Find("Canvas/DialogGUI");
        if (dialogUiIntro != null)
        {
            dialogUiIntro.transform.localScale = new Vector3(_dialogScale.Value, _dialogScale.Value, _dialogScale.Value);
        }

        var dialogUI = GameObject.Find("Canvas/MoveCanvasAtStart/DialogGUI");
        if (dialogUI != null)
        {
            dialogUI.transform.localScale = new Vector3(_dialogScale.Value, _dialogScale.Value, _dialogScale.Value);
        }


        var itemPickup = GameObject.Find("Canvas/MoveCanvasAtStart/ItemPickup");
        if (itemPickup != null)
        {
            itemPickup.transform.localScale = new Vector3(_dialogScale.Value, _dialogScale.Value, _dialogScale.Value);
        }

        var settingsBg = GameObject.Find("Canvas/MoveCanvasAtStart/PauseNode/ParentNode/BG");
        if (settingsBg != null)
        {
            settingsBg.transform.localScale = new Vector3(2000f, 1, 1);
        }

        var settingsVig = GameObject.Find("Canvas/MoveCanvasAtStart/PauseNode/ParentNode/Vignette");
        if (settingsVig != null)
        {
            settingsVig.transform.localScale = new Vector3(2000f, 1, 1);
        }

        var loadingScreenBackground = GameObject.Find("Canvas/ParentNode/LoadingScreen/BlackBG");
        if (loadingScreenBackground != null)
        {
            loadingScreenBackground.transform.localScale = new Vector3(2000f, 1, 1);
        }

        var topBottomBorders = GameObject.Find("Canvas/MoveCanvasAtStart/Borders");
        if (topBottomBorders != null)
        {
            topBottomBorders.transform.localScale = new Vector3(2000f, 1, 1);
        }

        if (!SceneManager.GetActiveScene().name.Contains("Main"))
        {
            if (Camera.main != null) Camera.main.backgroundColor = Color.black;
        }

        
        var canvasScalers = FindObjectsOfType<CanvasScaler>();
        foreach (var canvasScaler in canvasScalers)
        {
            // canvasScaler.referenceResolution = new Vector2(640, 350);
            canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        }
    }
}