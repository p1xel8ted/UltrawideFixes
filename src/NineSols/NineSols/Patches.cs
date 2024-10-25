namespace NineSols;

[Harmony]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(RCGUIPanel), nameof(RCGUIPanel.ShowInit))]
    public static void RCGUIPanel_Show(ref RCGUIPanel __instance)
    {
        if (__instance.name is "MenuUIPanel" or "SettingOptionPanel")
        {
            var bg = __instance.transform.Find("Background");
            if (bg)
            {
                bg.gameObject.SetActive(false);
            }
        }

        var bg2 = __instance.transform.Find("Backgound");
        if (bg2)
        {
            var rect = bg2.GetComponent<RectTransform>();
            rect.sizeDelta = rect.sizeDelta with { x = Plugin.MainHeight * 2f, y = Plugin.MainWidth * 2f };
        }

        var bgFade = __instance.transform.Find("BGFade");
        if (bgFade)
        {
            bgFade.transform.localScale = bgFade.localScale with { x = Plugin.PositiveScaleFactor };
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VersionText), nameof(VersionText.StartUnityAnalytics))]
    public static bool VersionText_StartUnityAnalytics()
    {
        return false;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(VersionText), nameof(VersionText.Start))]
    public static void VersionText_Start(VersionText __instance)
    {
        __instance.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIControlButton), nameof(UIControlButton.OnEnable))]
    public static void UIControlButton_OnEnable(UIControlButton __instance)
    {
        if (__instance.name is "MainMenuButton_Credit" or "MainMenuButton_Discord")
        {
            __instance.gameObject.SetActive(false);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CullingManager), nameof(CullingManager.ExtentRect))]
    public static void CullingManager_ExtentRect(ref Rect target, ref float padding)
    {
        target = GetAdjustedRect(target);
        padding = 250;
    }

    private static Rect GetAdjustedRect(Rect baseRect)
    {
        // Only adjust width if the aspect ratio changes
        var adjustedRect = baseRect;

        if (Mathf.Approximately(Plugin.MainAspectRatio, Plugin.BaseAspectRatio)) return adjustedRect;

        // Calculate the new width while keeping the height the same
        var newWidth = baseRect.height * Plugin.MainAspectRatio;
        var widthDifference = newWidth - baseRect.width;

        // Update the adjusted rect with the new width, keeping it centered
        adjustedRect.width = newWidth;
        adjustedRect.x -= widthDifference / 2; // Center the rect horizontally

        return adjustedRect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains("sinai")) return;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResolutionSetting), nameof(ResolutionSetting.IsValidResolution), typeof(int), typeof(int), typeof(int), typeof(int))]
    [HarmonyPatch(typeof(ResolutionSetting), nameof(ResolutionSetting.IsValidResolution), typeof(Resolution))]
    public static void ResolutionSetting_IsValidResolution(ref bool __result)
    {
        __result = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ResolutionSetting), nameof(ResolutionSetting.IsItUltraWideScreen))]
    public static void ResolutionSetting_IsItUltraWideScreen(ref bool __result)
    {
        __result = Plugin.MainAspectRatio > Plugin.BaseAspectRatio;
    }
}