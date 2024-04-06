using Elderand.Gameplay;
using Elderand.UI;
using Elderland.MonoBehaviours;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Elderland;

[HarmonyPatch]
public static class Patches
{

    [HarmonyPrefix]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.BeginSplashScreenFade))]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.Begin))]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.Draw))]
    public static void SplashScreen_Start()
    {
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        if (!__instance.name.Equals("Canvas Overlay")) return;

        var parent = GameObject.Find("Player/Player/Static/Canvas Overlay/AspectRatio/PlayerHUD");

        var xp = parent.transform.Find("Experience");
        var status = parent.transform.Find("Status");
        var items = parent.transform.Find("Items");
        var gold = parent.transform.Find("Gold");

        var topLeft = new GameObject("TopLeft");
        var middle = new GameObject("Middle");
        var topRight = new GameObject("TopRight");

        //top left hud
        topLeft.transform.SetParent(parent.transform);
        xp.SetParent(topLeft.transform);
        status.SetParent(topLeft.transform);
        topLeft.transform.position = topLeft.transform.position with {x = -Plugin.BlackBarSize};
        topLeft.AddComponent<LeftHudMover>();

        //middle hud
        middle.transform.SetParent(parent.transform);
        items.SetParent(middle.transform);
        middle.transform.position = middle.transform.position with {x = Plugin.BlackBarSize, y = 8};
        middle.AddComponent<MiddleHudMover>();

        //top right hud
        topRight.transform.SetParent(parent.transform);
        topRight.transform.SetAsLastSibling();
        gold.SetParent(topRight.transform);
        topRight.transform.position = topLeft.transform.position with {x = Plugin.BlackBarSize, y = 8};
        topRight.AddComponent<RightHudMover>();

        topLeft.transform.SetSiblingIndex(0);
        middle.transform.SetSiblingIndex(1);
        topRight.transform.SetSiblingIndex(2);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(ref VideoPlayer __instance)
    {
        if (__instance.clip.name.Equals("Logo_GraffitiGames"))
        {
            __instance.playbackSpeed = 1000f;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DialogueManager), nameof(DialogueManager.OnEnable))]
    public static void DialogueManager_OnEnable(ref DialogueManager __instance)
    {
        var x = (Screen.width / 2f) + Plugin.BlackBarSize;
        __instance.sentenceBox.transform.position = __instance.sentenceBox.transform.position with {x = x};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.Update))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        __instance.aspectRatio = Plugin.MainAspectRatio;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraResolution), nameof(CameraResolution.RescaleCamera))]
    public static void CameraResolution_RescaleCamera_Prefix(ref CameraResolution __instance)
    {
        __instance.width = 10f * Plugin.PositiveScaleFactor;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraResolution), nameof(CameraResolution.RescaleCamera))]
    public static void CameraResolution_RescaleCamera_Postfix(ref CameraResolution __instance)
    {
        if (Plugin.FieldOfView.Value <= 0) return;

        var originalValue = __instance.width * Screen.height / Screen.width * 0.5f;
        var percentIncrease = Plugin.FieldOfView.Value / 100f;
        var newValue = originalValue * (1 + percentIncrease);
        __instance.mainCamera.m_Lens.OrthographicSize = newValue;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ParallaxUnit), nameof(ParallaxUnit.OnEnable))]
    public static void ParallaxUnit_OnEnable(ref ParallaxUnit __instance)
    {
        if (__instance.name.Equals("Tilemap_background"))
        {
            __instance.gameObject.SetActive(false);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoSettings), nameof(VideoSettings.SetupNavigators))]
    public static void VideoSettings_SetupNavigators(ref VideoSettings __instance)
    {
        __instance.AspectRatioRange = new Vector2(1.6f, Plugin.MainAspectRatio);
    }

}