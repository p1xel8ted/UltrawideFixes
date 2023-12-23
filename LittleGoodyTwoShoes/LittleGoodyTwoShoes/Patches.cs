using System;
using System.Linq;
using Com.LuisPedroFonseca.ProCamera2D;
using FMODUnity;
using HarmonyLib;
using LGTS.Initialization;
using LGTS.LGTS_Utils;
using LGTS.Managers;
using LGTS.Managers.Scenes;
using LGTS.Scenes;
using LGTS.UI;
using LGTS.UI.Dialogue;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace LittleGoodyTwoShoes;

[Harmony]
public static class Patches
{


    [HarmonyPostfix]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.Load))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultLighting))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultWeather))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultWind))]
    [HarmonyPatch(typeof(LightingLoader), nameof(LightingLoader.LoadDefaultPostProcessing))]
    public static void LightingLoader_Load(ref LightingLoader __instance)
    {
        Plugin.LightingLoaderInstance = __instance;
        // Plugin.UpdatePostProcessing();
        Plugin.UpdateLightingWeight();
        Plugin.UpdatePauseFrame();
        Plugin.UpdateDialogueFrame();
        Plugin.UpdateScalers();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        // if (!Plugin.ScaleCorrections.Value) return;
        if (__instance.name.ToLowerInvariant().Contains(Const.Sinai) || __instance.name.Equals(Const.ToastManager) || __instance.name.Equals(Const.TutorialCanvas)) return;
        if (__instance.gameObject.GetGameObjectPath().Contains(Const.TitleUI)) return;
        Utils.UpdateScaler(__instance);
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.scaleFactor), MethodType.Getter)]
    public static void CanvasScaler_scaleFactor(ref CanvasScaler __instance, ref float __result)
    {
        // if (!Plugin.ScaleCorrections.Value) return;
        if (__instance.name.ToLowerInvariant().Contains(Const.Sinai) || __instance.name.Equals(Const.ToastManager) || __instance.name.Equals(Const.TutorialCanvas)) return;
        if (__instance.gameObject.GetGameObjectPath().Contains(Const.TitleUI)) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __result = Utils.GetNewScale(__instance.referenceResolution.y) * Plugin.ScaleConfig.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsConfigMenu), nameof(GraphicsConfigMenu.Start))]
    [HarmonyPatch(typeof(GraphicsConfigMenu), nameof(GraphicsConfigMenu.Refresh))]
    private static void GraphicsConfigMenu_Start(ref GraphicsConfigMenu __instance)
    {
        //forces the fullscreen window and locks the options
        __instance.windowed.currentIndex = 1;
        __instance.windowed.LockOptions(1);
        __instance.windowed.left.interactable = false;
        __instance.windowed.right.interactable = false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GraphicsConfigMenu), nameof(GraphicsConfigMenu.OnScreenModeChange))]
    private static void GraphicsConfigMenu_OnScreenModeChange(ref int index)
    {
        //forces the fullscreen window
        index = 1;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(DialogueWindow), nameof(DialogueWindow.StartConversation))]
    private static void DialogueWindow_Show(ref DialogueWindow __instance, ref bool frameless)
    {
        //forces the dialogue window to be frameless based on config and enables auto advance
        if (Plugin.AutoAdvanceConfig.Value)
        {
            __instance.controller.auto = false;
            __instance.ToggleAuto();
        }
        __instance.settingsPanel.SetActive(false);
        frameless = !Plugin.DialogueFrameConfig.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Canvas), nameof(Canvas.pixelRect), MethodType.Getter)]
    private static void Canvas_Show(ref Canvas __instance, ref Rect __result)
    {
        //this is to the keep the title menu usable.
        // if (!Plugin.ScaleCorrections.Value) return;
        if (__instance.name.Equals(Const.ToastManager)) return;
        if (Mathf.Approximately(__result.m_Height, Display.main.systemHeight))
        {
            __result = new Rect(0, 0, Display.main.systemHeight * 16 / 9f, Display.main.systemHeight);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Canvas), nameof(Canvas.renderingDisplaySize), MethodType.Getter)]
    private static void Canvas_Show(ref Canvas __instance, ref Vector2 __result)
    {
        //this is to the keep the title menu usable.
        // if (!Plugin.ScaleCorrections.Value) return;
        if (__instance.name.Equals(Const.ToastManager)) return;
        if (Mathf.Approximately(__result.y, Display.main.systemHeight))
        {
            __result = new Vector2(Display.main.systemHeight * 16 / 9f, Display.main.systemHeight);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameObject), nameof(GameObject.SetActive))]
    private static void GameObject_SetActive(GameObject __instance, ref bool value)
    {
        //disable the splash screen and photo sensitive warning
        if (__instance.name.Equals(Const.SplashCanvas) || __instance.name.Equals(Const.PhotoSensitveWarning))
        {
            value = false;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LgtsUtils), nameof(LgtsUtils.SetTimeout))]
    private static void LgtsUtils_SetTimeout(ref float timeout, ref Action action)
    {
        //skip the delay between showing the splash screen and the photo sensitive warning and playing the video
        if (Mathf.Approximately(6.5f, timeout))
        {
            timeout = 0;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.FilterResolutions))]
    public static void SettingsManager_FilterResolutions(ref SettingsManager __instance)
    {
        //makes sure the custom resolution is the only one available
        __instance._resolutions.Clear();
        var res = new Resolution
        {
            height = Display.main.systemHeight,
            width = Display.main.systemWidth,
            refreshRate = Screen.resolutions.Max(a => a.refreshRate)
        };
        __instance._resolutions.Add(res);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.SetResolution))]
    public static void SettingsManager_SetResolution(ref int index)
    {
        //forces the custom resolution
        index = 0;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.SetScreenMode))]
    public static void SettingsManager_SetScreenMode(ref int index)
    {
        //fullscreen window to preserve aspect ratio
        index = 1;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(StartingPosition), nameof(StartingPosition.VerifyAndApplyPosition))]
    public static void StartingPosition_VerifyAndApplyPosition()
    {
        if (!Plugin.CameraZoomConfig.Value) return;
        if (Camera.main == null) return;
        //figure is irrelevant, just needs to be a number as it gets patched in the setter
        Camera.main.orthographicSize = 5f;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.Start))]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.Awake))]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.SetScreenSize))]
    public static void ProCamera2D_Start(ref ProCamera2D __instance)
    {
        Plugin.ProCamera2DInstance = __instance;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(Camera), nameof(Camera.orthographicSize), MethodType.Setter)]
    private static void Camera_OrthographicSize_Setter(ref float value)
    {
        if (!Plugin.CameraZoomConfig.Value) return;
        //adjusts the orthographic size of the camera
        value = Utils.GetBaseOrthographicSize(Plugin.ProCamera2DInstance) * Plugin.CameraZoomConfigValue.Value;
        if (value <= 2f)
        {
            value = 2f;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(RuntimeManager), nameof(RuntimeManager.PlayOneShot), typeof(string), typeof(Vector3))]
    private static bool RuntimeManager_PlayOneShot(string path)
    {
        //stops the title menu voice over from playing
        if (Plugin.TitleMenuVoiceOver.Value) return true;
        return !path.Contains(Const.GameTitleVo);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleScreenManager), nameof(TitleScreenManager.Start))]
    public static void TitleScreenManager_Start(ref TitleScreenManager __instance)
    {
        //skip the animation video/intro and the press any key screen
        if (!Plugin.GoStraightToTitleMenu.Value) return;
        __instance.OnAfterShowAnyKeyPressed();
        __instance.ShowLogo();
        var flash = GameObject.Find(Const.IntroAnimationFlashTitlePath);
        if (flash == null) return;
        flash.SetActive(false);
        Object.Destroy(flash);
    }
}