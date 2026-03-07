namespace NeverGrave;

/// <summary>
/// Harmony patches for ultrawide display support, camera aspect ratio correction, and UI scaling.
/// </summary>
[Harmony]
public static class Patches
{
    /// <summary>
    /// Overrides MvUtil.calcCameraAspect to set the camera rect to full screen
    /// instead of the game's default 16:9 pillarboxing. Runs every frame.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MvUtil), nameof(MvUtil.calcCameraAspect))]
    public static void MvUtil_calcCameraAspect(Camera cam)
    {
        if (!cam) return;
        cam.aspect = DisplayMetrics.MainAspect;
        cam.rect = new Rect(0f, 0f, 1f, 1f);
    }

    /// <summary>
    /// Sets CanvasScaler to Expand mode for correct UI scaling on ultrawide displays.
    /// Disables the pillarbox overlay and stretches various background elements
    /// (controller prompt, pause menu, save menu, loading screen) to fill the wider viewport.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        // Disable pillarbox overlay (game misspells it as "LatterBox")
        DisableChild(__instance.transform, "MvImg_LatterBox");

        // Stretch backgrounds to cover ultrawide viewport
        ScaleChildX(__instance.transform, "InfoCtrlRecommend/Img_Bg", 20f);
        ScaleChildX(__instance.transform, "Menu_Save/Img_Black", 20f);
        ScaleChildX(__instance.transform, "Fade/ImgFade", 20f);

        // Pause menu: center and stretch background
        var menuBg = __instance.transform.FindChild("MvUI_MenuBG");
        if (menuBg)
        {
            menuBg.position = menuBg.position with { x = 0f };
            ScaleChildX(menuBg, "Img_Bg", 20f);
        }
    }

    /// <summary>
    /// Overrides the resolution display text to show the native display resolution,
    /// since the game's resolution list only contains 16:9/16:10 options.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MvUI_SettingSelect), nameof(MvUI_SettingSelect.refreshElem))]
    public static void MvUI_SettingSelect_refreshElem(MvUI_SettingSelect __instance, MvUI_SettingSelect.eSettingType type)
    {
        if (type != MvUI_SettingSelect.eSettingType.Resolution) return;
        if (__instance._Txt_Elem_Resolution)
        {
            __instance._Txt_Elem_Resolution.text = $"{DisplayMetrics.MainWidth}x{DisplayMetrics.MainHeight}";
        }
    }

    /// <summary>
    /// Hides the toast when in Hide phase, since its off-screen resting position
    /// was designed to sit behind the now-removed pillarbox bars.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MvToast), nameof(MvToast.lateMove))]
    public static void MvToast_lateMove(MvToast __instance)
    {
        if (!__instance) return;
        var go = __instance.gameObject;
        if (!go) return;
        var shouldHide = __instance._ToastPhase == MvToast.eToastPhase.Hide;
        if (go.activeSelf == shouldHide)
        {
            go.SetActive(!shouldHide);
        }
    }

    /// <summary>
    /// Finds a child transform by path and deactivates its gameObject.
    /// </summary>
    private static void DisableChild(Transform parent, string path)
    {
        var child = parent.FindChild(path);
        if (child)
        {
            child.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Finds a child transform by path and sets its local X scale.
    /// </summary>
    private static void ScaleChildX(Transform parent, string path, float scaleX)
    {
        var child = parent.FindChild(path);
        if (child)
        {
            child.localScale = child.localScale with { x = scaleX };
        }
    }
}
