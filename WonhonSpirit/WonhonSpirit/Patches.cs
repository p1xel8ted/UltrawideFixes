using HarmonyLib;
using Il2Cpp;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace WonhonSpirit;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.SetResolution))]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Start))]
    public static void Settings_SetResolution()
    {
        Application.targetFrameRate = WonhonSpirit.RefreshRate;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.Start))]
    [HarmonyPatch(typeof(Settings_UI), nameof(Settings_UI.OnEnable))]
    public static void Settings_Update(ref Settings_UI __instance)
    {
        //check the current display resolution doesn't exist in the resolutions list
        if (__instance.resolutions == null || __instance.resolutions.Any(x => x is var resolution && resolution.height == Display.main.systemHeight && resolution.width == Display.main.systemWidth)) return;

        //get a distinct list of refresh rates from the resolutions
        var refreshRates = __instance.resolutions.Select(x => x.refreshRate).Distinct();

        //get highest refresh rate of current resolution
        WonhonSpirit.RefreshRate = __instance.resolutions.Max(x => x.refreshRate);

        //create a new resolution list of the main display resolution with the refresh rates from refreshRates
        var resolutions = refreshRates.Select(x => new Resolution
        {
            width = Display.main.systemWidth,
            height = Display.main.systemHeight,
            refreshRate = x
        });

        //add the new resolutions to the existing resolutions in __instance.resolutions
        __instance.resolutions = __instance.resolutions.Union(resolutions).ToArray();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void UIBehaviour_Awake(ref CanvasScaler __instance)
    {
        var ar = Screen.width / (float) Screen.height;
        const float originalAr = 16f / 9f;
        if (!(ar > originalAr)) return;
        if (__instance.name.Contains("com.sinai")) return;
        if (__instance.name.Equals("EnemyCanvas-ScreenSpace")) return;
        if (__instance is {screenMatchMode: CanvasScaler.ScreenMatchMode.Expand, uiScaleMode: CanvasScaler.ScaleMode.ScaleWithScreenSize}) return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Disclaimer_Canvas), nameof(Disclaimer_Canvas.Start))]
    public static bool Disclaimer_Canvas_Start(ref Disclaimer_Canvas __instance)
    {
        return false;
    }
    
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(FadeBlack), nameof(FadeBlack.Start))]
    // public static bool FadeBlack_Start(ref FadeBlack __instance)
    // {
    //     return false;
    // }

    private static GameObject _quitDesktopButton;

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PauseUI), nameof(PauseUI.OnEnable))]
    public static void PauseUI_OnEnable(ref PauseUI __instance)
    {
        if (_quitDesktopButton == null)
        {
            _quitDesktopButton = UnityEngine.Object.Instantiate(__instance.Quit_Button.gameObject, __instance.Quit_Button.transform.parent);
            var local = _quitDesktopButton.GetComponent<UI_TextComp_Localize>();
            if (local != null)
            {
                local.enabled = false;
            }

            var button = _quitDesktopButton.GetComponent<Button>();
            button.onClick.AddListener((UnityAction) OnQuitDesktopButtonClick);
            var text = _quitDesktopButton.GetComponent<Text>();
            if (text != null)
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
        Application.Quit();
    }
}