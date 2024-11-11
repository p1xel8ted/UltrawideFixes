using Object = UnityEngine.Object;

namespace NIMRODS.Patches;

[Harmony]
public static class Patches
{
    private static readonly List<LayoutController> LayoutControllers = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        if (__instance.name == "PlayerCanvas")
        {
            var lc = __instance.gameObject.TryAddComponent<LayoutController>();
            LayoutControllers.Add(lc);

            var gradient = __instance.transform.FindChild("Gradient");
            if (gradient)
            {
                gradient.gameObject.SetActive(false);
            }
        }
    }

    internal static void UpdateLayoutControllers()
    {
        foreach (var layout in LayoutControllers.Where(layout => layout))
        {
            var width = MonoBehaviours.LayoutController.GetPreferredWidth();
            layout.LayoutElement.preferredWidth = width;
            layout.ContentSizeFitter.horizontalFit = width == -99 ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize;
            layout.LayoutElement.SetDirty();
            layout.ContentSizeFitter.SetDirty();
            Canvas.ForceUpdateCanvases();
        }
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //video is targeting a renderTexture so this does nothing...but..i..cant..stop..myself
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        var rawImage = __instance.GetComponent<RawImage>();
        if (rawImage)
        {
            rawImage.transform.localScale = new Vector3(Plugin.NegativeScaleFactor, 1f, 1f);
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIQuestScreen), nameof(UIQuestScreen.Start))]
    public static void UIQuestScreen_Start(UIQuestScreen __instance)
    {
        var bg = __instance.transform.FindChild("Window");
        if (bg)
        {
            AddAspectRatioFitter(bg.gameObject);
        }
        
        DisableBottomBar(__instance.gameObject);
        
    }
    private static void DisableBottomBar(GameObject go)
    {
        // var bottomBar = go.transform.FindChild("HelpKeysWidget");
        // if (bottomBar)
        // {
        //     var image = bottomBar.GetComponent<Image>();
        //     if (image)
        //     {
        //         image.enabled = false;
        //     }
        // }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIGenomeLayoutScreen), nameof(UIGenomeLayoutScreen.Start))]
    public static void UIGenomeLayoutScreen_Start(UIGenomeLayoutScreen __instance)
    {
        var bg = __instance.transform.FindChild("Background/Window");
        if (bg)
        {
            AddAspectRatioFitter(bg.gameObject);
        }
        
        var closeButton = __instance.transform.FindChild("Background/UICloseButton");
        if (closeButton)
        {
            closeButton.localPosition =  closeButton.localPosition with{x=Plugin.Difference};
        }
        
        DisableBottomBar(__instance.gameObject);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UISettingsScreen), nameof(UISettingsScreen.Start))]
    public static void UISettingsScreen_Start(UISettingsScreen __instance)
    {
        var bg = __instance.transform.FindChild("Background");
        if (bg)
        {
            var rect = bg.GetComponent<RectTransform>();
            if (rect)
            {
                rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
            }
        }

        DisableBottomBar(__instance.gameObject);
        
        AddAspectRatioFitter(__instance.gameObject);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIEndGameScreen), nameof(UIEndGameScreen.Start))]
    public static void UIEndGameScreen_Start(UIEndGameScreen __instance)
    {
        Utils.EnablePillarBoxing();
        AddAspectRatioFitter(__instance.gameObject);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIEndGameScreen), nameof(UIEndGameScreen.OnDestroy))]
    public static void UIEndGameScreen_OnDestroy(UIEndGameScreen __instance)
    {
        Utils.DisablePillarBoxing();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIPrepareGameScreen), nameof(UIPrepareGameScreen.Start))]
    public static void UIPrepareGameScreen_Start(UIPrepareGameScreen __instance)
    {
        DisableBottomBar(__instance.gameObject);
        
        var content = __instance.transform.FindChild("Content");
        if (content)
        {
            var newBackground = new GameObject("Background");
            newBackground.transform.SetParent(content, false);
            newBackground.transform.SetSiblingIndex(0);

            var ogImage = content.GetComponent<Image>();
            if (ogImage)
            {
                var newImage = newBackground.TryAddComponent<Image>();
                newImage.sprite = ogImage.sprite;
                newImage.color = ogImage.color;
                newImage.type = ogImage.type;
                newImage.fillCenter = ogImage.fillCenter;
                newImage.fillMethod = ogImage.fillMethod;
                newImage.fillOrigin = ogImage.fillOrigin;
                newImage.fillAmount = ogImage.fillAmount;
                newImage.preserveAspect = ogImage.preserveAspect;
                newImage.raycastTarget = ogImage.raycastTarget;

                ogImage.enabled = false;
            }

            var arf = AddAspectRatioFitter(newBackground.gameObject);
            arf.aspectRatio = Plugin.MainAspect;
            arf.aspectMode = AspectRatioFitter.AspectMode.EnvelopeParent;

            newBackground.transform.localScale = new Vector3(1.1f, 1.1f, 1f);

            AddAspectRatioFitter(content.gameObject);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIIntelScreen), nameof(UIIntelScreen.Show))]
    public static void UIIntelScreen_Start(UIIntelScreen __instance)
    {
        var content = __instance.transform.FindChild("Content");
        if (content)
        {
            AddAspectRatioFitter(content.gameObject);
            DisableBottomBar(content.gameObject);
        }
        
   
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIStoreScreen), nameof(UIStoreScreen.Start))]
    public static void UIStoreScreen_Start(UIStoreScreen __instance)
    {
        var background = __instance.transform.FindChild("Background");
        if (background)
        {
            var arf = AddAspectRatioFitter(background.gameObject);
            arf.aspectRatio = Plugin.MainAspect;
            arf.aspectMode = AspectRatioFitter.AspectMode.EnvelopeParent;
        }

        DisableBottomBar(__instance.gameObject);
        
        AddAspectRatioFitter(__instance.gameObject);
    }
  

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIDropZoneSelectScreen), nameof(UIDropZoneSelectScreen.Start))]
    public static void UIDropZoneSelectScreen_Start(UIDropZoneSelectScreen __instance)
    {
        var content = __instance.transform.FindChild("Content");
        if (content)
        {
            var background = content.FindChild("Background");
            if (background)
            {
                var arf = AddAspectRatioFitter(background.gameObject);
                arf.aspectRatio = Plugin.MainAspect;
                arf.aspectMode = AspectRatioFitter.AspectMode.EnvelopeParent;
            }

            AddAspectRatioFitter(content.gameObject);
        }
        
        DisableBottomBar(__instance.gameObject);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIPlayerDamageTint), nameof(UIPlayerDamageTint.Update))]
    public static void UIPlayerDamageTint_Update(UIPlayerDamageTint __instance)
    {
        if (__instance.init) return;

        var arf = AddAspectRatioFitter(__instance.gameObject);
        arf.aspectRatio = Plugin.MainAspect;
        arf.aspectMode = AspectRatioFitter.AspectMode.EnvelopeParent;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIBuildInformationHelper), nameof(UIBuildInformationHelper.Start))]
    public static void UIBuildInformationHelper_Start(UIBuildInformationHelper __instance)
    {
        __instance.versionText.text += $" - {Plugin.PluginName} v{Plugin.PluginVersion}";
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIMainMenuHUD), nameof(UIMainMenuHUD.Start))]
    public static void UIMainMenuHUD_Start(UIMainMenuHUD __instance)
    {
        var holder = __instance.transform.FindChild("Holder");
        if (holder)
        {
            var buttons = holder.FindChild("ButtonLinks_Holder");
            if (buttons)
            {
                buttons.gameObject.SetActiveRecursively(false);
            }

            AddAspectRatioFitter(holder.gameObject);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIGunUpgradeScreen), nameof(UIGunUpgradeScreen._Setup))]
    public static void UIGunUpgradeScreen_Setup(UIGunUpgradeScreen __instance)
    {
        var holder = __instance.transform.FindChild("Content");
        AddAspectRatioFitter(holder.gameObject);
        
        DisableBottomBar(__instance.gameObject);
    }

    private static AspectRatioFitter AddAspectRatioFitter(GameObject go)
    {
        var arf = go.TryAddComponent<AspectRatioFitter>();
        arf.aspectRatio = Plugin.NativeAspectRatio;
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        arf.enabled = true;
        return arf;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraAspectRatioHelper), nameof(CameraAspectRatioHelper.GetClosestAspectRatio))]
    public static void CameraAspectRatioHelper_GetClosestAspectRatio(ref float __result)
    {
        __result = Plugin.MainAspect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraAspectRatioHelper), nameof(CameraAspectRatioHelper.Start))]
    public static void CameraAspectRatioHelper_Start(CameraAspectRatioHelper __instance)
    {
        __instance.aspect16_9 = Plugin.MainAspect;
        __instance.aspect16_10 = Plugin.MainAspect;
        __instance.Resize();
    }
}