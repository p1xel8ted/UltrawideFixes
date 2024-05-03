namespace xMysticSurvivor;

[HarmonyPatch]
public static class Patches
{
    private static GameObject BlurOverlay { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PopUpManager), nameof(PopUpManager.ShowPopUpConfirm))]
    [HarmonyPatch(typeof(PopUpManager), nameof(PopUpManager.ShowPopUpWindow))]
    private static void PopUpManager_Show(ref PopUpManager __instance)
    {
        var bg = __instance.transform.Find("Bg");
        if (bg)
        {
            bg.localScale = bg.localScale with {x = Plugin.PositiveScaleFactor};
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraZoomer), nameof(CameraZoomer.ZoomTween))]
    private static void CameraZoomer_Zoom(ref CameraZoomer __instance, float currentZoomValue)
    {
        Plugin.CurrentZoomLevel.Value = currentZoomValue;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIOpenChest), nameof(UIOpenChest.Show))]
    private static void UIOpenChest_Show(ref UIOpenChest __instance)
    {
        if (Plugin.AutoOpenChests.Value)
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
            if (!Plugin.CollectCrystalsSound.Value)
            {
                volumeScale = 0;
                return;
            }

            if (Plugin.CollectCrystalsVolume.Value != 0)
            {
                volumeScale = Helpers.AdjustVolumeScale(volumeScale, Plugin.CollectCrystalsVolume.Value);
                return;
            }
        }

        if (clip.name.StartsWith("sunstone"))
        {
            if (Plugin.SunStoneVolume.Value != 0)
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
            if (!Plugin.LevelUpVoice.Value)
            {
                volumeScale = 0;
                return;
            }

            if (Plugin.LevelUpVoiceVolume.Value != 0)
            {
                volumeScale = Helpers.AdjustVolumeScale(volumeScale, Plugin.LevelUpVoiceVolume.Value);
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIUnlockScreen), nameof(UIUnlockScreen.OnShow))]
    [HarmonyPatch(typeof(UICharacterSelectScreen), nameof(UICharacterSelectScreen.OnShow))]
    [HarmonyPatch(typeof(UIPowerupScreen), nameof(UIPowerupScreen.OnShow))]
    [HarmonyPatch(typeof(UIGalleryScreen), nameof(UIGalleryScreen.OnShow))]
    [HarmonyPatch(typeof(UISettingScreen), nameof(UISettingScreen.IsShown))]
    [HarmonyPatch(typeof(UICardLevelUpPopup), nameof(UICardLevelUpPopup.Show))]
    [HarmonyPatch(typeof(UICardLevelUpPopup), nameof(UICardLevelUpPopup.Start))]
    [HarmonyPatch(typeof(UILevelSelectScreen), nameof(UILevelSelectScreen.OnShow))]
    [HarmonyPatch(typeof(UILevelDifficultScreen), nameof(UILevelDifficultScreen.OnShow))]
    private static void UIScreen2_OnShow(ref MonoBehaviour __instance)
    {
        var disableMe = GameObject.Find("CanvasOverlay/ScreenWrapper/BG_LevelSelect");
        if (disableMe)
        {
            disableMe.gameObject.SetActive(false);
        }

        var ol = __instance.transform.Find("Overlay");
        if (ol)
        {
            ol.localScale = ol.localScale with {x = Plugin.PositiveScaleFactor};
        }

        var blur = __instance.transform.Find("Blur");
        if (blur)
        {
            blur.localScale = blur.localScale with {x = Plugin.PositiveScaleFactor};
        }

        if ((ol && ol.gameObject.activeSelf) || (blur && blur.gameObject.activeSelf) || __instance.transform.Find("OverlayNew")) return;

        var image = __instance.GetComponent<Image>();
        if (image)
        {
            image.enabled = false;
        }
        BlurOverlay = GameObject.Find("CanvasOverlay/ScreenWrapper/UnlockScreen/Overlay");
        if (!BlurOverlay)
        {
            BlurOverlay = GameObject.Find("CanvasOverlay/ScreenWrapper/PopUpScreen/Bg");
        }

        if (BlurOverlay)
        {
            var newOverlay = Object.Instantiate(BlurOverlay, __instance.transform, true);
            newOverlay.name = "OverlayNew";
            newOverlay.transform.SetAsFirstSibling();
            newOverlay.transform.localScale = newOverlay.transform.localScale with {x = Plugin.PositiveScaleFactor};
            newOverlay.SetActive(true);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIResult), nameof(UIResult.Show))]
    private static void UIResult_Show(ref UIResult __instance)
    {
        if (__instance.transform.Find("NewBG")) return;
        var newBg = new GameObject("NewBG");
        var image = __instance.GetComponent<Image>();
        image.CopyComponent(newBg);
        newBg.AddComponent<Canvas>();
        newBg.transform.SetParent(__instance.transform);
        newBg.transform.SetAsFirstSibling();

        var rect = newBg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth * 2f, Plugin.MainHeight * 2f);
        rect.localScale = Vector3.one;
        rect.localPosition = Vector3.zero;
        newBg.SetActive(true);
        newBg.name = "NewBG";
        image.enabled = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICharacterStatsOnPauseScreen), nameof(UICharacterStatsOnPauseScreen.OnEnable))]
    private static void UICharacterStatsOnPauseScreen_OnEnable(ref UICharacterStatsOnPauseScreen __instance)
    {
        var corners = __instance.transform.Find("PanelCorners");
        if (corners)
        {
            var x = Plugin.BlackBarSize - 90f;
            corners.position = corners.position with {x = x};
        }

        var bg = __instance.transform.Find("PanelBG");
        if (bg)
        {
            bg.position = bg.position with {x = Plugin.BlackBarSize - 100f};
            bg.localScale = bg.localScale with {x = Plugin.PositiveScaleFactor + 1f};
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraZoomer), nameof(CameraZoomer.MakeTreeTransparent))]
    private static bool CameraZoomer_MakeTreeTransparent(ref CameraZoomer __instance)
    {
        return !Plugin.StopTransparentTrees.Value;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraZoomer), nameof(CameraZoomer.Start))]
    private static void CameraZoomer_Start(ref CameraZoomer __instance)
    {
        Plugin.CameraZoomer = __instance;
        if (Plugin.CurrentZoomLevel.Value > 0)
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
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        var titleBlur = __instance.transform.Find("BackgroundComp/BackgroundImage2_BLURMORE");
        if (titleBlur)
        {
            var image = titleBlur.GetComponent<Image>();
            if (image)
            {
                image.enabled = false;
            }
        }


        // var parent = __instance.transform.Find("ScreenWrapper");
        // if (!parent) return;
        //
        // var effectCircle = GameObject.Find("CanvasCamera/ScreenWrapperCC");
        //
        // NewLeftHUD = new GameObject("NewLeftHUD");
        // NewLeftHUD.transform.SetParent(parent, true);
        //
        // foreach (var element in LeftElements)
        // {
        //     var go = parent.Find(element);
        //     if (go)
        //     {
        //         go.SetParent(NewLeftHUD.transform, true);
        //     }
        // }
        // if (effectCircle)
        // {
        //     effectCircle.transform.SetParent(NewLeftHUD.transform, true);
        //     effectCircle.gameObject.TryAddComponent<SpecialMover>();
        // }
        //
        // NewRightHUD = new GameObject("NewRightHUD");
        // NewRightHUD.transform.SetParent(parent, true);
        //
        // foreach (var element in RightElements)
        // {
        //     var go = parent.Find(element);
        //     if (go)
        //     {
        //         go.SetParent(NewRightHUD.transform, true);
        //     }
        // }
        //
        // NewRightHUD.gameObject.TryAddComponent<RightHudMover>();
        // NewLeftHUD.gameObject.TryAddComponent<LeftHudMover>();
        //
        // NewRightHUD.transform.SetAsFirstSibling();
        // NewLeftHUD.transform.SetAsFirstSibling();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISettingScreenResolution), nameof(UISettingScreenResolution.FilterResolution))]
    private static void UISettingScreenResolution_FilterResolution(UISettingScreenResolution __instance)
    {
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