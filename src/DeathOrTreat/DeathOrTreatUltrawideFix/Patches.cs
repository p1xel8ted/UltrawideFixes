using System;
using Cinemachine;
using HarmonyLib;
using LeTai.Asset.TranslucentImage;
using SaonaStudios.MenuSystem.Menus;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
using UnityEngine.Video;

namespace DeathOrTreatUltrawideFix;

[Harmony]
public static class Patches
{
    private const string CanvasCutscene = "Canvas  Cutscene";
    private const string DeathMenu = "Death Menu";
    private const string MainMenuCanvasBg = "MAIN MENU Canvas BG";
    private const string ScreenPanelMediumTextTMP = "ScreenPanel/Medium/Text (TMP)";
    private const string Resolution = "Resolution";
    private const string Bg2Carro = "BG2/carro";
    private const string Bg2Background = "BG2/Background (12)";
    private const string MainImage = "Main Image";
    private const string DeathMenuRightPanel = "MenuManager/Death Menu(Clone)/Right Panel";
    private const string DeathMenuLeftPanel = "MenuManager/Death Menu(Clone)/Inventory";
    private const string BackgroundSaona = "Background Saona";
    internal static Transform Carro { get; private set; }

    private static GameObject LeftDots { get; set; }
    private static GameObject RightDots { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.Start))]
    private static void MainMenu_Start(ref MainMenu __instance)
    {
        var bgTransform = __instance.transform.Find(Bg2Background);
        Carro = __instance.transform.Find(Bg2Carro);
        var logoTransform = __instance.transform.Find(BackgroundSaona);
        
        var scaleFactor = GetScaleBasedOnAspectRatio();
        
        Carro.localScale = new Vector3(Carro.localScale.x * scaleFactor, Carro.localScale.y * scaleFactor, 1);
        bgTransform.localScale = new Vector3(scaleFactor, scaleFactor, 1);
        
        Carro.gameObject.SetActive(Plugin.MenuCarriage.Value);
        Carro.position = Carro.position with {x = -(Plugin.PositiveScaleFactor + 0.325f)};

        logoTransform.gameObject.SetActive(false);
    }

    private static float GetScaleBasedOnAspectRatio()
    {
        if (Mathf.Approximately(Plugin.SuperWideAspectRatio, Plugin.MainAspectRatio))
        {
            return 1.32f;
        }

        return Mathf.Approximately(Plugin.MainAspectRatio, Plugin.TwentiesAspectRatio) ? 1.1f : 1f;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void GraphicsMenu_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;

        if (__instance.name.Contains(DeathMenu, StringComparison.OrdinalIgnoreCase))
        {
            LeftDots = GameObject.Find(DeathMenuLeftPanel);
            RightDots = GameObject.Find(DeathMenuRightPanel);
        }

        if (__instance.name.Equals(CanvasCutscene, StringComparison.OrdinalIgnoreCase))
        {
            var image = __instance.transform.Find(MainImage);
            image.transform.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    private static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    private static void GraphicsMenu_Handle(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains(DeathMenu, StringComparison.OrdinalIgnoreCase))
        {
            __instance.scaleFactor = Plugin.PositiveScaleFactor;
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
            if (LeftDots)
            {
                LeftDots.transform.localPosition = LeftDots.transform.localPosition with {x = 50};
            }
            if (RightDots)
            {
                RightDots.transform.localPosition = RightDots.transform.localPosition with {x = Plugin.BlackBarSize - 100f};
            }
            return;
        }

        __instance.scaleFactor = __instance.name.Equals(MainMenuCanvasBg, StringComparison.OrdinalIgnoreCase) ? Plugin.PositiveScaleFactor : Plugin.CustomScale.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsMenu), nameof(GraphicsMenu.Start))]
    private static void GraphicsMenu_Start(ref GraphicsMenu __instance)
    {
        var resText = __instance.transform.Find(ScreenPanelMediumTextTMP).GetComponent<TextMeshProUGUI>();
        if (resText)
        {
            resText.text = $"{Plugin.MainWidth}x{Plugin.MainHeight}";
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TranslucentImage), nameof(TranslucentImage.OnEnable))]
    private static void TranslucentImage_OnEnable(ref TranslucentImage __instance)
    {
        var rect = __instance.GetComponent<RectTransform>();
        if (rect)
        {
            rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCameraBase), nameof(CinemachineVirtualCameraBase.Update))]
    private static void CinemachineVirtualCamera_OnEnable(ref CinemachineVirtualCameraBase __instance)
    {
        if (__instance is CinemachineVirtualCamera cvc)
        {
            cvc.m_Lens.OrthographicSize = 20f + Plugin.CameraZoom.Value;
        }

        __instance.gameObject.TryGetComponent(out CinemachineConfiner cc);
        if (cc)
        {
            cc.enabled = Plugin.ScreenConfiner.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.Update))]
    public static void PostProcessVolume_Update(ref PostProcessVolume __instance)
    {
        var ap = __instance.profile;
        ap.TryGetSettings(out Vignette vignette);
        if (vignette)
        {
            vignette.active = Plugin.Vignette.Value;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.UpdateVolumeSystem))]
    public static void PostProcessLayer_UpdateVolumeSystem(ref PostProcessLayer __instance)
    {
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.Init))]
    public static void PostProcessLayer_Init(ref PostProcessLayer __instance)
    {
        __instance.gameObject.TryGetComponent(out PostProcessVolume volume);
        if (!volume)
        {
            volume = __instance.gameObject.AddComponent<PostProcessVolume>();
        }
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;

        var ap = volume.profile;

        ap.TryGetSettings(out Vignette vignette);
        if (vignette is not null)
        {
            vignette.active = Plugin.Vignette.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GraphicsMenu), nameof(GraphicsMenu.SetResolution), typeof(int))]
    private static void GraphicsMenu_SetResolution(ref GraphicsMenu __instance, int resolutionInt)
    {
        if (resolutionInt != 2) return;

        __instance.SetResolution(Plugin.MainWidth, Plugin.MainHeight);
        PlayerPrefs.SetInt(Resolution, resolutionInt);
    }
}