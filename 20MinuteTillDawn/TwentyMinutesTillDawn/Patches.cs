using DG.Tweening;
using flanne.UI;
using HarmonyLib;
using UnityEngine;
using Menu = flanne.UIExtensions.Menu;

namespace TwentyMinutesTillDawn;

[HarmonyPatch]
public static class Patches
{
    internal const string FogOfWarCamera = "FogOfWarCamera";
    private const string GunMenuName = "GunMenu";

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsSetter), nameof(OptionsSetter.Start))]
    public static void Options_Start(ref OptionsSetter __instance)
    {
        __instance.SupportedResolutions = Plugin.NewSupportedResolutions.ToArray();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Menu), nameof(Menu.Show))]
    public static void Menu_Show(ref Menu __instance)
    {
        if (!__instance.name.Equals(GunMenuName)) return;
        var head = GameObject.Find("Canvas/SelectScreenBG/CharacterPortrait");
        if (head == null) return;

        var endPosition = new Vector3(500, head.transform.localPosition.y, 0);
        head.transform.DOLocalMove(endPosition, 1f);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionsSetter), nameof(OptionsSetter.SetFullscreen))]
    public static void Options_SetFullscreen(ref OptionsSetter __instance, bool isFS)
    {
        if (isFS)
        {
            __instance.DisableResolution();
            Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true);
        }
        else
        {
            __instance.resolutionButton.interactable = true;
            __instance.SetResolution(__instance._resolutionIndex);
        }

        Cameras.UpdateCameras();
    }
}