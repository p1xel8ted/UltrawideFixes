using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace WonhonSpiritUltraWide;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.SetResolution))]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Start))]
    public static void Settings_SetResolution()
    {
        Plugin.UpdateDisplay();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.Start))] 
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.OnEnable))] 
    public static void Settings_Update(ref Settings_UI __instance)
    {
        var resolutions = new List<Resolution>();
        var mainRes = new Resolution
        {
            width = Plugin.MainWidth,
            height = Plugin.MainHeight,
            refreshRate = Plugin.MaxRefresh
        };
        
        resolutions.Add(mainRes);
        resolutions.Add(mainRes);
        
        __instance.resolutions = resolutions.ToArray();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void UIBehaviour_Awake(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.Set_FPS))]
    public static void Settings_UI_Set_FPS()
    {
        Application.targetFrameRate = Plugin.MaxRefresh;
        PlayerPrefs.SetInt("fps", Plugin.MaxRefresh);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Disclaimer_Canvas), nameof(Disclaimer_Canvas.Start))]
    public static bool Disclaimer_Canvas_Start(ref Disclaimer_Canvas __instance)
    {
        return false;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_ControllerPlatform_Enable), nameof(UI_ControllerPlatform_Enable.Start))]
    [HarmonyPatch(typeof(UI_ControllerPlatform_Enable), nameof(UI_ControllerPlatform_Enable.Enable_UI_Controller))]
    public static void UI_ControllerPlatform_Enable_Start(ref UI_ControllerPlatform_Enable __instance)
    {
        __instance.gameObject.transform.localScale = __instance.gameObject.transform.localScale with {x = Plugin.PositiveScaleFactor};
        __instance.UI_keyboard_n_mouse.transform.localScale = __instance.UI_keyboard_n_mouse.transform.localScale with {x = Plugin.NegativeScaleFactor};
        __instance.UI_ps4.transform.localScale = __instance.UI_ps4.transform.localScale with {x = Plugin.NegativeScaleFactor};
        __instance.UI_switch.transform.localScale = __instance.UI_switch.transform.localScale with {x = Plugin.NegativeScaleFactor};
        __instance.UI_xbox.transform.localScale = __instance.UI_xbox.transform.localScale with {x = Plugin.NegativeScaleFactor};
        var cr = __instance.gameObject.transform.FindChild("Camera_Rotation");
        if (cr)
        {
            cr.localScale = cr.localScale with {x = Plugin.NegativeScaleFactor};
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(FadeBlack), nameof(FadeBlack.Start))]
    public static bool FadeBlack_Start(ref FadeBlack __instance)
    {
        return false;
    }
    
    private static GameObject _quitDesktopButton;
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseUI), nameof(PauseUI.OnEnable))]
    public static void PauseUI_OnEnable(ref PauseUI __instance)
    {
        if (!_quitDesktopButton)
        {
            _quitDesktopButton = Object.Instantiate(__instance.Quit_Button.gameObject, __instance.Quit_Button.transform.parent);
            var local = _quitDesktopButton.GetComponent<UI_TextComp_Localize>();
            if (local)
            {
                local.enabled = false;
            }
    
            var button = _quitDesktopButton.GetComponent<Button>();
            button.onClick.AddListener((UnityAction) OnQuitDesktopButtonClick);
            var text = _quitDesktopButton.GetComponent<Text>();
            if (text)
            {
                text.supportRichText = false;
                text.text = "QUIT TO DESKTOP";
                text.supportRichText = true;
            }
    
            _quitDesktopButton.name = "QuitToDesktopButton";
            _quitDesktopButton.transform.SetSiblingIndex(4);
            GameObject.Find("Canvas_UI_Paused/Pause_Buttons/BLANK").SetActive(false);
            __instance.pauseButtons.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
    
    private static void OnQuitDesktopButtonClick()
    {
        GC.Collect();
        Il2CppSystem.GC.Collect();
        Application.Quit();
    }
}