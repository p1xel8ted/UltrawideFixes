using System;

namespace MegaManDiveOffline;

[Harmony]
[HarmonyWrapSafe]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadingUI), nameof(LoadingUI.ActiveUI))]
    private static void LoadingUI_ActiveUI(ref LoadingUI __instance)
    {
        var bg = __instance.transform.Find("New Game Object");
        if (!bg) return;
        var rect = bg.GetComponent<RectTransform>();
        if (rect)
        {
            rect.sizeDelta = new Vector2(Plugin.SelectedWidth, Plugin.SelectedHeight);
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(StoryStageSelectUI), nameof(StoryStageSelectUI.OnEnable))]
    private static void StoryStageSelectUI_OnEnable(ref StoryStageSelectUI __instance)
    {
        var bg = __instance.transform.Find("Image");
        var rect = bg.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.SelectedWidth, Plugin.SelectedHeight);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraControl), nameof(CameraControl.UpdateCameraFov))]
    private static void CameraControl_UpdateCameraFov(ref CameraControl __instance, ref float p_targetFov)
    {
        p_targetFov = __instance._defaultFov + __instance._defaultFov * (Plugin.FieldOfView.Value / 100f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    private static void GraphicsMenu_Handle(ref CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase))
        {
            __instance.scaleFactor = 1;
        }
        else
        {
            __instance.scaleFactor = Plugin.CustomScale.Value;
        }
    }
}