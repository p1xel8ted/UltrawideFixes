using DG.Tweening;
using flanne;
using flanne.UI;
using flanne.UIExtensions;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Menu = flanne.UIExtensions.Menu;

namespace TwentyMinutesTillDawn;

[HarmonyPatch]
public static class Patches
{
    internal const string FogOfWarCamera = "FogOfWarCamera";
    private const string CanvasTitleScreenBanner = "Canvas/TitleScreen/EmberpathBanner";
    private const string MainMenu = "MainMenuButtons";
    private const string CanvasSelectScreenHead = "Canvas/SelectScreenBG/CharacterPortrait";
    private const string CharacterMenu = "CharacterMenu";

    private static WriteOnce<float> OriginalHeadStartPosition { get; } = new();

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.BeginSplashScreenFade))]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.Begin))]
    [HarmonyPatch(typeof(SplashScreen), nameof(SplashScreen.Draw))]
    public static void SplashScreen_Start()
    {
        PlayerPrefs.SetInt("Fullscreen", 1);
        PlayerPrefs.SetInt("ResolutionIndex", 0);
        SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(OptionsSetter), nameof(OptionsSetter.OnClickFullscreen))]
    public static bool Options_OnClickFullscreen(ref OptionsSetter __instance)
    {
        __instance.SetFullscreen(true);
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsSetter), nameof(OptionsSetter.Start))]
    public static void Options_Start(ref OptionsSetter __instance)
    {
        __instance.SetFullscreen(true);

        __instance.fullscreenTMP.GetComponentInParent<Button>().interactable = false;
        __instance.fullscreenTMP.text = LocalizationSystem.GetLocalizedValue(__instance.fullscreenLabel.key) + " " + "-";

        __instance.resolutionButton.interactable = false;
        __instance.resolutionTMP.text = LocalizationSystem.GetLocalizedValue(__instance.resolutionLabel.key) + " " + "-";
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Show))]
    public static void Menu_Show(ref Menu __instance)
    {
        if (__instance.name.Equals(MainMenu))
        {
            var banner = GameObject.Find(CanvasTitleScreenBanner);
            banner?.SetActive(false);
        }


        if (__instance.name.Equals(CharacterMenu))
        {
            var head = GameObject.Find(CanvasSelectScreenHead);
            if (head is null) return;

            OriginalHeadStartPosition.Value = head.GetComponent<MoveTransition>()._startPosition.x;

            var endPosition = new Vector3(OriginalHeadStartPosition.Value * Plugin.PositiveScaleFactor + 5f, head.transform.localPosition.y, 0);
            head.transform.DOLocalMove(endPosition, 1f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsSetter), nameof(OptionsSetter.SetFullscreen))]
    public static void Options_SetFullscreen(ref OptionsSetter __instance)
    {
        __instance.DisableResolution();
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.Windowed, Plugin.MaxRefresh);

        Cameras.UpdateCameras();
    }
}