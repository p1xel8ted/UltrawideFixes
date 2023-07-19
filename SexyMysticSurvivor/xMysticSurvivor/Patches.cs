using System.Linq;
using AMG;
using AMG.UI;
using DG.Tweening;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace xMysticSurvivor;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraZoomer), nameof(CameraZoomer.ZoomTween))]
    private static void CameraZoomer_Zoom(ref CameraZoomer __instance, float currentZoomValue)
    {
        if (Plugin.CurrentZoomLevel == null) return;

        Plugin.CurrentZoomLevel.Value = currentZoomValue;
        Plugin.LOG?.LogWarning($"Saving Zoom Level: {currentZoomValue}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIOpenChest), nameof(UIOpenChest.Show))]
    private static void UIOpenChest_Show(ref UIOpenChest __instance)
    {
        if (Plugin.AutoOpenChests is {Value: true})
        {
            __instance.HandleOpen();
            SoundManager.Instance.PlayUISound(GameSoundID.ui_button_click);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(AudioSource), nameof(AudioSource.PlayOneShot), typeof(AudioClip), typeof(float))]
    public static void AudioSource_PlayOneShot(ref AudioSource __instance, ref AudioClip clip, ref float volumeScale)
    {
        if (clip.name.StartsWith("Crystal Reward Tick"))
        {
            if (Plugin.CollectCrystalsSound != null && !Plugin.CollectCrystalsSound.Value)
            {
                volumeScale = 0;
                return;
            }

            if (Plugin.CollectCrystalsVolume != null && Plugin.CollectCrystalsVolume.Value != 0)
            {
                volumeScale = Helpers.AdjustVolumeScale(volumeScale, Plugin.CollectCrystalsVolume.Value);
                return;
            }
        }

        if (clip.name.StartsWith("sunstone"))
        {
            if (Plugin.SunStoneVolume != null && Plugin.SunStoneVolume.Value != 0)
            {
                volumeScale = Helpers.AdjustVolumeScale(volumeScale, Plugin.SunStoneVolume.Value);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SoundManager), nameof(SoundManager.PlaySFXSound), typeof(AudioClip), typeof(float))]
    public static void SoundManager_PlaySFXSound(ref AudioClip clip, ref float volumeScale)
    {
        if (clip.name.ToLowerInvariant().StartsWith("levelup"))
        {
            if (Plugin.LevelUpVoice != null && !Plugin.LevelUpVoice.Value)
            {
                volumeScale = 0;
                return;
            }

            if (Plugin.LevelUpVoiceVolume != null && Plugin.LevelUpVoiceVolume.Value != 0)
            {
                volumeScale = Helpers.AdjustVolumeScale(volumeScale, Plugin.LevelUpVoiceVolume.Value);
            }
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraZoomer), nameof(CameraZoomer.MakeTreeTransparent))]
    private static bool CameraZoomer_MakeTreeTransparent(ref CameraZoomer __instance)
    {
        return Plugin.StopTransparentTrees is not {Value: true};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraZoomer), nameof(CameraZoomer.Start))]
    private static void CameraZoomer_Start(ref CameraZoomer __instance)
    {
        Plugin.CameraZoomer = __instance;
        if (Plugin.CurrentZoomLevel != null && Plugin.CurrentZoomLevel.Value > 0)
        {
            __instance.CurrentZoomValue = Plugin.CurrentZoomLevel.Value;
            if (__instance.cam.orthographic)
            {
                __instance.tween = __instance.cam.DOOrthoSize(Plugin.CurrentZoomLevel.Value, 0).SetEase(0).SetUpdate(true);
                return;
            }

            __instance.tween = __instance.cam.DOFieldOfView(Plugin.CurrentZoomLevel.Value, 0).SetEase(0).SetUpdate(true);
        }

        Plugin.SetZoom();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    private static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        switch (__instance.name)
        {
            case "CanvasOverlay":
                Plugin.CanvasOverlay = __instance;
                break;
            case "CanvasCamera":
                Plugin.CanvasCamera = __instance;
                break;
        }

        Plugin.SetScaling();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISettingScreenResolution), nameof(UISettingScreenResolution.FilterResolution))]
    private static void UISettingScreenResolution_FilterResolution(UISettingScreenResolution __instance)
    {
        if (Plugin.UltraWide is {Value: false}) return;

        UISettingScreenResolution.filteredResolution.Clear();
        UISettingScreenResolution.resolutionsText.Clear();
        foreach (var res in Screen.resolutions
                     .GroupBy(r => new {r.width, r.height})
                     .Select(g => g.OrderByDescending(r => r.refreshRate).First()))
        {
            var resText = res.ToResText();
            UISettingScreenResolution.filteredResolution.Add(res);
            UISettingScreenResolution.resolutionsText.Add(resText);
        }

        UISettingScreenResolution.maxNumberResSupport = UISettingScreenResolution.resolutionsText.Count;
    }
}