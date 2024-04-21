using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FoW;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace HeavenDustTwo;

[HarmonyPatch]
public static class Patches
{
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(OptionMgr), nameof(OptionMgr.SetResolution), typeof(int))]
    // public static void OptionMgr_SetResolution(int nIndex)
    // {
    //     AspectUtility.s_fWantedAspectRatio = (float) OptionMgr.m_listResolutions[nIndex].width / (float) OptionMgr.m_listResolutions[nIndex].height;
    // }
    //
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(OptionMgr), nameof(OptionMgr.GetInitializedResolutions))]
    // public static void OptionMgr_GetInitializedResolutions()
    // {
    //     var res = new OptionMgr.OGResolution
    //     {
    //         width = Plugin.Width.Value,
    //         height = Plugin.Height.Value
    //     };
    //     OptionMgr.m_listResolutions.Add(res);
    // }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainUI), nameof(MainUI.ShowStudioName))]
    public static bool MainUI_ShowStudioName()
    {
        return false;
    }

    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(AspectUtility), nameof(AspectUtility.SetCameraRects))]
    // public static void AspectUtility_SetCameraRects()
    // {
    //     AspectUtility.s_fWantedAspectRatio = (float)Plugin.Width.Value / (float)Plugin.Height.Value;
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraCtl), nameof(CameraCtl.Update))]
    public static void CameraCtl_Update()
    {
        var cam = GameObject.Find("Canvas/BottomLayer/MainUI/ImgMask").GetComponent<CanvasRenderer>();

        if (Screen.currentResolution.height != Plugin.Height.Value || Screen.currentResolution.width != Plugin.Width.Value)
        {
            OptionMgr_SetResolution(0);
        }

        if (Plugin.HideOverlay.Value && cam.GetAlpha() > 0f)
        {
            cam.SetAlpha(0f);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.DoStart))]
    public static void SplashScreen_DoStart(ref bool ___m_bDone)
    {
        OptionMgr_SetResolution(0);
        ___m_bDone = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionMgr), nameof(OptionMgr.SetResolution), typeof(int))]
    public static bool OptionMgr_SetResolution(int nIndex)
    {
        float width = Plugin.Width.Value;
        float height = Plugin.Height.Value;
        var ar = width / height;
        AspectUtility.s_fWantedAspectRatio = ar;
        var @int = GlobalGameCtl.Setting.GetInt("FullScreen", 0);
        Screen.SetResolution((int) width, (int) height, @int == 0);
        AspectUtility.SetCameraRects();
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraCtl), nameof(CameraCtl.Start))]
    public static void CameraCtl_Start(ref CameraCtl __instance)
    {
        if (__instance == null) return;

        var canvas = GameObject.Find("Canvas").GetComponent<CanvasScaler>();
        if (canvas != null)
        {
            canvas.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            canvas.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            if (Plugin.AlternateUiScaleMode.Value)
            {
                canvas.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            }
        }

        var fow = __instance.GetComponentInChildren<FogOfWarLegacy>();
        if (Plugin.DisableFogOfWar.Value && fow != null)
        {
            fow.enabled = false;
        }

        var effects = __instance.GetComponentInChildren<MobilePostProcessing>();
        if (effects != null)
        {
            if (Plugin.DisableVignette.Value)
            {
                effects.Vignette = false;
            }

            if (Plugin.DisableChromaticAberration.Value)
            {
                effects.ChromaticAberration = false;
            }
        }

        if (!Plugin.HideOverlay.Value) return;

        var cam = GameObject.Find("Canvas/BottomLayer/MainUI/ImgMask").GetComponent<CanvasRenderer>();
        if (cam != null)
        {
            cam.SetAlpha(0f);
        }
    }
}